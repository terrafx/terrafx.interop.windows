// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICertificateStoresStatics.xml' path='doc/member[@name="ICertificateStoresStatics"]/*' />
[Guid("FBECC739-C6FE-4DE7-99CF-74C3E596E032")]
[NativeTypeName("struct ICertificateStoresStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateStoresStatics : ICertificateStoresStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICertificateStoresStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateStoresStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICertificateStoresStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateStoresStatics*, uint>)(lpVtbl[1]))((ICertificateStoresStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateStoresStatics*, uint>)(lpVtbl[2]))((ICertificateStoresStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateStoresStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICertificateStoresStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateStoresStatics*, HSTRING*, int>)(lpVtbl[4]))((ICertificateStoresStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateStoresStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICertificateStoresStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICertificateStoresStatics.xml' path='doc/member[@name="ICertificateStoresStatics.FindAllAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindAllAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<ICertificate>>>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateStoresStatics*, IAsyncOperation<Pointer<IVectorView<Pointer<ICertificate>>>>**, int>)(lpVtbl[6]))((ICertificateStoresStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateStoresStatics.xml' path='doc/member[@name="ICertificateStoresStatics.FindAllWithQueryAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindAllWithQueryAsync([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateQuery *")] ICertificateQuery* query, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<ICertificate>>>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateStoresStatics*, ICertificateQuery*, IAsyncOperation<Pointer<IVectorView<Pointer<ICertificate>>>>**, int>)(lpVtbl[7]))((ICertificateStoresStatics*)Unsafe.AsPointer(ref this), query, value);
    }

    /// <include file='ICertificateStoresStatics.xml' path='doc/member[@name="ICertificateStoresStatics.get_TrustedRootCertificationAuthorities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_TrustedRootCertificationAuthorities([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **")] ICertificateStore** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateStoresStatics*, ICertificateStore**, int>)(lpVtbl[8]))((ICertificateStoresStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateStoresStatics.xml' path='doc/member[@name="ICertificateStoresStatics.get_IntermediateCertificationAuthorities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IntermediateCertificationAuthorities([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **")] ICertificateStore** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateStoresStatics*, ICertificateStore**, int>)(lpVtbl[9]))((ICertificateStoresStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateStoresStatics.xml' path='doc/member[@name="ICertificateStoresStatics.GetStoreByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetStoreByName(HSTRING storeName, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **")] ICertificateStore** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateStoresStatics*, HSTRING, ICertificateStore**, int>)(lpVtbl[10]))((ICertificateStoresStatics*)Unsafe.AsPointer(ref this), storeName, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindAllAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<ICertificate>>>>** value);

        [VtblIndex(7)]
        HRESULT FindAllWithQueryAsync([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateQuery *")] ICertificateQuery* query, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<ICertificate>>>>** value);

        [VtblIndex(8)]
        HRESULT get_TrustedRootCertificationAuthorities([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **")] ICertificateStore** value);

        [VtblIndex(9)]
        HRESULT get_IntermediateCertificationAuthorities([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **")] ICertificateStore** value);

        [VtblIndex(10)]
        HRESULT GetStoreByName(HSTRING storeName, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **")] ICertificateStore** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<ICertificate>>>>**, int> FindAllAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificateQuery *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificateQuery*, IAsyncOperation<Pointer<IVectorView<Pointer<ICertificate>>>>**, int> FindAllWithQueryAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificateStore**, int> get_TrustedRootCertificationAuthorities;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificateStore**, int> get_IntermediateCertificationAuthorities;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Security::Cryptography::Certificates::ICertificateStore **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ICertificateStore**, int> GetStoreByName;
    }
}
