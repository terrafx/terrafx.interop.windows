// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISimpleOrientationSensor.xml' path='doc/member[@name="ISimpleOrientationSensor"]/*' />
[Guid("5FF53856-214A-4DEE-A3F9-616F1AB06FFD")]
[NativeTypeName("struct ISimpleOrientationSensor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISimpleOrientationSensor : ISimpleOrientationSensor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISimpleOrientationSensor);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensor*, Guid*, void**, int>)(lpVtbl[0]))((ISimpleOrientationSensor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensor*, uint>)(lpVtbl[1]))((ISimpleOrientationSensor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensor*, uint>)(lpVtbl[2]))((ISimpleOrientationSensor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensor*, uint*, Guid**, int>)(lpVtbl[3]))((ISimpleOrientationSensor*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensor*, HSTRING*, int>)(lpVtbl[4]))((ISimpleOrientationSensor*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensor*, TrustLevel*, int>)(lpVtbl[5]))((ISimpleOrientationSensor*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISimpleOrientationSensor.xml' path='doc/member[@name="ISimpleOrientationSensor.GetCurrentOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentOrientation([NativeTypeName("ABI::Windows::Devices::Sensors::SimpleOrientation *")] SimpleOrientation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensor*, SimpleOrientation*, int>)(lpVtbl[6]))((ISimpleOrientationSensor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISimpleOrientationSensor.xml' path='doc/member[@name="ISimpleOrientationSensor.add_OrientationChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_OrientationChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CSimpleOrientationSensor_Windows__CDevices__CSensors__CSimpleOrientationSensorOrientationChangedEventArgs_t *")] ITypedEventHandler<Pointer<ISimpleOrientationSensor>, Pointer<ISimpleOrientationSensorOrientationChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensor*, ITypedEventHandler<Pointer<ISimpleOrientationSensor>, Pointer<ISimpleOrientationSensorOrientationChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((ISimpleOrientationSensor*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISimpleOrientationSensor.xml' path='doc/member[@name="ISimpleOrientationSensor.remove_OrientationChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_OrientationChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensor*, EventRegistrationToken, int>)(lpVtbl[8]))((ISimpleOrientationSensor*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCurrentOrientation([NativeTypeName("ABI::Windows::Devices::Sensors::SimpleOrientation *")] SimpleOrientation* value);

        [VtblIndex(7)]
        HRESULT add_OrientationChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CSimpleOrientationSensor_Windows__CDevices__CSensors__CSimpleOrientationSensorOrientationChangedEventArgs_t *")] ITypedEventHandler<Pointer<ISimpleOrientationSensor>, Pointer<ISimpleOrientationSensorOrientationChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_OrientationChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::SimpleOrientation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SimpleOrientation*, int> GetCurrentOrientation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CSimpleOrientationSensor_Windows__CDevices__CSensors__CSimpleOrientationSensorOrientationChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISimpleOrientationSensor>, Pointer<ISimpleOrientationSensorOrientationChangedEventArgs>>*, EventRegistrationToken*, int> add_OrientationChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_OrientationChanged;
    }
}
