using System;
using System.Net;
using System.Windows.Forms;
using eg.Onkyo.API.Controllers;
using eg.Onkyo.Commander.Properties;
using eg.Onkyo.Communicator;

namespace eg.Onkyo.Commander
{
    public partial class OnkyoCommander : Form
    {
        private OnkyoController _controller;

        public OnkyoCommander()
        {
            InitializeComponent();
            Setup();
        }

        /// <summary>
        /// Sets up the Onkyo Commander instance
        /// </summary>
        private void Setup()
        {
            try
            {
                _controller = new OnkyoController();
            }
            catch (Exception exception)
            {
                Console.WriteLine($@"Setup: {Resources.ErrorMessageVolume1}{exception}");
                throw;
            }           
        }

        /// <summary>
        /// Handles the custom Onkyo button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOnkyoInitiate_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.SendCustomCommand(tbCommandText.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine($@"CustomCommand: {Resources.ErrorMessageVolume1}{exception}");
                throw;
            }
        }

        /// <summary>
        /// Handles the volume down button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.DecreaseVolume();
            }
            catch (Exception exception)
            {
                Console.WriteLine($@"VolumeDown: {Resources.ErrorMessageVolume1}{exception}");
                throw;
            }
        }

        /// <summary>
        /// Handles the volume up button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.IncreaseVolume();
            }
            catch (Exception exception)
            {
                Console.WriteLine($@"VolumeUp: {Resources.ErrorMessageVolume1}{exception}");
                throw;
            }
        }

        /// <summary>
        /// Handles the custom volume button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolume_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.IncreaseVolumeCustom(tbVolumeNumber.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine($@"VolumeCustom: {Resources.ErrorMessageVolume1}{exception}");
                throw;
            }
        }

        /// <summary>
        /// Handles the button on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOn_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.PowerOn();
            }
            catch (Exception exception)
            {
                Console.WriteLine($@"Button On: {Resources.ErrorMessageVolume1}{exception}");
                throw;
            }
        }

        /// <summary>
        /// Handles the button off click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOff_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.PowerOff();
            }
            catch (Exception exception)
            {
                Console.WriteLine($@"Button Off: {Resources.ErrorMessageVolume1}{exception}");
                throw;
            }
        }
    }
}
