// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattServiceProviderTrigger.xml' path='doc/member[@name="IGattServiceProviderTrigger"]/*' />
[Guid("DDC6A3E9-1557-4BD8-8542-468AA0C696F6")]
[NativeTypeName("struct IGattServiceProviderTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattServiceProviderTrigger : IGattServiceProviderTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattServiceProviderTrigger));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTrigger*, Guid*, void**, int>)(lpVtbl[0]))((IGattServiceProviderTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTrigger*, uint>)(lpVtbl[1]))((IGattServiceProviderTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTrigger*, uint>)(lpVtbl[2]))((IGattServiceProviderTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTrigger*, uint*, Guid**, int>)(lpVtbl[3]))((IGattServiceProviderTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTrigger*, HSTRING*, int>)(lpVtbl[4]))((IGattServiceProviderTrigger*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTrigger*, TrustLevel*, int>)(lpVtbl[5]))((IGattServiceProviderTrigger*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattServiceProviderTrigger.xml' path='doc/member[@name="IGattServiceProviderTrigger.get_TriggerId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TriggerId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTrigger*, HSTRING*, int>)(lpVtbl[6]))((IGattServiceProviderTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceProviderTrigger.xml' path='doc/member[@name="IGattServiceProviderTrigger.get_Service"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Service([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalService **")] IGattLocalService** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTrigger*, IGattLocalService**, int>)(lpVtbl[7]))((IGattServiceProviderTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceProviderTrigger.xml' path='doc/member[@name="IGattServiceProviderTrigger.put_AdvertisingParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_AdvertisingParameters([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProviderAdvertisingParameters *")] IGattServiceProviderAdvertisingParameters* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTrigger*, IGattServiceProviderAdvertisingParameters*, int>)(lpVtbl[8]))((IGattServiceProviderTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceProviderTrigger.xml' path='doc/member[@name="IGattServiceProviderTrigger.get_AdvertisingParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AdvertisingParameters([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProviderAdvertisingParameters **")] IGattServiceProviderAdvertisingParameters** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTrigger*, IGattServiceProviderAdvertisingParameters**, int>)(lpVtbl[9]))((IGattServiceProviderTrigger*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TriggerId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Service([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalService **")] IGattLocalService** value);

        [VtblIndex(8)]
        HRESULT put_AdvertisingParameters([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProviderAdvertisingParameters *")] IGattServiceProviderAdvertisingParameters* value);

        [VtblIndex(9)]
        HRESULT get_AdvertisingParameters([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProviderAdvertisingParameters **")] IGattServiceProviderAdvertisingParameters** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProviderAdvertisingParameters *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGattServiceProviderAdvertisingParameters*, int> put_AdvertisingParameters;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProviderAdvertisingParameters **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGattServiceProviderAdvertisingParameters**, int> get_AdvertisingParameters;
    }
}
