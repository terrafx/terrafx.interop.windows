// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceInformationCustomPairing.xml' path='doc/member[@name="IDeviceInformationCustomPairing"]/*' />
[Guid("85138C02-4EE6-4914-8370-107A39144C0E")]
[NativeTypeName("struct IDeviceInformationCustomPairing : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceInformationCustomPairing : IDeviceInformationCustomPairing.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceInformationCustomPairing));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceInformationCustomPairing*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing*, uint>)(lpVtbl[1]))((IDeviceInformationCustomPairing*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing*, uint>)(lpVtbl[2]))((IDeviceInformationCustomPairing*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceInformationCustomPairing*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing*, HSTRING*, int>)(lpVtbl[4]))((IDeviceInformationCustomPairing*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceInformationCustomPairing*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceInformationCustomPairing.xml' path='doc/member[@name="IDeviceInformationCustomPairing.PairAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT PairAsync([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingKinds")] DevicePairingKinds pairingKindsSupported, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **")] IAsyncOperation<Pointer<IDevicePairingResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing*, DevicePairingKinds, IAsyncOperation<Pointer<IDevicePairingResult>>**, int>)(lpVtbl[6]))((IDeviceInformationCustomPairing*)Unsafe.AsPointer(ref this), pairingKindsSupported, result);
    }

    /// <include file='IDeviceInformationCustomPairing.xml' path='doc/member[@name="IDeviceInformationCustomPairing.PairWithProtectionLevelAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT PairWithProtectionLevelAsync([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingKinds")] DevicePairingKinds pairingKindsSupported, [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel")] DevicePairingProtectionLevel minProtectionLevel, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **")] IAsyncOperation<Pointer<IDevicePairingResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing*, DevicePairingKinds, DevicePairingProtectionLevel, IAsyncOperation<Pointer<IDevicePairingResult>>**, int>)(lpVtbl[7]))((IDeviceInformationCustomPairing*)Unsafe.AsPointer(ref this), pairingKindsSupported, minProtectionLevel, result);
    }

    /// <include file='IDeviceInformationCustomPairing.xml' path='doc/member[@name="IDeviceInformationCustomPairing.PairWithProtectionLevelAndSettingsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT PairWithProtectionLevelAndSettingsAsync([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingKinds")] DevicePairingKinds pairingKindsSupported, [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel")] DevicePairingProtectionLevel minProtectionLevel, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePairingSettings *")] IDevicePairingSettings* devicePairingSettings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **")] IAsyncOperation<Pointer<IDevicePairingResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing*, DevicePairingKinds, DevicePairingProtectionLevel, IDevicePairingSettings*, IAsyncOperation<Pointer<IDevicePairingResult>>**, int>)(lpVtbl[8]))((IDeviceInformationCustomPairing*)Unsafe.AsPointer(ref this), pairingKindsSupported, minProtectionLevel, devicePairingSettings, result);
    }

    /// <include file='IDeviceInformationCustomPairing.xml' path='doc/member[@name="IDeviceInformationCustomPairing.add_PairingRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_PairingRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDeviceInformationCustomPairing_Windows__CDevices__CEnumeration__CDevicePairingRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IDeviceInformationCustomPairing>, Pointer<IDevicePairingRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing*, ITypedEventHandler<Pointer<IDeviceInformationCustomPairing>, Pointer<IDevicePairingRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IDeviceInformationCustomPairing*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDeviceInformationCustomPairing.xml' path='doc/member[@name="IDeviceInformationCustomPairing.remove_PairingRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_PairingRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceInformationCustomPairing*, EventRegistrationToken, int>)(lpVtbl[10]))((IDeviceInformationCustomPairing*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT PairAsync([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingKinds")] DevicePairingKinds pairingKindsSupported, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **")] IAsyncOperation<Pointer<IDevicePairingResult>>** result);

        [VtblIndex(7)]
        HRESULT PairWithProtectionLevelAsync([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingKinds")] DevicePairingKinds pairingKindsSupported, [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel")] DevicePairingProtectionLevel minProtectionLevel, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **")] IAsyncOperation<Pointer<IDevicePairingResult>>** result);

        [VtblIndex(8)]
        HRESULT PairWithProtectionLevelAndSettingsAsync([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingKinds")] DevicePairingKinds pairingKindsSupported, [NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel")] DevicePairingProtectionLevel minProtectionLevel, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDevicePairingSettings *")] IDevicePairingSettings* devicePairingSettings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **")] IAsyncOperation<Pointer<IDevicePairingResult>>** result);

        [VtblIndex(9)]
        HRESULT add_PairingRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDeviceInformationCustomPairing_Windows__CDevices__CEnumeration__CDevicePairingRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IDeviceInformationCustomPairing>, Pointer<IDevicePairingRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_PairingRequested(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::DevicePairingKinds, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DevicePairingKinds, IAsyncOperation<Pointer<IDevicePairingResult>>**, int> PairAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::DevicePairingKinds, ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DevicePairingKinds, DevicePairingProtectionLevel, IAsyncOperation<Pointer<IDevicePairingResult>>**, int> PairWithProtectionLevelAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::DevicePairingKinds, ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel, ABI::Windows::Devices::Enumeration::IDevicePairingSettings *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CEnumeration__CDevicePairingResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DevicePairingKinds, DevicePairingProtectionLevel, IDevicePairingSettings*, IAsyncOperation<Pointer<IDevicePairingResult>>**, int> PairWithProtectionLevelAndSettingsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CEnumeration__CDeviceInformationCustomPairing_Windows__CDevices__CEnumeration__CDevicePairingRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDeviceInformationCustomPairing>, Pointer<IDevicePairingRequestedEventArgs>>*, EventRegistrationToken*, int> add_PairingRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PairingRequested;
    }
}
