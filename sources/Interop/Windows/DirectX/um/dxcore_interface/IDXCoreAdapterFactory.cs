// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory"]/*' />
[Guid("78EE5945-C36E-4B13-A669-005DD11C0F06")]
[NativeTypeName("struct IDXCoreAdapterFactory : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IDXCoreAdapterFactory : IDXCoreAdapterFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXCoreAdapterFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory*, Guid*, void**, int>)(lpVtbl[0]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory*, uint>)(lpVtbl[1]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory*, uint>)(lpVtbl[2]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory.CreateAdapterList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateAdapterList([NativeTypeName("uint32_t")] uint numAttributes, [NativeTypeName("const GUID *")] Guid* filterAttributes, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapterList)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory*, uint, Guid*, Guid*, void**, int>)(lpVtbl[3]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), numAttributes, filterAttributes, riid, ppvAdapterList);
    }

    /// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory.GetAdapterByLuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAdapterByLuid([NativeTypeName("const LUID &")] LUID* adapterLUID, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory*, LUID*, Guid*, void**, int>)(lpVtbl[4]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), adapterLUID, riid, ppvAdapter);
    }

    /// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory.IsNotificationTypeSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public bool IsNotificationTypeSupported(DXCoreNotificationType notificationType)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory*, DXCoreNotificationType, bool>)(lpVtbl[5]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), notificationType);
    }

    /// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory.RegisterEventNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RegisterEventNotification(IUnknown* dxCoreObject, DXCoreNotificationType notificationType, [NativeTypeName("PFN_DXCORE_NOTIFICATION_CALLBACK")] delegate* unmanaged<DXCoreNotificationType, IUnknown*, void*, void> callbackFunction, void* callbackContext, [NativeTypeName("uint32_t *")] uint* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory*, IUnknown*, DXCoreNotificationType, delegate* unmanaged<DXCoreNotificationType, IUnknown*, void*, void>, void*, uint*, int>)(lpVtbl[6]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), dxCoreObject, notificationType, callbackFunction, callbackContext, eventCookie);
    }

    /// <include file='IDXCoreAdapterFactory.xml' path='doc/member[@name="IDXCoreAdapterFactory.UnregisterEventNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnregisterEventNotification([NativeTypeName("uint32_t")] uint eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory*, uint, int>)(lpVtbl[7]))((IDXCoreAdapterFactory*)Unsafe.AsPointer(ref this), eventCookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateAdapterList([NativeTypeName("uint32_t")] uint numAttributes, [NativeTypeName("const GUID *")] Guid* filterAttributes, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapterList);

        [VtblIndex(4)]
        HRESULT GetAdapterByLuid([NativeTypeName("const LUID &")] LUID* adapterLUID, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter);

        [VtblIndex(5)]
        bool IsNotificationTypeSupported(DXCoreNotificationType notificationType);

        [VtblIndex(7)]
        HRESULT UnregisterEventNotification([NativeTypeName("uint32_t")] uint eventCookie);
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

        [NativeTypeName("HRESULT (uint32_t, const GUID *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, Guid*, void**, int> CreateAdapterList;

        [NativeTypeName("HRESULT (const LUID &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, LUID*, Guid*, void**, int> GetAdapterByLuid;

        [NativeTypeName("bool (DXCoreNotificationType) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreNotificationType, bool> IsNotificationTypeSupported;

        [NativeTypeName("HRESULT (IUnknown *, DXCoreNotificationType, PFN_DXCORE_NOTIFICATION_CALLBACK, void *, uint32_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, DXCoreNotificationType, delegate* unmanaged<DXCoreNotificationType, IUnknown*, void*, void>, void*, uint*, int> RegisterEventNotification;

        [NativeTypeName("HRESULT (uint32_t) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> UnregisterEventNotification;
    }
}
