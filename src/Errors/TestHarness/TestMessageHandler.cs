﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using NServiceBus.Faults;

namespace NServiceBus.Management.Errors.TestHarness
{
    class TestMessageHandler : IHandleMessages<SendTestMessage>
    {
        public void Handle(SendTestMessage message)
        {
            throw new NotImplementedException();
            Console.WriteLine("Hello World!!!");

            //if (message.Name.StartsWith("Hello"))
            //{
            //    throw new NotImplementedException();
            //}
            //else
            {
                Console.WriteLine("Hello again!!!");
            }
        }
    }
}
