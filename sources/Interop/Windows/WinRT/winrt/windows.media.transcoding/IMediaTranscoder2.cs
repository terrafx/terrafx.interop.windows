// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.transcoding.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaTranscoder2.xml' path='doc/member[@name="IMediaTranscoder2"]/*' />
[Guid("40531D74-35E0-4F04-8574-CA8BC4E5A082")]
[NativeTypeName("struct IMediaTranscoder2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaTranscoder2 : IMediaTranscoder2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaTranscoder2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaTranscoder2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder2*, uint>)(lpVtbl[1]))((IMediaTranscoder2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder2*, uint>)(lpVtbl[2]))((IMediaTranscoder2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder2*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaTranscoder2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder2*, HSTRING*, int>)(lpVtbl[4]))((IMediaTranscoder2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder2*, TrustLevel*, int>)(lpVtbl[5]))((IMediaTranscoder2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaTranscoder2.xml' path='doc/member[@name="IMediaTranscoder2.PrepareMediaStreamSourceTranscodeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT PrepareMediaStreamSourceTranscodeAsync([NativeTypeName("ABI::Windows::Media::Core::IMediaSource *")] IMediaSource* source, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* destination, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* profile, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder2*, IMediaSource*, IRandomAccessStream*, IMediaEncodingProfile*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IMediaTranscoder2*)Unsafe.AsPointer(ref this), source, destination, profile, operation);
    }

    /// <include file='IMediaTranscoder2.xml' path='doc/member[@name="IMediaTranscoder2.put_VideoProcessingAlgorithm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_VideoProcessingAlgorithm([NativeTypeName("ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm")] MediaVideoProcessingAlgorithm value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder2*, MediaVideoProcessingAlgorithm, int>)(lpVtbl[7]))((IMediaTranscoder2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTranscoder2.xml' path='doc/member[@name="IMediaTranscoder2.get_VideoProcessingAlgorithm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_VideoProcessingAlgorithm([NativeTypeName("ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm *")] MediaVideoProcessingAlgorithm* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder2*, MediaVideoProcessingAlgorithm*, int>)(lpVtbl[8]))((IMediaTranscoder2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT PrepareMediaStreamSourceTranscodeAsync([NativeTypeName("ABI::Windows::Media::Core::IMediaSource *")] IMediaSource* source, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* destination, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* profile, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(7)]
        HRESULT put_VideoProcessingAlgorithm([NativeTypeName("ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm")] MediaVideoProcessingAlgorithm value);

        [VtblIndex(8)]
        HRESULT get_VideoProcessingAlgorithm([NativeTypeName("ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm *")] MediaVideoProcessingAlgorithm* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaSource *, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaSource*, IRandomAccessStream*, IMediaEncodingProfile*, IAsyncOperation<IntPtr>**, int> PrepareMediaStreamSourceTranscodeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaVideoProcessingAlgorithm, int> put_VideoProcessingAlgorithm;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Transcoding::MediaVideoProcessingAlgorithm *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaVideoProcessingAlgorithm*, int> get_VideoProcessingAlgorithm;
    }
}
