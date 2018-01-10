using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Christmas.Entities;
using Christmas.Patterns.Commands;

namespace Christmas.Shopping.Commands
{
    public class CommandCreateNode : ICommand
    {
        public CommandCreateNode( TreeNodeCollection aNodes, Receiver aReceiver )
        {
            Nodes = aNodes;

            Node = new TreeNode();
            Node.Text = aReceiver.Name;
            Node.ImageIndex = Node.SelectedImageIndex = 1;
            Node.Tag = aReceiver;

            aReceiver.OnUpdate += ( sender, data ) => Node.Text = aReceiver.Name;
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
