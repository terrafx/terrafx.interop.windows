// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactPicker.xml' path='doc/member[@name="IContactPicker"]/*' />
[Guid("0E09FD91-42F8-4055-90A0-896F96738936")]
[NativeTypeName("struct IContactPicker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactPicker : IContactPicker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IContactPicker);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPicker*, Guid*, void**, int>)(lpVtbl[0]))((IContactPicker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPicker*, uint>)(lpVtbl[1]))((IContactPicker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPicker*, uint>)(lpVtbl[2]))((IContactPicker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPicker*, uint*, Guid**, int>)(lpVtbl[3]))((IContactPicker*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPicker*, HSTRING*, int>)(lpVtbl[4]))((IContactPicker*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPicker*, TrustLevel*, int>)(lpVtbl[5]))((IContactPicker*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactPicker.xml' path='doc/member[@name="IContactPicker.get_CommitButtonText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CommitButtonText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPicker*, HSTRING*, int>)(lpVtbl[6]))((IContactPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactPicker.xml' path='doc/member[@name="IContactPicker.put_CommitButtonText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CommitButtonText(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPicker*, HSTRING, int>)(lpVtbl[7]))((IContactPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactPicker.xml' path='doc/member[@name="IContactPicker.get_SelectionMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SelectionMode([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode *")] ContactSelectionMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPicker*, ContactSelectionMode*, int>)(lpVtbl[8]))((IContactPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactPicker.xml' path='doc/member[@name="IContactPicker.put_SelectionMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SelectionMode([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode")] ContactSelectionMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPicker*, ContactSelectionMode, int>)(lpVtbl[9]))((IContactPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactPicker.xml' path='doc/member[@name="IContactPicker.get_DesiredFields"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DesiredFields([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPicker*, IVector<HSTRING>**, int>)(lpVtbl[10]))((IContactPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactPicker.xml' path='doc/member[@name="IContactPicker.PickSingleContactAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT PickSingleContactAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactInformation_t **")] IAsyncOperation<Pointer<IContactInformation>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPicker*, IAsyncOperation<Pointer<IContactInformation>>**, int>)(lpVtbl[11]))((IContactPicker*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IContactPicker.xml' path='doc/member[@name="IContactPicker.PickMultipleContactsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT PickMultipleContactsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactInformation_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContactInformation>>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactPicker*, IAsyncOperation<Pointer<IVectorView<Pointer<IContactInformation>>>>**, int>)(lpVtbl[12]))((IContactPicker*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CommitButtonText(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_CommitButtonText(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_SelectionMode([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode *")] ContactSelectionMode* value);

        [VtblIndex(9)]
        HRESULT put_SelectionMode([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode")] ContactSelectionMode value);

        [VtblIndex(10)]
        HRESULT get_DesiredFields([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(11)]
        HRESULT PickSingleContactAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactInformation_t **")] IAsyncOperation<Pointer<IContactInformation>>** result);

        [VtblIndex(12)]
        HRESULT PickMultipleContactsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactInformation_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IContactInformation>>>>** result);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CommitButtonText;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_CommitButtonText;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactSelectionMode*, int> get_SelectionMode;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactSelectionMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactSelectionMode, int> put_SelectionMode;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_DesiredFields;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CContacts__CContactInformation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IContactInformation>>**, int> PickSingleContactAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CContacts__CContactInformation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IContactInformation>>>>**, int> PickMultipleContactsAsync;
    }
}
