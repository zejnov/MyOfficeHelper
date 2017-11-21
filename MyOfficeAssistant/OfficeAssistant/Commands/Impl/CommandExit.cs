﻿using OfficeAssistant.Domain;

namespace OfficeAssistant.Commands.Impl
{
    internal class CommandExit : ICommand
    {
        public string Name => "Exit";
        public string HelpInfo => "Exit application";
        public bool IsHighlighted
        {
            get => true;
            set => IsHighlighted = value;
        }

        public void Execute()
        {
            ApplicationState.IsRunning = false;
        }
    }
}