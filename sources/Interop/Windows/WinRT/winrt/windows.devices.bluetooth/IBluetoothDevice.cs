// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothDevice.xml' path='doc/member[@name="IBluetoothDevice"]/*' />
[Guid("2335B156-90D2-4A04-AEF5-0E20B9E6B707")]
[NativeTypeName("struct IBluetoothDevice : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothDevice : IBluetoothDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothDevice));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, uint>)(lpVtbl[1]))((IBluetoothDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, uint>)(lpVtbl[2]))((IBluetoothDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothDevice.xml' path='doc/member[@name="IBluetoothDevice.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, HSTRING*, int>)(lpVtbl[6]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothDevice.xml' path='doc/member[@name="IBluetoothDevice.get_HostName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_HostName([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, IHostName**, int>)(lpVtbl[7]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothDevice.xml' path='doc/member[@name="IBluetoothDevice.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, HSTRING*, int>)(lpVtbl[8]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothDevice.xml' path='doc/member[@name="IBluetoothDevice.get_ClassOfDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ClassOfDevice([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothClassOfDevice **")] IBluetoothClassOfDevice** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, IBluetoothClassOfDevice**, int>)(lpVtbl[9]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothDevice.xml' path='doc/member[@name="IBluetoothDevice.get_SdpRecords"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SdpRecords([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CStorage__CStreams__CIBuffer_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, IVectorView<IntPtr>**, int>)(lpVtbl[10]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothDevice.xml' path='doc/member[@name="IBluetoothDevice.get_RfcommServices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("Use GetRfcommServicesAsync instead of RfcommServices.  For more info, see MSDN.")]
    public HRESULT get_RfcommServices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceService_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, IVectorView<IntPtr>**, int>)(lpVtbl[11]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothDevice.xml' path='doc/member[@name="IBluetoothDevice.get_ConnectionStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ConnectionStatus([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothConnectionStatus *")] BluetoothConnectionStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, BluetoothConnectionStatus*, int>)(lpVtbl[12]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothDevice.xml' path='doc/member[@name="IBluetoothDevice.get_BluetoothAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_BluetoothAddress([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, ulong*, int>)(lpVtbl[13]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothDevice.xml' path='doc/member[@name="IBluetoothDevice.add_NameChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_NameChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothDevice_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBluetoothDevice.xml' path='doc/member[@name="IBluetoothDevice.remove_NameChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_NameChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, EventRegistrationToken, int>)(lpVtbl[15]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IBluetoothDevice.xml' path='doc/member[@name="IBluetoothDevice.add_SdpRecordsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_SdpRecordsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothDevice_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[16]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBluetoothDevice.xml' path='doc/member[@name="IBluetoothDevice.remove_SdpRecordsChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_SdpRecordsChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, EventRegistrationToken, int>)(lpVtbl[17]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IBluetoothDevice.xml' path='doc/member[@name="IBluetoothDevice.add_ConnectionStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT add_ConnectionStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothDevice_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[18]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBluetoothDevice.xml' path='doc/member[@name="IBluetoothDevice.remove_ConnectionStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT remove_ConnectionStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothDevice*, EventRegistrationToken, int>)(lpVtbl[19]))((IBluetoothDevice*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_HostName([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value);

        [VtblIndex(8)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_ClassOfDevice([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothClassOfDevice **")] IBluetoothClassOfDevice** value);

        [VtblIndex(10)]
        HRESULT get_SdpRecords([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CStorage__CStreams__CIBuffer_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(11)]
        [Obsolete("Use GetRfcommServicesAsync instead of RfcommServices.  For more info, see MSDN.")]
        HRESULT get_RfcommServices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceService_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(12)]
        HRESULT get_ConnectionStatus([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothConnectionStatus *")] BluetoothConnectionStatus* value);

        [VtblIndex(13)]
        HRESULT get_BluetoothAddress([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(14)]
        HRESULT add_NameChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothDevice_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_NameChanged(EventRegistrationToken token);

        [VtblIndex(16)]
        HRESULT add_SdpRecordsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothDevice_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(17)]
        HRESULT remove_SdpRecordsChanged(EventRegistrationToken token);

        [VtblIndex(18)]
        HRESULT add_ConnectionStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothDevice_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(19)]
        HRESULT remove_ConnectionStatusChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName**, int> get_HostName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothClassOfDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothClassOfDevice**, int> get_ClassOfDevice;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> get_SdpRecords;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CRfcomm__CRfcommDeviceService_t **) __attribute__((stdcall))")]
        [Obsolete("Use GetRfcommServicesAsync instead of RfcommServices.  For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> get_RfcommServices;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothConnectionStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothConnectionStatus*, int> get_ConnectionStatus;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_BluetoothAddress;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothDevice_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_NameChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_NameChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothDevice_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_SdpRecordsChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SdpRecordsChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothDevice_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_ConnectionStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ConnectionStatusChanged;
    }
}
