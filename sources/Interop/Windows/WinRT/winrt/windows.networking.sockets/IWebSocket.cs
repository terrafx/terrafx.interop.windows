// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebSocket.xml' path='doc/member[@name="IWebSocket"]/*' />
[Guid("F877396F-99B1-4E18-BC08-850C9ADF156E")]
[NativeTypeName("struct IWebSocket : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebSocket : IWebSocket.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebSocket));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocket*, Guid*, void**, int>)(lpVtbl[0]))((IWebSocket*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocket*, uint>)(lpVtbl[1]))((IWebSocket*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocket*, uint>)(lpVtbl[2]))((IWebSocket*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocket*, uint*, Guid**, int>)(lpVtbl[3]))((IWebSocket*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocket*, HSTRING*, int>)(lpVtbl[4]))((IWebSocket*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocket*, TrustLevel*, int>)(lpVtbl[5]))((IWebSocket*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebSocket.xml' path='doc/member[@name="IWebSocket.get_OutputStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OutputStream([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocket*, IOutputStream**, int>)(lpVtbl[6]))((IWebSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebSocket.xml' path='doc/member[@name="IWebSocket.ConnectAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ConnectAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocket*, IUriRuntimeClass*, IAsyncAction**, int>)(lpVtbl[7]))((IWebSocket*)Unsafe.AsPointer(ref this), uri, operation);
    }

    /// <include file='IWebSocket.xml' path='doc/member[@name="IWebSocket.SetRequestHeader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetRequestHeader(HSTRING headerName, HSTRING headerValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocket*, HSTRING, HSTRING, int>)(lpVtbl[8]))((IWebSocket*)Unsafe.AsPointer(ref this), headerName, headerValue);
    }

    /// <include file='IWebSocket.xml' path='doc/member[@name="IWebSocket.add_Closed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CIWebSocket_Windows__CNetworking__CSockets__CWebSocketClosedEventArgs_t *")] ITypedEventHandler<Pointer<IWebSocket>, Pointer<IWebSocketClosedEventArgs>>* eventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocket*, ITypedEventHandler<Pointer<IWebSocket>, Pointer<IWebSocketClosedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IWebSocket*)Unsafe.AsPointer(ref this), eventHandler, eventCookie);
    }

    /// <include file='IWebSocket.xml' path='doc/member[@name="IWebSocket.remove_Closed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_Closed(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocket*, EventRegistrationToken, int>)(lpVtbl[10]))((IWebSocket*)Unsafe.AsPointer(ref this), eventCookie);
    }

    /// <include file='IWebSocket.xml' path='doc/member[@name="IWebSocket.CloseWithStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CloseWithStatus([NativeTypeName("UINT16")] ushort code, HSTRING reason)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocket*, ushort, HSTRING, int>)(lpVtbl[11]))((IWebSocket*)Unsafe.AsPointer(ref this), code, reason);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OutputStream([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** value);

        [VtblIndex(7)]
        HRESULT ConnectAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(8)]
        HRESULT SetRequestHeader(HSTRING headerName, HSTRING headerValue);

        [VtblIndex(9)]
        HRESULT add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CIWebSocket_Windows__CNetworking__CSockets__CWebSocketClosedEventArgs_t *")] ITypedEventHandler<Pointer<IWebSocket>, Pointer<IWebSocketClosedEventArgs>>* eventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(10)]
        HRESULT remove_Closed(EventRegistrationToken eventCookie);

        [VtblIndex(11)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IOutputStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IOutputStream**, int> get_OutputStream;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncAction**, int> ConnectAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, int> SetRequestHeader;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CIWebSocket_Windows__CNetworking__CSockets__CWebSocketClosedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IWebSocket>, Pointer<IWebSocketClosedEventArgs>>*, EventRegistrationToken*, int> add_Closed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Closed;

        [NativeTypeName("HRESULT (UINT16, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, HSTRING, int> CloseWithStatus;
    }
}
