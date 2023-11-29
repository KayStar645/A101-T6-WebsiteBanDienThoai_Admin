using AutoMapper;
using Database.Common;
using Database.Interfaces;
using Domain.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Services.Constants;
using Services.Interfaces;
using Services.Interfaces.Common;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Services.Services
{
    public class AuthService : IAuthService, IService
    {
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;
        private readonly IPasswordHasher<UserDto> _passwordHasher;
        private readonly IEmployeeRepository _employeeRepo;

        public AuthService(IUserRepository userRepository, IMapper mapper,
                           IPasswordHasher<UserDto> passwordHasher, IEmployeeRepository employeeRepository) 
        {
            _userRepo = userRepository;
            _mapper = mapper;
            _passwordHasher = passwordHasher;
            _employeeRepo = employeeRepository;
        }

        public async Task<int> CreateAccount(UserDto pUser)
        {
            try
            {
                var hashedPassword = _passwordHasher.HashPassword(pUser, pUser.Password);
                pUser.Password = hashedPassword;

                var user = _mapper.Map<Domain.Entities.User>(pUser);
                var result = await _userRepo.AddAsync(user);

                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<bool> Login(UserDto pUser)
        {
            try
            {
                var result = await _userRepo.FindByNameAsync(pUser.UserName);

                var user = _mapper.Map<UserDto>(result);

                if(result == null)
                {
                    return false;
                }

                var accuracy = _passwordHasher.VerifyHashedPassword(user, user.Password, pUser.Password);
                if(accuracy == PasswordVerificationResult.Success)
                {
                    JwtSecurityToken jwtSecurityToken = await GenerateToken(result);
                    string token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

                    LibrarySettings.Default.UserId = result.Id;
                    LibrarySettings.Default.UserName = result.UserName;
                    LibrarySettings.Default.Token = token;

                    LibrarySettings.Default.Save();

                    return true;
                }

                return false;
            }
            catch { return false; }
        }

        public void Logout()
        {
            LibrarySettings.Default.UserId = 0;
            LibrarySettings.Default.UserName = string.Empty;
            LibrarySettings.Default.Token = string.Empty;

        }

        private async Task<JwtSecurityToken> GenerateToken(Domain.Entities.User user)
        {
            //var roles = await _userRepo.GetRolesAsync(user);
            //var permissions = await _userRepo.GetPermissionsAsync(user);

            //var roleClaims = roles.Select(role => new Claim(ClaimTypes.Role, role.Name));
            //var permissionClaims = permissions.Select(permission => new Claim(CONSTANT_CLAIM_TYPES.Permission, permission.Name));

            // Lấy nhân viên
            var employee = await _employeeRepo.FindByInternalCodesync(user.UserName);
            var employeeDto = _mapper.Map<EmployeeDto>(employee); 
            string userObject = JsonConvert.SerializeObject(employeeDto);

            var claims = new[]
            {
                new Claim(CONSTANT_CLAIM_TYPES.Uid, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(CONSTANT_CLAIM_TYPES.User, userObject),
            };
            //.Union(permissionClaims)
            //.Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(DatabaseCommon.JwtSettings_Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: DatabaseCommon.JwtSettings_Issuer,
                audience: DatabaseCommon.JwtSettings_Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(int.Parse(DatabaseCommon.JwtSettings_DurationInMinutes)),
                signingCredentials: signingCredentials);
            return jwtSecurityToken;
        }
    }
}
