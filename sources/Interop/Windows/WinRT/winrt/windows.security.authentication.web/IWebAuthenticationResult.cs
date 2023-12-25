// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAuthenticationResult.xml' path='doc/member[@name="IWebAuthenticationResult"]/*' />
[Guid("64002B4B-EDE9-470A-A5CD-0323FAF6E262")]
[NativeTypeName("struct IWebAuthenticationResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationResult : IWebAuthenticationResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAuthenticationResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationResult*, Guid*, void**, int>)(lpVtbl[0]))((IWebAuthenticationResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationResult*, uint>)(lpVtbl[1]))((IWebAuthenticationResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationResult*, uint>)(lpVtbl[2]))((IWebAuthenticationResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationResult*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAuthenticationResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationResult*, HSTRING*, int>)(lpVtbl[4]))((IWebAuthenticationResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationResult*, TrustLevel*, int>)(lpVtbl[5]))((IWebAuthenticationResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAuthenticationResult.xml' path='doc/member[@name="IWebAuthenticationResult.get_ResponseData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResponseData(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationResult*, HSTRING*, int>)(lpVtbl[6]))((IWebAuthenticationResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebAuthenticationResult.xml' path='doc/member[@name="IWebAuthenticationResult.get_ResponseStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ResponseStatus([NativeTypeName("ABI::Windows::Security::Authentication::Web::WebAuthenticationStatus *")] WebAuthenticationStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationResult*, WebAuthenticationStatus*, int>)(lpVtbl[7]))((IWebAuthenticationResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebAuthenticationResult.xml' path='doc/member[@name="IWebAuthenticationResult.get_ResponseErrorDetail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ResponseErrorDetail([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationResult*, uint*, int>)(lpVtbl[8]))((IWebAuthenticationResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ResponseData(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ResponseStatus([NativeTypeName("ABI::Windows::Security::Authentication::Web::WebAuthenticationStatus *")] WebAuthenticationStatus* value);

        [VtblIndex(8)]
        HRESULT get_ResponseErrorDetail([NativeTypeName("UINT32 *")] uint* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ResponseData;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::WebAuthenticationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WebAuthenticationStatus*, int> get_ResponseStatus;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ResponseErrorDetail;
    }
}
