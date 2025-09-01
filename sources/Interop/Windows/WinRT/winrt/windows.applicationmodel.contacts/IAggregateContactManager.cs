// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAggregateContactManager.xml' path='doc/member[@name="IAggregateContactManager"]/*' />
[Guid("0379D5DD-DB5A-4FD3-B54E-4DF17917A212")]
[NativeTypeName("struct IAggregateContactManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAggregateContactManager : IAggregateContactManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAggregateContactManager);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAggregateContactManager*, Guid*, void**, int>)(lpVtbl[0]))((IAggregateContactManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAggregateContactManager*, uint>)(lpVtbl[1]))((IAggregateContactManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAggregateContactManager*, uint>)(lpVtbl[2]))((IAggregateContactManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAggregateContactManager*, uint*, Guid**, int>)(lpVtbl[3]))((IAggregateContactManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAggregateContactManager*, HSTRING*, int>)(lpVtbl[4]))((IAggregateContactManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAggregateContactManager*, TrustLevel*, int>)(lpVtbl[5]))((IAggregateContactManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAggregateContactManager.xml' path='doc/member[@name="IAggregateContactManager.FindRawContactsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindRawContactsAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContact_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContact>>>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAggregateContactManager*, IContact*, IAsyncOperation<Pointer<IVectorView<Pointer<IContact>>>>**, int>)(lpVtbl[6]))((IAggregateContactManager*)Unsafe.AsPointer(ref this), contact, value);
    }

    /// <include file='IAggregateContactManager.xml' path='doc/member[@name="IAggregateContactManager.TryLinkContactsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryLinkContactsAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* primaryContact, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* secondaryContact, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **")] IAsyncOperation<Pointer<IContact>>** contact)
    {
        return ((delegate* unmanaged[MemberFunction]<IAggregateContactManager*, IContact*, IContact*, IAsyncOperation<Pointer<IContact>>**, int>)(lpVtbl[7]))((IAggregateContactManager*)Unsafe.AsPointer(ref this), primaryContact, secondaryContact, contact);
    }

    /// <include file='IAggregateContactManager.xml' path='doc/member[@name="IAggregateContactManager.UnlinkRawContactAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UnlinkRawContactAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAggregateContactManager*, IContact*, IAsyncAction**, int>)(lpVtbl[8]))((IAggregateContactManager*)Unsafe.AsPointer(ref this), contact, value);
    }

    /// <include file='IAggregateContactManager.xml' path='doc/member[@name="IAggregateContactManager.TrySetPreferredSourceForPictureAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TrySetPreferredSourceForPictureAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* aggregateContact, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* rawContact, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAggregateContactManager*, IContact*, IContact*, IAsyncOperation<bool>**, int>)(lpVtbl[9]))((IAggregateContactManager*)Unsafe.AsPointer(ref this), aggregateContact, rawContact, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindRawContactsAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContact_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContact>>>>** value);

        [VtblIndex(7)]
        HRESULT TryLinkContactsAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* primaryContact, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* secondaryContact, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **")] IAsyncOperation<Pointer<IContact>>** contact);

        [VtblIndex(8)]
        HRESULT UnlinkRawContactAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(9)]
        HRESULT TrySetPreferredSourceForPictureAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* aggregateContact, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* rawContact, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContact_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, IAsyncOperation<Pointer<IVectorView<Pointer<IContact>>>>**, int> FindRawContactsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, IContact*, IAsyncOperation<Pointer<IContact>>**, int> TryLinkContactsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, IAsyncAction**, int> UnlinkRawContactAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, IContact*, IAsyncOperation<bool>**, int> TrySetPreferredSourceForPictureAsync;
    }
}
