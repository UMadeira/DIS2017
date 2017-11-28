using System.Collections.Generic;
using Christmas.Patterns.Observer2;

namespace Christmas.Entities
{
    public class Receiver : ISubject
    {
        public event UpdateHandler OnUpdate;

        public Receiver()
        {
            Gifts = new List<Gift>();
        }

        private string mName;

        public string Name
        {
            get { return mName; }
            set { mName = value;  OnUpdate?.Invoke( this, "Name"); }
        }

        public ICollection<Gift> Gifts { get; }
    }
}
