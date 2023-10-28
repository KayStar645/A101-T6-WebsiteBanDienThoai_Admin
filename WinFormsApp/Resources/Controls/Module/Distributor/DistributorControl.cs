﻿using Domain.DTOs;
using Guna.UI2.WinForms;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Distributor
{
    public partial class DistributorControl : UserControl
    {
        private readonly IDistributorService _distributorService;

        public static Guna2Button refreshButton = new Guna2Button();

        public DistributorControl()
        {
            InitializeComponent();

            DataGridView_Listing.DataSource = _distributorService.GetList();

            refreshButton = Button_Refresh;
        }

        public DistributorControl(List<DistributorDto> distributors)
        {
            InitializeComponent();

            LoadData(distributors);

            refreshButton = Button_Refresh;
        }

        public void LoadData(List<DistributorDto> distributors)
        {
            DataGridView_Listing.DataSource = distributors;
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            Util.LoadForm(new DistributorForm());
        }

        private void DataGridView_Listing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection selected = DataGridView_Listing.CurrentRow.Cells;
            DistributorDto formData = new()
            {
                Id = int.Parse(selected["Id"].FormattedValue.ToString()),
                InternalCode = selected["InternalCode"].FormattedValue.ToString(),
                Name = selected["_Name"].FormattedValue.ToString(),
                Address = selected["Address"].FormattedValue.ToString(),
                Phone = selected["Phone"].FormattedValue.ToString(),
            };

            if (e.ColumnIndex == 0)
            {
                Util.LoadForm(new DistributorForm(formData), true);
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = Dialog_Confirm.Show();

                if(dialogResult != DialogResult.Yes)
                {
                    return;
                }

                _distributorService.Delete(formData.Id);
                Button_Refresh.PerformClick();
            }
        }

        private async void Button_Refresh_Click(object sender, EventArgs e)
        {
            var result = await _distributorService.GetList();
            LoadData(result.list);
        }
    }
}
