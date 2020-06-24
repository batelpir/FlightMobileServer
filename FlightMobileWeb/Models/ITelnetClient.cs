﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightMobileWeb.Models
{
    /// <summary>
    ///  Our telnet connection iterface
    /// </summary>
    public interface ITelnetClient
    {
        void connect();
        void write(string command);
        string read(string command); //blocking call 
        void disconnect();
        bool isConnected();
    }
}
