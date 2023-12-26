// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdataaccounts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataAccount.xml' path='doc/member[@name="IUserDataAccount"]/*' />
[Guid("B9C4367E-B348-4910-BE94-4AD4BBA6DEA7")]
[NativeTypeName("struct IUserDataAccount : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataAccount : IUserDataAccount.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataAccount));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataAccount*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, uint>)(lpVtbl[1]))((IUserDataAccount*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, uint>)(lpVtbl[2]))((IUserDataAccount*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataAccount*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, HSTRING*, int>)(lpVtbl[4]))((IUserDataAccount*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataAccount*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataAccount.xml' path='doc/member[@name="IUserDataAccount.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, HSTRING*, int>)(lpVtbl[6]))((IUserDataAccount*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataAccount.xml' path='doc/member[@name="IUserDataAccount.get_UserDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_UserDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, HSTRING*, int>)(lpVtbl[7]))((IUserDataAccount*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataAccount.xml' path='doc/member[@name="IUserDataAccount.put_UserDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_UserDisplayName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, HSTRING, int>)(lpVtbl[8]))((IUserDataAccount*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataAccount.xml' path='doc/member[@name="IUserDataAccount.get_OtherAppReadAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountOtherAppReadAccess *")] UserDataAccountOtherAppReadAccess* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, UserDataAccountOtherAppReadAccess*, int>)(lpVtbl[9]))((IUserDataAccount*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataAccount.xml' path='doc/member[@name="IUserDataAccount.put_OtherAppReadAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountOtherAppReadAccess")] UserDataAccountOtherAppReadAccess value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, UserDataAccountOtherAppReadAccess, int>)(lpVtbl[10]))((IUserDataAccount*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataAccount.xml' path='doc/member[@name="IUserDataAccount.get_Icon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Icon([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, IRandomAccessStreamReference**, int>)(lpVtbl[11]))((IUserDataAccount*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataAccount.xml' path='doc/member[@name="IUserDataAccount.get_DeviceAccountTypeId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DeviceAccountTypeId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, HSTRING*, int>)(lpVtbl[12]))((IUserDataAccount*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataAccount.xml' path='doc/member[@name="IUserDataAccount.get_PackageFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PackageFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, HSTRING*, int>)(lpVtbl[13]))((IUserDataAccount*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataAccount.xml' path='doc/member[@name="IUserDataAccount.SaveAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SaveAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, IAsyncAction**, int>)(lpVtbl[14]))((IUserDataAccount*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IUserDataAccount.xml' path='doc/member[@name="IUserDataAccount.DeleteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, IAsyncAction**, int>)(lpVtbl[15]))((IUserDataAccount*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IUserDataAccount.xml' path='doc/member[@name="IUserDataAccount.FindAppointmentCalendarsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT FindAppointmentCalendarsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[16]))((IUserDataAccount*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IUserDataAccount.xml' path='doc/member[@name="IUserDataAccount.FindEmailMailboxesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT FindEmailMailboxesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[17]))((IUserDataAccount*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IUserDataAccount.xml' path='doc/member[@name="IUserDataAccount.FindContactListsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT FindContactListsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactList_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[18]))((IUserDataAccount*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IUserDataAccount.xml' path='doc/member[@name="IUserDataAccount.FindContactAnnotationListsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT FindContactAnnotationListsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccount*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[19]))((IUserDataAccount*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_UserDisplayName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_UserDisplayName(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountOtherAppReadAccess *")] UserDataAccountOtherAppReadAccess* value);

        [VtblIndex(10)]
        HRESULT put_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountOtherAppReadAccess")] UserDataAccountOtherAppReadAccess value);

        [VtblIndex(11)]
        HRESULT get_Icon([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(12)]
        HRESULT get_DeviceAccountTypeId(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_PackageFamilyName(HSTRING* value);

        [VtblIndex(14)]
        HRESULT SaveAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(15)]
        HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(16)]
        HRESULT FindAppointmentCalendarsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(17)]
        HRESULT FindEmailMailboxesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(18)]
        HRESULT FindContactListsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactList_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(19)]
        HRESULT FindContactAnnotationListsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **")] IAsyncOperation<IntPtr>** result);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserDisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_UserDisplayName;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountOtherAppReadAccess *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataAccountOtherAppReadAccess*, int> get_OtherAppReadAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountOtherAppReadAccess) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataAccountOtherAppReadAccess, int> put_OtherAppReadAccess;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_Icon;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceAccountTypeId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PackageFamilyName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> SaveAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> DeleteAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppointments__CAppointmentCalendar_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> FindAppointmentCalendarsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> FindEmailMailboxesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactList_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> FindContactListsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> FindContactAnnotationListsAsync;
    }
}
