// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMailboxSyncManager.xml' path='doc/member[@name="IEmailMailboxSyncManager"]/*' />
[Guid("517AC55A-3591-4B5D-85BC-C71DDE862263")]
[NativeTypeName("struct IEmailMailboxSyncManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailboxSyncManager : IEmailMailboxSyncManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailMailboxSyncManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMailboxSyncManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager*, uint>)(lpVtbl[1]))((IEmailMailboxSyncManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager*, uint>)(lpVtbl[2]))((IEmailMailboxSyncManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMailboxSyncManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager*, HSTRING*, int>)(lpVtbl[4]))((IEmailMailboxSyncManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMailboxSyncManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMailboxSyncManager.xml' path='doc/member[@name="IEmailMailboxSyncManager.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxSyncStatus *")] EmailMailboxSyncStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager*, EmailMailboxSyncStatus*, int>)(lpVtbl[6]))((IEmailMailboxSyncManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxSyncManager.xml' path='doc/member[@name="IEmailMailboxSyncManager.get_LastSuccessfulSyncTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_LastSuccessfulSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager*, WinRTDateTime*, int>)(lpVtbl[7]))((IEmailMailboxSyncManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxSyncManager.xml' path='doc/member[@name="IEmailMailboxSyncManager.get_LastAttemptedSyncTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LastAttemptedSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager*, WinRTDateTime*, int>)(lpVtbl[8]))((IEmailMailboxSyncManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxSyncManager.xml' path='doc/member[@name="IEmailMailboxSyncManager.SyncAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SyncAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager*, IAsyncOperation<bool>**, int>)(lpVtbl[9]))((IEmailMailboxSyncManager*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IEmailMailboxSyncManager.xml' path='doc/member[@name="IEmailMailboxSyncManager.add_SyncStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_SyncStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CEmail__CEmailMailboxSyncManager_IInspectable_t *")] ITypedEventHandler<Pointer<IEmailMailboxSyncManager>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager*, ITypedEventHandler<Pointer<IEmailMailboxSyncManager>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IEmailMailboxSyncManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IEmailMailboxSyncManager.xml' path='doc/member[@name="IEmailMailboxSyncManager.remove_SyncStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_SyncStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager*, EventRegistrationToken, int>)(lpVtbl[11]))((IEmailMailboxSyncManager*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxSyncStatus *")] EmailMailboxSyncStatus* value);

        [VtblIndex(7)]
        HRESULT get_LastSuccessfulSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(8)]
        HRESULT get_LastAttemptedSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(9)]
        HRESULT SyncAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(10)]
        HRESULT add_SyncStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CEmail__CEmailMailboxSyncManager_IInspectable_t *")] ITypedEventHandler<Pointer<IEmailMailboxSyncManager>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxSyncStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMailboxSyncStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_LastSuccessfulSyncTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_LastAttemptedSyncTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<bool>**, int> SyncAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CEmail__CEmailMailboxSyncManager_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IEmailMailboxSyncManager>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_SyncStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SyncStatusChanged;
    }
}
