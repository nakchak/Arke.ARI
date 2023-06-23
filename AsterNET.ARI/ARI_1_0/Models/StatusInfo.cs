/*
   AsterNET ARI Framework
   Automatically generated file @ 6/21/2023 2:39:12 PM
*/
using System;
using System.Collections.Generic;
using AsterNET.ARI.Actions;

namespace AsterNET.ARI.Models
{
    /// <summary>
    /// Info about Asterisk status
    /// </summary>
    public class StatusInfo
    {


        /// <summary>
        /// Time when Asterisk was started.
        /// </summary>
        public DateTime Startup_time { get; set; }

        /// <summary>
        /// Time when Asterisk was last reloaded.
        /// </summary>
        public DateTime Last_reload_time { get; set; }

    }
}
