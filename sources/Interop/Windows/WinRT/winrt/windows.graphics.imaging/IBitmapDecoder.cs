// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBitmapDecoder.xml' path='doc/member[@name="IBitmapDecoder"]/*' />
[Guid("ACEF22BA-1D74-4C91-9DFC-9620745233E6")]
[NativeTypeName("struct IBitmapDecoder : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBitmapDecoder : IBitmapDecoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBitmapDecoder));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoder*, Guid*, void**, int>)(lpVtbl[0]))((IBitmapDecoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoder*, uint>)(lpVtbl[1]))((IBitmapDecoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoder*, uint>)(lpVtbl[2]))((IBitmapDecoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoder*, uint*, Guid**, int>)(lpVtbl[3]))((IBitmapDecoder*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoder*, HSTRING*, int>)(lpVtbl[4]))((IBitmapDecoder*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoder*, TrustLevel*, int>)(lpVtbl[5]))((IBitmapDecoder*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBitmapDecoder.xml' path='doc/member[@name="IBitmapDecoder.get_BitmapContainerProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BitmapContainerProperties([NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapPropertiesView **")] IBitmapPropertiesView** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoder*, IBitmapPropertiesView**, int>)(lpVtbl[6]))((IBitmapDecoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapDecoder.xml' path='doc/member[@name="IBitmapDecoder.get_DecoderInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DecoderInformation([NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapCodecInformation **")] IBitmapCodecInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoder*, IBitmapCodecInformation**, int>)(lpVtbl[7]))((IBitmapDecoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapDecoder.xml' path='doc/member[@name="IBitmapDecoder.get_FrameCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FrameCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoder*, uint*, int>)(lpVtbl[8]))((IBitmapDecoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapDecoder.xml' path='doc/member[@name="IBitmapDecoder.GetPreviewAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPreviewAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CImageStream_t **")] IAsyncOperation<Pointer<IntPtr>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoder*, IAsyncOperation<Pointer<IntPtr>>**, int>)(lpVtbl[9]))((IBitmapDecoder*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    /// <include file='IBitmapDecoder.xml' path='doc/member[@name="IBitmapDecoder.GetFrameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFrameAsync([NativeTypeName("UINT32")] uint frameIndex, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapFrame_t **")] IAsyncOperation<Pointer<IBitmapFrame>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoder*, uint, IAsyncOperation<Pointer<IBitmapFrame>>**, int>)(lpVtbl[10]))((IBitmapDecoder*)Unsafe.AsPointer(ref this), frameIndex, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BitmapContainerProperties([NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapPropertiesView **")] IBitmapPropertiesView** value);

        [VtblIndex(7)]
        HRESULT get_DecoderInformation([NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapCodecInformation **")] IBitmapCodecInformation** value);

        [VtblIndex(8)]
        HRESULT get_FrameCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT GetPreviewAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CImageStream_t **")] IAsyncOperation<Pointer<IntPtr>>** asyncInfo);

        [VtblIndex(10)]
        HRESULT GetFrameAsync([NativeTypeName("UINT32")] uint frameIndex, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapFrame_t **")] IAsyncOperation<Pointer<IBitmapFrame>>** asyncInfo);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::IBitmapPropertiesView **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBitmapPropertiesView**, int> get_BitmapContainerProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::IBitmapCodecInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBitmapCodecInformation**, int> get_DecoderInformation;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_FrameCount;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CImageStream_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IntPtr>>**, int> GetPreviewAsync;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapFrame_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IAsyncOperation<Pointer<IBitmapFrame>>**, int> GetFrameAsync;
    }
}
