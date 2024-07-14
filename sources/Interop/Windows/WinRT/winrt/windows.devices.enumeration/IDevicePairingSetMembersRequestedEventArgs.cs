// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDevicePairingSetMembersRequestedEventArgs.xml' path='doc/member[@name="IDevicePairingSetMembersRequestedEventArgs"]/*' />
[Guid("7FB42CFF-ECAC-5012-8D7D-A1894680A349")]
[NativeTypeName("struct IDevicePairingSetMembersRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDevicePairingSetMembersRequestedEventArgs : IDevicePairingSetMembersRequestedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDevicePairingSetMembersRequestedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingSetMembersRequestedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IDevicePairingSetMembersRequestedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingSetMembersRequestedEventArgs*, uint>)(lpVtbl[1]))((IDevicePairingSetMembersRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingSetMembersRequestedEventArgs*, uint>)(lpVtbl[2]))((IDevicePairingSetMembersRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingSetMembersRequestedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IDevicePairingSetMembersRequestedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingSetMembersRequestedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IDevicePairingSetMembersRequestedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingSetMembersRequestedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IDevicePairingSetMembersRequestedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDevicePairingSetMembersRequestedEventArgs.xml' path='doc/member[@name="IDevicePairingSetMembersRequestedEventArgs.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingAddPairingSetMemberStatus *")] DevicePairingAddPairingSetMemberStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingSetMembersRequestedEventArgs*, DevicePairingAddPairingSetMemberStatus*, int>)(lpVtbl[6]))((IDevicePairingSetMembersRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePairingSetMembersRequestedEventArgs.xml' path='doc/member[@name="IDevicePairingSetMembersRequestedEventArgs.get_ParentDeviceInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ParentDeviceInformation([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")] IDeviceInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingSetMembersRequestedEventArgs*, IDeviceInformation**, int>)(lpVtbl[7]))((IDevicePairingSetMembersRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePairingSetMembersRequestedEventArgs.xml' path='doc/member[@name="IDevicePairingSetMembersRequestedEventArgs.get_PairingSetMembers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PairingSetMembers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **")] IVectorView<Pointer<IDeviceInformation>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingSetMembersRequestedEventArgs*, IVectorView<Pointer<IDeviceInformation>>**, int>)(lpVtbl[8]))((IDevicePairingSetMembersRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingAddPairingSetMemberStatus *")] DevicePairingAddPairingSetMemberStatus* value);

        [VtblIndex(7)]
        HRESULT get_ParentDeviceInformation([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")] IDeviceInformation** value);

        [VtblIndex(8)]
        HRESULT get_PairingSetMembers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **")] IVectorView<Pointer<IDeviceInformation>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::DevicePairingAddPairingSetMemberStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DevicePairingAddPairingSetMemberStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceInformation**, int> get_ParentDeviceInformation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CEnumeration__CDeviceInformation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IDeviceInformation>>**, int> get_PairingSetMembers;
    }
}
