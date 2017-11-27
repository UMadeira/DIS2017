using System.Collections.Generic;
using Christmas.Patterns.Observer;

namespace Christmas.Entities
{
    public class Receiver : Subject
    {
        public Receiver()
        {
            Gifts = new List<Gift>();
        }

        private string mName;

        public string Name
        {
            get { return mName; }
            set { mName = value; Notify( this, "Name" ); }
        }

        public ICollection<Gift> Gifts { get; }
    }
}
