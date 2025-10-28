// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_LOCATION_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_LOCATION_DESCRIPTOR"]/*' />
public partial struct MINIDUMP_LOCATION_DESCRIPTOR
{
    /// <include file='MINIDUMP_LOCATION_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_LOCATION_DESCRIPTOR.DataSize"]/*' />
    [NativeTypeName("ULONG32")]
    public uint DataSize;

    /// <include file='MINIDUMP_LOCATION_DESCRIPTOR.xml' path='doc/member[@name="MINIDUMP_LOCATION_DESCRIPTOR.Rva"]/*' />
    [NativeTypeName("RVA")]
    public uint Rva;
}
