// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAdvertisementPublisher2.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher2"]/*' />
[Guid("FBDB545E-56F1-510F-A434-217FBD9E7BD2")]
[NativeTypeName("struct IBluetoothLEAdvertisementPublisher2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementPublisher2 : IBluetoothLEAdvertisementPublisher2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAdvertisementPublisher2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher2*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAdvertisementPublisher2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher2*, uint>)(lpVtbl[1]))((IBluetoothLEAdvertisementPublisher2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher2*, uint>)(lpVtbl[2]))((IBluetoothLEAdvertisementPublisher2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher2*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAdvertisementPublisher2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher2*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAdvertisementPublisher2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher2*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAdvertisementPublisher2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAdvertisementPublisher2.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher2.get_PreferredTransmitPowerLevelInDBm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PreferredTransmitPowerLevelInDBm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_short_t **")] IReference<short>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher2*, IReference<short>**, int>)(lpVtbl[6]))((IBluetoothLEAdvertisementPublisher2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementPublisher2.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher2.put_PreferredTransmitPowerLevelInDBm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_PreferredTransmitPowerLevelInDBm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_short_t *")] IReference<short>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher2*, IReference<short>*, int>)(lpVtbl[7]))((IBluetoothLEAdvertisementPublisher2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementPublisher2.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher2.get_UseExtendedAdvertisement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_UseExtendedAdvertisement([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher2*, byte*, int>)(lpVtbl[8]))((IBluetoothLEAdvertisementPublisher2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementPublisher2.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher2.put_UseExtendedAdvertisement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_UseExtendedAdvertisement([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher2*, byte, int>)(lpVtbl[9]))((IBluetoothLEAdvertisementPublisher2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementPublisher2.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher2.get_IsAnonymous"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsAnonymous([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher2*, byte*, int>)(lpVtbl[10]))((IBluetoothLEAdvertisementPublisher2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementPublisher2.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher2.put_IsAnonymous"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_IsAnonymous([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher2*, byte, int>)(lpVtbl[11]))((IBluetoothLEAdvertisementPublisher2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementPublisher2.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher2.get_IncludeTransmitPowerLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IncludeTransmitPowerLevel([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher2*, byte*, int>)(lpVtbl[12]))((IBluetoothLEAdvertisementPublisher2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementPublisher2.xml' path='doc/member[@name="IBluetoothLEAdvertisementPublisher2.put_IncludeTransmitPowerLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_IncludeTransmitPowerLevel([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementPublisher2*, byte, int>)(lpVtbl[13]))((IBluetoothLEAdvertisementPublisher2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PreferredTransmitPowerLevelInDBm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_short_t **")] IReference<short>** value);

        [VtblIndex(7)]
        HRESULT put_PreferredTransmitPowerLevelInDBm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_short_t *")] IReference<short>* value);

        [VtblIndex(8)]
        HRESULT get_UseExtendedAdvertisement([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_UseExtendedAdvertisement([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_IsAnonymous([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_IsAnonymous([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_IncludeTransmitPowerLevel([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_IncludeTransmitPowerLevel([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_short_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<short>**, int> get_PreferredTransmitPowerLevelInDBm;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_short_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<short>*, int> put_PreferredTransmitPowerLevelInDBm;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UseExtendedAdvertisement;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_UseExtendedAdvertisement;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAnonymous;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsAnonymous;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IncludeTransmitPowerLevel;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IncludeTransmitPowerLevel;
    }
}
