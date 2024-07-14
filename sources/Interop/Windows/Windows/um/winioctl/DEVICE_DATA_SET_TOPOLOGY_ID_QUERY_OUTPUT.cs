// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='DEVICE_DATA_SET_TOPOLOGY_ID_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DATA_SET_TOPOLOGY_ID_QUERY_OUTPUT"]/*' />
public partial struct DEVICE_DATA_SET_TOPOLOGY_ID_QUERY_OUTPUT
{
    /// <include file='DEVICE_DATA_SET_TOPOLOGY_ID_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DATA_SET_TOPOLOGY_ID_QUERY_OUTPUT.TopologyRangeBytes"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong TopologyRangeBytes;

    /// <include file='DEVICE_DATA_SET_TOPOLOGY_ID_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DATA_SET_TOPOLOGY_ID_QUERY_OUTPUT.TopologyId"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _TopologyId_e__FixedBuffer TopologyId;

    /// <include file='_TopologyId_e__FixedBuffer.xml' path='doc/member[@name="_TopologyId_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _TopologyId_e__FixedBuffer
    {
        public byte e0;
    }
}
