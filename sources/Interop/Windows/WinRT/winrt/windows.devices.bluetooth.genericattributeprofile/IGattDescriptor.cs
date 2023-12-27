// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattDescriptor.xml' path='doc/member[@name="IGattDescriptor"]/*' />
[Guid("92055F2B-8084-4344-B4C2-284DE19A8506")]
[NativeTypeName("struct IGattDescriptor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattDescriptor : IGattDescriptor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattDescriptor));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptor*, Guid*, void**, int>)(lpVtbl[0]))((IGattDescriptor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptor*, uint>)(lpVtbl[1]))((IGattDescriptor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptor*, uint>)(lpVtbl[2]))((IGattDescriptor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptor*, uint*, Guid**, int>)(lpVtbl[3]))((IGattDescriptor*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptor*, HSTRING*, int>)(lpVtbl[4]))((IGattDescriptor*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptor*, TrustLevel*, int>)(lpVtbl[5]))((IGattDescriptor*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattDescriptor.xml' path='doc/member[@name="IGattDescriptor.get_ProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptor*, GattProtectionLevel*, int>)(lpVtbl[6]))((IGattDescriptor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDescriptor.xml' path='doc/member[@name="IGattDescriptor.put_ProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel")] GattProtectionLevel value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptor*, GattProtectionLevel, int>)(lpVtbl[7]))((IGattDescriptor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDescriptor.xml' path='doc/member[@name="IGattDescriptor.get_Uuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Uuid(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptor*, Guid*, int>)(lpVtbl[8]))((IGattDescriptor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDescriptor.xml' path='doc/member[@name="IGattDescriptor.get_AttributeHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AttributeHandle([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptor*, ushort*, int>)(lpVtbl[9]))((IGattDescriptor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDescriptor.xml' path='doc/member[@name="IGattDescriptor.ReadValueAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ReadValueAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **")] IAsyncOperation<Pointer<IGattReadResult>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptor*, IAsyncOperation<Pointer<IGattReadResult>>**, int>)(lpVtbl[10]))((IGattDescriptor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDescriptor.xml' path='doc/member[@name="IGattDescriptor.ReadValueWithCacheModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ReadValueWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **")] IAsyncOperation<Pointer<IGattReadResult>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptor*, BluetoothCacheMode, IAsyncOperation<Pointer<IGattReadResult>>**, int>)(lpVtbl[11]))((IGattDescriptor*)Unsafe.AsPointer(ref this), cacheMode, value);
    }

    /// <include file='IGattDescriptor.xml' path='doc/member[@name="IGattDescriptor.WriteValueAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT WriteValueAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **")] IAsyncOperation<GattCommunicationStatus>** action)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptor*, IBuffer*, IAsyncOperation<GattCommunicationStatus>**, int>)(lpVtbl[12]))((IGattDescriptor*)Unsafe.AsPointer(ref this), value, action);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value);

        [VtblIndex(7)]
        HRESULT put_ProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel")] GattProtectionLevel value);

        [VtblIndex(8)]
        HRESULT get_Uuid(Guid* value);

        [VtblIndex(9)]
        HRESULT get_AttributeHandle([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(10)]
        HRESULT ReadValueAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **")] IAsyncOperation<Pointer<IGattReadResult>>** value);

        [VtblIndex(11)]
        HRESULT ReadValueWithCacheModeAsync([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothCacheMode")] BluetoothCacheMode cacheMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **")] IAsyncOperation<Pointer<IGattReadResult>>** value);

        [VtblIndex(12)]
        HRESULT WriteValueAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **")] IAsyncOperation<GattCommunicationStatus>** action);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattProtectionLevel*, int> get_ProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattProtectionLevel, int> put_ProtectionLevel;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_Uuid;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_AttributeHandle;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IGattReadResult>>**, int> ReadValueAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothCacheMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothCacheMode, IAsyncOperation<Pointer<IGattReadResult>>**, int> ReadValueWithCacheModeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IAsyncOperation<GattCommunicationStatus>**, int> WriteValueAsync;
    }
}
