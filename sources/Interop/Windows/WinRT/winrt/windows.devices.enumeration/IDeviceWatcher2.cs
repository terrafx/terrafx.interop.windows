// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceWatcher2.xml' path='doc/member[@name="IDeviceWatcher2"]/*' />
[Guid("FF08456E-ED14-49E9-9A69-8117C54AE971")]
[NativeTypeName("struct IDeviceWatcher2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceWatcher2 : IDeviceWatcher2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceWatcher2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceWatcher2*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceWatcher2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceWatcher2*, uint>)(lpVtbl[1]))((IDeviceWatcher2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceWatcher2*, uint>)(lpVtbl[2]))((IDeviceWatcher2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceWatcher2*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceWatcher2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceWatcher2*, HSTRING*, int>)(lpVtbl[4]))((IDeviceWatcher2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceWatcher2*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceWatcher2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceWatcher2.xml' path='doc/member[@name="IDeviceWatcher2.GetBackgroundTrigger"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetBackgroundTrigger([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CEnumeration__CDeviceWatcherEventKind_t *")] IIterable<DeviceWatcherEventKind>* requestedEventKinds, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IDeviceWatcherTrigger **")] IDeviceWatcherTrigger** trigger)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceWatcher2*, IIterable<DeviceWatcherEventKind>*, IDeviceWatcherTrigger**, int>)(lpVtbl[6]))((IDeviceWatcher2*)Unsafe.AsPointer(ref this), requestedEventKinds, trigger);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetBackgroundTrigger([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CEnumeration__CDeviceWatcherEventKind_t *")] IIterable<DeviceWatcherEventKind>* requestedEventKinds, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IDeviceWatcherTrigger **")] IDeviceWatcherTrigger** trigger);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CEnumeration__CDeviceWatcherEventKind_t *, ABI::Windows::ApplicationModel::Background::IDeviceWatcherTrigger **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<DeviceWatcherEventKind>*, IDeviceWatcherTrigger**, int> GetBackgroundTrigger;
    }
}
