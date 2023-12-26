// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.i2c.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='II2cDevice.xml' path='doc/member[@name="II2cDevice"]/*' />
[Guid("8636C136-B9C5-4F70-9449-CC46DC6F57EB")]
[NativeTypeName("struct II2cDevice : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct II2cDevice : II2cDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_II2cDevice));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDevice*, Guid*, void**, int>)(lpVtbl[0]))((II2cDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDevice*, uint>)(lpVtbl[1]))((II2cDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDevice*, uint>)(lpVtbl[2]))((II2cDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDevice*, uint*, Guid**, int>)(lpVtbl[3]))((II2cDevice*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDevice*, HSTRING*, int>)(lpVtbl[4]))((II2cDevice*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDevice*, TrustLevel*, int>)(lpVtbl[5]))((II2cDevice*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='II2cDevice.xml' path='doc/member[@name="II2cDevice.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDevice*, HSTRING*, int>)(lpVtbl[6]))((II2cDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='II2cDevice.xml' path='doc/member[@name="II2cDevice.get_ConnectionSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ConnectionSettings([NativeTypeName("ABI::Windows::Devices::I2c::II2cConnectionSettings **")] II2cConnectionSettings** value)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDevice*, II2cConnectionSettings**, int>)(lpVtbl[7]))((II2cDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='II2cDevice.xml' path='doc/member[@name="II2cDevice.Write"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Write([NativeTypeName("UINT32")] uint bufferLength, byte* buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDevice*, uint, byte*, int>)(lpVtbl[8]))((II2cDevice*)Unsafe.AsPointer(ref this), bufferLength, buffer);
    }

    /// <include file='II2cDevice.xml' path='doc/member[@name="II2cDevice.WritePartial"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT WritePartial([NativeTypeName("UINT32")] uint bufferLength, byte* buffer, [NativeTypeName("ABI::Windows::Devices::I2c::I2cTransferResult *")] I2cTransferResult* result)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDevice*, uint, byte*, I2cTransferResult*, int>)(lpVtbl[9]))((II2cDevice*)Unsafe.AsPointer(ref this), bufferLength, buffer, result);
    }

    /// <include file='II2cDevice.xml' path='doc/member[@name="II2cDevice.Read"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Read([NativeTypeName("UINT32")] uint bufferLength, byte* buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDevice*, uint, byte*, int>)(lpVtbl[10]))((II2cDevice*)Unsafe.AsPointer(ref this), bufferLength, buffer);
    }

    /// <include file='II2cDevice.xml' path='doc/member[@name="II2cDevice.ReadPartial"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ReadPartial([NativeTypeName("UINT32")] uint bufferLength, byte* buffer, [NativeTypeName("ABI::Windows::Devices::I2c::I2cTransferResult *")] I2cTransferResult* result)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDevice*, uint, byte*, I2cTransferResult*, int>)(lpVtbl[11]))((II2cDevice*)Unsafe.AsPointer(ref this), bufferLength, buffer, result);
    }

    /// <include file='II2cDevice.xml' path='doc/member[@name="II2cDevice.WriteRead"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT WriteRead([NativeTypeName("UINT32")] uint writeBufferLength, byte* writeBuffer, [NativeTypeName("UINT32")] uint readBufferLength, byte* readBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDevice*, uint, byte*, uint, byte*, int>)(lpVtbl[12]))((II2cDevice*)Unsafe.AsPointer(ref this), writeBufferLength, writeBuffer, readBufferLength, readBuffer);
    }

    /// <include file='II2cDevice.xml' path='doc/member[@name="II2cDevice.WriteReadPartial"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT WriteReadPartial([NativeTypeName("UINT32")] uint writeBufferLength, byte* writeBuffer, [NativeTypeName("UINT32")] uint readBufferLength, byte* readBuffer, [NativeTypeName("ABI::Windows::Devices::I2c::I2cTransferResult *")] I2cTransferResult* result)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDevice*, uint, byte*, uint, byte*, I2cTransferResult*, int>)(lpVtbl[13]))((II2cDevice*)Unsafe.AsPointer(ref this), writeBufferLength, writeBuffer, readBufferLength, readBuffer, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ConnectionSettings([NativeTypeName("ABI::Windows::Devices::I2c::II2cConnectionSettings **")] II2cConnectionSettings** value);

        [VtblIndex(8)]
        HRESULT Write([NativeTypeName("UINT32")] uint bufferLength, byte* buffer);

        [VtblIndex(9)]
        HRESULT WritePartial([NativeTypeName("UINT32")] uint bufferLength, byte* buffer, [NativeTypeName("ABI::Windows::Devices::I2c::I2cTransferResult *")] I2cTransferResult* result);

        [VtblIndex(10)]
        HRESULT Read([NativeTypeName("UINT32")] uint bufferLength, byte* buffer);

        [VtblIndex(11)]
        HRESULT ReadPartial([NativeTypeName("UINT32")] uint bufferLength, byte* buffer, [NativeTypeName("ABI::Windows::Devices::I2c::I2cTransferResult *")] I2cTransferResult* result);

        [VtblIndex(12)]
        HRESULT WriteRead([NativeTypeName("UINT32")] uint writeBufferLength, byte* writeBuffer, [NativeTypeName("UINT32")] uint readBufferLength, byte* readBuffer);

        [VtblIndex(13)]
        HRESULT WriteReadPartial([NativeTypeName("UINT32")] uint writeBufferLength, byte* writeBuffer, [NativeTypeName("UINT32")] uint readBufferLength, byte* readBuffer, [NativeTypeName("ABI::Windows::Devices::I2c::I2cTransferResult *")] I2cTransferResult* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::I2c::II2cConnectionSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, II2cConnectionSettings**, int> get_ConnectionSettings;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> Write;

        [NativeTypeName("HRESULT (UINT32, BYTE *, ABI::Windows::Devices::I2c::I2cTransferResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, I2cTransferResult*, int> WritePartial;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> Read;

        [NativeTypeName("HRESULT (UINT32, BYTE *, ABI::Windows::Devices::I2c::I2cTransferResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, I2cTransferResult*, int> ReadPartial;

        [NativeTypeName("HRESULT (UINT32, BYTE *, UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint, byte*, int> WriteRead;

        [NativeTypeName("HRESULT (UINT32, BYTE *, UINT32, BYTE *, ABI::Windows::Devices::I2c::I2cTransferResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint, byte*, I2cTransferResult*, int> WriteReadPartial;
    }
}
