using System;
using System.Windows.Forms;
using Christmas.Entities;

namespace Christmas.Shopping
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnAddPerson(object sender, EventArgs e)
        {
            var person = new Person();
            person.Name = "Noname Person";

            var node = new TreeNode();
            node.Text = person.Name;
            node.ImageIndex = node.SelectedImageIndex = 1;
            node.Tag = person;

            person.OnUpdate += ( s, data ) => node.Text = person.Name;

            var family = mTreeView.SelectedNode?.Tag as Family;
            if ( family == null )
            {
                mTreeView.Nodes.Add(node);
            }
            else
            {
                mTreeView.SelectedNode.Nodes.Add( node );
            }

        }

        private void OnAddFamily(object sender, EventArgs e)
        {
            var family = new Family();
            family.Name = "Noname Family";

            var node = new TreeNode();
            node.Text = family.Name;
            node.ImageIndex = node.SelectedImageIndex = 2;
            node.Tag = family;

            family.OnUpdate += ( s, data ) => node.Text = family.Name;

            mTreeView.Nodes.Add(node);
        }

        private void OnDoubleClick(object sender, EventArgs e)
        {
            var receiver = mTreeView.SelectedNode?.Tag as Receiver;
            if ( receiver == null ) return;

            var dialog = new ChangeNameForm( receiver.Name );
            if ( dialog.ShowDialog() == DialogResult.OK )
            {
                receiver.Name = dialog.Value;
            }
        }
    }
}
