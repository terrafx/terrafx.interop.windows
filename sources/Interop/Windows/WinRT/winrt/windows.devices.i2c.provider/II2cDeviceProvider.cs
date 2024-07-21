// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.i2c.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='II2cDeviceProvider.xml' path='doc/member[@name="II2cDeviceProvider"]/*' />
[Guid("AD342654-57E8-453E-8329-D1E447D103A9")]
[NativeTypeName("struct II2cDeviceProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct II2cDeviceProvider : II2cDeviceProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_II2cDeviceProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceProvider*, Guid*, void**, int>)(lpVtbl[0]))((II2cDeviceProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceProvider*, uint>)(lpVtbl[1]))((II2cDeviceProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceProvider*, uint>)(lpVtbl[2]))((II2cDeviceProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceProvider*, uint*, Guid**, int>)(lpVtbl[3]))((II2cDeviceProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceProvider*, HSTRING*, int>)(lpVtbl[4]))((II2cDeviceProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceProvider*, TrustLevel*, int>)(lpVtbl[5]))((II2cDeviceProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='II2cDeviceProvider.xml' path='doc/member[@name="II2cDeviceProvider.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceProvider*, HSTRING*, int>)(lpVtbl[6]))((II2cDeviceProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='II2cDeviceProvider.xml' path='doc/member[@name="II2cDeviceProvider.Write"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Write([NativeTypeName("UINT32")] uint bufferLength, byte* buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceProvider*, uint, byte*, int>)(lpVtbl[7]))((II2cDeviceProvider*)Unsafe.AsPointer(ref this), bufferLength, buffer);
    }

    /// <include file='II2cDeviceProvider.xml' path='doc/member[@name="II2cDeviceProvider.WritePartial"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WritePartial([NativeTypeName("UINT32")] uint bufferLength, byte* buffer, [NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *")] ProviderI2cTransferResult* result)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceProvider*, uint, byte*, ProviderI2cTransferResult*, int>)(lpVtbl[8]))((II2cDeviceProvider*)Unsafe.AsPointer(ref this), bufferLength, buffer, result);
    }

    /// <include file='II2cDeviceProvider.xml' path='doc/member[@name="II2cDeviceProvider.Read"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Read([NativeTypeName("UINT32")] uint bufferLength, byte* buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceProvider*, uint, byte*, int>)(lpVtbl[9]))((II2cDeviceProvider*)Unsafe.AsPointer(ref this), bufferLength, buffer);
    }

    /// <include file='II2cDeviceProvider.xml' path='doc/member[@name="II2cDeviceProvider.ReadPartial"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ReadPartial([NativeTypeName("UINT32")] uint bufferLength, byte* buffer, [NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *")] ProviderI2cTransferResult* result)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceProvider*, uint, byte*, ProviderI2cTransferResult*, int>)(lpVtbl[10]))((II2cDeviceProvider*)Unsafe.AsPointer(ref this), bufferLength, buffer, result);
    }

    /// <include file='II2cDeviceProvider.xml' path='doc/member[@name="II2cDeviceProvider.WriteRead"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT WriteRead([NativeTypeName("UINT32")] uint writeBufferLength, byte* writeBuffer, [NativeTypeName("UINT32")] uint readBufferLength, byte* readBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceProvider*, uint, byte*, uint, byte*, int>)(lpVtbl[11]))((II2cDeviceProvider*)Unsafe.AsPointer(ref this), writeBufferLength, writeBuffer, readBufferLength, readBuffer);
    }

    /// <include file='II2cDeviceProvider.xml' path='doc/member[@name="II2cDeviceProvider.WriteReadPartial"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT WriteReadPartial([NativeTypeName("UINT32")] uint writeBufferLength, byte* writeBuffer, [NativeTypeName("UINT32")] uint readBufferLength, byte* readBuffer, [NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *")] ProviderI2cTransferResult* result)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceProvider*, uint, byte*, uint, byte*, ProviderI2cTransferResult*, int>)(lpVtbl[12]))((II2cDeviceProvider*)Unsafe.AsPointer(ref this), writeBufferLength, writeBuffer, readBufferLength, readBuffer, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT Write([NativeTypeName("UINT32")] uint bufferLength, byte* buffer);

        [VtblIndex(8)]
        HRESULT WritePartial([NativeTypeName("UINT32")] uint bufferLength, byte* buffer, [NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *")] ProviderI2cTransferResult* result);

        [VtblIndex(9)]
        HRESULT Read([NativeTypeName("UINT32")] uint bufferLength, byte* buffer);

        [VtblIndex(10)]
        HRESULT ReadPartial([NativeTypeName("UINT32")] uint bufferLength, byte* buffer, [NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *")] ProviderI2cTransferResult* result);

        [VtblIndex(11)]
        HRESULT WriteRead([NativeTypeName("UINT32")] uint writeBufferLength, byte* writeBuffer, [NativeTypeName("UINT32")] uint readBufferLength, byte* readBuffer);

        [VtblIndex(12)]
        HRESULT WriteReadPartial([NativeTypeName("UINT32")] uint writeBufferLength, byte* writeBuffer, [NativeTypeName("UINT32")] uint readBufferLength, byte* readBuffer, [NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *")] ProviderI2cTransferResult* result);
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

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> Write;

        [NativeTypeName("HRESULT (UINT32, BYTE *, ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, ProviderI2cTransferResult*, int> WritePartial;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> Read;

        [NativeTypeName("HRESULT (UINT32, BYTE *, ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, ProviderI2cTransferResult*, int> ReadPartial;

        [NativeTypeName("HRESULT (UINT32, BYTE *, UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint, byte*, int> WriteRead;

        [NativeTypeName("HRESULT (UINT32, BYTE *, UINT32, BYTE *, ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint, byte*, ProviderI2cTransferResult*, int> WriteReadPartial;
    }
}
