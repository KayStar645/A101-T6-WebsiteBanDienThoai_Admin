using AutoMapper;
using Database.Common;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Services.Constants;
using Services.Interfaces;
using Services.Interfaces.Common;
using Services.Middleware;
using Services.Transform;
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

        [RequirePermission("Account.View")]
        public async Task<List<UserDto>> GetList()
        {
            if (CustomMiddleware.CheckPermission("Account.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _userRepo.GetAllAsync();

            return _mapper.Map<List<UserDto>>(result.list);
        }

        [RequirePermission("Account.View")]
        public async Task<UserDto> GetDetail(string pUserName)
        {
            if (CustomMiddleware.CheckPermission("Account.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _userRepo.FindByNameAsync(pUserName);
            var userDto = _mapper.Map<UserDto>(result);
            userDto.Roles = await _userRepo.GetRoleByUserName(pUserName);

            return _mapper.Map<UserDto>(result);
        }

        [RequirePermission("Account.Create")]
        public async Task<int> CreateAccount(UserDto pUser)
        {
            if (CustomMiddleware.CheckPermission("Account.Create") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
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

                    var employee = jwtSecurityToken.Claims
                                                .Where(claim => claim.Type == CONSTANT_CLAIM_TYPES.User)
                                                .Select(claim => claim.Value).FirstOrDefault();
                    LibrarySettings.Default.Employee = employee;


                    var permissionClaim = jwtSecurityToken.Claims
                                                .Where(claim => claim.Type == CONSTANT_CLAIM_TYPES.Permission)
                                                .Select(claim => claim.Value)
                                                .ToList();
                    LibrarySettings.Default.Permission = string.Join(",", permissionClaim);

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
            var permissions = await _userRepo.GetPermissionsByUserAsync(user.UserName);
            var permissionClaims = permissions.Select(permission => new Claim(CONSTANT_CLAIM_TYPES.Permission, permission));

            // Lấy nhân viên
            var employee = await _employeeRepo.FindByInternalCodesync(user.UserName);
            var employeeDto = _mapper.Map<EmployeeDto>(employee); 
            string userObject = JsonConvert.SerializeObject(employeeDto);

            var claims = new[]
            {
                new Claim(CONSTANT_CLAIM_TYPES.Uid, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(CONSTANT_CLAIM_TYPES.User, userObject),
            }
            .Union(permissionClaims);

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
