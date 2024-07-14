// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISystemMediaTransportControls2.xml' path='doc/member[@name="ISystemMediaTransportControls2"]/*' />
[Guid("EA98D2F6-7F3C-4AF2-A586-72889808EFB1")]
[NativeTypeName("struct ISystemMediaTransportControls2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemMediaTransportControls2 : ISystemMediaTransportControls2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISystemMediaTransportControls2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, Guid*, void**, int>)(lpVtbl[0]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, uint>)(lpVtbl[1]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, uint>)(lpVtbl[2]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, HSTRING*, int>)(lpVtbl[4]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, TrustLevel*, int>)(lpVtbl[5]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISystemMediaTransportControls2.xml' path='doc/member[@name="ISystemMediaTransportControls2.get_AutoRepeatMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AutoRepeatMode([NativeTypeName("ABI::Windows::Media::MediaPlaybackAutoRepeatMode *")] MediaPlaybackAutoRepeatMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, MediaPlaybackAutoRepeatMode*, int>)(lpVtbl[6]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControls2.xml' path='doc/member[@name="ISystemMediaTransportControls2.put_AutoRepeatMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AutoRepeatMode([NativeTypeName("ABI::Windows::Media::MediaPlaybackAutoRepeatMode")] MediaPlaybackAutoRepeatMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, MediaPlaybackAutoRepeatMode, int>)(lpVtbl[7]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControls2.xml' path='doc/member[@name="ISystemMediaTransportControls2.get_ShuffleEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ShuffleEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, byte*, int>)(lpVtbl[8]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControls2.xml' path='doc/member[@name="ISystemMediaTransportControls2.put_ShuffleEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ShuffleEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, byte, int>)(lpVtbl[9]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControls2.xml' path='doc/member[@name="ISystemMediaTransportControls2.get_PlaybackRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PlaybackRate(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, double*, int>)(lpVtbl[10]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControls2.xml' path='doc/member[@name="ISystemMediaTransportControls2.put_PlaybackRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_PlaybackRate(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, double, int>)(lpVtbl[11]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControls2.xml' path='doc/member[@name="ISystemMediaTransportControls2.UpdateTimelineProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT UpdateTimelineProperties([NativeTypeName("ABI::Windows::Media::ISystemMediaTransportControlsTimelineProperties *")] ISystemMediaTransportControlsTimelineProperties* timelineProperties)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, ISystemMediaTransportControlsTimelineProperties*, int>)(lpVtbl[12]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), timelineProperties);
    }

    /// <include file='ISystemMediaTransportControls2.xml' path='doc/member[@name="ISystemMediaTransportControls2.add_PlaybackPositionChangeRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_PlaybackPositionChangeRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CPlaybackPositionChangeRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ISystemMediaTransportControls>, Pointer<IPlaybackPositionChangeRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, ITypedEventHandler<Pointer<ISystemMediaTransportControls>, Pointer<IPlaybackPositionChangeRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISystemMediaTransportControls2.xml' path='doc/member[@name="ISystemMediaTransportControls2.remove_PlaybackPositionChangeRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_PlaybackPositionChangeRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, EventRegistrationToken, int>)(lpVtbl[14]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISystemMediaTransportControls2.xml' path='doc/member[@name="ISystemMediaTransportControls2.add_PlaybackRateChangeRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_PlaybackRateChangeRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CPlaybackRateChangeRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ISystemMediaTransportControls>, Pointer<IPlaybackRateChangeRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, ITypedEventHandler<Pointer<ISystemMediaTransportControls>, Pointer<IPlaybackRateChangeRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[15]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISystemMediaTransportControls2.xml' path='doc/member[@name="ISystemMediaTransportControls2.remove_PlaybackRateChangeRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_PlaybackRateChangeRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, EventRegistrationToken, int>)(lpVtbl[16]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISystemMediaTransportControls2.xml' path='doc/member[@name="ISystemMediaTransportControls2.add_ShuffleEnabledChangeRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_ShuffleEnabledChangeRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CShuffleEnabledChangeRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ISystemMediaTransportControls>, Pointer<IShuffleEnabledChangeRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, ITypedEventHandler<Pointer<ISystemMediaTransportControls>, Pointer<IShuffleEnabledChangeRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[17]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISystemMediaTransportControls2.xml' path='doc/member[@name="ISystemMediaTransportControls2.remove_ShuffleEnabledChangeRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_ShuffleEnabledChangeRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, EventRegistrationToken, int>)(lpVtbl[18]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISystemMediaTransportControls2.xml' path='doc/member[@name="ISystemMediaTransportControls2.add_AutoRepeatModeChangeRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT add_AutoRepeatModeChangeRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CAutoRepeatModeChangeRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ISystemMediaTransportControls>, Pointer<IAutoRepeatModeChangeRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, ITypedEventHandler<Pointer<ISystemMediaTransportControls>, Pointer<IAutoRepeatModeChangeRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[19]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISystemMediaTransportControls2.xml' path='doc/member[@name="ISystemMediaTransportControls2.remove_AutoRepeatModeChangeRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT remove_AutoRepeatModeChangeRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControls2*, EventRegistrationToken, int>)(lpVtbl[20]))((ISystemMediaTransportControls2*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AutoRepeatMode([NativeTypeName("ABI::Windows::Media::MediaPlaybackAutoRepeatMode *")] MediaPlaybackAutoRepeatMode* value);

        [VtblIndex(7)]
        HRESULT put_AutoRepeatMode([NativeTypeName("ABI::Windows::Media::MediaPlaybackAutoRepeatMode")] MediaPlaybackAutoRepeatMode value);

        [VtblIndex(8)]
        HRESULT get_ShuffleEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_ShuffleEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_PlaybackRate(double* value);

        [VtblIndex(11)]
        HRESULT put_PlaybackRate(double value);

        [VtblIndex(12)]
        HRESULT UpdateTimelineProperties([NativeTypeName("ABI::Windows::Media::ISystemMediaTransportControlsTimelineProperties *")] ISystemMediaTransportControlsTimelineProperties* timelineProperties);

        [VtblIndex(13)]
        HRESULT add_PlaybackPositionChangeRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CPlaybackPositionChangeRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ISystemMediaTransportControls>, Pointer<IPlaybackPositionChangeRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_PlaybackPositionChangeRequested(EventRegistrationToken token);

        [VtblIndex(15)]
        HRESULT add_PlaybackRateChangeRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CPlaybackRateChangeRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ISystemMediaTransportControls>, Pointer<IPlaybackRateChangeRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(16)]
        HRESULT remove_PlaybackRateChangeRequested(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT add_ShuffleEnabledChangeRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CShuffleEnabledChangeRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ISystemMediaTransportControls>, Pointer<IShuffleEnabledChangeRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(18)]
        HRESULT remove_ShuffleEnabledChangeRequested(EventRegistrationToken token);

        [VtblIndex(19)]
        HRESULT add_AutoRepeatModeChangeRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CAutoRepeatModeChangeRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ISystemMediaTransportControls>, Pointer<IAutoRepeatModeChangeRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(20)]
        HRESULT remove_AutoRepeatModeChangeRequested(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaPlaybackAutoRepeatMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaPlaybackAutoRepeatMode*, int> get_AutoRepeatMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaPlaybackAutoRepeatMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaPlaybackAutoRepeatMode, int> put_AutoRepeatMode;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ShuffleEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ShuffleEnabled;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_PlaybackRate;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_PlaybackRate;

        [NativeTypeName("HRESULT (ABI::Windows::Media::ISystemMediaTransportControlsTimelineProperties *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISystemMediaTransportControlsTimelineProperties*, int> UpdateTimelineProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CPlaybackPositionChangeRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISystemMediaTransportControls>, Pointer<IPlaybackPositionChangeRequestedEventArgs>>*, EventRegistrationToken*, int> add_PlaybackPositionChangeRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PlaybackPositionChangeRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CPlaybackRateChangeRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISystemMediaTransportControls>, Pointer<IPlaybackRateChangeRequestedEventArgs>>*, EventRegistrationToken*, int> add_PlaybackRateChangeRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PlaybackRateChangeRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CShuffleEnabledChangeRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISystemMediaTransportControls>, Pointer<IShuffleEnabledChangeRequestedEventArgs>>*, EventRegistrationToken*, int> add_ShuffleEnabledChangeRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ShuffleEnabledChangeRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSystemMediaTransportControls_Windows__CMedia__CAutoRepeatModeChangeRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISystemMediaTransportControls>, Pointer<IAutoRepeatModeChangeRequestedEventArgs>>*, EventRegistrationToken*, int> add_AutoRepeatModeChangeRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AutoRepeatModeChangeRequested;
    }
}
