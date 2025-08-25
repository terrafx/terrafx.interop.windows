// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDCompositionTexture.xml' path='doc/member[@name="IDCompositionTexture"]/*' />
[Guid("929BB1AA-725F-433B-ABD7-273075A835F2")]
[NativeTypeName("struct IDCompositionTexture : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDCompositionTexture : IDCompositionTexture.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDCompositionTexture);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionTexture*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionTexture*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionTexture*, uint>)(lpVtbl[1]))((IDCompositionTexture*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionTexture*, uint>)(lpVtbl[2]))((IDCompositionTexture*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionTexture.xml' path='doc/member[@name="IDCompositionTexture.SetSourceRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSourceRect([NativeTypeName("const D2D_RECT_U &")] D2D_RECT_U* sourceRect)
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionTexture*, D2D_RECT_U*, int>)(lpVtbl[3]))((IDCompositionTexture*)Unsafe.AsPointer(ref this), sourceRect);
    }

    /// <include file='IDCompositionTexture.xml' path='doc/member[@name="IDCompositionTexture.SetColorSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace)
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionTexture*, DXGI_COLOR_SPACE_TYPE, int>)(lpVtbl[4]))((IDCompositionTexture*)Unsafe.AsPointer(ref this), colorSpace);
    }

    /// <include file='IDCompositionTexture.xml' path='doc/member[@name="IDCompositionTexture.SetAlphaMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetAlphaMode(DXGI_ALPHA_MODE alphaMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionTexture*, DXGI_ALPHA_MODE, int>)(lpVtbl[5]))((IDCompositionTexture*)Unsafe.AsPointer(ref this), alphaMode);
    }

    /// <include file='IDCompositionTexture.xml' path='doc/member[@name="IDCompositionTexture.GetAvailableFence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAvailableFence([NativeTypeName("UINT64 *")] ulong* fenceValue, [NativeTypeName("const IID &")] Guid* iid, void** availableFence)
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionTexture*, ulong*, Guid*, void**, int>)(lpVtbl[6]))((IDCompositionTexture*)Unsafe.AsPointer(ref this), fenceValue, iid, availableFence);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetSourceRect([NativeTypeName("const D2D_RECT_U &")] D2D_RECT_U* sourceRect);

        [VtblIndex(4)]
        HRESULT SetColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace);

        [VtblIndex(5)]
        HRESULT SetAlphaMode(DXGI_ALPHA_MODE alphaMode);

        [VtblIndex(6)]
        HRESULT GetAvailableFence([NativeTypeName("UINT64 *")] ulong* fenceValue, [NativeTypeName("const IID &")] Guid* iid, void** availableFence);
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

        [NativeTypeName("HRESULT (const D2D_RECT_U &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D2D_RECT_U*, int> SetSourceRect;

        [NativeTypeName("HRESULT (DXGI_COLOR_SPACE_TYPE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXGI_COLOR_SPACE_TYPE, int> SetColorSpace;

        [NativeTypeName("HRESULT (DXGI_ALPHA_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXGI_ALPHA_MODE, int> SetAlphaMode;

        [NativeTypeName("HRESULT (UINT64 *, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, Guid*, void**, int> GetAvailableFence;
    }
}
