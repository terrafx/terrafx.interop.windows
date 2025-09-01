// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12DSRDeviceFactory.xml' path='doc/member[@name="ID3D12DSRDeviceFactory"]/*' />
[Guid("F343D1A0-AFE3-439F-B13D-CD87A43B70CA")]
[NativeTypeName("struct ID3D12DSRDeviceFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DSRDeviceFactory : ID3D12DSRDeviceFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12DSRDeviceFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DSRDeviceFactory*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DSRDeviceFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DSRDeviceFactory*, uint>)(lpVtbl[1]))((ID3D12DSRDeviceFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DSRDeviceFactory*, uint>)(lpVtbl[2]))((ID3D12DSRDeviceFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12DSRDeviceFactory.xml' path='doc/member[@name="ID3D12DSRDeviceFactory.CreateDSRDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateDSRDevice(ID3D12Device* pD3D12Device, uint NodeMask, [NativeTypeName("const IID &")] Guid* riid, void** ppvDSRDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)(lpVtbl[3]))((ID3D12DSRDeviceFactory*)Unsafe.AsPointer(ref this), pD3D12Device, NodeMask, riid, ppvDSRDevice);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateDSRDevice(ID3D12Device* pD3D12Device, uint NodeMask, [NativeTypeName("const IID &")] Guid* riid, void** ppvDSRDevice);
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

        [NativeTypeName("HRESULT (ID3D12Device *, UINT, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12Device*, uint, Guid*, void**, int> CreateDSRDevice;
    }
}
