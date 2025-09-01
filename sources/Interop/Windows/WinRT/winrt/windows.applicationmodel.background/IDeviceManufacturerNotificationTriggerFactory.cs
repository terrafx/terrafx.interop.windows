// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceManufacturerNotificationTriggerFactory.xml' path='doc/member[@name="IDeviceManufacturerNotificationTriggerFactory"]/*' />
[Guid("7955DE75-25BB-4153-A1A2-3029FCABB652")]
[NativeTypeName("struct IDeviceManufacturerNotificationTriggerFactory : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms")]
public unsafe partial struct IDeviceManufacturerNotificationTriggerFactory : IDeviceManufacturerNotificationTriggerFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDeviceManufacturerNotificationTriggerFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceManufacturerNotificationTriggerFactory*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceManufacturerNotificationTriggerFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceManufacturerNotificationTriggerFactory*, uint>)(lpVtbl[1]))((IDeviceManufacturerNotificationTriggerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceManufacturerNotificationTriggerFactory*, uint>)(lpVtbl[2]))((IDeviceManufacturerNotificationTriggerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceManufacturerNotificationTriggerFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceManufacturerNotificationTriggerFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceManufacturerNotificationTriggerFactory*, HSTRING*, int>)(lpVtbl[4]))((IDeviceManufacturerNotificationTriggerFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceManufacturerNotificationTriggerFactory*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceManufacturerNotificationTriggerFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceManufacturerNotificationTriggerFactory.xml' path='doc/member[@name="IDeviceManufacturerNotificationTriggerFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms")]
    public HRESULT Create(HSTRING triggerQualifier, [NativeTypeName("boolean")] byte oneShot, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IDeviceManufacturerNotificationTrigger **")] IDeviceManufacturerNotificationTrigger** trigger)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceManufacturerNotificationTriggerFactory*, HSTRING, byte, IDeviceManufacturerNotificationTrigger**, int>)(lpVtbl[6]))((IDeviceManufacturerNotificationTriggerFactory*)Unsafe.AsPointer(ref this), triggerQualifier, oneShot, trigger);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms")]
        HRESULT Create(HSTRING triggerQualifier, [NativeTypeName("boolean")] byte oneShot, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IDeviceManufacturerNotificationTrigger **")] IDeviceManufacturerNotificationTrigger** trigger);
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

        [NativeTypeName("HRESULT (HSTRING, boolean, ABI::Windows::ApplicationModel::Background::IDeviceManufacturerNotificationTrigger **) __attribute__((stdcall))")]
        [Obsolete("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte, IDeviceManufacturerNotificationTrigger**, int> Create;
    }
}
