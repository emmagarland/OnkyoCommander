using System;

namespace eg.Onkyo.Communicator
{
    public interface ICommunicator
    {
        void SendCommand(String cmd);
    }
}
