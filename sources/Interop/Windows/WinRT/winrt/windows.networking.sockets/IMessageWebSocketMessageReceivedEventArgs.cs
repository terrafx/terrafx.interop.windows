// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMessageWebSocketMessageReceivedEventArgs.xml' path='doc/member[@name="IMessageWebSocketMessageReceivedEventArgs"]/*' />
[Guid("478C22AC-4C4B-42ED-9ED7-1EF9F94FA3D5")]
[NativeTypeName("struct IMessageWebSocketMessageReceivedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMessageWebSocketMessageReceivedEventArgs : IMessageWebSocketMessageReceivedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMessageWebSocketMessageReceivedEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocketMessageReceivedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IMessageWebSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocketMessageReceivedEventArgs*, uint>)(lpVtbl[1]))((IMessageWebSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocketMessageReceivedEventArgs*, uint>)(lpVtbl[2]))((IMessageWebSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocketMessageReceivedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IMessageWebSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocketMessageReceivedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IMessageWebSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocketMessageReceivedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IMessageWebSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMessageWebSocketMessageReceivedEventArgs.xml' path='doc/member[@name="IMessageWebSocketMessageReceivedEventArgs.get_MessageType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MessageType([NativeTypeName("ABI::Windows::Networking::Sockets::SocketMessageType *")] SocketMessageType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocketMessageReceivedEventArgs*, SocketMessageType*, int>)(lpVtbl[6]))((IMessageWebSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMessageWebSocketMessageReceivedEventArgs.xml' path='doc/member[@name="IMessageWebSocketMessageReceivedEventArgs.GetDataReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDataReader([NativeTypeName("ABI::Windows::Storage::Streams::IDataReader **")] IDataReader** dataReader)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocketMessageReceivedEventArgs*, IDataReader**, int>)(lpVtbl[7]))((IMessageWebSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), dataReader);
    }

    /// <include file='IMessageWebSocketMessageReceivedEventArgs.xml' path='doc/member[@name="IMessageWebSocketMessageReceivedEventArgs.GetDataStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDataStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** inputStream)
    {
        return ((delegate* unmanaged[MemberFunction]<IMessageWebSocketMessageReceivedEventArgs*, IInputStream**, int>)(lpVtbl[8]))((IMessageWebSocketMessageReceivedEventArgs*)Unsafe.AsPointer(ref this), inputStream);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MessageType([NativeTypeName("ABI::Windows::Networking::Sockets::SocketMessageType *")] SocketMessageType* value);

        [VtblIndex(7)]
        HRESULT GetDataReader([NativeTypeName("ABI::Windows::Storage::Streams::IDataReader **")] IDataReader** dataReader);

        [VtblIndex(8)]
        HRESULT GetDataStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** inputStream);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::SocketMessageType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SocketMessageType*, int> get_MessageType;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IDataReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataReader**, int> GetDataReader;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream**, int> GetDataStream;
    }
}
