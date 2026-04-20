// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyCredentialManagerStatics2.xml' path='doc/member[@name="IKeyCredentialManagerStatics2"]/*' />
[Guid("6439895D-68C5-521B-9DC4-7C199794F0D8")]
[NativeTypeName("struct IKeyCredentialManagerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyCredentialManagerStatics2 : IKeyCredentialManagerStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKeyCredentialManagerStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IKeyCredentialManagerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics2*, uint>)(lpVtbl[1]))((IKeyCredentialManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics2*, uint>)(lpVtbl[2]))((IKeyCredentialManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyCredentialManagerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics2*, HSTRING*, int>)(lpVtbl[4]))((IKeyCredentialManagerStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IKeyCredentialManagerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyCredentialManagerStatics2.xml' path='doc/member[@name="IKeyCredentialManagerStatics2.RequestCreateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestCreateAsync(HSTRING name, [NativeTypeName("ABI::Windows::Security::Credentials::KeyCredentialCreationOption")] KeyCredentialCreationOption option, HSTRING algorithm, HSTRING message, [NativeTypeName("ABI::Windows::Security::Credentials::IKeyCredentialCacheConfiguration *")] IKeyCredentialCacheConfiguration* cacheConfiguration, [NativeTypeName("ABI::Windows::UI::WindowId")] WindowId windowId, [NativeTypeName("ABI::Windows::Security::Credentials::ChallengeResponseKind")] ChallengeResponseKind callbackType, [NativeTypeName("ABI::Windows::Security::Credentials::IAttestationChallengeHandler *")] IAttestationChallengeHandler* attestationCallback, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialRetrievalResult_t **")] IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics2*, HSTRING, KeyCredentialCreationOption, HSTRING, HSTRING, IKeyCredentialCacheConfiguration*, WindowId, ChallengeResponseKind, IAttestationChallengeHandler*, IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>**, int>)(lpVtbl[6]))((IKeyCredentialManagerStatics2*)Unsafe.AsPointer(ref this), name, option, algorithm, message, cacheConfiguration, windowId, callbackType, attestationCallback, operation);
    }

    /// <include file='IKeyCredentialManagerStatics2.xml' path='doc/member[@name="IKeyCredentialManagerStatics2.OpenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OpenAsync(HSTRING name, [NativeTypeName("ABI::Windows::Security::Credentials::ChallengeResponseKind")] ChallengeResponseKind callbackType, [NativeTypeName("ABI::Windows::Security::Credentials::IAttestationChallengeHandler *")] IAttestationChallengeHandler* attestationCallback, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialRetrievalResult_t **")] IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics2*, HSTRING, ChallengeResponseKind, IAttestationChallengeHandler*, IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>**, int>)(lpVtbl[7]))((IKeyCredentialManagerStatics2*)Unsafe.AsPointer(ref this), name, callbackType, attestationCallback, operation);
    }

    /// <include file='IKeyCredentialManagerStatics2.xml' path='doc/member[@name="IKeyCredentialManagerStatics2.GetSecureId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSecureId([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredentialManagerStatics2*, IBuffer**, int>)(lpVtbl[8]))((IKeyCredentialManagerStatics2*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestCreateAsync(HSTRING name, [NativeTypeName("ABI::Windows::Security::Credentials::KeyCredentialCreationOption")] KeyCredentialCreationOption option, HSTRING algorithm, HSTRING message, [NativeTypeName("ABI::Windows::Security::Credentials::IKeyCredentialCacheConfiguration *")] IKeyCredentialCacheConfiguration* cacheConfiguration, [NativeTypeName("ABI::Windows::UI::WindowId")] WindowId windowId, [NativeTypeName("ABI::Windows::Security::Credentials::ChallengeResponseKind")] ChallengeResponseKind callbackType, [NativeTypeName("ABI::Windows::Security::Credentials::IAttestationChallengeHandler *")] IAttestationChallengeHandler* attestationCallback, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialRetrievalResult_t **")] IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>** operation);

        [VtblIndex(7)]
        HRESULT OpenAsync(HSTRING name, [NativeTypeName("ABI::Windows::Security::Credentials::ChallengeResponseKind")] ChallengeResponseKind callbackType, [NativeTypeName("ABI::Windows::Security::Credentials::IAttestationChallengeHandler *")] IAttestationChallengeHandler* attestationCallback, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialRetrievalResult_t **")] IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>** operation);

        [VtblIndex(8)]
        HRESULT GetSecureId([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Security::Credentials::KeyCredentialCreationOption, HSTRING, HSTRING, ABI::Windows::Security::Credentials::IKeyCredentialCacheConfiguration *, ABI::Windows::UI::WindowId, ABI::Windows::Security::Credentials::ChallengeResponseKind, ABI::Windows::Security::Credentials::IAttestationChallengeHandler *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialRetrievalResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, KeyCredentialCreationOption, HSTRING, HSTRING, IKeyCredentialCacheConfiguration*, WindowId, ChallengeResponseKind, IAttestationChallengeHandler*, IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>**, int> RequestCreateAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Security::Credentials::ChallengeResponseKind, ABI::Windows::Security::Credentials::IAttestationChallengeHandler *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialRetrievalResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ChallengeResponseKind, IAttestationChallengeHandler*, IAsyncOperation<Pointer<IKeyCredentialRetrievalResult>>**, int> OpenAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> GetSecureId;
    }
}
