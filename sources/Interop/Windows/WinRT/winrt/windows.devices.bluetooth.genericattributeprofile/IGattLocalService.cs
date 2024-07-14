// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattLocalService.xml' path='doc/member[@name="IGattLocalService"]/*' />
[Guid("F513E258-F7F7-4902-B803-57FCC7D6FE83")]
[NativeTypeName("struct IGattLocalService : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattLocalService : IGattLocalService.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattLocalService));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalService*, Guid*, void**, int>)(lpVtbl[0]))((IGattLocalService*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalService*, uint>)(lpVtbl[1]))((IGattLocalService*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalService*, uint>)(lpVtbl[2]))((IGattLocalService*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalService*, uint*, Guid**, int>)(lpVtbl[3]))((IGattLocalService*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalService*, HSTRING*, int>)(lpVtbl[4]))((IGattLocalService*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalService*, TrustLevel*, int>)(lpVtbl[5]))((IGattLocalService*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattLocalService.xml' path='doc/member[@name="IGattLocalService.get_Uuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Uuid(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalService*, Guid*, int>)(lpVtbl[6]))((IGattLocalService*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalService.xml' path='doc/member[@name="IGattLocalService.CreateCharacteristicAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateCharacteristicAsync(Guid characteristicUuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalCharacteristicParameters *")] IGattLocalCharacteristicParameters* parameters, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalCharacteristicResult_t **")] IAsyncOperation<Pointer<IGattLocalCharacteristicResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalService*, Guid, IGattLocalCharacteristicParameters*, IAsyncOperation<Pointer<IGattLocalCharacteristicResult>>**, int>)(lpVtbl[7]))((IGattLocalService*)Unsafe.AsPointer(ref this), characteristicUuid, parameters, operation);
    }

    /// <include file='IGattLocalService.xml' path='doc/member[@name="IGattLocalService.get_Characteristics"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Characteristics([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalCharacteristic_t **")] IVectorView<Pointer<IGattLocalCharacteristic>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalService*, IVectorView<Pointer<IGattLocalCharacteristic>>**, int>)(lpVtbl[8]))((IGattLocalService*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Uuid(Guid* value);

        [VtblIndex(7)]
        HRESULT CreateCharacteristicAsync(Guid characteristicUuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalCharacteristicParameters *")] IGattLocalCharacteristicParameters* parameters, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalCharacteristicResult_t **")] IAsyncOperation<Pointer<IGattLocalCharacteristicResult>>** operation);

        [VtblIndex(8)]
        HRESULT get_Characteristics([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalCharacteristic_t **")] IVectorView<Pointer<IGattLocalCharacteristic>>** value);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_Uuid;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalCharacteristicParameters *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalCharacteristicResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, IGattLocalCharacteristicParameters*, IAsyncOperation<Pointer<IGattLocalCharacteristicResult>>**, int> CreateCharacteristicAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalCharacteristic_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IGattLocalCharacteristic>>**, int> get_Characteristics;
    }
}
