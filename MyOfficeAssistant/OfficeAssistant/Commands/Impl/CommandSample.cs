﻿using System;

namespace OfficeAssistant.Commands.Impl
{
    public class CommandSample : ICommand
    {
        public string Name => "Sample";
        public string HelpInfo => "Doing sample stuff";
        public void Execute()
        {
            Console.WriteLine("Ssssample");
            Console.ReadKey();
        }
    }
}