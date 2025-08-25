// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactManagerStatics3.xml' path='doc/member[@name="IContactManagerStatics3"]/*' />
[Guid("C4CC3D42-7586-492A-930B-7BC138FC2139")]
[NativeTypeName("struct IContactManagerStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactManagerStatics3 : IContactManagerStatics3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IContactManagerStatics3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, Guid*, void**, int>)(lpVtbl[0]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, uint>)(lpVtbl[1]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, uint>)(lpVtbl[2]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, HSTRING*, int>)(lpVtbl[4]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, TrustLevel*, int>)(lpVtbl[5]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactManagerStatics3.xml' path='doc/member[@name="IContactManagerStatics3.ConvertContactToVCardAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ConvertContactToVCardAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **")] IAsyncOperation<Pointer<IRandomAccessStreamReference>>** vCard)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, IContact*, IAsyncOperation<Pointer<IRandomAccessStreamReference>>**, int>)(lpVtbl[6]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), contact, vCard);
    }

    /// <include file='IContactManagerStatics3.xml' path='doc/member[@name="IContactManagerStatics3.ConvertContactToVCardAsyncWithMaxBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ConvertContactToVCardAsyncWithMaxBytes([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("UINT32")] uint maxBytes, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **")] IAsyncOperation<Pointer<IRandomAccessStreamReference>>** vCard)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, IContact*, uint, IAsyncOperation<Pointer<IRandomAccessStreamReference>>**, int>)(lpVtbl[7]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), contact, maxBytes, vCard);
    }

    /// <include file='IContactManagerStatics3.xml' path='doc/member[@name="IContactManagerStatics3.ConvertVCardToContactAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ConvertVCardToContactAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* vCard, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **")] IAsyncOperation<Pointer<IContact>>** contact)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, IRandomAccessStreamReference*, IAsyncOperation<Pointer<IContact>>**, int>)(lpVtbl[8]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), vCard, contact);
    }

    /// <include file='IContactManagerStatics3.xml' path='doc/member[@name="IContactManagerStatics3.RequestStoreAsyncWithAccessType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestStoreAsyncWithAccessType([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactStoreAccessType")] ContactStoreAccessType accessType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactStore_t **")] IAsyncOperation<Pointer<IContactStore>>** store)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, ContactStoreAccessType, IAsyncOperation<Pointer<IContactStore>>**, int>)(lpVtbl[9]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), accessType, store);
    }

    /// <include file='IContactManagerStatics3.xml' path='doc/member[@name="IContactManagerStatics3.RequestAnnotationStoreAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RequestAnnotationStoreAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAnnotationStoreAccessType")] ContactAnnotationStoreAccessType accessType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationStore_t **")] IAsyncOperation<Pointer<IContactAnnotationStore>>** store)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, ContactAnnotationStoreAccessType, IAsyncOperation<Pointer<IContactAnnotationStore>>**, int>)(lpVtbl[10]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), accessType, store);
    }

    /// <include file='IContactManagerStatics3.xml' path='doc/member[@name="IContactManagerStatics3.IsShowContactCardSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsShowContactCardSupported([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, byte*, int>)(lpVtbl[11]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IContactManagerStatics3.xml' path='doc/member[@name="IContactManagerStatics3.ShowContactCardWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ShowContactCardWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactCardOptions *")] IContactCardOptions* contactCardOptions)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, IContact*, Rect, Placement, IContactCardOptions*, int>)(lpVtbl[12]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), contact, selection, preferredPlacement, contactCardOptions);
    }

    /// <include file='IContactManagerStatics3.xml' path='doc/member[@name="IContactManagerStatics3.IsShowDelayLoadedContactCardSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT IsShowDelayLoadedContactCardSupported([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, byte*, int>)(lpVtbl[13]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IContactManagerStatics3.xml' path='doc/member[@name="IContactManagerStatics3.ShowDelayLoadedContactCardWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ShowDelayLoadedContactCardWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactCardOptions *")] IContactCardOptions* contactCardOptions, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactCardDelayedDataLoader **")] IContactCardDelayedDataLoader** dataLoader)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, IContact*, Rect, Placement, IContactCardOptions*, IContactCardDelayedDataLoader**, int>)(lpVtbl[14]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), contact, selection, preferredPlacement, contactCardOptions, dataLoader);
    }

    /// <include file='IContactManagerStatics3.xml' path='doc/member[@name="IContactManagerStatics3.ShowFullContactCard"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ShowFullContactCard([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IFullContactCardOptions *")] IFullContactCardOptions* fullContactCardOptions)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, IContact*, IFullContactCardOptions*, int>)(lpVtbl[15]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), contact, fullContactCardOptions);
    }

    /// <include file='IContactManagerStatics3.xml' path='doc/member[@name="IContactManagerStatics3.get_SystemDisplayNameOrder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_SystemDisplayNameOrder([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *")] ContactNameOrder* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, ContactNameOrder*, int>)(lpVtbl[16]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactManagerStatics3.xml' path='doc/member[@name="IContactManagerStatics3.put_SystemDisplayNameOrder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_SystemDisplayNameOrder([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder")] ContactNameOrder value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, ContactNameOrder, int>)(lpVtbl[17]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactManagerStatics3.xml' path='doc/member[@name="IContactManagerStatics3.get_SystemSortOrder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_SystemSortOrder([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *")] ContactNameOrder* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, ContactNameOrder*, int>)(lpVtbl[18]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactManagerStatics3.xml' path='doc/member[@name="IContactManagerStatics3.put_SystemSortOrder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_SystemSortOrder([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder")] ContactNameOrder value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactManagerStatics3*, ContactNameOrder, int>)(lpVtbl[19]))((IContactManagerStatics3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ConvertContactToVCardAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **")] IAsyncOperation<Pointer<IRandomAccessStreamReference>>** vCard);

        [VtblIndex(7)]
        HRESULT ConvertContactToVCardAsyncWithMaxBytes([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("UINT32")] uint maxBytes, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **")] IAsyncOperation<Pointer<IRandomAccessStreamReference>>** vCard);

        [VtblIndex(8)]
        HRESULT ConvertVCardToContactAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* vCard, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContact_t **")] IAsyncOperation<Pointer<IContact>>** contact);

        [VtblIndex(9)]
        HRESULT RequestStoreAsyncWithAccessType([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactStoreAccessType")] ContactStoreAccessType accessType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactStore_t **")] IAsyncOperation<Pointer<IContactStore>>** store);

        [VtblIndex(10)]
        HRESULT RequestAnnotationStoreAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAnnotationStoreAccessType")] ContactAnnotationStoreAccessType accessType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationStore_t **")] IAsyncOperation<Pointer<IContactAnnotationStore>>** store);

        [VtblIndex(11)]
        HRESULT IsShowContactCardSupported([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(12)]
        HRESULT ShowContactCardWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactCardOptions *")] IContactCardOptions* contactCardOptions);

        [VtblIndex(13)]
        HRESULT IsShowDelayLoadedContactCardSupported([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(14)]
        HRESULT ShowDelayLoadedContactCardWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect selection, [NativeTypeName("ABI::Windows::UI::Popups::Placement")] Placement preferredPlacement, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactCardOptions *")] IContactCardOptions* contactCardOptions, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactCardDelayedDataLoader **")] IContactCardDelayedDataLoader** dataLoader);

        [VtblIndex(15)]
        HRESULT ShowFullContactCard([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IFullContactCardOptions *")] IFullContactCardOptions* fullContactCardOptions);

        [VtblIndex(16)]
        HRESULT get_SystemDisplayNameOrder([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *")] ContactNameOrder* value);

        [VtblIndex(17)]
        HRESULT put_SystemDisplayNameOrder([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder")] ContactNameOrder value);

        [VtblIndex(18)]
        HRESULT get_SystemSortOrder([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *")] ContactNameOrder* value);

        [VtblIndex(19)]
        HRESULT put_SystemSortOrder([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactNameOrder")] ContactNameOrder value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactStoreAccessType, IAsyncOperation<Pointer<IContactStore>>**, int> RequestStoreAsyncWithAccessType;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactAnnotationStoreAccessType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationStore_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactAnnotationStoreAccessType, IAsyncOperation<Pointer<IContactAnnotationStore>>**, int> RequestAnnotationStoreAsync;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> IsShowContactCardSupported;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::ApplicationModel::Contacts::IContactCardOptions *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, Rect, Placement, IContactCardOptions*, int> ShowContactCardWithOptions;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> IsShowDelayLoadedContactCardSupported;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::Rect, ABI::Windows::UI::Popups::Placement, ABI::Windows::ApplicationModel::Contacts::IContactCardOptions *, ABI::Windows::ApplicationModel::Contacts::IContactCardDelayedDataLoader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, Rect, Placement, IContactCardOptions*, IContactCardDelayedDataLoader**, int> ShowDelayLoadedContactCardWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::ApplicationModel::Contacts::IFullContactCardOptions *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, IFullContactCardOptions*, int> ShowFullContactCard;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactNameOrder*, int> get_SystemDisplayNameOrder;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactNameOrder) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactNameOrder, int> put_SystemDisplayNameOrder;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactNameOrder *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactNameOrder*, int> get_SystemSortOrder;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactNameOrder) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactNameOrder, int> put_SystemSortOrder;
    }
}
