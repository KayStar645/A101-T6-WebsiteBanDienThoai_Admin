using Domain.DTOs;
using Services.Interfaces;
using SimpleInjector;
using WinFormsApp.Services;
using WinFormsApp.View.Screen;

namespace WinFormsApp.View.Auth
{
    public partial class Login : Form
    {
        private readonly Container _container;
        private readonly IAuthService _authService;

        public Login(Container container)
        {
            InitializeComponent();

            _container = container;
            _authService = _container.GetInstance<IAuthService>();
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

                //Program.admin = new Admin();

                thread.CloseThisOpenThat(this, Program.admin);
            }
            else
            {
                Dialog_ThongBao.Show();
            }
        }
    }
}
