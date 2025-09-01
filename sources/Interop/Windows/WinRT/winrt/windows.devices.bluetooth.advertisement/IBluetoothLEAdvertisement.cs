// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAdvertisement.xml' path='doc/member[@name="IBluetoothLEAdvertisement"]/*' />
[Guid("066FB2B7-33D1-4E7D-8367-CF81D0F79653")]
[NativeTypeName("struct IBluetoothLEAdvertisement : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisement : IBluetoothLEAdvertisement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBluetoothLEAdvertisement);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisement*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAdvertisement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisement*, uint>)(lpVtbl[1]))((IBluetoothLEAdvertisement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisement*, uint>)(lpVtbl[2]))((IBluetoothLEAdvertisement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisement*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAdvertisement*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisement*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAdvertisement*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisement*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAdvertisement*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAdvertisement.xml' path='doc/member[@name="IBluetoothLEAdvertisement.get_Flags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Flags([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementFlags_t **")] IReference<BluetoothLEAdvertisementFlags>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisement*, IReference<BluetoothLEAdvertisementFlags>**, int>)(lpVtbl[6]))((IBluetoothLEAdvertisement*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisement.xml' path='doc/member[@name="IBluetoothLEAdvertisement.put_Flags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Flags([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementFlags_t *")] IReference<BluetoothLEAdvertisementFlags>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisement*, IReference<BluetoothLEAdvertisementFlags>*, int>)(lpVtbl[7]))((IBluetoothLEAdvertisement*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisement.xml' path='doc/member[@name="IBluetoothLEAdvertisement.get_LocalName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LocalName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisement*, HSTRING*, int>)(lpVtbl[8]))((IBluetoothLEAdvertisement*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisement.xml' path='doc/member[@name="IBluetoothLEAdvertisement.put_LocalName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_LocalName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisement*, HSTRING, int>)(lpVtbl[9]))((IBluetoothLEAdvertisement*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisement.xml' path='doc/member[@name="IBluetoothLEAdvertisement.get_ServiceUuids"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ServiceUuids([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_GUID_t **")] IVector<Guid>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisement*, IVector<Guid>**, int>)(lpVtbl[10]))((IBluetoothLEAdvertisement*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisement.xml' path='doc/member[@name="IBluetoothLEAdvertisement.get_ManufacturerData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ManufacturerData([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEManufacturerData_t **")] IVector<Pointer<IBluetoothLEManufacturerData>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisement*, IVector<Pointer<IBluetoothLEManufacturerData>>**, int>)(lpVtbl[11]))((IBluetoothLEAdvertisement*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisement.xml' path='doc/member[@name="IBluetoothLEAdvertisement.get_DataSections"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DataSections([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementDataSection_t **")] IVector<Pointer<IBluetoothLEAdvertisementDataSection>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisement*, IVector<Pointer<IBluetoothLEAdvertisementDataSection>>**, int>)(lpVtbl[12]))((IBluetoothLEAdvertisement*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisement.xml' path='doc/member[@name="IBluetoothLEAdvertisement.GetManufacturerDataByCompanyId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetManufacturerDataByCompanyId([NativeTypeName("UINT16")] ushort companyId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEManufacturerData_t **")] IVectorView<Pointer<IBluetoothLEManufacturerData>>** dataList)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisement*, ushort, IVectorView<Pointer<IBluetoothLEManufacturerData>>**, int>)(lpVtbl[13]))((IBluetoothLEAdvertisement*)Unsafe.AsPointer(ref this), companyId, dataList);
    }

    /// <include file='IBluetoothLEAdvertisement.xml' path='doc/member[@name="IBluetoothLEAdvertisement.GetSectionsByType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetSectionsByType(byte type, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementDataSection_t **")] IVectorView<Pointer<IBluetoothLEAdvertisementDataSection>>** sectionList)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisement*, byte, IVectorView<Pointer<IBluetoothLEAdvertisementDataSection>>**, int>)(lpVtbl[14]))((IBluetoothLEAdvertisement*)Unsafe.AsPointer(ref this), type, sectionList);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Flags([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementFlags_t **")] IReference<BluetoothLEAdvertisementFlags>** value);

        [VtblIndex(7)]
        HRESULT put_Flags([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementFlags_t *")] IReference<BluetoothLEAdvertisementFlags>* value);

        [VtblIndex(8)]
        HRESULT get_LocalName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_LocalName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_ServiceUuids([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_GUID_t **")] IVector<Guid>** value);

        [VtblIndex(11)]
        HRESULT get_ManufacturerData([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEManufacturerData_t **")] IVector<Pointer<IBluetoothLEManufacturerData>>** value);

        [VtblIndex(12)]
        HRESULT get_DataSections([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementDataSection_t **")] IVector<Pointer<IBluetoothLEAdvertisementDataSection>>** value);

        [VtblIndex(13)]
        HRESULT GetManufacturerDataByCompanyId([NativeTypeName("UINT16")] ushort companyId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEManufacturerData_t **")] IVectorView<Pointer<IBluetoothLEManufacturerData>>** dataList);

        [VtblIndex(14)]
        HRESULT GetSectionsByType(byte type, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementDataSection_t **")] IVectorView<Pointer<IBluetoothLEAdvertisementDataSection>>** sectionList);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementFlags_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<BluetoothLEAdvertisementFlags>**, int> get_Flags;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementFlags_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<BluetoothLEAdvertisementFlags>*, int> put_Flags;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_LocalName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_LocalName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_GUID_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Guid>**, int> get_ServiceUuids;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEManufacturerData_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IBluetoothLEManufacturerData>>**, int> get_ManufacturerData;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementDataSection_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IBluetoothLEAdvertisementDataSection>>**, int> get_DataSections;

        [NativeTypeName("HRESULT (UINT16, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEManufacturerData_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, IVectorView<Pointer<IBluetoothLEManufacturerData>>**, int> GetManufacturerDataByCompanyId;

        [NativeTypeName("HRESULT (BYTE, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CAdvertisement__CBluetoothLEAdvertisementDataSection_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, IVectorView<Pointer<IBluetoothLEAdvertisementDataSection>>**, int> GetSectionsByType;
    }
}
