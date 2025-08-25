// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactQueryOptions.xml' path='doc/member[@name="IContactQueryOptions"]/*' />
[Guid("4408CC9E-7D7C-42F0-8AC7-F50733ECDBC1")]
[NativeTypeName("struct IContactQueryOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactQueryOptions : IContactQueryOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IContactQueryOptions);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryOptions*, Guid*, void**, int>)(lpVtbl[0]))((IContactQueryOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryOptions*, uint>)(lpVtbl[1]))((IContactQueryOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryOptions*, uint>)(lpVtbl[2]))((IContactQueryOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IContactQueryOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryOptions*, HSTRING*, int>)(lpVtbl[4]))((IContactQueryOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryOptions*, TrustLevel*, int>)(lpVtbl[5]))((IContactQueryOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactQueryOptions.xml' path='doc/member[@name="IContactQueryOptions.get_TextSearch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TextSearch([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactQueryTextSearch **")] IContactQueryTextSearch** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryOptions*, IContactQueryTextSearch**, int>)(lpVtbl[6]))((IContactQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactQueryOptions.xml' path='doc/member[@name="IContactQueryOptions.get_ContactListIds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ContactListIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryOptions*, IVector<HSTRING>**, int>)(lpVtbl[7]))((IContactQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactQueryOptions.xml' path='doc/member[@name="IContactQueryOptions.get_IncludeContactsFromHiddenLists"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IncludeContactsFromHiddenLists([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryOptions*, byte*, int>)(lpVtbl[8]))((IContactQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactQueryOptions.xml' path='doc/member[@name="IContactQueryOptions.put_IncludeContactsFromHiddenLists"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IncludeContactsFromHiddenLists([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryOptions*, byte, int>)(lpVtbl[9]))((IContactQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactQueryOptions.xml' path='doc/member[@name="IContactQueryOptions.get_DesiredFields"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DesiredFields([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQueryDesiredFields *")] ContactQueryDesiredFields* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryOptions*, ContactQueryDesiredFields*, int>)(lpVtbl[10]))((IContactQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactQueryOptions.xml' path='doc/member[@name="IContactQueryOptions.put_DesiredFields"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_DesiredFields([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQueryDesiredFields")] ContactQueryDesiredFields value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryOptions*, ContactQueryDesiredFields, int>)(lpVtbl[11]))((IContactQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactQueryOptions.xml' path='doc/member[@name="IContactQueryOptions.get_DesiredOperations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DesiredOperations([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations *")] ContactAnnotationOperations* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryOptions*, ContactAnnotationOperations*, int>)(lpVtbl[12]))((IContactQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactQueryOptions.xml' path='doc/member[@name="IContactQueryOptions.put_DesiredOperations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_DesiredOperations([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations")] ContactAnnotationOperations value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryOptions*, ContactAnnotationOperations, int>)(lpVtbl[13]))((IContactQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactQueryOptions.xml' path='doc/member[@name="IContactQueryOptions.get_AnnotationListIds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_AnnotationListIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactQueryOptions*, IVector<HSTRING>**, int>)(lpVtbl[14]))((IContactQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TextSearch([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactQueryTextSearch **")] IContactQueryTextSearch** value);

        [VtblIndex(7)]
        HRESULT get_ContactListIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(8)]
        HRESULT get_IncludeContactsFromHiddenLists([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IncludeContactsFromHiddenLists([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_DesiredFields([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQueryDesiredFields *")] ContactQueryDesiredFields* value);

        [VtblIndex(11)]
        HRESULT put_DesiredFields([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactQueryDesiredFields")] ContactQueryDesiredFields value);

        [VtblIndex(12)]
        HRESULT get_DesiredOperations([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations *")] ContactAnnotationOperations* value);

        [VtblIndex(13)]
        HRESULT put_DesiredOperations([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations")] ContactAnnotationOperations value);

        [VtblIndex(14)]
        HRESULT get_AnnotationListIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContactQueryTextSearch **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContactQueryTextSearch**, int> get_TextSearch;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_ContactListIds;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IncludeContactsFromHiddenLists;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IncludeContactsFromHiddenLists;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactQueryDesiredFields *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactQueryDesiredFields*, int> get_DesiredFields;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactQueryDesiredFields) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactQueryDesiredFields, int> put_DesiredFields;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactAnnotationOperations*, int> get_DesiredOperations;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactAnnotationOperations, int> put_DesiredOperations;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_AnnotationListIds;
    }
}
