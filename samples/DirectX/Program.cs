// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Linq;
using TerraFX.Samples.DirectX.D3D11;
using TerraFX.Samples.DirectX.D3D12;
using static TerraFX.Interop.Windows;

namespace TerraFX.Samples.DirectX
{
    public static unsafe class Program
    {
        /// <summary>
        /// This collection of samples act as an introduction to Direct3D 12. Each sample introduces an elementary concept and lays a foundation for all of the Direct3D 12 samples.
        /// </summary>
        private static readonly DXSample[] Samples = {
            new HelloWindow11(1280, 720, "D3D11.HelloWindow"),
            new HelloTriangle11(1280, 720, "D3D11.HelloTriangle"),
            // This sample shows you how to create a window, Direct3D device (with debug layers enabled), and present to the window. These are the basic elements that every sample uses.
            new HelloWindow12(1280, 720, "D3D12.HelloWindow"),
            // This sample shows you how to draw a static triangle using a vertex buffer.
            new HelloTriangle12(1280, 720, "D3D12.HelloTriangle"),
            // This sample shows you how to apply a Texture2D to triangle.
            new HelloTexture12(1280, 720, "D3D12.HelloTexture"),
            // This sample shows you how to use Bundles to draw a static triangle more efficiently.
            new HelloBundles12(1280, 720, "D3D12.HelloBundles"),
            // This sample shows you how to animate a triangle using a constant buffer.
            new HelloConstBuffer12(1280, 720, "D3D12.HelloConstBuffer"),
            // This sample shows you how to use fences and multiple allocators to queue up multiple frames to the GPU.
            new HelloFrameBuffering12(1280, 720, "HelloFrameBuffering"),
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
