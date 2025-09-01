// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.spi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpiDevice.xml' path='doc/member[@name="ISpiDevice"]/*' />
[Guid("05D5356D-11B6-4D39-84D5-95DFB4C9F2CE")]
[NativeTypeName("struct ISpiDevice : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpiDevice : ISpiDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpiDevice);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDevice*, Guid*, void**, int>)(lpVtbl[0]))((ISpiDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDevice*, uint>)(lpVtbl[1]))((ISpiDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDevice*, uint>)(lpVtbl[2]))((ISpiDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDevice*, uint*, Guid**, int>)(lpVtbl[3]))((ISpiDevice*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDevice*, HSTRING*, int>)(lpVtbl[4]))((ISpiDevice*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDevice*, TrustLevel*, int>)(lpVtbl[5]))((ISpiDevice*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpiDevice.xml' path='doc/member[@name="ISpiDevice.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDevice*, HSTRING*, int>)(lpVtbl[6]))((ISpiDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiDevice.xml' path='doc/member[@name="ISpiDevice.get_ConnectionSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ConnectionSettings([NativeTypeName("ABI::Windows::Devices::Spi::ISpiConnectionSettings **")] ISpiConnectionSettings** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDevice*, ISpiConnectionSettings**, int>)(lpVtbl[7]))((ISpiDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiDevice.xml' path='doc/member[@name="ISpiDevice.Write"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Write([NativeTypeName("UINT32")] uint bufferLength, byte* buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDevice*, uint, byte*, int>)(lpVtbl[8]))((ISpiDevice*)Unsafe.AsPointer(ref this), bufferLength, buffer);
    }

    /// <include file='ISpiDevice.xml' path='doc/member[@name="ISpiDevice.Read"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Read([NativeTypeName("UINT32")] uint bufferLength, byte* buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDevice*, uint, byte*, int>)(lpVtbl[9]))((ISpiDevice*)Unsafe.AsPointer(ref this), bufferLength, buffer);
    }

    /// <include file='ISpiDevice.xml' path='doc/member[@name="ISpiDevice.TransferSequential"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TransferSequential([NativeTypeName("UINT32")] uint writeBufferLength, byte* writeBuffer, [NativeTypeName("UINT32")] uint readBufferLength, byte* readBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDevice*, uint, byte*, uint, byte*, int>)(lpVtbl[10]))((ISpiDevice*)Unsafe.AsPointer(ref this), writeBufferLength, writeBuffer, readBufferLength, readBuffer);
    }

    /// <include file='ISpiDevice.xml' path='doc/member[@name="ISpiDevice.TransferFullDuplex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TransferFullDuplex([NativeTypeName("UINT32")] uint writeBufferLength, byte* writeBuffer, [NativeTypeName("UINT32")] uint readBufferLength, byte* readBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDevice*, uint, byte*, uint, byte*, int>)(lpVtbl[11]))((ISpiDevice*)Unsafe.AsPointer(ref this), writeBufferLength, writeBuffer, readBufferLength, readBuffer);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ConnectionSettings([NativeTypeName("ABI::Windows::Devices::Spi::ISpiConnectionSettings **")] ISpiConnectionSettings** value);

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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Spi::ISpiConnectionSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpiConnectionSettings**, int> get_ConnectionSettings;

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
