// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebSocketControl.xml' path='doc/member[@name="IWebSocketControl"]/*' />
[Guid("2EC4BDC3-D9A5-455A-9811-DE24D45337E9")]
[NativeTypeName("struct IWebSocketControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebSocketControl : IWebSocketControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebSocketControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketControl*, Guid*, void**, int>)(lpVtbl[0]))((IWebSocketControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketControl*, uint>)(lpVtbl[1]))((IWebSocketControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketControl*, uint>)(lpVtbl[2]))((IWebSocketControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketControl*, uint*, Guid**, int>)(lpVtbl[3]))((IWebSocketControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketControl*, HSTRING*, int>)(lpVtbl[4]))((IWebSocketControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketControl*, TrustLevel*, int>)(lpVtbl[5]))((IWebSocketControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebSocketControl.xml' path='doc/member[@name="IWebSocketControl.get_OutboundBufferSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OutboundBufferSizeInBytes([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketControl*, uint*, int>)(lpVtbl[6]))((IWebSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebSocketControl.xml' path='doc/member[@name="IWebSocketControl.put_OutboundBufferSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_OutboundBufferSizeInBytes([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketControl*, uint, int>)(lpVtbl[7]))((IWebSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebSocketControl.xml' path='doc/member[@name="IWebSocketControl.get_ServerCredential"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ServerCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")] IPasswordCredential** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketControl*, IPasswordCredential**, int>)(lpVtbl[8]))((IWebSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebSocketControl.xml' path='doc/member[@name="IWebSocketControl.put_ServerCredential"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ServerCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")] IPasswordCredential* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketControl*, IPasswordCredential*, int>)(lpVtbl[9]))((IWebSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebSocketControl.xml' path='doc/member[@name="IWebSocketControl.get_ProxyCredential"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ProxyCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")] IPasswordCredential** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketControl*, IPasswordCredential**, int>)(lpVtbl[10]))((IWebSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebSocketControl.xml' path='doc/member[@name="IWebSocketControl.put_ProxyCredential"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ProxyCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")] IPasswordCredential* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketControl*, IPasswordCredential*, int>)(lpVtbl[11]))((IWebSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebSocketControl.xml' path='doc/member[@name="IWebSocketControl.get_SupportedProtocols"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SupportedProtocols([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebSocketControl*, IVector<HSTRING>**, int>)(lpVtbl[12]))((IWebSocketControl*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OutboundBufferSizeInBytes([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT put_OutboundBufferSizeInBytes([NativeTypeName("UINT32")] uint value);

        [VtblIndex(8)]
        HRESULT get_ServerCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")] IPasswordCredential** value);

        [VtblIndex(9)]
        HRESULT put_ServerCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")] IPasswordCredential* value);

        [VtblIndex(10)]
        HRESULT get_ProxyCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")] IPasswordCredential** value);

        [VtblIndex(11)]
        HRESULT put_ProxyCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")] IPasswordCredential* value);

        [VtblIndex(12)]
        HRESULT get_SupportedProtocols([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_OutboundBufferSizeInBytes;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_OutboundBufferSizeInBytes;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPasswordCredential**, int> get_ServerCredential;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPasswordCredential*, int> put_ServerCredential;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPasswordCredential**, int> get_ProxyCredential;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPasswordCredential*, int> put_ProxyCredential;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_SupportedProtocols;
    }
}
