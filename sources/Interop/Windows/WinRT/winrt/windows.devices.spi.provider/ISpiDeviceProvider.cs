// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.spi.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpiDeviceProvider.xml' path='doc/member[@name="ISpiDeviceProvider"]/*' />
[Guid("0D1C3443-304B-405C-B4F7-F5AB1074461E")]
[NativeTypeName("struct ISpiDeviceProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpiDeviceProvider : ISpiDeviceProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpiDeviceProvider);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceProvider*, Guid*, void**, int>)(lpVtbl[0]))((ISpiDeviceProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceProvider*, uint>)(lpVtbl[1]))((ISpiDeviceProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceProvider*, uint>)(lpVtbl[2]))((ISpiDeviceProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceProvider*, uint*, Guid**, int>)(lpVtbl[3]))((ISpiDeviceProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceProvider*, HSTRING*, int>)(lpVtbl[4]))((ISpiDeviceProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceProvider*, TrustLevel*, int>)(lpVtbl[5]))((ISpiDeviceProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpiDeviceProvider.xml' path='doc/member[@name="ISpiDeviceProvider.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceProvider*, HSTRING*, int>)(lpVtbl[6]))((ISpiDeviceProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiDeviceProvider.xml' path='doc/member[@name="ISpiDeviceProvider.get_ConnectionSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ConnectionSettings([NativeTypeName("ABI::Windows::Devices::Spi::Provider::IProviderSpiConnectionSettings **")] IProviderSpiConnectionSettings** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceProvider*, IProviderSpiConnectionSettings**, int>)(lpVtbl[7]))((ISpiDeviceProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiDeviceProvider.xml' path='doc/member[@name="ISpiDeviceProvider.Write"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Write([NativeTypeName("UINT32")] uint bufferLength, byte* buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceProvider*, uint, byte*, int>)(lpVtbl[8]))((ISpiDeviceProvider*)Unsafe.AsPointer(ref this), bufferLength, buffer);
    }

    /// <include file='ISpiDeviceProvider.xml' path='doc/member[@name="ISpiDeviceProvider.Read"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Read([NativeTypeName("UINT32")] uint bufferLength, byte* buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceProvider*, uint, byte*, int>)(lpVtbl[9]))((ISpiDeviceProvider*)Unsafe.AsPointer(ref this), bufferLength, buffer);
    }

    /// <include file='ISpiDeviceProvider.xml' path='doc/member[@name="ISpiDeviceProvider.TransferSequential"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TransferSequential([NativeTypeName("UINT32")] uint writeBufferLength, byte* writeBuffer, [NativeTypeName("UINT32")] uint readBufferLength, byte* readBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceProvider*, uint, byte*, uint, byte*, int>)(lpVtbl[10]))((ISpiDeviceProvider*)Unsafe.AsPointer(ref this), writeBufferLength, writeBuffer, readBufferLength, readBuffer);
    }

    /// <include file='ISpiDeviceProvider.xml' path='doc/member[@name="ISpiDeviceProvider.TransferFullDuplex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TransferFullDuplex([NativeTypeName("UINT32")] uint writeBufferLength, byte* writeBuffer, [NativeTypeName("UINT32")] uint readBufferLength, byte* readBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceProvider*, uint, byte*, uint, byte*, int>)(lpVtbl[11]))((ISpiDeviceProvider*)Unsafe.AsPointer(ref this), writeBufferLength, writeBuffer, readBufferLength, readBuffer);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ConnectionSettings([NativeTypeName("ABI::Windows::Devices::Spi::Provider::IProviderSpiConnectionSettings **")] IProviderSpiConnectionSettings** value);

        [VtblIndex(8)]
        HRESULT Write([NativeTypeName("UINT32")] uint bufferLength, byte* buffer);

        [VtblIndex(9)]
        HRESULT Read([NativeTypeName("UINT32")] uint bufferLength, byte* buffer);

        [VtblIndex(10)]
        HRESULT TransferSequential([NativeTypeName("UINT32")] uint writeBufferLength, byte* writeBuffer, [NativeTypeName("UINT32")] uint readBufferLength, byte* readBuffer);

        [VtblIndex(11)]
        HRESULT TransferFullDuplex([NativeTypeName("UINT32")] uint writeBufferLength, byte* writeBuffer, [NativeTypeName("UINT32")] uint readBufferLength, byte* readBuffer);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Spi::Provider::IProviderSpiConnectionSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IProviderSpiConnectionSettings**, int> get_ConnectionSettings;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> Write;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> Read;

        [NativeTypeName("HRESULT (UINT32, BYTE *, UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint, byte*, int> TransferSequential;

        [NativeTypeName("HRESULT (UINT32, BYTE *, UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint, byte*, int> TransferFullDuplex;
    }
}
