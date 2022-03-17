// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA.xml' path='doc/member[@name="D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA"]/*' />
public partial struct D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA
{
    /// <include file='D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA.xml' path='doc/member[@name="D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA.Version"]/*' />
    public D3D12_DRED_VERSION Version;

    /// <include file='D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA.xml' path='doc/member[@name="D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA.Anonymous"]/*' />
    [NativeTypeName("D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/d3d12.h:14383:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Dred_1_0"]/*' />
    public ref D3D12_DEVICE_REMOVED_EXTENDED_DATA Dred_1_0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Dred_1_0, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Dred_1_1"]/*' />
    public ref D3D12_DEVICE_REMOVED_EXTENDED_DATA1 Dred_1_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Dred_1_1, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Dred_1_2"]/*' />
    public ref D3D12_DEVICE_REMOVED_EXTENDED_DATA2 Dred_1_2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Dred_1_2, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Dred_1_3"]/*' />
    public ref D3D12_DEVICE_REMOVED_EXTENDED_DATA3 Dred_1_3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Dred_1_3, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Dred_1_0"]/*' />
        [FieldOffset(0)]
        public D3D12_DEVICE_REMOVED_EXTENDED_DATA Dred_1_0;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Dred_1_1"]/*' />
        [FieldOffset(0)]
        public D3D12_DEVICE_REMOVED_EXTENDED_DATA1 Dred_1_1;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Dred_1_2"]/*' />
        [FieldOffset(0)]
        public D3D12_DEVICE_REMOVED_EXTENDED_DATA2 Dred_1_2;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Dred_1_3"]/*' />
        [FieldOffset(0)]
        public D3D12_DEVICE_REMOVED_EXTENDED_DATA3 Dred_1_3;
    }
}
