// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_DIRECTORY.xml' path='doc/member[@name="MINIDUMP_DIRECTORY"]/*' />
public partial struct MINIDUMP_DIRECTORY
{
    /// <include file='MINIDUMP_DIRECTORY.xml' path='doc/member[@name="MINIDUMP_DIRECTORY.StreamType"]/*' />
    [NativeTypeName("ULONG32")]
    public uint StreamType;

    /// <include file='MINIDUMP_DIRECTORY.xml' path='doc/member[@name="MINIDUMP_DIRECTORY.Location"]/*' />
    public MINIDUMP_LOCATION_DESCRIPTOR Location;
}
