// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattDeviceService2.xml' path='doc/member[@name="IGattDeviceService2"]/*' />
[Guid("FC54520B-0B0D-4708-BAE0-9FFD9489BC59")]
[NativeTypeName("struct IGattDeviceService2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattDeviceService2 : IGattDeviceService2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattDeviceService2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService2*, Guid*, void**, int>)(lpVtbl[0]))((IGattDeviceService2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService2*, uint>)(lpVtbl[1]))((IGattDeviceService2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService2*, uint>)(lpVtbl[2]))((IGattDeviceService2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService2*, uint*, Guid**, int>)(lpVtbl[3]))((IGattDeviceService2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService2*, HSTRING*, int>)(lpVtbl[4]))((IGattDeviceService2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService2*, TrustLevel*, int>)(lpVtbl[5]))((IGattDeviceService2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattDeviceService2.xml' path='doc/member[@name="IGattDeviceService2.get_Device"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Use Session instead of Device property.  For more information, see MSDN.")]
    public HRESULT get_Device([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEDevice **")] IBluetoothLEDevice** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService2*, IBluetoothLEDevice**, int>)(lpVtbl[6]))((IGattDeviceService2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDeviceService2.xml' path='doc/member[@name="IGattDeviceService2.get_ParentServices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("ParentServices may be altered or unavailable in future releases.  For more information, see MSDN.")]
    public HRESULT get_ParentServices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **")] IVectorView<Pointer<IGattDeviceService>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService2*, IVectorView<Pointer<IGattDeviceService>>**, int>)(lpVtbl[7]))((IGattDeviceService2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDeviceService2.xml' path='doc/member[@name="IGattDeviceService2.GetAllCharacteristics"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Use GetCharacteristicsAsync instead of GetAllCharacteristics.  For more information, see MSDN.")]
    public HRESULT GetAllCharacteristics([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_t **")] IVectorView<Pointer<IGattCharacteristic>>** characteristics)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService2*, IVectorView<Pointer<IGattCharacteristic>>**, int>)(lpVtbl[8]))((IGattDeviceService2*)Unsafe.AsPointer(ref this), characteristics);
    }

    /// <include file='IGattDeviceService2.xml' path='doc/member[@name="IGattDeviceService2.GetAllIncludedServices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("Use GetIncludedServicesAsync instead of GetAllIncludedServices.  For more information, see MSDN.")]
    public HRESULT GetAllIncludedServices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **")] IVectorView<Pointer<IGattDeviceService>>** includedServices)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService2*, IVectorView<Pointer<IGattDeviceService>>**, int>)(lpVtbl[9]))((IGattDeviceService2*)Unsafe.AsPointer(ref this), includedServices);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Use Session instead of Device property.  For more information, see MSDN.")]
        HRESULT get_Device([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEDevice **")] IBluetoothLEDevice** value);

        [VtblIndex(7)]
        [Obsolete("ParentServices may be altered or unavailable in future releases.  For more information, see MSDN.")]
        HRESULT get_ParentServices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **")] IVectorView<Pointer<IGattDeviceService>>** value);

        [VtblIndex(8)]
        [Obsolete("Use GetCharacteristicsAsync instead of GetAllCharacteristics.  For more information, see MSDN.")]
        HRESULT GetAllCharacteristics([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_t **")] IVectorView<Pointer<IGattCharacteristic>>** characteristics);

        [VtblIndex(9)]
        [Obsolete("Use GetIncludedServicesAsync instead of GetAllIncludedServices.  For more information, see MSDN.")]
        HRESULT GetAllIncludedServices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **")] IVectorView<Pointer<IGattDeviceService>>** includedServices);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothLEDevice **) __attribute__((stdcall))")]
        [Obsolete("Use Session instead of Device property.  For more information, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEDevice**, int> get_Device;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **) __attribute__((stdcall))")]
        [Obsolete("ParentServices may be altered or unavailable in future releases.  For more information, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IGattDeviceService>>**, int> get_ParentServices;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_t **) __attribute__((stdcall))")]
        [Obsolete("Use GetCharacteristicsAsync instead of GetAllCharacteristics.  For more information, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IGattCharacteristic>>**, int> GetAllCharacteristics;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **) __attribute__((stdcall))")]
        [Obsolete("Use GetIncludedServicesAsync instead of GetAllIncludedServices.  For more information, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IGattDeviceService>>**, int> GetAllIncludedServices;
    }
}
