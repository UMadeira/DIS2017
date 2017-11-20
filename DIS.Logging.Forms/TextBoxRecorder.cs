using System;
using System.Windows.Forms;

namespace DIS.Logging
{
    public class TextBoxRecorder : IRecorder
    {
        private TextBox TextBox { get; set; }

        public TextBoxRecorder( TextBox aTextBox )
        {
            TextBox = aTextBox;
        }

        #region IRecorder Members

        public void Record( string aMessage )
        {
            TextBox.AppendText( aMessage );
            TextBox.AppendText( Environment.NewLine );
        }

        #endregion
    }
}
