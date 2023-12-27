// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBitmapEncoder.xml' path='doc/member[@name="IBitmapEncoder"]/*' />
[Guid("2BC468E3-E1F8-4B54-95E8-32919551CE62")]
[NativeTypeName("struct IBitmapEncoder : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBitmapEncoder : IBitmapEncoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBitmapEncoder));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, Guid*, void**, int>)(lpVtbl[0]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, uint>)(lpVtbl[1]))((IBitmapEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, uint>)(lpVtbl[2]))((IBitmapEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, uint*, Guid**, int>)(lpVtbl[3]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, HSTRING*, int>)(lpVtbl[4]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, TrustLevel*, int>)(lpVtbl[5]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBitmapEncoder.xml' path='doc/member[@name="IBitmapEncoder.get_EncoderInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EncoderInformation([NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapCodecInformation **")] IBitmapCodecInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, IBitmapCodecInformation**, int>)(lpVtbl[6]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapEncoder.xml' path='doc/member[@name="IBitmapEncoder.get_BitmapProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BitmapProperties([NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapProperties **")] IBitmapProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, IBitmapProperties**, int>)(lpVtbl[7]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapEncoder.xml' path='doc/member[@name="IBitmapEncoder.get_BitmapContainerProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BitmapContainerProperties([NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapProperties **")] IBitmapProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, IBitmapProperties**, int>)(lpVtbl[8]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapEncoder.xml' path='doc/member[@name="IBitmapEncoder.get_IsThumbnailGenerated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsThumbnailGenerated([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, byte*, int>)(lpVtbl[9]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapEncoder.xml' path='doc/member[@name="IBitmapEncoder.put_IsThumbnailGenerated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_IsThumbnailGenerated([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, byte, int>)(lpVtbl[10]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapEncoder.xml' path='doc/member[@name="IBitmapEncoder.get_GeneratedThumbnailWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_GeneratedThumbnailWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, uint*, int>)(lpVtbl[11]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapEncoder.xml' path='doc/member[@name="IBitmapEncoder.put_GeneratedThumbnailWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_GeneratedThumbnailWidth([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, uint, int>)(lpVtbl[12]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapEncoder.xml' path='doc/member[@name="IBitmapEncoder.get_GeneratedThumbnailHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_GeneratedThumbnailHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, uint*, int>)(lpVtbl[13]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapEncoder.xml' path='doc/member[@name="IBitmapEncoder.put_GeneratedThumbnailHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_GeneratedThumbnailHeight([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, uint, int>)(lpVtbl[14]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapEncoder.xml' path='doc/member[@name="IBitmapEncoder.get_BitmapTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_BitmapTransform([NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapTransform **")] IBitmapTransform** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, IBitmapTransform**, int>)(lpVtbl[15]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapEncoder.xml' path='doc/member[@name="IBitmapEncoder.SetPixelData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetPixelData([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alphaMode, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, double dpiX, double dpiY, [NativeTypeName("UINT32")] uint pixelsLength, byte* pixels)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, BitmapPixelFormat, BitmapAlphaMode, uint, uint, double, double, uint, byte*, int>)(lpVtbl[16]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), pixelFormat, alphaMode, width, height, dpiX, dpiY, pixelsLength, pixels);
    }

    /// <include file='IBitmapEncoder.xml' path='doc/member[@name="IBitmapEncoder.GoToNextFrameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GoToNextFrameAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, IAsyncAction**, int>)(lpVtbl[17]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    /// <include file='IBitmapEncoder.xml' path='doc/member[@name="IBitmapEncoder.GoToNextFrameWithEncodingOptionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GoToNextFrameWithEncodingOptionsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CGraphics__CImaging__CBitmapTypedValue_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IBitmapTypedValue>>>>* encodingOptions, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IBitmapTypedValue>>>>*, IAsyncAction**, int>)(lpVtbl[18]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), encodingOptions, asyncInfo);
    }

    /// <include file='IBitmapEncoder.xml' path='doc/member[@name="IBitmapEncoder.FlushAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT FlushAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoder*, IAsyncAction**, int>)(lpVtbl[19]))((IBitmapEncoder*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EncoderInformation([NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapCodecInformation **")] IBitmapCodecInformation** value);

        [VtblIndex(7)]
        HRESULT get_BitmapProperties([NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapProperties **")] IBitmapProperties** value);

        [VtblIndex(8)]
        HRESULT get_BitmapContainerProperties([NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapProperties **")] IBitmapProperties** value);

        [VtblIndex(9)]
        HRESULT get_IsThumbnailGenerated([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT put_IsThumbnailGenerated([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT get_GeneratedThumbnailWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT put_GeneratedThumbnailWidth([NativeTypeName("UINT32")] uint value);

        [VtblIndex(13)]
        HRESULT get_GeneratedThumbnailHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        HRESULT put_GeneratedThumbnailHeight([NativeTypeName("UINT32")] uint value);

        [VtblIndex(15)]
        HRESULT get_BitmapTransform([NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapTransform **")] IBitmapTransform** value);

        [VtblIndex(16)]
        HRESULT SetPixelData([NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")] BitmapPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alphaMode, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, double dpiX, double dpiY, [NativeTypeName("UINT32")] uint pixelsLength, byte* pixels);

        [VtblIndex(17)]
        HRESULT GoToNextFrameAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(18)]
        HRESULT GoToNextFrameWithEncodingOptionsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CGraphics__CImaging__CBitmapTypedValue_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IBitmapTypedValue>>>>* encodingOptions, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(19)]
        HRESULT FlushAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::IBitmapCodecInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBitmapCodecInformation**, int> get_EncoderInformation;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::IBitmapProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBitmapProperties**, int> get_BitmapProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::IBitmapProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBitmapProperties**, int> get_BitmapContainerProperties;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsThumbnailGenerated;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsThumbnailGenerated;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_GeneratedThumbnailWidth;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_GeneratedThumbnailWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_GeneratedThumbnailHeight;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_GeneratedThumbnailHeight;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::IBitmapTransform **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBitmapTransform**, int> get_BitmapTransform;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat, ABI::Windows::Graphics::Imaging::BitmapAlphaMode, UINT32, UINT32, DOUBLE, DOUBLE, UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BitmapPixelFormat, BitmapAlphaMode, uint, uint, double, double, uint, byte*, int> SetPixelData;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> GoToNextFrameAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CGraphics__CImaging__CBitmapTypedValue_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IBitmapTypedValue>>>>*, IAsyncAction**, int> GoToNextFrameWithEncodingOptionsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> FlushAsync;
    }
}
