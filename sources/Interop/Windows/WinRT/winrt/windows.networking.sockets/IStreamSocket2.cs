// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStreamSocket2.xml' path='doc/member[@name="IStreamSocket2"]/*' />
[Guid("29D0E575-F314-4D09-ADF0-0FBD967FBD9F")]
[NativeTypeName("struct IStreamSocket2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamSocket2 : IStreamSocket2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamSocket2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket2*, Guid*, void**, int>)(lpVtbl[0]))((IStreamSocket2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket2*, uint>)(lpVtbl[1]))((IStreamSocket2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket2*, uint>)(lpVtbl[2]))((IStreamSocket2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket2*, uint*, Guid**, int>)(lpVtbl[3]))((IStreamSocket2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket2*, HSTRING*, int>)(lpVtbl[4]))((IStreamSocket2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket2*, TrustLevel*, int>)(lpVtbl[5]))((IStreamSocket2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStreamSocket2.xml' path='doc/member[@name="IStreamSocket2.ConnectWithProtectionLevelAndAdapterAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ConnectWithProtectionLevelAndAdapterAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* remoteHostName, HSTRING remoteServiceName, [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")] SocketProtectionLevel protectionLevel, [NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkAdapter *")] INetworkAdapter* adapter, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket2*, IHostName*, HSTRING, SocketProtectionLevel, INetworkAdapter*, IAsyncAction**, int>)(lpVtbl[6]))((IStreamSocket2*)Unsafe.AsPointer(ref this), remoteHostName, remoteServiceName, protectionLevel, adapter, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ConnectWithProtectionLevelAndAdapterAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* remoteHostName, HSTRING remoteServiceName, [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")] SocketProtectionLevel protectionLevel, [NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkAdapter *")] INetworkAdapter* adapter, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Networking::Sockets::SocketProtectionLevel, ABI::Windows::Networking::Connectivity::INetworkAdapter *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, HSTRING, SocketProtectionLevel, INetworkAdapter*, IAsyncAction**, int> ConnectWithProtectionLevelAndAdapterAsync;
    }
}
