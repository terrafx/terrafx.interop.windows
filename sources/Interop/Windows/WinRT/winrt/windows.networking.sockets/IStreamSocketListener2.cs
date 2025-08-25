// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStreamSocketListener2.xml' path='doc/member[@name="IStreamSocketListener2"]/*' />
[Guid("658DC13E-BB3E-4458-B232-ED1088694B98")]
[NativeTypeName("struct IStreamSocketListener2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamSocketListener2 : IStreamSocketListener2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStreamSocketListener2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener2*, Guid*, void**, int>)(lpVtbl[0]))((IStreamSocketListener2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener2*, uint>)(lpVtbl[1]))((IStreamSocketListener2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener2*, uint>)(lpVtbl[2]))((IStreamSocketListener2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener2*, uint*, Guid**, int>)(lpVtbl[3]))((IStreamSocketListener2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener2*, HSTRING*, int>)(lpVtbl[4]))((IStreamSocketListener2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener2*, TrustLevel*, int>)(lpVtbl[5]))((IStreamSocketListener2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStreamSocketListener2.xml' path='doc/member[@name="IStreamSocketListener2.BindServiceNameWithProtectionLevelAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BindServiceNameWithProtectionLevelAsync(HSTRING localServiceName, [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")] SocketProtectionLevel protectionLevel, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener2*, HSTRING, SocketProtectionLevel, IAsyncAction**, int>)(lpVtbl[6]))((IStreamSocketListener2*)Unsafe.AsPointer(ref this), localServiceName, protectionLevel, operation);
    }

    /// <include file='IStreamSocketListener2.xml' path='doc/member[@name="IStreamSocketListener2.BindServiceNameWithProtectionLevelAndAdapterAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT BindServiceNameWithProtectionLevelAndAdapterAsync(HSTRING localServiceName, [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")] SocketProtectionLevel protectionLevel, [NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkAdapter *")] INetworkAdapter* adapter, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener2*, HSTRING, SocketProtectionLevel, INetworkAdapter*, IAsyncAction**, int>)(lpVtbl[7]))((IStreamSocketListener2*)Unsafe.AsPointer(ref this), localServiceName, protectionLevel, adapter, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT BindServiceNameWithProtectionLevelAsync(HSTRING localServiceName, [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")] SocketProtectionLevel protectionLevel, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(7)]
        HRESULT BindServiceNameWithProtectionLevelAndAdapterAsync(HSTRING localServiceName, [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")] SocketProtectionLevel protectionLevel, [NativeTypeName("ABI::Windows::Networking::Connectivity::INetworkAdapter *")] INetworkAdapter* adapter, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Networking::Sockets::SocketProtectionLevel, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, SocketProtectionLevel, IAsyncAction**, int> BindServiceNameWithProtectionLevelAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Networking::Sockets::SocketProtectionLevel, ABI::Windows::Networking::Connectivity::INetworkAdapter *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, SocketProtectionLevel, INetworkAdapter*, IAsyncAction**, int> BindServiceNameWithProtectionLevelAndAdapterAsync;
    }
}
