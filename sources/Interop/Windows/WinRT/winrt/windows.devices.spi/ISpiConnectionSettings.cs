// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.spi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpiConnectionSettings.xml' path='doc/member[@name="ISpiConnectionSettings"]/*' />
[Guid("5283A37F-F935-4B9F-A7A7-3A7890AFA5CE")]
[NativeTypeName("struct ISpiConnectionSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpiConnectionSettings : ISpiConnectionSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpiConnectionSettings);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiConnectionSettings*, Guid*, void**, int>)(lpVtbl[0]))((ISpiConnectionSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiConnectionSettings*, uint>)(lpVtbl[1]))((ISpiConnectionSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiConnectionSettings*, uint>)(lpVtbl[2]))((ISpiConnectionSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiConnectionSettings*, uint*, Guid**, int>)(lpVtbl[3]))((ISpiConnectionSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiConnectionSettings*, HSTRING*, int>)(lpVtbl[4]))((ISpiConnectionSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiConnectionSettings*, TrustLevel*, int>)(lpVtbl[5]))((ISpiConnectionSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpiConnectionSettings.xml' path='doc/member[@name="ISpiConnectionSettings.get_ChipSelectLine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChipSelectLine([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiConnectionSettings*, int*, int>)(lpVtbl[6]))((ISpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiConnectionSettings.xml' path='doc/member[@name="ISpiConnectionSettings.put_ChipSelectLine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ChipSelectLine([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiConnectionSettings*, int, int>)(lpVtbl[7]))((ISpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiConnectionSettings.xml' path='doc/member[@name="ISpiConnectionSettings.get_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Mode([NativeTypeName("ABI::Windows::Devices::Spi::SpiMode *")] SpiMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiConnectionSettings*, SpiMode*, int>)(lpVtbl[8]))((ISpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiConnectionSettings.xml' path='doc/member[@name="ISpiConnectionSettings.put_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Mode([NativeTypeName("ABI::Windows::Devices::Spi::SpiMode")] SpiMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiConnectionSettings*, SpiMode, int>)(lpVtbl[9]))((ISpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiConnectionSettings.xml' path='doc/member[@name="ISpiConnectionSettings.get_DataBitLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DataBitLength([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiConnectionSettings*, int*, int>)(lpVtbl[10]))((ISpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiConnectionSettings.xml' path='doc/member[@name="ISpiConnectionSettings.put_DataBitLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_DataBitLength([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiConnectionSettings*, int, int>)(lpVtbl[11]))((ISpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiConnectionSettings.xml' path='doc/member[@name="ISpiConnectionSettings.get_ClockFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ClockFrequency([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiConnectionSettings*, int*, int>)(lpVtbl[12]))((ISpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiConnectionSettings.xml' path='doc/member[@name="ISpiConnectionSettings.put_ClockFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_ClockFrequency([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiConnectionSettings*, int, int>)(lpVtbl[13]))((ISpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiConnectionSettings.xml' path='doc/member[@name="ISpiConnectionSettings.get_SharingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_SharingMode([NativeTypeName("ABI::Windows::Devices::Spi::SpiSharingMode *")] SpiSharingMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiConnectionSettings*, SpiSharingMode*, int>)(lpVtbl[14]))((ISpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiConnectionSettings.xml' path='doc/member[@name="ISpiConnectionSettings.put_SharingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_SharingMode([NativeTypeName("ABI::Windows::Devices::Spi::SpiSharingMode")] SpiSharingMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiConnectionSettings*, SpiSharingMode, int>)(lpVtbl[15]))((ISpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ChipSelectLine([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT put_ChipSelectLine([NativeTypeName("INT32")] int value);

        [VtblIndex(8)]
        HRESULT get_Mode([NativeTypeName("ABI::Windows::Devices::Spi::SpiMode *")] SpiMode* value);

        [VtblIndex(9)]
        HRESULT put_Mode([NativeTypeName("ABI::Windows::Devices::Spi::SpiMode")] SpiMode value);

        [VtblIndex(10)]
        HRESULT get_DataBitLength([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(11)]
        HRESULT put_DataBitLength([NativeTypeName("INT32")] int value);

        [VtblIndex(12)]
        HRESULT get_ClockFrequency([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT put_ClockFrequency([NativeTypeName("INT32")] int value);

        [VtblIndex(14)]
        HRESULT get_SharingMode([NativeTypeName("ABI::Windows::Devices::Spi::SpiSharingMode *")] SpiSharingMode* value);

        [VtblIndex(15)]
        HRESULT put_SharingMode([NativeTypeName("ABI::Windows::Devices::Spi::SpiSharingMode")] SpiSharingMode value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ChipSelectLine;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_ChipSelectLine;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Spi::SpiMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpiMode*, int> get_Mode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Spi::SpiMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpiMode, int> put_Mode;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_DataBitLength;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_DataBitLength;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ClockFrequency;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_ClockFrequency;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Spi::SpiSharingMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpiSharingMode*, int> get_SharingMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Spi::SpiSharingMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpiSharingMode, int> put_SharingMode;
    }
}
