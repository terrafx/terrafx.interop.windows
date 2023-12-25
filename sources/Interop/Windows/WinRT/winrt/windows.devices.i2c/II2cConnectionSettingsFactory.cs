// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.i2c.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='II2cConnectionSettingsFactory.xml' path='doc/member[@name="II2cConnectionSettingsFactory"]/*' />
[Guid("81B586B3-9693-41B1-A243-DED4F6E66926")]
[NativeTypeName("struct II2cConnectionSettingsFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct II2cConnectionSettingsFactory : II2cConnectionSettingsFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_II2cConnectionSettingsFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cConnectionSettingsFactory*, Guid*, void**, int>)(lpVtbl[0]))((II2cConnectionSettingsFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<II2cConnectionSettingsFactory*, uint>)(lpVtbl[1]))((II2cConnectionSettingsFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<II2cConnectionSettingsFactory*, uint>)(lpVtbl[2]))((II2cConnectionSettingsFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cConnectionSettingsFactory*, uint*, Guid**, int>)(lpVtbl[3]))((II2cConnectionSettingsFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cConnectionSettingsFactory*, HSTRING*, int>)(lpVtbl[4]))((II2cConnectionSettingsFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cConnectionSettingsFactory*, TrustLevel*, int>)(lpVtbl[5]))((II2cConnectionSettingsFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='II2cConnectionSettingsFactory.xml' path='doc/member[@name="II2cConnectionSettingsFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("INT32")] int slaveAddress, [NativeTypeName("ABI::Windows::Devices::I2c::II2cConnectionSettings **")] II2cConnectionSettings** value)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cConnectionSettingsFactory*, int, II2cConnectionSettings**, int>)(lpVtbl[6]))((II2cConnectionSettingsFactory*)Unsafe.AsPointer(ref this), slaveAddress, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("INT32")] int slaveAddress, [NativeTypeName("ABI::Windows::Devices::I2c::II2cConnectionSettings **")] II2cConnectionSettings** value);
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

        [NativeTypeName("HRESULT (INT32, ABI::Windows::Devices::I2c::II2cConnectionSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, II2cConnectionSettings**, int> Create;
    }
}
