// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsDeviceStatusChangedEventHandler.xml' path='doc/member[@name="ISmsDeviceStatusChangedEventHandler"]/*' />
[Guid("982B1162-3DD7-4618-AF89-0C272D5D06D8")]
[NativeTypeName("struct ISmsDeviceStatusChangedEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
[Obsolete("SmsDeviceStatusChangedEventHandler may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISmsDeviceStatusChangedEventHandler : ISmsDeviceStatusChangedEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsDeviceStatusChangedEventHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatusChangedEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((ISmsDeviceStatusChangedEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatusChangedEventHandler*, uint>)(lpVtbl[1]))((ISmsDeviceStatusChangedEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatusChangedEventHandler*, uint>)(lpVtbl[2]))((ISmsDeviceStatusChangedEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISmsDeviceStatusChangedEventHandler.xml' path='doc/member[@name="ISmsDeviceStatusChangedEventHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [Obsolete("SmsDeviceStatusChangedEventHandler may be altered or unavailable for releases after Windows 10.")]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice *")] ISmsDevice* sender)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatusChangedEventHandler*, ISmsDevice*, int>)(lpVtbl[3]))((ISmsDeviceStatusChangedEventHandler*)Unsafe.AsPointer(ref this), sender);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [Obsolete("SmsDeviceStatusChangedEventHandler may be altered or unavailable for releases after Windows 10.")]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice *")] ISmsDevice* sender);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsDevice *) __attribute__((stdcall))")]
        [Obsolete("SmsDeviceStatusChangedEventHandler may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsDevice*, int> Invoke;
    }
}
