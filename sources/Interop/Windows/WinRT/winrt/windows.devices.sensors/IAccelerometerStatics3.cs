// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAccelerometerStatics3.xml' path='doc/member[@name="IAccelerometerStatics3"]/*' />
[Guid("9DE218CF-455D-4CF3-8200-70E1410340F8")]
[NativeTypeName("struct IAccelerometerStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAccelerometerStatics3 : IAccelerometerStatics3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAccelerometerStatics3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerStatics3*, Guid*, void**, int>)(lpVtbl[0]))((IAccelerometerStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerStatics3*, uint>)(lpVtbl[1]))((IAccelerometerStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerStatics3*, uint>)(lpVtbl[2]))((IAccelerometerStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((IAccelerometerStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerStatics3*, HSTRING*, int>)(lpVtbl[4]))((IAccelerometerStatics3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerStatics3*, TrustLevel*, int>)(lpVtbl[5]))((IAccelerometerStatics3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAccelerometerStatics3.xml' path='doc/member[@name="IAccelerometerStatics3.FromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CAccelerometer_t **")] IAsyncOperation<Pointer<IAccelerometer>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerStatics3*, HSTRING, IAsyncOperation<Pointer<IAccelerometer>>**, int>)(lpVtbl[6]))((IAccelerometerStatics3*)Unsafe.AsPointer(ref this), deviceId, operation);
    }

    /// <include file='IAccelerometerStatics3.xml' path='doc/member[@name="IAccelerometerStatics3.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelector([NativeTypeName("ABI::Windows::Devices::Sensors::AccelerometerReadingType")] AccelerometerReadingType readingType, HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerStatics3*, AccelerometerReadingType, HSTRING*, int>)(lpVtbl[7]))((IAccelerometerStatics3*)Unsafe.AsPointer(ref this), readingType, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CAccelerometer_t **")] IAsyncOperation<Pointer<IAccelerometer>>** operation);

        [VtblIndex(7)]
        HRESULT GetDeviceSelector([NativeTypeName("ABI::Windows::Devices::Sensors::AccelerometerReadingType")] AccelerometerReadingType readingType, HSTRING* result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CAccelerometer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IAccelerometer>>**, int> FromIdAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::AccelerometerReadingType, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AccelerometerReadingType, HSTRING*, int> GetDeviceSelector;
    }
}
