// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceInformationPairingStatics2.xml' path='doc/member[@name="IDeviceInformationPairingStatics2"]/*' />
[Guid("04DE5372-B7B7-476B-A74F-C5836A704D98")]
[NativeTypeName("struct IDeviceInformationPairingStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceInformationPairingStatics2 : IDeviceInformationPairingStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceInformationPairingStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairingStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceInformationPairingStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairingStatics2*, uint>)(lpVtbl[1]))((IDeviceInformationPairingStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairingStatics2*, uint>)(lpVtbl[2]))((IDeviceInformationPairingStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairingStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceInformationPairingStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairingStatics2*, HSTRING*, int>)(lpVtbl[4]))((IDeviceInformationPairingStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairingStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceInformationPairingStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceInformationPairingStatics2.xml' path='doc/member[@name="IDeviceInformationPairingStatics2.TryRegisterForAllInboundPairingRequestsWithProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryRegisterForAllInboundPairingRequestsWithProtectionLevel([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingKinds")] DevicePairingKinds pairingKindsSupported, [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel")] DevicePairingProtectionLevel minProtectionLevel, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairingStatics2*, DevicePairingKinds, DevicePairingProtectionLevel, byte*, int>)(lpVtbl[6]))((IDeviceInformationPairingStatics2*)Unsafe.AsPointer(ref this), pairingKindsSupported, minProtectionLevel, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryRegisterForAllInboundPairingRequestsWithProtectionLevel([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingKinds")] DevicePairingKinds pairingKindsSupported, [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel")] DevicePairingProtectionLevel minProtectionLevel, [NativeTypeName("boolean *")] byte* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::DevicePairingKinds, ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DevicePairingKinds, DevicePairingProtectionLevel, byte*, int> TryRegisterForAllInboundPairingRequestsWithProtectionLevel;
    }
}
