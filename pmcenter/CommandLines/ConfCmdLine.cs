using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using static pmcenter.Methods;

namespace pmcenter.CommandLines
{
    internal class ConfCmdLine : ICmdLine
    {
        public string Prefix => "conf";
        public bool ExitAfterExecution => false;
        public Task<bool> Process(string CmdLine)
        {
            // for example
            // dotnet pmcenter.dll --conf /home/pmcenter/conf.json --lang /home/pmcenter/lang.json
            // 012345678910 13 16 19 22 25 28 31 34 37 40 43 46 49 52 55 58 61 64 67 70 73 76 79 82
            //            11 14 17 20 23 26 29 32 35 38 41 44 47 50 53 56 59 62 65 68 71 74 77 80 83
            //             12 15 18 21 24 27 30 33 36 39 42 45 48 51 54 57 60 63 66 69 72 75 78 81
            //                     ^ 20 is index of "--conf"      ^ cut here (int SpaceIndex)
            //                            ^ actually we want here (27)
            
            Log("Using configurations file: ");
            return Task.FromResult(true);
        }
    }
}