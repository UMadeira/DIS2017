using System;
using System.Windows.Forms;
using Christmas.Entities;
using Christmas.Patterns.Commands;
using Christmas.Shopping.Commands;

namespace Christmas.Shopping
{
    public partial class MainForm : Form
    {
        private ICommand Command { get; set; }

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
            TreeNodeCollection collection;

            var family = mTreeView.SelectedNode?.Tag as Family;
            if (family == null)
            {
                collection = mTreeView.Nodes;
            }
            else
            {
                collection = mTreeView.SelectedNode.Nodes;
            }

            var macro = new MacroCommand();

            var command1 = new CommandCreatePerson("Noname Person");
            command1.Execute();
            macro.Add(command1);

            var command2 = new CommandCreateNode(collection, command1.Person);
            macro.Add( command2 );

            CommandsManager.Instance.Execute( macro );
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

        private void OnUndo(object sender, EventArgs e)
        {
            CommandsManager.Instance.Undo();
        }

        private void OnRedo(object sender, EventArgs e)
        {
            CommandsManager.Instance.Redo();
        }
    }
}
