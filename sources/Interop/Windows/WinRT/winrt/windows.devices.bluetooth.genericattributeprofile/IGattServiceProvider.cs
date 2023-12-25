// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattServiceProvider.xml' path='doc/member[@name="IGattServiceProvider"]/*' />
[Guid("7822B3CD-2889-4F86-A051-3F0AED1C2760")]
[NativeTypeName("struct IGattServiceProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattServiceProvider : IGattServiceProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattServiceProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProvider*, Guid*, void**, int>)(lpVtbl[0]))((IGattServiceProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProvider*, uint>)(lpVtbl[1]))((IGattServiceProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProvider*, uint>)(lpVtbl[2]))((IGattServiceProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProvider*, uint*, Guid**, int>)(lpVtbl[3]))((IGattServiceProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProvider*, HSTRING*, int>)(lpVtbl[4]))((IGattServiceProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProvider*, TrustLevel*, int>)(lpVtbl[5]))((IGattServiceProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattServiceProvider.xml' path='doc/member[@name="IGattServiceProvider.get_Service"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Service([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalService **")] IGattLocalService** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProvider*, IGattLocalService**, int>)(lpVtbl[6]))((IGattServiceProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceProvider.xml' path='doc/member[@name="IGattServiceProvider.get_AdvertisementStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AdvertisementStatus([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattServiceProviderAdvertisementStatus *")] GattServiceProviderAdvertisementStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProvider*, GattServiceProviderAdvertisementStatus*, int>)(lpVtbl[7]))((IGattServiceProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceProvider.xml' path='doc/member[@name="IGattServiceProvider.add_AdvertisementStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_AdvertisementStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattServiceProvider_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattServiceProviderAdvertisementStatusChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProvider*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IGattServiceProvider*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGattServiceProvider.xml' path='doc/member[@name="IGattServiceProvider.remove_AdvertisementStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_AdvertisementStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProvider*, EventRegistrationToken, int>)(lpVtbl[9]))((IGattServiceProvider*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGattServiceProvider.xml' path='doc/member[@name="IGattServiceProvider.StartAdvertising"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StartAdvertising()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProvider*, int>)(lpVtbl[10]))((IGattServiceProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGattServiceProvider.xml' path='doc/member[@name="IGattServiceProvider.StartAdvertisingWithParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT StartAdvertisingWithParameters([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProviderAdvertisingParameters *")] IGattServiceProviderAdvertisingParameters* parameters)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProvider*, IGattServiceProviderAdvertisingParameters*, int>)(lpVtbl[11]))((IGattServiceProvider*)Unsafe.AsPointer(ref this), parameters);
    }

    /// <include file='IGattServiceProvider.xml' path='doc/member[@name="IGattServiceProvider.StopAdvertising"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT StopAdvertising()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProvider*, int>)(lpVtbl[12]))((IGattServiceProvider*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Service([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalService **")] IGattLocalService** value);

        [VtblIndex(7)]
        HRESULT get_AdvertisementStatus([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattServiceProviderAdvertisementStatus *")] GattServiceProviderAdvertisementStatus* value);

        [VtblIndex(8)]
        HRESULT add_AdvertisementStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattServiceProvider_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattServiceProviderAdvertisementStatusChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_AdvertisementStatusChanged(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT StartAdvertising();

        [VtblIndex(11)]
        HRESULT StartAdvertisingWithParameters([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProviderAdvertisingParameters *")] IGattServiceProviderAdvertisingParameters* parameters);

        [VtblIndex(12)]
        HRESULT StopAdvertising();
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalService **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGattLocalService**, int> get_Service;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattServiceProviderAdvertisementStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattServiceProviderAdvertisementStatus*, int> get_AdvertisementStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattServiceProvider_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattServiceProviderAdvertisementStatusChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_AdvertisementStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AdvertisementStatusChanged;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> StartAdvertising;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProviderAdvertisingParameters *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGattServiceProviderAdvertisingParameters*, int> StartAdvertisingWithParameters;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> StopAdvertising;
    }
}
