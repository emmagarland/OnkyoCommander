using System;
using System.Diagnostics;
using System.Web.Http;
using System.Web.Http.Results;
using eg.Onkyo.API.Models;
using eg.Onkyo.API.Properties;
using eg.Onkyo.Communicator;

namespace eg.Onkyo.API.Controllers
{
    public class OnkyoController : ApiController
    {
        private readonly OnkyoCommanderSettings _settings;
        private readonly OnkyoCommunicator _communicator;

        /// <summary>
        /// Parameterless constructor to setup the Onkyo Commander instance
        /// </summary>
        public OnkyoController()
        {
            _settings = new OnkyoCommanderSettings(Settings.Default.IPAddress, Settings.Default.Port, Settings.Default.Timeout);
            _communicator = _settings.Communicator;
        }

        /// <summary>
        /// Sends a custom command to the Onkyo
        /// </summary>
        /// <param name="value"></param>
        public IHttpActionResult SendCustomCommand([FromBody] string value)
        {
            _communicator.SendCommand(value);
            return Ok(value);
        }

        /// <summary>
        /// Sends a custom volume button increase
        /// </summary>
        /// <param name="volumeAmount">The amount to increase the volume by</param>
        public IHttpActionResult IncreaseVolumeCustom([FromBody] string volumeAmount)
        {
            try
            {
                var volume = int.Parse(volumeAmount);
                _communicator.ParseVolumeCommand(OnkyoCommands.MasterVolumeCustom, volume);
            }
            catch (Exception exception)
            {
                return new BadRequestErrorMessageResult($"There has been an issue: {exception.Message}", this);
            }
            return Ok(volumeAmount);
        }

        /// <summary>
        /// Increases the volume by 1
        /// </summary>
        public IHttpActionResult IncreaseVolume()
        {            
            _communicator.SendCommand(OnkyoCommands.MasterVolumeUp);
            return Ok();
        }

        /// <summary>
        /// Decreases the volume by 1
        /// </summary>
        public IHttpActionResult DecreaseVolume()
        {
            _communicator.SendCommand(OnkyoCommands.MasterVolumeDown);
            return Ok();
        }

        /// <summary>
        /// Powers off the Onkyo
        /// </summary>
        public IHttpActionResult PowerOff()
        {
            _communicator.SendCommand(OnkyoCommands.Poweroff);
            return Ok();
        }

        /// <summary>
        /// Powers on the Onkyo
        /// </summary>
        public IHttpActionResult PowerOn()
        {
            _communicator.SendCommand(OnkyoCommands.Poweron);
            return Ok();
        }
    }
}