// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactList.xml' path='doc/member[@name="IContactList"]/*' />
[Guid("16DDEC75-392C-4845-9DFB-51A3E7EF3E42")]
[NativeTypeName("struct IContactList : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactList : IContactList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactList));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, Guid*, void**, int>)(lpVtbl[0]))((IContactList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, uint>)(lpVtbl[1]))((IContactList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, uint>)(lpVtbl[2]))((IContactList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, uint*, Guid**, int>)(lpVtbl[3]))((IContactList*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, HSTRING*, int>)(lpVtbl[4]))((IContactList*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, TrustLevel*, int>)(lpVtbl[5]))((IContactList*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, HSTRING*, int>)(lpVtbl[6]))((IContactList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, HSTRING*, int>)(lpVtbl[7]))((IContactList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.put_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, HSTRING, int>)(lpVtbl[8]))((IContactList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.get_SourceDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SourceDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, HSTRING*, int>)(lpVtbl[9]))((IContactList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.get_IsHidden"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsHidden([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, byte*, int>)(lpVtbl[10]))((IContactList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.put_IsHidden"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_IsHidden([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, byte, int>)(lpVtbl[11]))((IContactList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.get_OtherAppReadAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppReadAccess *")] ContactListOtherAppReadAccess* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, ContactListOtherAppReadAccess*, int>)(lpVtbl[12]))((IContactList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.put_OtherAppReadAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppReadAccess")] ContactListOtherAppReadAccess value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, ContactListOtherAppReadAccess, int>)(lpVtbl[13]))((IContactList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.get_OtherAppWriteAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_OtherAppWriteAccess([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppWriteAccess *")] ContactListOtherAppWriteAccess* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, ContactListOtherAppWriteAccess*, int>)(lpVtbl[14]))((IContactList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.put_OtherAppWriteAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_OtherAppWriteAccess([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppWriteAccess")] ContactListOtherAppWriteAccess value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, ContactListOtherAppWriteAccess, int>)(lpVtbl[15]))((IContactList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.get_ChangeTracker"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ChangeTracker([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactChangeTracker **")] IContactChangeTracker** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, IContactChangeTracker**, int>)(lpVtbl[16]))((IContactList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.get_SyncManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SyncManager([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactListSyncManager **")] IContactListSyncManager** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, IContactListSyncManager**, int>)(lpVtbl[17]))((IContactList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.get_SupportsServerSearch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_SupportsServerSearch([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, byte*, int>)(lpVtbl[18]))((IContactList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.get_UserDataAccountId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_UserDataAccountId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, HSTRING*, int>)(lpVtbl[19]))((IContactList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.add_ContactChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT add_ContactChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactList_Windows__CApplicationModel__CContacts__CContactChangedEventArgs_t *")] ITypedEventHandler<Pointer<IContactList>, Pointer<IContactChangedEventArgs>>* value, EventRegistrationToken* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, ITypedEventHandler<Pointer<IContactList>, Pointer<IContactChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[20]))((IContactList*)Unsafe.AsPointer(ref this), value, returnValue);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.remove_ContactChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT remove_ContactChanged(EventRegistrationToken value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, EventRegistrationToken, int>)(lpVtbl[21]))((IContactList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.SaveAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SaveAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, IAsyncAction**, int>)(lpVtbl[22]))((IContactList*)Unsafe.AsPointer(ref this), returnValue);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.DeleteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, IAsyncAction**, int>)(lpVtbl[23]))((IContactList*)Unsafe.AsPointer(ref this), returnValue);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.GetContactFromRemoteIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetContactFromRemoteIdAsync(HSTRING remoteId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **")] IAsyncOperation<Pointer<IContact>>** contact)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, HSTRING, IAsyncOperation<Pointer<IContact>>**, int>)(lpVtbl[24]))((IContactList*)Unsafe.AsPointer(ref this), remoteId, contact);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.GetMeContactAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetMeContactAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **")] IAsyncOperation<Pointer<IContact>>** meContact)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, IAsyncOperation<Pointer<IContact>>**, int>)(lpVtbl[25]))((IContactList*)Unsafe.AsPointer(ref this), meContact);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.GetContactReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetContactReader([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactReader **")] IContactReader** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, IContactReader**, int>)(lpVtbl[26]))((IContactList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.GetContactReaderWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetContactReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactQueryOptions *")] IContactQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactReader **")] IContactReader** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, IContactQueryOptions*, IContactReader**, int>)(lpVtbl[27]))((IContactList*)Unsafe.AsPointer(ref this), options, value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.SaveContactAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SaveContactAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, IContact*, IAsyncAction**, int>)(lpVtbl[28]))((IContactList*)Unsafe.AsPointer(ref this), contact, value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.DeleteContactAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT DeleteContactAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, IContact*, IAsyncAction**, int>)(lpVtbl[29]))((IContactList*)Unsafe.AsPointer(ref this), contact, value);
    }

    /// <include file='IContactList.xml' path='doc/member[@name="IContactList.GetContactAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetContactAsync(HSTRING contactId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **")] IAsyncOperation<Pointer<IContact>>** contacts)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactList*, HSTRING, IAsyncOperation<Pointer<IContact>>**, int>)(lpVtbl[30]))((IContactList*)Unsafe.AsPointer(ref this), contactId, contacts);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_SourceDisplayName(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_IsHidden([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_IsHidden([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppReadAccess *")] ContactListOtherAppReadAccess* value);

        [VtblIndex(13)]
        HRESULT put_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppReadAccess")] ContactListOtherAppReadAccess value);

        [VtblIndex(14)]
        HRESULT get_OtherAppWriteAccess([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppWriteAccess *")] ContactListOtherAppWriteAccess* value);

        [VtblIndex(15)]
        HRESULT put_OtherAppWriteAccess([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppWriteAccess")] ContactListOtherAppWriteAccess value);

        [VtblIndex(16)]
        HRESULT get_ChangeTracker([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactChangeTracker **")] IContactChangeTracker** value);

        [VtblIndex(17)]
        HRESULT get_SyncManager([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactListSyncManager **")] IContactListSyncManager** value);

        [VtblIndex(18)]
        HRESULT get_SupportsServerSearch([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT get_UserDataAccountId(HSTRING* value);

        [VtblIndex(20)]
        HRESULT add_ContactChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactList_Windows__CApplicationModel__CContacts__CContactChangedEventArgs_t *")] ITypedEventHandler<Pointer<IContactList>, Pointer<IContactChangedEventArgs>>* value, EventRegistrationToken* returnValue);

        [VtblIndex(21)]
        HRESULT remove_ContactChanged(EventRegistrationToken value);

        [VtblIndex(22)]
        HRESULT SaveAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** returnValue);

        [VtblIndex(23)]
        HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** returnValue);

        [VtblIndex(24)]
        HRESULT GetContactFromRemoteIdAsync(HSTRING remoteId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **")] IAsyncOperation<Pointer<IContact>>** contact);

        [VtblIndex(25)]
        HRESULT GetMeContactAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **")] IAsyncOperation<Pointer<IContact>>** meContact);

        [VtblIndex(26)]
        HRESULT GetContactReader([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactReader **")] IContactReader** value);

        [VtblIndex(27)]
        HRESULT GetContactReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactQueryOptions *")] IContactQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactReader **")] IContactReader** value);

        [VtblIndex(28)]
        HRESULT SaveContactAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(29)]
        HRESULT DeleteContactAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(30)]
        HRESULT GetContactAsync(HSTRING contactId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **")] IAsyncOperation<Pointer<IContact>>** contacts);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SourceDisplayName;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsHidden;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsHidden;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppReadAccess *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactListOtherAppReadAccess*, int> get_OtherAppReadAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppReadAccess) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactListOtherAppReadAccess, int> put_OtherAppReadAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppWriteAccess *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactListOtherAppWriteAccess*, int> get_OtherAppWriteAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactListOtherAppWriteAccess) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactListOtherAppWriteAccess, int> put_OtherAppWriteAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactChangeTracker **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContactChangeTracker**, int> get_ChangeTracker;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactListSyncManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContactListSyncManager**, int> get_SyncManager;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SupportsServerSearch;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserDataAccountId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactList_Windows__CApplicationModel__CContacts__CContactChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IContactList>, Pointer<IContactChangedEventArgs>>*, EventRegistrationToken*, int> add_ContactChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ContactChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> SaveAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> DeleteAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IContact>>**, int> GetContactFromRemoteIdAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IContact>>**, int> GetMeContactAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContactReader**, int> GetContactReader;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactQueryOptions *, ABI::Windows::ApplicationModel::Contacts::IContactReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContactQueryOptions*, IContactReader**, int> GetContactReaderWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, IAsyncAction**, int> SaveContactAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, IAsyncAction**, int> DeleteContactAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IContact>>**, int> GetContactAsync;
    }
}
