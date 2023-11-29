using Domain.DTOs;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.View.Auth
{
    public partial class Login : Form
    {
        private readonly IAuthService _authService;

        public Login()
        {
            InitializeComponent();

            _authService = Program.container.GetInstance<IAuthService>();
        }

        private async void Btn_Login_Click(object sender, EventArgs e)
        {
            bool login = await _authService.Login(new UserDto
            {
                UserName = Txt_Account.Text,
                Password = Txt_Password.Text,
            });

            if (login)
            {
                MyThread thread = new();

                thread.CloseThisOpenThat(this, Program.admin);
            }
            else
            {
                Dialog_ThongBao.Show();
            }
        }
    }
}
