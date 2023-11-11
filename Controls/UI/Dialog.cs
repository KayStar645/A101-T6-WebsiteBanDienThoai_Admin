namespace Common.UI
{
    public partial class Dialog : Form
    {
        public delegate void OnButtonClick();

        OnButtonClick _OnCancelClick;
        OnButtonClick _OnAgreeClick;
        OnButtonClick _OnOKlClick;

        public Dialog()
        {
            InitializeComponent();
        }

        public void Open(string mess, string? type = "OK", int? timeClose = 3500)
        {
            Label_Mess.Text = mess;

            if (type == "yes_no")
            {
                Button_OK.Visible = false;
            }
            if (type == "OK")
            {
                Button_Agree.Visible = false;
                Button_Cancel.Visible = false;
            }

            Timer_Close.Interval = (int)timeClose;
            Timer_Close.Start();

            ShowDialog();
        }

        private void Timer_Close_Tick(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (_OnOKlClick != null)
            {
                _OnOKlClick();
            }

            Visible = false;
        }

        private void Button_Agree_Click(object sender, EventArgs e)
        {
            if (_OnAgreeClick != null)
            {
                _OnAgreeClick();
            }

            Visible = false;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            if (_OnCancelClick != null)
            {
                _OnCancelClick();
            }

            Visible = false;
        }
    }
}
