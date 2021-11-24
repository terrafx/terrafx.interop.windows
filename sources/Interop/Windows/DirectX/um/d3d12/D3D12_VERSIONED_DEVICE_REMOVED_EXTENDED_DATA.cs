// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

public partial struct D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA
{
    public D3D12_DRED_VERSION Version;

    [NativeTypeName("D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/d3d12.h:14400:5)")]
    public _Anonymous_e__Union Anonymous;

    public ref D3D12_DEVICE_REMOVED_EXTENDED_DATA Dred_1_0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Dred_1_0, 1));
        }
    }

    public ref D3D12_DEVICE_REMOVED_EXTENDED_DATA1 Dred_1_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Dred_1_1, 1));
        }
    }

    public ref D3D12_DEVICE_REMOVED_EXTENDED_DATA2 Dred_1_2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Dred_1_2, 1));
        }
    }

    public ref D3D12_DEVICE_REMOVED_EXTENDED_DATA3 Dred_1_3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Dred_1_3, 1));
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_DEVICE_REMOVED_EXTENDED_DATA Dred_1_0;

        [FieldOffset(0)]
        public D3D12_DEVICE_REMOVED_EXTENDED_DATA1 Dred_1_1;

        [FieldOffset(0)]
        public D3D12_DEVICE_REMOVED_EXTENDED_DATA2 Dred_1_2;

        [FieldOffset(0)]
        public D3D12_DEVICE_REMOVED_EXTENDED_DATA3 Dred_1_3;
    }
}
