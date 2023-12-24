// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using NUnit.Framework;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;

#pragma warning disable IL2026
#pragma warning disable IL2072

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
                case "DxcCreateInstance":
                case "DxcCreateInstance2":
                case "SRRemoveRestorePoint":
                case "SRSetRestorePoint":
                case "SRSetRestorePointA":
                case "SRSetRestorePointInternal":
                case "SRSetRestorePointW":
                case "X3DAudioInitialize":
                case "X3DAudioCalculate":
                {
                    if (Environment.GetEnvironmentVariable("GITHUB_RUN_ID") is not null)
                    {
                        // This isn't good practice, but current CI runs Windows Server and these APIs aren't available
                        // due to being in a library that isn't present on the Windows Server machines
                        Assert.Warn($"Warn: {exception.Message}");
                    }
                    else
                    {
                        goto default;
                    }
                    break;
                }

                case "DCompositionBoostCompositorClock":
                case "DCompositionGetFrameId":
                case "DCompositionGetStatistics":
                case "DCompositionGetTargetStatistics":
                case "DCompositionWaitForCompositorClock":
                case "GetIdForPackageDependencyContext":
                case "GetMachineTypeAttributes":
                case "HidP_GetButtonArray":
                case "HidP_SetButtonArray":
                case "MFCreateCameraOcclusionStateMonitor":
                case "SymGetSourceFileFromTokenByTokenName":
                case "SymGetSourceFileFromTokenByTokenNameW":
                case "SymGetSourceFileTokenByTokenName":
                case "SymGetSourceFileTokenByTokenNameW":
                case "SetThreadCursorCreationScaling":
                case "TryCreatePackageDependency":
                case "WinHttpQueryConnectionGroup":
                case "WinHttpFreeQueryConnectionGroupResult":
                {
                    if (!OperatingSystem.IsWindowsVersionAtLeast(10, 0, 22000, 0))
                    {
                        // This isn't good practice, but current CI runs Windows Server and these APIs aren't available
                        // due to only being in a newer version of Windows.
                        Assert.Warn($"Warn: {exception.Message}");
                    }
                    else
                    {
                        goto default;
                    }
                    break;
                }

                case "DXGIDisableVBlankVirtualization":
                case "GetClipboardMetadata":
                case "GetPackageGraphRevisionId":
                case "MFCreateCameraControlMonitor":
                case "RegisterDeviceDualEnrollMmpcUsingAADDeviceCredentials":
                case "RegisterForTooltipDismissNotification":
                case "SetAdditionalForegroundBoostProcesses":
                case "SslDeserializeCertificateStore":
                case "StackWalk2":
                case "Tbsi_Is_Tpm_Present":
                case "WinHttpFreeProxySettingsEx":
                case "WinHttpGetProxySettingsEx":
                case "WinHttpGetProxySettingsResultEx":
                case "WinHttpRegisterProxyChangeNotification":
                case "WinHttpUnregisterProxyChangeNotification":
                {
                    if (!OperatingSystem.IsWindowsVersionAtLeast(10, 0, 22621, 0))
                    {
                        // This isn't good practice, but current CI runs Windows Server and these APIs aren't available
                        // due to only being in a newer version of Windows.
                        Assert.Warn($"Warn: {exception.Message}");
                    }
                    else
                    {
                        goto default;
                    }
                    break;
                }

                case "GetDeveloperDriveEnablementState":
                {
                    if (!OperatingSystem.IsWindowsVersionAtLeast(10, 0, 22631, 0))
                    {
                        // This isn't good practice, but current CI runs Windows Server and these APIs aren't available
                        // due to only being in a newer version of Windows.
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

                default:
                {
                    throw;
                }
            }
        }
    }

    private static void ProcessType([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)] Type type)
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
