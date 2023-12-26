// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl"]/*' />
[Guid("98F1FBE1-7A8D-42CB-B6FE-8FE698264F13")]
[NativeTypeName("struct IMediaControl : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
public unsafe partial struct IMediaControl : IMediaControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_WinRT_IMediaControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, Guid*, void**, int>)(lpVtbl[0]))((IMediaControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, uint>)(lpVtbl[1]))((IMediaControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, uint>)(lpVtbl[2]))((IMediaControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, HSTRING*, int>)(lpVtbl[4]))((IMediaControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, TrustLevel*, int>)(lpVtbl[5]))((IMediaControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.add_SoundLevelChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT add_SoundLevelChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaControl*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.remove_SoundLevelChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT remove_SoundLevelChanged(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaControl*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.add_PlayPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT add_PlayPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IMediaControl*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.remove_PlayPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT remove_PlayPressed(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, EventRegistrationToken, int>)(lpVtbl[9]))((IMediaControl*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.add_PausePressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT add_PausePressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IMediaControl*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.remove_PausePressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT remove_PausePressed(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, EventRegistrationToken, int>)(lpVtbl[11]))((IMediaControl*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.add_StopPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT add_StopPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IMediaControl*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.remove_StopPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT remove_StopPressed(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, EventRegistrationToken, int>)(lpVtbl[13]))((IMediaControl*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.add_PlayPauseTogglePressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT add_PlayPauseTogglePressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IMediaControl*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.remove_PlayPauseTogglePressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT remove_PlayPauseTogglePressed(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, EventRegistrationToken, int>)(lpVtbl[15]))((IMediaControl*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.add_RecordPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT add_RecordPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[16]))((IMediaControl*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.remove_RecordPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT remove_RecordPressed(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, EventRegistrationToken, int>)(lpVtbl[17]))((IMediaControl*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.add_NextTrackPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT add_NextTrackPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[18]))((IMediaControl*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.remove_NextTrackPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT remove_NextTrackPressed(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, EventRegistrationToken, int>)(lpVtbl[19]))((IMediaControl*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.add_PreviousTrackPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT add_PreviousTrackPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[20]))((IMediaControl*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.remove_PreviousTrackPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT remove_PreviousTrackPressed(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, EventRegistrationToken, int>)(lpVtbl[21]))((IMediaControl*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.add_FastForwardPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT add_FastForwardPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[22]))((IMediaControl*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.remove_FastForwardPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT remove_FastForwardPressed(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, EventRegistrationToken, int>)(lpVtbl[23]))((IMediaControl*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.add_RewindPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT add_RewindPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[24]))((IMediaControl*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.remove_RewindPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT remove_RewindPressed(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, EventRegistrationToken, int>)(lpVtbl[25]))((IMediaControl*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.add_ChannelUpPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT add_ChannelUpPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[26]))((IMediaControl*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.remove_ChannelUpPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT remove_ChannelUpPressed(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, EventRegistrationToken, int>)(lpVtbl[27]))((IMediaControl*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.add_ChannelDownPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT add_ChannelDownPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[28]))((IMediaControl*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.remove_ChannelDownPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT remove_ChannelDownPressed(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, EventRegistrationToken, int>)(lpVtbl[29]))((IMediaControl*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.get_SoundLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT get_SoundLevel([NativeTypeName("ABI::Windows::Media::SoundLevel *")] SoundLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, SoundLevel*, int>)(lpVtbl[30]))((IMediaControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.put_TrackName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT put_TrackName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, HSTRING, int>)(lpVtbl[31]))((IMediaControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.get_TrackName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT get_TrackName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, HSTRING*, int>)(lpVtbl[32]))((IMediaControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.put_ArtistName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT put_ArtistName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, HSTRING, int>)(lpVtbl[33]))((IMediaControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.get_ArtistName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT get_ArtistName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, HSTRING*, int>)(lpVtbl[34]))((IMediaControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.put_IsPlaying"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT put_IsPlaying([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, byte, int>)(lpVtbl[35]))((IMediaControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.get_IsPlaying"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT get_IsPlaying([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, byte*, int>)(lpVtbl[36]))((IMediaControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.put_AlbumArt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT put_AlbumArt([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, IUriRuntimeClass*, int>)(lpVtbl[37]))((IMediaControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.get_AlbumArt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
    public HRESULT get_AlbumArt([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaControl*, IUriRuntimeClass**, int>)(lpVtbl[38]))((IMediaControl*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT add_SoundLevelChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie);

        [VtblIndex(7)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT remove_SoundLevelChanged(EventRegistrationToken cookie);

        [VtblIndex(8)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT add_PlayPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie);

        [VtblIndex(9)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT remove_PlayPressed(EventRegistrationToken cookie);

        [VtblIndex(10)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT add_PausePressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie);

        [VtblIndex(11)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT remove_PausePressed(EventRegistrationToken cookie);

        [VtblIndex(12)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT add_StopPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie);

        [VtblIndex(13)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT remove_StopPressed(EventRegistrationToken cookie);

        [VtblIndex(14)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT add_PlayPauseTogglePressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie);

        [VtblIndex(15)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT remove_PlayPauseTogglePressed(EventRegistrationToken cookie);

        [VtblIndex(16)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT add_RecordPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie);

        [VtblIndex(17)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT remove_RecordPressed(EventRegistrationToken cookie);

        [VtblIndex(18)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT add_NextTrackPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie);

        [VtblIndex(19)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT remove_NextTrackPressed(EventRegistrationToken cookie);

        [VtblIndex(20)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT add_PreviousTrackPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie);

        [VtblIndex(21)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT remove_PreviousTrackPressed(EventRegistrationToken cookie);

        [VtblIndex(22)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT add_FastForwardPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie);

        [VtblIndex(23)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT remove_FastForwardPressed(EventRegistrationToken cookie);

        [VtblIndex(24)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT add_RewindPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie);

        [VtblIndex(25)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT remove_RewindPressed(EventRegistrationToken cookie);

        [VtblIndex(26)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT add_ChannelUpPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie);

        [VtblIndex(27)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT remove_ChannelUpPressed(EventRegistrationToken cookie);

        [VtblIndex(28)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT add_ChannelDownPressed([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* cookie);

        [VtblIndex(29)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT remove_ChannelDownPressed(EventRegistrationToken cookie);

        [VtblIndex(30)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT get_SoundLevel([NativeTypeName("ABI::Windows::Media::SoundLevel *")] SoundLevel* value);

        [VtblIndex(31)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT put_TrackName(HSTRING value);

        [VtblIndex(32)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT get_TrackName(HSTRING* value);

        [VtblIndex(33)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT put_ArtistName(HSTRING value);

        [VtblIndex(34)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT get_ArtistName(HSTRING* value);

        [VtblIndex(35)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT put_IsPlaying([NativeTypeName("boolean")] byte value);

        [VtblIndex(36)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT get_IsPlaying([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(37)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT put_AlbumArt([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);

        [VtblIndex(38)]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        HRESULT get_AlbumArt([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_SoundLevelChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SoundLevelChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_PlayPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PlayPressed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_PausePressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PausePressed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_StopPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StopPressed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_PlayPauseTogglePressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PlayPauseTogglePressed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_RecordPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RecordPressed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_NextTrackPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_NextTrackPressed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_PreviousTrackPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PreviousTrackPressed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_FastForwardPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_FastForwardPressed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_RewindPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RewindPressed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_ChannelUpPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ChannelUpPressed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_ChannelDownPressed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ChannelDownPressed;

        [NativeTypeName("HRESULT (ABI::Windows::Media::SoundLevel *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SoundLevel*, int> get_SoundLevel;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_TrackName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TrackName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ArtistName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ArtistName;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsPlaying;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsPlaying;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_AlbumArt;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        [Obsolete("MediaControl may be altered or unavailable for releases after Windows 8.1. Instead, use SystemMediaTransportControls.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_AlbumArt;
    }
}
