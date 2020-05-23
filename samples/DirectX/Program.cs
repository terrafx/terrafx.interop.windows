// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Linq;
using TerraFX.Samples.DirectX.D3D11;
using TerraFX.Samples.DirectX.D3D12;
using static TerraFX.Interop.Windows;
using static TerraFX.Interop.User32;

namespace TerraFX.Samples.DirectX
{
    public static unsafe class Program
    {
        private static readonly DXSample[] Samples = {
            new HelloWindow11(1280, 720, "D3D11.HelloWindow"),
            new HelloTriangle11(1280, 720, "D3D11.HelloTriangle"),
            new HelloWindow12(1280, 720, "D3D12.HelloWindow"),
            new HelloTriangle12(1280, 720, "D3D12.HelloTriangle")
        };

        public static void Main(string[] args)
        {
            if ((args.Length == 0) || args.Any((arg) => Matches(arg, "?", "h", "help")))
            {
                PrintHelp();
            }
            else
            {
                RunSamples(args);
            }
        }

        internal static bool Matches(string arg, params string[] keywords)
        {
            return keywords.Any((keyword) => ((arg.Length == keyword.Length) && arg.Equals(keyword, StringComparison.OrdinalIgnoreCase))
                                          || (((arg.Length - 1) == keyword.Length) && ((arg[0] == '-') || (arg[0] == '/')) && (string.Compare(arg, 1, keyword, 0, keyword.Length, StringComparison.OrdinalIgnoreCase) == 0)));
        }

        private static void PrintHelp()
        {
            Console.WriteLine("General Options");
            Console.WriteLine("    ALL:     Indicates that all samples should be run.");
            Console.WriteLine("    WARP:    Indicates that the 'Windows Advanced Rasterization Platform' adapter should be used.");
            Console.WriteLine();

            Console.WriteLine("Available Samples - Can specify multiple");

            foreach (var sample in Samples)
            {
                Console.WriteLine($"    {sample.Title}");
            }
        }

        private static int Run(DXSample sample)
        {
            var hInstance = GetModuleHandleW(null);
            return Win32Application.Run(sample, hInstance, SW_SHOWDEFAULT);
        }

        private static void RunSamples(string[] args)
        {
            var ranAnySamples = false;

            if (args.Any((arg) => Matches(arg, "all")))
            {
                foreach (var sample in Samples)
                {
                    RunSample(sample);
                    ranAnySamples = true;
                }
            }

            foreach (var arg in args)
            {
                foreach (var sample in Samples.Where((sample) => arg.Equals(sample.Title, StringComparison.OrdinalIgnoreCase)))
                {
                    RunSample(sample);
                    ranAnySamples = true;
                }
            }

            if (ranAnySamples == false)
            {
                PrintHelp();
            }
        }

        private static void RunSample(DXSample sample)
        {
            Console.WriteLine($"Running: {sample.Title}");
            var exitCode = Run(sample);
            Console.WriteLine($"    Completed with exit code: {exitCode}");
        }
    }
}
