// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBitmapDecoderStatics.xml' path='doc/member[@name="IBitmapDecoderStatics"]/*' />
[Guid("438CCB26-BCEF-4E95-BAD6-23A822E58D01")]
[NativeTypeName("struct IBitmapDecoderStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBitmapDecoderStatics : IBitmapDecoderStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBitmapDecoderStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoderStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBitmapDecoderStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoderStatics*, uint>)(lpVtbl[1]))((IBitmapDecoderStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoderStatics*, uint>)(lpVtbl[2]))((IBitmapDecoderStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoderStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBitmapDecoderStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoderStatics*, HSTRING*, int>)(lpVtbl[4]))((IBitmapDecoderStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoderStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBitmapDecoderStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBitmapDecoderStatics.xml' path='doc/member[@name="IBitmapDecoderStatics.get_BmpDecoderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BmpDecoderId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoderStatics*, Guid*, int>)(lpVtbl[6]))((IBitmapDecoderStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapDecoderStatics.xml' path='doc/member[@name="IBitmapDecoderStatics.get_JpegDecoderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_JpegDecoderId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoderStatics*, Guid*, int>)(lpVtbl[7]))((IBitmapDecoderStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapDecoderStatics.xml' path='doc/member[@name="IBitmapDecoderStatics.get_PngDecoderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PngDecoderId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoderStatics*, Guid*, int>)(lpVtbl[8]))((IBitmapDecoderStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapDecoderStatics.xml' path='doc/member[@name="IBitmapDecoderStatics.get_TiffDecoderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TiffDecoderId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoderStatics*, Guid*, int>)(lpVtbl[9]))((IBitmapDecoderStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapDecoderStatics.xml' path='doc/member[@name="IBitmapDecoderStatics.get_GifDecoderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_GifDecoderId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoderStatics*, Guid*, int>)(lpVtbl[10]))((IBitmapDecoderStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapDecoderStatics.xml' path='doc/member[@name="IBitmapDecoderStatics.get_JpegXRDecoderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_JpegXRDecoderId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoderStatics*, Guid*, int>)(lpVtbl[11]))((IBitmapDecoderStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapDecoderStatics.xml' path='doc/member[@name="IBitmapDecoderStatics.get_IcoDecoderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IcoDecoderId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoderStatics*, Guid*, int>)(lpVtbl[12]))((IBitmapDecoderStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapDecoderStatics.xml' path='doc/member[@name="IBitmapDecoderStatics.GetDecoderInformationEnumerator"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDecoderInformationEnumerator([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CImaging__CBitmapCodecInformation_t **")] IVectorView<Pointer<IBitmapCodecInformation>>** decoderInformationEnumerator)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoderStatics*, IVectorView<Pointer<IBitmapCodecInformation>>**, int>)(lpVtbl[13]))((IBitmapDecoderStatics*)Unsafe.AsPointer(ref this), decoderInformationEnumerator);
    }

    /// <include file='IBitmapDecoderStatics.xml' path='doc/member[@name="IBitmapDecoderStatics.CreateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapDecoder_t **")] IAsyncOperation<Pointer<IBitmapDecoder>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoderStatics*, IRandomAccessStream*, IAsyncOperation<Pointer<IBitmapDecoder>>**, int>)(lpVtbl[14]))((IBitmapDecoderStatics*)Unsafe.AsPointer(ref this), stream, asyncInfo);
    }

    /// <include file='IBitmapDecoderStatics.xml' path='doc/member[@name="IBitmapDecoderStatics.CreateWithIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateWithIdAsync(Guid decoderId, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapDecoder_t **")] IAsyncOperation<Pointer<IBitmapDecoder>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapDecoderStatics*, Guid, IRandomAccessStream*, IAsyncOperation<Pointer<IBitmapDecoder>>**, int>)(lpVtbl[15]))((IBitmapDecoderStatics*)Unsafe.AsPointer(ref this), decoderId, stream, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BmpDecoderId(Guid* value);

        [VtblIndex(7)]
        HRESULT get_JpegDecoderId(Guid* value);

        [VtblIndex(8)]
        HRESULT get_PngDecoderId(Guid* value);

        [VtblIndex(9)]
        HRESULT get_TiffDecoderId(Guid* value);

        [VtblIndex(10)]
        HRESULT get_GifDecoderId(Guid* value);

        [VtblIndex(11)]
        HRESULT get_JpegXRDecoderId(Guid* value);

        [VtblIndex(12)]
        HRESULT get_IcoDecoderId(Guid* value);

        [VtblIndex(13)]
        HRESULT GetDecoderInformationEnumerator([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CImaging__CBitmapCodecInformation_t **")] IVectorView<Pointer<IBitmapCodecInformation>>** decoderInformationEnumerator);

        [VtblIndex(14)]
        HRESULT CreateAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapDecoder_t **")] IAsyncOperation<Pointer<IBitmapDecoder>>** asyncInfo);

        [VtblIndex(15)]
        HRESULT CreateWithIdAsync(Guid decoderId, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapDecoder_t **")] IAsyncOperation<Pointer<IBitmapDecoder>>** asyncInfo);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_BmpDecoderId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_JpegDecoderId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_PngDecoderId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_TiffDecoderId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_GifDecoderId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_JpegXRDecoderId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_IcoDecoderId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CImaging__CBitmapCodecInformation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IBitmapCodecInformation>>**, int> GetDecoderInformationEnumerator;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapDecoder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream*, IAsyncOperation<Pointer<IBitmapDecoder>>**, int> CreateAsync;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapDecoder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, IRandomAccessStream*, IAsyncOperation<Pointer<IBitmapDecoder>>**, int> CreateWithIdAsync;
    }
}
