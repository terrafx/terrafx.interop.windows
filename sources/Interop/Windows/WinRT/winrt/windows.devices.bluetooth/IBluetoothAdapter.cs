// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothAdapter.xml' path='doc/member[@name="IBluetoothAdapter"]/*' />
[Guid("7974F04C-5F7A-4A34-9225-A855F84B1A8B")]
[NativeTypeName("struct IBluetoothAdapter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothAdapter : IBluetoothAdapter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBluetoothAdapter);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothAdapter*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothAdapter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothAdapter*, uint>)(lpVtbl[1]))((IBluetoothAdapter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothAdapter*, uint>)(lpVtbl[2]))((IBluetoothAdapter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothAdapter*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothAdapter*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothAdapter*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothAdapter*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothAdapter*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothAdapter*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothAdapter.xml' path='doc/member[@name="IBluetoothAdapter.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothAdapter*, HSTRING*, int>)(lpVtbl[6]))((IBluetoothAdapter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothAdapter.xml' path='doc/member[@name="IBluetoothAdapter.get_BluetoothAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BluetoothAddress([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothAdapter*, ulong*, int>)(lpVtbl[7]))((IBluetoothAdapter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothAdapter.xml' path='doc/member[@name="IBluetoothAdapter.get_IsClassicSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsClassicSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothAdapter*, byte*, int>)(lpVtbl[8]))((IBluetoothAdapter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothAdapter.xml' path='doc/member[@name="IBluetoothAdapter.get_IsLowEnergySupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsLowEnergySupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothAdapter*, byte*, int>)(lpVtbl[9]))((IBluetoothAdapter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothAdapter.xml' path='doc/member[@name="IBluetoothAdapter.get_IsPeripheralRoleSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsPeripheralRoleSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothAdapter*, byte*, int>)(lpVtbl[10]))((IBluetoothAdapter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothAdapter.xml' path='doc/member[@name="IBluetoothAdapter.get_IsCentralRoleSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsCentralRoleSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothAdapter*, byte*, int>)(lpVtbl[11]))((IBluetoothAdapter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothAdapter.xml' path='doc/member[@name="IBluetoothAdapter.get_IsAdvertisementOffloadSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsAdvertisementOffloadSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothAdapter*, byte*, int>)(lpVtbl[12]))((IBluetoothAdapter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothAdapter.xml' path='doc/member[@name="IBluetoothAdapter.GetRadioAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetRadioAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CRadios__CRadio_t **")] IAsyncOperation<Pointer<IRadio>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothAdapter*, IAsyncOperation<Pointer<IRadio>>**, int>)(lpVtbl[13]))((IBluetoothAdapter*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_BluetoothAddress([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(8)]
        HRESULT get_IsClassicSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_IsLowEnergySupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_IsPeripheralRoleSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_IsCentralRoleSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT get_IsAdvertisementOffloadSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT GetRadioAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CRadios__CRadio_t **")] IAsyncOperation<Pointer<IRadio>>** operation);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_BluetoothAddress;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsClassicSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsLowEnergySupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsPeripheralRoleSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCentralRoleSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAdvertisementOffloadSupported;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CRadios__CRadio_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IRadio>>**, int> GetRadioAsync;
    }
}
