// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattServiceProviderTriggerResult.xml' path='doc/member[@name="IGattServiceProviderTriggerResult"]/*' />
[Guid("3C4691B1-B198-4E84-BAD4-CF4AD299ED3A")]
[NativeTypeName("struct IGattServiceProviderTriggerResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattServiceProviderTriggerResult : IGattServiceProviderTriggerResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattServiceProviderTriggerResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTriggerResult*, Guid*, void**, int>)(lpVtbl[0]))((IGattServiceProviderTriggerResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTriggerResult*, uint>)(lpVtbl[1]))((IGattServiceProviderTriggerResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTriggerResult*, uint>)(lpVtbl[2]))((IGattServiceProviderTriggerResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTriggerResult*, uint*, Guid**, int>)(lpVtbl[3]))((IGattServiceProviderTriggerResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTriggerResult*, HSTRING*, int>)(lpVtbl[4]))((IGattServiceProviderTriggerResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTriggerResult*, TrustLevel*, int>)(lpVtbl[5]))((IGattServiceProviderTriggerResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattServiceProviderTriggerResult.xml' path='doc/member[@name="IGattServiceProviderTriggerResult.get_Trigger"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Trigger([NativeTypeName("ABI::Windows::ApplicationModel::Background::IGattServiceProviderTrigger **")] IGattServiceProviderTrigger** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTriggerResult*, IGattServiceProviderTrigger**, int>)(lpVtbl[6]))((IGattServiceProviderTriggerResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceProviderTriggerResult.xml' path='doc/member[@name="IGattServiceProviderTriggerResult.get_Error"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Error([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothError *")] BluetoothError* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderTriggerResult*, BluetoothError*, int>)(lpVtbl[7]))((IGattServiceProviderTriggerResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Trigger([NativeTypeName("ABI::Windows::ApplicationModel::Background::IGattServiceProviderTrigger **")] IGattServiceProviderTrigger** value);

        [VtblIndex(7)]
        HRESULT get_Error([NativeTypeName("ABI::Windows::Devices::Bluetooth::BluetoothError *")] BluetoothError* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::IGattServiceProviderTrigger **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGattServiceProviderTrigger**, int> get_Trigger;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::BluetoothError *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BluetoothError*, int> get_Error;
    }
}
