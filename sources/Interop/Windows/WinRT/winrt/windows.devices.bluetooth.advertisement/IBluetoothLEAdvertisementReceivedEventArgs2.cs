// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAdvertisementReceivedEventArgs2.xml' path='doc/member[@name="IBluetoothLEAdvertisementReceivedEventArgs2"]/*' />
[Guid("12D9C87B-0399-5F0E-A348-53B02B6B162E")]
[NativeTypeName("struct IBluetoothLEAdvertisementReceivedEventArgs2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementReceivedEventArgs2 : IBluetoothLEAdvertisementReceivedEventArgs2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAdvertisementReceivedEventArgs2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs2*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAdvertisementReceivedEventArgs2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs2*, uint>)(lpVtbl[1]))((IBluetoothLEAdvertisementReceivedEventArgs2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs2*, uint>)(lpVtbl[2]))((IBluetoothLEAdvertisementReceivedEventArgs2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs2*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAdvertisementReceivedEventArgs2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs2*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAdvertisementReceivedEventArgs2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs2*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAdvertisementReceivedEventArgs2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAdvertisementReceivedEventArgs2.xml' path='doc/member[@name="IBluetoothLEAdvertisementReceivedEventArgs2.get_BluetoothAddressType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BluetoothAddressType([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothAddressType *")] BluetoothAddressType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs2*, BluetoothAddressType*, int>)(lpVtbl[6]))((IBluetoothLEAdvertisementReceivedEventArgs2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementReceivedEventArgs2.xml' path='doc/member[@name="IBluetoothLEAdvertisementReceivedEventArgs2.get_TransmitPowerLevelInDBm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TransmitPowerLevelInDBm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_short_t **")] IReference<short>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs2*, IReference<short>**, int>)(lpVtbl[7]))((IBluetoothLEAdvertisementReceivedEventArgs2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementReceivedEventArgs2.xml' path='doc/member[@name="IBluetoothLEAdvertisementReceivedEventArgs2.get_IsAnonymous"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsAnonymous([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs2*, byte*, int>)(lpVtbl[8]))((IBluetoothLEAdvertisementReceivedEventArgs2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementReceivedEventArgs2.xml' path='doc/member[@name="IBluetoothLEAdvertisementReceivedEventArgs2.get_IsConnectable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsConnectable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs2*, byte*, int>)(lpVtbl[9]))((IBluetoothLEAdvertisementReceivedEventArgs2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementReceivedEventArgs2.xml' path='doc/member[@name="IBluetoothLEAdvertisementReceivedEventArgs2.get_IsScannable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsScannable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs2*, byte*, int>)(lpVtbl[10]))((IBluetoothLEAdvertisementReceivedEventArgs2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementReceivedEventArgs2.xml' path='doc/member[@name="IBluetoothLEAdvertisementReceivedEventArgs2.get_IsDirected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsDirected([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs2*, byte*, int>)(lpVtbl[11]))((IBluetoothLEAdvertisementReceivedEventArgs2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementReceivedEventArgs2.xml' path='doc/member[@name="IBluetoothLEAdvertisementReceivedEventArgs2.get_IsScanResponse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsScanResponse([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementReceivedEventArgs2*, byte*, int>)(lpVtbl[12]))((IBluetoothLEAdvertisementReceivedEventArgs2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BluetoothAddressType([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothAddressType *")] BluetoothAddressType* value);

        [VtblIndex(7)]
        HRESULT get_TransmitPowerLevelInDBm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_short_t **")] IReference<short>** value);

        [VtblIndex(8)]
        HRESULT get_IsAnonymous([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_IsConnectable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_IsScannable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_IsDirected([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT get_IsScanResponse([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothAddressType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothAddressType*, int> get_BluetoothAddressType;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_short_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<short>**, int> get_TransmitPowerLevelInDBm;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAnonymous;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsConnectable;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsScannable;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsDirected;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsScanResponse;
    }
}
