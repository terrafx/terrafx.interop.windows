// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaBreakSchedule.xml' path='doc/member[@name="IMediaBreakSchedule"]/*' />
[Guid("A19A5813-98B6-41D8-83DA-F971D22B7BBA")]
[NativeTypeName("struct IMediaBreakSchedule : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaBreakSchedule : IMediaBreakSchedule.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaBreakSchedule));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSchedule*, Guid*, void**, int>)(lpVtbl[0]))((IMediaBreakSchedule*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSchedule*, uint>)(lpVtbl[1]))((IMediaBreakSchedule*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSchedule*, uint>)(lpVtbl[2]))((IMediaBreakSchedule*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSchedule*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaBreakSchedule*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSchedule*, HSTRING*, int>)(lpVtbl[4]))((IMediaBreakSchedule*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSchedule*, TrustLevel*, int>)(lpVtbl[5]))((IMediaBreakSchedule*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaBreakSchedule.xml' path='doc/member[@name="IMediaBreakSchedule.add_ScheduleChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ScheduleChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakSchedule_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaBreakSchedule>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSchedule*, ITypedEventHandler<Pointer<IMediaBreakSchedule>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IMediaBreakSchedule*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaBreakSchedule.xml' path='doc/member[@name="IMediaBreakSchedule.remove_ScheduleChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ScheduleChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSchedule*, EventRegistrationToken, int>)(lpVtbl[7]))((IMediaBreakSchedule*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IMediaBreakSchedule.xml' path='doc/member[@name="IMediaBreakSchedule.InsertMidrollBreak"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InsertMidrollBreak([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak* mediaBreak)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSchedule*, IMediaBreak*, int>)(lpVtbl[8]))((IMediaBreakSchedule*)Unsafe.AsPointer(ref this), mediaBreak);
    }

    /// <include file='IMediaBreakSchedule.xml' path='doc/member[@name="IMediaBreakSchedule.RemoveMidrollBreak"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveMidrollBreak([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak* mediaBreak)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSchedule*, IMediaBreak*, int>)(lpVtbl[9]))((IMediaBreakSchedule*)Unsafe.AsPointer(ref this), mediaBreak);
    }

    /// <include file='IMediaBreakSchedule.xml' path='doc/member[@name="IMediaBreakSchedule.get_MidrollBreaks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MidrollBreaks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CPlayback__CMediaBreak_t **")] IVectorView<Pointer<IMediaBreak>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSchedule*, IVectorView<Pointer<IMediaBreak>>**, int>)(lpVtbl[10]))((IMediaBreakSchedule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBreakSchedule.xml' path='doc/member[@name="IMediaBreakSchedule.put_PrerollBreak"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_PrerollBreak([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSchedule*, IMediaBreak*, int>)(lpVtbl[11]))((IMediaBreakSchedule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBreakSchedule.xml' path='doc/member[@name="IMediaBreakSchedule.get_PrerollBreak"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PrerollBreak([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak **")] IMediaBreak** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSchedule*, IMediaBreak**, int>)(lpVtbl[12]))((IMediaBreakSchedule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBreakSchedule.xml' path='doc/member[@name="IMediaBreakSchedule.put_PostrollBreak"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_PostrollBreak([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSchedule*, IMediaBreak*, int>)(lpVtbl[13]))((IMediaBreakSchedule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBreakSchedule.xml' path='doc/member[@name="IMediaBreakSchedule.get_PostrollBreak"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PostrollBreak([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak **")] IMediaBreak** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSchedule*, IMediaBreak**, int>)(lpVtbl[14]))((IMediaBreakSchedule*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaBreakSchedule.xml' path='doc/member[@name="IMediaBreakSchedule.get_PlaybackItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_PlaybackItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaBreakSchedule*, IMediaPlaybackItem**, int>)(lpVtbl[15]))((IMediaBreakSchedule*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ScheduleChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakSchedule_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaBreakSchedule>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_ScheduleChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT InsertMidrollBreak([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak* mediaBreak);

        [VtblIndex(9)]
        HRESULT RemoveMidrollBreak([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak* mediaBreak);

        [VtblIndex(10)]
        HRESULT get_MidrollBreaks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CPlayback__CMediaBreak_t **")] IVectorView<Pointer<IMediaBreak>>** value);

        [VtblIndex(11)]
        HRESULT put_PrerollBreak([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak* value);

        [VtblIndex(12)]
        HRESULT get_PrerollBreak([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak **")] IMediaBreak** value);

        [VtblIndex(13)]
        HRESULT put_PostrollBreak([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak *")] IMediaBreak* value);

        [VtblIndex(14)]
        HRESULT get_PostrollBreak([NativeTypeName("ABI::Windows::Media::Playback::IMediaBreak **")] IMediaBreak** value);

        [VtblIndex(15)]
        HRESULT get_PlaybackItem([NativeTypeName("ABI::Windows::Media::Playback::IMediaPlaybackItem **")] IMediaPlaybackItem** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CPlayback__CMediaBreakSchedule_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaBreakSchedule>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_ScheduleChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ScheduleChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaBreak *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaBreak*, int> InsertMidrollBreak;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaBreak *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaBreak*, int> RemoveMidrollBreak;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CPlayback__CMediaBreak_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IMediaBreak>>**, int> get_MidrollBreaks;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaBreak *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaBreak*, int> put_PrerollBreak;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaBreak **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaBreak**, int> get_PrerollBreak;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaBreak *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaBreak*, int> put_PostrollBreak;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaBreak **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaBreak**, int> get_PostrollBreak;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaPlaybackItem**, int> get_PlaybackItem;
    }
}
