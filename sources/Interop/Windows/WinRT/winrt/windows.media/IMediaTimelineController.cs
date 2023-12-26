// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaTimelineController.xml' path='doc/member[@name="IMediaTimelineController"]/*' />
[Guid("8ED361F3-0B78-4360-BF71-0C841999EA1B")]
[NativeTypeName("struct IMediaTimelineController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaTimelineController : IMediaTimelineController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaTimelineController));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, Guid*, void**, int>)(lpVtbl[0]))((IMediaTimelineController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, uint>)(lpVtbl[1]))((IMediaTimelineController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, uint>)(lpVtbl[2]))((IMediaTimelineController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaTimelineController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, HSTRING*, int>)(lpVtbl[4]))((IMediaTimelineController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, TrustLevel*, int>)(lpVtbl[5]))((IMediaTimelineController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaTimelineController.xml' path='doc/member[@name="IMediaTimelineController.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, int>)(lpVtbl[6]))((IMediaTimelineController*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaTimelineController.xml' path='doc/member[@name="IMediaTimelineController.Resume"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, int>)(lpVtbl[7]))((IMediaTimelineController*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaTimelineController.xml' path='doc/member[@name="IMediaTimelineController.Pause"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, int>)(lpVtbl[8]))((IMediaTimelineController*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaTimelineController.xml' path='doc/member[@name="IMediaTimelineController.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, TimeSpan*, int>)(lpVtbl[9]))((IMediaTimelineController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTimelineController.xml' path='doc/member[@name="IMediaTimelineController.put_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, TimeSpan, int>)(lpVtbl[10]))((IMediaTimelineController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTimelineController.xml' path='doc/member[@name="IMediaTimelineController.get_ClockRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ClockRate(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, double*, int>)(lpVtbl[11]))((IMediaTimelineController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTimelineController.xml' path='doc/member[@name="IMediaTimelineController.put_ClockRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_ClockRate(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, double, int>)(lpVtbl[12]))((IMediaTimelineController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTimelineController.xml' path='doc/member[@name="IMediaTimelineController.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::Media::MediaTimelineControllerState *")] MediaTimelineControllerState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, MediaTimelineControllerState*, int>)(lpVtbl[13]))((IMediaTimelineController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTimelineController.xml' path='doc/member[@name="IMediaTimelineController.add_PositionChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_PositionChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CMediaTimelineController_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* positionChangedEventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IMediaTimelineController*)Unsafe.AsPointer(ref this), positionChangedEventHandler, eventCookie);
    }

    /// <include file='IMediaTimelineController.xml' path='doc/member[@name="IMediaTimelineController.remove_PositionChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_PositionChanged(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, EventRegistrationToken, int>)(lpVtbl[15]))((IMediaTimelineController*)Unsafe.AsPointer(ref this), eventCookie);
    }

    /// <include file='IMediaTimelineController.xml' path='doc/member[@name="IMediaTimelineController.add_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CMediaTimelineController_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* stateChangedEventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[16]))((IMediaTimelineController*)Unsafe.AsPointer(ref this), stateChangedEventHandler, eventCookie);
    }

    /// <include file='IMediaTimelineController.xml' path='doc/member[@name="IMediaTimelineController.remove_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_StateChanged(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTimelineController*, EventRegistrationToken, int>)(lpVtbl[17]))((IMediaTimelineController*)Unsafe.AsPointer(ref this), eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Start();

        [VtblIndex(7)]
        HRESULT Resume();

        [VtblIndex(8)]
        HRESULT Pause();

        [VtblIndex(9)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(10)]
        HRESULT put_Position([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(11)]
        HRESULT get_ClockRate(double* value);

        [VtblIndex(12)]
        HRESULT put_ClockRate(double value);

        [VtblIndex(13)]
        HRESULT get_State([NativeTypeName("ABI::Windows::Media::MediaTimelineControllerState *")] MediaTimelineControllerState* value);

        [VtblIndex(14)]
        HRESULT add_PositionChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CMediaTimelineController_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* positionChangedEventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(15)]
        HRESULT remove_PositionChanged(EventRegistrationToken eventCookie);

        [VtblIndex(16)]
        HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CMediaTimelineController_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* stateChangedEventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(17)]
        HRESULT remove_StateChanged(EventRegistrationToken eventCookie);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Resume;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Pause;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_Position;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_ClockRate;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_ClockRate;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaTimelineControllerState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaTimelineControllerState*, int> get_State;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CMediaTimelineController_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_PositionChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PositionChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CMediaTimelineController_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_StateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StateChanged;
    }
}
