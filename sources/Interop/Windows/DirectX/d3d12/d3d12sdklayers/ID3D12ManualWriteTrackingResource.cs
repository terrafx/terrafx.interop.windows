// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12ManualWriteTrackingResource.xml' path='doc/member[@name="ID3D12ManualWriteTrackingResource"]/*' />
[Guid("86CA3B85-49AD-4B6E-AED5-EDDB18540F41")]
[NativeTypeName("struct ID3D12ManualWriteTrackingResource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12ManualWriteTrackingResource : ID3D12ManualWriteTrackingResource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12ManualWriteTrackingResource);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ManualWriteTrackingResource*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12ManualWriteTrackingResource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ManualWriteTrackingResource*, uint>)(lpVtbl[1]))((ID3D12ManualWriteTrackingResource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ManualWriteTrackingResource*, uint>)(lpVtbl[2]))((ID3D12ManualWriteTrackingResource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12ManualWriteTrackingResource.xml' path='doc/member[@name="ID3D12ManualWriteTrackingResource.TrackWrite"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void TrackWrite(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pWrittenRange)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12ManualWriteTrackingResource*, uint, D3D12_RANGE*, void>)(lpVtbl[3]))((ID3D12ManualWriteTrackingResource*)Unsafe.AsPointer(ref this), Subresource, pWrittenRange);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void TrackWrite(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pWrittenRange);
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

        [NativeTypeName("void (UINT, const D3D12_RANGE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3D12_RANGE*, void> TrackWrite;
    }
}
