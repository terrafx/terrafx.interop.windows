// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SYSTEM_HANDLECOUNT_INFORMATION.xml' path='doc/member[@name="SYSTEM_HANDLECOUNT_INFORMATION"]/*' />
public partial struct SYSTEM_HANDLECOUNT_INFORMATION
{
    /// <include file='SYSTEM_HANDLECOUNT_INFORMATION.xml' path='doc/member[@name="SYSTEM_HANDLECOUNT_INFORMATION.ProcessCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint ProcessCount;

    /// <include file='SYSTEM_HANDLECOUNT_INFORMATION.xml' path='doc/member[@name="SYSTEM_HANDLECOUNT_INFORMATION.ThreadCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint ThreadCount;

    /// <include file='SYSTEM_HANDLECOUNT_INFORMATION.xml' path='doc/member[@name="SYSTEM_HANDLECOUNT_INFORMATION.HandleCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint HandleCount;
}
