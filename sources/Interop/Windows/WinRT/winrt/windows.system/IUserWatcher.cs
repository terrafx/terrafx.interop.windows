// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher"]/*' />
[Guid("155EB23B-242A-45E0-A2E9-3171FC6A7FBB")]
[NativeTypeName("struct IUserWatcher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserWatcher : IUserWatcher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IUserWatcher);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, Guid*, void**, int>)(lpVtbl[0]))((IUserWatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, uint>)(lpVtbl[1]))((IUserWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, uint>)(lpVtbl[2]))((IUserWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, uint*, Guid**, int>)(lpVtbl[3]))((IUserWatcher*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, HSTRING*, int>)(lpVtbl[4]))((IUserWatcher*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, TrustLevel*, int>)(lpVtbl[5]))((IUserWatcher*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::System::UserWatcherStatus *")] UserWatcherStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, UserWatcherStatus*, int>)(lpVtbl[6]))((IUserWatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, int>)(lpVtbl[7]))((IUserWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, int>)(lpVtbl[8]))((IUserWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.add_Added"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_Added([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserChangedEventArgs_t *")] ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IUserWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.remove_Added"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_Added(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, EventRegistrationToken, int>)(lpVtbl[10]))((IUserWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.add_Removed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserChangedEventArgs_t *")] ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IUserWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.remove_Removed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_Removed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, EventRegistrationToken, int>)(lpVtbl[12]))((IUserWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.add_Updated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_Updated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserChangedEventArgs_t *")] ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IUserWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.remove_Updated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_Updated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, EventRegistrationToken, int>)(lpVtbl[14]))((IUserWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.add_AuthenticationStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_AuthenticationStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserChangedEventArgs_t *")] ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[15]))((IUserWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.remove_AuthenticationStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_AuthenticationStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, EventRegistrationToken, int>)(lpVtbl[16]))((IUserWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.add_AuthenticationStatusChanging"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_AuthenticationStatusChanging([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserAuthenticationStatusChangingEventArgs_t *")] ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserAuthenticationStatusChangingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserAuthenticationStatusChangingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[17]))((IUserWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.remove_AuthenticationStatusChanging"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_AuthenticationStatusChanging(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, EventRegistrationToken, int>)(lpVtbl[18]))((IUserWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.add_EnumerationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[19]))((IUserWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.remove_EnumerationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT remove_EnumerationCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, EventRegistrationToken, int>)(lpVtbl[20]))((IUserWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.add_Stopped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT add_Stopped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[21]))((IUserWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IUserWatcher.xml' path='doc/member[@name="IUserWatcher.remove_Stopped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT remove_Stopped(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserWatcher*, EventRegistrationToken, int>)(lpVtbl[22]))((IUserWatcher*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::System::UserWatcherStatus *")] UserWatcherStatus* value);

        [VtblIndex(7)]
        HRESULT Start();

        [VtblIndex(8)]
        HRESULT Stop();

        [VtblIndex(9)]
        HRESULT add_Added([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserChangedEventArgs_t *")] ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_Added(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserChangedEventArgs_t *")] ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_Removed(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT add_Updated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserChangedEventArgs_t *")] ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_Updated(EventRegistrationToken token);

        [VtblIndex(15)]
        HRESULT add_AuthenticationStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserChangedEventArgs_t *")] ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(16)]
        HRESULT remove_AuthenticationStatusChanged(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT add_AuthenticationStatusChanging([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserAuthenticationStatusChangingEventArgs_t *")] ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserAuthenticationStatusChangingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(18)]
        HRESULT remove_AuthenticationStatusChanging(EventRegistrationToken token);

        [VtblIndex(19)]
        HRESULT add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(20)]
        HRESULT remove_EnumerationCompleted(EventRegistrationToken token);

        [VtblIndex(21)]
        HRESULT add_Stopped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(22)]
        HRESULT remove_Stopped(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::UserWatcherStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserWatcherStatus*, int> get_Status;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserChangedEventArgs>>*, EventRegistrationToken*, int> add_Added;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Added;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserChangedEventArgs>>*, EventRegistrationToken*, int> add_Removed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Removed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserChangedEventArgs>>*, EventRegistrationToken*, int> add_Updated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Updated;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserChangedEventArgs>>*, EventRegistrationToken*, int> add_AuthenticationStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AuthenticationStatusChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_Windows__CSystem__CUserAuthenticationStatusChangingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IUserAuthenticationStatusChangingEventArgs>>*, EventRegistrationToken*, int> add_AuthenticationStatusChanging;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AuthenticationStatusChanging;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_EnumerationCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_EnumerationCompleted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CUserWatcher_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IUserWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Stopped;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Stopped;
    }
}
