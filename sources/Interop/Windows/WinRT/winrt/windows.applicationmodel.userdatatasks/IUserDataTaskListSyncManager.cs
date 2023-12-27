// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataTaskListSyncManager.xml' path='doc/member[@name="IUserDataTaskListSyncManager"]/*' />
[Guid("8E591A95-1DCF-469F-93EC-BA48BB553C6B")]
[NativeTypeName("struct IUserDataTaskListSyncManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataTaskListSyncManager : IUserDataTaskListSyncManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataTaskListSyncManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListSyncManager*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataTaskListSyncManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListSyncManager*, uint>)(lpVtbl[1]))((IUserDataTaskListSyncManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListSyncManager*, uint>)(lpVtbl[2]))((IUserDataTaskListSyncManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListSyncManager*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataTaskListSyncManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListSyncManager*, HSTRING*, int>)(lpVtbl[4]))((IUserDataTaskListSyncManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListSyncManager*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataTaskListSyncManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataTaskListSyncManager.xml' path='doc/member[@name="IUserDataTaskListSyncManager.get_LastAttemptedSyncTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_LastAttemptedSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListSyncManager*, WinRTDateTime*, int>)(lpVtbl[6]))((IUserDataTaskListSyncManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskListSyncManager.xml' path='doc/member[@name="IUserDataTaskListSyncManager.put_LastAttemptedSyncTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_LastAttemptedSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListSyncManager*, WinRTDateTime, int>)(lpVtbl[7]))((IUserDataTaskListSyncManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskListSyncManager.xml' path='doc/member[@name="IUserDataTaskListSyncManager.get_LastSuccessfulSyncTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LastSuccessfulSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListSyncManager*, WinRTDateTime*, int>)(lpVtbl[8]))((IUserDataTaskListSyncManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskListSyncManager.xml' path='doc/member[@name="IUserDataTaskListSyncManager.put_LastSuccessfulSyncTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_LastSuccessfulSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListSyncManager*, WinRTDateTime, int>)(lpVtbl[9]))((IUserDataTaskListSyncManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskListSyncManager.xml' path='doc/member[@name="IUserDataTaskListSyncManager.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListSyncStatus *")] UserDataTaskListSyncStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListSyncManager*, UserDataTaskListSyncStatus*, int>)(lpVtbl[10]))((IUserDataTaskListSyncManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskListSyncManager.xml' path='doc/member[@name="IUserDataTaskListSyncManager.put_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Status([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListSyncStatus")] UserDataTaskListSyncStatus value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListSyncManager*, UserDataTaskListSyncStatus, int>)(lpVtbl[11]))((IUserDataTaskListSyncManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataTaskListSyncManager.xml' path='doc/member[@name="IUserDataTaskListSyncManager.SyncAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SyncAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListSyncManager*, IAsyncOperation<bool>**, int>)(lpVtbl[12]))((IUserDataTaskListSyncManager*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IUserDataTaskListSyncManager.xml' path='doc/member[@name="IUserDataTaskListSyncManager.add_SyncStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_SyncStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskListSyncManager_IInspectable_t *")] ITypedEventHandler<Pointer<IUserDataTaskListSyncManager>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListSyncManager*, ITypedEventHandler<Pointer<IUserDataTaskListSyncManager>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IUserDataTaskListSyncManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IUserDataTaskListSyncManager.xml' path='doc/member[@name="IUserDataTaskListSyncManager.remove_SyncStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_SyncStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataTaskListSyncManager*, EventRegistrationToken, int>)(lpVtbl[14]))((IUserDataTaskListSyncManager*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_LastAttemptedSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(7)]
        HRESULT put_LastAttemptedSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value);

        [VtblIndex(8)]
        HRESULT get_LastSuccessfulSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(9)]
        HRESULT put_LastSuccessfulSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value);

        [VtblIndex(10)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListSyncStatus *")] UserDataTaskListSyncStatus* value);

        [VtblIndex(11)]
        HRESULT put_Status([NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListSyncStatus")] UserDataTaskListSyncStatus value);

        [VtblIndex(12)]
        HRESULT SyncAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(13)]
        HRESULT add_SyncStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskListSyncManager_IInspectable_t *")] ITypedEventHandler<Pointer<IUserDataTaskListSyncManager>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_SyncStatusChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_LastAttemptedSyncTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, int> put_LastAttemptedSyncTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_LastSuccessfulSyncTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, int> put_LastSuccessfulSyncTime;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListSyncStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskListSyncStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskListSyncStatus) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataTaskListSyncStatus, int> put_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<bool>**, int> SyncAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CUserDataTasks__CUserDataTaskListSyncManager_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IUserDataTaskListSyncManager>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_SyncStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SyncStatusChanged;
    }
}
