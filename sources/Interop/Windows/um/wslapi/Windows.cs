// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wslapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.WSL_DISTRIBUTION_FLAGS;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("api-ms-win-wsl-api-l1-1-0", ExactSpelling = true)]
        public static extern BOOL WslIsDistributionRegistered([NativeTypeName("PCWSTR")] ushort* distributionName);

        [DllImport("api-ms-win-wsl-api-l1-1-0", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslRegisterDistribution([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("PCWSTR")] ushort* tarGzFilename);

        [DllImport("api-ms-win-wsl-api-l1-1-0", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslUnregisterDistribution([NativeTypeName("PCWSTR")] ushort* distributionName);

        [DllImport("api-ms-win-wsl-api-l1-1-0", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslConfigureDistribution([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("ULONG")] uint defaultUID, WSL_DISTRIBUTION_FLAGS wslDistributionFlags);

        [DllImport("api-ms-win-wsl-api-l1-1-0", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslGetDistributionConfiguration([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("ULONG *")] uint* distributionVersion, [NativeTypeName("ULONG *")] uint* defaultUID, WSL_DISTRIBUTION_FLAGS* wslDistributionFlags, [NativeTypeName("PSTR **")] sbyte*** defaultEnvironmentVariables, [NativeTypeName("ULONG *")] uint* defaultEnvironmentVariableCount);

        [DllImport("api-ms-win-wsl-api-l1-1-0", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslLaunchInteractive([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("PCWSTR")] ushort* command, BOOL useCurrentWorkingDirectory, [NativeTypeName("DWORD *")] uint* exitCode);

        [DllImport("api-ms-win-wsl-api-l1-1-0", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WslLaunch([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("PCWSTR")] ushort* command, BOOL useCurrentWorkingDirectory, [NativeTypeName("HANDLE")] IntPtr stdIn, [NativeTypeName("HANDLE")] IntPtr stdOut, [NativeTypeName("HANDLE")] IntPtr stdErr, [NativeTypeName("HANDLE *")] IntPtr* process);

        [NativeTypeName("#define WSL_DISTRIBUTION_FLAGS_VALID (WSL_DISTRIBUTION_FLAGS_ENABLE_INTEROP | WSL_DISTRIBUTION_FLAGS_APPEND_NT_PATH | WSL_DISTRIBUTION_FLAGS_ENABLE_DRIVE_MOUNTING)")]
        public const WSL_DISTRIBUTION_FLAGS WSL_DISTRIBUTION_FLAGS_VALID = (WSL_DISTRIBUTION_FLAGS_ENABLE_INTEROP | WSL_DISTRIBUTION_FLAGS_APPEND_NT_PATH | WSL_DISTRIBUTION_FLAGS_ENABLE_DRIVE_MOUNTING);

        [NativeTypeName("#define WSL_DISTRIBUTION_FLAGS_DEFAULT (WSL_DISTRIBUTION_FLAGS_ENABLE_INTEROP | WSL_DISTRIBUTION_FLAGS_APPEND_NT_PATH | WSL_DISTRIBUTION_FLAGS_ENABLE_DRIVE_MOUNTING)")]
        public const WSL_DISTRIBUTION_FLAGS WSL_DISTRIBUTION_FLAGS_DEFAULT = (WSL_DISTRIBUTION_FLAGS_ENABLE_INTEROP | WSL_DISTRIBUTION_FLAGS_APPEND_NT_PATH | WSL_DISTRIBUTION_FLAGS_ENABLE_DRIVE_MOUNTING);
    }
}
