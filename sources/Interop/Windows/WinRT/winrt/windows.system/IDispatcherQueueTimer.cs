// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDispatcherQueueTimer.xml' path='doc/member[@name="IDispatcherQueueTimer"]/*' />
[Guid("5FEABB1D-A31C-4727-B1AC-37454649D56A")]
[NativeTypeName("struct IDispatcherQueueTimer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDispatcherQueueTimer : IDispatcherQueueTimer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDispatcherQueueTimer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueueTimer*, Guid*, void**, int>)(lpVtbl[0]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueueTimer*, uint>)(lpVtbl[1]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueueTimer*, uint>)(lpVtbl[2]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueueTimer*, uint*, Guid**, int>)(lpVtbl[3]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueueTimer*, HSTRING*, int>)(lpVtbl[4]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueueTimer*, TrustLevel*, int>)(lpVtbl[5]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDispatcherQueueTimer.xml' path='doc/member[@name="IDispatcherQueueTimer.get_Interval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Interval([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueueTimer*, TimeSpan*, int>)(lpVtbl[6]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDispatcherQueueTimer.xml' path='doc/member[@name="IDispatcherQueueTimer.put_Interval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Interval([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueueTimer*, TimeSpan, int>)(lpVtbl[7]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDispatcherQueueTimer.xml' path='doc/member[@name="IDispatcherQueueTimer.get_IsRunning"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsRunning([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueueTimer*, byte*, int>)(lpVtbl[8]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDispatcherQueueTimer.xml' path='doc/member[@name="IDispatcherQueueTimer.get_IsRepeating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsRepeating([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueueTimer*, byte*, int>)(lpVtbl[9]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDispatcherQueueTimer.xml' path='doc/member[@name="IDispatcherQueueTimer.put_IsRepeating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_IsRepeating([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueueTimer*, byte, int>)(lpVtbl[10]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDispatcherQueueTimer.xml' path='doc/member[@name="IDispatcherQueueTimer.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueueTimer*, int>)(lpVtbl[11]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDispatcherQueueTimer.xml' path='doc/member[@name="IDispatcherQueueTimer.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueueTimer*, int>)(lpVtbl[12]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDispatcherQueueTimer.xml' path='doc/member[@name="IDispatcherQueueTimer.add_Tick"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_Tick([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CDispatcherQueueTimer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueueTimer*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDispatcherQueueTimer.xml' path='doc/member[@name="IDispatcherQueueTimer.remove_Tick"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_Tick(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueueTimer*, EventRegistrationToken, int>)(lpVtbl[14]))((IDispatcherQueueTimer*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Interval([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(7)]
        HRESULT put_Interval([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(8)]
        HRESULT get_IsRunning([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_IsRepeating([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT put_IsRepeating([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT Start();

        [VtblIndex(12)]
        HRESULT Stop();

        [VtblIndex(13)]
        HRESULT add_Tick([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CDispatcherQueueTimer_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_Tick(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Interval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_Interval;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsRunning;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsRepeating;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsRepeating;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CDispatcherQueueTimer_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_Tick;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Tick;
    }
}
