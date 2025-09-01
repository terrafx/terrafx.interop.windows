// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDXCoreAdapterFactory1.xml' path='doc/member[@name="IDXCoreAdapterFactory1"]/*' />
[Guid("D5682E19-6D21-401C-827A-9A51A4EA35D7")]
[NativeTypeName("struct IDXCoreAdapterFactory1 : IDXCoreAdapterFactory")]
[NativeInheritance("IDXCoreAdapterFactory")]
public unsafe partial struct IDXCoreAdapterFactory1 : IDXCoreAdapterFactory1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDXCoreAdapterFactory1);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory1*, Guid*, void**, int>)(lpVtbl[0]))((IDXCoreAdapterFactory1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory1*, uint>)(lpVtbl[1]))((IDXCoreAdapterFactory1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory1*, uint>)(lpVtbl[2]))((IDXCoreAdapterFactory1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDXCoreAdapterFactory.CreateAdapterList" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateAdapterList([NativeTypeName("uint32_t")] uint numAttributes, [NativeTypeName("const GUID *")] Guid* filterAttributes, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapterList)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory1*, uint, Guid*, Guid*, void**, int>)(lpVtbl[3]))((IDXCoreAdapterFactory1*)Unsafe.AsPointer(ref this), numAttributes, filterAttributes, riid, ppvAdapterList);
    }

    /// <inheritdoc cref="IDXCoreAdapterFactory.GetAdapterByLuid" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAdapterByLuid([NativeTypeName("const LUID &")] LUID* adapterLUID, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory1*, LUID*, Guid*, void**, int>)(lpVtbl[4]))((IDXCoreAdapterFactory1*)Unsafe.AsPointer(ref this), adapterLUID, riid, ppvAdapter);
    }

    /// <inheritdoc cref="IDXCoreAdapterFactory.IsNotificationTypeSupported" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public bool IsNotificationTypeSupported(DXCoreNotificationType notificationType)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory1*, DXCoreNotificationType, bool>)(lpVtbl[5]))((IDXCoreAdapterFactory1*)Unsafe.AsPointer(ref this), notificationType);
    }

    /// <inheritdoc cref="IDXCoreAdapterFactory.RegisterEventNotification" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RegisterEventNotification(IUnknown* dxCoreObject, DXCoreNotificationType notificationType, [NativeTypeName("PFN_DXCORE_NOTIFICATION_CALLBACK")] delegate* unmanaged<DXCoreNotificationType, IUnknown*, void*, void> callbackFunction, void* callbackContext, [NativeTypeName("uint32_t *")] uint* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory1*, IUnknown*, DXCoreNotificationType, delegate* unmanaged<DXCoreNotificationType, IUnknown*, void*, void>, void*, uint*, int>)(lpVtbl[6]))((IDXCoreAdapterFactory1*)Unsafe.AsPointer(ref this), dxCoreObject, notificationType, callbackFunction, callbackContext, eventCookie);
    }

    /// <inheritdoc cref="IDXCoreAdapterFactory.UnregisterEventNotification" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnregisterEventNotification([NativeTypeName("uint32_t")] uint eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory1*, uint, int>)(lpVtbl[7]))((IDXCoreAdapterFactory1*)Unsafe.AsPointer(ref this), eventCookie);
    }

    /// <include file='IDXCoreAdapterFactory1.xml' path='doc/member[@name="IDXCoreAdapterFactory1.CreateAdapterListByWorkload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateAdapterListByWorkload(DXCoreWorkload workload, DXCoreRuntimeFilterFlags runtimeFilter, DXCoreHardwareTypeFilterFlags hardwareTypeFilter, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapterList)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapterFactory1*, DXCoreWorkload, DXCoreRuntimeFilterFlags, DXCoreHardwareTypeFilterFlags, Guid*, void**, int>)(lpVtbl[8]))((IDXCoreAdapterFactory1*)Unsafe.AsPointer(ref this), workload, runtimeFilter, hardwareTypeFilter, riid, ppvAdapterList);
    }

    public interface Interface : IDXCoreAdapterFactory.Interface
    {
        [VtblIndex(8)]
        HRESULT CreateAdapterListByWorkload(DXCoreWorkload workload, DXCoreRuntimeFilterFlags runtimeFilter, DXCoreHardwareTypeFilterFlags hardwareTypeFilter, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapterList);
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

        [NativeTypeName("HRESULT (DXCoreWorkload, DXCoreRuntimeFilterFlags, DXCoreHardwareTypeFilterFlags, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreWorkload, DXCoreRuntimeFilterFlags, DXCoreHardwareTypeFilterFlags, Guid*, void**, int> CreateAdapterListByWorkload;
    }
}
