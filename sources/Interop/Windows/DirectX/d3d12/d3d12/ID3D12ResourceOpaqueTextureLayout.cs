// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12ResourceOpaqueTextureLayout.xml' path='doc/member[@name="ID3D12ResourceOpaqueTextureLayout"]/*' />
[Guid("A7C3F1E8-2B94-4D06-9F5A-E8D1C40B7263")]
[NativeTypeName("struct ID3D12ResourceOpaqueTextureLayout : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12ResourceOpaqueTextureLayout : ID3D12ResourceOpaqueTextureLayout.Interface, INativeGuid
{
    /// <include file='ID3D12ResourceOpaqueTextureLayout.xml' path='doc/member[@name="ID3D12ResourceOpaqueTextureLayout.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12ResourceOpaqueTextureLayout);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ResourceOpaqueTextureLayout*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12ResourceOpaqueTextureLayout*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ResourceOpaqueTextureLayout*, uint>)(lpVtbl[1]))((ID3D12ResourceOpaqueTextureLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ResourceOpaqueTextureLayout*, uint>)(lpVtbl[2]))((ID3D12ResourceOpaqueTextureLayout*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12ResourceOpaqueTextureLayout.xml' path='doc/member[@name="ID3D12ResourceOpaqueTextureLayout.GetOpaqueTextureRowMajorLayoutInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOpaqueTextureRowMajorLayoutInfo(uint FirstSubresource, uint NumSubresources, D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO* pLayoutInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12ResourceOpaqueTextureLayout*, uint, uint, D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO*, int>)(lpVtbl[3]))((ID3D12ResourceOpaqueTextureLayout*)Unsafe.AsPointer(ref this), FirstSubresource, NumSubresources, pLayoutInfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetOpaqueTextureRowMajorLayoutInfo(uint FirstSubresource, uint NumSubresources, D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO* pLayoutInfo);
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

        [NativeTypeName("HRESULT (UINT, UINT, D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO*, int> GetOpaqueTextureRowMajorLayoutInfo;
    }
}
