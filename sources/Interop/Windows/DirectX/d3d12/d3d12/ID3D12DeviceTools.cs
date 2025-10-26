// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12DeviceTools.xml' path='doc/member[@name="ID3D12DeviceTools"]/*' />
[Guid("2EA68E9C-19C3-4E47-A109-6CDADFF0ACA9")]
[NativeTypeName("struct ID3D12DeviceTools : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DeviceTools : ID3D12DeviceTools.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12DeviceTools);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DeviceTools*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DeviceTools*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DeviceTools*, uint>)(lpVtbl[1]))((ID3D12DeviceTools*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DeviceTools*, uint>)(lpVtbl[2]))((ID3D12DeviceTools*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12DeviceTools.xml' path='doc/member[@name="ID3D12DeviceTools.SetNextAllocationAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetNextAllocationAddress([NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong nextAllocationVirtualAddress)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12DeviceTools*, ulong, void>)(lpVtbl[3]))((ID3D12DeviceTools*)Unsafe.AsPointer(ref this), nextAllocationVirtualAddress);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void SetNextAllocationAddress([NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong nextAllocationVirtualAddress);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("void (D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, void> SetNextAllocationAddress;
    }
}
