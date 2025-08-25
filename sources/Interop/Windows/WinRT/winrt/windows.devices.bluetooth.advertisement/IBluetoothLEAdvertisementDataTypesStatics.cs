// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics"]/*' />
[Guid("3BB6472F-0606-434B-A76E-74159F0684D3")]
[NativeTypeName("struct IBluetoothLEAdvertisementDataTypesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementDataTypesStatics : IBluetoothLEAdvertisementDataTypesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBluetoothLEAdvertisementDataTypesStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, uint>)(lpVtbl[1]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, uint>)(lpVtbl[2]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_Flags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Flags(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[6]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_IncompleteService16BitUuids"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IncompleteService16BitUuids(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[7]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_CompleteService16BitUuids"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CompleteService16BitUuids(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[8]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_IncompleteService32BitUuids"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IncompleteService32BitUuids(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[9]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_CompleteService32BitUuids"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CompleteService32BitUuids(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[10]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_IncompleteService128BitUuids"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IncompleteService128BitUuids(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[11]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_CompleteService128BitUuids"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CompleteService128BitUuids(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[12]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_ShortenedLocalName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ShortenedLocalName(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[13]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_CompleteLocalName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_CompleteLocalName(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[14]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_TxPowerLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_TxPowerLevel(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[15]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_PeripheralConnectionIntervalRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_PeripheralConnectionIntervalRange(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[16]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_ServiceSolicitation16BitUuids"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ServiceSolicitation16BitUuids(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[17]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_ServiceSolicitation32BitUuids"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_ServiceSolicitation32BitUuids(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[18]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_ServiceSolicitation128BitUuids"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_ServiceSolicitation128BitUuids(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[19]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_ServiceData16BitUuids"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_ServiceData16BitUuids(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[20]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_ServiceData32BitUuids"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_ServiceData32BitUuids(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[21]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_ServiceData128BitUuids"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_ServiceData128BitUuids(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[22]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_PublicTargetAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_PublicTargetAddress(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[23]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_RandomTargetAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_RandomTargetAddress(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[24]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_Appearance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_Appearance(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[25]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_AdvertisingInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_AdvertisingInterval(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[26]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataTypesStatics.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataTypesStatics.get_ManufacturerSpecificData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_ManufacturerSpecificData(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataTypesStatics*, byte*, int>)(lpVtbl[27]))((IBluetoothLEAdvertisementDataTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Flags(byte* value);

        [VtblIndex(7)]
        HRESULT get_IncompleteService16BitUuids(byte* value);

        [VtblIndex(8)]
        HRESULT get_CompleteService16BitUuids(byte* value);

        [VtblIndex(9)]
        HRESULT get_IncompleteService32BitUuids(byte* value);

        [VtblIndex(10)]
        HRESULT get_CompleteService32BitUuids(byte* value);

        [VtblIndex(11)]
        HRESULT get_IncompleteService128BitUuids(byte* value);

        [VtblIndex(12)]
        HRESULT get_CompleteService128BitUuids(byte* value);

        [VtblIndex(13)]
        HRESULT get_ShortenedLocalName(byte* value);

        [VtblIndex(14)]
        HRESULT get_CompleteLocalName(byte* value);

        [VtblIndex(15)]
        HRESULT get_TxPowerLevel(byte* value);

        [VtblIndex(16)]
        HRESULT get_PeripheralConnectionIntervalRange(byte* value);

        [VtblIndex(17)]
        HRESULT get_ServiceSolicitation16BitUuids(byte* value);

        [VtblIndex(18)]
        HRESULT get_ServiceSolicitation32BitUuids(byte* value);

        [VtblIndex(19)]
        HRESULT get_ServiceSolicitation128BitUuids(byte* value);

        [VtblIndex(20)]
        HRESULT get_ServiceData16BitUuids(byte* value);

        [VtblIndex(21)]
        HRESULT get_ServiceData32BitUuids(byte* value);

        [VtblIndex(22)]
        HRESULT get_ServiceData128BitUuids(byte* value);

        [VtblIndex(23)]
        HRESULT get_PublicTargetAddress(byte* value);

        [VtblIndex(24)]
        HRESULT get_RandomTargetAddress(byte* value);

        [VtblIndex(25)]
        HRESULT get_Appearance(byte* value);

        [VtblIndex(26)]
        HRESULT get_AdvertisingInterval(byte* value);

        [VtblIndex(27)]
        HRESULT get_ManufacturerSpecificData(byte* value);
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

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Flags;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IncompleteService16BitUuids;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CompleteService16BitUuids;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IncompleteService32BitUuids;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CompleteService32BitUuids;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IncompleteService128BitUuids;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CompleteService128BitUuids;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ShortenedLocalName;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CompleteLocalName;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_TxPowerLevel;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_PeripheralConnectionIntervalRange;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ServiceSolicitation16BitUuids;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ServiceSolicitation32BitUuids;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ServiceSolicitation128BitUuids;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ServiceData16BitUuids;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ServiceData32BitUuids;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ServiceData128BitUuids;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_PublicTargetAddress;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_RandomTargetAddress;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Appearance;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AdvertisingInterval;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ManufacturerSpecificData;
    }
}
