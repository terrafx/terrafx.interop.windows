// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICertificateEnrollmentManagerStatics2.xml' path='doc/member[@name="ICertificateEnrollmentManagerStatics2"]/*' />
[Guid("DC5B1C33-6429-4014-999C-5D9735802D1D")]
[NativeTypeName("struct ICertificateEnrollmentManagerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateEnrollmentManagerStatics2 : ICertificateEnrollmentManagerStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICertificateEnrollmentManagerStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((ICertificateEnrollmentManagerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics2*, uint>)(lpVtbl[1]))((ICertificateEnrollmentManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics2*, uint>)(lpVtbl[2]))((ICertificateEnrollmentManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((ICertificateEnrollmentManagerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics2*, HSTRING*, int>)(lpVtbl[4]))((ICertificateEnrollmentManagerStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((ICertificateEnrollmentManagerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICertificateEnrollmentManagerStatics2.xml' path='doc/member[@name="ICertificateEnrollmentManagerStatics2.get_UserCertificateEnrollmentManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_UserCertificateEnrollmentManager([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::IUserCertificateEnrollmentManager **")] IUserCertificateEnrollmentManager** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics2*, IUserCertificateEnrollmentManager**, int>)(lpVtbl[6]))((ICertificateEnrollmentManagerStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateEnrollmentManagerStatics2.xml' path='doc/member[@name="ICertificateEnrollmentManagerStatics2.ImportPfxDataToKspAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ImportPfxDataToKspAsync(HSTRING pfxData, HSTRING password, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption")] ExportOption exportable, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel")] KeyProtectionLevel keyProtectionLevel, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::InstallOptions")] InstallOptions installOption, HSTRING friendlyName, HSTRING keyStorageProvider, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateEnrollmentManagerStatics2*, HSTRING, HSTRING, ExportOption, KeyProtectionLevel, InstallOptions, HSTRING, HSTRING, IAsyncAction**, int>)(lpVtbl[7]))((ICertificateEnrollmentManagerStatics2*)Unsafe.AsPointer(ref this), pfxData, password, exportable, keyProtectionLevel, installOption, friendlyName, keyStorageProvider, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_UserCertificateEnrollmentManager([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::IUserCertificateEnrollmentManager **")] IUserCertificateEnrollmentManager** value);

        [VtblIndex(7)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::IUserCertificateEnrollmentManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUserCertificateEnrollmentManager**, int> get_UserCertificateEnrollmentManager;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Security::Cryptography::Certificates::ExportOption, ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel, ABI::Windows::Security::Cryptography::Certificates::InstallOptions, HSTRING, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, ExportOption, KeyProtectionLevel, InstallOptions, HSTRING, HSTRING, IAsyncAction**, int> ImportPfxDataToKspAsync;
    }
}
