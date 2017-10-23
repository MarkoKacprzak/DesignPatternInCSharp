using System;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using DesignPattern.Mix.NTierApp.Presentation.Implementation.Commands;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation
{
    internal class MenuItem
    {

        private readonly string caption;
        private readonly char hotkey;
        private readonly bool isTerminal;
        private readonly ICommand command;
        private readonly Func<bool> isVisible;

        private MenuItem(string caption, char hotkey, bool isTerminal, ICommand command, Func<bool> isVisible)
        {
            this.caption = caption;
            this.hotkey = hotkey;
            this.isTerminal = isTerminal;
            this.command = command;
            this.isVisible = isVisible;
        }

        public static MenuItem CreateTerminal(string caption, char hotkey)
        {
            return new MenuItem(caption, hotkey, true, new DoNothingCommand(), () => true);
        }

        public static MenuItem CreateNonTerminal(string caption, char hotkey, ICommand command, Func<bool> isVisible)
        {
            return new MenuItem(caption, hotkey, false, command, isVisible);
        }

        public void Display()
        {

            if (!isVisible())
                return;

            int pos = caption.IndexOf(this.hotkey);

            if (pos > 0)
                Console.Write(this.caption.Substring(0, pos));

            var previousColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(hotkey);
            Console.ForegroundColor = previousColor;

            if (pos < caption.Length - 1)
                Console.Write(caption.Substring(pos + 1));

            Console.WriteLine();
        }

        public bool IsTerminalCommand => isTerminal;

        public bool MatchesKey(char key) => isVisible() && char.ToLower(this.hotkey) == char.ToLower(key);

        public ICommand Command =>  command;
    }
}
