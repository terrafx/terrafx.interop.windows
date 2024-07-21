// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCapture2.xml' path='doc/member[@name="IMediaCapture2"]/*' />
[Guid("9CC68260-7DA1-4043-B652-21B8878DAFF9")]
[NativeTypeName("struct IMediaCapture2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCapture2 : IMediaCapture2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCapture2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCapture2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture2*, uint>)(lpVtbl[1]))((IMediaCapture2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture2*, uint>)(lpVtbl[2]))((IMediaCapture2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture2*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCapture2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture2*, HSTRING*, int>)(lpVtbl[4]))((IMediaCapture2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture2*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCapture2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCapture2.xml' path='doc/member[@name="IMediaCapture2.PrepareLowLagRecordToStorageFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT PrepareLowLagRecordToStorageFileAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* encodingProfile, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **")] IAsyncOperation<Pointer<ILowLagMediaRecording>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture2*, IMediaEncodingProfile*, IStorageFile*, IAsyncOperation<Pointer<ILowLagMediaRecording>>**, int>)(lpVtbl[6]))((IMediaCapture2*)Unsafe.AsPointer(ref this), encodingProfile, file, operation);
    }

    /// <include file='IMediaCapture2.xml' path='doc/member[@name="IMediaCapture2.PrepareLowLagRecordToStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT PrepareLowLagRecordToStreamAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* encodingProfile, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **")] IAsyncOperation<Pointer<ILowLagMediaRecording>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture2*, IMediaEncodingProfile*, IRandomAccessStream*, IAsyncOperation<Pointer<ILowLagMediaRecording>>**, int>)(lpVtbl[7]))((IMediaCapture2*)Unsafe.AsPointer(ref this), encodingProfile, stream, operation);
    }

    /// <include file='IMediaCapture2.xml' path='doc/member[@name="IMediaCapture2.PrepareLowLagRecordToCustomSinkAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT PrepareLowLagRecordToCustomSinkAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* encodingProfile, [NativeTypeName("ABI::Windows::Media::IMediaExtension *")] IMediaExtension* customMediaSink, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **")] IAsyncOperation<Pointer<ILowLagMediaRecording>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture2*, IMediaEncodingProfile*, IMediaExtension*, IAsyncOperation<Pointer<ILowLagMediaRecording>>**, int>)(lpVtbl[8]))((IMediaCapture2*)Unsafe.AsPointer(ref this), encodingProfile, customMediaSink, operation);
    }

    /// <include file='IMediaCapture2.xml' path='doc/member[@name="IMediaCapture2.PrepareLowLagRecordToCustomSinkIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT PrepareLowLagRecordToCustomSinkIdAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* encodingProfile, HSTRING customSinkActivationId, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* customSinkSettings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **")] IAsyncOperation<Pointer<ILowLagMediaRecording>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture2*, IMediaEncodingProfile*, HSTRING, IPropertySet*, IAsyncOperation<Pointer<ILowLagMediaRecording>>**, int>)(lpVtbl[9]))((IMediaCapture2*)Unsafe.AsPointer(ref this), encodingProfile, customSinkActivationId, customSinkSettings, operation);
    }

    /// <include file='IMediaCapture2.xml' path='doc/member[@name="IMediaCapture2.PrepareLowLagPhotoCaptureAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT PrepareLowLagPhotoCaptureAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties *")] IImageEncodingProperties* type, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagPhotoCapture_t **")] IAsyncOperation<Pointer<ILowLagPhotoCapture>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture2*, IImageEncodingProperties*, IAsyncOperation<Pointer<ILowLagPhotoCapture>>**, int>)(lpVtbl[10]))((IMediaCapture2*)Unsafe.AsPointer(ref this), type, operation);
    }

    /// <include file='IMediaCapture2.xml' path='doc/member[@name="IMediaCapture2.PrepareLowLagPhotoSequenceCaptureAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT PrepareLowLagPhotoSequenceCaptureAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties *")] IImageEncodingProperties* type, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagPhotoSequenceCapture_t **")] IAsyncOperation<Pointer<ILowLagPhotoSequenceCapture>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture2*, IImageEncodingProperties*, IAsyncOperation<Pointer<ILowLagPhotoSequenceCapture>>**, int>)(lpVtbl[11]))((IMediaCapture2*)Unsafe.AsPointer(ref this), type, operation);
    }

    /// <include file='IMediaCapture2.xml' path='doc/member[@name="IMediaCapture2.SetEncodingPropertiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetEncodingPropertiesAsync([NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")] MediaStreamType mediaStreamType, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")] IMediaEncodingProperties* mediaEncodingProperties, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_GUID_IInspectable_t *")] IMap<Guid, Pointer<IInspectable>>* encoderProperties, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCapture2*, MediaStreamType, IMediaEncodingProperties*, IMap<Guid, Pointer<IInspectable>>*, IAsyncAction**, int>)(lpVtbl[12]))((IMediaCapture2*)Unsafe.AsPointer(ref this), mediaStreamType, mediaEncodingProperties, encoderProperties, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT PrepareLowLagRecordToStorageFileAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* encodingProfile, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **")] IAsyncOperation<Pointer<ILowLagMediaRecording>>** operation);

        [VtblIndex(7)]
        HRESULT PrepareLowLagRecordToStreamAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* encodingProfile, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **")] IAsyncOperation<Pointer<ILowLagMediaRecording>>** operation);

        [VtblIndex(8)]
        HRESULT PrepareLowLagRecordToCustomSinkAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* encodingProfile, [NativeTypeName("ABI::Windows::Media::IMediaExtension *")] IMediaExtension* customMediaSink, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **")] IAsyncOperation<Pointer<ILowLagMediaRecording>>** operation);

        [VtblIndex(9)]
        HRESULT PrepareLowLagRecordToCustomSinkIdAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* encodingProfile, HSTRING customSinkActivationId, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* customSinkSettings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **")] IAsyncOperation<Pointer<ILowLagMediaRecording>>** operation);

        [VtblIndex(10)]
        HRESULT PrepareLowLagPhotoCaptureAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties *")] IImageEncodingProperties* type, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagPhotoCapture_t **")] IAsyncOperation<Pointer<ILowLagPhotoCapture>>** operation);

        [VtblIndex(11)]
        HRESULT PrepareLowLagPhotoSequenceCaptureAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IImageEncodingProperties *")] IImageEncodingProperties* type, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagPhotoSequenceCapture_t **")] IAsyncOperation<Pointer<ILowLagPhotoSequenceCapture>>** operation);

        [VtblIndex(12)]
        HRESULT SetEncodingPropertiesAsync([NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")] MediaStreamType mediaStreamType, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")] IMediaEncodingProperties* mediaEncodingProperties, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_GUID_IInspectable_t *")] IMap<Guid, Pointer<IInspectable>>* encoderProperties, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaEncodingProfile*, IStorageFile*, IAsyncOperation<Pointer<ILowLagMediaRecording>>**, int> PrepareLowLagRecordToStorageFileAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaEncodingProfile*, IRandomAccessStream*, IAsyncOperation<Pointer<ILowLagMediaRecording>>**, int> PrepareLowLagRecordToStreamAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Media::IMediaExtension *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaEncodingProfile*, IMediaExtension*, IAsyncOperation<Pointer<ILowLagMediaRecording>>**, int> PrepareLowLagRecordToCustomSinkAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, HSTRING, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagMediaRecording_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaEncodingProfile*, HSTRING, IPropertySet*, IAsyncOperation<Pointer<ILowLagMediaRecording>>**, int> PrepareLowLagRecordToCustomSinkIdAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IImageEncodingProperties *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagPhotoCapture_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IImageEncodingProperties*, IAsyncOperation<Pointer<ILowLagPhotoCapture>>**, int> PrepareLowLagPhotoCaptureAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IImageEncodingProperties *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCapture__CLowLagPhotoSequenceCapture_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IImageEncodingProperties*, IAsyncOperation<Pointer<ILowLagPhotoSequenceCapture>>**, int> PrepareLowLagPhotoSequenceCaptureAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaStreamType, ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *, ABI::Windows::Foundation::Collections::__FIMap_2_GUID_IInspectable_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaStreamType, IMediaEncodingProperties*, IMap<Guid, Pointer<IInspectable>>*, IAsyncAction**, int> SetEncodingPropertiesAsync;
    }
}
