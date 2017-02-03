using System;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Microsoft.VisualBasic;

namespace eg.Onkyo.Communicator
{
    public class OnkyoCommunicator : ICommunicator
    {
        private Socket _socket;
        private readonly IPAddress _address;
        private readonly int _port;
        private readonly int _timeout;

        /// <summary>
        /// Instantiates the Onkyo Communicator
        /// </summary>
        /// <param name="address"></param>
        /// <param name="port"></param>
        /// <param name="timeout"></param>
        public OnkyoCommunicator(IPAddress address, int port, int timeout)
        {
            _address = address;
            _port = port;
            _timeout = timeout;
        }

        /// <summary>
        /// Sends a command to the Onkyo
        /// </summary>
        /// <param name="cmd"></param>
        public void SendCommand(string cmd)
        {
            using (_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            {
                ReceiveTimeout = _timeout
            })
            {
                _socket.Connect(_address, _port);
                if (string.IsNullOrEmpty(cmd)) return;
                var sendBytes = new char[cmd.Length + 19];
                sendBytes[0] = 'I';
                sendBytes[1] = 'S';
                sendBytes[2] = 'C';
                sendBytes[3] = 'P';
                sendBytes[4] = Strings.Chr(0);
                sendBytes[5] = Strings.Chr(0);
                sendBytes[6] = Strings.Chr(0);
                sendBytes[7] = Strings.Chr(16);
                sendBytes[8] = Strings.Chr(0);
                sendBytes[9] = Strings.Chr(0);
                sendBytes[10] = Strings.Chr(0);
                sendBytes[11] = Strings.Chr(cmd.Length + 3);
                sendBytes[12] = Strings.Chr(1);
                sendBytes[13] = Strings.Chr(0);
                sendBytes[14] = Strings.Chr(0);
                sendBytes[15] = Strings.Chr(0);
                sendBytes[16] = '!';
                sendBytes[17] = '1';

                int i;
                for (i = 0; i <= (cmd.Length - 1); i++)
                {
                    sendBytes[18 + i] = cmd[i];
                }

                sendBytes[cmd.Length + 18] = Strings.Chr(13);
                var hexOutput = sendBytes.Select(Convert.ToInt32).Aggregate("", (current, value) => current + $"{value:x2} ");
                var send = SoapHexBinary.Parse(hexOutput);
                _socket.Send(send.Value, send.Value.Length, SocketFlags.None);
            }
        }

        /// <summary>
        /// Parses the volume command into a 2-digit hex string
        /// </summary>
        /// <param name="volumeCommand"></param>
        /// <param name="volumeAmount"></param>
        public void ParseVolumeCommand(string volumeCommand, int volumeAmount)
        {
            var vol = volumeAmount.ToString("X2");
            SendCommand(volumeCommand + vol);
        }
    }
}
