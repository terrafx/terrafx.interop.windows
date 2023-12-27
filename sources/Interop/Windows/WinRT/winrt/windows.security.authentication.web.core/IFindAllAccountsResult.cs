// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFindAllAccountsResult.xml' path='doc/member[@name="IFindAllAccountsResult"]/*' />
[Guid("A5812B5D-B72E-420C-86AB-AAC0D7B7261F")]
[NativeTypeName("struct IFindAllAccountsResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFindAllAccountsResult : IFindAllAccountsResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFindAllAccountsResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindAllAccountsResult*, Guid*, void**, int>)(lpVtbl[0]))((IFindAllAccountsResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFindAllAccountsResult*, uint>)(lpVtbl[1]))((IFindAllAccountsResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFindAllAccountsResult*, uint>)(lpVtbl[2]))((IFindAllAccountsResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindAllAccountsResult*, uint*, Guid**, int>)(lpVtbl[3]))((IFindAllAccountsResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindAllAccountsResult*, HSTRING*, int>)(lpVtbl[4]))((IFindAllAccountsResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindAllAccountsResult*, TrustLevel*, int>)(lpVtbl[5]))((IFindAllAccountsResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFindAllAccountsResult.xml' path='doc/member[@name="IFindAllAccountsResult.get_Accounts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Accounts([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IVectorView<Pointer<IWebAccount>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindAllAccountsResult*, IVectorView<Pointer<IWebAccount>>**, int>)(lpVtbl[6]))((IFindAllAccountsResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFindAllAccountsResult.xml' path='doc/member[@name="IFindAllAccountsResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::FindAllWebAccountsStatus *")] FindAllWebAccountsStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindAllAccountsResult*, FindAllWebAccountsStatus*, int>)(lpVtbl[7]))((IFindAllAccountsResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFindAllAccountsResult.xml' path='doc/member[@name="IFindAllAccountsResult.get_ProviderError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ProviderError([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebProviderError **")] IWebProviderError** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFindAllAccountsResult*, IWebProviderError**, int>)(lpVtbl[8]))((IFindAllAccountsResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Accounts([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IVectorView<Pointer<IWebAccount>>** value);

        [VtblIndex(7)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::FindAllWebAccountsStatus *")] FindAllWebAccountsStatus* value);

        [VtblIndex(8)]
        HRESULT get_ProviderError([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebProviderError **")] IWebProviderError** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CWebAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IWebAccount>>**, int> get_Accounts;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Core::FindAllWebAccountsStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FindAllWebAccountsStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Core::IWebProviderError **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebProviderError**, int> get_ProviderError;
    }
}
