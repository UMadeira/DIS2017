using System.Windows.Forms;
using Christmas.Entities;
using Christmas.Patterns.ObserverCanonical;

namespace Christmas.Shopping
{
    internal class TreeNodeObserver : TreeNode, IObserver
    {
        public void Update( object sender, object data )
        {
            var receiver = Tag as Receiver;
            Text = receiver?.Name ?? string.Empty;
        }
    }
}
