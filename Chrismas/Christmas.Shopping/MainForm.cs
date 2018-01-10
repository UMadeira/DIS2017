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
            CommandsManager.Instance.Notify += (s, a) => mUndoButton.Enabled = mUndoMenuItem.Enabled = CommandsManager.Instance.HasUndo;
            CommandsManager.Instance.Notify += (s, a) => mRedoButton.Enabled = mRedoMenuItem.Enabled = CommandsManager.Instance.HasRedo;
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnAddPerson(object sender, EventArgs e)
        {
            var family = mTreeView.SelectedNode?.Tag as Family;
            var collection = family == null ? mTreeView.Nodes : mTreeView.SelectedNode.Nodes;

            var macro = new MacroCommand();

            var command1 = new CommandCreatePerson("Noname Person");
            command1.Execute();
            macro.Add(command1);

            var command2 = new CommandCreateNode( collection, 1, command1.Person );
            macro.Add( command2 );

            CommandsManager.Instance.Execute( macro );
        }

        private void OnAddFamily(object sender, EventArgs e)
        {
            var macro = new MacroCommand();

            var command1 = new CommandCreateFamily("Noname Family");
            command1.Execute();
            macro.Add(command1);

            var command2 = new CommandCreateNode( mTreeView.Nodes, 2, command1.Family );
            macro.Add(command2);

            CommandsManager.Instance.Execute(macro);
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

        private void OnBeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {

        }

        private void OnAfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {

        }
    }
}
