using System.Collections.Generic;

namespace DIS.Logging
{
    public class ComposedRecorder : IRecorder
    {
        private readonly IList<IRecorder> mRecoders = new List<IRecorder>();

        public void Append( IRecorder aRecorder )
        {
            if ( mRecoders.Contains( aRecorder ) ) return;
            mRecoders.Add( aRecorder );
        }

        public void Remove( IRecorder aRecorder )
        {
            if ( ! mRecoders.Contains( aRecorder ) ) return;
            mRecoders.Remove( aRecorder );
        }

        #region IRecorder Members

        public void Record( string aMessage )
        {
            foreach ( var recorder in mRecoders )
                recorder.Record( aMessage );
        }

        #endregion
    }
}
