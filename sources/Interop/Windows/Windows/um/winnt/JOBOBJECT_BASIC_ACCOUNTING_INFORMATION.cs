// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct JOBOBJECT_BASIC_ACCOUNTING_INFORMATION
{
    public LARGE_INTEGER TotalUserTime;

    public LARGE_INTEGER TotalKernelTime;

    public LARGE_INTEGER ThisPeriodTotalUserTime;

    public LARGE_INTEGER ThisPeriodTotalKernelTime;

    [NativeTypeName("DWORD")]
    public uint TotalPageFaultCount;

    [NativeTypeName("DWORD")]
    public uint TotalProcesses;

    [NativeTypeName("DWORD")]
    public uint ActiveProcesses;

    [NativeTypeName("DWORD")]
    public uint TotalTerminatedProcesses;
}
