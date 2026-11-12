// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12AsyncCommandsFallback.xml' path='doc/member[@name="ID3D12AsyncCommandsFallback"]/*' />
[Guid("FBDDF9E8-33A3-488C-9775-1A970DC54862")]
[NativeTypeName("struct ID3D12AsyncCommandsFallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12AsyncCommandsFallback : ID3D12AsyncCommandsFallback.Interface, INativeGuid
{
    /// <include file='ID3D12AsyncCommandsFallback.xml' path='doc/member[@name="ID3D12AsyncCommandsFallback.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12AsyncCommandsFallback);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12AsyncCommandsFallback*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12AsyncCommandsFallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12AsyncCommandsFallback*, uint>)(lpVtbl[1]))((ID3D12AsyncCommandsFallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12AsyncCommandsFallback*, uint>)(lpVtbl[2]))((ID3D12AsyncCommandsFallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12AsyncCommandsFallback.xml' path='doc/member[@name="ID3D12AsyncCommandsFallback.SetFallbackLayerEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFallbackLayerEnabled(BOOL Enable)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12AsyncCommandsFallback*, BOOL, int>)(lpVtbl[3]))((ID3D12AsyncCommandsFallback*)Unsafe.AsPointer(ref this), Enable);
    }

    /// <include file='ID3D12AsyncCommandsFallback.xml' path='doc/member[@name="ID3D12AsyncCommandsFallback.GetFallbackLayerEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public BOOL GetFallbackLayerEnabled()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12AsyncCommandsFallback*, int>)(lpVtbl[4]))((ID3D12AsyncCommandsFallback*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetFallbackLayerEnabled(BOOL Enable);

        [VtblIndex(4)]
        BOOL GetFallbackLayerEnabled();
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

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, int> SetFallbackLayerEnabled;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> GetFallbackLayerEnabled;
    }
}
