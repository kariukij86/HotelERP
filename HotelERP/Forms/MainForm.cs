using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace HotelERP
{
    public partial class MainForm : Form
    {
        static MainForm _obj;
        public Panel MainPanel
        {
            get { return MainContent; }
            set { MainContent = value; }
        }
        public MainForm()
        {
            InitializeComponent();
        }
        public static MainForm instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = Framework.provider.GetService<MainForm>();
                }
                return _obj;
            }
        }
    }
}
