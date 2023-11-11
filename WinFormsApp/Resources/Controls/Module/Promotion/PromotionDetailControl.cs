using Common;
using Domain.DTOs;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Promotion
{
    public partial class PromotionDetailControl : UserControl
    {
        IPromotionService _promotionService;
        PromotionDto _promotion = new();

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
            LoadStatus();
            LoadType();

            if (_promotion.Id > 0)
            {
                var result = await _promotionService.GetDetail(_promotion.Id);

                _promotion = result;

                Text_Name.Text = _promotion.Name;
                Text_InternalCode.Text = _promotion.InternalCode;
                DateTime_Start.Value = _promotion.Start;
                DateTime_End.Value = _promotion.End;
                ComboBox_Status.SelectedValue = _promotion.Status;
                ComboBox_Type.SelectedValue = _promotion.Type;
                Text_MinPrice.Text = _promotion.PercentMax.ToString();
                Label_Discount.Text = ComboBox_Type.Text;
                Text_Discount.Text = _promotion.Discount.ToString();
            }
            else
            {
                DateTime_Start.Value = DateTime.Now;
                DateTime_End.Value = DateTime.Now;
                ComboBox_Status.SelectedValue = Domain.Entities.Promotion.STATUS_DRAFT;
                ComboBox_Status.Enabled = false;
            }

        }

        private void LoadStatus()
        {
            ComboBox_Status.DataSource = Constant.promotionStatuses;
            ComboBox_Status.DisplayMember = "label";
            ComboBox_Status.ValueMember = "value";
            ComboBox_Status.StartIndex = -1;
        }

        private void LoadType()
        {
            ComboBox_Type.DataSource = Constant.promotionTypes;
            ComboBox_Type.DisplayMember = "label";
            ComboBox_Type.ValueMember = "value";
            ComboBox_Type.StartIndex = -1;
        }

        private async void Button_Save_Click(object sender, EventArgs e)
        {
            _promotion.Name = Text_Name.Text;
            _promotion.InternalCode = Text_InternalCode.Text;
            _promotion.End = DateTime_End.Value;
            _promotion.Start = DateTime_Start.Value;
            _promotion.Type = (string?)ComboBox_Type.SelectedValue;
            _promotion.Status = (string?)ComboBox_Status.SelectedValue;
            _promotion.PercentMax = int.Parse(Text_MinPrice.Text);
            _promotion.Discount = int.Parse(Text_Discount.Text);

            if (_promotion.Id > 0)
            {
                await _promotionService.Update(_promotion);
            }
            else
            {
                await _promotionService.Create(_promotion);
            }

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

                Text_Discount.Enabled = true;
                Text_Discount.PlaceholderForeColor = Color.FromArgb(193, 200, 207);
                Text_Discount.BorderColor = Color.FromArgb(213, 218, 223);
                Text_Discount.FillColor = Color.White;
                Text_Discount.ForeColor = Color.Black;
                Text_Discount.HoverState.BorderColor = Color.FromArgb(94, 148, 255);

                Label_Discount.Text = ComboBox_Type.Text;
                Text_Discount.PlaceholderText = ComboBox_Type.Text;
            }
        }
    }
}
