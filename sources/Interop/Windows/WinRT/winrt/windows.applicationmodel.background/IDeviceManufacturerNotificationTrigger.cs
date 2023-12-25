// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceManufacturerNotificationTrigger.xml' path='doc/member[@name="IDeviceManufacturerNotificationTrigger"]/*' />
[Guid("81278AB5-41AB-16DA-86C2-7F7BF0912F5B")]
[NativeTypeName("struct IDeviceManufacturerNotificationTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms")]
public unsafe partial struct IDeviceManufacturerNotificationTrigger : IDeviceManufacturerNotificationTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceManufacturerNotificationTrigger));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceManufacturerNotificationTrigger*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceManufacturerNotificationTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceManufacturerNotificationTrigger*, uint>)(lpVtbl[1]))((IDeviceManufacturerNotificationTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceManufacturerNotificationTrigger*, uint>)(lpVtbl[2]))((IDeviceManufacturerNotificationTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceManufacturerNotificationTrigger*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceManufacturerNotificationTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceManufacturerNotificationTrigger*, HSTRING*, int>)(lpVtbl[4]))((IDeviceManufacturerNotificationTrigger*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceManufacturerNotificationTrigger*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceManufacturerNotificationTrigger*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceManufacturerNotificationTrigger.xml' path='doc/member[@name="IDeviceManufacturerNotificationTrigger.get_TriggerQualifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms")]
    public HRESULT get_TriggerQualifier(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceManufacturerNotificationTrigger*, HSTRING*, int>)(lpVtbl[6]))((IDeviceManufacturerNotificationTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDeviceManufacturerNotificationTrigger.xml' path='doc/member[@name="IDeviceManufacturerNotificationTrigger.get_OneShot"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms")]
    public HRESULT get_OneShot([NativeTypeName("boolean *")] byte* oneShot)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceManufacturerNotificationTrigger*, byte*, int>)(lpVtbl[7]))((IDeviceManufacturerNotificationTrigger*)Unsafe.AsPointer(ref this), oneShot);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms")]
        HRESULT get_TriggerQualifier(HSTRING* value);

        [VtblIndex(7)]
        [Obsolete("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms")]
        HRESULT get_OneShot([NativeTypeName("boolean *")] byte* oneShot);
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
        [Obsolete("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TriggerQualifier;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("DeviceManufacturerNotificationTrigger is deprecated and might not work on all platforms")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_OneShot;
    }
}
