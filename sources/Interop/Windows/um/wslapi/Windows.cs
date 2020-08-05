// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wslapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.WSL_DISTRIBUTION_FLAGS;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("wslapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WslIsDistributionRegistered([NativeTypeName("PCWSTR")] ushort* distributionName);

        [DllImport("wslapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslRegisterDistribution([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("PCWSTR")] ushort* tarGzFilename);

        [DllImport("wslapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslUnregisterDistribution([NativeTypeName("PCWSTR")] ushort* distributionName);

        [DllImport("wslapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslConfigureDistribution([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("ULONG")] uint defaultUID, WSL_DISTRIBUTION_FLAGS wslDistributionFlags);

        [DllImport("wslapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslGetDistributionConfiguration([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("ULONG *")] uint* distributionVersion, [NativeTypeName("ULONG *")] uint* defaultUID, [NativeTypeName("WSL_DISTRIBUTION_FLAGS *")] WSL_DISTRIBUTION_FLAGS* wslDistributionFlags, [NativeTypeName("PSTR **")] sbyte*** defaultEnvironmentVariables, [NativeTypeName("ULONG *")] uint* defaultEnvironmentVariableCount);

        [DllImport("wslapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslLaunchInteractive([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("PCWSTR")] ushort* command, [NativeTypeName("BOOL")] int useCurrentWorkingDirectory, [NativeTypeName("DWORD *")] uint* exitCode);

        [DllImport("wslapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslLaunch([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("PCWSTR")] ushort* command, [NativeTypeName("BOOL")] int useCurrentWorkingDirectory, [NativeTypeName("HANDLE")] IntPtr stdIn, [NativeTypeName("HANDLE")] IntPtr stdOut, [NativeTypeName("HANDLE")] IntPtr stdErr, [NativeTypeName("HANDLE *")] IntPtr* process);

        [NativeTypeName("#define WSL_DISTRIBUTION_FLAGS_VALID (WSL_DISTRIBUTION_FLAGS_ENABLE_INTEROP | WSL_DISTRIBUTION_FLAGS_APPEND_NT_PATH | WSL_DISTRIBUTION_FLAGS_ENABLE_DRIVE_MOUNTING)")]
        public const WSL_DISTRIBUTION_FLAGS WSL_DISTRIBUTION_FLAGS_VALID = (WSL_DISTRIBUTION_FLAGS_ENABLE_INTEROP | WSL_DISTRIBUTION_FLAGS_APPEND_NT_PATH | WSL_DISTRIBUTION_FLAGS_ENABLE_DRIVE_MOUNTING);

        [NativeTypeName("#define WSL_DISTRIBUTION_FLAGS_DEFAULT (WSL_DISTRIBUTION_FLAGS_ENABLE_INTEROP | WSL_DISTRIBUTION_FLAGS_APPEND_NT_PATH | WSL_DISTRIBUTION_FLAGS_ENABLE_DRIVE_MOUNTING)")]
        public const WSL_DISTRIBUTION_FLAGS WSL_DISTRIBUTION_FLAGS_DEFAULT = (WSL_DISTRIBUTION_FLAGS_ENABLE_INTEROP | WSL_DISTRIBUTION_FLAGS_APPEND_NT_PATH | WSL_DISTRIBUTION_FLAGS_ENABLE_DRIVE_MOUNTING);
    }
}
