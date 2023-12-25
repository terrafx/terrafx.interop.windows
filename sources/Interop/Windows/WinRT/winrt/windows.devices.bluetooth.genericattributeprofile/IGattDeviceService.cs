// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattDeviceService.xml' path='doc/member[@name="IGattDeviceService"]/*' />
[Guid("AC7B7C05-B33C-47CF-990F-6B8F5577DF71")]
[NativeTypeName("struct IGattDeviceService : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattDeviceService : IGattDeviceService.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattDeviceService));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService*, Guid*, void**, int>)(lpVtbl[0]))((IGattDeviceService*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService*, uint>)(lpVtbl[1]))((IGattDeviceService*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService*, uint>)(lpVtbl[2]))((IGattDeviceService*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService*, uint*, Guid**, int>)(lpVtbl[3]))((IGattDeviceService*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService*, HSTRING*, int>)(lpVtbl[4]))((IGattDeviceService*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService*, TrustLevel*, int>)(lpVtbl[5]))((IGattDeviceService*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattDeviceService.xml' path='doc/member[@name="IGattDeviceService.GetCharacteristics"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Use GetCharacteristicsForUuidAsync instead of GetCharacteristics.  For more information, see MSDN.")]
    public HRESULT GetCharacteristics(Guid characteristicUuid, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService*, Guid, IVectorView<IntPtr>**, int>)(lpVtbl[6]))((IGattDeviceService*)Unsafe.AsPointer(ref this), characteristicUuid, value);
    }

    /// <include file='IGattDeviceService.xml' path='doc/member[@name="IGattDeviceService.GetIncludedServices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Use GetIncludedServicesForUuidAsync instead of GetIncludedServices.  For more information, see MSDN.")]
    public HRESULT GetIncludedServices(Guid serviceUuid, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService*, Guid, IVectorView<IntPtr>**, int>)(lpVtbl[7]))((IGattDeviceService*)Unsafe.AsPointer(ref this), serviceUuid, value);
    }

    /// <include file='IGattDeviceService.xml' path='doc/member[@name="IGattDeviceService.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService*, HSTRING*, int>)(lpVtbl[8]))((IGattDeviceService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDeviceService.xml' path='doc/member[@name="IGattDeviceService.get_Uuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Uuid(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService*, Guid*, int>)(lpVtbl[9]))((IGattDeviceService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDeviceService.xml' path='doc/member[@name="IGattDeviceService.get_AttributeHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AttributeHandle([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceService*, ushort*, int>)(lpVtbl[10]))((IGattDeviceService*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Use GetCharacteristicsForUuidAsync instead of GetCharacteristics.  For more information, see MSDN.")]
        HRESULT GetCharacteristics(Guid characteristicUuid, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(7)]
        [Obsolete("Use GetIncludedServicesForUuidAsync instead of GetIncludedServices.  For more information, see MSDN.")]
        HRESULT GetIncludedServices(Guid serviceUuid, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(8)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Uuid(Guid* value);

        [VtblIndex(10)]
        HRESULT get_AttributeHandle([NativeTypeName("UINT16 *")] ushort* value);
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

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCharacteristic_t **) __attribute__((stdcall))")]
        [Obsolete("Use GetCharacteristicsForUuidAsync instead of GetCharacteristics.  For more information, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, IVectorView<IntPtr>**, int> GetCharacteristics;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **) __attribute__((stdcall))")]
        [Obsolete("Use GetIncludedServicesForUuidAsync instead of GetIncludedServices.  For more information, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, IVectorView<IntPtr>**, int> GetIncludedServices;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_Uuid;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_AttributeHandle;
    }
}
