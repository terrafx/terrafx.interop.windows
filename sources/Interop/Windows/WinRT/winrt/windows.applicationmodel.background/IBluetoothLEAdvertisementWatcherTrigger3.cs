// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAdvertisementWatcherTrigger3.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTrigger3"]/*' />
[Guid("DA50011A-8261-56A0-AC7B-A8DE1624088B")]
[NativeTypeName("struct IBluetoothLEAdvertisementWatcherTrigger3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementWatcherTrigger3 : IBluetoothLEAdvertisementWatcherTrigger3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBluetoothLEAdvertisementWatcherTrigger3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger3*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAdvertisementWatcherTrigger3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger3*, uint>)(lpVtbl[1]))((IBluetoothLEAdvertisementWatcherTrigger3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger3*, uint>)(lpVtbl[2]))((IBluetoothLEAdvertisementWatcherTrigger3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger3*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAdvertisementWatcherTrigger3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger3*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAdvertisementWatcherTrigger3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger3*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAdvertisementWatcherTrigger3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTrigger3.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTrigger3.get_UseUncoded1MPhy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_UseUncoded1MPhy([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger3*, byte*, int>)(lpVtbl[6]))((IBluetoothLEAdvertisementWatcherTrigger3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTrigger3.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTrigger3.put_UseUncoded1MPhy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_UseUncoded1MPhy([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger3*, byte, int>)(lpVtbl[7]))((IBluetoothLEAdvertisementWatcherTrigger3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTrigger3.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTrigger3.get_UseCodedPhy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_UseCodedPhy([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger3*, byte*, int>)(lpVtbl[8]))((IBluetoothLEAdvertisementWatcherTrigger3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTrigger3.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTrigger3.put_UseCodedPhy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_UseCodedPhy([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger3*, byte, int>)(lpVtbl[9]))((IBluetoothLEAdvertisementWatcherTrigger3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTrigger3.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTrigger3.get_ScanParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ScanParameters([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementScanParameters **")] IBluetoothLEAdvertisementScanParameters** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger3*, IBluetoothLEAdvertisementScanParameters**, int>)(lpVtbl[10]))((IBluetoothLEAdvertisementWatcherTrigger3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementWatcherTrigger3.xml' path='doc/member[@name="IBluetoothLEAdvertisementWatcherTrigger3.put_ScanParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ScanParameters([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementScanParameters *")] IBluetoothLEAdvertisementScanParameters* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementWatcherTrigger3*, IBluetoothLEAdvertisementScanParameters*, int>)(lpVtbl[11]))((IBluetoothLEAdvertisementWatcherTrigger3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_UseUncoded1MPhy([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_UseUncoded1MPhy([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_UseCodedPhy([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_UseCodedPhy([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_ScanParameters([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementScanParameters **")] IBluetoothLEAdvertisementScanParameters** value);

        [VtblIndex(11)]
        HRESULT put_ScanParameters([NativeTypeName("ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementScanParameters *")] IBluetoothLEAdvertisementScanParameters* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UseUncoded1MPhy;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_UseUncoded1MPhy;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UseCodedPhy;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_UseCodedPhy;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementScanParameters **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEAdvertisementScanParameters**, int> get_ScanParameters;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Advertisement::IBluetoothLEAdvertisementScanParameters *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBluetoothLEAdvertisementScanParameters*, int> put_ScanParameters;
    }
}
