// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneLineWatcher.xml' path='doc/member[@name="IPhoneLineWatcher"]/*' />
[Guid("8A45CD0A-6323-44E0-A6F6-9F21F64DC90A")]
[NativeTypeName("struct IPhoneLineWatcher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneLineWatcher : IPhoneLineWatcher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPhoneLineWatcher);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, uint>)(lpVtbl[1]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, uint>)(lpVtbl[2]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, HSTRING*, int>)(lpVtbl[4]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneLineWatcher.xml' path='doc/member[@name="IPhoneLineWatcher.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, int>)(lpVtbl[6]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPhoneLineWatcher.xml' path='doc/member[@name="IPhoneLineWatcher.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, int>)(lpVtbl[7]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPhoneLineWatcher.xml' path='doc/member[@name="IPhoneLineWatcher.add_LineAdded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_LineAdded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineWatcher_Windows__CApplicationModel__CCalls__CPhoneLineWatcherEventArgs_t *")] ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IPhoneLineWatcherEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IPhoneLineWatcherEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhoneLineWatcher.xml' path='doc/member[@name="IPhoneLineWatcher.remove_LineAdded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_LineAdded(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, EventRegistrationToken, int>)(lpVtbl[9]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPhoneLineWatcher.xml' path='doc/member[@name="IPhoneLineWatcher.add_LineRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_LineRemoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineWatcher_Windows__CApplicationModel__CCalls__CPhoneLineWatcherEventArgs_t *")] ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IPhoneLineWatcherEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IPhoneLineWatcherEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhoneLineWatcher.xml' path='doc/member[@name="IPhoneLineWatcher.remove_LineRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_LineRemoved(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, EventRegistrationToken, int>)(lpVtbl[11]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPhoneLineWatcher.xml' path='doc/member[@name="IPhoneLineWatcher.add_LineUpdated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_LineUpdated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineWatcher_Windows__CApplicationModel__CCalls__CPhoneLineWatcherEventArgs_t *")] ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IPhoneLineWatcherEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IPhoneLineWatcherEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhoneLineWatcher.xml' path='doc/member[@name="IPhoneLineWatcher.remove_LineUpdated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_LineUpdated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, EventRegistrationToken, int>)(lpVtbl[13]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPhoneLineWatcher.xml' path='doc/member[@name="IPhoneLineWatcher.add_EnumerationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhoneLineWatcher.xml' path='doc/member[@name="IPhoneLineWatcher.remove_EnumerationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_EnumerationCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, EventRegistrationToken, int>)(lpVtbl[15]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPhoneLineWatcher.xml' path='doc/member[@name="IPhoneLineWatcher.add_Stopped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_Stopped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[16]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhoneLineWatcher.xml' path='doc/member[@name="IPhoneLineWatcher.remove_Stopped"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_Stopped(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, EventRegistrationToken, int>)(lpVtbl[17]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPhoneLineWatcher.xml' path='doc/member[@name="IPhoneLineWatcher.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineWatcherStatus *")] PhoneLineWatcherStatus* status)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineWatcher*, PhoneLineWatcherStatus*, int>)(lpVtbl[18]))((IPhoneLineWatcher*)Unsafe.AsPointer(ref this), status);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Start();

        [VtblIndex(7)]
        HRESULT Stop();

        [VtblIndex(8)]
        HRESULT add_LineAdded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineWatcher_Windows__CApplicationModel__CCalls__CPhoneLineWatcherEventArgs_t *")] ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IPhoneLineWatcherEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_LineAdded(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_LineRemoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineWatcher_Windows__CApplicationModel__CCalls__CPhoneLineWatcherEventArgs_t *")] ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IPhoneLineWatcherEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_LineRemoved(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_LineUpdated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineWatcher_Windows__CApplicationModel__CCalls__CPhoneLineWatcherEventArgs_t *")] ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IPhoneLineWatcherEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_LineUpdated(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_EnumerationCompleted(EventRegistrationToken token);

        [VtblIndex(16)]
        HRESULT add_Stopped([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(17)]
        HRESULT remove_Stopped(EventRegistrationToken token);

        [VtblIndex(18)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineWatcherStatus *")] PhoneLineWatcherStatus* status);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineWatcher_Windows__CApplicationModel__CCalls__CPhoneLineWatcherEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IPhoneLineWatcherEventArgs>>*, EventRegistrationToken*, int> add_LineAdded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_LineAdded;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineWatcher_Windows__CApplicationModel__CCalls__CPhoneLineWatcherEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IPhoneLineWatcherEventArgs>>*, EventRegistrationToken*, int> add_LineRemoved;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_LineRemoved;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineWatcher_Windows__CApplicationModel__CCalls__CPhoneLineWatcherEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IPhoneLineWatcherEventArgs>>*, EventRegistrationToken*, int> add_LineUpdated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_LineUpdated;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineWatcher_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_EnumerationCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_EnumerationCompleted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLineWatcher_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPhoneLineWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Stopped;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Stopped;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneLineWatcherStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneLineWatcherStatus*, int> get_Status;
    }
}
