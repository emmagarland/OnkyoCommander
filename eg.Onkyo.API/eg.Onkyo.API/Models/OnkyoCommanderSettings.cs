using System;
using System.Net;
using eg.Onkyo.Communicator;

namespace eg.Onkyo.API.Models
{
    public class OnkyoCommanderSettings
    {

        /// <summary>
        /// Sets up the settings for Onkyo Communications
        /// </summary>
        /// <param name="IPAddress"></param>
        /// <param name="port"></param>
        /// <param name="timeout"></param>
        public OnkyoCommanderSettings(string IPAddress, string port, string timeout)
        {
            Address = IPAddress;
            Port = Convert.ToInt32(port);
            Timeout = Convert.ToInt32(timeout);
        }

        public string Address { get; set; }
        public int Port { get; set; }
        public int Timeout { get; set; }
        public IPAddress IPAddress => Helpers.ConvertToIPAddress(Address);
        public OnkyoCommunicator Communicator => new OnkyoCommunicator(IPAddress, Port, Timeout);
    }
}