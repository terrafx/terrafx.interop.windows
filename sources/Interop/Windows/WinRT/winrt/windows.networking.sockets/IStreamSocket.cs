// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStreamSocket.xml' path='doc/member[@name="IStreamSocket"]/*' />
[Guid("69A22CF3-FC7B-4857-AF38-F6E7DE6A5B49")]
[NativeTypeName("struct IStreamSocket : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamSocket : IStreamSocket.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStreamSocket);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket*, Guid*, void**, int>)(lpVtbl[0]))((IStreamSocket*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket*, uint>)(lpVtbl[1]))((IStreamSocket*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket*, uint>)(lpVtbl[2]))((IStreamSocket*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket*, uint*, Guid**, int>)(lpVtbl[3]))((IStreamSocket*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket*, HSTRING*, int>)(lpVtbl[4]))((IStreamSocket*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket*, TrustLevel*, int>)(lpVtbl[5]))((IStreamSocket*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStreamSocket.xml' path='doc/member[@name="IStreamSocket.get_Control"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Control([NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketControl **")] IStreamSocketControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket*, IStreamSocketControl**, int>)(lpVtbl[6]))((IStreamSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocket.xml' path='doc/member[@name="IStreamSocket.get_Information"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Information([NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketInformation **")] IStreamSocketInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket*, IStreamSocketInformation**, int>)(lpVtbl[7]))((IStreamSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocket.xml' path='doc/member[@name="IStreamSocket.get_InputStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InputStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket*, IInputStream**, int>)(lpVtbl[8]))((IStreamSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocket.xml' path='doc/member[@name="IStreamSocket.get_OutputStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_OutputStream([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket*, IOutputStream**, int>)(lpVtbl[9]))((IStreamSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocket.xml' path='doc/member[@name="IStreamSocket.ConnectWithEndpointPairAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ConnectWithEndpointPairAsync([NativeTypeName("ABI::Windows::Networking::IEndpointPair *")] IEndpointPair* endpointPair, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket*, IEndpointPair*, IAsyncAction**, int>)(lpVtbl[10]))((IStreamSocket*)Unsafe.AsPointer(ref this), endpointPair, operation);
    }

    /// <include file='IStreamSocket.xml' path='doc/member[@name="IStreamSocket.ConnectAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ConnectAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* remoteHostName, HSTRING remoteServiceName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket*, IHostName*, HSTRING, IAsyncAction**, int>)(lpVtbl[11]))((IStreamSocket*)Unsafe.AsPointer(ref this), remoteHostName, remoteServiceName, operation);
    }

    /// <include file='IStreamSocket.xml' path='doc/member[@name="IStreamSocket.ConnectWithEndpointPairAndProtectionLevelAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ConnectWithEndpointPairAndProtectionLevelAsync([NativeTypeName("ABI::Windows::Networking::IEndpointPair *")] IEndpointPair* endpointPair, [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")] SocketProtectionLevel protectionLevel, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket*, IEndpointPair*, SocketProtectionLevel, IAsyncAction**, int>)(lpVtbl[12]))((IStreamSocket*)Unsafe.AsPointer(ref this), endpointPair, protectionLevel, operation);
    }

    /// <include file='IStreamSocket.xml' path='doc/member[@name="IStreamSocket.ConnectWithProtectionLevelAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ConnectWithProtectionLevelAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* remoteHostName, HSTRING remoteServiceName, [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")] SocketProtectionLevel protectionLevel, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket*, IHostName*, HSTRING, SocketProtectionLevel, IAsyncAction**, int>)(lpVtbl[13]))((IStreamSocket*)Unsafe.AsPointer(ref this), remoteHostName, remoteServiceName, protectionLevel, operation);
    }

    /// <include file='IStreamSocket.xml' path='doc/member[@name="IStreamSocket.UpgradeToSslAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT UpgradeToSslAsync([NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")] SocketProtectionLevel protectionLevel, [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* validationHostName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocket*, SocketProtectionLevel, IHostName*, IAsyncAction**, int>)(lpVtbl[14]))((IStreamSocket*)Unsafe.AsPointer(ref this), protectionLevel, validationHostName, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Control([NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketControl **")] IStreamSocketControl** value);

        [VtblIndex(7)]
        HRESULT get_Information([NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketInformation **")] IStreamSocketInformation** value);

        [VtblIndex(8)]
        HRESULT get_InputStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** value);

        [VtblIndex(9)]
        HRESULT get_OutputStream([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** value);

        [VtblIndex(10)]
        HRESULT ConnectWithEndpointPairAsync([NativeTypeName("ABI::Windows::Networking::IEndpointPair *")] IEndpointPair* endpointPair, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(11)]
        HRESULT ConnectAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* remoteHostName, HSTRING remoteServiceName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(12)]
        HRESULT ConnectWithEndpointPairAndProtectionLevelAsync([NativeTypeName("ABI::Windows::Networking::IEndpointPair *")] IEndpointPair* endpointPair, [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")] SocketProtectionLevel protectionLevel, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(13)]
        HRESULT ConnectWithProtectionLevelAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* remoteHostName, HSTRING remoteServiceName, [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")] SocketProtectionLevel protectionLevel, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(14)]
        HRESULT UpgradeToSslAsync([NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")] SocketProtectionLevel protectionLevel, [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* validationHostName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::IStreamSocketControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStreamSocketControl**, int> get_Control;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::IStreamSocketInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStreamSocketInformation**, int> get_Information;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream**, int> get_InputStream;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IOutputStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IOutputStream**, int> get_OutputStream;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IEndpointPair *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEndpointPair*, IAsyncAction**, int> ConnectWithEndpointPairAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, HSTRING, IAsyncAction**, int> ConnectAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IEndpointPair *, ABI::Windows::Networking::Sockets::SocketProtectionLevel, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEndpointPair*, SocketProtectionLevel, IAsyncAction**, int> ConnectWithEndpointPairAndProtectionLevelAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Networking::Sockets::SocketProtectionLevel, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, HSTRING, SocketProtectionLevel, IAsyncAction**, int> ConnectWithProtectionLevelAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::SocketProtectionLevel, ABI::Windows::Networking::IHostName *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SocketProtectionLevel, IHostName*, IAsyncAction**, int> UpgradeToSslAsync;
    }
}
