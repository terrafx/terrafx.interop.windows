// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDevicePairingRequestedEventArgs.xml' path='doc/member[@name="IDevicePairingRequestedEventArgs"]/*' />
[Guid("F717FC56-DE6B-487F-8376-0180ACA69963")]
[NativeTypeName("struct IDevicePairingRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDevicePairingRequestedEventArgs : IDevicePairingRequestedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDevicePairingRequestedEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IDevicePairingRequestedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs*, uint>)(lpVtbl[1]))((IDevicePairingRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs*, uint>)(lpVtbl[2]))((IDevicePairingRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IDevicePairingRequestedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IDevicePairingRequestedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IDevicePairingRequestedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDevicePairingRequestedEventArgs.xml' path='doc/member[@name="IDevicePairingRequestedEventArgs.get_DeviceInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceInformation([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")] IDeviceInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs*, IDeviceInformation**, int>)(lpVtbl[6]))((IDevicePairingRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePairingRequestedEventArgs.xml' path='doc/member[@name="IDevicePairingRequestedEventArgs.get_PairingKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PairingKind([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingKinds *")] DevicePairingKinds* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs*, DevicePairingKinds*, int>)(lpVtbl[7]))((IDevicePairingRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePairingRequestedEventArgs.xml' path='doc/member[@name="IDevicePairingRequestedEventArgs.get_Pin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Pin(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs*, HSTRING*, int>)(lpVtbl[8]))((IDevicePairingRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDevicePairingRequestedEventArgs.xml' path='doc/member[@name="IDevicePairingRequestedEventArgs.Accept"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Accept()
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs*, int>)(lpVtbl[9]))((IDevicePairingRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDevicePairingRequestedEventArgs.xml' path='doc/member[@name="IDevicePairingRequestedEventArgs.AcceptWithPin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AcceptWithPin(HSTRING pin)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs*, HSTRING, int>)(lpVtbl[10]))((IDevicePairingRequestedEventArgs*)Unsafe.AsPointer(ref this), pin);
    }

    /// <include file='IDevicePairingRequestedEventArgs.xml' path='doc/member[@name="IDevicePairingRequestedEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingRequestedEventArgs*, IDeferral**, int>)(lpVtbl[11]))((IDevicePairingRequestedEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceInformation([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")] IDeviceInformation** value);

        [VtblIndex(7)]
        HRESULT get_PairingKind([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingKinds *")] DevicePairingKinds* value);

        [VtblIndex(8)]
        HRESULT get_Pin(HSTRING* value);

        [VtblIndex(9)]
        HRESULT Accept();

        [VtblIndex(10)]
        HRESULT AcceptWithPin(HSTRING pin);

        [VtblIndex(11)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceInformation**, int> get_DeviceInformation;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::DevicePairingKinds *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DevicePairingKinds*, int> get_PairingKind;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Pin;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Accept;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> AcceptWithPin;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
