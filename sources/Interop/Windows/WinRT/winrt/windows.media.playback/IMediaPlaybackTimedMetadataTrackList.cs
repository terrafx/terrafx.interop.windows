// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlaybackTimedMetadataTrackList.xml' path='doc/member[@name="IMediaPlaybackTimedMetadataTrackList"]/*' />
[Guid("72B41319-BBFB-46A3-9372-9C9C744B9438")]
[NativeTypeName("struct IMediaPlaybackTimedMetadataTrackList : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackTimedMetadataTrackList : IMediaPlaybackTimedMetadataTrackList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaPlaybackTimedMetadataTrackList);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackTimedMetadataTrackList*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlaybackTimedMetadataTrackList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackTimedMetadataTrackList*, uint>)(lpVtbl[1]))((IMediaPlaybackTimedMetadataTrackList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackTimedMetadataTrackList*, uint>)(lpVtbl[2]))((IMediaPlaybackTimedMetadataTrackList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackTimedMetadataTrackList*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlaybackTimedMetadataTrackList*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackTimedMetadataTrackList*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlaybackTimedMetadataTrackList*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackTimedMetadataTrackList*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlaybackTimedMetadataTrackList*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlaybackTimedMetadataTrackList.xml' path='doc/member[@name="IMediaPlaybackTimedMetadataTrackList.add_PresentationModeChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_PresentationModeChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackTimedMetadataTrackList_Windows__CMedia__CPlayback__CTimedMetadataPresentationModeChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackTimedMetadataTrackList>, Pointer<ITimedMetadataPresentationModeChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackTimedMetadataTrackList*, ITypedEventHandler<Pointer<IMediaPlaybackTimedMetadataTrackList>, Pointer<ITimedMetadataPresentationModeChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaPlaybackTimedMetadataTrackList*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackTimedMetadataTrackList.xml' path='doc/member[@name="IMediaPlaybackTimedMetadataTrackList.remove_PresentationModeChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_PresentationModeChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackTimedMetadataTrackList*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaPlaybackTimedMetadataTrackList*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackTimedMetadataTrackList.xml' path='doc/member[@name="IMediaPlaybackTimedMetadataTrackList.GetPresentationMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPresentationMode([NativeTypeName("UINT32")] uint index, [NativeTypeName("ABI::Windows::Media::Playback::TimedMetadataTrackPresentationMode *")] TimedMetadataTrackPresentationMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackTimedMetadataTrackList*, uint, TimedMetadataTrackPresentationMode*, int>)(lpVtbl[8]))((IMediaPlaybackTimedMetadataTrackList*)Unsafe.AsPointer(ref this), index, value);
    }

    /// <include file='IMediaPlaybackTimedMetadataTrackList.xml' path='doc/member[@name="IMediaPlaybackTimedMetadataTrackList.SetPresentationMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetPresentationMode([NativeTypeName("UINT32")] uint index, [NativeTypeName("ABI::Windows::Media::Playback::TimedMetadataTrackPresentationMode")] TimedMetadataTrackPresentationMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackTimedMetadataTrackList*, uint, TimedMetadataTrackPresentationMode, int>)(lpVtbl[9]))((IMediaPlaybackTimedMetadataTrackList*)Unsafe.AsPointer(ref this), index, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_PresentationModeChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackTimedMetadataTrackList_Windows__CMedia__CPlayback__CTimedMetadataPresentationModeChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackTimedMetadataTrackList>, Pointer<ITimedMetadataPresentationModeChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_PresentationModeChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT GetPresentationMode([NativeTypeName("UINT32")] uint index, [NativeTypeName("ABI::Windows::Media::Playback::TimedMetadataTrackPresentationMode *")] TimedMetadataTrackPresentationMode* value);

        [VtblIndex(9)]
        HRESULT SetPresentationMode([NativeTypeName("UINT32")] uint index, [NativeTypeName("ABI::Windows::Media::Playback::TimedMetadataTrackPresentationMode")] TimedMetadataTrackPresentationMode value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackTimedMetadataTrackList_Windows__CMedia__CPlayback__CTimedMetadataPresentationModeChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackTimedMetadataTrackList>, Pointer<ITimedMetadataPresentationModeChangedEventArgs>>*, EventRegistrationToken*, int> add_PresentationModeChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PresentationModeChanged;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Media::Playback::TimedMetadataTrackPresentationMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, TimedMetadataTrackPresentationMode*, int> GetPresentationMode;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Media::Playback::TimedMetadataTrackPresentationMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, TimedMetadataTrackPresentationMode, int> SetPresentationMode;
    }
}
