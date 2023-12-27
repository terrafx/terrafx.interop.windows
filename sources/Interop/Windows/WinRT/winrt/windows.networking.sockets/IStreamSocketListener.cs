// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStreamSocketListener.xml' path='doc/member[@name="IStreamSocketListener"]/*' />
[Guid("FF513437-DF9F-4DF0-BF82-0EC5D7B35AAE")]
[NativeTypeName("struct IStreamSocketListener : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamSocketListener : IStreamSocketListener.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamSocketListener));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener*, Guid*, void**, int>)(lpVtbl[0]))((IStreamSocketListener*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener*, uint>)(lpVtbl[1]))((IStreamSocketListener*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener*, uint>)(lpVtbl[2]))((IStreamSocketListener*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener*, uint*, Guid**, int>)(lpVtbl[3]))((IStreamSocketListener*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener*, HSTRING*, int>)(lpVtbl[4]))((IStreamSocketListener*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener*, TrustLevel*, int>)(lpVtbl[5]))((IStreamSocketListener*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStreamSocketListener.xml' path='doc/member[@name="IStreamSocketListener.get_Control"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Control([NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketListenerControl **")] IStreamSocketListenerControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener*, IStreamSocketListenerControl**, int>)(lpVtbl[6]))((IStreamSocketListener*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketListener.xml' path='doc/member[@name="IStreamSocketListener.get_Information"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Information([NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketListenerInformation **")] IStreamSocketListenerInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener*, IStreamSocketListenerInformation**, int>)(lpVtbl[7]))((IStreamSocketListener*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamSocketListener.xml' path='doc/member[@name="IStreamSocketListener.BindServiceNameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT BindServiceNameAsync(HSTRING localServiceName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener*, HSTRING, IAsyncAction**, int>)(lpVtbl[8]))((IStreamSocketListener*)Unsafe.AsPointer(ref this), localServiceName, operation);
    }

    /// <include file='IStreamSocketListener.xml' path='doc/member[@name="IStreamSocketListener.BindEndpointAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT BindEndpointAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* localHostName, HSTRING localServiceName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener*, IHostName*, HSTRING, IAsyncAction**, int>)(lpVtbl[9]))((IStreamSocketListener*)Unsafe.AsPointer(ref this), localHostName, localServiceName, operation);
    }

    /// <include file='IStreamSocketListener.xml' path='doc/member[@name="IStreamSocketListener.add_ConnectionReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ConnectionReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CStreamSocketListener_Windows__CNetworking__CSockets__CStreamSocketListenerConnectionReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IStreamSocketListener>, Pointer<IStreamSocketListenerConnectionReceivedEventArgs>>* eventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener*, ITypedEventHandler<Pointer<IStreamSocketListener>, Pointer<IStreamSocketListenerConnectionReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IStreamSocketListener*)Unsafe.AsPointer(ref this), eventHandler, eventCookie);
    }

    /// <include file='IStreamSocketListener.xml' path='doc/member[@name="IStreamSocketListener.remove_ConnectionReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ConnectionReceived(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamSocketListener*, EventRegistrationToken, int>)(lpVtbl[11]))((IStreamSocketListener*)Unsafe.AsPointer(ref this), eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Control([NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketListenerControl **")] IStreamSocketListenerControl** value);

        [VtblIndex(7)]
        HRESULT get_Information([NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketListenerInformation **")] IStreamSocketListenerInformation** value);

        [VtblIndex(8)]
        HRESULT BindServiceNameAsync(HSTRING localServiceName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(9)]
        HRESULT BindEndpointAsync([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* localHostName, HSTRING localServiceName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(10)]
        HRESULT add_ConnectionReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CStreamSocketListener_Windows__CNetworking__CSockets__CStreamSocketListenerConnectionReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IStreamSocketListener>, Pointer<IStreamSocketListenerConnectionReceivedEventArgs>>* eventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(11)]
        HRESULT remove_ConnectionReceived(EventRegistrationToken eventCookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::IStreamSocketListenerControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStreamSocketListenerControl**, int> get_Control;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::IStreamSocketListenerInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStreamSocketListenerInformation**, int> get_Information;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> BindServiceNameAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, HSTRING, IAsyncAction**, int> BindEndpointAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CStreamSocketListener_Windows__CNetworking__CSockets__CStreamSocketListenerConnectionReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IStreamSocketListener>, Pointer<IStreamSocketListenerConnectionReceivedEventArgs>>*, EventRegistrationToken*, int> add_ConnectionReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ConnectionReceived;
    }
}
