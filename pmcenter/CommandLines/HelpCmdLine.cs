﻿using System;
using System.Threading.Tasks;

using static pmcenter.Methods;

namespace pmcenter.CommandLines
{
    internal class HelpCmdLine : ICmdLine
    {
        public string Prefix => "help";
        public bool ExitAfterExecution => true;
        private string HelpString => "pmcenter commandline help\n--help: Display this message.\n--info: Get application information.\n--update: Update application manually.\n--backup: Backup configurations.\n--setup: Run setup wizard.\n--reset: Reset everything (use carefully).";
        public Task<bool> Process(string CmdLine)
        {
            Log("Printing commandline help...", "CMD");
            Log(HelpString, "CMD");
            return Task.FromResult(true);
        }
    }
}