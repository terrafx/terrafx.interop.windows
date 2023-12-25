// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRfcommConnectionTrigger.xml' path='doc/member[@name="IRfcommConnectionTrigger"]/*' />
[Guid("E8C4CAE2-0B53-4464-9394-FD875654DE64")]
[NativeTypeName("struct IRfcommConnectionTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRfcommConnectionTrigger : IRfcommConnectionTrigger.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRfcommConnectionTrigger));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTrigger*, Guid*, void**, int>)(lpVtbl[0]))((IRfcommConnectionTrigger*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTrigger*, uint>)(lpVtbl[1]))((IRfcommConnectionTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTrigger*, uint>)(lpVtbl[2]))((IRfcommConnectionTrigger*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTrigger*, uint*, Guid**, int>)(lpVtbl[3]))((IRfcommConnectionTrigger*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTrigger*, HSTRING*, int>)(lpVtbl[4]))((IRfcommConnectionTrigger*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTrigger*, TrustLevel*, int>)(lpVtbl[5]))((IRfcommConnectionTrigger*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRfcommConnectionTrigger.xml' path='doc/member[@name="IRfcommConnectionTrigger.get_InboundConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InboundConnection([NativeTypeName("ABI::Windows::Devices::Bluetooth::Background::IRfcommInboundConnectionInformation **")] IRfcommInboundConnectionInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTrigger*, IRfcommInboundConnectionInformation**, int>)(lpVtbl[6]))((IRfcommConnectionTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommConnectionTrigger.xml' path='doc/member[@name="IRfcommConnectionTrigger.get_OutboundConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_OutboundConnection([NativeTypeName("ABI::Windows::Devices::Bluetooth::Background::IRfcommOutboundConnectionInformation **")] IRfcommOutboundConnectionInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTrigger*, IRfcommOutboundConnectionInformation**, int>)(lpVtbl[7]))((IRfcommConnectionTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommConnectionTrigger.xml' path='doc/member[@name="IRfcommConnectionTrigger.get_AllowMultipleConnections"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AllowMultipleConnections([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTrigger*, byte*, int>)(lpVtbl[8]))((IRfcommConnectionTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommConnectionTrigger.xml' path='doc/member[@name="IRfcommConnectionTrigger.put_AllowMultipleConnections"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AllowMultipleConnections([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTrigger*, byte, int>)(lpVtbl[9]))((IRfcommConnectionTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommConnectionTrigger.xml' path='doc/member[@name="IRfcommConnectionTrigger.get_ProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ProtectionLevel([NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel *")] SocketProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTrigger*, SocketProtectionLevel*, int>)(lpVtbl[10]))((IRfcommConnectionTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommConnectionTrigger.xml' path='doc/member[@name="IRfcommConnectionTrigger.put_ProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ProtectionLevel([NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")] SocketProtectionLevel value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTrigger*, SocketProtectionLevel, int>)(lpVtbl[11]))((IRfcommConnectionTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommConnectionTrigger.xml' path='doc/member[@name="IRfcommConnectionTrigger.get_RemoteHostName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RemoteHostName([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTrigger*, IHostName**, int>)(lpVtbl[12]))((IRfcommConnectionTrigger*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommConnectionTrigger.xml' path='doc/member[@name="IRfcommConnectionTrigger.put_RemoteHostName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_RemoteHostName([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommConnectionTrigger*, IHostName*, int>)(lpVtbl[13]))((IRfcommConnectionTrigger*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InboundConnection([NativeTypeName("ABI::Windows::Devices::Bluetooth::Background::IRfcommInboundConnectionInformation **")] IRfcommInboundConnectionInformation** value);

        [VtblIndex(7)]
        HRESULT get_OutboundConnection([NativeTypeName("ABI::Windows::Devices::Bluetooth::Background::IRfcommOutboundConnectionInformation **")] IRfcommOutboundConnectionInformation** value);

        [VtblIndex(8)]
        HRESULT get_AllowMultipleConnections([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_AllowMultipleConnections([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_ProtectionLevel([NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel *")] SocketProtectionLevel* value);

        [VtblIndex(11)]
        HRESULT put_ProtectionLevel([NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")] SocketProtectionLevel value);

        [VtblIndex(12)]
        HRESULT get_RemoteHostName([NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName** value);

        [VtblIndex(13)]
        HRESULT put_RemoteHostName([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Background::IRfcommInboundConnectionInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRfcommInboundConnectionInformation**, int> get_InboundConnection;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Background::IRfcommOutboundConnectionInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRfcommOutboundConnectionInformation**, int> get_OutboundConnection;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AllowMultipleConnections;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AllowMultipleConnections;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::SocketProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SocketProtectionLevel*, int> get_ProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::SocketProtectionLevel) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SocketProtectionLevel, int> put_ProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName**, int> get_RemoteHostName;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, int> put_RemoteHostName;
    }
}
