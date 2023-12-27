// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IServerMessageWebSocket.xml' path='doc/member[@name="IServerMessageWebSocket"]/*' />
[Guid("E3AC9240-813B-5EFD-7E11-AE2305FC77F1")]
[NativeTypeName("struct IServerMessageWebSocket : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IServerMessageWebSocket : IServerMessageWebSocket.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IServerMessageWebSocket));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocket*, Guid*, void**, int>)(lpVtbl[0]))((IServerMessageWebSocket*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocket*, uint>)(lpVtbl[1]))((IServerMessageWebSocket*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocket*, uint>)(lpVtbl[2]))((IServerMessageWebSocket*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocket*, uint*, Guid**, int>)(lpVtbl[3]))((IServerMessageWebSocket*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocket*, HSTRING*, int>)(lpVtbl[4]))((IServerMessageWebSocket*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocket*, TrustLevel*, int>)(lpVtbl[5]))((IServerMessageWebSocket*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IServerMessageWebSocket.xml' path='doc/member[@name="IServerMessageWebSocket.add_MessageReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_MessageReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CServerMessageWebSocket_Windows__CNetworking__CSockets__CMessageWebSocketMessageReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IServerMessageWebSocket>, Pointer<IMessageWebSocketMessageReceivedEventArgs>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocket*, ITypedEventHandler<Pointer<IServerMessageWebSocket>, Pointer<IMessageWebSocketMessageReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IServerMessageWebSocket*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IServerMessageWebSocket.xml' path='doc/member[@name="IServerMessageWebSocket.remove_MessageReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_MessageReceived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocket*, EventRegistrationToken, int>)(lpVtbl[7]))((IServerMessageWebSocket*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IServerMessageWebSocket.xml' path='doc/member[@name="IServerMessageWebSocket.get_Control"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Control([NativeTypeName("ABI::Windows::Networking::Sockets::IServerMessageWebSocketControl **")] IServerMessageWebSocketControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocket*, IServerMessageWebSocketControl**, int>)(lpVtbl[8]))((IServerMessageWebSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IServerMessageWebSocket.xml' path='doc/member[@name="IServerMessageWebSocket.get_Information"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Information([NativeTypeName("ABI::Windows::Networking::Sockets::IServerMessageWebSocketInformation **")] IServerMessageWebSocketInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocket*, IServerMessageWebSocketInformation**, int>)(lpVtbl[9]))((IServerMessageWebSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IServerMessageWebSocket.xml' path='doc/member[@name="IServerMessageWebSocket.get_OutputStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_OutputStream([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocket*, IOutputStream**, int>)(lpVtbl[10]))((IServerMessageWebSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IServerMessageWebSocket.xml' path='doc/member[@name="IServerMessageWebSocket.add_Closed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CServerMessageWebSocket_Windows__CNetworking__CSockets__CWebSocketClosedEventArgs_t *")] ITypedEventHandler<Pointer<IServerMessageWebSocket>, Pointer<IWebSocketClosedEventArgs>>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocket*, ITypedEventHandler<Pointer<IServerMessageWebSocket>, Pointer<IWebSocketClosedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IServerMessageWebSocket*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IServerMessageWebSocket.xml' path='doc/member[@name="IServerMessageWebSocket.remove_Closed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_Closed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocket*, EventRegistrationToken, int>)(lpVtbl[12]))((IServerMessageWebSocket*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IServerMessageWebSocket.xml' path='doc/member[@name="IServerMessageWebSocket.CloseWithStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CloseWithStatus([NativeTypeName("UINT16")] ushort code, HSTRING reason)
    {
        return ((delegate* unmanaged[MemberFunction]<IServerMessageWebSocket*, ushort, HSTRING, int>)(lpVtbl[13]))((IServerMessageWebSocket*)Unsafe.AsPointer(ref this), code, reason);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_MessageReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CServerMessageWebSocket_Windows__CNetworking__CSockets__CMessageWebSocketMessageReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IServerMessageWebSocket>, Pointer<IMessageWebSocketMessageReceivedEventArgs>>* value, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_MessageReceived(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT get_Control([NativeTypeName("ABI::Windows::Networking::Sockets::IServerMessageWebSocketControl **")] IServerMessageWebSocketControl** value);

        [VtblIndex(9)]
        HRESULT get_Information([NativeTypeName("ABI::Windows::Networking::Sockets::IServerMessageWebSocketInformation **")] IServerMessageWebSocketInformation** value);

        [VtblIndex(10)]
        HRESULT get_OutputStream([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** value);

        [VtblIndex(11)]
        HRESULT add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CServerMessageWebSocket_Windows__CNetworking__CSockets__CWebSocketClosedEventArgs_t *")] ITypedEventHandler<Pointer<IServerMessageWebSocket>, Pointer<IWebSocketClosedEventArgs>>* value, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_Closed(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT CloseWithStatus([NativeTypeName("UINT16")] ushort code, HSTRING reason);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CServerMessageWebSocket_Windows__CNetworking__CSockets__CMessageWebSocketMessageReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IServerMessageWebSocket>, Pointer<IMessageWebSocketMessageReceivedEventArgs>>*, EventRegistrationToken*, int> add_MessageReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MessageReceived;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::IServerMessageWebSocketControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IServerMessageWebSocketControl**, int> get_Control;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::IServerMessageWebSocketInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IServerMessageWebSocketInformation**, int> get_Information;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IOutputStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IOutputStream**, int> get_OutputStream;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CServerMessageWebSocket_Windows__CNetworking__CSockets__CWebSocketClosedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IServerMessageWebSocket>, Pointer<IWebSocketClosedEventArgs>>*, EventRegistrationToken*, int> add_Closed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Closed;

        [NativeTypeName("HRESULT (UINT16, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, HSTRING, int> CloseWithStatus;
    }
}
