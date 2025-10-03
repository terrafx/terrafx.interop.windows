// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_USER_RECORD.xml' path='doc/member[@name="MINIDUMP_USER_RECORD"]/*' />
public partial struct MINIDUMP_USER_RECORD
{
    /// <include file='MINIDUMP_USER_RECORD.xml' path='doc/member[@name="MINIDUMP_USER_RECORD.Type"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Type;

    /// <include file='MINIDUMP_USER_RECORD.xml' path='doc/member[@name="MINIDUMP_USER_RECORD.Memory"]/*' />
    public MINIDUMP_LOCATION_DESCRIPTOR Memory;
}
