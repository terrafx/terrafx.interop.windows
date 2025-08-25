// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAuthenticationCoreManagerStatics2.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics2"]/*' />
[Guid("F584184A-8B57-4820-B6A4-70A5B6FCF44A")]
[NativeTypeName("struct IWebAuthenticationCoreManagerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationCoreManagerStatics2 : IWebAuthenticationCoreManagerStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWebAuthenticationCoreManagerStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IWebAuthenticationCoreManagerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics2*, uint>)(lpVtbl[1]))((IWebAuthenticationCoreManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics2*, uint>)(lpVtbl[2]))((IWebAuthenticationCoreManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAuthenticationCoreManagerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics2*, HSTRING*, int>)(lpVtbl[4]))((IWebAuthenticationCoreManagerStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IWebAuthenticationCoreManagerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAuthenticationCoreManagerStatics2.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics2.FindAccountProviderWithAuthorityForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindAccountProviderWithAuthorityForUserAsync(HSTRING webAccountProviderId, HSTRING authority, [NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **")] IAsyncOperation<Pointer<IWebAccountProvider>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics2*, HSTRING, HSTRING, IUser*, IAsyncOperation<Pointer<IWebAccountProvider>>**, int>)(lpVtbl[6]))((IWebAuthenticationCoreManagerStatics2*)Unsafe.AsPointer(ref this), webAccountProviderId, authority, user, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindAccountProviderWithAuthorityForUserAsync(HSTRING webAccountProviderId, HSTRING authority, [NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **")] IAsyncOperation<Pointer<IWebAccountProvider>>** asyncInfo);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::System::IUser *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IUser*, IAsyncOperation<Pointer<IWebAccountProvider>>**, int> FindAccountProviderWithAuthorityForUserAsync;
    }
}
