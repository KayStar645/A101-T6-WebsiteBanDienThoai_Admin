﻿using Common;
using Common.UI;
using Domain.DTOs;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Promotion
{
    public partial class PromotionDetailControl : UserControl
    {
        IPromotionService _promotionService;
        PromotionDto _promotion = new();
        Dialog _dialog = new();

        public PromotionDetailControl()
        {
            InitializeComponent();

            _promotionService = Program.container.GetInstance<IPromotionService>();

            LoadInfo();
        }

        public PromotionDetailControl(int promotionId)
        {
            InitializeComponent();

            _promotion.Id = promotionId;

            _promotionService = Program.container.GetInstance<IPromotionService>();

            LoadInfo();
        }

        private async void LoadInfo()
        {
            LoadType();

            if (_promotion.Id > 0)
            {
                var result = await _promotionService.GetDetail(_promotion.Id);

                _promotion = result;

                Label_Discount.Text = ComboBox_Type.Text;
                Text_Name.Text = _promotion.Name;
                Text_InternalCode.Text = _promotion.InternalCode;
                Text_Status.Text = Domain.Entities.Promotion.GetStatusMapping(_promotion.Status).FirstOrDefault().statusName;
                DateTime_Start.Value = _promotion.Start;
                DateTime_End.Value = _promotion.End;
                ComboBox_Type.SelectedValue = _promotion.Type;

                if (result.Type == Domain.Entities.Promotion.TYPE_PERCENT)
                {
                    Text_Discount.Text = _promotion.Percent.ToString();
                    Text_DiscountMax.Text = Util.AddCommas(_promotion.DiscountMax);
                    Label_DiscountMax.Text = "Giảm giá tối đa";
                }
                else
                {
                    Text_Discount.Text = Util.AddCommas(_promotion.Discount);
                    Text_DiscountMax.Text = Util.AddCommas(_promotion.PercentMax);
                    Label_DiscountMax.Text = "Giảm phần trăm tối đa";
                }

                if (result.Status == Domain.Entities.Promotion.STATUS_APPROVED)
                {
                    Button_Save.Visible = false;
                    Button_Approve.Visible = false;

                    DisableAll();
                }
                else if (result.Status == Domain.Entities.Promotion.STATUS_CANCEL)
                {
                    Button_Cancel.Visible = false;
                    Button_Save.Visible = false;
                    Button_Approve.Visible = false;

                    DisableAll();
                }
            }
            else
            {
                DateTime_Start.Value = DateTime.Now;
                DateTime_End.Value = DateTime.Now;
                Text_Status.Text = "Nháp";
                Button_Cancel.Visible = false;
                Button_Approve.Visible = false;
            }
        }

        private void DisableAll()
        {
            Text_InternalCode.Enabled = false;
            Text_Name.Enabled = false;
            Text_Discount.Enabled = false;
            Text_DiscountMax.Enabled = false;
            DateTime_End.Enabled = false;
            DateTime_Start.Enabled = false;
            ComboBox_Type.Enabled = false;
        }

        private void LoadType()
        {
            ComboBox_Type.DataSource = Constant.promotionTypes;
            ComboBox_Type.DisplayMember = "label";
            ComboBox_Type.ValueMember = "value";
            ComboBox_Type.StartIndex = -1;
        }

        private void GetForm()
        {
            _promotion.Name = Text_Name.Text;
            _promotion.InternalCode = Text_InternalCode.Text;
            _promotion.End = DateTime_End.Value;
            _promotion.Start = DateTime_Start.Value;
            _promotion.Type = (string?)ComboBox_Type.SelectedValue;

            if (_promotion.Type == Domain.Entities.Promotion.TYPE_PERCENT)
            {
                _promotion.Percent = int.Parse(Text_Discount.Text == string.Empty ? "0" : Text_Discount.Text);
                _promotion.DiscountMax = int.Parse(Util.DeleteCommas(Text_DiscountMax.Text == string.Empty ? "0" : Text_DiscountMax.Text));
            }
            else
            {
                _promotion.Discount = int.Parse(Util.DeleteCommas(Text_Discount.Text == string.Empty ? "0" : Text_Discount.Text));
                _promotion.PercentMax = int.Parse(Util.DeleteCommas(Text_DiscountMax.Text == string.Empty ? "0" : Text_DiscountMax.Text));
            }
        }

        private async void Button_Save_Click(object sender, EventArgs e)
        {
            GetForm();
            try
            {
                if (_promotion.Id > 0)
                {
                    await _promotionService.Update(_promotion);
                }
                else
                {
                    await _promotionService.Create(_promotion);
                }

                Util.LoadControl(this, new PromotionControl());
                Util.LoadControl(this, new PromotionControl());
            }
            catch (Exception ex)
            {
                Dialog_Notification.Show(ex.Message);
            }
        }

        private async void Button_Approve_Click(object sender, EventArgs e)
        {
            await _promotionService.Approve(_promotion.Id, Domain.Entities.Promotion.STATUS_APPROVED);

            Util.LoadControl(this, new PromotionControl());
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            _dialog._OnAgreeClick = OnAgreeCancel;

            _dialog.Open("Bạn có chắc muốn hủy chương trình khuyến mãi này không ?", "yes_no");
        }

        private async void OnAgreeCancel()
        {
            await _promotionService.Approve(_promotion.Id, Domain.Entities.Promotion.STATUS_CANCEL);

            Util.LoadControl(this, new PromotionControl());
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Util.LoadControl(this, new PromotionControl());
        }

        private void ComboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Type.ValueMember != string.Empty && ComboBox_Type.SelectedIndex > -1)
            {
                Label_Discount.Visible = true;
                Text_Discount.Visible = true;
                Label_Discount.Text = ComboBox_Type.Text;
                Text_Discount.PlaceholderText = ComboBox_Type.Text;

                Label_DiscountMax.Visible = true;
                Text_DiscountMax.Visible = true;

                if (ComboBox_Type.SelectedValue == Domain.Entities.Promotion.TYPE_DISCOUNT)
                {
                    Label_DiscountMax.Text = "Giảm phần trăm tối đa";
                    Text_DiscountMax.PlaceholderText = "Giảm phần trăm tối đa";
                }
                else
                {
                    Label_DiscountMax.Text = "Giảm giá tối đa";
                    Text_DiscountMax.PlaceholderText = "Giảm giá tối đa";
                }
            }
        }
    }
}
