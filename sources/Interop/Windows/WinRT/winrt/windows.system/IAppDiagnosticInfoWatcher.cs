// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppDiagnosticInfoWatcher.xml' path='doc/member[@name="IAppDiagnosticInfoWatcher"]/*' />
[Guid("75575070-01D3-489A-9325-52F9CC6EDE0A")]
[NativeTypeName("struct IAppDiagnosticInfoWatcher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppDiagnosticInfoWatcher : IAppDiagnosticInfoWatcher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppDiagnosticInfoWatcher));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, Guid*, void**, int>)(lpVtbl[0]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, uint>)(lpVtbl[1]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, uint>)(lpVtbl[2]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, uint*, Guid**, int>)(lpVtbl[3]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, HSTRING*, int>)(lpVtbl[4]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, TrustLevel*, int>)(lpVtbl[5]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppDiagnosticInfoWatcher.xml' path='doc/member[@name="IAppDiagnosticInfoWatcher.add_Added"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_Added([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppDiagnosticInfoWatcher_Windows__CSystem__CAppDiagnosticInfoWatcherEventArgs_t *")] ITypedEventHandler<Pointer<IAppDiagnosticInfoWatcher>, Pointer<IAppDiagnosticInfoWatcherEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, ITypedEventHandler<Pointer<IAppDiagnosticInfoWatcher>, Pointer<IAppDiagnosticInfoWatcherEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppDiagnosticInfoWatcher.xml' path='doc/member[@name="IAppDiagnosticInfoWatcher.remove_Added"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_Added(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[7]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppDiagnosticInfoWatcher.xml' path='doc/member[@name="IAppDiagnosticInfoWatcher.add_Removed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppDiagnosticInfoWatcher_Windows__CSystem__CAppDiagnosticInfoWatcherEventArgs_t *")] ITypedEventHandler<Pointer<IAppDiagnosticInfoWatcher>, Pointer<IAppDiagnosticInfoWatcherEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, ITypedEventHandler<Pointer<IAppDiagnosticInfoWatcher>, Pointer<IAppDiagnosticInfoWatcherEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppDiagnosticInfoWatcher.xml' path='doc/member[@name="IAppDiagnosticInfoWatcher.remove_Removed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_Removed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[9]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppDiagnosticInfoWatcher.xml' path='doc/member[@name="IAppDiagnosticInfoWatcher.add_EnumerationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppDiagnosticInfoWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<IAppDiagnosticInfoWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, ITypedEventHandler<Pointer<IAppDiagnosticInfoWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppDiagnosticInfoWatcher.xml' path='doc/member[@name="IAppDiagnosticInfoWatcher.remove_EnumerationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_EnumerationCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[11]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppDiagnosticInfoWatcher.xml' path='doc/member[@name="IAppDiagnosticInfoWatcher.add_Stopped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_Stopped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppDiagnosticInfoWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<IAppDiagnosticInfoWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, ITypedEventHandler<Pointer<IAppDiagnosticInfoWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppDiagnosticInfoWatcher.xml' path='doc/member[@name="IAppDiagnosticInfoWatcher.remove_Stopped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_Stopped(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, EventRegistrationToken, int>)(lpVtbl[13]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppDiagnosticInfoWatcher.xml' path='doc/member[@name="IAppDiagnosticInfoWatcher.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::System::AppDiagnosticInfoWatcherStatus *")] AppDiagnosticInfoWatcherStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, AppDiagnosticInfoWatcherStatus*, int>)(lpVtbl[14]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppDiagnosticInfoWatcher.xml' path='doc/member[@name="IAppDiagnosticInfoWatcher.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, int>)(lpVtbl[15]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppDiagnosticInfoWatcher.xml' path='doc/member[@name="IAppDiagnosticInfoWatcher.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppDiagnosticInfoWatcher*, int>)(lpVtbl[16]))((IAppDiagnosticInfoWatcher*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_Added([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppDiagnosticInfoWatcher_Windows__CSystem__CAppDiagnosticInfoWatcherEventArgs_t *")] ITypedEventHandler<Pointer<IAppDiagnosticInfoWatcher>, Pointer<IAppDiagnosticInfoWatcherEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_Added(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppDiagnosticInfoWatcher_Windows__CSystem__CAppDiagnosticInfoWatcherEventArgs_t *")] ITypedEventHandler<Pointer<IAppDiagnosticInfoWatcher>, Pointer<IAppDiagnosticInfoWatcherEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_Removed(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppDiagnosticInfoWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<IAppDiagnosticInfoWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_EnumerationCompleted(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_Stopped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppDiagnosticInfoWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<IAppDiagnosticInfoWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_Stopped(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::System::AppDiagnosticInfoWatcherStatus *")] AppDiagnosticInfoWatcherStatus* value);

        [VtblIndex(15)]
        HRESULT Start();

        [VtblIndex(16)]
        HRESULT Stop();
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppDiagnosticInfoWatcher_Windows__CSystem__CAppDiagnosticInfoWatcherEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppDiagnosticInfoWatcher>, Pointer<IAppDiagnosticInfoWatcherEventArgs>>*, EventRegistrationToken*, int> add_Added;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Added;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppDiagnosticInfoWatcher_Windows__CSystem__CAppDiagnosticInfoWatcherEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppDiagnosticInfoWatcher>, Pointer<IAppDiagnosticInfoWatcherEventArgs>>*, EventRegistrationToken*, int> add_Removed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Removed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppDiagnosticInfoWatcher_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppDiagnosticInfoWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_EnumerationCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_EnumerationCompleted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CAppDiagnosticInfoWatcher_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppDiagnosticInfoWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Stopped;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Stopped;

        [NativeTypeName("HRESULT (ABI::Windows::System::AppDiagnosticInfoWatcherStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppDiagnosticInfoWatcherStatus*, int> get_Status;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;
    }
}
