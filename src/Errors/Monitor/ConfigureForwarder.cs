﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using NServiceBus.Faults;

namespace NServiceBus.Management.Errors.Monitor
{
    class ConfigureForwarder : IWantCustomInitialization
    {
        public void Init()
        {
            Configure.Instance.MessageForwardingInCaseOfFault();
        }
    }
}
