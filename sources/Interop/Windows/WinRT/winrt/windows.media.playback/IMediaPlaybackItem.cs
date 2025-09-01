// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlaybackItem.xml' path='doc/member[@name="IMediaPlaybackItem"]/*' />
[Guid("047097D2-E4AF-48AB-B283-6929E674ECE2")]
[NativeTypeName("struct IMediaPlaybackItem : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackItem : IMediaPlaybackItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaPlaybackItem);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlaybackItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem*, uint>)(lpVtbl[1]))((IMediaPlaybackItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem*, uint>)(lpVtbl[2]))((IMediaPlaybackItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlaybackItem*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlaybackItem*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlaybackItem*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlaybackItem.xml' path='doc/member[@name="IMediaPlaybackItem.add_AudioTracksChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_AudioTracksChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackItem___F__CIVectorChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackItem>, Pointer<IVectorChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem*, ITypedEventHandler<Pointer<IMediaPlaybackItem>, Pointer<IVectorChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaPlaybackItem*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackItem.xml' path='doc/member[@name="IMediaPlaybackItem.remove_AudioTracksChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_AudioTracksChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaPlaybackItem*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackItem.xml' path='doc/member[@name="IMediaPlaybackItem.add_VideoTracksChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_VideoTracksChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackItem___F__CIVectorChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackItem>, Pointer<IVectorChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem*, ITypedEventHandler<Pointer<IMediaPlaybackItem>, Pointer<IVectorChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IMediaPlaybackItem*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackItem.xml' path='doc/member[@name="IMediaPlaybackItem.remove_VideoTracksChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_VideoTracksChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem*, EventRegistrationToken, int>)(lpVtbl[9]))((IMediaPlaybackItem*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackItem.xml' path='doc/member[@name="IMediaPlaybackItem.add_TimedMetadataTracksChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_TimedMetadataTracksChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackItem___F__CIVectorChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackItem>, Pointer<IVectorChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem*, ITypedEventHandler<Pointer<IMediaPlaybackItem>, Pointer<IVectorChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IMediaPlaybackItem*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackItem.xml' path='doc/member[@name="IMediaPlaybackItem.remove_TimedMetadataTracksChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_TimedMetadataTracksChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem*, EventRegistrationToken, int>)(lpVtbl[11]))((IMediaPlaybackItem*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackItem.xml' path='doc/member[@name="IMediaPlaybackItem.get_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Source([NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem*, IMediaSource2**, int>)(lpVtbl[12]))((IMediaPlaybackItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackItem.xml' path='doc/member[@name="IMediaPlaybackItem.get_AudioTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_AudioTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CAudioTrack_t **")] IVectorView<Pointer<IAudioTrack>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem*, IVectorView<Pointer<IAudioTrack>>**, int>)(lpVtbl[13]))((IMediaPlaybackItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackItem.xml' path='doc/member[@name="IMediaPlaybackItem.get_VideoTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_VideoTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CVideoTrack_t **")] IVectorView<Pointer<IVideoTrack>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem*, IVectorView<Pointer<IVideoTrack>>**, int>)(lpVtbl[14]))((IMediaPlaybackItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackItem.xml' path='doc/member[@name="IMediaPlaybackItem.get_TimedMetadataTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_TimedMetadataTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CTimedMetadataTrack_t **")] IVectorView<Pointer<ITimedMetadataTrack>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackItem*, IVectorView<Pointer<ITimedMetadataTrack>>**, int>)(lpVtbl[15]))((IMediaPlaybackItem*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_AudioTracksChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackItem___F__CIVectorChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackItem>, Pointer<IVectorChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_AudioTracksChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_VideoTracksChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackItem___F__CIVectorChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackItem>, Pointer<IVectorChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_VideoTracksChanged(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_TimedMetadataTracksChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackItem___F__CIVectorChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackItem>, Pointer<IVectorChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_TimedMetadataTracksChanged(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT get_Source([NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** value);

        [VtblIndex(13)]
        HRESULT get_AudioTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CAudioTrack_t **")] IVectorView<Pointer<IAudioTrack>>** value);

        [VtblIndex(14)]
        HRESULT get_VideoTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CVideoTrack_t **")] IVectorView<Pointer<IVideoTrack>>** value);

        [VtblIndex(15)]
        HRESULT get_TimedMetadataTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CTimedMetadataTrack_t **")] IVectorView<Pointer<ITimedMetadataTrack>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackItem___F__CIVectorChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackItem>, Pointer<IVectorChangedEventArgs>>*, EventRegistrationToken*, int> add_AudioTracksChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AudioTracksChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackItem___F__CIVectorChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackItem>, Pointer<IVectorChangedEventArgs>>*, EventRegistrationToken*, int> add_VideoTracksChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_VideoTracksChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackItem___F__CIVectorChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackItem>, Pointer<IVectorChangedEventArgs>>*, EventRegistrationToken*, int> add_TimedMetadataTracksChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_TimedMetadataTracksChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaSource2**, int> get_Source;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CAudioTrack_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IAudioTrack>>**, int> get_AudioTracks;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CVideoTrack_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IVideoTrack>>**, int> get_VideoTracks;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CTimedMetadataTrack_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<ITimedMetadataTrack>>**, int> get_TimedMetadataTracks;
    }
}
