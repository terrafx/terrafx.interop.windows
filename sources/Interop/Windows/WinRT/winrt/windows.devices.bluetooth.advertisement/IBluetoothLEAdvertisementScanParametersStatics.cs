// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAdvertisementScanParametersStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementScanParametersStatics"]/*' />
[Guid("548E39CD-3C9E-5F8D-B5E1-ADEBED5C357C")]
[NativeTypeName("struct IBluetoothLEAdvertisementScanParametersStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementScanParametersStatics : IBluetoothLEAdvertisementScanParametersStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBluetoothLEAdvertisementScanParametersStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementScanParametersStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAdvertisementScanParametersStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementScanParametersStatics*, uint>)(lpVtbl[1]))((IBluetoothLEAdvertisementScanParametersStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementScanParametersStatics*, uint>)(lpVtbl[2]))((IBluetoothLEAdvertisementScanParametersStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementScanParametersStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAdvertisementScanParametersStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementScanParametersStatics*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAdvertisementScanParametersStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementScanParametersStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAdvertisementScanParametersStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAdvertisementScanParametersStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementScanParametersStatics.CoexistenceOptimized"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CoexistenceOptimized([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementScanParameters **")] IBluetoothLEAdvertisementScanParameters** parameters)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementScanParametersStatics*, IBluetoothLEAdvertisementScanParameters**, int>)(lpVtbl[6]))((IBluetoothLEAdvertisementScanParametersStatics*)Unsafe.AsPointer(ref this), parameters);
    }

    /// <include file='IBluetoothLEAdvertisementScanParametersStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementScanParametersStatics.LowLatency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LowLatency([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementScanParameters **")] IBluetoothLEAdvertisementScanParameters** parameters)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementScanParametersStatics*, IBluetoothLEAdvertisementScanParameters**, int>)(lpVtbl[7]))((IBluetoothLEAdvertisementScanParametersStatics*)Unsafe.AsPointer(ref this), parameters);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CoexistenceOptimized([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementScanParameters **")] IBluetoothLEAdvertisementScanParameters** parameters);

        [VtblIndex(7)]
        HRESULT LowLatency([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementScanParameters **")] IBluetoothLEAdvertisementScanParameters** parameters);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementScanParameters **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEAdvertisementScanParameters**, int> CoexistenceOptimized;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementScanParameters **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEAdvertisementScanParameters**, int> LowLatency;
    }
}
