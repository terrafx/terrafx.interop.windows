// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager"]/*' />
[Guid("5ACEE5A6-5CB6-4A5A-8521-CC86B1C1ED37")]
[NativeTypeName("struct IMediaPlaybackCommandManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackCommandManager : IMediaPlaybackCommandManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlaybackCommandManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, uint>)(lpVtbl[1]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, uint>)(lpVtbl[2]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.get_IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, byte*, int>)(lpVtbl[6]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.put_IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, byte, int>)(lpVtbl[7]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.get_MediaPlayer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MediaPlayer([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlayer **")] IMediaPlayer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, IMediaPlayer**, int>)(lpVtbl[8]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.get_PlayBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PlayBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, IMediaPlaybackCommandManagerCommandBehavior**, int>)(lpVtbl[9]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.get_PauseBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PauseBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, IMediaPlaybackCommandManagerCommandBehavior**, int>)(lpVtbl[10]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.get_NextBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_NextBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, IMediaPlaybackCommandManagerCommandBehavior**, int>)(lpVtbl[11]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.get_PreviousBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PreviousBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, IMediaPlaybackCommandManagerCommandBehavior**, int>)(lpVtbl[12]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.get_FastForwardBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_FastForwardBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, IMediaPlaybackCommandManagerCommandBehavior**, int>)(lpVtbl[13]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.get_RewindBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_RewindBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, IMediaPlaybackCommandManagerCommandBehavior**, int>)(lpVtbl[14]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.get_ShuffleBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ShuffleBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, IMediaPlaybackCommandManagerCommandBehavior**, int>)(lpVtbl[15]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.get_AutoRepeatModeBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_AutoRepeatModeBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, IMediaPlaybackCommandManagerCommandBehavior**, int>)(lpVtbl[16]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.get_PositionBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_PositionBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, IMediaPlaybackCommandManagerCommandBehavior**, int>)(lpVtbl[17]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.get_RateBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_RateBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, IMediaPlaybackCommandManagerCommandBehavior**, int>)(lpVtbl[18]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.add_PlayReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT add_PlayReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPlayReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerPlayReceivedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerPlayReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[19]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.remove_PlayReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT remove_PlayReceived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, EventRegistrationToken, int>)(lpVtbl[20]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.add_PauseReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT add_PauseReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPauseReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerPauseReceivedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerPauseReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[21]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.remove_PauseReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT remove_PauseReceived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, EventRegistrationToken, int>)(lpVtbl[22]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.add_NextReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT add_NextReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerNextReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerNextReceivedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerNextReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[23]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.remove_NextReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT remove_NextReceived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, EventRegistrationToken, int>)(lpVtbl[24]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.add_PreviousReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT add_PreviousReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPreviousReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerPreviousReceivedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerPreviousReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[25]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.remove_PreviousReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT remove_PreviousReceived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, EventRegistrationToken, int>)(lpVtbl[26]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.add_FastForwardReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT add_FastForwardReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerFastForwardReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerFastForwardReceivedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerFastForwardReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[27]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.remove_FastForwardReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT remove_FastForwardReceived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, EventRegistrationToken, int>)(lpVtbl[28]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.add_RewindReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT add_RewindReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerRewindReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerRewindReceivedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerRewindReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[29]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.remove_RewindReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT remove_RewindReceived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, EventRegistrationToken, int>)(lpVtbl[30]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.add_ShuffleReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT add_ShuffleReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerShuffleReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerShuffleReceivedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerShuffleReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[31]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.remove_ShuffleReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT remove_ShuffleReceived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, EventRegistrationToken, int>)(lpVtbl[32]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.add_AutoRepeatModeReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT add_AutoRepeatModeReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[33]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.remove_AutoRepeatModeReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT remove_AutoRepeatModeReceived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, EventRegistrationToken, int>)(lpVtbl[34]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.add_PositionReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT add_PositionReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPositionReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerPositionReceivedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerPositionReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[35]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.remove_PositionReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT remove_PositionReceived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, EventRegistrationToken, int>)(lpVtbl[36]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.add_RateReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT add_RateReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerRateReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerRateReceivedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerRateReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[37]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaPlaybackCommandManager.xml' path='doc/member[@name="IMediaPlaybackCommandManager.remove_RateReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT remove_RateReceived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackCommandManager*, EventRegistrationToken, int>)(lpVtbl[38]))((IMediaPlaybackCommandManager*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_MediaPlayer([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlayer **")] IMediaPlayer** value);

        [VtblIndex(9)]
        HRESULT get_PlayBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value);

        [VtblIndex(10)]
        HRESULT get_PauseBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value);

        [VtblIndex(11)]
        HRESULT get_NextBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value);

        [VtblIndex(12)]
        HRESULT get_PreviousBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value);

        [VtblIndex(13)]
        HRESULT get_FastForwardBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value);

        [VtblIndex(14)]
        HRESULT get_RewindBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value);

        [VtblIndex(15)]
        HRESULT get_ShuffleBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value);

        [VtblIndex(16)]
        HRESULT get_AutoRepeatModeBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value);

        [VtblIndex(17)]
        HRESULT get_PositionBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value);

        [VtblIndex(18)]
        HRESULT get_RateBehavior([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **")] IMediaPlaybackCommandManagerCommandBehavior** value);

        [VtblIndex(19)]
        HRESULT add_PlayReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPlayReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerPlayReceivedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(20)]
        HRESULT remove_PlayReceived(EventRegistrationToken token);

        [VtblIndex(21)]
        HRESULT add_PauseReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPauseReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerPauseReceivedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(22)]
        HRESULT remove_PauseReceived(EventRegistrationToken token);

        [VtblIndex(23)]
        HRESULT add_NextReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerNextReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerNextReceivedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(24)]
        HRESULT remove_NextReceived(EventRegistrationToken token);

        [VtblIndex(25)]
        HRESULT add_PreviousReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPreviousReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerPreviousReceivedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(26)]
        HRESULT remove_PreviousReceived(EventRegistrationToken token);

        [VtblIndex(27)]
        HRESULT add_FastForwardReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerFastForwardReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerFastForwardReceivedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(28)]
        HRESULT remove_FastForwardReceived(EventRegistrationToken token);

        [VtblIndex(29)]
        HRESULT add_RewindReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerRewindReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerRewindReceivedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(30)]
        HRESULT remove_RewindReceived(EventRegistrationToken token);

        [VtblIndex(31)]
        HRESULT add_ShuffleReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerShuffleReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerShuffleReceivedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(32)]
        HRESULT remove_ShuffleReceived(EventRegistrationToken token);

        [VtblIndex(33)]
        HRESULT add_AutoRepeatModeReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(34)]
        HRESULT remove_AutoRepeatModeReceived(EventRegistrationToken token);

        [VtblIndex(35)]
        HRESULT add_PositionReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPositionReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerPositionReceivedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(36)]
        HRESULT remove_PositionReceived(EventRegistrationToken token);

        [VtblIndex(37)]
        HRESULT add_RateReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerRateReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerRateReceivedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(38)]
        HRESULT remove_RateReceived(EventRegistrationToken token);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlayer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlayer**, int> get_MediaPlayer;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackCommandManagerCommandBehavior**, int> get_PlayBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackCommandManagerCommandBehavior**, int> get_PauseBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackCommandManagerCommandBehavior**, int> get_NextBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackCommandManagerCommandBehavior**, int> get_PreviousBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackCommandManagerCommandBehavior**, int> get_FastForwardBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackCommandManagerCommandBehavior**, int> get_RewindBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackCommandManagerCommandBehavior**, int> get_ShuffleBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackCommandManagerCommandBehavior**, int> get_AutoRepeatModeBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackCommandManagerCommandBehavior**, int> get_PositionBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackCommandManagerCommandBehavior **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackCommandManagerCommandBehavior**, int> get_RateBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPlayReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerPlayReceivedEventArgs>>*, EventRegistrationToken*, int> add_PlayReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PlayReceived;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPauseReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerPauseReceivedEventArgs>>*, EventRegistrationToken*, int> add_PauseReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PauseReceived;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerNextReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerNextReceivedEventArgs>>*, EventRegistrationToken*, int> add_NextReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_NextReceived;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPreviousReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerPreviousReceivedEventArgs>>*, EventRegistrationToken*, int> add_PreviousReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PreviousReceived;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerFastForwardReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerFastForwardReceivedEventArgs>>*, EventRegistrationToken*, int> add_FastForwardReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_FastForwardReceived;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerRewindReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerRewindReceivedEventArgs>>*, EventRegistrationToken*, int> add_RewindReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RewindReceived;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerShuffleReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerShuffleReceivedEventArgs>>*, EventRegistrationToken*, int> add_ShuffleReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ShuffleReceived;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs>>*, EventRegistrationToken*, int> add_AutoRepeatModeReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AutoRepeatModeReceived;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerPositionReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerPositionReceivedEventArgs>>*, EventRegistrationToken*, int> add_PositionReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PositionReceived;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaPlaybackCommandManager_Windows__CMedia__CPlayback__CMediaPlaybackCommandManagerRateReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaPlaybackCommandManager>, Pointer<IMediaPlaybackCommandManagerRateReceivedEventArgs>>*, EventRegistrationToken*, int> add_RateReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RateReceived;
    }
}
