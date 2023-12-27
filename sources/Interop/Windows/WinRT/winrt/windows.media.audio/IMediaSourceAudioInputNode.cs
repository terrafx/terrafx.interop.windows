// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaSourceAudioInputNode.xml' path='doc/member[@name="IMediaSourceAudioInputNode"]/*' />
[Guid("99D8983B-A88A-4041-8E4F-DDBAC0C91FD3")]
[NativeTypeName("struct IMediaSourceAudioInputNode : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaSourceAudioInputNode : IMediaSourceAudioInputNode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaSourceAudioInputNode));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, Guid*, void**, int>)(lpVtbl[0]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, uint>)(lpVtbl[1]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, uint>)(lpVtbl[2]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, HSTRING*, int>)(lpVtbl[4]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, TrustLevel*, int>)(lpVtbl[5]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaSourceAudioInputNode.xml' path='doc/member[@name="IMediaSourceAudioInputNode.put_PlaybackSpeedFactor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_PlaybackSpeedFactor(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, double, int>)(lpVtbl[6]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSourceAudioInputNode.xml' path='doc/member[@name="IMediaSourceAudioInputNode.get_PlaybackSpeedFactor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PlaybackSpeedFactor(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, double*, int>)(lpVtbl[7]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSourceAudioInputNode.xml' path='doc/member[@name="IMediaSourceAudioInputNode.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, TimeSpan*, int>)(lpVtbl[8]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSourceAudioInputNode.xml' path='doc/member[@name="IMediaSourceAudioInputNode.Seek"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Seek([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan position)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, TimeSpan, int>)(lpVtbl[9]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), position);
    }

    /// <include file='IMediaSourceAudioInputNode.xml' path='doc/member[@name="IMediaSourceAudioInputNode.get_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, IReference<TimeSpan>**, int>)(lpVtbl[10]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSourceAudioInputNode.xml' path='doc/member[@name="IMediaSourceAudioInputNode.put_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_StartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, IReference<TimeSpan>*, int>)(lpVtbl[11]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSourceAudioInputNode.xml' path='doc/member[@name="IMediaSourceAudioInputNode.get_EndTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_EndTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, IReference<TimeSpan>**, int>)(lpVtbl[12]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSourceAudioInputNode.xml' path='doc/member[@name="IMediaSourceAudioInputNode.put_EndTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_EndTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, IReference<TimeSpan>*, int>)(lpVtbl[13]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSourceAudioInputNode.xml' path='doc/member[@name="IMediaSourceAudioInputNode.get_LoopCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_LoopCount([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, IReference<int>**, int>)(lpVtbl[14]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSourceAudioInputNode.xml' path='doc/member[@name="IMediaSourceAudioInputNode.put_LoopCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_LoopCount([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, IReference<int>*, int>)(lpVtbl[15]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSourceAudioInputNode.xml' path='doc/member[@name="IMediaSourceAudioInputNode.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, TimeSpan*, int>)(lpVtbl[16]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSourceAudioInputNode.xml' path='doc/member[@name="IMediaSourceAudioInputNode.get_MediaSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_MediaSource([NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, IMediaSource2**, int>)(lpVtbl[17]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaSourceAudioInputNode.xml' path='doc/member[@name="IMediaSourceAudioInputNode.add_MediaSourceCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT add_MediaSourceCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CMediaSourceAudioInputNode_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaSourceAudioInputNode>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, ITypedEventHandler<Pointer<IMediaSourceAudioInputNode>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[18]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IMediaSourceAudioInputNode.xml' path='doc/member[@name="IMediaSourceAudioInputNode.remove_MediaSourceCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT remove_MediaSourceCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceAudioInputNode*, EventRegistrationToken, int>)(lpVtbl[19]))((IMediaSourceAudioInputNode*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_PlaybackSpeedFactor(double value);

        [VtblIndex(7)]
        HRESULT get_PlaybackSpeedFactor(double* value);

        [VtblIndex(8)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(9)]
        HRESULT Seek([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan position);

        [VtblIndex(10)]
        HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(11)]
        HRESULT put_StartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value);

        [VtblIndex(12)]
        HRESULT get_EndTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(13)]
        HRESULT put_EndTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value);

        [VtblIndex(14)]
        HRESULT get_LoopCount([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(15)]
        HRESULT put_LoopCount([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(16)]
        HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(17)]
        HRESULT get_MediaSource([NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** value);

        [VtblIndex(18)]
        HRESULT add_MediaSourceCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CMediaSourceAudioInputNode_IInspectable_t *")] ITypedEventHandler<Pointer<IMediaSourceAudioInputNode>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(19)]
        HRESULT remove_MediaSourceCompleted(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_PlaybackSpeedFactor;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_PlaybackSpeedFactor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> Seek;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>*, int> put_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_EndTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>*, int> put_EndTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_LoopCount;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_LoopCount;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Duration;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaSource2**, int> get_MediaSource;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CMediaSourceAudioInputNode_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMediaSourceAudioInputNode>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_MediaSourceCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MediaSourceCompleted;
    }
}
