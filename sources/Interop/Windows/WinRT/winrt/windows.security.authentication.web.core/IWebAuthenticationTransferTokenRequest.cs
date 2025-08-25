// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAuthenticationTransferTokenRequest.xml' path='doc/member[@name="IWebAuthenticationTransferTokenRequest"]/*' />
[Guid("7ACFA5B6-529D-5E76-9846-F3FD999304D0")]
[NativeTypeName("struct IWebAuthenticationTransferTokenRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationTransferTokenRequest : IWebAuthenticationTransferTokenRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWebAuthenticationTransferTokenRequest);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequest*, Guid*, void**, int>)(lpVtbl[0]))((IWebAuthenticationTransferTokenRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequest*, uint>)(lpVtbl[1]))((IWebAuthenticationTransferTokenRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequest*, uint>)(lpVtbl[2]))((IWebAuthenticationTransferTokenRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequest*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAuthenticationTransferTokenRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequest*, HSTRING*, int>)(lpVtbl[4]))((IWebAuthenticationTransferTokenRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequest*, TrustLevel*, int>)(lpVtbl[5]))((IWebAuthenticationTransferTokenRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAuthenticationTransferTokenRequest.xml' path='doc/member[@name="IWebAuthenticationTransferTokenRequest.get_WebAccountProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_WebAccountProvider([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider **")] IWebAccountProvider** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequest*, IWebAccountProvider**, int>)(lpVtbl[6]))((IWebAuthenticationTransferTokenRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebAuthenticationTransferTokenRequest.xml' path='doc/member[@name="IWebAuthenticationTransferTokenRequest.get_TransferToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TransferToken(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequest*, HSTRING*, int>)(lpVtbl[7]))((IWebAuthenticationTransferTokenRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebAuthenticationTransferTokenRequest.xml' path='doc/member[@name="IWebAuthenticationTransferTokenRequest.put_TransferToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_TransferToken(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequest*, HSTRING, int>)(lpVtbl[8]))((IWebAuthenticationTransferTokenRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebAuthenticationTransferTokenRequest.xml' path='doc/member[@name="IWebAuthenticationTransferTokenRequest.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")] IMap<HSTRING, HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequest*, IMap<HSTRING, HSTRING>**, int>)(lpVtbl[9]))((IWebAuthenticationTransferTokenRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebAuthenticationTransferTokenRequest.xml' path='doc/member[@name="IWebAuthenticationTransferTokenRequest.get_CorrelationId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CorrelationId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequest*, HSTRING*, int>)(lpVtbl[10]))((IWebAuthenticationTransferTokenRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebAuthenticationTransferTokenRequest.xml' path='doc/member[@name="IWebAuthenticationTransferTokenRequest.put_CorrelationId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_CorrelationId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequest*, HSTRING, int>)(lpVtbl[11]))((IWebAuthenticationTransferTokenRequest*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_WebAccountProvider([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider **")] IWebAccountProvider** value);

        [VtblIndex(7)]
        HRESULT get_TransferToken(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_TransferToken(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")] IMap<HSTRING, HSTRING>** value);

        [VtblIndex(10)]
        HRESULT get_CorrelationId(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_CorrelationId(HSTRING value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccountProvider**, int> get_WebAccountProvider;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TransferToken;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_TransferToken;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, HSTRING>**, int> get_Properties;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CorrelationId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_CorrelationId;
    }
}
