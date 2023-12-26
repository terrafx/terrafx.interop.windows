// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDeviceWatcherEvent.xml' path='doc/member[@name="IDeviceWatcherEvent"]/*' />
[Guid("74AA9C0B-1DBD-47FD-B635-3CC556D0FF8B")]
[NativeTypeName("struct IDeviceWatcherEvent : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceWatcherEvent : IDeviceWatcherEvent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceWatcherEvent));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceWatcherEvent*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceWatcherEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceWatcherEvent*, uint>)(lpVtbl[1]))((IDeviceWatcherEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceWatcherEvent*, uint>)(lpVtbl[2]))((IDeviceWatcherEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceWatcherEvent*, uint*, Guid**, int>)(lpVtbl[3]))((IDeviceWatcherEvent*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceWatcherEvent*, HSTRING*, int>)(lpVtbl[4]))((IDeviceWatcherEvent*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceWatcherEvent*, TrustLevel*, int>)(lpVtbl[5]))((IDeviceWatcherEvent*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDeviceWatcherEvent.xml' path='doc/member[@name="IDeviceWatcherEvent.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceWatcherEventKind *")] DeviceWatcherEventKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceWatcherEvent*, DeviceWatcherEventKind*, int>)(lpVtbl[6]))((IDeviceWatcherEvent*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDeviceWatcherEvent.xml' path='doc/member[@name="IDeviceWatcherEvent.get_DeviceInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DeviceInformation([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")] IDeviceInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceWatcherEvent*, IDeviceInformation**, int>)(lpVtbl[7]))((IDeviceWatcherEvent*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDeviceWatcherEvent.xml' path='doc/member[@name="IDeviceWatcherEvent.get_DeviceInformationUpdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DeviceInformationUpdate([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformationUpdate **")] IDeviceInformationUpdate** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDeviceWatcherEvent*, IDeviceInformationUpdate**, int>)(lpVtbl[8]))((IDeviceWatcherEvent*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceWatcherEventKind *")] DeviceWatcherEventKind* value);

        [VtblIndex(7)]
        HRESULT get_DeviceInformation([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")] IDeviceInformation** value);

        [VtblIndex(8)]
        HRESULT get_DeviceInformationUpdate([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformationUpdate **")] IDeviceInformationUpdate** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::DeviceWatcherEventKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DeviceWatcherEventKind*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceInformation**, int> get_DeviceInformation;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformationUpdate **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceInformationUpdate**, int> get_DeviceInformationUpdate;
    }
}
