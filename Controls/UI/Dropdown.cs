using Controls.Type;
using System.Xml.Linq;

namespace Controls.UI
{
    public partial class Dropdown : UserControl
    {
        private List<DropdownType> options = new();

        public List<DropdownType> Options { get => options; set => options = value; }


        public Dropdown()
        {
            InitializeComponent();
        }

        public Dropdown(List<DropdownType> options)
        {
            InitializeComponent();

            this.options = options;
        }


        private void LoadOptions()
        {
            foreach (DropdownType option in options)
            {
                
            }
        }
    }
}
