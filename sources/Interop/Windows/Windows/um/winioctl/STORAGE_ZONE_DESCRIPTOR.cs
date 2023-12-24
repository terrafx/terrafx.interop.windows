// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_ZONE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONE_DESCRIPTOR"]/*' />
public partial struct STORAGE_ZONE_DESCRIPTOR
{
    /// <include file='STORAGE_ZONE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONE_DESCRIPTOR.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_ZONE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONE_DESCRIPTOR.ZoneType"]/*' />
    public STORAGE_ZONE_TYPES ZoneType;

    /// <include file='STORAGE_ZONE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONE_DESCRIPTOR.ZoneCondition"]/*' />
    public STORAGE_ZONE_CONDITION ZoneCondition;

    /// <include file='STORAGE_ZONE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONE_DESCRIPTOR.ResetWritePointerRecommend"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte ResetWritePointerRecommend;

    /// <include file='STORAGE_ZONE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONE_DESCRIPTOR.Reserved0"]/*' />
    [NativeTypeName("BYTE[3]")]
    public _Reserved0_e__FixedBuffer Reserved0;

    /// <include file='STORAGE_ZONE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONE_DESCRIPTOR.ZoneSize"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong ZoneSize;

    /// <include file='STORAGE_ZONE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONE_DESCRIPTOR.WritePointerOffset"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong WritePointerOffset;

    /// <include file='_Reserved0_e__FixedBuffer.xml' path='doc/member[@name="_Reserved0_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _Reserved0_e__FixedBuffer
    {
        public byte e0;
    }
}
