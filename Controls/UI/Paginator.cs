using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;

namespace Controls.UI
{
    public partial class Paginator : UserControl
    {
        public delegate void OnClickItemCallBack(int currPage);
        public OnClickItemCallBack _onClickItem;

        int _pageNumber = 0;
        int _currPage = 0;

        public Paginator(int pageNumber, int currPage, OnClickItemCallBack onClickItemCallBack)
        {
            InitializeComponent();
            _pageNumber = pageNumber;
            _currPage = currPage;
            _onClickItem = onClickItemCallBack;

            Pagination();
        }

        private void Pagination()
        {
            FlowLayoutPanel_Container.Controls.Clear();

            for (int i = 1; i <= _pageNumber; i++)
            {
                FlowLayoutPanel_Container.Controls.Add(Button(i.ToString()));
            }

            if (_pageNumber > 0)
            {
                Guna2Button btn = (Guna2Button)FlowLayoutPanel_Container.Controls[_currPage - 1];
                btn.FillColor = Color.RoyalBlue;
                btn.ForeColor = Color.White;
            }
        }

        private Guna2Button Button(string text)
        {
            Guna2Button btn = new();
            CustomizableEdges edge1 = new();
            CustomizableEdges edge2 = new();

            btn.BorderRadius = 5;
            btn.CustomizableEdges = edge1;
            btn.DisabledState.BorderColor = Color.DarkGray;
            btn.DisabledState.CustomBorderColor = Color.DarkGray;
            btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn.FillColor = Color.LightGray;
            btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn.ForeColor = Color.Black;
            btn.Location = new Point(3, 3);
            btn.Margin = new Padding(3, 3, 5, 3);
            btn.ShadowDecoration.CustomizableEdges = edge2;
            btn.Size = new Size(40, 40);
            btn.TabIndex = 1;
            btn.Text = text;
            btn.Click += Btn_Click;

            return btn;
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender!;

            Guna2Button prevBtn = (Guna2Button)FlowLayoutPanel_Container.Controls[_currPage - 1];

            prevBtn.FillColor = Color.LightGray;
            prevBtn.ForeColor = Color.White;

            _currPage = int.Parse(button.Text);

            button.FillColor = Color.RoyalBlue;
            button.ForeColor = Color.White;

            _onClickItem(_currPage);
        }
    }
}
