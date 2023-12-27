// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPersistedKeyProviderStatics.xml' path='doc/member[@name="IPersistedKeyProviderStatics"]/*' />
[Guid("77274814-D9D4-4CF5-B668-E0457DF30894")]
[NativeTypeName("struct IPersistedKeyProviderStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPersistedKeyProviderStatics : IPersistedKeyProviderStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistedKeyProviderStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPersistedKeyProviderStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPersistedKeyProviderStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPersistedKeyProviderStatics*, uint>)(lpVtbl[1]))((IPersistedKeyProviderStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPersistedKeyProviderStatics*, uint>)(lpVtbl[2]))((IPersistedKeyProviderStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPersistedKeyProviderStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPersistedKeyProviderStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPersistedKeyProviderStatics*, HSTRING*, int>)(lpVtbl[4]))((IPersistedKeyProviderStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPersistedKeyProviderStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPersistedKeyProviderStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPersistedKeyProviderStatics.xml' path='doc/member[@name="IPersistedKeyProviderStatics.OpenKeyPairFromCertificateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OpenKeyPairFromCertificateAsync([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")] ICertificate* certificate, HSTRING hashAlgorithmName, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPadding")] CryptographicPadding padding, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCore__CCryptographicKey_t **")] IAsyncOperation<Pointer<ICryptographicKey>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPersistedKeyProviderStatics*, ICertificate*, HSTRING, CryptographicPadding, IAsyncOperation<Pointer<ICryptographicKey>>**, int>)(lpVtbl[6]))((IPersistedKeyProviderStatics*)Unsafe.AsPointer(ref this), certificate, hashAlgorithmName, padding, operation);
    }

    /// <include file='IPersistedKeyProviderStatics.xml' path='doc/member[@name="IPersistedKeyProviderStatics.OpenPublicKeyFromCertificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OpenPublicKeyFromCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")] ICertificate* certificate, HSTRING hashAlgorithmName, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPadding")] CryptographicPadding padding, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** key)
    {
        return ((delegate* unmanaged[MemberFunction]<IPersistedKeyProviderStatics*, ICertificate*, HSTRING, CryptographicPadding, ICryptographicKey**, int>)(lpVtbl[7]))((IPersistedKeyProviderStatics*)Unsafe.AsPointer(ref this), certificate, hashAlgorithmName, padding, key);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT OpenKeyPairFromCertificateAsync([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")] ICertificate* certificate, HSTRING hashAlgorithmName, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPadding")] CryptographicPadding padding, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCore__CCryptographicKey_t **")] IAsyncOperation<Pointer<ICryptographicKey>>** operation);

        [VtblIndex(7)]
        HRESULT OpenPublicKeyFromCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")] ICertificate* certificate, HSTRING hashAlgorithmName, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPadding")] CryptographicPadding padding, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** key);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate *, HSTRING, ABI::Windows::Security::Cryptography::Core::CryptographicPadding, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCore__CCryptographicKey_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificate*, HSTRING, CryptographicPadding, IAsyncOperation<Pointer<ICryptographicKey>>**, int> OpenKeyPairFromCertificateAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate *, HSTRING, ABI::Windows::Security::Cryptography::Core::CryptographicPadding, ABI::Windows::Security::Cryptography::Core::ICryptographicKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificate*, HSTRING, CryptographicPadding, ICryptographicKey**, int> OpenPublicKeyFromCertificate;
    }
}
