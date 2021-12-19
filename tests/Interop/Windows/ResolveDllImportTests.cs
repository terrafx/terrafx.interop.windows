// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using NUnit.Framework;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

#pragma warning disable IL2026

namespace TerraFX.Interop.Windows.UnitTests;

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
        if (!method.Attributes.HasFlag(MethodAttributes.PinvokeImpl))
        {
            return;
        }

        try
        {
            Marshal.Prelink(method);
        }
        catch (Exception exception)
        {
            switch (method.Name)
            {
                case "DavCancelConnectionsToServer":
                case "DavGetTheLockOwnerOfTheFile":
                case "DavInvalidateCache":
                case "DavRegisterAuthCallback":
                case "DavUnregisterAuthCallback":
                {
                    if (Environment.GetEnvironmentVariable("GITHUB_RUN_ID") is not null)
                    {
                        // This isn't good practice, but current CI runs Windows Server and 'davclnt' isn't available
                        Assert.Warn($"Warn: {exception.Message}");
                    }
                    else
                    {
                        goto default;
                    }
                    break;
                }

                case "DrawShadowText":
                case "GetWindowSubclass":
                case "HIMAGELIST_QueryInterface":
                case "ImageList_CoCreateInstance":
                case "ImageList_ReadEx":
                case "ImageList_WriteEx":
                case "LoadIconMetric":
                case "LoadIconWithScaleDown":
                case "TaskDialog":
                case "TaskDialogIndirect":
                {
                    // These methods come from 'comctl32' but require a manifest file for the app
                    // to see them as visible. Mark them with a warning rather than failing them

                    Assert.Warn($"Warn: {exception.Message}");
                    break;
                }

                case "DxcCreateInstance":
                case "DxcCreateInstance2":
                {
                    if (Environment.GetEnvironmentVariable("GITHUB_RUN_ID") is not null)
                    {
                        // This isn't good practice, but current CI runs Windows Server and 'dxcompiler' isn't available
                        Assert.Warn($"Warn: {exception.Message}");
                    }
                    else
                    {
                        goto default;
                    }
                    break;
                }

                case "SRRemoveRestorePoint":
                case "SRSetRestorePoint":
                case "SRSetRestorePointA":
                case "SRSetRestorePointInternal":
                case "SRSetRestorePointW":
                {
                    if (Environment.GetEnvironmentVariable("GITHUB_RUN_ID") is not null)
                    {
                        // This isn't good practice, but current CI runs Windows Server and 'srclient' isn't available
                        Assert.Warn($"Warn: {exception.Message}");
                    }
                    else
                    {
                        goto default;
                    }
                    break;
                }

                case "X3DAudioInitialize":
                case "X3DAudioCalculate":
                {
                    if (Environment.GetEnvironmentVariable("GITHUB_RUN_ID") is not null)
                    {
                        // This isn't good practice, but current CI runs Windows Server and 'X3DAudio1_7' isn't available
                        Assert.Warn($"Warn: {exception.Message}");
                    }
                    else
                    {
                        goto default;
                    }
                    break;
                }

                default:
                {
                    Assert.Fail($"Fail: {exception.Message}");
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
