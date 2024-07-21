// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWICBitmapSourceTransform2.xml' path='doc/member[@name="IWICBitmapSourceTransform2"]/*' />
[Guid("C3373FDF-6D39-4E5F-8E79-BF40C0B7ED77")]
[NativeTypeName("struct IWICBitmapSourceTransform2 : IWICBitmapSourceTransform")]
[NativeInheritance("IWICBitmapSourceTransform")]
public unsafe partial struct IWICBitmapSourceTransform2 : IWICBitmapSourceTransform2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapSourceTransform2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapSourceTransform2*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapSourceTransform2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapSourceTransform2*, uint>)(lpVtbl[1]))((IWICBitmapSourceTransform2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapSourceTransform2*, uint>)(lpVtbl[2]))((IWICBitmapSourceTransform2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWICBitmapSourceTransform.CopyPixels" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint uiWidth, uint uiHeight, [NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat, WICBitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapSourceTransform2*, WICRect*, uint, uint, Guid*, WICBitmapTransformOptions, uint, uint, byte*, int>)(lpVtbl[3]))((IWICBitmapSourceTransform2*)Unsafe.AsPointer(ref this), prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBuffer);
    }

    /// <inheritdoc cref="IWICBitmapSourceTransform.GetClosestSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetClosestSize(uint* puiWidth, uint* puiHeight)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapSourceTransform2*, uint*, uint*, int>)(lpVtbl[4]))((IWICBitmapSourceTransform2*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
    }

    /// <inheritdoc cref="IWICBitmapSourceTransform.GetClosestPixelFormat" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetClosestPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapSourceTransform2*, Guid*, int>)(lpVtbl[5]))((IWICBitmapSourceTransform2*)Unsafe.AsPointer(ref this), pguidDstFormat);
    }

    /// <inheritdoc cref="IWICBitmapSourceTransform.DoesSupportTransform" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DoesSupportTransform(WICBitmapTransformOptions dstTransform, BOOL* pfIsSupported)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapSourceTransform2*, WICBitmapTransformOptions, BOOL*, int>)(lpVtbl[6]))((IWICBitmapSourceTransform2*)Unsafe.AsPointer(ref this), dstTransform, pfIsSupported);
    }

    /// <include file='IWICBitmapSourceTransform2.xml' path='doc/member[@name="IWICBitmapSourceTransform2.GetColorContextsForPixelFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetColorContextsForPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat, uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapSourceTransform2*, Guid*, uint, IWICColorContext**, uint*, int>)(lpVtbl[7]))((IWICBitmapSourceTransform2*)Unsafe.AsPointer(ref this), pPixelFormat, cCount, ppIColorContexts, pcActualCount);
    }

    public interface Interface : IWICBitmapSourceTransform.Interface
    {
        [VtblIndex(7)]
        HRESULT GetColorContextsForPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat, uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount);
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

        [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, WICPixelFormatGUID *, WICBitmapTransformOptions, UINT, UINT, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, Guid*, WICBitmapTransformOptions, uint, uint, byte*, int> CopyPixels;

        [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetClosestSize;

        [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetClosestPixelFormat;

        [NativeTypeName("HRESULT (WICBitmapTransformOptions, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WICBitmapTransformOptions, BOOL*, int> DoesSupportTransform;

        [NativeTypeName("HRESULT (WICPixelFormatGUID *, UINT, IWICColorContext **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint, IWICColorContext**, uint*, int> GetColorContextsForPixelFormat;
    }
}
