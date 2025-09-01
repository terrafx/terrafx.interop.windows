// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceInformationCustomPairing2.xml' path='doc/member[@name="IDeviceInformationCustomPairing2"]/*' />
[Guid("0EBDA662-E696-5FA9-8F72-80CFEBCD851D")]
[NativeTypeName("struct IDeviceInformationCustomPairing2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceInformationCustomPairing2 : IDeviceInformationCustomPairing2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDeviceInformationCustomPairing2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing2*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceInformationCustomPairing2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing2*, uint>)(lpVtbl[1]))((IDeviceInformationCustomPairing2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing2*, uint>)(lpVtbl[2]))((IDeviceInformationCustomPairing2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing2*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceInformationCustomPairing2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing2*, HSTRING*, int>)(lpVtbl[4]))((IDeviceInformationCustomPairing2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing2*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceInformationCustomPairing2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceInformationCustomPairing2.xml' path='doc/member[@name="IDeviceInformationCustomPairing2.AddPairingSetMember"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddPairingSetMember([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")] IDeviceInformation* device)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing2*, IDeviceInformation*, int>)(lpVtbl[6]))((IDeviceInformationCustomPairing2*)Unsafe.AsPointer(ref this), device);
    }

    /// <include file='IDeviceInformationCustomPairing2.xml' path='doc/member[@name="IDeviceInformationCustomPairing2.add_PairingSetMembersRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_PairingSetMembersRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDeviceInformationCustomPairing_Windows__CDevices__CEnumeration__CDevicePairingSetMembersRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IDeviceInformationCustomPairing>, Pointer<IDevicePairingSetMembersRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing2*, ITypedEventHandler<Pointer<IDeviceInformationCustomPairing>, Pointer<IDevicePairingSetMembersRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IDeviceInformationCustomPairing2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDeviceInformationCustomPairing2.xml' path='doc/member[@name="IDeviceInformationCustomPairing2.remove_PairingSetMembersRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_PairingSetMembersRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing2*, EventRegistrationToken, int>)(lpVtbl[8]))((IDeviceInformationCustomPairing2*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddPairingSetMember([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")] IDeviceInformation* device);

        [VtblIndex(7)]
        HRESULT add_PairingSetMembersRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDeviceInformationCustomPairing_Windows__CDevices__CEnumeration__CDevicePairingSetMembersRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IDeviceInformationCustomPairing>, Pointer<IDevicePairingSetMembersRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_PairingSetMembersRequested(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceInformation*, int> AddPairingSetMember;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDeviceInformationCustomPairing_Windows__CDevices__CEnumeration__CDevicePairingSetMembersRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDeviceInformationCustomPairing>, Pointer<IDevicePairingSetMembersRequestedEventArgs>>*, EventRegistrationToken*, int> add_PairingSetMembersRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PairingSetMembersRequested;
    }
}
