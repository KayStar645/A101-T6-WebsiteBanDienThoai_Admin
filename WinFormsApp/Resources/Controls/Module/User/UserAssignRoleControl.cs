﻿using Controls.UI;
using Domain.DTOs;
using Guna.UI2.WinForms;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.User
{
    public partial class UserAssignRoleControl : UserControl
    {
        private readonly IAuthService _AuthService;
        public static Guna2Button _refreshButton = new Guna2Button();
        List<UserDto> _result;

        public UserAssignRoleControl()
        {

            InitializeComponent();

            _AuthService = Program.container.GetInstance<IAuthService>();

            _refreshButton = Button_Refresh;

            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            _refreshButton = Button_Refresh;


            await LoadData();
        }

        private async void Button_Paginator_Click(int page)
        {
            await LoadData();
        }

        public async Task LoadData()
        {
            _result = await _AuthService.GetList();

            DataGridView_Listing.DataSource = _result;
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            Util.LoadForm(new UserAssignRoleForm(), true);
        }

        private async void Button_Refresh_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void Text_Search_TextChanged(object sender, EventArgs e)
        {
            Timer_Debounce.Start();
        }

        private async void Timer_Debounce_Tick(object sender, EventArgs e)
        {
            await LoadData();

            Timer_Debounce.Stop();
        }

        private void DataGridView_Listing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           string name = DataGridView_Listing.CurrentRow.Cells["UserName"].Value.ToString()!;

            if (e.ColumnIndex == 0)
            {
                Util.LoadForm(new UserAssignRoleForm(name), true);
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = Dialog_Confirm.Show();

                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }

                Button_Refresh.PerformClick();
            }
        }
    }
}
