// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattServiceProviderConnection.xml' path='doc/member[@name="IGattServiceProviderConnection"]/*' />
[Guid("7FA1B9B9-2F13-40B5-9582-8EB78E98EF13")]
[NativeTypeName("struct IGattServiceProviderConnection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattServiceProviderConnection : IGattServiceProviderConnection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattServiceProviderConnection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderConnection*, Guid*, void**, int>)(lpVtbl[0]))((IGattServiceProviderConnection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderConnection*, uint>)(lpVtbl[1]))((IGattServiceProviderConnection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderConnection*, uint>)(lpVtbl[2]))((IGattServiceProviderConnection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderConnection*, uint*, Guid**, int>)(lpVtbl[3]))((IGattServiceProviderConnection*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderConnection*, HSTRING*, int>)(lpVtbl[4]))((IGattServiceProviderConnection*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderConnection*, TrustLevel*, int>)(lpVtbl[5]))((IGattServiceProviderConnection*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattServiceProviderConnection.xml' path='doc/member[@name="IGattServiceProviderConnection.get_TriggerId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TriggerId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderConnection*, HSTRING*, int>)(lpVtbl[6]))((IGattServiceProviderConnection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceProviderConnection.xml' path='doc/member[@name="IGattServiceProviderConnection.get_Service"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Service([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalService **")] IGattLocalService** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderConnection*, IGattLocalService**, int>)(lpVtbl[7]))((IGattServiceProviderConnection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceProviderConnection.xml' path='doc/member[@name="IGattServiceProviderConnection.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderConnection*, int>)(lpVtbl[8]))((IGattServiceProviderConnection*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TriggerId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Service([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalService **")] IGattLocalService** value);

        [VtblIndex(8)]
        HRESULT Start();
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TriggerId;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalService **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGattLocalService**, int> get_Service;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;
    }
}
