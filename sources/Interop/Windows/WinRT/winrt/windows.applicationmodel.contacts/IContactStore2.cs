// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactStore2.xml' path='doc/member[@name="IContactStore2"]/*' />
[Guid("18CE1C22-EBD5-4BFB-B690-5F4F27C4F0E8")]
[NativeTypeName("struct IContactStore2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactStore2 : IContactStore2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactStore2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, Guid*, void**, int>)(lpVtbl[0]))((IContactStore2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, uint>)(lpVtbl[1]))((IContactStore2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, uint>)(lpVtbl[2]))((IContactStore2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, uint*, Guid**, int>)(lpVtbl[3]))((IContactStore2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, HSTRING*, int>)(lpVtbl[4]))((IContactStore2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, TrustLevel*, int>)(lpVtbl[5]))((IContactStore2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactStore2.xml' path='doc/member[@name="IContactStore2.get_ChangeTracker"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChangeTracker([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactChangeTracker **")] IContactChangeTracker** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, IContactChangeTracker**, int>)(lpVtbl[6]))((IContactStore2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactStore2.xml' path='doc/member[@name="IContactStore2.add_ContactChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_ContactChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactStore_Windows__CApplicationModel__CContacts__CContactChangedEventArgs_t *")] ITypedEventHandler<Pointer<IContactStore>, Pointer<IContactChangedEventArgs>>* value, EventRegistrationToken* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, ITypedEventHandler<Pointer<IContactStore>, Pointer<IContactChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IContactStore2*)Unsafe.AsPointer(ref this), value, returnValue);
    }

    /// <include file='IContactStore2.xml' path='doc/member[@name="IContactStore2.remove_ContactChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_ContactChanged(EventRegistrationToken value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, EventRegistrationToken, int>)(lpVtbl[8]))((IContactStore2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactStore2.xml' path='doc/member[@name="IContactStore2.get_AggregateContactManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AggregateContactManager([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IAggregateContactManager **")] IAggregateContactManager** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, IAggregateContactManager**, int>)(lpVtbl[9]))((IContactStore2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactStore2.xml' path='doc/member[@name="IContactStore2.FindContactListsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FindContactListsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactList_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContactList>>>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, IAsyncOperation<Pointer<IVectorView<Pointer<IContactList>>>>**, int>)(lpVtbl[10]))((IContactStore2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactStore2.xml' path='doc/member[@name="IContactStore2.GetContactListAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetContactListAsync(HSTRING contactListId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **")] IAsyncOperation<Pointer<IContactList>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, HSTRING, IAsyncOperation<Pointer<IContactList>>**, int>)(lpVtbl[11]))((IContactStore2*)Unsafe.AsPointer(ref this), contactListId, value);
    }

    /// <include file='IContactStore2.xml' path='doc/member[@name="IContactStore2.CreateContactListAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateContactListAsync(HSTRING displayName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **")] IAsyncOperation<Pointer<IContactList>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, HSTRING, IAsyncOperation<Pointer<IContactList>>**, int>)(lpVtbl[12]))((IContactStore2*)Unsafe.AsPointer(ref this), displayName, value);
    }

    /// <include file='IContactStore2.xml' path='doc/member[@name="IContactStore2.GetMeContactAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetMeContactAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **")] IAsyncOperation<Pointer<IContact>>** meContact)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, IAsyncOperation<Pointer<IContact>>**, int>)(lpVtbl[13]))((IContactStore2*)Unsafe.AsPointer(ref this), meContact);
    }

    /// <include file='IContactStore2.xml' path='doc/member[@name="IContactStore2.GetContactReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetContactReader([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactReader **")] IContactReader** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, IContactReader**, int>)(lpVtbl[14]))((IContactStore2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactStore2.xml' path='doc/member[@name="IContactStore2.GetContactReaderWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetContactReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactQueryOptions *")] IContactQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactReader **")] IContactReader** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, IContactQueryOptions*, IContactReader**, int>)(lpVtbl[15]))((IContactStore2*)Unsafe.AsPointer(ref this), options, value);
    }

    /// <include file='IContactStore2.xml' path='doc/member[@name="IContactStore2.CreateContactListInAccountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateContactListInAccountAsync(HSTRING displayName, HSTRING userDataAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **")] IAsyncOperation<Pointer<IContactList>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactStore2*, HSTRING, HSTRING, IAsyncOperation<Pointer<IContactList>>**, int>)(lpVtbl[16]))((IContactStore2*)Unsafe.AsPointer(ref this), displayName, userDataAccountId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ChangeTracker([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactChangeTracker **")] IContactChangeTracker** value);

        [VtblIndex(7)]
        HRESULT add_ContactChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactStore_Windows__CApplicationModel__CContacts__CContactChangedEventArgs_t *")] ITypedEventHandler<Pointer<IContactStore>, Pointer<IContactChangedEventArgs>>* value, EventRegistrationToken* returnValue);

        [VtblIndex(8)]
        HRESULT remove_ContactChanged(EventRegistrationToken value);

        [VtblIndex(9)]
        HRESULT get_AggregateContactManager([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IAggregateContactManager **")] IAggregateContactManager** value);

        [VtblIndex(10)]
        HRESULT FindContactListsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactList_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContactList>>>>** value);

        [VtblIndex(11)]
        HRESULT GetContactListAsync(HSTRING contactListId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **")] IAsyncOperation<Pointer<IContactList>>** value);

        [VtblIndex(12)]
        HRESULT CreateContactListAsync(HSTRING displayName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **")] IAsyncOperation<Pointer<IContactList>>** value);

        [VtblIndex(13)]
        HRESULT GetMeContactAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **")] IAsyncOperation<Pointer<IContact>>** meContact);

        [VtblIndex(14)]
        HRESULT GetContactReader([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactReader **")] IContactReader** value);

        [VtblIndex(15)]
        HRESULT GetContactReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactQueryOptions *")] IContactQueryOptions* options, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactReader **")] IContactReader** value);

        [VtblIndex(16)]
        HRESULT CreateContactListInAccountAsync(HSTRING displayName, HSTRING userDataAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **")] IAsyncOperation<Pointer<IContactList>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactChangeTracker **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContactChangeTracker**, int> get_ChangeTracker;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CContactStore_Windows__CApplicationModel__CContacts__CContactChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IContactStore>, Pointer<IContactChangedEventArgs>>*, EventRegistrationToken*, int> add_ContactChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ContactChanged;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IAggregateContactManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAggregateContactManager**, int> get_AggregateContactManager;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactList_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IContactList>>>>**, int> FindContactListsAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IContactList>>**, int> GetContactListAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IContactList>>**, int> CreateContactListAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IContact>>**, int> GetMeContactAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContactReader**, int> GetContactReader;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactQueryOptions *, ABI::Windows::ApplicationModel::Contacts::IContactReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContactQueryOptions*, IContactReader**, int> GetContactReaderWithOptions;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactList_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<Pointer<IContactList>>**, int> CreateContactListInAccountAsync;
    }
}
