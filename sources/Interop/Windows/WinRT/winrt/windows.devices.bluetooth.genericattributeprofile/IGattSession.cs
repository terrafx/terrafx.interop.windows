// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattSession.xml' path='doc/member[@name="IGattSession"]/*' />
[Guid("D23B5143-E04E-4C24-999C-9C256F9856B1")]
[NativeTypeName("struct IGattSession : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattSession : IGattSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattSession));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattSession*, Guid*, void**, int>)(lpVtbl[0]))((IGattSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattSession*, uint>)(lpVtbl[1]))((IGattSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattSession*, uint>)(lpVtbl[2]))((IGattSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattSession*, uint*, Guid**, int>)(lpVtbl[3]))((IGattSession*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattSession*, HSTRING*, int>)(lpVtbl[4]))((IGattSession*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattSession*, TrustLevel*, int>)(lpVtbl[5]))((IGattSession*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattSession.xml' path='doc/member[@name="IGattSession.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId **")] IBluetoothDeviceId** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattSession*, IBluetoothDeviceId**, int>)(lpVtbl[6]))((IGattSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattSession.xml' path='doc/member[@name="IGattSession.get_CanMaintainConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CanMaintainConnection([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattSession*, byte*, int>)(lpVtbl[7]))((IGattSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattSession.xml' path='doc/member[@name="IGattSession.put_MaintainConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_MaintainConnection([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattSession*, byte, int>)(lpVtbl[8]))((IGattSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattSession.xml' path='doc/member[@name="IGattSession.get_MaintainConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MaintainConnection([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattSession*, byte*, int>)(lpVtbl[9]))((IGattSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattSession.xml' path='doc/member[@name="IGattSession.get_MaxPduSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MaxPduSize([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattSession*, ushort*, int>)(lpVtbl[10]))((IGattSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattSession.xml' path='doc/member[@name="IGattSession.get_SessionStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SessionStatus([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSessionStatus *")] GattSessionStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattSession*, GattSessionStatus*, int>)(lpVtbl[11]))((IGattSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattSession.xml' path='doc/member[@name="IGattSession.add_MaxPduSizeChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_MaxPduSizeChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattSession_IInspectable_t *")] ITypedEventHandler<Pointer<IGattSession>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattSession*, ITypedEventHandler<Pointer<IGattSession>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IGattSession*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGattSession.xml' path='doc/member[@name="IGattSession.remove_MaxPduSizeChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_MaxPduSizeChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattSession*, EventRegistrationToken, int>)(lpVtbl[13]))((IGattSession*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGattSession.xml' path='doc/member[@name="IGattSession.add_SessionStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_SessionStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattSession_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattSessionStatusChangedEventArgs_t *")] ITypedEventHandler<Pointer<IGattSession>, Pointer<IGattSessionStatusChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattSession*, ITypedEventHandler<Pointer<IGattSession>, Pointer<IGattSessionStatusChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IGattSession*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGattSession.xml' path='doc/member[@name="IGattSession.remove_SessionStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_SessionStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattSession*, EventRegistrationToken, int>)(lpVtbl[15]))((IGattSession*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId **")] IBluetoothDeviceId** value);

        [VtblIndex(7)]
        HRESULT get_CanMaintainConnection([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT put_MaintainConnection([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT get_MaintainConnection([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_MaxPduSize([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(11)]
        HRESULT get_SessionStatus([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSessionStatus *")] GattSessionStatus* value);

        [VtblIndex(12)]
        HRESULT add_MaxPduSizeChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattSession_IInspectable_t *")] ITypedEventHandler<Pointer<IGattSession>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_MaxPduSizeChanged(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT add_SessionStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattSession_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattSessionStatusChangedEventArgs_t *")] ITypedEventHandler<Pointer<IGattSession>, Pointer<IGattSessionStatusChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_SessionStatusChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothDeviceId **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothDeviceId**, int> get_DeviceId;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanMaintainConnection;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_MaintainConnection;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_MaintainConnection;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_MaxPduSize;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattSessionStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattSessionStatus*, int> get_SessionStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattSession_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGattSession>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_MaxPduSizeChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MaxPduSizeChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattSession_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattSessionStatusChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGattSession>, Pointer<IGattSessionStatusChangedEventArgs>>*, EventRegistrationToken*, int> add_SessionStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SessionStatusChanged;
    }
}
