// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.spi.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProviderSpiConnectionSettings.xml' path='doc/member[@name="IProviderSpiConnectionSettings"]/*' />
[Guid("F6034550-A542-4EC0-9601-A4DD68F8697B")]
[NativeTypeName("struct IProviderSpiConnectionSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProviderSpiConnectionSettings : IProviderSpiConnectionSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProviderSpiConnectionSettings));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettings*, Guid*, void**, int>)(lpVtbl[0]))((IProviderSpiConnectionSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettings*, uint>)(lpVtbl[1]))((IProviderSpiConnectionSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettings*, uint>)(lpVtbl[2]))((IProviderSpiConnectionSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettings*, uint*, Guid**, int>)(lpVtbl[3]))((IProviderSpiConnectionSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettings*, HSTRING*, int>)(lpVtbl[4]))((IProviderSpiConnectionSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettings*, TrustLevel*, int>)(lpVtbl[5]))((IProviderSpiConnectionSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProviderSpiConnectionSettings.xml' path='doc/member[@name="IProviderSpiConnectionSettings.get_ChipSelectLine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChipSelectLine([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettings*, int*, int>)(lpVtbl[6]))((IProviderSpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProviderSpiConnectionSettings.xml' path='doc/member[@name="IProviderSpiConnectionSettings.put_ChipSelectLine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ChipSelectLine([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettings*, int, int>)(lpVtbl[7]))((IProviderSpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProviderSpiConnectionSettings.xml' path='doc/member[@name="IProviderSpiConnectionSettings.get_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Mode([NativeTypeName("ABI::Windows::Devices::Spi::Provider::ProviderSpiMode *")] ProviderSpiMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettings*, ProviderSpiMode*, int>)(lpVtbl[8]))((IProviderSpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProviderSpiConnectionSettings.xml' path='doc/member[@name="IProviderSpiConnectionSettings.put_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Mode([NativeTypeName("ABI::Windows::Devices::Spi::Provider::ProviderSpiMode")] ProviderSpiMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettings*, ProviderSpiMode, int>)(lpVtbl[9]))((IProviderSpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProviderSpiConnectionSettings.xml' path='doc/member[@name="IProviderSpiConnectionSettings.get_DataBitLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DataBitLength([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettings*, int*, int>)(lpVtbl[10]))((IProviderSpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProviderSpiConnectionSettings.xml' path='doc/member[@name="IProviderSpiConnectionSettings.put_DataBitLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_DataBitLength([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettings*, int, int>)(lpVtbl[11]))((IProviderSpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProviderSpiConnectionSettings.xml' path='doc/member[@name="IProviderSpiConnectionSettings.get_ClockFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ClockFrequency([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettings*, int*, int>)(lpVtbl[12]))((IProviderSpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProviderSpiConnectionSettings.xml' path='doc/member[@name="IProviderSpiConnectionSettings.put_ClockFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_ClockFrequency([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettings*, int, int>)(lpVtbl[13]))((IProviderSpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProviderSpiConnectionSettings.xml' path='doc/member[@name="IProviderSpiConnectionSettings.get_SharingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_SharingMode([NativeTypeName("ABI::Windows::Devices::Spi::Provider::ProviderSpiSharingMode *")] ProviderSpiSharingMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettings*, ProviderSpiSharingMode*, int>)(lpVtbl[14]))((IProviderSpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProviderSpiConnectionSettings.xml' path='doc/member[@name="IProviderSpiConnectionSettings.put_SharingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_SharingMode([NativeTypeName("ABI::Windows::Devices::Spi::Provider::ProviderSpiSharingMode")] ProviderSpiSharingMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettings*, ProviderSpiSharingMode, int>)(lpVtbl[15]))((IProviderSpiConnectionSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ChipSelectLine([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT put_ChipSelectLine([NativeTypeName("INT32")] int value);

        [VtblIndex(8)]
        HRESULT get_Mode([NativeTypeName("ABI::Windows::Devices::Spi::Provider::ProviderSpiMode *")] ProviderSpiMode* value);

        [VtblIndex(9)]
        HRESULT put_Mode([NativeTypeName("ABI::Windows::Devices::Spi::Provider::ProviderSpiMode")] ProviderSpiMode value);

        [VtblIndex(10)]
        HRESULT get_DataBitLength([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(11)]
        HRESULT put_DataBitLength([NativeTypeName("INT32")] int value);

        [VtblIndex(12)]
        HRESULT get_ClockFrequency([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT put_ClockFrequency([NativeTypeName("INT32")] int value);

        [VtblIndex(14)]
        HRESULT get_SharingMode([NativeTypeName("ABI::Windows::Devices::Spi::Provider::ProviderSpiSharingMode *")] ProviderSpiSharingMode* value);

        [VtblIndex(15)]
        HRESULT put_SharingMode([NativeTypeName("ABI::Windows::Devices::Spi::Provider::ProviderSpiSharingMode")] ProviderSpiSharingMode value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Spi::Provider::ProviderSpiMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderSpiMode*, int> get_Mode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Spi::Provider::ProviderSpiMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderSpiMode, int> put_Mode;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_DataBitLength;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_DataBitLength;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ClockFrequency;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_ClockFrequency;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Spi::Provider::ProviderSpiSharingMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderSpiSharingMode*, int> get_SharingMode;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Spi::Provider::ProviderSpiSharingMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderSpiSharingMode, int> put_SharingMode;
    }
}
