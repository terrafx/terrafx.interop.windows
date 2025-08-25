// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDCompositionDynamicTexture.xml' path='doc/member[@name="IDCompositionDynamicTexture"]/*' />
[Guid("A1DE1D3F-6405-447F-8E95-1383A34B0277")]
[NativeTypeName("struct IDCompositionDynamicTexture : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDCompositionDynamicTexture : IDCompositionDynamicTexture.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDCompositionDynamicTexture);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionDynamicTexture*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionDynamicTexture*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionDynamicTexture*, uint>)(lpVtbl[1]))((IDCompositionDynamicTexture*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionDynamicTexture*, uint>)(lpVtbl[2]))((IDCompositionDynamicTexture*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionDynamicTexture.xml' path='doc/member[@name="IDCompositionDynamicTexture.SetTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetTexture(IDCompositionTexture* pTexture, [NativeTypeName("const D2D_RECT_L *")] RECT* pRects, [NativeTypeName("size_t")] nuint rectCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionDynamicTexture*, IDCompositionTexture*, RECT*, nuint, int>)(lpVtbl[3]))((IDCompositionDynamicTexture*)Unsafe.AsPointer(ref this), pTexture, pRects, rectCount);
    }

    /// <include file='IDCompositionDynamicTexture.xml' path='doc/member[@name="IDCompositionDynamicTexture.SetTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTexture(IDCompositionTexture* pTexture)
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionDynamicTexture*, IDCompositionTexture*, int>)(lpVtbl[4]))((IDCompositionDynamicTexture*)Unsafe.AsPointer(ref this), pTexture);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetTexture(IDCompositionTexture* pTexture, [NativeTypeName("const D2D_RECT_L *")] RECT* pRects, [NativeTypeName("size_t")] nuint rectCount);

        [VtblIndex(4)]
        HRESULT SetTexture(IDCompositionTexture* pTexture);
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

        [NativeTypeName("HRESULT (IDCompositionTexture *, const D2D_RECT_L *, size_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDCompositionTexture*, RECT*, nuint, int> SetTexture;

        [NativeTypeName("HRESULT (IDCompositionTexture *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDCompositionTexture*, int> SetTexture1;
    }
}
