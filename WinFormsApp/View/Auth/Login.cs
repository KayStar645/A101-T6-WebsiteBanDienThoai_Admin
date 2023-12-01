using Domain.DTOs;
using Services.Interfaces;
using WinFormsApp.Services;
using WinFormsApp.View.Screen;

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

                Admin admin = new();

                await admin.LoadCategory();

                thread.CloseThisOpenThat(this, admin);
            }
            else
            {
                Dialog_ThongBao.Show();
            }
        }
    }
}
