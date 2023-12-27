// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMessageWebSocket.xml' path='doc/member[@name="IMessageWebSocket"]/*' />
[Guid("33727D08-34D5-4746-AD7B-8DDE5BC2EF88")]
[NativeTypeName("struct IMessageWebSocket : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMessageWebSocket : IMessageWebSocket.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMessageWebSocket));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket*, Guid*, void**, int>)(lpVtbl[0]))((IMessageWebSocket*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket*, uint>)(lpVtbl[1]))((IMessageWebSocket*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket*, uint>)(lpVtbl[2]))((IMessageWebSocket*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket*, uint*, Guid**, int>)(lpVtbl[3]))((IMessageWebSocket*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket*, HSTRING*, int>)(lpVtbl[4]))((IMessageWebSocket*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket*, TrustLevel*, int>)(lpVtbl[5]))((IMessageWebSocket*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMessageWebSocket.xml' path='doc/member[@name="IMessageWebSocket.get_Control"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Control([NativeTypeName("ABI::Windows::Networking::Sockets::IMessageWebSocketControl **")] IMessageWebSocketControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket*, IMessageWebSocketControl**, int>)(lpVtbl[6]))((IMessageWebSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMessageWebSocket.xml' path='doc/member[@name="IMessageWebSocket.get_Information"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Information([NativeTypeName("ABI::Windows::Networking::Sockets::IWebSocketInformation **")] IWebSocketInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket*, IWebSocketInformation**, int>)(lpVtbl[7]))((IMessageWebSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMessageWebSocket.xml' path='doc/member[@name="IMessageWebSocket.add_MessageReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_MessageReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CMessageWebSocket_Windows__CNetworking__CSockets__CMessageWebSocketMessageReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMessageWebSocket>, Pointer<IMessageWebSocketMessageReceivedEventArgs>>* eventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket*, ITypedEventHandler<Pointer<IMessageWebSocket>, Pointer<IMessageWebSocketMessageReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IMessageWebSocket*)Unsafe.AsPointer(ref this), eventHandler, eventCookie);
    }

    /// <include file='IMessageWebSocket.xml' path='doc/member[@name="IMessageWebSocket.remove_MessageReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_MessageReceived(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocket*, EventRegistrationToken, int>)(lpVtbl[9]))((IMessageWebSocket*)Unsafe.AsPointer(ref this), eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Control([NativeTypeName("ABI::Windows::Networking::Sockets::IMessageWebSocketControl **")] IMessageWebSocketControl** value);

        [VtblIndex(7)]
        HRESULT get_Information([NativeTypeName("ABI::Windows::Networking::Sockets::IWebSocketInformation **")] IWebSocketInformation** value);

        [VtblIndex(8)]
        HRESULT add_MessageReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CMessageWebSocket_Windows__CNetworking__CSockets__CMessageWebSocketMessageReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IMessageWebSocket>, Pointer<IMessageWebSocketMessageReceivedEventArgs>>* eventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(9)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::IMessageWebSocketControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMessageWebSocketControl**, int> get_Control;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::IWebSocketInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebSocketInformation**, int> get_Information;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CMessageWebSocket_Windows__CNetworking__CSockets__CMessageWebSocketMessageReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IMessageWebSocket>, Pointer<IMessageWebSocketMessageReceivedEventArgs>>*, EventRegistrationToken*, int> add_MessageReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MessageReceived;
    }
}
