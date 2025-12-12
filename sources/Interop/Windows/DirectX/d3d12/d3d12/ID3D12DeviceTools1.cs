// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12DeviceTools1.xml' path='doc/member[@name="ID3D12DeviceTools1"]/*' />
[Guid("E30E9FC7-E641-4D6E-8A81-9DD9206EC47A")]
[NativeTypeName("struct ID3D12DeviceTools1 : ID3D12DeviceTools")]
[NativeInheritance("ID3D12DeviceTools")]
public unsafe partial struct ID3D12DeviceTools1 : ID3D12DeviceTools1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12DeviceTools1);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DeviceTools1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DeviceTools1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DeviceTools1*, uint>)(lpVtbl[1]))((ID3D12DeviceTools1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DeviceTools1*, uint>)(lpVtbl[2]))((ID3D12DeviceTools1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12DeviceTools.SetNextAllocationAddress" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetNextAllocationAddress([NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong nextAllocationVirtualAddress)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12DeviceTools1*, ulong, void>)(lpVtbl[3]))((ID3D12DeviceTools1*)Unsafe.AsPointer(ref this), nextAllocationVirtualAddress);
    }

    /// <include file='ID3D12DeviceTools1.xml' path='doc/member[@name="ID3D12DeviceTools1.GetApplicationSpecificDriverState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetApplicationSpecificDriverState(ID3DBlob** ppBlob)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DeviceTools1*, ID3DBlob**, int>)(lpVtbl[4]))((ID3D12DeviceTools1*)Unsafe.AsPointer(ref this), ppBlob);
    }

    /// <include file='ID3D12DeviceTools1.xml' path='doc/member[@name="ID3D12DeviceTools1.GetApplicationSpecificDriverBlobStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public D3D12_APPLICATION_SPECIFIC_DRIVER_BLOB_STATUS GetApplicationSpecificDriverBlobStatus()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DeviceTools1*, D3D12_APPLICATION_SPECIFIC_DRIVER_BLOB_STATUS>)(lpVtbl[5]))((ID3D12DeviceTools1*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ID3D12DeviceTools.Interface
    {
        [VtblIndex(4)]
        HRESULT GetApplicationSpecificDriverState(ID3DBlob** ppBlob);

        [VtblIndex(5)]
        D3D12_APPLICATION_SPECIFIC_DRIVER_BLOB_STATUS GetApplicationSpecificDriverBlobStatus();
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

        [NativeTypeName("HRESULT (ID3DBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3DBlob**, int> GetApplicationSpecificDriverState;

        [NativeTypeName("D3D12_APPLICATION_SPECIFIC_DRIVER_BLOB_STATUS () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_APPLICATION_SPECIFIC_DRIVER_BLOB_STATUS> GetApplicationSpecificDriverBlobStatus;
    }
}
