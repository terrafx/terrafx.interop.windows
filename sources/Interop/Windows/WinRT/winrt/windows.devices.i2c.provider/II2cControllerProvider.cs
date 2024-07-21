// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.i2c.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='II2cControllerProvider.xml' path='doc/member[@name="II2cControllerProvider"]/*' />
[Guid("61C2BB82-4510-4163-A87C-4E15A9558980")]
[NativeTypeName("struct II2cControllerProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct II2cControllerProvider : II2cControllerProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_II2cControllerProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cControllerProvider*, Guid*, void**, int>)(lpVtbl[0]))((II2cControllerProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<II2cControllerProvider*, uint>)(lpVtbl[1]))((II2cControllerProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<II2cControllerProvider*, uint>)(lpVtbl[2]))((II2cControllerProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cControllerProvider*, uint*, Guid**, int>)(lpVtbl[3]))((II2cControllerProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cControllerProvider*, HSTRING*, int>)(lpVtbl[4]))((II2cControllerProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cControllerProvider*, TrustLevel*, int>)(lpVtbl[5]))((II2cControllerProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='II2cControllerProvider.xml' path='doc/member[@name="II2cControllerProvider.GetDeviceProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceProvider([NativeTypeName("ABI::Windows::Devices::I2c::Provider::IProviderI2cConnectionSettings *")] IProviderI2cConnectionSettings* settings, [NativeTypeName("ABI::Windows::Devices::I2c::Provider::II2cDeviceProvider **")] II2cDeviceProvider** device)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cControllerProvider*, IProviderI2cConnectionSettings*, II2cDeviceProvider**, int>)(lpVtbl[6]))((II2cControllerProvider*)Unsafe.AsPointer(ref this), settings, device);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceProvider([NativeTypeName("ABI::Windows::Devices::I2c::Provider::IProviderI2cConnectionSettings *")] IProviderI2cConnectionSettings* settings, [NativeTypeName("ABI::Windows::Devices::I2c::Provider::II2cDeviceProvider **")] II2cDeviceProvider** device);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::I2c::Provider::IProviderI2cConnectionSettings *, ABI::Windows::Devices::I2c::Provider::II2cDeviceProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IProviderI2cConnectionSettings*, II2cDeviceProvider**, int> GetDeviceProvider;
    }
}
