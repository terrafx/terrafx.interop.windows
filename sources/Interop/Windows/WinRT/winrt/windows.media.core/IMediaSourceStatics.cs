// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaSourceStatics.xml' path='doc/member[@name="IMediaSourceStatics"]/*' />
[Guid("F77D6FA4-4652-410E-B1D8-E9A5E245A45C")]
[NativeTypeName("struct IMediaSourceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaSourceStatics : IMediaSourceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaSourceStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IMediaSourceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics*, uint>)(lpVtbl[1]))((IMediaSourceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics*, uint>)(lpVtbl[2]))((IMediaSourceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaSourceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics*, HSTRING*, int>)(lpVtbl[4]))((IMediaSourceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IMediaSourceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaSourceStatics.xml' path='doc/member[@name="IMediaSourceStatics.CreateFromAdaptiveMediaSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromAdaptiveMediaSource([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSource *")] IAdaptiveMediaSource* mediaSource, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics*, IAdaptiveMediaSource*, IMediaSource2**, int>)(lpVtbl[6]))((IMediaSourceStatics*)Unsafe.AsPointer(ref this), mediaSource, result);
    }

    /// <include file='IMediaSourceStatics.xml' path='doc/member[@name="IMediaSourceStatics.CreateFromMediaStreamSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromMediaStreamSource([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource *")] IMediaStreamSource* mediaSource, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics*, IMediaStreamSource*, IMediaSource2**, int>)(lpVtbl[7]))((IMediaSourceStatics*)Unsafe.AsPointer(ref this), mediaSource, result);
    }

    /// <include file='IMediaSourceStatics.xml' path='doc/member[@name="IMediaSourceStatics.CreateFromMseStreamSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromMseStreamSource([NativeTypeName("ABI::Windows::Media::Core::IMseStreamSource *")] IMseStreamSource* mediaSource, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics*, IMseStreamSource*, IMediaSource2**, int>)(lpVtbl[8]))((IMediaSourceStatics*)Unsafe.AsPointer(ref this), mediaSource, result);
    }

    /// <include file='IMediaSourceStatics.xml' path='doc/member[@name="IMediaSourceStatics.CreateFromIMediaSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFromIMediaSource([NativeTypeName("ABI::Windows::Media::Core::IMediaSource *")] IMediaSource* mediaSource, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics*, IMediaSource*, IMediaSource2**, int>)(lpVtbl[9]))((IMediaSourceStatics*)Unsafe.AsPointer(ref this), mediaSource, result);
    }

    /// <include file='IMediaSourceStatics.xml' path='doc/member[@name="IMediaSourceStatics.CreateFromStorageFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateFromStorageFile([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics*, IStorageFile*, IMediaSource2**, int>)(lpVtbl[10]))((IMediaSourceStatics*)Unsafe.AsPointer(ref this), file, result);
    }

    /// <include file='IMediaSourceStatics.xml' path='doc/member[@name="IMediaSourceStatics.CreateFromStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateFromStream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, HSTRING contentType, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics*, IRandomAccessStream*, HSTRING, IMediaSource2**, int>)(lpVtbl[11]))((IMediaSourceStatics*)Unsafe.AsPointer(ref this), stream, contentType, result);
    }

    /// <include file='IMediaSourceStatics.xml' path='doc/member[@name="IMediaSourceStatics.CreateFromStreamReference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateFromStreamReference([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* stream, HSTRING contentType, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics*, IRandomAccessStreamReference*, HSTRING, IMediaSource2**, int>)(lpVtbl[12]))((IMediaSourceStatics*)Unsafe.AsPointer(ref this), stream, contentType, result);
    }

    /// <include file='IMediaSourceStatics.xml' path='doc/member[@name="IMediaSourceStatics.CreateFromUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateFromUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics*, IUriRuntimeClass*, IMediaSource2**, int>)(lpVtbl[13]))((IMediaSourceStatics*)Unsafe.AsPointer(ref this), uri, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromAdaptiveMediaSource([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSource *")] IAdaptiveMediaSource* mediaSource, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result);

        [VtblIndex(7)]
        HRESULT CreateFromMediaStreamSource([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource *")] IMediaStreamSource* mediaSource, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result);

        [VtblIndex(8)]
        HRESULT CreateFromMseStreamSource([NativeTypeName("ABI::Windows::Media::Core::IMseStreamSource *")] IMseStreamSource* mediaSource, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result);

        [VtblIndex(9)]
        HRESULT CreateFromIMediaSource([NativeTypeName("ABI::Windows::Media::Core::IMediaSource *")] IMediaSource* mediaSource, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result);

        [VtblIndex(10)]
        HRESULT CreateFromStorageFile([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result);

        [VtblIndex(11)]
        HRESULT CreateFromStream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, HSTRING contentType, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result);

        [VtblIndex(12)]
        HRESULT CreateFromStreamReference([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* stream, HSTRING contentType, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result);

        [VtblIndex(13)]
        HRESULT CreateFromUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSource *, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAdaptiveMediaSource*, IMediaSource2**, int> CreateFromAdaptiveMediaSource;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamSource *, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamSource*, IMediaSource2**, int> CreateFromMediaStreamSource;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMseStreamSource *, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMseStreamSource*, IMediaSource2**, int> CreateFromMseStreamSource;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaSource *, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaSource*, IMediaSource2**, int> CreateFromIMediaSource;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IMediaSource2**, int> CreateFromStorageFile;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, HSTRING, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream*, HSTRING, IMediaSource2**, int> CreateFromStream;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, HSTRING, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, HSTRING, IMediaSource2**, int> CreateFromStreamReference;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IMediaSource2**, int> CreateFromUri;
    }
}
