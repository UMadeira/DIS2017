using System.Windows.Forms;
using Christmas.Entities;
using Christmas.Patterns.ObserverCanonical;

namespace Christmas.Shopping
{
    class TreeNodeObserver : TreeNode, IObserver
    {
        public void Update( object sender, object data )
        {
            var receiver = this.Tag as Receiver;
            this.Text = receiver.Name;
        }
    }
}
