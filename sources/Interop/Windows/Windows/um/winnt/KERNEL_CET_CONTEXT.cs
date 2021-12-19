// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='KERNEL_CET_CONTEXT.xml' path='doc/member[@name="KERNEL_CET_CONTEXT"]/*' />
public unsafe partial struct KERNEL_CET_CONTEXT
{
    /// <include file='KERNEL_CET_CONTEXT.xml' path='doc/member[@name="KERNEL_CET_CONTEXT.Ssp"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong Ssp;

    /// <include file='KERNEL_CET_CONTEXT.xml' path='doc/member[@name="KERNEL_CET_CONTEXT.Rip"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong Rip;

    /// <include file='KERNEL_CET_CONTEXT.xml' path='doc/member[@name="KERNEL_CET_CONTEXT.SegCs"]/*' />
    [NativeTypeName("WORD")]
    public ushort SegCs;

    /// <include file='KERNEL_CET_CONTEXT.xml' path='doc/member[@name="KERNEL_CET_CONTEXT.Fill"]/*' />
    [NativeTypeName("WORD [3]")]
    public fixed ushort Fill[3];
}
