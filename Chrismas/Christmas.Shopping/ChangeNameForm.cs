using System.Windows.Forms;

namespace Christmas.Shopping
{
    public partial class ChangeNameForm : Form
    {
        public ChangeNameForm( string aName )
        {
            InitializeComponent();
            mNameTextBox.Text = aName;
        }

        public string Value => mNameTextBox.Text;
    }
}
