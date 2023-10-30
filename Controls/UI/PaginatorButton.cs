namespace Controls.UI
{
    public partial class PaginatorButton : UserControl
    {
        public string _text = "";

        public PaginatorButton(string text, EventHandler customClick)
        {
            InitializeComponent();

            _text = text;

            Btn_Container.Text = _text;
            Btn_Container.Click += customClick;
        }
    }
}
