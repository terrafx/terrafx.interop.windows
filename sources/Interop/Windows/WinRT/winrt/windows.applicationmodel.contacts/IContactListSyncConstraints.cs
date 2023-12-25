// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints"]/*' />
[Guid("B2B0BF01-3062-4E2E-969D-018D1987F314")]
[NativeTypeName("struct IContactListSyncConstraints : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactListSyncConstraints : IContactListSyncConstraints.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactListSyncConstraints));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, Guid*, void**, int>)(lpVtbl[0]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, uint>)(lpVtbl[1]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, uint>)(lpVtbl[2]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, uint*, Guid**, int>)(lpVtbl[3]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, HSTRING*, int>)(lpVtbl[4]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, TrustLevel*, int>)(lpVtbl[5]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_CanSyncDescriptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CanSyncDescriptions([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, byte*, int>)(lpVtbl[6]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_CanSyncDescriptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CanSyncDescriptions([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, byte, int>)(lpVtbl[7]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxHomePhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxHomePhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[8]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxHomePhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_MaxHomePhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[9]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxMobilePhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MaxMobilePhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[10]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxMobilePhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_MaxMobilePhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[11]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxWorkPhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_MaxWorkPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[12]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxWorkPhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_MaxWorkPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[13]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxOtherPhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_MaxOtherPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[14]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxOtherPhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_MaxOtherPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[15]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxPagerPhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_MaxPagerPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[16]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxPagerPhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_MaxPagerPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[17]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxBusinessFaxPhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_MaxBusinessFaxPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[18]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxBusinessFaxPhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_MaxBusinessFaxPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[19]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxHomeFaxPhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_MaxHomeFaxPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[20]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxHomeFaxPhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_MaxHomeFaxPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[21]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxCompanyPhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_MaxCompanyPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[22]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxCompanyPhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_MaxCompanyPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[23]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxAssistantPhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_MaxAssistantPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[24]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxAssistantPhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_MaxAssistantPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[25]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxRadioPhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_MaxRadioPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[26]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxRadioPhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_MaxRadioPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[27]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxPersonalEmailAddresses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_MaxPersonalEmailAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[28]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxPersonalEmailAddresses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_MaxPersonalEmailAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[29]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxWorkEmailAddresses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_MaxWorkEmailAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[30]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxWorkEmailAddresses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_MaxWorkEmailAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[31]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxOtherEmailAddresses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_MaxOtherEmailAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[32]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxOtherEmailAddresses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_MaxOtherEmailAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[33]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxHomeAddresses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_MaxHomeAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[34]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxHomeAddresses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_MaxHomeAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[35]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxWorkAddresses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_MaxWorkAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[36]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxWorkAddresses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_MaxWorkAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[37]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxOtherAddresses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_MaxOtherAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[38]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxOtherAddresses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_MaxOtherAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[39]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxBirthdayDates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_MaxBirthdayDates([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[40]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxBirthdayDates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_MaxBirthdayDates([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[41]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxAnniversaryDates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_MaxAnniversaryDates([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[42]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxAnniversaryDates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_MaxAnniversaryDates([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[43]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxOtherDates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_MaxOtherDates([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[44]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxOtherDates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT put_MaxOtherDates([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[45]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxOtherRelationships"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_MaxOtherRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[46]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxOtherRelationships"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT put_MaxOtherRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[47]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxSpouseRelationships"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_MaxSpouseRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[48]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxSpouseRelationships"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT put_MaxSpouseRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[49]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxPartnerRelationships"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_MaxPartnerRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[50]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxPartnerRelationships"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT put_MaxPartnerRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[51]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxSiblingRelationships"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_MaxSiblingRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[52]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxSiblingRelationships"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT put_MaxSiblingRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[53]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxParentRelationships"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_MaxParentRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[54]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxParentRelationships"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT put_MaxParentRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[55]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxChildRelationships"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_MaxChildRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[56]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxChildRelationships"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT put_MaxChildRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[57]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxJobInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_MaxJobInfo([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[58]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxJobInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT put_MaxJobInfo([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[59]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.get_MaxWebsites"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_MaxWebsites([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>**, int>)(lpVtbl[60]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactListSyncConstraints.xml' path='doc/member[@name="IContactListSyncConstraints.put_MaxWebsites"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT put_MaxWebsites([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactListSyncConstraints*, IReference<int>*, int>)(lpVtbl[61]))((IContactListSyncConstraints*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CanSyncDescriptions([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_CanSyncDescriptions([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_MaxHomePhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(9)]
        HRESULT put_MaxHomePhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(10)]
        HRESULT get_MaxMobilePhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(11)]
        HRESULT put_MaxMobilePhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(12)]
        HRESULT get_MaxWorkPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(13)]
        HRESULT put_MaxWorkPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(14)]
        HRESULT get_MaxOtherPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(15)]
        HRESULT put_MaxOtherPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(16)]
        HRESULT get_MaxPagerPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(17)]
        HRESULT put_MaxPagerPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(18)]
        HRESULT get_MaxBusinessFaxPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(19)]
        HRESULT put_MaxBusinessFaxPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(20)]
        HRESULT get_MaxHomeFaxPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(21)]
        HRESULT put_MaxHomeFaxPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(22)]
        HRESULT get_MaxCompanyPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(23)]
        HRESULT put_MaxCompanyPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(24)]
        HRESULT get_MaxAssistantPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(25)]
        HRESULT put_MaxAssistantPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(26)]
        HRESULT get_MaxRadioPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(27)]
        HRESULT put_MaxRadioPhoneNumbers([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(28)]
        HRESULT get_MaxPersonalEmailAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(29)]
        HRESULT put_MaxPersonalEmailAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(30)]
        HRESULT get_MaxWorkEmailAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(31)]
        HRESULT put_MaxWorkEmailAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(32)]
        HRESULT get_MaxOtherEmailAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(33)]
        HRESULT put_MaxOtherEmailAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(34)]
        HRESULT get_MaxHomeAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(35)]
        HRESULT put_MaxHomeAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(36)]
        HRESULT get_MaxWorkAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(37)]
        HRESULT put_MaxWorkAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(38)]
        HRESULT get_MaxOtherAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(39)]
        HRESULT put_MaxOtherAddresses([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(40)]
        HRESULT get_MaxBirthdayDates([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(41)]
        HRESULT put_MaxBirthdayDates([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(42)]
        HRESULT get_MaxAnniversaryDates([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(43)]
        HRESULT put_MaxAnniversaryDates([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(44)]
        HRESULT get_MaxOtherDates([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(45)]
        HRESULT put_MaxOtherDates([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(46)]
        HRESULT get_MaxOtherRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(47)]
        HRESULT put_MaxOtherRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(48)]
        HRESULT get_MaxSpouseRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(49)]
        HRESULT put_MaxSpouseRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(50)]
        HRESULT get_MaxPartnerRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(51)]
        HRESULT put_MaxPartnerRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(52)]
        HRESULT get_MaxSiblingRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(53)]
        HRESULT put_MaxSiblingRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(54)]
        HRESULT get_MaxParentRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(55)]
        HRESULT put_MaxParentRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(56)]
        HRESULT get_MaxChildRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(57)]
        HRESULT put_MaxChildRelationships([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(58)]
        HRESULT get_MaxJobInfo([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(59)]
        HRESULT put_MaxJobInfo([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);

        [VtblIndex(60)]
        HRESULT get_MaxWebsites([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(61)]
        HRESULT put_MaxWebsites([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t *")] IReference<int>* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanSyncDescriptions;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanSyncDescriptions;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxHomePhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxHomePhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxMobilePhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxMobilePhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxWorkPhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxWorkPhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxOtherPhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxOtherPhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxPagerPhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxPagerPhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxBusinessFaxPhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxBusinessFaxPhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxHomeFaxPhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxHomeFaxPhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxCompanyPhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxCompanyPhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxAssistantPhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxAssistantPhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxRadioPhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxRadioPhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxPersonalEmailAddresses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxPersonalEmailAddresses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxWorkEmailAddresses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxWorkEmailAddresses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxOtherEmailAddresses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxOtherEmailAddresses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxHomeAddresses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxHomeAddresses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxWorkAddresses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxWorkAddresses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxOtherAddresses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxOtherAddresses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxBirthdayDates;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxBirthdayDates;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxAnniversaryDates;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxAnniversaryDates;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxOtherDates;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxOtherDates;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxOtherRelationships;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxOtherRelationships;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxSpouseRelationships;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxSpouseRelationships;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxPartnerRelationships;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxPartnerRelationships;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxSiblingRelationships;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxSiblingRelationships;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxParentRelationships;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxParentRelationships;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxChildRelationships;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxChildRelationships;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxJobInfo;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxJobInfo;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_MaxWebsites;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>*, int> put_MaxWebsites;
    }
}
