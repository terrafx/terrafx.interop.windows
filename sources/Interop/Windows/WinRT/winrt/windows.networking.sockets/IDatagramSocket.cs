// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDatagramSocket.xml' path='doc/member[@name="IDatagramSocket"]/*' />
[Guid("7FE25BBB-C3BC-4677-8446-CA28A465A3AF")]
[NativeTypeName("struct IDatagramSocket : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDatagramSocket : IDatagramSocket.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDatagramSocket));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, Guid*, void**, int>)(lpVtbl[0]))((IDatagramSocket*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, uint>)(lpVtbl[1]))((IDatagramSocket*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, uint>)(lpVtbl[2]))((IDatagramSocket*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, uint*, Guid**, int>)(lpVtbl[3]))((IDatagramSocket*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, HSTRING*, int>)(lpVtbl[4]))((IDatagramSocket*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, TrustLevel*, int>)(lpVtbl[5]))((IDatagramSocket*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDatagramSocket.xml' path='doc/member[@name="IDatagramSocket.get_Control"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Control([NativeTypeName("ABI::Windows::Networking::Sockets::IDatagramSocketControl **")] IDatagramSocketControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, IDatagramSocketControl**, int>)(lpVtbl[6]))((IDatagramSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDatagramSocket.xml' path='doc/member[@name="IDatagramSocket.get_Information"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Information([NativeTypeName("ABI::Windows::Networking::Sockets::IDatagramSocketInformation **")] IDatagramSocketInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, IDatagramSocketInformation**, int>)(lpVtbl[7]))((IDatagramSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDatagramSocket.xml' path='doc/member[@name="IDatagramSocket.get_OutputStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OutputStream([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, IOutputStream**, int>)(lpVtbl[8]))((IDatagramSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDatagramSocket.xml' path='doc/member[@name="IDatagramSocket.ConnectAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ConnectAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* remoteHostName, HSTRING remoteServiceName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, IHostName*, HSTRING, IAsyncAction**, int>)(lpVtbl[9]))((IDatagramSocket*)Unsafe.AsPointer(ref this), remoteHostName, remoteServiceName, operation);
    }

    /// <include file='IDatagramSocket.xml' path='doc/member[@name="IDatagramSocket.ConnectWithEndpointPairAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ConnectWithEndpointPairAsync([NativeTypeName("ABI::Windows::Networking::IEndpointPair *")] IEndpointPair* endpointPair, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, IEndpointPair*, IAsyncAction**, int>)(lpVtbl[10]))((IDatagramSocket*)Unsafe.AsPointer(ref this), endpointPair, operation);
    }

    /// <include file='IDatagramSocket.xml' path='doc/member[@name="IDatagramSocket.BindServiceNameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT BindServiceNameAsync(HSTRING localServiceName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, HSTRING, IAsyncAction**, int>)(lpVtbl[11]))((IDatagramSocket*)Unsafe.AsPointer(ref this), localServiceName, operation);
    }

    /// <include file='IDatagramSocket.xml' path='doc/member[@name="IDatagramSocket.BindEndpointAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT BindEndpointAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* localHostName, HSTRING localServiceName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, IHostName*, HSTRING, IAsyncAction**, int>)(lpVtbl[12]))((IDatagramSocket*)Unsafe.AsPointer(ref this), localHostName, localServiceName, operation);
    }

    /// <include file='IDatagramSocket.xml' path='doc/member[@name="IDatagramSocket.JoinMulticastGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT JoinMulticastGroup([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* host)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, IHostName*, int>)(lpVtbl[13]))((IDatagramSocket*)Unsafe.AsPointer(ref this), host);
    }

    /// <include file='IDatagramSocket.xml' path='doc/member[@name="IDatagramSocket.GetOutputStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetOutputStreamAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* remoteHostName, HSTRING remoteServiceName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIOutputStream_t **")] IAsyncOperation<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, IHostName*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[14]))((IDatagramSocket*)Unsafe.AsPointer(ref this), remoteHostName, remoteServiceName, value);
    }

    /// <include file='IDatagramSocket.xml' path='doc/member[@name="IDatagramSocket.GetOutputStreamWithEndpointPairAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetOutputStreamWithEndpointPairAsync([NativeTypeName("ABI::Windows::Networking::IEndpointPair *")] IEndpointPair* endpointPair, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIOutputStream_t **")] IAsyncOperation<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, IEndpointPair*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[15]))((IDatagramSocket*)Unsafe.AsPointer(ref this), endpointPair, value);
    }

    /// <include file='IDatagramSocket.xml' path='doc/member[@name="IDatagramSocket.add_MessageReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_MessageReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CDatagramSocket_Windows__CNetworking__CSockets__CDatagramSocketMessageReceivedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* eventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[16]))((IDatagramSocket*)Unsafe.AsPointer(ref this), eventHandler, eventCookie);
    }

    /// <include file='IDatagramSocket.xml' path='doc/member[@name="IDatagramSocket.remove_MessageReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_MessageReceived(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IDatagramSocket*, EventRegistrationToken, int>)(lpVtbl[17]))((IDatagramSocket*)Unsafe.AsPointer(ref this), eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Control([NativeTypeName("ABI::Windows::Networking::Sockets::IDatagramSocketControl **")] IDatagramSocketControl** value);

        [VtblIndex(7)]
        HRESULT get_Information([NativeTypeName("ABI::Windows::Networking::Sockets::IDatagramSocketInformation **")] IDatagramSocketInformation** value);

        [VtblIndex(8)]
        HRESULT get_OutputStream([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** value);

        [VtblIndex(9)]
        HRESULT ConnectAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* remoteHostName, HSTRING remoteServiceName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(10)]
        HRESULT ConnectWithEndpointPairAsync([NativeTypeName("ABI::Windows::Networking::IEndpointPair *")] IEndpointPair* endpointPair, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(11)]
        HRESULT BindServiceNameAsync(HSTRING localServiceName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(12)]
        HRESULT BindEndpointAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* localHostName, HSTRING localServiceName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(13)]
        HRESULT JoinMulticastGroup([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* host);

        [VtblIndex(14)]
        HRESULT GetOutputStreamAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* remoteHostName, HSTRING remoteServiceName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIOutputStream_t **")] IAsyncOperation<IntPtr>** value);

        [VtblIndex(15)]
        HRESULT GetOutputStreamWithEndpointPairAsync([NativeTypeName("ABI::Windows::Networking::IEndpointPair *")] IEndpointPair* endpointPair, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIOutputStream_t **")] IAsyncOperation<IntPtr>** value);

        [VtblIndex(16)]
        HRESULT add_MessageReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CDatagramSocket_Windows__CNetworking__CSockets__CDatagramSocketMessageReceivedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* eventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(17)]
        HRESULT remove_MessageReceived(EventRegistrationToken eventCookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::IDatagramSocketControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDatagramSocketControl**, int> get_Control;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::IDatagramSocketInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDatagramSocketInformation**, int> get_Information;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IOutputStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IOutputStream**, int> get_OutputStream;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, HSTRING, IAsyncAction**, int> ConnectAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IEndpointPair *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEndpointPair*, IAsyncAction**, int> ConnectWithEndpointPairAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> BindServiceNameAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, HSTRING, IAsyncAction**, int> BindEndpointAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, int> JoinMulticastGroup;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIOutputStream_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, HSTRING, IAsyncOperation<IntPtr>**, int> GetOutputStreamAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IEndpointPair *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIOutputStream_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEndpointPair*, IAsyncOperation<IntPtr>**, int> GetOutputStreamWithEndpointPairAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CDatagramSocket_Windows__CNetworking__CSockets__CDatagramSocketMessageReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_MessageReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MessageReceived;
    }
}
