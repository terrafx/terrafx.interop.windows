// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer"]/*' />
[Guid("381A83CB-6FFF-499B-8D64-2885DFC1249E")]
[NativeTypeName("struct IMediaPlayer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlayer : IMediaPlayer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlayer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlayer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, uint>)(lpVtbl[1]))((IMediaPlayer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, uint>)(lpVtbl[2]))((IMediaPlayer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlayer*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlayer*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlayer*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.get_AutoPlay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AutoPlay([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, byte*, int>)(lpVtbl[6]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.put_AutoPlay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AutoPlay([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, byte, int>)(lpVtbl[7]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.get_NaturalDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Use PlaybackSession.NaturalDuration instead of NaturalDuration.  For more info, see MSDN.")]
    public HRESULT get_NaturalDuration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, TimeSpan*, int>)(lpVtbl[8]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.")]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, TimeSpan*, int>)(lpVtbl[9]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.put_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.")]
    public HRESULT put_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, TimeSpan, int>)(lpVtbl[10]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.get_BufferingProgress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("Use PlaybackSession.BufferingProgress instead of BufferingProgress.  For more info, see MSDN.")]
    public HRESULT get_BufferingProgress(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, double*, int>)(lpVtbl[11]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.get_CurrentState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete("Use PlaybackSession.State instead of CurrentState.  For more info, see MSDN.")]
    public HRESULT get_CurrentState([NativeTypeName("ABI::Windows::Media::Playback::MediaPlayerState *")] MediaPlayerState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, MediaPlayerState*, int>)(lpVtbl[12]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.get_CanSeek"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete("Use PlaybackSession.CanSeek instead of CanSeek.  For more info, see MSDN.")]
    public HRESULT get_CanSeek([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, byte*, int>)(lpVtbl[13]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.get_CanPause"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("Use PlaybackSession.CanPause instead of CanPause.  For more info, see MSDN.")]
    public HRESULT get_CanPause([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, byte*, int>)(lpVtbl[14]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.get_IsLoopingEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsLoopingEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, byte*, int>)(lpVtbl[15]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.put_IsLoopingEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_IsLoopingEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, byte, int>)(lpVtbl[16]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.get_IsProtected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [Obsolete("Use PlaybackSession.IsProtected instead of IsProtected.  For more info, see MSDN.")]
    public HRESULT get_IsProtected([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, byte*, int>)(lpVtbl[17]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.get_IsMuted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_IsMuted([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, byte*, int>)(lpVtbl[18]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.put_IsMuted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_IsMuted([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, byte, int>)(lpVtbl[19]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.get_PlaybackRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [Obsolete("Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN.")]
    public HRESULT get_PlaybackRate(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, double*, int>)(lpVtbl[20]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.put_PlaybackRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [Obsolete("Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN.")]
    public HRESULT put_PlaybackRate(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, double, int>)(lpVtbl[21]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.get_Volume"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Volume(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, double*, int>)(lpVtbl[22]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.put_Volume"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_Volume(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, double, int>)(lpVtbl[23]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.get_PlaybackMediaMarkers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    [Obsolete("Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN.")]
    public HRESULT get_PlaybackMediaMarkers([NativeTypeName("ABI::Windows::Media::Playback::IPlaybackMediaMarkerSequence **")] IPlaybackMediaMarkerSequence** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, IPlaybackMediaMarkerSequence**, int>)(lpVtbl[24]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.add_MediaOpened"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT add_MediaOpened([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[25]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.remove_MediaOpened"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT remove_MediaOpened(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, EventRegistrationToken, int>)(lpVtbl[26]))((IMediaPlayer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.add_MediaEnded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT add_MediaEnded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[27]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.remove_MediaEnded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT remove_MediaEnded(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, EventRegistrationToken, int>)(lpVtbl[28]))((IMediaPlayer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.add_MediaFailed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT add_MediaFailed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CMediaPlayerFailedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IMediaPlayerFailedEventArgs>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IMediaPlayerFailedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[29]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.remove_MediaFailed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT remove_MediaFailed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, EventRegistrationToken, int>)(lpVtbl[30]))((IMediaPlayer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.add_CurrentStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    [Obsolete("Use PlaybackSession.PlaybackStateChanged instead of CurrentStateChanged.  For more info, see MSDN.")]
    public HRESULT add_CurrentStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[31]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.remove_CurrentStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    [Obsolete("Use PlaybackSession.PlaybackStateChanged instead of CurrentStateChanged.  For more info, see MSDN.")]
    public HRESULT remove_CurrentStateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, EventRegistrationToken, int>)(lpVtbl[32]))((IMediaPlayer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.add_PlaybackMediaMarkerReached"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    [Obsolete("Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN.")]
    public HRESULT add_PlaybackMediaMarkerReached([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CPlaybackMediaMarkerReachedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IPlaybackMediaMarkerReachedEventArgs>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IPlaybackMediaMarkerReachedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[33]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.remove_PlaybackMediaMarkerReached"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    [Obsolete("Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN.")]
    public HRESULT remove_PlaybackMediaMarkerReached(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, EventRegistrationToken, int>)(lpVtbl[34]))((IMediaPlayer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.add_MediaPlayerRateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    [Obsolete("Use PlaybackSession.PlaybackRateChanged instead of MediaPlayerRateChanged.  For more info, see MSDN.")]
    public HRESULT add_MediaPlayerRateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CMediaPlayerRateChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IMediaPlayerRateChangedEventArgs>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IMediaPlayerRateChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[35]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.remove_MediaPlayerRateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    [Obsolete("Use PlaybackSession.PlaybackRateChanged instead of MediaPlayerRateChanged.  For more info, see MSDN.")]
    public HRESULT remove_MediaPlayerRateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, EventRegistrationToken, int>)(lpVtbl[36]))((IMediaPlayer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.add_VolumeChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT add_VolumeChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[37]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.remove_VolumeChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT remove_VolumeChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, EventRegistrationToken, int>)(lpVtbl[38]))((IMediaPlayer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.add_SeekCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    [Obsolete("Use PlaybackSession.SeekCompleted instead of SeekCompleted.  For more info, see MSDN.")]
    public HRESULT add_SeekCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[39]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.remove_SeekCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    [Obsolete("Use PlaybackSession.SeekCompleted instead of SeekCompleted.  For more info, see MSDN.")]
    public HRESULT remove_SeekCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, EventRegistrationToken, int>)(lpVtbl[40]))((IMediaPlayer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.add_BufferingStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    [Obsolete("Use PlaybackSession.BufferingStarted instead of BufferingStarted.  For more info, see MSDN.")]
    public HRESULT add_BufferingStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[41]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.remove_BufferingStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    [Obsolete("Use PlaybackSession.BufferingStarted instead of BufferingStarted.  For more info, see MSDN.")]
    public HRESULT remove_BufferingStarted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, EventRegistrationToken, int>)(lpVtbl[42]))((IMediaPlayer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.add_BufferingEnded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    [Obsolete("Use PlaybackSession.BufferingEnded instead of BufferingEnded.  For more info, see MSDN.")]
    public HRESULT add_BufferingEnded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[43]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.remove_BufferingEnded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    [Obsolete("Use PlaybackSession.BufferingEnded instead of BufferingEnded.  For more info, see MSDN.")]
    public HRESULT remove_BufferingEnded(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, EventRegistrationToken, int>)(lpVtbl[44]))((IMediaPlayer*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.Play"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT Play()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, int>)(lpVtbl[45]))((IMediaPlayer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.Pause"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, int>)(lpVtbl[46]))((IMediaPlayer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaPlayer.xml' path='doc/member[@name="IMediaPlayer.SetUriSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    [Obsolete("Use Source instead of SetUriSource.  For more info, see MSDN.")]
    public HRESULT SetUriSource([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayer*, IUriRuntimeClass*, int>)(lpVtbl[47]))((IMediaPlayer*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AutoPlay([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_AutoPlay([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        [Obsolete("Use PlaybackSession.NaturalDuration instead of NaturalDuration.  For more info, see MSDN.")]
        HRESULT get_NaturalDuration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(9)]
        [Obsolete("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.")]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(10)]
        [Obsolete("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.")]
        HRESULT put_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(11)]
        [Obsolete("Use PlaybackSession.BufferingProgress instead of BufferingProgress.  For more info, see MSDN.")]
        HRESULT get_BufferingProgress(double* value);

        [VtblIndex(12)]
        [Obsolete("Use PlaybackSession.State instead of CurrentState.  For more info, see MSDN.")]
        HRESULT get_CurrentState([NativeTypeName("ABI::Windows::Media::Playback::MediaPlayerState *")] MediaPlayerState* value);

        [VtblIndex(13)]
        [Obsolete("Use PlaybackSession.CanSeek instead of CanSeek.  For more info, see MSDN.")]
        HRESULT get_CanSeek([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        [Obsolete("Use PlaybackSession.CanPause instead of CanPause.  For more info, see MSDN.")]
        HRESULT get_CanPause([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT get_IsLoopingEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT put_IsLoopingEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(17)]
        [Obsolete("Use PlaybackSession.IsProtected instead of IsProtected.  For more info, see MSDN.")]
        HRESULT get_IsProtected([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(18)]
        HRESULT get_IsMuted([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT put_IsMuted([NativeTypeName("boolean")] byte value);

        [VtblIndex(20)]
        [Obsolete("Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN.")]
        HRESULT get_PlaybackRate(double* value);

        [VtblIndex(21)]
        [Obsolete("Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN.")]
        HRESULT put_PlaybackRate(double value);

        [VtblIndex(22)]
        HRESULT get_Volume(double* value);

        [VtblIndex(23)]
        HRESULT put_Volume(double value);

        [VtblIndex(24)]
        [Obsolete("Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN.")]
        HRESULT get_PlaybackMediaMarkers([NativeTypeName("ABI::Windows::Media::Playback::IPlaybackMediaMarkerSequence **")] IPlaybackMediaMarkerSequence** value);

        [VtblIndex(25)]
        HRESULT add_MediaOpened([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>* value, EventRegistrationToken* token);

        [VtblIndex(26)]
        HRESULT remove_MediaOpened(EventRegistrationToken token);

        [VtblIndex(27)]
        HRESULT add_MediaEnded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>* value, EventRegistrationToken* token);

        [VtblIndex(28)]
        HRESULT remove_MediaEnded(EventRegistrationToken token);

        [VtblIndex(29)]
        HRESULT add_MediaFailed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CMediaPlayerFailedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IMediaPlayerFailedEventArgs>>* value, EventRegistrationToken* token);

        [VtblIndex(30)]
        HRESULT remove_MediaFailed(EventRegistrationToken token);

        [VtblIndex(31)]
        [Obsolete("Use PlaybackSession.PlaybackStateChanged instead of CurrentStateChanged.  For more info, see MSDN.")]
        HRESULT add_CurrentStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>* value, EventRegistrationToken* token);

        [VtblIndex(32)]
        [Obsolete("Use PlaybackSession.PlaybackStateChanged instead of CurrentStateChanged.  For more info, see MSDN.")]
        HRESULT remove_CurrentStateChanged(EventRegistrationToken token);

        [VtblIndex(33)]
        [Obsolete("Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN.")]
        HRESULT add_PlaybackMediaMarkerReached([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CPlaybackMediaMarkerReachedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IPlaybackMediaMarkerReachedEventArgs>>* value, EventRegistrationToken* token);

        [VtblIndex(34)]
        [Obsolete("Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN.")]
        HRESULT remove_PlaybackMediaMarkerReached(EventRegistrationToken token);

        [VtblIndex(35)]
        [Obsolete("Use PlaybackSession.PlaybackRateChanged instead of MediaPlayerRateChanged.  For more info, see MSDN.")]
        HRESULT add_MediaPlayerRateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CMediaPlayerRateChangedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IMediaPlayerRateChangedEventArgs>>* value, EventRegistrationToken* token);

        [VtblIndex(36)]
        [Obsolete("Use PlaybackSession.PlaybackRateChanged instead of MediaPlayerRateChanged.  For more info, see MSDN.")]
        HRESULT remove_MediaPlayerRateChanged(EventRegistrationToken token);

        [VtblIndex(37)]
        HRESULT add_VolumeChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>* value, EventRegistrationToken* token);

        [VtblIndex(38)]
        HRESULT remove_VolumeChanged(EventRegistrationToken token);

        [VtblIndex(39)]
        [Obsolete("Use PlaybackSession.SeekCompleted instead of SeekCompleted.  For more info, see MSDN.")]
        HRESULT add_SeekCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>* value, EventRegistrationToken* token);

        [VtblIndex(40)]
        [Obsolete("Use PlaybackSession.SeekCompleted instead of SeekCompleted.  For more info, see MSDN.")]
        HRESULT remove_SeekCompleted(EventRegistrationToken token);

        [VtblIndex(41)]
        [Obsolete("Use PlaybackSession.BufferingStarted instead of BufferingStarted.  For more info, see MSDN.")]
        HRESULT add_BufferingStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>* value, EventRegistrationToken* token);

        [VtblIndex(42)]
        [Obsolete("Use PlaybackSession.BufferingStarted instead of BufferingStarted.  For more info, see MSDN.")]
        HRESULT remove_BufferingStarted(EventRegistrationToken token);

        [VtblIndex(43)]
        [Obsolete("Use PlaybackSession.BufferingEnded instead of BufferingEnded.  For more info, see MSDN.")]
        HRESULT add_BufferingEnded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>* value, EventRegistrationToken* token);

        [VtblIndex(44)]
        [Obsolete("Use PlaybackSession.BufferingEnded instead of BufferingEnded.  For more info, see MSDN.")]
        HRESULT remove_BufferingEnded(EventRegistrationToken token);

        [VtblIndex(45)]
        HRESULT Play();

        [VtblIndex(46)]
        HRESULT Pause();

        [VtblIndex(47)]
        [Obsolete("Use Source instead of SetUriSource.  For more info, see MSDN.")]
        HRESULT SetUriSource([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AutoPlay;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AutoPlay;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.NaturalDuration instead of NaturalDuration.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_NaturalDuration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.Position instead of Position.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_Position;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.BufferingProgress instead of BufferingProgress.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_BufferingProgress;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::MediaPlayerState *) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.State instead of CurrentState.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaPlayerState*, int> get_CurrentState;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.CanSeek instead of CanSeek.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanSeek;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.CanPause instead of CanPause.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanPause;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsLoopingEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsLoopingEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.IsProtected instead of IsProtected.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsProtected;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsMuted;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsMuted;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_PlaybackRate;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.PlaybackRate instead of PlaybackRate.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_PlaybackRate;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_Volume;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_Volume;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IPlaybackMediaMarkerSequence **) __attribute__((stdcall))")]
        [Obsolete("Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPlaybackMediaMarkerSequence**, int> get_PlaybackMediaMarkers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_MediaOpened;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MediaOpened;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_MediaEnded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MediaEnded;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CMediaPlayerFailedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IMediaPlayerFailedEventArgs>>*, EventRegistrationToken*, int> add_MediaFailed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MediaFailed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.PlaybackStateChanged instead of CurrentStateChanged.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_CurrentStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.PlaybackStateChanged instead of CurrentStateChanged.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CurrentStateChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CPlaybackMediaMarkerReachedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IPlaybackMediaMarkerReachedEventArgs>>*, EventRegistrationToken*, int> add_PlaybackMediaMarkerReached;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("Use media tracks on MediaPlaybackItem instead of PlaybackMediaMarkers.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PlaybackMediaMarkerReached;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_Windows__CMedia__CPlayback__CMediaPlayerRateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.PlaybackRateChanged instead of MediaPlayerRateChanged.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IMediaPlayerRateChangedEventArgs>>*, EventRegistrationToken*, int> add_MediaPlayerRateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.PlaybackRateChanged instead of MediaPlayerRateChanged.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MediaPlayerRateChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_VolumeChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_VolumeChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.SeekCompleted instead of SeekCompleted.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_SeekCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.SeekCompleted instead of SeekCompleted.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SeekCompleted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.BufferingStarted instead of BufferingStarted.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_BufferingStarted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.BufferingStarted instead of BufferingStarted.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_BufferingStarted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlayer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.BufferingEnded instead of BufferingEnded.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlayer>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_BufferingEnded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("Use PlaybackSession.BufferingEnded instead of BufferingEnded.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_BufferingEnded;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Play;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Pause;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        [Obsolete("Use Source instead of SetUriSource.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> SetUriSource;
    }
}
