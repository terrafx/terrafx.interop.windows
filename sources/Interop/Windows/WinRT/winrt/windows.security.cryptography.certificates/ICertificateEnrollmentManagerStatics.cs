// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICertificateEnrollmentManagerStatics.xml' path='doc/member[@name="ICertificateEnrollmentManagerStatics"]/*' />
[Guid("8846EF3F-A986-48FB-9FD7-9AEC06935BF1")]
[NativeTypeName("struct ICertificateEnrollmentManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateEnrollmentManagerStatics : ICertificateEnrollmentManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICertificateEnrollmentManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICertificateEnrollmentManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics*, uint>)(lpVtbl[1]))((ICertificateEnrollmentManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics*, uint>)(lpVtbl[2]))((ICertificateEnrollmentManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICertificateEnrollmentManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((ICertificateEnrollmentManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICertificateEnrollmentManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICertificateEnrollmentManagerStatics.xml' path='doc/member[@name="ICertificateEnrollmentManagerStatics.CreateRequestAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateRequestAsync([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateRequestProperties *")] ICertificateRequestProperties* request, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics*, ICertificateRequestProperties*, IAsyncOperation<HSTRING>**, int>)(lpVtbl[6]))((ICertificateEnrollmentManagerStatics*)Unsafe.AsPointer(ref this), request, value);
    }

    /// <include file='ICertificateEnrollmentManagerStatics.xml' path='doc/member[@name="ICertificateEnrollmentManagerStatics.InstallCertificateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InstallCertificateAsync(HSTRING certificate, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")] InstallOptions installOption, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics*, HSTRING, InstallOptions, IAsyncAction**, int>)(lpVtbl[7]))((ICertificateEnrollmentManagerStatics*)Unsafe.AsPointer(ref this), certificate, installOption, value);
    }

    /// <include file='ICertificateEnrollmentManagerStatics.xml' path='doc/member[@name="ICertificateEnrollmentManagerStatics.ImportPfxDataAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ImportPfxDataAsync(HSTRING pfxData, HSTRING password, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption")] ExportOption exportable, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel")] KeyProtectionLevel keyProtectionLevel, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")] InstallOptions installOption, HSTRING friendlyName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics*, HSTRING, HSTRING, ExportOption, KeyProtectionLevel, InstallOptions, HSTRING, IAsyncAction**, int>)(lpVtbl[8]))((ICertificateEnrollmentManagerStatics*)Unsafe.AsPointer(ref this), pfxData, password, exportable, keyProtectionLevel, installOption, friendlyName, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateRequestAsync([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateRequestProperties *")] ICertificateRequestProperties* request, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** value);

        [VtblIndex(7)]
        HRESULT InstallCertificateAsync(HSTRING certificate, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")] InstallOptions installOption, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(8)]
        HRESULT ImportPfxDataAsync(HSTRING pfxData, HSTRING password, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption")] ExportOption exportable, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel")] KeyProtectionLevel keyProtectionLevel, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")] InstallOptions installOption, HSTRING friendlyName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificateRequestProperties *, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificateRequestProperties*, IAsyncOperation<HSTRING>**, int> CreateRequestAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Security::Cryptography::Certificates::InstallOptions, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, InstallOptions, IAsyncAction**, int> InstallCertificateAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Security::Cryptography::Certificates::ExportOption, ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel, ABI::Windows::Security::Cryptography::Certificates::InstallOptions, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, ExportOption, KeyProtectionLevel, InstallOptions, HSTRING, IAsyncAction**, int> ImportPfxDataAsync;
    }
}
