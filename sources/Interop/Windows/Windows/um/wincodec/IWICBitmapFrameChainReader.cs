// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWICBitmapFrameChainReader.xml' path='doc/member[@name="IWICBitmapFrameChainReader"]/*' />
[Guid("0C599495-A120-4222-9130-A8C29410BD0B")]
[NativeTypeName("struct IWICBitmapFrameChainReader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICBitmapFrameChainReader : IWICBitmapFrameChainReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWICBitmapFrameChainReader);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapFrameChainReader*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapFrameChainReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapFrameChainReader*, uint>)(lpVtbl[1]))((IWICBitmapFrameChainReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapFrameChainReader*, uint>)(lpVtbl[2]))((IWICBitmapFrameChainReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICBitmapFrameChainReader.xml' path='doc/member[@name="IWICBitmapFrameChainReader.GetChainedFrameCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetChainedFrameCount(WICBitmapChainType chainType, uint* pCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapFrameChainReader*, WICBitmapChainType, uint*, int>)(lpVtbl[3]))((IWICBitmapFrameChainReader*)Unsafe.AsPointer(ref this), chainType, pCount);
    }

    /// <include file='IWICBitmapFrameChainReader.xml' path='doc/member[@name="IWICBitmapFrameChainReader.GetChainedFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetChainedFrame(WICBitmapChainType chainType, uint index, IWICBitmapFrameDecode** ppIBitmapFrame)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapFrameChainReader*, WICBitmapChainType, uint, IWICBitmapFrameDecode**, int>)(lpVtbl[4]))((IWICBitmapFrameChainReader*)Unsafe.AsPointer(ref this), chainType, index, ppIBitmapFrame);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetChainedFrameCount(WICBitmapChainType chainType, uint* pCount);

        [VtblIndex(4)]
        HRESULT GetChainedFrame(WICBitmapChainType chainType, uint index, IWICBitmapFrameDecode** ppIBitmapFrame);
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

        [NativeTypeName("HRESULT (WICBitmapChainType, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WICBitmapChainType, uint*, int> GetChainedFrameCount;

        [NativeTypeName("HRESULT (WICBitmapChainType, UINT, IWICBitmapFrameDecode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WICBitmapChainType, uint, IWICBitmapFrameDecode**, int> GetChainedFrame;
    }
}
