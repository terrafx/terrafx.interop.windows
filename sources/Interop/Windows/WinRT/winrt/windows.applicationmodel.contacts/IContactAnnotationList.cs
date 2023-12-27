// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactAnnotationList.xml' path='doc/member[@name="IContactAnnotationList"]/*' />
[Guid("92A486AA-5C88-45B9-AAD0-461888E68D8A")]
[NativeTypeName("struct IContactAnnotationList : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactAnnotationList : IContactAnnotationList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactAnnotationList));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationList*, Guid*, void**, int>)(lpVtbl[0]))((IContactAnnotationList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationList*, uint>)(lpVtbl[1]))((IContactAnnotationList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationList*, uint>)(lpVtbl[2]))((IContactAnnotationList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationList*, uint*, Guid**, int>)(lpVtbl[3]))((IContactAnnotationList*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationList*, HSTRING*, int>)(lpVtbl[4]))((IContactAnnotationList*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationList*, TrustLevel*, int>)(lpVtbl[5]))((IContactAnnotationList*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactAnnotationList.xml' path='doc/member[@name="IContactAnnotationList.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationList*, HSTRING*, int>)(lpVtbl[6]))((IContactAnnotationList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAnnotationList.xml' path='doc/member[@name="IContactAnnotationList.get_ProviderPackageFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ProviderPackageFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationList*, HSTRING*, int>)(lpVtbl[7]))((IContactAnnotationList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAnnotationList.xml' path='doc/member[@name="IContactAnnotationList.get_UserDataAccountId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_UserDataAccountId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationList*, HSTRING*, int>)(lpVtbl[8]))((IContactAnnotationList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAnnotationList.xml' path='doc/member[@name="IContactAnnotationList.DeleteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationList*, IAsyncAction**, int>)(lpVtbl[9]))((IContactAnnotationList*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAnnotationList.xml' path='doc/member[@name="IContactAnnotationList.TrySaveAnnotationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TrySaveAnnotationAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactAnnotation *")] IContactAnnotation* annotation, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationList*, IContactAnnotation*, IAsyncOperation<bool>**, int>)(lpVtbl[10]))((IContactAnnotationList*)Unsafe.AsPointer(ref this), annotation, ppResult);
    }

    /// <include file='IContactAnnotationList.xml' path='doc/member[@name="IContactAnnotationList.GetAnnotationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetAnnotationAsync(HSTRING annotationId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotation_t **")] IAsyncOperation<Pointer<IContactAnnotation>>** annotation)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationList*, HSTRING, IAsyncOperation<Pointer<IContactAnnotation>>**, int>)(lpVtbl[11]))((IContactAnnotationList*)Unsafe.AsPointer(ref this), annotationId, annotation);
    }

    /// <include file='IContactAnnotationList.xml' path='doc/member[@name="IContactAnnotationList.FindAnnotationsByRemoteIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT FindAnnotationsByRemoteIdAsync(HSTRING remoteId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotation_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContactAnnotation>>>>** annotations)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationList*, HSTRING, IAsyncOperation<Pointer<IVectorView<Pointer<IContactAnnotation>>>>**, int>)(lpVtbl[12]))((IContactAnnotationList*)Unsafe.AsPointer(ref this), remoteId, annotations);
    }

    /// <include file='IContactAnnotationList.xml' path='doc/member[@name="IContactAnnotationList.FindAnnotationsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT FindAnnotationsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotation_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContactAnnotation>>>>** annotations)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationList*, IAsyncOperation<Pointer<IVectorView<Pointer<IContactAnnotation>>>>**, int>)(lpVtbl[13]))((IContactAnnotationList*)Unsafe.AsPointer(ref this), annotations);
    }

    /// <include file='IContactAnnotationList.xml' path='doc/member[@name="IContactAnnotationList.DeleteAnnotationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT DeleteAnnotationAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactAnnotation *")] IContactAnnotation* annotation, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotationList*, IContactAnnotation*, IAsyncAction**, int>)(lpVtbl[14]))((IContactAnnotationList*)Unsafe.AsPointer(ref this), annotation, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ProviderPackageFamilyName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_UserDataAccountId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT DeleteAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(10)]
        HRESULT TrySaveAnnotationAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactAnnotation *")] IContactAnnotation* annotation, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** ppResult);

        [VtblIndex(11)]
        HRESULT GetAnnotationAsync(HSTRING annotationId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotation_t **")] IAsyncOperation<Pointer<IContactAnnotation>>** annotation);

        [VtblIndex(12)]
        HRESULT FindAnnotationsByRemoteIdAsync(HSTRING remoteId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotation_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContactAnnotation>>>>** annotations);

        [VtblIndex(13)]
        HRESULT FindAnnotationsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotation_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContactAnnotation>>>>** annotations);

        [VtblIndex(14)]
        HRESULT DeleteAnnotationAsync([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactAnnotation *")] IContactAnnotation* annotation, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ProviderPackageFamilyName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserDataAccountId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> DeleteAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactAnnotation *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContactAnnotation*, IAsyncOperation<bool>**, int> TrySaveAnnotationAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactAnnotation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IContactAnnotation>>**, int> GetAnnotationAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IVectorView<Pointer<IContactAnnotation>>>>**, int> FindAnnotationsByRemoteIdAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactAnnotation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IContactAnnotation>>>>**, int> FindAnnotationsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactAnnotation *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContactAnnotation*, IAsyncAction**, int> DeleteAnnotationAsync;
    }
}
