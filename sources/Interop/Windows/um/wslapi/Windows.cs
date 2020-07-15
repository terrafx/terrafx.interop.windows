// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wslapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("wslapi", EntryPoint = "WslIsDistributionRegistered", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WslIsDistributionRegistered([NativeTypeName("PCWSTR")] ushort* distributionName);

        [DllImport("wslapi", EntryPoint = "WslRegisterDistribution", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslRegisterDistribution([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("PCWSTR")] ushort* tarGzFilename);

        [DllImport("wslapi", EntryPoint = "WslUnregisterDistribution", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslUnregisterDistribution([NativeTypeName("PCWSTR")] ushort* distributionName);

        [DllImport("wslapi", EntryPoint = "WslConfigureDistribution", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslConfigureDistribution([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("ULONG")] uint defaultUID, WSL_DISTRIBUTION_FLAGS wslDistributionFlags);

        [DllImport("wslapi", EntryPoint = "WslGetDistributionConfiguration", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslGetDistributionConfiguration([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("ULONG *")] uint* distributionVersion, [NativeTypeName("ULONG *")] uint* defaultUID, [NativeTypeName("WSL_DISTRIBUTION_FLAGS *")] WSL_DISTRIBUTION_FLAGS* wslDistributionFlags, [NativeTypeName("PSTR **")] sbyte*** defaultEnvironmentVariables, [NativeTypeName("ULONG *")] uint* defaultEnvironmentVariableCount);

        [DllImport("wslapi", EntryPoint = "WslLaunchInteractive", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslLaunchInteractive([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("PCWSTR")] ushort* command, [NativeTypeName("BOOL")] int useCurrentWorkingDirectory, [NativeTypeName("DWORD *")] uint* exitCode);

        [DllImport("wslapi", EntryPoint = "WslLaunch", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslLaunch([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("PCWSTR")] ushort* command, [NativeTypeName("BOOL")] int useCurrentWorkingDirectory, [NativeTypeName("HANDLE")] IntPtr stdIn, [NativeTypeName("HANDLE")] IntPtr stdOut, [NativeTypeName("HANDLE")] IntPtr stdErr, [NativeTypeName("HANDLE *")] IntPtr* process);
    }
}
