// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebTokenRequest.xml' path='doc/member[@name="IWebTokenRequest"]/*' />
[Guid("B77B4D68-ADCB-4673-B364-0CF7B35CAF97")]
[NativeTypeName("struct IWebTokenRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebTokenRequest : IWebTokenRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWebTokenRequest);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequest*, Guid*, void**, int>)(lpVtbl[0]))((IWebTokenRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequest*, uint>)(lpVtbl[1]))((IWebTokenRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequest*, uint>)(lpVtbl[2]))((IWebTokenRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequest*, uint*, Guid**, int>)(lpVtbl[3]))((IWebTokenRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequest*, HSTRING*, int>)(lpVtbl[4]))((IWebTokenRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequest*, TrustLevel*, int>)(lpVtbl[5]))((IWebTokenRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebTokenRequest.xml' path='doc/member[@name="IWebTokenRequest.get_WebAccountProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_WebAccountProvider([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider **")] IWebAccountProvider** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequest*, IWebAccountProvider**, int>)(lpVtbl[6]))((IWebTokenRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebTokenRequest.xml' path='doc/member[@name="IWebTokenRequest.get_Scope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Scope(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequest*, HSTRING*, int>)(lpVtbl[7]))((IWebTokenRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebTokenRequest.xml' path='doc/member[@name="IWebTokenRequest.get_ClientId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ClientId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequest*, HSTRING*, int>)(lpVtbl[8]))((IWebTokenRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebTokenRequest.xml' path='doc/member[@name="IWebTokenRequest.get_PromptType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PromptType([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::WebTokenRequestPromptType *")] WebTokenRequestPromptType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequest*, WebTokenRequestPromptType*, int>)(lpVtbl[9]))((IWebTokenRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebTokenRequest.xml' path='doc/member[@name="IWebTokenRequest.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")] IMap<HSTRING, HSTRING>** requestProperties)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequest*, IMap<HSTRING, HSTRING>**, int>)(lpVtbl[10]))((IWebTokenRequest*)Unsafe.AsPointer(ref this), requestProperties);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_WebAccountProvider([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider **")] IWebAccountProvider** value);

        [VtblIndex(7)]
        HRESULT get_Scope(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_ClientId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_PromptType([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::WebTokenRequestPromptType *")] WebTokenRequestPromptType* value);

        [VtblIndex(10)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")] IMap<HSTRING, HSTRING>** requestProperties);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Scope;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ClientId;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Core::WebTokenRequestPromptType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WebTokenRequestPromptType*, int> get_PromptType;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, HSTRING>**, int> get_Properties;
    }
}
