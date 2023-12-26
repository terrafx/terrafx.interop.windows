// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.i2c.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProviderI2cConnectionSettings.xml' path='doc/member[@name="IProviderI2cConnectionSettings"]/*' />
[Guid("E9DB4E34-E510-44B7-809D-F2F85B555339")]
[NativeTypeName("struct IProviderI2cConnectionSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProviderI2cConnectionSettings : IProviderI2cConnectionSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProviderI2cConnectionSettings));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderI2cConnectionSettings*, Guid*, void**, int>)(lpVtbl[0]))((IProviderI2cConnectionSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderI2cConnectionSettings*, uint>)(lpVtbl[1]))((IProviderI2cConnectionSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderI2cConnectionSettings*, uint>)(lpVtbl[2]))((IProviderI2cConnectionSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderI2cConnectionSettings*, uint*, Guid**, int>)(lpVtbl[3]))((IProviderI2cConnectionSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderI2cConnectionSettings*, HSTRING*, int>)(lpVtbl[4]))((IProviderI2cConnectionSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderI2cConnectionSettings*, TrustLevel*, int>)(lpVtbl[5]))((IProviderI2cConnectionSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProviderI2cConnectionSettings.xml' path='doc/member[@name="IProviderI2cConnectionSettings.get_SlaveAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SlaveAddress([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderI2cConnectionSettings*, int*, int>)(lpVtbl[6]))((IProviderI2cConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProviderI2cConnectionSettings.xml' path='doc/member[@name="IProviderI2cConnectionSettings.put_SlaveAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SlaveAddress([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderI2cConnectionSettings*, int, int>)(lpVtbl[7]))((IProviderI2cConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProviderI2cConnectionSettings.xml' path='doc/member[@name="IProviderI2cConnectionSettings.get_BusSpeed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BusSpeed([NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cBusSpeed *")] ProviderI2cBusSpeed* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderI2cConnectionSettings*, ProviderI2cBusSpeed*, int>)(lpVtbl[8]))((IProviderI2cConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProviderI2cConnectionSettings.xml' path='doc/member[@name="IProviderI2cConnectionSettings.put_BusSpeed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BusSpeed([NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cBusSpeed")] ProviderI2cBusSpeed value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderI2cConnectionSettings*, ProviderI2cBusSpeed, int>)(lpVtbl[9]))((IProviderI2cConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProviderI2cConnectionSettings.xml' path='doc/member[@name="IProviderI2cConnectionSettings.get_SharingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SharingMode([NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cSharingMode *")] ProviderI2cSharingMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderI2cConnectionSettings*, ProviderI2cSharingMode*, int>)(lpVtbl[10]))((IProviderI2cConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProviderI2cConnectionSettings.xml' path='doc/member[@name="IProviderI2cConnectionSettings.put_SharingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_SharingMode([NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cSharingMode")] ProviderI2cSharingMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderI2cConnectionSettings*, ProviderI2cSharingMode, int>)(lpVtbl[11]))((IProviderI2cConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SlaveAddress([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT put_SlaveAddress([NativeTypeName("INT32")] int value);

        [VtblIndex(8)]
        HRESULT get_BusSpeed([NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cBusSpeed *")] ProviderI2cBusSpeed* value);

        [VtblIndex(9)]
        HRESULT put_BusSpeed([NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cBusSpeed")] ProviderI2cBusSpeed value);

        [VtblIndex(10)]
        HRESULT get_SharingMode([NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cSharingMode *")] ProviderI2cSharingMode* value);

        [VtblIndex(11)]
        HRESULT put_SharingMode([NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cSharingMode")] ProviderI2cSharingMode value);
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_SlaveAddress;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_SlaveAddress;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::I2c::Provider::ProviderI2cBusSpeed *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderI2cBusSpeed*, int> get_BusSpeed;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::I2c::Provider::ProviderI2cBusSpeed) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderI2cBusSpeed, int> put_BusSpeed;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::I2c::Provider::ProviderI2cSharingMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderI2cSharingMode*, int> get_SharingMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::I2c::Provider::ProviderI2cSharingMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderI2cSharingMode, int> put_SharingMode;
    }
}
