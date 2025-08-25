// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserCertificateEnrollmentManager2.xml' path='doc/member[@name="IUserCertificateEnrollmentManager2"]/*' />
[Guid("0DAD9CB1-65DE-492A-B86D-FC5C482C3747")]
[NativeTypeName("struct IUserCertificateEnrollmentManager2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserCertificateEnrollmentManager2 : IUserCertificateEnrollmentManager2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IUserCertificateEnrollmentManager2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager2*, Guid*, void**, int>)(lpVtbl[0]))((IUserCertificateEnrollmentManager2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager2*, uint>)(lpVtbl[1]))((IUserCertificateEnrollmentManager2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager2*, uint>)(lpVtbl[2]))((IUserCertificateEnrollmentManager2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager2*, uint*, Guid**, int>)(lpVtbl[3]))((IUserCertificateEnrollmentManager2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager2*, HSTRING*, int>)(lpVtbl[4]))((IUserCertificateEnrollmentManager2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager2*, TrustLevel*, int>)(lpVtbl[5]))((IUserCertificateEnrollmentManager2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserCertificateEnrollmentManager2.xml' path='doc/member[@name="IUserCertificateEnrollmentManager2.ImportPfxDataToKspWithParametersAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ImportPfxDataToKspWithParametersAsync(HSTRING pfxData, HSTRING password, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::IPfxImportParameters *")] IPfxImportParameters* pfxImportParameters, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserCertificateEnrollmentManager2*, HSTRING, HSTRING, IPfxImportParameters*, IAsyncAction**, int>)(lpVtbl[6]))((IUserCertificateEnrollmentManager2*)Unsafe.AsPointer(ref this), pfxData, password, pfxImportParameters, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ImportPfxDataToKspWithParametersAsync(HSTRING pfxData, HSTRING password, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::IPfxImportParameters *")] IPfxImportParameters* pfxImportParameters, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Security::Cryptography::Certificates::IPfxImportParameters *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IPfxImportParameters*, IAsyncAction**, int> ImportPfxDataToKspWithParametersAsync;
    }
}
