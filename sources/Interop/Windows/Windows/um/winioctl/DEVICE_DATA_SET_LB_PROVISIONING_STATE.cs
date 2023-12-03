// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='DEVICE_DATA_SET_LB_PROVISIONING_STATE.xml' path='doc/member[@name="DEVICE_DATA_SET_LB_PROVISIONING_STATE"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct DEVICE_DATA_SET_LB_PROVISIONING_STATE
{
    /// <include file='DEVICE_DATA_SET_LB_PROVISIONING_STATE.xml' path='doc/member[@name="DEVICE_DATA_SET_LB_PROVISIONING_STATE.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='DEVICE_DATA_SET_LB_PROVISIONING_STATE.xml' path='doc/member[@name="DEVICE_DATA_SET_LB_PROVISIONING_STATE.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='DEVICE_DATA_SET_LB_PROVISIONING_STATE.xml' path='doc/member[@name="DEVICE_DATA_SET_LB_PROVISIONING_STATE.SlabSizeInBytes"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong SlabSizeInBytes;

    /// <include file='DEVICE_DATA_SET_LB_PROVISIONING_STATE.xml' path='doc/member[@name="DEVICE_DATA_SET_LB_PROVISIONING_STATE.SlabOffsetDeltaInBytes"]/*' />
    [NativeTypeName("DWORD")]
    public uint SlabOffsetDeltaInBytes;

    /// <include file='DEVICE_DATA_SET_LB_PROVISIONING_STATE.xml' path='doc/member[@name="DEVICE_DATA_SET_LB_PROVISIONING_STATE.SlabAllocationBitMapBitCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint SlabAllocationBitMapBitCount;

    /// <include file='DEVICE_DATA_SET_LB_PROVISIONING_STATE.xml' path='doc/member[@name="DEVICE_DATA_SET_LB_PROVISIONING_STATE.SlabAllocationBitMapLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint SlabAllocationBitMapLength;

    /// <include file='DEVICE_DATA_SET_LB_PROVISIONING_STATE.xml' path='doc/member[@name="DEVICE_DATA_SET_LB_PROVISIONING_STATE.SlabAllocationBitMap"]/*' />
    [NativeTypeName("DWORD[1]")]
    public _SlabAllocationBitMap_e__FixedBuffer SlabAllocationBitMap;

    /// <include file='_SlabAllocationBitMap_e__FixedBuffer.xml' path='doc/member[@name="_SlabAllocationBitMap_e__FixedBuffer"]/*' />
    public partial struct _SlabAllocationBitMap_e__FixedBuffer
    {
        public uint e0;

        [UnscopedRef]
        public ref uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
