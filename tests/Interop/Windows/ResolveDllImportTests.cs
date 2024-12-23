// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using NUnit.Framework;
using System;
using System.Collections.Generic;
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
        var unresolved = new List<string>();

        foreach (var type in assembly.GetTypes())
        {
            ProcessType(type, unresolved);
        }

        Assert.That(unresolved, Is.Empty);
    }

#pragma warning disable CA1031 // Do not catch general exception types
    private static void ProcessMethod(MethodInfo method, List<string> unresolved)
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
                case "LoadManagedRuntime":
                case "PrjAllocateAlignedBuffer":
                case "PrjClearNegativePathCache":
                case "PrjCompleteCommand":
                case "PrjDeleteFile":
                case "PrjDoesNameContainWildCards":
                case "PrjFileNameCompare":
                case "PrjFileNameMatch":
                case "PrjFillDirEntryBuffer":
                case "PrjFillDirEntryBuffer2":
                case "PrjFreeAlignedBuffer":
                case "PrjGetOnDiskFileState":
                case "PrjGetVirtualizationInstanceInfo":
                case "PrjMarkDirectoryAsPlaceholder":
                case "PrjStartVirtualizing":
                case "PrjStopVirtualizing":
                case "PrjUpdateFileIfNeeded":
                case "PrjWriteFileData":
                case "PrjWritePlaceholderInfo":
                case "PrjWritePlaceholderInfo2":
                case "SRRemoveRestorePoint":
                case "SRSetRestorePoint":
                case "SRSetRestorePointA":
                case "SRSetRestorePointInternal":
                case "SRSetRestorePointW":
                case "X3DAudioInitialize":
                case "X3DAudioCalculate":
                {
                    // This isn't good practice, but current CI runs Windows Server and these APIs aren't available
                    // due to being in a library that isn't present on the Windows Server machines or requiring an
                    // optional Windows feature to be installed
                    Assert.Warn($"Warn: {exception.Message}");
                    break;
                }

                case "CreatePresentationFactory":
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

                case "AddPackageDependency2":
                case "AllocConsoleWithOptions":
                case "ColorProfileGetDeviceCapabilities":
                case "FindPackageDependency":
                case "GetFileInformationByName":
                case "GetMemoryNumaClosestInitiatorNode":
                case "GetMemoryNumaPerformanceInformation":
                case "GetPackageDependencyInformation":
                case "GetProcessesUsingPackageDependency":
                case "GetResolvedPackageFullNameForPackageDependency2":
                case "MFCreateDXGICrossAdapterBuffer":
                case "MFGetDXGIDeviceManageMode":
                case "ReleasePseudoConsole":
                case "SHGetAssocKeys":
                case "SymGetParentWindow":
                case "TlsGetValue2":
                case "TryCreatePackageDependency2":
                case "WinHttpProtocolCompleteUpgrade":
                case "WinHttpProtocolReceive":
                case "WinHttpProtocolSend":
                {
                    if (!OperatingSystem.IsWindowsVersionAtLeast(10, 0, 26100, 0))
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
                    unresolved.Add(method.Name);
                    break;
                }
            }
        }
    }
#pragma warning restore CA1031 // Do not catch general exception types

    private static void ProcessType([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)] Type type, List<string> unresolved)
    {
        foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
        {
            ProcessMethod(method, unresolved);
        }

        foreach (var nestedType in type.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic))
        {
            ProcessType(nestedType, unresolved);
        }
    }
}
