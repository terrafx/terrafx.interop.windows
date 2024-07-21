// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCapture5.xml' path='doc/member[@name="IMediaCapture5"]/*' />
[Guid("DA787C22-3A9B-4720-A71E-97900A316E5A")]
[NativeTypeName("struct IMediaCapture5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCapture5 : IMediaCapture5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCapture5));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture5*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCapture5*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture5*, uint>)(lpVtbl[1]))((IMediaCapture5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture5*, uint>)(lpVtbl[2]))((IMediaCapture5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture5*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCapture5*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture5*, HSTRING*, int>)(lpVtbl[4]))((IMediaCapture5*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture5*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCapture5*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCapture5.xml' path='doc/member[@name="IMediaCapture5.RemoveEffectAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveEffectAsync([NativeTypeName("ABI::Windows::Media::IMediaExtension *")] IMediaExtension* effect, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture5*, IMediaExtension*, IAsyncAction**, int>)(lpVtbl[6]))((IMediaCapture5*)Unsafe.AsPointer(ref this), effect, asyncInfo);
    }

    /// <include file='IMediaCapture5.xml' path='doc/member[@name="IMediaCapture5.PauseRecordWithResultAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT PauseRecordWithResultAsync([NativeTypeName("ABI::Windows::Media::Devices::MediaCapturePauseBehavior")] MediaCapturePauseBehavior behavior, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CMediaCapturePauseResult_t **")] IAsyncOperation<Pointer<IMediaCapturePauseResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture5*, MediaCapturePauseBehavior, IAsyncOperation<Pointer<IMediaCapturePauseResult>>**, int>)(lpVtbl[7]))((IMediaCapture5*)Unsafe.AsPointer(ref this), behavior, operation);
    }

    /// <include file='IMediaCapture5.xml' path='doc/member[@name="IMediaCapture5.StopRecordWithResultAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StopRecordWithResultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CMediaCaptureStopResult_t **")] IAsyncOperation<Pointer<IMediaCaptureStopResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture5*, IAsyncOperation<Pointer<IMediaCaptureStopResult>>**, int>)(lpVtbl[8]))((IMediaCapture5*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IMediaCapture5.xml' path='doc/member[@name="IMediaCapture5.get_FrameSources"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_FrameSources([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CMedia__CCapture__CFrames__CMediaFrameSource_t **")] IMapView<HSTRING, Pointer<IMediaFrameSource>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture5*, IMapView<HSTRING, Pointer<IMediaFrameSource>>**, int>)(lpVtbl[9]))((IMediaCapture5*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCapture5.xml' path='doc/member[@name="IMediaCapture5.CreateFrameReaderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateFrameReaderAsync([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSource *")] IMediaFrameSource* inputSource, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **")] IAsyncOperation<Pointer<IMediaFrameReader>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture5*, IMediaFrameSource*, IAsyncOperation<Pointer<IMediaFrameReader>>**, int>)(lpVtbl[10]))((IMediaCapture5*)Unsafe.AsPointer(ref this), inputSource, value);
    }

    /// <include file='IMediaCapture5.xml' path='doc/member[@name="IMediaCapture5.CreateFrameReaderWithSubtypeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateFrameReaderWithSubtypeAsync([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSource *")] IMediaFrameSource* inputSource, HSTRING outputSubtype, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **")] IAsyncOperation<Pointer<IMediaFrameReader>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture5*, IMediaFrameSource*, HSTRING, IAsyncOperation<Pointer<IMediaFrameReader>>**, int>)(lpVtbl[11]))((IMediaCapture5*)Unsafe.AsPointer(ref this), inputSource, outputSubtype, value);
    }

    /// <include file='IMediaCapture5.xml' path='doc/member[@name="IMediaCapture5.CreateFrameReaderWithSubtypeAndSizeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateFrameReaderWithSubtypeAndSizeAsync([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSource *")] IMediaFrameSource* inputSource, HSTRING outputSubtype, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize")] BitmapSize outputSize, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **")] IAsyncOperation<Pointer<IMediaFrameReader>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture5*, IMediaFrameSource*, HSTRING, BitmapSize, IAsyncOperation<Pointer<IMediaFrameReader>>**, int>)(lpVtbl[12]))((IMediaCapture5*)Unsafe.AsPointer(ref this), inputSource, outputSubtype, outputSize, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RemoveEffectAsync([NativeTypeName("ABI::Windows::Media::IMediaExtension *")] IMediaExtension* effect, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(7)]
        HRESULT PauseRecordWithResultAsync([NativeTypeName("ABI::Windows::Media::Devices::MediaCapturePauseBehavior")] MediaCapturePauseBehavior behavior, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CMediaCapturePauseResult_t **")] IAsyncOperation<Pointer<IMediaCapturePauseResult>>** operation);

        [VtblIndex(8)]
        HRESULT StopRecordWithResultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CMediaCaptureStopResult_t **")] IAsyncOperation<Pointer<IMediaCaptureStopResult>>** operation);

        [VtblIndex(9)]
        HRESULT get_FrameSources([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CMedia__CCapture__CFrames__CMediaFrameSource_t **")] IMapView<HSTRING, Pointer<IMediaFrameSource>>** value);

        [VtblIndex(10)]
        HRESULT CreateFrameReaderAsync([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSource *")] IMediaFrameSource* inputSource, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **")] IAsyncOperation<Pointer<IMediaFrameReader>>** value);

        [VtblIndex(11)]
        HRESULT CreateFrameReaderWithSubtypeAsync([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSource *")] IMediaFrameSource* inputSource, HSTRING outputSubtype, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **")] IAsyncOperation<Pointer<IMediaFrameReader>>** value);

        [VtblIndex(12)]
        HRESULT CreateFrameReaderWithSubtypeAndSizeAsync([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSource *")] IMediaFrameSource* inputSource, HSTRING outputSubtype, [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize")] BitmapSize outputSize, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **")] IAsyncOperation<Pointer<IMediaFrameReader>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::IMediaExtension *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaExtension*, IAsyncAction**, int> RemoveEffectAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::MediaCapturePauseBehavior, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CMediaCapturePauseResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCapturePauseBehavior, IAsyncOperation<Pointer<IMediaCapturePauseResult>>**, int> PauseRecordWithResultAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CMediaCaptureStopResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IMediaCaptureStopResult>>**, int> StopRecordWithResultAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CMedia__CCapture__CFrames__CMediaFrameSource_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMapView<HSTRING, Pointer<IMediaFrameSource>>**, int> get_FrameSources;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameSource *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaFrameSource*, IAsyncOperation<Pointer<IMediaFrameReader>>**, int> CreateFrameReaderAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameSource *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaFrameSource*, HSTRING, IAsyncOperation<Pointer<IMediaFrameReader>>**, int> CreateFrameReaderWithSubtypeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameSource *, HSTRING, ABI::Windows::Graphics::Imaging::BitmapSize, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CFrames__CMediaFrameReader_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaFrameSource*, HSTRING, BitmapSize, IAsyncOperation<Pointer<IMediaFrameReader>>**, int> CreateFrameReaderWithSubtypeAndSizeAsync;
    }
}
