// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsMessageReceivedEventHandler.xml' path='doc/member[@name="ISmsMessageReceivedEventHandler"]/*' />
[Guid("0B7AD409-EC2D-47CE-A253-732BEEEBCACD")]
[NativeTypeName("struct ISmsMessageReceivedEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
[Obsolete("SmsMessageReceivedEventHandler may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISmsMessageReceivedEventHandler : ISmsMessageReceivedEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmsMessageReceivedEventHandler);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((ISmsMessageReceivedEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedEventHandler*, uint>)(lpVtbl[1]))((ISmsMessageReceivedEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedEventHandler*, uint>)(lpVtbl[2]))((ISmsMessageReceivedEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISmsMessageReceivedEventHandler.xml' path='doc/member[@name="ISmsMessageReceivedEventHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [Obsolete("SmsMessageReceivedEventHandler may be altered or unavailable for releases after Windows 10.")]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice *")] ISmsDevice* sender, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageReceivedEventArgs *")] ISmsMessageReceivedEventArgs* e)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageReceivedEventHandler*, ISmsDevice*, ISmsMessageReceivedEventArgs*, int>)(lpVtbl[3]))((ISmsMessageReceivedEventHandler*)Unsafe.AsPointer(ref this), sender, e);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [Obsolete("SmsMessageReceivedEventHandler may be altered or unavailable for releases after Windows 10.")]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice *")] ISmsDevice* sender, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageReceivedEventArgs *")] ISmsMessageReceivedEventArgs* e);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsDevice *, ABI::Windows::Devices::Sms::ISmsMessageReceivedEventArgs *) __attribute__((stdcall))")]
        [Obsolete("SmsMessageReceivedEventHandler may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsDevice*, ISmsMessageReceivedEventArgs*, int> Invoke;
    }
}
