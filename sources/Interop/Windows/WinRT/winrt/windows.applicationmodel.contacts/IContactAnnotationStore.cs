// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactAnnotationStore.xml' path='doc/member[@name="IContactAnnotationStore"]/*' />
[Guid("23ACF4AA-7A77-457D-8203-987F4B31AF09")]
[NativeTypeName("struct IContactAnnotationStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactAnnotationStore : IContactAnnotationStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactAnnotationStore));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationStore*, Guid*, void**, int>)(lpVtbl[0]))((IContactAnnotationStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationStore*, uint>)(lpVtbl[1]))((IContactAnnotationStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationStore*, uint>)(lpVtbl[2]))((IContactAnnotationStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationStore*, uint*, Guid**, int>)(lpVtbl[3]))((IContactAnnotationStore*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationStore*, HSTRING*, int>)(lpVtbl[4]))((IContactAnnotationStore*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationStore*, TrustLevel*, int>)(lpVtbl[5]))((IContactAnnotationStore*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactAnnotationStore.xml' path='doc/member[@name="IContactAnnotationStore.FindContactIdsByEmailAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindContactIdsByEmailAsync(HSTRING emailAddress, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **")] IAsyncOperation<Pointer<IVectorView<HSTRING>>>** contactIds)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationStore*, HSTRING, IAsyncOperation<Pointer<IVectorView<HSTRING>>>**, int>)(lpVtbl[6]))((IContactAnnotationStore*)Unsafe.AsPointer(ref this), emailAddress, contactIds);
    }

    /// <include file='IContactAnnotationStore.xml' path='doc/member[@name="IContactAnnotationStore.FindContactIdsByPhoneNumberAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindContactIdsByPhoneNumberAsync(HSTRING phoneNumber, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **")] IAsyncOperation<Pointer<IVectorView<HSTRING>>>** contactIds)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationStore*, HSTRING, IAsyncOperation<Pointer<IVectorView<HSTRING>>>**, int>)(lpVtbl[7]))((IContactAnnotationStore*)Unsafe.AsPointer(ref this), phoneNumber, contactIds);
    }

    /// <include file='IContactAnnotationStore.xml' path='doc/member[@name="IContactAnnotationStore.FindAnnotationsForContactAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindAnnotationsForContactAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotation_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContactAnnotation>>>>** annotations)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationStore*, IContact*, IAsyncOperation<Pointer<IVectorView<Pointer<IContactAnnotation>>>>**, int>)(lpVtbl[8]))((IContactAnnotationStore*)Unsafe.AsPointer(ref this), contact, annotations);
    }

    /// <include file='IContactAnnotationStore.xml' path='doc/member[@name="IContactAnnotationStore.DisableAnnotationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DisableAnnotationAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactAnnotation *")] IContactAnnotation* annotation, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationStore*, IContactAnnotation*, IAsyncAction**, int>)(lpVtbl[9]))((IContactAnnotationStore*)Unsafe.AsPointer(ref this), annotation, value);
    }

    /// <include file='IContactAnnotationStore.xml' path='doc/member[@name="IContactAnnotationStore.CreateAnnotationListAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateAnnotationListAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **")] IAsyncOperation<Pointer<IContactAnnotationList>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationStore*, IAsyncOperation<Pointer<IContactAnnotationList>>**, int>)(lpVtbl[10]))((IContactAnnotationStore*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAnnotationStore.xml' path='doc/member[@name="IContactAnnotationStore.CreateAnnotationListInAccountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateAnnotationListInAccountAsync(HSTRING userDataAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **")] IAsyncOperation<Pointer<IContactAnnotationList>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationStore*, HSTRING, IAsyncOperation<Pointer<IContactAnnotationList>>**, int>)(lpVtbl[11]))((IContactAnnotationStore*)Unsafe.AsPointer(ref this), userDataAccountId, value);
    }

    /// <include file='IContactAnnotationStore.xml' path='doc/member[@name="IContactAnnotationStore.GetAnnotationListAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetAnnotationListAsync(HSTRING annotationListId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **")] IAsyncOperation<Pointer<IContactAnnotationList>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationStore*, HSTRING, IAsyncOperation<Pointer<IContactAnnotationList>>**, int>)(lpVtbl[12]))((IContactAnnotationStore*)Unsafe.AsPointer(ref this), annotationListId, value);
    }

    /// <include file='IContactAnnotationStore.xml' path='doc/member[@name="IContactAnnotationStore.FindAnnotationListsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT FindAnnotationListsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContactAnnotationList>>>>** lists)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationStore*, IAsyncOperation<Pointer<IVectorView<Pointer<IContactAnnotationList>>>>**, int>)(lpVtbl[13]))((IContactAnnotationStore*)Unsafe.AsPointer(ref this), lists);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindContactIdsByEmailAsync(HSTRING emailAddress, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **")] IAsyncOperation<Pointer<IVectorView<HSTRING>>>** contactIds);

        [VtblIndex(7)]
        HRESULT FindContactIdsByPhoneNumberAsync(HSTRING phoneNumber, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **")] IAsyncOperation<Pointer<IVectorView<HSTRING>>>** contactIds);

        [VtblIndex(8)]
        HRESULT FindAnnotationsForContactAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotation_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContactAnnotation>>>>** annotations);

        [VtblIndex(9)]
        HRESULT DisableAnnotationAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactAnnotation *")] IContactAnnotation* annotation, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(10)]
        HRESULT CreateAnnotationListAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **")] IAsyncOperation<Pointer<IContactAnnotationList>>** value);

        [VtblIndex(11)]
        HRESULT CreateAnnotationListInAccountAsync(HSTRING userDataAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **")] IAsyncOperation<Pointer<IContactAnnotationList>>** value);

        [VtblIndex(12)]
        HRESULT GetAnnotationListAsync(HSTRING annotationListId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **")] IAsyncOperation<Pointer<IContactAnnotationList>>** value);

        [VtblIndex(13)]
        HRESULT FindAnnotationListsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContactAnnotationList>>>>** lists);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IVectorView<HSTRING>>>**, int> FindContactIdsByEmailAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IVectorView<HSTRING>>>**, int> FindContactIdsByPhoneNumberAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, IAsyncOperation<Pointer<IVectorView<Pointer<IContactAnnotation>>>>**, int> FindAnnotationsForContactAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactAnnotation *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContactAnnotation*, IAsyncAction**, int> DisableAnnotationAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IContactAnnotationList>>**, int> CreateAnnotationListAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IContactAnnotationList>>**, int> CreateAnnotationListInAccountAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IContactAnnotationList>>**, int> GetAnnotationListAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotationList_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IContactAnnotationList>>>>**, int> FindAnnotationListsAsync;
    }
}
