// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebProviderTokenRequest2.xml' path='doc/member[@name="IWebProviderTokenRequest2"]/*' />
[Guid("B5D72E4C-10B1-4AA6-88B1-0B6C9E0C1E46")]
[NativeTypeName("struct IWebProviderTokenRequest2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebProviderTokenRequest2 : IWebProviderTokenRequest2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebProviderTokenRequest2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest2*, Guid*, void**, int>)(lpVtbl[0]))((IWebProviderTokenRequest2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest2*, uint>)(lpVtbl[1]))((IWebProviderTokenRequest2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest2*, uint>)(lpVtbl[2]))((IWebProviderTokenRequest2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest2*, uint*, Guid**, int>)(lpVtbl[3]))((IWebProviderTokenRequest2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest2*, HSTRING*, int>)(lpVtbl[4]))((IWebProviderTokenRequest2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest2*, TrustLevel*, int>)(lpVtbl[5]))((IWebProviderTokenRequest2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebProviderTokenRequest2.xml' path='doc/member[@name="IWebProviderTokenRequest2.GetApplicationTokenBindingKeyIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetApplicationTokenBindingKeyIdAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::TokenBindingKeyType")] TokenBindingKeyType keyType, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* target, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<IntPtr>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest2*, TokenBindingKeyType, IUriRuntimeClass*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IWebProviderTokenRequest2*)Unsafe.AsPointer(ref this), keyType, target, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetApplicationTokenBindingKeyIdAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::TokenBindingKeyType")] TokenBindingKeyType keyType, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* target, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<IntPtr>** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::TokenBindingKeyType, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TokenBindingKeyType, IUriRuntimeClass*, IAsyncOperation<IntPtr>**, int> GetApplicationTokenBindingKeyIdAsync;
    }
}
