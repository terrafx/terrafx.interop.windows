// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattServiceProviderResult.xml' path='doc/member[@name="IGattServiceProviderResult"]/*' />
[Guid("764696D8-C53E-428C-8A48-67AFE02C3AE6")]
[NativeTypeName("struct IGattServiceProviderResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattServiceProviderResult : IGattServiceProviderResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGattServiceProviderResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderResult*, Guid*, void**, int>)(lpVtbl[0]))((IGattServiceProviderResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderResult*, uint>)(lpVtbl[1]))((IGattServiceProviderResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderResult*, uint>)(lpVtbl[2]))((IGattServiceProviderResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderResult*, uint*, Guid**, int>)(lpVtbl[3]))((IGattServiceProviderResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderResult*, HSTRING*, int>)(lpVtbl[4]))((IGattServiceProviderResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderResult*, TrustLevel*, int>)(lpVtbl[5]))((IGattServiceProviderResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattServiceProviderResult.xml' path='doc/member[@name="IGattServiceProviderResult.get_Error"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Error([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothError *")] BluetoothError* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderResult*, BluetoothError*, int>)(lpVtbl[6]))((IGattServiceProviderResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceProviderResult.xml' path='doc/member[@name="IGattServiceProviderResult.get_ServiceProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ServiceProvider([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProvider **")] IGattServiceProvider** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderResult*, IGattServiceProvider**, int>)(lpVtbl[7]))((IGattServiceProviderResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Error([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothError *")] BluetoothError* value);

        [VtblIndex(7)]
        HRESULT get_ServiceProvider([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProvider **")] IGattServiceProvider** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothError *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothError*, int> get_Error;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGattServiceProvider**, int> get_ServiceProvider;
    }
}
