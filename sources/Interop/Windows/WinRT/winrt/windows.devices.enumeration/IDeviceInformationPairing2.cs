// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceInformationPairing2.xml' path='doc/member[@name="IDeviceInformationPairing2"]/*' />
[Guid("F68612FD-0AEE-4328-85CC-1C742BB1790D")]
[NativeTypeName("struct IDeviceInformationPairing2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceInformationPairing2 : IDeviceInformationPairing2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDeviceInformationPairing2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairing2*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceInformationPairing2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairing2*, uint>)(lpVtbl[1]))((IDeviceInformationPairing2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairing2*, uint>)(lpVtbl[2]))((IDeviceInformationPairing2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairing2*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceInformationPairing2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairing2*, HSTRING*, int>)(lpVtbl[4]))((IDeviceInformationPairing2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairing2*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceInformationPairing2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceInformationPairing2.xml' path='doc/member[@name="IDeviceInformationPairing2.get_ProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProtectionLevel([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel *")] DevicePairingProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairing2*, DevicePairingProtectionLevel*, int>)(lpVtbl[6]))((IDeviceInformationPairing2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDeviceInformationPairing2.xml' path='doc/member[@name="IDeviceInformationPairing2.get_Custom"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Custom([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformationCustomPairing **")] IDeviceInformationCustomPairing** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairing2*, IDeviceInformationCustomPairing**, int>)(lpVtbl[7]))((IDeviceInformationPairing2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDeviceInformationPairing2.xml' path='doc/member[@name="IDeviceInformationPairing2.PairWithProtectionLevelAndSettingsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT PairWithProtectionLevelAndSettingsAsync([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel")] DevicePairingProtectionLevel minProtectionLevel, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePairingSettings *")] IDevicePairingSettings* devicePairingSettings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **")] IAsyncOperation<Pointer<IDevicePairingResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairing2*, DevicePairingProtectionLevel, IDevicePairingSettings*, IAsyncOperation<Pointer<IDevicePairingResult>>**, int>)(lpVtbl[8]))((IDeviceInformationPairing2*)Unsafe.AsPointer(ref this), minProtectionLevel, devicePairingSettings, result);
    }

    /// <include file='IDeviceInformationPairing2.xml' path='doc/member[@name="IDeviceInformationPairing2.UnpairAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UnpairAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceUnpairingResult_t **")] IAsyncOperation<Pointer<IDeviceUnpairingResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationPairing2*, IAsyncOperation<Pointer<IDeviceUnpairingResult>>**, int>)(lpVtbl[9]))((IDeviceInformationPairing2*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProtectionLevel([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel *")] DevicePairingProtectionLevel* value);

        [VtblIndex(7)]
        HRESULT get_Custom([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformationCustomPairing **")] IDeviceInformationCustomPairing** value);

        [VtblIndex(8)]
        HRESULT PairWithProtectionLevelAndSettingsAsync([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel")] DevicePairingProtectionLevel minProtectionLevel, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePairingSettings *")] IDevicePairingSettings* devicePairingSettings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **")] IAsyncOperation<Pointer<IDevicePairingResult>>** result);

        [VtblIndex(9)]
        HRESULT UnpairAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceUnpairingResult_t **")] IAsyncOperation<Pointer<IDeviceUnpairingResult>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DevicePairingProtectionLevel*, int> get_ProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformationCustomPairing **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceInformationCustomPairing**, int> get_Custom;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel, ABI::Windows::Devices::Enumeration::IDevicePairingSettings *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DevicePairingProtectionLevel, IDevicePairingSettings*, IAsyncOperation<Pointer<IDevicePairingResult>>**, int> PairWithProtectionLevelAndSettingsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDeviceUnpairingResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IDeviceUnpairingResult>>**, int> UnpairAsync;
    }
}
