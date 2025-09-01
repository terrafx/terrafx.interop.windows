// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.editing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaComposition.xml' path='doc/member[@name="IMediaComposition"]/*' />
[Guid("2E06E605-DC71-41D6-B837-2D2BC14A2947")]
[NativeTypeName("struct IMediaComposition : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaComposition : IMediaComposition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaComposition);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, Guid*, void**, int>)(lpVtbl[0]))((IMediaComposition*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, uint>)(lpVtbl[1]))((IMediaComposition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, uint>)(lpVtbl[2]))((IMediaComposition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaComposition*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, HSTRING*, int>)(lpVtbl[4]))((IMediaComposition*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, TrustLevel*, int>)(lpVtbl[5]))((IMediaComposition*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaComposition.xml' path='doc/member[@name="IMediaComposition.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, TimeSpan*, int>)(lpVtbl[6]))((IMediaComposition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaComposition.xml' path='doc/member[@name="IMediaComposition.get_Clips"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Clips([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEditing__CMediaClip_t **")] IVector<Pointer<IMediaClip>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, IVector<Pointer<IMediaClip>>**, int>)(lpVtbl[7]))((IMediaComposition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaComposition.xml' path='doc/member[@name="IMediaComposition.get_BackgroundAudioTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BackgroundAudioTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEditing__CBackgroundAudioTrack_t **")] IVector<Pointer<IBackgroundAudioTrack>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, IVector<Pointer<IBackgroundAudioTrack>>**, int>)(lpVtbl[8]))((IMediaComposition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaComposition.xml' path='doc/member[@name="IMediaComposition.get_UserData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_UserData([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")] IMap<HSTRING, HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, IMap<HSTRING, HSTRING>**, int>)(lpVtbl[9]))((IMediaComposition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaComposition.xml' path='doc/member[@name="IMediaComposition.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Clone([NativeTypeName("ABI::Windows::Media::Editing::IMediaComposition **")] IMediaComposition** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, IMediaComposition**, int>)(lpVtbl[10]))((IMediaComposition*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IMediaComposition.xml' path='doc/member[@name="IMediaComposition.SaveAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SaveAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, IStorageFile*, IAsyncAction**, int>)(lpVtbl[11]))((IMediaComposition*)Unsafe.AsPointer(ref this), file, operation);
    }

    /// <include file='IMediaComposition.xml' path='doc/member[@name="IMediaComposition.GetThumbnailAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetThumbnailAsync([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timeFromStart, [NativeTypeName("INT32")] int scaledWidth, [NativeTypeName("INT32")] int scaledHeight, [NativeTypeName("ABI::Windows::Media::Editing::VideoFramePrecision")] VideoFramePrecision framePrecision, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CImageStream_t **")] IAsyncOperation<Pointer<IntPtr>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, TimeSpan, int, int, VideoFramePrecision, IAsyncOperation<Pointer<IntPtr>>**, int>)(lpVtbl[12]))((IMediaComposition*)Unsafe.AsPointer(ref this), timeFromStart, scaledWidth, scaledHeight, framePrecision, operation);
    }

    /// <include file='IMediaComposition.xml' path='doc/member[@name="IMediaComposition.GetThumbnailsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetThumbnailsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CTimeSpan_t *")] IIterable<TimeSpan>* timesFromStart, [NativeTypeName("INT32")] int scaledWidth, [NativeTypeName("INT32")] int scaledHeight, [NativeTypeName("ABI::Windows::Media::Editing::VideoFramePrecision")] VideoFramePrecision framePrecision, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CGraphics__CImaging__CImageStream_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IntPtr>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, IIterable<TimeSpan>*, int, int, VideoFramePrecision, IAsyncOperation<Pointer<IVectorView<Pointer<IntPtr>>>>**, int>)(lpVtbl[13]))((IMediaComposition*)Unsafe.AsPointer(ref this), timesFromStart, scaledWidth, scaledHeight, framePrecision, operation);
    }

    /// <include file='IMediaComposition.xml' path='doc/member[@name="IMediaComposition.RenderToFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT RenderToFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* destination, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **")] IAsyncOperationWithProgress<TranscodeFailureReason, double>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, IStorageFile*, IAsyncOperationWithProgress<TranscodeFailureReason, double>**, int>)(lpVtbl[14]))((IMediaComposition*)Unsafe.AsPointer(ref this), destination, operation);
    }

    /// <include file='IMediaComposition.xml' path='doc/member[@name="IMediaComposition.RenderToFileWithTrimmingPreferenceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT RenderToFileWithTrimmingPreferenceAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* destination, [NativeTypeName("ABI::Windows::Media::Editing::MediaTrimmingPreference")] MediaTrimmingPreference trimmingPreference, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **")] IAsyncOperationWithProgress<TranscodeFailureReason, double>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, IStorageFile*, MediaTrimmingPreference, IAsyncOperationWithProgress<TranscodeFailureReason, double>**, int>)(lpVtbl[15]))((IMediaComposition*)Unsafe.AsPointer(ref this), destination, trimmingPreference, operation);
    }

    /// <include file='IMediaComposition.xml' path='doc/member[@name="IMediaComposition.RenderToFileWithProfileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RenderToFileWithProfileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* destination, [NativeTypeName("ABI::Windows::Media::Editing::MediaTrimmingPreference")] MediaTrimmingPreference trimmingPreference, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* encodingProfile, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **")] IAsyncOperationWithProgress<TranscodeFailureReason, double>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, IStorageFile*, MediaTrimmingPreference, IMediaEncodingProfile*, IAsyncOperationWithProgress<TranscodeFailureReason, double>**, int>)(lpVtbl[16]))((IMediaComposition*)Unsafe.AsPointer(ref this), destination, trimmingPreference, encodingProfile, operation);
    }

    /// <include file='IMediaComposition.xml' path='doc/member[@name="IMediaComposition.CreateDefaultEncodingProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateDefaultEncodingProfile([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, IMediaEncodingProfile**, int>)(lpVtbl[17]))((IMediaComposition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaComposition.xml' path='doc/member[@name="IMediaComposition.GenerateMediaStreamSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GenerateMediaStreamSource([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")] IMediaStreamSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, IMediaStreamSource**, int>)(lpVtbl[18]))((IMediaComposition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaComposition.xml' path='doc/member[@name="IMediaComposition.GenerateMediaStreamSourceWithProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GenerateMediaStreamSourceWithProfile([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* encodingProfile, [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")] IMediaStreamSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, IMediaEncodingProfile*, IMediaStreamSource**, int>)(lpVtbl[19]))((IMediaComposition*)Unsafe.AsPointer(ref this), encodingProfile, value);
    }

    /// <include file='IMediaComposition.xml' path='doc/member[@name="IMediaComposition.GeneratePreviewMediaStreamSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GeneratePreviewMediaStreamSource([NativeTypeName("INT32")] int scaledWidth, [NativeTypeName("INT32")] int scaledHeight, [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")] IMediaStreamSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaComposition*, int, int, IMediaStreamSource**, int>)(lpVtbl[20]))((IMediaComposition*)Unsafe.AsPointer(ref this), scaledWidth, scaledHeight, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(7)]
        HRESULT get_Clips([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEditing__CMediaClip_t **")] IVector<Pointer<IMediaClip>>** value);

        [VtblIndex(8)]
        HRESULT get_BackgroundAudioTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEditing__CBackgroundAudioTrack_t **")] IVector<Pointer<IBackgroundAudioTrack>>** value);

        [VtblIndex(9)]
        HRESULT get_UserData([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")] IMap<HSTRING, HSTRING>** value);

        [VtblIndex(10)]
        HRESULT Clone([NativeTypeName("ABI::Windows::Media::Editing::IMediaComposition **")] IMediaComposition** result);

        [VtblIndex(11)]
        HRESULT SaveAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(12)]
        HRESULT GetThumbnailAsync([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timeFromStart, [NativeTypeName("INT32")] int scaledWidth, [NativeTypeName("INT32")] int scaledHeight, [NativeTypeName("ABI::Windows::Media::Editing::VideoFramePrecision")] VideoFramePrecision framePrecision, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CImageStream_t **")] IAsyncOperation<Pointer<IntPtr>>** operation);

        [VtblIndex(13)]
        HRESULT GetThumbnailsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CTimeSpan_t *")] IIterable<TimeSpan>* timesFromStart, [NativeTypeName("INT32")] int scaledWidth, [NativeTypeName("INT32")] int scaledHeight, [NativeTypeName("ABI::Windows::Media::Editing::VideoFramePrecision")] VideoFramePrecision framePrecision, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CGraphics__CImaging__CImageStream_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IntPtr>>>>** operation);

        [VtblIndex(14)]
        HRESULT RenderToFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* destination, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **")] IAsyncOperationWithProgress<TranscodeFailureReason, double>** operation);

        [VtblIndex(15)]
        HRESULT RenderToFileWithTrimmingPreferenceAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* destination, [NativeTypeName("ABI::Windows::Media::Editing::MediaTrimmingPreference")] MediaTrimmingPreference trimmingPreference, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **")] IAsyncOperationWithProgress<TranscodeFailureReason, double>** operation);

        [VtblIndex(16)]
        HRESULT RenderToFileWithProfileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* destination, [NativeTypeName("ABI::Windows::Media::Editing::MediaTrimmingPreference")] MediaTrimmingPreference trimmingPreference, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* encodingProfile, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **")] IAsyncOperationWithProgress<TranscodeFailureReason, double>** operation);

        [VtblIndex(17)]
        HRESULT CreateDefaultEncodingProfile([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value);

        [VtblIndex(18)]
        HRESULT GenerateMediaStreamSource([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")] IMediaStreamSource** value);

        [VtblIndex(19)]
        HRESULT GenerateMediaStreamSourceWithProfile([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* encodingProfile, [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")] IMediaStreamSource** value);

        [VtblIndex(20)]
        HRESULT GeneratePreviewMediaStreamSource([NativeTypeName("INT32")] int scaledWidth, [NativeTypeName("INT32")] int scaledHeight, [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")] IMediaStreamSource** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Duration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEditing__CMediaClip_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IMediaClip>>**, int> get_Clips;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEditing__CBackgroundAudioTrack_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IBackgroundAudioTrack>>**, int> get_BackgroundAudioTracks;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, HSTRING>**, int> get_UserData;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Editing::IMediaComposition **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaComposition**, int> Clone;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncAction**, int> SaveAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan, INT32, INT32, ABI::Windows::Media::Editing::VideoFramePrecision, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CImageStream_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int, int, VideoFramePrecision, IAsyncOperation<Pointer<IntPtr>>**, int> GetThumbnailAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CTimeSpan_t *, INT32, INT32, ABI::Windows::Media::Editing::VideoFramePrecision, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CGraphics__CImaging__CImageStream_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<TimeSpan>*, int, int, VideoFramePrecision, IAsyncOperation<Pointer<IVectorView<Pointer<IntPtr>>>>**, int> GetThumbnailsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncOperationWithProgress<TranscodeFailureReason, double>**, int> RenderToFileAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Media::Editing::MediaTrimmingPreference, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, MediaTrimmingPreference, IAsyncOperationWithProgress<TranscodeFailureReason, double>**, int> RenderToFileWithTrimmingPreferenceAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Media::Editing::MediaTrimmingPreference, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CTranscoding__CTranscodeFailureReason_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, MediaTrimmingPreference, IMediaEncodingProfile*, IAsyncOperationWithProgress<TranscodeFailureReason, double>**, int> RenderToFileWithProfileAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaEncodingProfile**, int> CreateDefaultEncodingProfile;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamSource**, int> GenerateMediaStreamSource;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Media::Core::IMediaStreamSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaEncodingProfile*, IMediaStreamSource**, int> GenerateMediaStreamSourceWithProfile;

        [NativeTypeName("HRESULT (INT32, INT32, ABI::Windows::Media::Core::IMediaStreamSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, IMediaStreamSource**, int> GeneratePreviewMediaStreamSource;
    }
}
