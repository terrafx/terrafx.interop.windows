// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimedMetadataTrack.xml' path='doc/member[@name="ITimedMetadataTrack"]/*' />
[Guid("9E6AED9E-F67A-49A9-B330-CF03B0E9CF07")]
[NativeTypeName("struct ITimedMetadataTrack : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedMetadataTrack : ITimedMetadataTrack.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITimedMetadataTrack);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, Guid*, void**, int>)(lpVtbl[0]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, uint>)(lpVtbl[1]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, uint>)(lpVtbl[2]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, uint*, Guid**, int>)(lpVtbl[3]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, HSTRING*, int>)(lpVtbl[4]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, TrustLevel*, int>)(lpVtbl[5]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimedMetadataTrack.xml' path='doc/member[@name="ITimedMetadataTrack.add_CueEntered"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_CueEntered([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CTimedMetadataTrack_Windows__CMedia__CCore__CMediaCueEventArgs_t *")] ITypedEventHandler<Pointer<ITimedMetadataTrack>, Pointer<IMediaCueEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, ITypedEventHandler<Pointer<ITimedMetadataTrack>, Pointer<IMediaCueEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ITimedMetadataTrack.xml' path='doc/member[@name="ITimedMetadataTrack.remove_CueEntered"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_CueEntered(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, EventRegistrationToken, int>)(lpVtbl[7]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ITimedMetadataTrack.xml' path='doc/member[@name="ITimedMetadataTrack.add_CueExited"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_CueExited([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CTimedMetadataTrack_Windows__CMedia__CCore__CMediaCueEventArgs_t *")] ITypedEventHandler<Pointer<ITimedMetadataTrack>, Pointer<IMediaCueEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, ITypedEventHandler<Pointer<ITimedMetadataTrack>, Pointer<IMediaCueEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ITimedMetadataTrack.xml' path='doc/member[@name="ITimedMetadataTrack.remove_CueExited"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_CueExited(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, EventRegistrationToken, int>)(lpVtbl[9]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ITimedMetadataTrack.xml' path='doc/member[@name="ITimedMetadataTrack.add_TrackFailed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_TrackFailed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CTimedMetadataTrack_Windows__CMedia__CCore__CTimedMetadataTrackFailedEventArgs_t *")] ITypedEventHandler<Pointer<ITimedMetadataTrack>, Pointer<ITimedMetadataTrackFailedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, ITypedEventHandler<Pointer<ITimedMetadataTrack>, Pointer<ITimedMetadataTrackFailedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ITimedMetadataTrack.xml' path='doc/member[@name="ITimedMetadataTrack.remove_TrackFailed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_TrackFailed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, EventRegistrationToken, int>)(lpVtbl[11]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ITimedMetadataTrack.xml' path='doc/member[@name="ITimedMetadataTrack.get_Cues"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Cues([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CIMediaCue_t **")] IVectorView<Pointer<IMediaCue>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, IVectorView<Pointer<IMediaCue>>**, int>)(lpVtbl[12]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedMetadataTrack.xml' path='doc/member[@name="ITimedMetadataTrack.get_ActiveCues"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ActiveCues([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CIMediaCue_t **")] IVectorView<Pointer<IMediaCue>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, IVectorView<Pointer<IMediaCue>>**, int>)(lpVtbl[13]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedMetadataTrack.xml' path='doc/member[@name="ITimedMetadataTrack.get_TimedMetadataKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_TimedMetadataKind([NativeTypeName("ABI::Windows::Media::Core::TimedMetadataKind *")] TimedMetadataKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, TimedMetadataKind*, int>)(lpVtbl[14]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedMetadataTrack.xml' path='doc/member[@name="ITimedMetadataTrack.get_DispatchType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_DispatchType(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, HSTRING*, int>)(lpVtbl[15]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedMetadataTrack.xml' path='doc/member[@name="ITimedMetadataTrack.AddCue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AddCue([NativeTypeName("ABI::Windows::Media::Core::IMediaCue *")] IMediaCue* cue)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, IMediaCue*, int>)(lpVtbl[16]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this), cue);
    }

    /// <include file='ITimedMetadataTrack.xml' path='doc/member[@name="ITimedMetadataTrack.RemoveCue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT RemoveCue([NativeTypeName("ABI::Windows::Media::Core::IMediaCue *")] IMediaCue* cue)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataTrack*, IMediaCue*, int>)(lpVtbl[17]))((ITimedMetadataTrack*)Unsafe.AsPointer(ref this), cue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_CueEntered([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CTimedMetadataTrack_Windows__CMedia__CCore__CMediaCueEventArgs_t *")] ITypedEventHandler<Pointer<ITimedMetadataTrack>, Pointer<IMediaCueEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_CueEntered(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_CueExited([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CTimedMetadataTrack_Windows__CMedia__CCore__CMediaCueEventArgs_t *")] ITypedEventHandler<Pointer<ITimedMetadataTrack>, Pointer<IMediaCueEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_CueExited(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_TrackFailed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CTimedMetadataTrack_Windows__CMedia__CCore__CTimedMetadataTrackFailedEventArgs_t *")] ITypedEventHandler<Pointer<ITimedMetadataTrack>, Pointer<ITimedMetadataTrackFailedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_TrackFailed(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT get_Cues([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CIMediaCue_t **")] IVectorView<Pointer<IMediaCue>>** value);

        [VtblIndex(13)]
        HRESULT get_ActiveCues([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CIMediaCue_t **")] IVectorView<Pointer<IMediaCue>>** value);

        [VtblIndex(14)]
        HRESULT get_TimedMetadataKind([NativeTypeName("ABI::Windows::Media::Core::TimedMetadataKind *")] TimedMetadataKind* value);

        [VtblIndex(15)]
        HRESULT get_DispatchType(HSTRING* value);

        [VtblIndex(16)]
        HRESULT AddCue([NativeTypeName("ABI::Windows::Media::Core::IMediaCue *")] IMediaCue* cue);

        [VtblIndex(17)]
        HRESULT RemoveCue([NativeTypeName("ABI::Windows::Media::Core::IMediaCue *")] IMediaCue* cue);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CTimedMetadataTrack_Windows__CMedia__CCore__CMediaCueEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ITimedMetadataTrack>, Pointer<IMediaCueEventArgs>>*, EventRegistrationToken*, int> add_CueEntered;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CueEntered;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CTimedMetadataTrack_Windows__CMedia__CCore__CMediaCueEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ITimedMetadataTrack>, Pointer<IMediaCueEventArgs>>*, EventRegistrationToken*, int> add_CueExited;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CueExited;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCore__CTimedMetadataTrack_Windows__CMedia__CCore__CTimedMetadataTrackFailedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ITimedMetadataTrack>, Pointer<ITimedMetadataTrackFailedEventArgs>>*, EventRegistrationToken*, int> add_TrackFailed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_TrackFailed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CIMediaCue_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IMediaCue>>**, int> get_Cues;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCore__CIMediaCue_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IMediaCue>>**, int> get_ActiveCues;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedMetadataKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedMetadataKind*, int> get_TimedMetadataKind;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DispatchType;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaCue *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaCue*, int> AddCue;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaCue *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaCue*, int> RemoveCue;
    }
}
