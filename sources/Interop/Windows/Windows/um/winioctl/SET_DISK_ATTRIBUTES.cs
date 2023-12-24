// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SET_DISK_ATTRIBUTES.xml' path='doc/member[@name="SET_DISK_ATTRIBUTES"]/*' />
public partial struct SET_DISK_ATTRIBUTES
{
    /// <include file='SET_DISK_ATTRIBUTES.xml' path='doc/member[@name="SET_DISK_ATTRIBUTES.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SET_DISK_ATTRIBUTES.xml' path='doc/member[@name="SET_DISK_ATTRIBUTES.Persist"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Persist;

    /// <include file='SET_DISK_ATTRIBUTES.xml' path='doc/member[@name="SET_DISK_ATTRIBUTES.Reserved1"]/*' />
    [NativeTypeName("BYTE[3]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    /// <include file='SET_DISK_ATTRIBUTES.xml' path='doc/member[@name="SET_DISK_ATTRIBUTES.Attributes"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong Attributes;

    /// <include file='SET_DISK_ATTRIBUTES.xml' path='doc/member[@name="SET_DISK_ATTRIBUTES.AttributesMask"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong AttributesMask;

    /// <include file='SET_DISK_ATTRIBUTES.xml' path='doc/member[@name="SET_DISK_ATTRIBUTES.Reserved2"]/*' />
    [NativeTypeName("DWORD[4]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    /// <include file='_Reserved1_e__FixedBuffer.xml' path='doc/member[@name="_Reserved1_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Reserved2_e__FixedBuffer.xml' path='doc/member[@name="_Reserved2_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _Reserved2_e__FixedBuffer
    {
        public uint e0;
    }
}
