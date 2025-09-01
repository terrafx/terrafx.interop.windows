// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserCertificateEnrollmentManager.xml' path='doc/member[@name="IUserCertificateEnrollmentManager"]/*' />
[Guid("96313718-22E1-4819-B20B-AB46A6ECA06E")]
[NativeTypeName("struct IUserCertificateEnrollmentManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserCertificateEnrollmentManager : IUserCertificateEnrollmentManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IUserCertificateEnrollmentManager);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager*, Guid*, void**, int>)(lpVtbl[0]))((IUserCertificateEnrollmentManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager*, uint>)(lpVtbl[1]))((IUserCertificateEnrollmentManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager*, uint>)(lpVtbl[2]))((IUserCertificateEnrollmentManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager*, uint*, Guid**, int>)(lpVtbl[3]))((IUserCertificateEnrollmentManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager*, HSTRING*, int>)(lpVtbl[4]))((IUserCertificateEnrollmentManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager*, TrustLevel*, int>)(lpVtbl[5]))((IUserCertificateEnrollmentManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserCertificateEnrollmentManager.xml' path='doc/member[@name="IUserCertificateEnrollmentManager.CreateRequestAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateRequestAsync([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateRequestProperties *")] ICertificateRequestProperties* request, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager*, ICertificateRequestProperties*, IAsyncOperation<HSTRING>**, int>)(lpVtbl[6]))((IUserCertificateEnrollmentManager*)Unsafe.AsPointer(ref this), request, value);
    }

    /// <include file='IUserCertificateEnrollmentManager.xml' path='doc/member[@name="IUserCertificateEnrollmentManager.InstallCertificateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InstallCertificateAsync(HSTRING certificate, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")] InstallOptions installOption, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager*, HSTRING, InstallOptions, IAsyncAction**, int>)(lpVtbl[7]))((IUserCertificateEnrollmentManager*)Unsafe.AsPointer(ref this), certificate, installOption, value);
    }

    /// <include file='IUserCertificateEnrollmentManager.xml' path='doc/member[@name="IUserCertificateEnrollmentManager.ImportPfxDataAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ImportPfxDataAsync(HSTRING pfxData, HSTRING password, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption")] ExportOption exportable, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel")] KeyProtectionLevel keyProtectionLevel, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")] InstallOptions installOption, HSTRING friendlyName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager*, HSTRING, HSTRING, ExportOption, KeyProtectionLevel, InstallOptions, HSTRING, IAsyncAction**, int>)(lpVtbl[8]))((IUserCertificateEnrollmentManager*)Unsafe.AsPointer(ref this), pfxData, password, exportable, keyProtectionLevel, installOption, friendlyName, value);
    }

    /// <include file='IUserCertificateEnrollmentManager.xml' path='doc/member[@name="IUserCertificateEnrollmentManager.ImportPfxDataToKspAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ImportPfxDataToKspAsync(HSTRING pfxData, HSTRING password, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption")] ExportOption exportable, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel")] KeyProtectionLevel keyProtectionLevel, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")] InstallOptions installOption, HSTRING friendlyName, HSTRING keyStorageProvider, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager*, HSTRING, HSTRING, ExportOption, KeyProtectionLevel, InstallOptions, HSTRING, HSTRING, IAsyncAction**, int>)(lpVtbl[9]))((IUserCertificateEnrollmentManager*)Unsafe.AsPointer(ref this), pfxData, password, exportable, keyProtectionLevel, installOption, friendlyName, keyStorageProvider, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateRequestAsync([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateRequestProperties *")] ICertificateRequestProperties* request, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** value);

        [VtblIndex(7)]
        HRESULT InstallCertificateAsync(HSTRING certificate, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")] InstallOptions installOption, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(8)]
        HRESULT ImportPfxDataAsync(HSTRING pfxData, HSTRING password, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption")] ExportOption exportable, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel")] KeyProtectionLevel keyProtectionLevel, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")] InstallOptions installOption, HSTRING friendlyName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(9)]
        HRESULT ImportPfxDataToKspAsync(HSTRING pfxData, HSTRING password, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption")] ExportOption exportable, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel")] KeyProtectionLevel keyProtectionLevel, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")] InstallOptions installOption, HSTRING friendlyName, HSTRING keyStorageProvider, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Security::Cryptography::Certificates::ExportOption, ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel, ABI::Windows::Security::Cryptography::Certificates::InstallOptions, HSTRING, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, ExportOption, KeyProtectionLevel, InstallOptions, HSTRING, HSTRING, IAsyncAction**, int> ImportPfxDataToKspAsync;
    }
}
