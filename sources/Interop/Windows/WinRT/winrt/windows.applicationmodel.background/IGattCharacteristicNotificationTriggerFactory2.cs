// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattCharacteristicNotificationTriggerFactory2.xml' path='doc/member[@name="IGattCharacteristicNotificationTriggerFactory2"]/*' />
[Guid("5998E91F-8A53-4E9F-A32C-23CD33664CEE")]
[NativeTypeName("struct IGattCharacteristicNotificationTriggerFactory2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattCharacteristicNotificationTriggerFactory2 : IGattCharacteristicNotificationTriggerFactory2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGattCharacteristicNotificationTriggerFactory2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicNotificationTriggerFactory2*, Guid*, void**, int>)(lpVtbl[0]))((IGattCharacteristicNotificationTriggerFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicNotificationTriggerFactory2*, uint>)(lpVtbl[1]))((IGattCharacteristicNotificationTriggerFactory2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicNotificationTriggerFactory2*, uint>)(lpVtbl[2]))((IGattCharacteristicNotificationTriggerFactory2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicNotificationTriggerFactory2*, uint*, Guid**, int>)(lpVtbl[3]))((IGattCharacteristicNotificationTriggerFactory2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicNotificationTriggerFactory2*, HSTRING*, int>)(lpVtbl[4]))((IGattCharacteristicNotificationTriggerFactory2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicNotificationTriggerFactory2*, TrustLevel*, int>)(lpVtbl[5]))((IGattCharacteristicNotificationTriggerFactory2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattCharacteristicNotificationTriggerFactory2.xml' path='doc/member[@name="IGattCharacteristicNotificationTriggerFactory2.CreateWithEventTriggeringMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWithEventTriggeringMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattCharacteristic *")] IGattCharacteristic* characteristic, [NativeTypeName("ABI::Windows::Devices::Bluetooth::Background::BluetoothEventTriggeringMode")] BluetoothEventTriggeringMode eventTriggeringMode, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IGattCharacteristicNotificationTrigger **")] IGattCharacteristicNotificationTrigger** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicNotificationTriggerFactory2*, IGattCharacteristic*, BluetoothEventTriggeringMode, IGattCharacteristicNotificationTrigger**, int>)(lpVtbl[6]))((IGattCharacteristicNotificationTriggerFactory2*)Unsafe.AsPointer(ref this), characteristic, eventTriggeringMode, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWithEventTriggeringMode([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattCharacteristic *")] IGattCharacteristic* characteristic, [NativeTypeName("ABI::Windows::Devices::Bluetooth::Background::BluetoothEventTriggeringMode")] BluetoothEventTriggeringMode eventTriggeringMode, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IGattCharacteristicNotificationTrigger **")] IGattCharacteristicNotificationTrigger** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattCharacteristic *, ABI::Windows::Devices::Bluetooth::Background::BluetoothEventTriggeringMode, ABI::Windows::ApplicationModel::Background::IGattCharacteristicNotificationTrigger **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGattCharacteristic*, BluetoothEventTriggeringMode, IGattCharacteristicNotificationTrigger**, int> CreateWithEventTriggeringMode;
    }
}
