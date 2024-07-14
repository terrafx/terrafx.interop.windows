// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHingeAngleSensorStatics.xml' path='doc/member[@name="IHingeAngleSensorStatics"]/*' />
[Guid("B7B63910-FBB1-4123-89CE-4EA34EB0DFCA")]
[NativeTypeName("struct IHingeAngleSensorStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHingeAngleSensorStatics : IHingeAngleSensorStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHingeAngleSensorStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensorStatics*, Guid*, void**, int>)(lpVtbl[0]))((IHingeAngleSensorStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensorStatics*, uint>)(lpVtbl[1]))((IHingeAngleSensorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensorStatics*, uint>)(lpVtbl[2]))((IHingeAngleSensorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensorStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IHingeAngleSensorStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensorStatics*, HSTRING*, int>)(lpVtbl[4]))((IHingeAngleSensorStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensorStatics*, TrustLevel*, int>)(lpVtbl[5]))((IHingeAngleSensorStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHingeAngleSensorStatics.xml' path='doc/member[@name="IHingeAngleSensorStatics.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceSelector(HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensorStatics*, HSTRING*, int>)(lpVtbl[6]))((IHingeAngleSensorStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IHingeAngleSensorStatics.xml' path='doc/member[@name="IHingeAngleSensorStatics.GetDefaultAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDefaultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHingeAngleSensor_t **")] IAsyncOperation<Pointer<IHingeAngleSensor>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensorStatics*, IAsyncOperation<Pointer<IHingeAngleSensor>>**, int>)(lpVtbl[7]))((IHingeAngleSensorStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IHingeAngleSensorStatics.xml' path='doc/member[@name="IHingeAngleSensorStatics.GetRelatedToAdjacentPanelsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetRelatedToAdjacentPanelsAsync(HSTRING firstPanelId, HSTRING secondPanelId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHingeAngleSensor_t **")] IAsyncOperation<Pointer<IHingeAngleSensor>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensorStatics*, HSTRING, HSTRING, IAsyncOperation<Pointer<IHingeAngleSensor>>**, int>)(lpVtbl[8]))((IHingeAngleSensorStatics*)Unsafe.AsPointer(ref this), firstPanelId, secondPanelId, result);
    }

    /// <include file='IHingeAngleSensorStatics.xml' path='doc/member[@name="IHingeAngleSensorStatics.FromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHingeAngleSensor_t **")] IAsyncOperation<Pointer<IHingeAngleSensor>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHingeAngleSensorStatics*, HSTRING, IAsyncOperation<Pointer<IHingeAngleSensor>>**, int>)(lpVtbl[9]))((IHingeAngleSensorStatics*)Unsafe.AsPointer(ref this), deviceId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceSelector(HSTRING* result);

        [VtblIndex(7)]
        HRESULT GetDefaultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHingeAngleSensor_t **")] IAsyncOperation<Pointer<IHingeAngleSensor>>** result);

        [VtblIndex(8)]
        HRESULT GetRelatedToAdjacentPanelsAsync(HSTRING firstPanelId, HSTRING secondPanelId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHingeAngleSensor_t **")] IAsyncOperation<Pointer<IHingeAngleSensor>>** result);

        [VtblIndex(9)]
        HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHingeAngleSensor_t **")] IAsyncOperation<Pointer<IHingeAngleSensor>>** result);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetDeviceSelector;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHingeAngleSensor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IHingeAngleSensor>>**, int> GetDefaultAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHingeAngleSensor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<Pointer<IHingeAngleSensor>>**, int> GetRelatedToAdjacentPanelsAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSensors__CHingeAngleSensor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IHingeAngleSensor>>**, int> FromIdAsync;
    }
}
