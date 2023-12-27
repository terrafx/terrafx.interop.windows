// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProximitySensor.xml' path='doc/member[@name="IProximitySensor"]/*' />
[Guid("54C076B8-ECFB-4944-B928-74FC504D47EE")]
[NativeTypeName("struct IProximitySensor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProximitySensor : IProximitySensor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProximitySensor));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensor*, Guid*, void**, int>)(lpVtbl[0]))((IProximitySensor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensor*, uint>)(lpVtbl[1]))((IProximitySensor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensor*, uint>)(lpVtbl[2]))((IProximitySensor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensor*, uint*, Guid**, int>)(lpVtbl[3]))((IProximitySensor*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensor*, HSTRING*, int>)(lpVtbl[4]))((IProximitySensor*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensor*, TrustLevel*, int>)(lpVtbl[5]))((IProximitySensor*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProximitySensor.xml' path='doc/member[@name="IProximitySensor.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensor*, HSTRING*, int>)(lpVtbl[6]))((IProximitySensor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProximitySensor.xml' path='doc/member[@name="IProximitySensor.get_MaxDistanceInMillimeters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MaxDistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensor*, IReference<uint>**, int>)(lpVtbl[7]))((IProximitySensor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProximitySensor.xml' path='doc/member[@name="IProximitySensor.get_MinDistanceInMillimeters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MinDistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensor*, IReference<uint>**, int>)(lpVtbl[8]))((IProximitySensor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProximitySensor.xml' path='doc/member[@name="IProximitySensor.GetCurrentReading"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCurrentReading([NativeTypeName("ABI::Windows::Devices::Sensors::IProximitySensorReading **")] IProximitySensorReading** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensor*, IProximitySensorReading**, int>)(lpVtbl[9]))((IProximitySensor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProximitySensor.xml' path='doc/member[@name="IProximitySensor.add_ReadingChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ReadingChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CProximitySensor_Windows__CDevices__CSensors__CProximitySensorReadingChangedEventArgs_t *")] ITypedEventHandler<Pointer<IProximitySensor>, Pointer<IProximitySensorReadingChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensor*, ITypedEventHandler<Pointer<IProximitySensor>, Pointer<IProximitySensorReadingChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IProximitySensor*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IProximitySensor.xml' path='doc/member[@name="IProximitySensor.remove_ReadingChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ReadingChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensor*, EventRegistrationToken, int>)(lpVtbl[11]))((IProximitySensor*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IProximitySensor.xml' path='doc/member[@name="IProximitySensor.CreateDisplayOnOffController"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateDisplayOnOffController([NativeTypeName("ABI::Windows::Foundation::IClosable **")] IClosable** controller)
    {
        return ((delegate* unmanaged[MemberFunction]<IProximitySensor*, IClosable**, int>)(lpVtbl[12]))((IProximitySensor*)Unsafe.AsPointer(ref this), controller);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_MaxDistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(8)]
        HRESULT get_MinDistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(9)]
        HRESULT GetCurrentReading([NativeTypeName("ABI::Windows::Devices::Sensors::IProximitySensorReading **")] IProximitySensorReading** value);

        [VtblIndex(10)]
        HRESULT add_ReadingChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CProximitySensor_Windows__CDevices__CSensors__CProximitySensorReadingChangedEventArgs_t *")] ITypedEventHandler<Pointer<IProximitySensor>, Pointer<IProximitySensorReadingChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_ReadingChanged(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT CreateDisplayOnOffController([NativeTypeName("ABI::Windows::Foundation::IClosable **")] IClosable** controller);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_MaxDistanceInMillimeters;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_MinDistanceInMillimeters;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::IProximitySensorReading **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IProximitySensorReading**, int> GetCurrentReading;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CProximitySensor_Windows__CDevices__CSensors__CProximitySensorReadingChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IProximitySensor>, Pointer<IProximitySensorReadingChangedEventArgs>>*, EventRegistrationToken*, int> add_ReadingChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ReadingChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IClosable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IClosable**, int> CreateDisplayOnOffController;
    }
}
