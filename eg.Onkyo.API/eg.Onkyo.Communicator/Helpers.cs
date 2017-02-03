using System;
using System.Net;

namespace eg.Onkyo.Communicator
{
    public class Helpers
    {
        /// <summary>
        /// Convert the given IP Address to a .net IP Address
        /// </summary>
        /// <param name="IPAddressString"></param>
        /// <returns></returns>
        public static IPAddress ConvertToIPAddress(string IPAddressString)
        {
            try
            {
                var address = IPAddress.Parse(IPAddressString);
                return address;
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an issue when parsing the IP Address: {0}", e);
                throw;
            }
        }
    }
}
