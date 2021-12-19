// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#pragma warning disable IL2026

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation that the <see cref="DllImportAttribute" /> attributed methods can be resolved.</summary>
    public static unsafe partial class ResolveDllImportTests
    {
        /// <summary>Validates that thhe <see cref="DllImportAttribute" /> attributed methods can be resolved.</summary>
        [Test]
        [Platform("Win32")]
        public static void ResolveDllImportTest()
        {
            Assert.Multiple(() => {
                var assembly = typeof(Windows).Assembly;
                ProcessAssembly(assembly);
            });
        }

        private static void ProcessAssembly(Assembly assembly)
        {
            foreach (var type in assembly.GetTypes())
            {
                ProcessType(type);
            }
        }

        private static void ProcessMethod(MethodInfo method)
        {
            var customAttribute = method.GetCustomAttributes(typeof(DllImportAttribute)).SingleOrDefault();

            if (customAttribute is not DllImportAttribute)
            {
                return;
            }

            try
            {
                RuntimeHelpers.PrepareMethod(method.MethodHandle);
            }
            catch (Exception exception)
            {
                switch (method.Name)
                {
                    case "LoadIconWithScaleDown":
                    case "DrawShadowText":
                    case "ImageList_CoCreateInstance":
                    case "TaskDialogIndirect":
                    case "TaskDialog":
                    case "GetWindowSubclass":
                    case "LoadIconMetric":
                    case "ImageList_ReadEx":
                    case "ImageList_WriteEx":
                    case "HIMAGELIST_QueryInterface":
                    {
                        // These methods come from 'comctl32' but require a manifest file for the app
                        // to see them as visible. Mark them with a warning rather than failing them

                        Assert.Warn(exception.Message);
                        break;
                    }

                    default:
                    {
                        Assert.Fail(exception.Message);
                        break;
                    }
                }
            }
        }

        private static void ProcessType(Type type)
        {
            foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
            {
                ProcessMethod(method);
            }

            foreach (var nestedType in type.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic))
            {
                ProcessType(nestedType);
            }
        }
    }
}
