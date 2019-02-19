using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using static pmcenter.Methods;

namespace pmcenter.CommandLines
{
    internal class ResetCmdLine : ICmdLine
    {
        public string Prefix => "reset";
        public bool ExitAfterExecution => true;
        public async Task<bool> Process(string CmdLine)
        {
            Log("Resetting configurations...", "CMD");
            Vars.CurrentConf = new Conf.ConfObj();
            await Conf.SaveConf();
            Vars.CurrentLang = new Lang.Language();
            await Lang.SaveLang();
            Log("Reset complete.");
            return true;
        }
    }
}