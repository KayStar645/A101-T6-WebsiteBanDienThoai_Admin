﻿using Domain.DTOs;
using Services.Interfaces;
using WinFormsApp.Services;
using WinFormsApp.View.Screen;

namespace WinFormsApp.Resources.Controls.Module.Configuration
{
    public partial class CategoryForm : Form
    {
        private readonly ICategoryService _categoryService;

        CategoryDto _formData = new CategoryDto();

        public CategoryForm()
        {
            InitializeComponent();

            _categoryService = Program.container.GetInstance<ICategoryService>();

            OnInit();
        }

        public CategoryForm(CategoryDto formData)
        {
            InitializeComponent();

            _categoryService = Program.container.GetInstance<ICategoryService>();

            _formData = formData;

            LoadData();

            OnInit();
        }

        private void OnInit()
        {
            if (!Util.CheckPermission("Configuration.Update"))
            {
                Button_Save.Visible = false;
            }
        }

        public void LoadData()
        {
            ClearForm();

            Text_Name.Text = _formData.Name;
            Text_InternalCode.Text = _formData.InternalCode;

            Label_Heading.Text = "Cập nhập danh mục " + _formData.Name;
        }

        private void ClearForm()
        {
            Text_Name.Clear();
            Text_InternalCode.Clear();
        }

        private async void Button_Save_Click(object sender, EventArgs e)
        {
            _formData.Name = Text_Name.Text;
            _formData.InternalCode = Text_InternalCode.Text;

            try
            {
                if (_formData.Id != 0)
                {
                    await _categoryService.Update(_formData);
                }
                else
                {
                    await _categoryService.Create(_formData);
                }

                ConfigurationControl._refreahCategoryButton.PerformClick();
                Admin._refreshCategoryBtn.PerformClick();

                Close();
            }
            catch (Exception ex)
            {
                Dialog_Notification.Show(ex.Message);
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
