// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactPickerUI.xml' path='doc/member[@name="IContactPickerUI"]/*' />
[Guid("E2CC1366-CF66-43C4-A96A-A5A112DB4746")]
[NativeTypeName("struct IContactPickerUI : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactPickerUI : IContactPickerUI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactPickerUI));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI*, Guid*, void**, int>)(lpVtbl[0]))((IContactPickerUI*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI*, uint>)(lpVtbl[1]))((IContactPickerUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI*, uint>)(lpVtbl[2]))((IContactPickerUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI*, uint*, Guid**, int>)(lpVtbl[3]))((IContactPickerUI*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI*, HSTRING*, int>)(lpVtbl[4]))((IContactPickerUI*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI*, TrustLevel*, int>)(lpVtbl[5]))((IContactPickerUI*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactPickerUI.xml' path='doc/member[@name="IContactPickerUI.AddContact"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("AddContact may be altered or unavailable for releases after Windows 8.1. Instead, use AddContact without the ID.")]
    public HRESULT AddContact(HSTRING id, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::Provider::AddContactResult *")] AddContactResult* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI*, HSTRING, IContact*, AddContactResult*, int>)(lpVtbl[6]))((IContactPickerUI*)Unsafe.AsPointer(ref this), id, contact, result);
    }

    /// <include file='IContactPickerUI.xml' path='doc/member[@name="IContactPickerUI.RemoveContact"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveContact(HSTRING id)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI*, HSTRING, int>)(lpVtbl[7]))((IContactPickerUI*)Unsafe.AsPointer(ref this), id);
    }

    /// <include file='IContactPickerUI.xml' path='doc/member[@name="IContactPickerUI.ContainsContact"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ContainsContact(HSTRING id, [NativeTypeName("boolean *")] byte* isContained)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI*, HSTRING, byte*, int>)(lpVtbl[8]))((IContactPickerUI*)Unsafe.AsPointer(ref this), id, isContained);
    }

    /// <include file='IContactPickerUI.xml' path='doc/member[@name="IContactPickerUI.get_DesiredFields"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("DesiredFields may be altered or unavailable for releases after Windows 8.1. Instead, use DesiredFieldsWithContactFieldType.")]
    public HRESULT get_DesiredFields([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI*, IVectorView<HSTRING>**, int>)(lpVtbl[9]))((IContactPickerUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactPickerUI.xml' path='doc/member[@name="IContactPickerUI.get_SelectionMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SelectionMode([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode *")] ContactSelectionMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI*, ContactSelectionMode*, int>)(lpVtbl[10]))((IContactPickerUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactPickerUI.xml' path='doc/member[@name="IContactPickerUI.add_ContactRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_ContactRemoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CProvider__CContactPickerUI_Windows__CApplicationModel__CContacts__CProvider__CContactRemovedEventArgs_t *")] ITypedEventHandler<Pointer<IContactPickerUI>, Pointer<IContactRemovedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI*, ITypedEventHandler<Pointer<IContactPickerUI>, Pointer<IContactRemovedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IContactPickerUI*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IContactPickerUI.xml' path='doc/member[@name="IContactPickerUI.remove_ContactRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_ContactRemoved(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPickerUI*, EventRegistrationToken, int>)(lpVtbl[12]))((IContactPickerUI*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("AddContact may be altered or unavailable for releases after Windows 8.1. Instead, use AddContact without the ID.")]
        HRESULT AddContact(HSTRING id, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContact *")] IContact* contact, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::Provider::AddContactResult *")] AddContactResult* result);

        [VtblIndex(7)]
        HRESULT RemoveContact(HSTRING id);

        [VtblIndex(8)]
        HRESULT ContainsContact(HSTRING id, [NativeTypeName("boolean *")] byte* isContained);

        [VtblIndex(9)]
        [Obsolete("DesiredFields may be altered or unavailable for releases after Windows 8.1. Instead, use DesiredFieldsWithContactFieldType.")]
        HRESULT get_DesiredFields([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value);

        [VtblIndex(10)]
        HRESULT get_SelectionMode([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode *")] ContactSelectionMode* value);

        [VtblIndex(11)]
        HRESULT add_ContactRemoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CProvider__CContactPickerUI_Windows__CApplicationModel__CContacts__CProvider__CContactRemovedEventArgs_t *")] ITypedEventHandler<Pointer<IContactPickerUI>, Pointer<IContactRemovedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_ContactRemoved(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::IContact *, ABI::Windows::ApplicationModel::Contacts::Provider::AddContactResult *) __attribute__((stdcall))")]
        [Obsolete("AddContact may be altered or unavailable for releases after Windows 8.1. Instead, use AddContact without the ID.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IContact*, AddContactResult*, int> AddContact;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> RemoveContact;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> ContainsContact;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        [Obsolete("DesiredFields may be altered or unavailable for releases after Windows 8.1. Instead, use DesiredFieldsWithContactFieldType.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_DesiredFields;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactSelectionMode*, int> get_SelectionMode;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CContacts__CProvider__CContactPickerUI_Windows__CApplicationModel__CContacts__CProvider__CContactRemovedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IContactPickerUI>, Pointer<IContactRemovedEventArgs>>*, EventRegistrationToken*, int> add_ContactRemoved;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ContactRemoved;
    }
}
