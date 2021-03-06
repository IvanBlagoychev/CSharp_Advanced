﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public static class InputReader
    {
        private const string endCommand = "quit";

        public static void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.currentPath}> ");
            var input = Console.ReadLine();
            input = input.Trim();

            while (true)
            {
                OutputWriter.WriteMessage($"{SessionData.currentPath}>");
                string input = Console.ReadLine();
                input = input.Trim();
                if (input.Equals(endCommand)) break;
                CommandInterpreter.InterpredCommand(input);
            }
        }
    }
}
