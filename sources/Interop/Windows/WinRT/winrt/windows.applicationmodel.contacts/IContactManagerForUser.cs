// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactManagerForUser.xml' path='doc/member[@name="IContactManagerForUser"]/*' />
[Guid("B74BBA57-1076-4BEF-AEF3-54686D18387D")]
[NativeTypeName("struct IContactManagerForUser : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactManagerForUser : IContactManagerForUser.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IContactManagerForUser);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerForUser*, Guid*, void**, int>)(lpVtbl[0]))((IContactManagerForUser*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerForUser*, uint>)(lpVtbl[1]))((IContactManagerForUser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerForUser*, uint>)(lpVtbl[2]))((IContactManagerForUser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerForUser*, uint*, Guid**, int>)(lpVtbl[3]))((IContactManagerForUser*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerForUser*, HSTRING*, int>)(lpVtbl[4]))((IContactManagerForUser*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerForUser*, TrustLevel*, int>)(lpVtbl[5]))((IContactManagerForUser*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactManagerForUser.xml' path='doc/member[@name="IContactManagerForUser.ConvertContactToVCardAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ConvertContactToVCardAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **")] IAsyncOperation<Pointer<IRandomAccessStreamReference>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerForUser*, IContact*, IAsyncOperation<Pointer<IRandomAccessStreamReference>>**, int>)(lpVtbl[6]))((IContactManagerForUser*)Unsafe.AsPointer(ref this), contact, result);
    }

    /// <include file='IContactManagerForUser.xml' path='doc/member[@name="IContactManagerForUser.ConvertContactToVCardAsyncWithMaxBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ConvertContactToVCardAsyncWithMaxBytes([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("UINT32")] uint maxBytes, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **")] IAsyncOperation<Pointer<IRandomAccessStreamReference>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerForUser*, IContact*, uint, IAsyncOperation<Pointer<IRandomAccessStreamReference>>**, int>)(lpVtbl[7]))((IContactManagerForUser*)Unsafe.AsPointer(ref this), contact, maxBytes, result);
    }

    /// <include file='IContactManagerForUser.xml' path='doc/member[@name="IContactManagerForUser.ConvertVCardToContactAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ConvertVCardToContactAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* vCard, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **")] IAsyncOperation<Pointer<IContact>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerForUser*, IRandomAccessStreamReference*, IAsyncOperation<Pointer<IContact>>**, int>)(lpVtbl[8]))((IContactManagerForUser*)Unsafe.AsPointer(ref this), vCard, result);
    }

    /// <include file='IContactManagerForUser.xml' path='doc/member[@name="IContactManagerForUser.RequestStoreAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestStoreAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactStoreAccessType")] ContactStoreAccessType accessType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactStore_t **")] IAsyncOperation<Pointer<IContactStore>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerForUser*, ContactStoreAccessType, IAsyncOperation<Pointer<IContactStore>>**, int>)(lpVtbl[9]))((IContactManagerForUser*)Unsafe.AsPointer(ref this), accessType, result);
    }

    /// <include file='IContactManagerForUser.xml' path='doc/member[@name="IContactManagerForUser.RequestAnnotationStoreAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RequestAnnotationStoreAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAnnotationStoreAccessType")] ContactAnnotationStoreAccessType accessType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationStore_t **")] IAsyncOperation<Pointer<IContactAnnotationStore>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerForUser*, ContactAnnotationStoreAccessType, IAsyncOperation<Pointer<IContactAnnotationStore>>**, int>)(lpVtbl[10]))((IContactManagerForUser*)Unsafe.AsPointer(ref this), accessType, result);
    }

    /// <include file='IContactManagerForUser.xml' path='doc/member[@name="IContactManagerForUser.get_SystemDisplayNameOrder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SystemDisplayNameOrder([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *")] ContactNameOrder* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerForUser*, ContactNameOrder*, int>)(lpVtbl[11]))((IContactManagerForUser*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactManagerForUser.xml' path='doc/member[@name="IContactManagerForUser.put_SystemDisplayNameOrder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_SystemDisplayNameOrder([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder")] ContactNameOrder value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerForUser*, ContactNameOrder, int>)(lpVtbl[12]))((IContactManagerForUser*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactManagerForUser.xml' path='doc/member[@name="IContactManagerForUser.get_SystemSortOrder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_SystemSortOrder([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *")] ContactNameOrder* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerForUser*, ContactNameOrder*, int>)(lpVtbl[13]))((IContactManagerForUser*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactManagerForUser.xml' path='doc/member[@name="IContactManagerForUser.put_SystemSortOrder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_SystemSortOrder([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder")] ContactNameOrder value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerForUser*, ContactNameOrder, int>)(lpVtbl[14]))((IContactManagerForUser*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactManagerForUser.xml' path='doc/member[@name="IContactManagerForUser.get_User"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerForUser*, IUser**, int>)(lpVtbl[15]))((IContactManagerForUser*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ConvertContactToVCardAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **")] IAsyncOperation<Pointer<IRandomAccessStreamReference>>** result);

        [VtblIndex(7)]
        HRESULT ConvertContactToVCardAsyncWithMaxBytes([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("UINT32")] uint maxBytes, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **")] IAsyncOperation<Pointer<IRandomAccessStreamReference>>** result);

        [VtblIndex(8)]
        HRESULT ConvertVCardToContactAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* vCard, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **")] IAsyncOperation<Pointer<IContact>>** result);

        [VtblIndex(9)]
        HRESULT RequestStoreAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactStoreAccessType")] ContactStoreAccessType accessType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactStore_t **")] IAsyncOperation<Pointer<IContactStore>>** result);

        [VtblIndex(10)]
        HRESULT RequestAnnotationStoreAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAnnotationStoreAccessType")] ContactAnnotationStoreAccessType accessType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationStore_t **")] IAsyncOperation<Pointer<IContactAnnotationStore>>** result);

        [VtblIndex(11)]
        HRESULT get_SystemDisplayNameOrder([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *")] ContactNameOrder* value);

        [VtblIndex(12)]
        HRESULT put_SystemDisplayNameOrder([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder")] ContactNameOrder value);

        [VtblIndex(13)]
        HRESULT get_SystemSortOrder([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *")] ContactNameOrder* value);

        [VtblIndex(14)]
        HRESULT put_SystemSortOrder([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder")] ContactNameOrder value);

        [VtblIndex(15)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, IAsyncOperation<Pointer<IRandomAccessStreamReference>>**, int> ConvertContactToVCardAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, uint, IAsyncOperation<Pointer<IRandomAccessStreamReference>>**, int> ConvertContactToVCardAsyncWithMaxBytes;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, IAsyncOperation<Pointer<IContact>>**, int> ConvertVCardToContactAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactStoreAccessType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactStore_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactStoreAccessType, IAsyncOperation<Pointer<IContactStore>>**, int> RequestStoreAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactAnnotationStoreAccessType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationStore_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactAnnotationStoreAccessType, IAsyncOperation<Pointer<IContactAnnotationStore>>**, int> RequestAnnotationStoreAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactNameOrder*, int> get_SystemDisplayNameOrder;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactNameOrder) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactNameOrder, int> put_SystemDisplayNameOrder;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactNameOrder*, int> get_SystemSortOrder;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactNameOrder) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactNameOrder, int> put_SystemSortOrder;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser**, int> get_User;
    }
}
