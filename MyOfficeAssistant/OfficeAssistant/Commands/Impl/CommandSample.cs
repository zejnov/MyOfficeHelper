﻿using System;
using System.Linq;
using Component.Service.CommandsManager;
using InteractiveGraphicMenu;
using InteractiveGraphicMenu.Interfaces;

namespace OfficeAssistant.Commands.Impl
{
    public class CommandSample : ICommand
    {
        public string Name => "bcdefghijklmnoprst";
        public int Ordinal => 555;
        public string Command => Name;
        public string HelpInfo => "Doing sample stuff";
        public bool IsHighlighted { get; set; }

        private MenuManager<ICommand> _menuManager { get; set; }
        public MenuManager<ICommand> MenuManager => _menuManager ?? (_menuManager = new MenuManager<ICommand>());

        public void Execute()
        {
            var list = CommandManager<ICommand>.GetInstance().GetAvaibleCommands();
            var commandsArray = MenuManager.GenerateCommandsArray(list, 4);

            var menu = new GraphicMenu<ICommand>();
            Console.Clear();

            menu.PrintMenu(commandsArray);

            Console.ReadKey();
        }
    }
}
