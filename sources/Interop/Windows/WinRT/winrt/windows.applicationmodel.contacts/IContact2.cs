// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContact2.xml' path='doc/member[@name="IContact2"]/*' />
[Guid("F312F365-BB77-4C94-802D-8328CEE40C08")]
[NativeTypeName("struct IContact2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContact2 : IContact2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContact2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, Guid*, void**, int>)(lpVtbl[0]))((IContact2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, uint>)(lpVtbl[1]))((IContact2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, uint>)(lpVtbl[2]))((IContact2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, uint*, Guid**, int>)(lpVtbl[3]))((IContact2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, HSTRING*, int>)(lpVtbl[4]))((IContact2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, TrustLevel*, int>)(lpVtbl[5]))((IContact2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContact2.xml' path='doc/member[@name="IContact2.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, HSTRING*, int>)(lpVtbl[6]))((IContact2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact2.xml' path='doc/member[@name="IContact2.put_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Id(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, HSTRING, int>)(lpVtbl[7]))((IContact2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact2.xml' path='doc/member[@name="IContact2.get_Notes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Notes(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, HSTRING*, int>)(lpVtbl[8]))((IContact2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact2.xml' path='doc/member[@name="IContact2.put_Notes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Notes(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, HSTRING, int>)(lpVtbl[9]))((IContact2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact2.xml' path='doc/member[@name="IContact2.get_Phones"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Phones([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactPhone_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, IVector<IntPtr>**, int>)(lpVtbl[10]))((IContact2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact2.xml' path='doc/member[@name="IContact2.get_Emails"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Emails([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactEmail_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, IVector<IntPtr>**, int>)(lpVtbl[11]))((IContact2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact2.xml' path='doc/member[@name="IContact2.get_Addresses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Addresses([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactAddress_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, IVector<IntPtr>**, int>)(lpVtbl[12]))((IContact2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact2.xml' path='doc/member[@name="IContact2.get_ConnectedServiceAccounts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ConnectedServiceAccounts([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactConnectedServiceAccount_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, IVector<IntPtr>**, int>)(lpVtbl[13]))((IContact2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact2.xml' path='doc/member[@name="IContact2.get_ImportantDates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ImportantDates([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactDate_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, IVector<IntPtr>**, int>)(lpVtbl[14]))((IContact2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact2.xml' path='doc/member[@name="IContact2.get_DataSuppliers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_DataSuppliers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, IVector<HSTRING>**, int>)(lpVtbl[15]))((IContact2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact2.xml' path='doc/member[@name="IContact2.get_JobInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_JobInfo([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactJobInfo_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, IVector<IntPtr>**, int>)(lpVtbl[16]))((IContact2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact2.xml' path='doc/member[@name="IContact2.get_SignificantOthers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SignificantOthers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactSignificantOther_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, IVector<IntPtr>**, int>)(lpVtbl[17]))((IContact2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact2.xml' path='doc/member[@name="IContact2.get_Websites"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Websites([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactWebsite_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, IVector<IntPtr>**, int>)(lpVtbl[18]))((IContact2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContact2.xml' path='doc/member[@name="IContact2.get_ProviderProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_ProviderProperties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContact2*, IPropertySet**, int>)(lpVtbl[19]))((IContact2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Id(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Notes(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Notes(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Phones([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactPhone_t **")] IVector<IntPtr>** value);

        [VtblIndex(11)]
        HRESULT get_Emails([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactEmail_t **")] IVector<IntPtr>** value);

        [VtblIndex(12)]
        HRESULT get_Addresses([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactAddress_t **")] IVector<IntPtr>** value);

        [VtblIndex(13)]
        HRESULT get_ConnectedServiceAccounts([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactConnectedServiceAccount_t **")] IVector<IntPtr>** value);

        [VtblIndex(14)]
        HRESULT get_ImportantDates([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactDate_t **")] IVector<IntPtr>** value);

        [VtblIndex(15)]
        HRESULT get_DataSuppliers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(16)]
        HRESULT get_JobInfo([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactJobInfo_t **")] IVector<IntPtr>** value);

        [VtblIndex(17)]
        HRESULT get_SignificantOthers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactSignificantOther_t **")] IVector<IntPtr>** value);

        [VtblIndex(18)]
        HRESULT get_Websites([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactWebsite_t **")] IVector<IntPtr>** value);

        [VtblIndex(19)]
        HRESULT get_ProviderProperties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value);
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

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Notes;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Notes;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactPhone_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_Phones;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactEmail_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_Emails;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactAddress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_Addresses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactConnectedServiceAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_ConnectedServiceAccounts;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactDate_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_ImportantDates;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_DataSuppliers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactJobInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_JobInfo;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactSignificantOther_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_SignificantOthers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CContacts__CContactWebsite_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_Websites;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet**, int> get_ProviderProperties;
    }
}
