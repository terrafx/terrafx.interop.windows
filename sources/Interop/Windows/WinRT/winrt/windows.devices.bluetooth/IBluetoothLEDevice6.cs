// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEDevice6.xml' path='doc/member[@name="IBluetoothLEDevice6"]/*' />
[Guid("CA7190EF-0CAE-573C-A1CA-E1FC5BFC39E2")]
[NativeTypeName("struct IBluetoothLEDevice6 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEDevice6 : IBluetoothLEDevice6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBluetoothLEDevice6);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice6*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEDevice6*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice6*, uint>)(lpVtbl[1]))((IBluetoothLEDevice6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice6*, uint>)(lpVtbl[2]))((IBluetoothLEDevice6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice6*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEDevice6*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice6*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEDevice6*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice6*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEDevice6*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEDevice6.xml' path='doc/member[@name="IBluetoothLEDevice6.GetConnectionParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetConnectionParameters([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionParameters **")] IBluetoothLEConnectionParameters** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice6*, IBluetoothLEConnectionParameters**, int>)(lpVtbl[6]))((IBluetoothLEDevice6*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IBluetoothLEDevice6.xml' path='doc/member[@name="IBluetoothLEDevice6.GetConnectionPhy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetConnectionPhy([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionPhy **")] IBluetoothLEConnectionPhy** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice6*, IBluetoothLEConnectionPhy**, int>)(lpVtbl[7]))((IBluetoothLEDevice6*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IBluetoothLEDevice6.xml' path='doc/member[@name="IBluetoothLEDevice6.RequestPreferredConnectionParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestPreferredConnectionParameters([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEPreferredConnectionParameters *")] IBluetoothLEPreferredConnectionParameters* preferredConnectionParameters, [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEPreferredConnectionParametersRequest **")] IBluetoothLEPreferredConnectionParametersRequest** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice6*, IBluetoothLEPreferredConnectionParameters*, IBluetoothLEPreferredConnectionParametersRequest**, int>)(lpVtbl[8]))((IBluetoothLEDevice6*)Unsafe.AsPointer(ref this), preferredConnectionParameters, result);
    }

    /// <include file='IBluetoothLEDevice6.xml' path='doc/member[@name="IBluetoothLEDevice6.add_ConnectionParametersChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_ConnectionParametersChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *")] ITypedEventHandler<Pointer<IBluetoothLEDevice>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice6*, ITypedEventHandler<Pointer<IBluetoothLEDevice>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IBluetoothLEDevice6*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBluetoothLEDevice6.xml' path='doc/member[@name="IBluetoothLEDevice6.remove_ConnectionParametersChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_ConnectionParametersChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice6*, EventRegistrationToken, int>)(lpVtbl[10]))((IBluetoothLEDevice6*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IBluetoothLEDevice6.xml' path='doc/member[@name="IBluetoothLEDevice6.add_ConnectionPhyChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_ConnectionPhyChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *")] ITypedEventHandler<Pointer<IBluetoothLEDevice>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice6*, ITypedEventHandler<Pointer<IBluetoothLEDevice>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IBluetoothLEDevice6*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBluetoothLEDevice6.xml' path='doc/member[@name="IBluetoothLEDevice6.remove_ConnectionPhyChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_ConnectionPhyChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEDevice6*, EventRegistrationToken, int>)(lpVtbl[12]))((IBluetoothLEDevice6*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetConnectionParameters([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionParameters **")] IBluetoothLEConnectionParameters** result);

        [VtblIndex(7)]
        HRESULT GetConnectionPhy([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionPhy **")] IBluetoothLEConnectionPhy** result);

        [VtblIndex(8)]
        HRESULT RequestPreferredConnectionParameters([NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEPreferredConnectionParameters *")] IBluetoothLEPreferredConnectionParameters* preferredConnectionParameters, [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEPreferredConnectionParametersRequest **")] IBluetoothLEPreferredConnectionParametersRequest** result);

        [VtblIndex(9)]
        HRESULT add_ConnectionParametersChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *")] ITypedEventHandler<Pointer<IBluetoothLEDevice>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_ConnectionParametersChanged(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_ConnectionPhyChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *")] ITypedEventHandler<Pointer<IBluetoothLEDevice>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_ConnectionPhyChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionParameters **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEConnectionParameters**, int> GetConnectionParameters;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothLEConnectionPhy **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEConnectionPhy**, int> GetConnectionPhy;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::IBluetoothLEPreferredConnectionParameters *, ABI::Windows::Devices::Bluetooth::IBluetoothLEPreferredConnectionParametersRequest **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEPreferredConnectionParameters*, IBluetoothLEPreferredConnectionParametersRequest**, int> RequestPreferredConnectionParameters;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IBluetoothLEDevice>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_ConnectionParametersChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ConnectionParametersChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CBluetoothLEDevice_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IBluetoothLEDevice>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_ConnectionPhyChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ConnectionPhyChanged;
    }
}
