// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaBreakManager.xml' path='doc/member[@name="IMediaBreakManager"]/*' />
[Guid("A854DDB1-FEB4-4D9B-9D97-0FDBE58E5E39")]
[NativeTypeName("struct IMediaBreakManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaBreakManager : IMediaBreakManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaBreakManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, Guid*, void**, int>)(lpVtbl[0]))((IMediaBreakManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, uint>)(lpVtbl[1]))((IMediaBreakManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, uint>)(lpVtbl[2]))((IMediaBreakManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaBreakManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, HSTRING*, int>)(lpVtbl[4]))((IMediaBreakManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, TrustLevel*, int>)(lpVtbl[5]))((IMediaBreakManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaBreakManager.xml' path='doc/member[@name="IMediaBreakManager.add_BreaksSeekedOver"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_BreaksSeekedOver([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakManager_Windows__CMedia__CPlayback__CMediaBreakSeekedOverEventArgs_t *")] ITypedEventHandler<Pointer<IMediaBreakManager>, Pointer<IMediaBreakSeekedOverEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, ITypedEventHandler<Pointer<IMediaBreakManager>, Pointer<IMediaBreakSeekedOverEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaBreakManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaBreakManager.xml' path='doc/member[@name="IMediaBreakManager.remove_BreaksSeekedOver"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_BreaksSeekedOver(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaBreakManager*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaBreakManager.xml' path='doc/member[@name="IMediaBreakManager.add_BreakStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_BreakStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakManager_Windows__CMedia__CPlayback__CMediaBreakStartedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaBreakManager>, Pointer<IMediaBreakStartedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, ITypedEventHandler<Pointer<IMediaBreakManager>, Pointer<IMediaBreakStartedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IMediaBreakManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaBreakManager.xml' path='doc/member[@name="IMediaBreakManager.remove_BreakStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_BreakStarted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, EventRegistrationToken, int>)(lpVtbl[9]))((IMediaBreakManager*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaBreakManager.xml' path='doc/member[@name="IMediaBreakManager.add_BreakEnded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_BreakEnded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakManager_Windows__CMedia__CPlayback__CMediaBreakEndedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaBreakManager>, Pointer<IMediaBreakEndedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, ITypedEventHandler<Pointer<IMediaBreakManager>, Pointer<IMediaBreakEndedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IMediaBreakManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaBreakManager.xml' path='doc/member[@name="IMediaBreakManager.remove_BreakEnded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_BreakEnded(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, EventRegistrationToken, int>)(lpVtbl[11]))((IMediaBreakManager*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaBreakManager.xml' path='doc/member[@name="IMediaBreakManager.add_BreakSkipped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_BreakSkipped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakManager_Windows__CMedia__CPlayback__CMediaBreakSkippedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaBreakManager>, Pointer<IMediaBreakSkippedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, ITypedEventHandler<Pointer<IMediaBreakManager>, Pointer<IMediaBreakSkippedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IMediaBreakManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaBreakManager.xml' path='doc/member[@name="IMediaBreakManager.remove_BreakSkipped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_BreakSkipped(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, EventRegistrationToken, int>)(lpVtbl[13]))((IMediaBreakManager*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaBreakManager.xml' path='doc/member[@name="IMediaBreakManager.get_CurrentBreak"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_CurrentBreak([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak **")] IMediaBreak** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, IMediaBreak**, int>)(lpVtbl[14]))((IMediaBreakManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBreakManager.xml' path='doc/member[@name="IMediaBreakManager.get_PlaybackSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_PlaybackSession([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSession **")] IMediaPlaybackSession** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, IMediaPlaybackSession**, int>)(lpVtbl[15]))((IMediaBreakManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBreakManager.xml' path='doc/member[@name="IMediaBreakManager.PlayBreak"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT PlayBreak([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, IMediaBreak*, int>)(lpVtbl[16]))((IMediaBreakManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBreakManager.xml' path='doc/member[@name="IMediaBreakManager.SkipCurrentBreak"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SkipCurrentBreak()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakManager*, int>)(lpVtbl[17]))((IMediaBreakManager*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_BreaksSeekedOver([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakManager_Windows__CMedia__CPlayback__CMediaBreakSeekedOverEventArgs_t *")] ITypedEventHandler<Pointer<IMediaBreakManager>, Pointer<IMediaBreakSeekedOverEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_BreaksSeekedOver(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_BreakStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakManager_Windows__CMedia__CPlayback__CMediaBreakStartedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaBreakManager>, Pointer<IMediaBreakStartedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_BreakStarted(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_BreakEnded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakManager_Windows__CMedia__CPlayback__CMediaBreakEndedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaBreakManager>, Pointer<IMediaBreakEndedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_BreakEnded(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_BreakSkipped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakManager_Windows__CMedia__CPlayback__CMediaBreakSkippedEventArgs_t *")] ITypedEventHandler<Pointer<IMediaBreakManager>, Pointer<IMediaBreakSkippedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_BreakSkipped(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT get_CurrentBreak([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak **")] IMediaBreak** value);

        [VtblIndex(15)]
        HRESULT get_PlaybackSession([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackSession **")] IMediaPlaybackSession** value);

        [VtblIndex(16)]
        HRESULT PlayBreak([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak* value);

        [VtblIndex(17)]
        HRESULT SkipCurrentBreak();
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakManager_Windows__CMedia__CPlayback__CMediaBreakSeekedOverEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaBreakManager>, Pointer<IMediaBreakSeekedOverEventArgs>>*, EventRegistrationToken*, int> add_BreaksSeekedOver;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_BreaksSeekedOver;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakManager_Windows__CMedia__CPlayback__CMediaBreakStartedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaBreakManager>, Pointer<IMediaBreakStartedEventArgs>>*, EventRegistrationToken*, int> add_BreakStarted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_BreakStarted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakManager_Windows__CMedia__CPlayback__CMediaBreakEndedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaBreakManager>, Pointer<IMediaBreakEndedEventArgs>>*, EventRegistrationToken*, int> add_BreakEnded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_BreakEnded;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakManager_Windows__CMedia__CPlayback__CMediaBreakSkippedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaBreakManager>, Pointer<IMediaBreakSkippedEventArgs>>*, EventRegistrationToken*, int> add_BreakSkipped;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_BreakSkipped;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaBreak **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaBreak**, int> get_CurrentBreak;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackSession **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackSession**, int> get_PlaybackSession;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaBreak *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaBreak*, int> PlayBreak;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> SkipCurrentBreak;
    }
}
