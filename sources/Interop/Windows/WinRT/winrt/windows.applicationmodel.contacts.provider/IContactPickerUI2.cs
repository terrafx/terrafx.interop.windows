// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactPickerUI2.xml' path='doc/member[@name="IContactPickerUI2"]/*' />
[Guid("6E449E28-7B25-4999-9B0B-875400A1E8C8")]
[NativeTypeName("struct IContactPickerUI2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactPickerUI2 : IContactPickerUI2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactPickerUI2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI2*, Guid*, void**, int>)(lpVtbl[0]))((IContactPickerUI2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI2*, uint>)(lpVtbl[1]))((IContactPickerUI2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI2*, uint>)(lpVtbl[2]))((IContactPickerUI2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI2*, uint*, Guid**, int>)(lpVtbl[3]))((IContactPickerUI2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI2*, HSTRING*, int>)(lpVtbl[4]))((IContactPickerUI2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI2*, TrustLevel*, int>)(lpVtbl[5]))((IContactPickerUI2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactPickerUI2.xml' path='doc/member[@name="IContactPickerUI2.AddContact"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddContact([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::Provider::AddContactResult *")] AddContactResult* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI2*, IContact*, AddContactResult*, int>)(lpVtbl[6]))((IContactPickerUI2*)Unsafe.AsPointer(ref this), contact, result);
    }

    /// <include file='IContactPickerUI2.xml' path='doc/member[@name="IContactPickerUI2.get_DesiredFieldsWithContactFieldType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DesiredFieldsWithContactFieldType([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactFieldType_t **")] IVector<ContactFieldType>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI2*, IVector<ContactFieldType>**, int>)(lpVtbl[7]))((IContactPickerUI2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddContact([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::Provider::AddContactResult *")] AddContactResult* result);

        [VtblIndex(7)]
        HRESULT get_DesiredFieldsWithContactFieldType([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactFieldType_t **")] IVector<ContactFieldType>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::ApplicationModel::Contacts::Provider::AddContactResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContact*, AddContactResult*, int> AddContact;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactFieldType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<ContactFieldType>**, int> get_DesiredFieldsWithContactFieldType;
    }
}
