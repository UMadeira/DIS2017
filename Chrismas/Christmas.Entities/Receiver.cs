using System.Collections.Generic;
using Christmas.Patterns.Observer;

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
            get => mName;
            set { mName = value;  OnUpdate?.Invoke( this, nameof(Name) ); }
        }

        public ICollection<Gift> Gifts { get; }

        public override string ToString() => Name;
    }
}
