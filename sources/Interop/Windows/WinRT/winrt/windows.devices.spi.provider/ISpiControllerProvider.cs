// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.spi.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpiControllerProvider.xml' path='doc/member[@name="ISpiControllerProvider"]/*' />
[Guid("C1686504-02CE-4226-A385-4F11FB04B41B")]
[NativeTypeName("struct ISpiControllerProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpiControllerProvider : ISpiControllerProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpiControllerProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiControllerProvider*, Guid*, void**, int>)(lpVtbl[0]))((ISpiControllerProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiControllerProvider*, uint>)(lpVtbl[1]))((ISpiControllerProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiControllerProvider*, uint>)(lpVtbl[2]))((ISpiControllerProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiControllerProvider*, uint*, Guid**, int>)(lpVtbl[3]))((ISpiControllerProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiControllerProvider*, HSTRING*, int>)(lpVtbl[4]))((ISpiControllerProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiControllerProvider*, TrustLevel*, int>)(lpVtbl[5]))((ISpiControllerProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpiControllerProvider.xml' path='doc/member[@name="ISpiControllerProvider.GetDeviceProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceProvider([NativeTypeName("ABI::Windows::Devices::Spi::Provider::IProviderSpiConnectionSettings *")] IProviderSpiConnectionSettings* settings, [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ISpiDeviceProvider **")] ISpiDeviceProvider** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiControllerProvider*, IProviderSpiConnectionSettings*, ISpiDeviceProvider**, int>)(lpVtbl[6]))((ISpiControllerProvider*)Unsafe.AsPointer(ref this), settings, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceProvider([NativeTypeName("ABI::Windows::Devices::Spi::Provider::IProviderSpiConnectionSettings *")] IProviderSpiConnectionSettings* settings, [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ISpiDeviceProvider **")] ISpiDeviceProvider** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Spi::Provider::IProviderSpiConnectionSettings *, ABI::Windows::Devices::Spi::Provider::ISpiDeviceProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IProviderSpiConnectionSettings*, ISpiDeviceProvider**, int> GetDeviceProvider;
    }
}
