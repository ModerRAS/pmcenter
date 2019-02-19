using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CommandLine;

using static pmcenter.Methods;

namespace pmcenter
{
    public partial class CmdLines
    {
        [Verb("backup", HelpText = "Backup all configurations", Hidden = false)]
        public class BackupOption
        {
            public Task<bool> Run()
            {
                Log("Backing up...", "CMD");
                string RandomFilename = "pmcenter." + DateTime.Now.ToString("yyyy-dd-M-HH-mm-ss") + "#" + GetRandomString(6) + ".json";
                RandomFilename = Path.Combine(Vars.AppDirectory, RandomFilename);
                File.Copy(Vars.ConfFile, RandomFilename);
                Log("Backup complete. Filename: " + RandomFilename, "CMD");
                Environment.Exit(0);
                return Task.FromResult(true);
            }
        }
    }
}