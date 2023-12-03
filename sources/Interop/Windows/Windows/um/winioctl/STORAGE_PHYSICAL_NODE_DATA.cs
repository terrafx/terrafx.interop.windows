// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_PHYSICAL_NODE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_NODE_DATA"]/*' />
public partial struct STORAGE_PHYSICAL_NODE_DATA
{
    /// <include file='STORAGE_PHYSICAL_NODE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_NODE_DATA.NodeId"]/*' />
    [NativeTypeName("DWORD")]
    public uint NodeId;

    /// <include file='STORAGE_PHYSICAL_NODE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_NODE_DATA.AdapterCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint AdapterCount;

    /// <include file='STORAGE_PHYSICAL_NODE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_NODE_DATA.AdapterDataLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint AdapterDataLength;

    /// <include file='STORAGE_PHYSICAL_NODE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_NODE_DATA.AdapterDataOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint AdapterDataOffset;

    /// <include file='STORAGE_PHYSICAL_NODE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_NODE_DATA.DeviceCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeviceCount;

    /// <include file='STORAGE_PHYSICAL_NODE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_NODE_DATA.DeviceDataLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeviceDataLength;

    /// <include file='STORAGE_PHYSICAL_NODE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_NODE_DATA.DeviceDataOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeviceDataOffset;

    /// <include file='STORAGE_PHYSICAL_NODE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_NODE_DATA.Reserved"]/*' />
    [NativeTypeName("DWORD[3]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public uint e0;
    }
}
