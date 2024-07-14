// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStreamWebSocket.xml' path='doc/member[@name="IStreamWebSocket"]/*' />
[Guid("BD4A49D8-B289-45BB-97EB-C7525205A843")]
[NativeTypeName("struct IStreamWebSocket : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamWebSocket : IStreamWebSocket.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamWebSocket));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket*, Guid*, void**, int>)(lpVtbl[0]))((IStreamWebSocket*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket*, uint>)(lpVtbl[1]))((IStreamWebSocket*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket*, uint>)(lpVtbl[2]))((IStreamWebSocket*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket*, uint*, Guid**, int>)(lpVtbl[3]))((IStreamWebSocket*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket*, HSTRING*, int>)(lpVtbl[4]))((IStreamWebSocket*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket*, TrustLevel*, int>)(lpVtbl[5]))((IStreamWebSocket*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStreamWebSocket.xml' path='doc/member[@name="IStreamWebSocket.get_Control"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Control([NativeTypeName("ABI::Windows::Networking::Sockets::IStreamWebSocketControl **")] IStreamWebSocketControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket*, IStreamWebSocketControl**, int>)(lpVtbl[6]))((IStreamWebSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamWebSocket.xml' path='doc/member[@name="IStreamWebSocket.get_Information"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Information([NativeTypeName("ABI::Windows::Networking::Sockets::IWebSocketInformation **")] IWebSocketInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket*, IWebSocketInformation**, int>)(lpVtbl[7]))((IStreamWebSocket*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStreamWebSocket.xml' path='doc/member[@name="IStreamWebSocket.get_InputStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InputStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamWebSocket*, IInputStream**, int>)(lpVtbl[8]))((IStreamWebSocket*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Control([NativeTypeName("ABI::Windows::Networking::Sockets::IStreamWebSocketControl **")] IStreamWebSocketControl** value);

        [VtblIndex(7)]
        HRESULT get_Information([NativeTypeName("ABI::Windows::Networking::Sockets::IWebSocketInformation **")] IWebSocketInformation** value);

        [VtblIndex(8)]
        HRESULT get_InputStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::IStreamWebSocketControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStreamWebSocketControl**, int> get_Control;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::IWebSocketInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebSocketInformation**, int> get_Information;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream**, int> get_InputStream;
    }
}
