// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKnownContactFieldStatics.xml' path='doc/member[@name="IKnownContactFieldStatics"]/*' />
[Guid("2E0E1B12-D627-4FCA-BAD4-1FAF168C7D14")]
[NativeTypeName("struct IKnownContactFieldStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
public unsafe partial struct IKnownContactFieldStatics : IKnownContactFieldStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKnownContactFieldStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownContactFieldStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKnownContactFieldStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownContactFieldStatics*, uint>)(lpVtbl[1]))((IKnownContactFieldStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownContactFieldStatics*, uint>)(lpVtbl[2]))((IKnownContactFieldStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownContactFieldStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownContactFieldStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownContactFieldStatics*, HSTRING*, int>)(lpVtbl[4]))((IKnownContactFieldStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownContactFieldStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKnownContactFieldStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKnownContactFieldStatics.xml' path='doc/member[@name="IKnownContactFieldStatics.get_Email"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
    public HRESULT get_Email(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownContactFieldStatics*, HSTRING*, int>)(lpVtbl[6]))((IKnownContactFieldStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownContactFieldStatics.xml' path='doc/member[@name="IKnownContactFieldStatics.get_PhoneNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
    public HRESULT get_PhoneNumber(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownContactFieldStatics*, HSTRING*, int>)(lpVtbl[7]))((IKnownContactFieldStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownContactFieldStatics.xml' path='doc/member[@name="IKnownContactFieldStatics.get_Location"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
    public HRESULT get_Location(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownContactFieldStatics*, HSTRING*, int>)(lpVtbl[8]))((IKnownContactFieldStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownContactFieldStatics.xml' path='doc/member[@name="IKnownContactFieldStatics.get_InstantMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
    public HRESULT get_InstantMessage(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownContactFieldStatics*, HSTRING*, int>)(lpVtbl[9]))((IKnownContactFieldStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownContactFieldStatics.xml' path='doc/member[@name="IKnownContactFieldStatics.ConvertNameToType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
    public HRESULT ConvertNameToType(HSTRING name, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType *")] ContactFieldType* type)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownContactFieldStatics*, HSTRING, ContactFieldType*, int>)(lpVtbl[10]))((IKnownContactFieldStatics*)Unsafe.AsPointer(ref this), name, type);
    }

    /// <include file='IKnownContactFieldStatics.xml' path='doc/member[@name="IKnownContactFieldStatics.ConvertTypeToName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
    public HRESULT ConvertTypeToName([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType")] ContactFieldType type, HSTRING* name)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownContactFieldStatics*, ContactFieldType, HSTRING*, int>)(lpVtbl[11]))((IKnownContactFieldStatics*)Unsafe.AsPointer(ref this), type, name);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
        HRESULT get_Email(HSTRING* value);

        [VtblIndex(7)]
        [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
        HRESULT get_PhoneNumber(HSTRING* value);

        [VtblIndex(8)]
        [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
        HRESULT get_Location(HSTRING* value);

        [VtblIndex(9)]
        [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
        HRESULT get_InstantMessage(HSTRING* value);

        [VtblIndex(10)]
        [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
        HRESULT ConvertNameToType(HSTRING name, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType *")] ContactFieldType* type);

        [VtblIndex(11)]
        [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
        HRESULT ConvertTypeToName([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType")] ContactFieldType type, HSTRING* name);
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
        [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Email;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PhoneNumber;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Location;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_InstantMessage;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::ContactFieldType *) __attribute__((stdcall))")]
        [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ContactFieldType*, int> ConvertNameToType;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactFieldType, HSTRING *) __attribute__((stdcall))")]
        [Obsolete("IKnownContactFieldStatics may be altered or unavailable for releases after Windows 8.1. Instead, use ContactAddress, ContactPhone, ContactConnectedServiceAccount or ContactEmail.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactFieldType, HSTRING*, int> ConvertTypeToName;
    }
}
