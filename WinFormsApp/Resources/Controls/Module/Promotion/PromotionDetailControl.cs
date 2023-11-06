using Domain.DTOs;
using Services.Interfaces;
using WinFormsApp.Services;

namespace WinFormsApp.Resources.Controls.Module.Promotion
{
    public partial class PromotionDetailControl : UserControl
    {
        IPromotionService _promotionService;
        PromotionDto _promotion = new PromotionDto();

        public PromotionDetailControl()
        {
            InitializeComponent();

            _promotionService = Program.container.GetInstance<IPromotionService>();
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
            if(_promotion.Id > 0)
            {
                var result = await _promotionService.GetDetail(_promotion.Id);

                _promotion = result;

                Text_Name.Text = _promotion.Name;
                Text_InternalCode.Text = _promotion.InternalCode;
                DateTime_Start.Value = _promotion.Start;
                DateTime_End.Value = _promotion.End;
                ComboBox_Status.SelectedValue = _promotion.Status;
            }
            else
            {
                DateTime_Start.Value = DateTime.Now;
                DateTime_End.Value = DateTime.Now;
            }

        }

        private async void Button_Save_Click(object sender, EventArgs e)
        {
            _promotion.Name = Text_Name.Text;
            _promotion.InternalCode = Text_InternalCode.Text;
            _promotion.End = DateTime_End.Value;
            _promotion.Start = DateTime_Start.Value;

            if (_promotion.Id > 0)
            {
                await _promotionService.Update(_promotion);
            }
            else 
            { 

            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Util.LoadControl(this, new PromotionControl());
        }

        private void ComboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
