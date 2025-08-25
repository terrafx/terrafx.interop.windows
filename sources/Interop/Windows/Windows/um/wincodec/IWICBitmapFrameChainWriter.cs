// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWICBitmapFrameChainWriter.xml' path='doc/member[@name="IWICBitmapFrameChainWriter"]/*' />
[Guid("40D9EA28-4768-47B3-8C12-558A48E98E38")]
[NativeTypeName("struct IWICBitmapFrameChainWriter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICBitmapFrameChainWriter : IWICBitmapFrameChainWriter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWICBitmapFrameChainWriter);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapFrameChainWriter*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapFrameChainWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapFrameChainWriter*, uint>)(lpVtbl[1]))((IWICBitmapFrameChainWriter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapFrameChainWriter*, uint>)(lpVtbl[2]))((IWICBitmapFrameChainWriter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICBitmapFrameChainWriter.xml' path='doc/member[@name="IWICBitmapFrameChainWriter.AppendFrameToChain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AppendFrameToChain(WICBitmapChainType chainType, IWICBitmapFrameEncode** ppIFrameEncode, IPropertyBag2** ppIEncoderOptions)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapFrameChainWriter*, WICBitmapChainType, IWICBitmapFrameEncode**, IPropertyBag2**, int>)(lpVtbl[3]))((IWICBitmapFrameChainWriter*)Unsafe.AsPointer(ref this), chainType, ppIFrameEncode, ppIEncoderOptions);
    }

    /// <include file='IWICBitmapFrameChainWriter.xml' path='doc/member[@name="IWICBitmapFrameChainWriter.DoesSupportChainType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DoesSupportChainType(WICBitmapChainType chainType, BOOL* pfIsSupported)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapFrameChainWriter*, WICBitmapChainType, BOOL*, int>)(lpVtbl[4]))((IWICBitmapFrameChainWriter*)Unsafe.AsPointer(ref this), chainType, pfIsSupported);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AppendFrameToChain(WICBitmapChainType chainType, IWICBitmapFrameEncode** ppIFrameEncode, IPropertyBag2** ppIEncoderOptions);

        [VtblIndex(4)]
        HRESULT DoesSupportChainType(WICBitmapChainType chainType, BOOL* pfIsSupported);
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

        [NativeTypeName("HRESULT (WICBitmapChainType, IWICBitmapFrameEncode **, IPropertyBag2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WICBitmapChainType, IWICBitmapFrameEncode**, IPropertyBag2**, int> AppendFrameToChain;

        [NativeTypeName("HRESULT (WICBitmapChainType, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WICBitmapChainType, BOOL*, int> DoesSupportChainType;
    }
}
