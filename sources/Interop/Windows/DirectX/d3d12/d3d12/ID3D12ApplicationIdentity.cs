// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.619.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12ApplicationIdentity.xml' path='doc/member[@name="ID3D12ApplicationIdentity"]/*' />
[Guid("82DC6C85-727B-4A8D-9169-DB6CE3E975A0")]
[NativeTypeName("struct ID3D12ApplicationIdentity : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12ApplicationIdentity : ID3D12ApplicationIdentity.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12ApplicationIdentity);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ApplicationIdentity*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12ApplicationIdentity*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ApplicationIdentity*, uint>)(lpVtbl[1]))((ID3D12ApplicationIdentity*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ApplicationIdentity*, uint>)(lpVtbl[2]))((ID3D12ApplicationIdentity*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12ApplicationIdentity.xml' path='doc/member[@name="ID3D12ApplicationIdentity.SetApplicationIdentity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetApplicationIdentity([NativeTypeName("const D3D12_APPLICATION_DESC *")] D3D12_APPLICATION_DESC* pDesc, [NativeTypeName("const GUID &")] Guid* AppId)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ApplicationIdentity*, D3D12_APPLICATION_DESC*, Guid*, int>)(lpVtbl[3]))((ID3D12ApplicationIdentity*)Unsafe.AsPointer(ref this), pDesc, AppId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetApplicationIdentity([NativeTypeName("const D3D12_APPLICATION_DESC *")] D3D12_APPLICATION_DESC* pDesc, [NativeTypeName("const GUID &")] Guid* AppId);
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

        [NativeTypeName("HRESULT (const D3D12_APPLICATION_DESC *, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_APPLICATION_DESC*, Guid*, int> SetApplicationIdentity;
    }
}
