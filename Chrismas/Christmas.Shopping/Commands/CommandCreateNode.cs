using System.Windows.Forms;
using Christmas.Patterns.Commands;
using Christmas.Patterns.Observer;

namespace Christmas.Shopping.Commands
{
    public class CommandCreateNode : ICommand
    {
        public CommandCreateNode( TreeNodeCollection aNodes, int aImage, ISubject aSubject )
        {
            Nodes = aNodes;

            Node = new TreeNode { Text = aSubject.ToString() };
            Node.ImageIndex = Node.SelectedImageIndex = aImage;
            Node.Tag = aSubject;

            aSubject.OnUpdate += ( sender, data ) => Node.Text = aSubject.ToString();
        }

        public TreeNodeCollection Nodes { get; }

        public TreeNode Node { get; }

        public void Execute()
        {
            Nodes.Add( Node );
        }

        public void Undo()
        {
            Nodes.Remove( Node );
        }

        public void Redo()
        {
            Execute();
        }
    }
}
