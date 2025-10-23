// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_LOCATION_DESCRIPTOR64.xml' path='doc/member[@name="MINIDUMP_LOCATION_DESCRIPTOR64"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_LOCATION_DESCRIPTOR64
{
    /// <include file='MINIDUMP_LOCATION_DESCRIPTOR64.xml' path='doc/member[@name="MINIDUMP_LOCATION_DESCRIPTOR64.DataSize"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong DataSize;

    /// <include file='MINIDUMP_LOCATION_DESCRIPTOR64.xml' path='doc/member[@name="MINIDUMP_LOCATION_DESCRIPTOR64.Rva"]/*' />
    [NativeTypeName("RVA64")]
    public ulong Rva;
}
