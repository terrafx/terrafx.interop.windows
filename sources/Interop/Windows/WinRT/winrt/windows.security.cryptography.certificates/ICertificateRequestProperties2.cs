// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICertificateRequestProperties2.xml' path='doc/member[@name="ICertificateRequestProperties2"]/*' />
[Guid("3DA0C954-D73F-4FF3-A0A6-0677C0ADA05B")]
[NativeTypeName("struct ICertificateRequestProperties2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateRequestProperties2 : ICertificateRequestProperties2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICertificateRequestProperties2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties2*, Guid*, void**, int>)(lpVtbl[0]))((ICertificateRequestProperties2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties2*, uint>)(lpVtbl[1]))((ICertificateRequestProperties2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties2*, uint>)(lpVtbl[2]))((ICertificateRequestProperties2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties2*, uint*, Guid**, int>)(lpVtbl[3]))((ICertificateRequestProperties2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties2*, HSTRING*, int>)(lpVtbl[4]))((ICertificateRequestProperties2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties2*, TrustLevel*, int>)(lpVtbl[5]))((ICertificateRequestProperties2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICertificateRequestProperties2.xml' path='doc/member[@name="ICertificateRequestProperties2.get_SmartcardReaderName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SmartcardReaderName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties2*, HSTRING*, int>)(lpVtbl[6]))((ICertificateRequestProperties2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties2.xml' path='doc/member[@name="ICertificateRequestProperties2.put_SmartcardReaderName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SmartcardReaderName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties2*, HSTRING, int>)(lpVtbl[7]))((ICertificateRequestProperties2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties2.xml' path='doc/member[@name="ICertificateRequestProperties2.get_SigningCertificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SigningCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")] ICertificate** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties2*, ICertificate**, int>)(lpVtbl[8]))((ICertificateRequestProperties2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties2.xml' path='doc/member[@name="ICertificateRequestProperties2.put_SigningCertificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SigningCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")] ICertificate* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties2*, ICertificate*, int>)(lpVtbl[9]))((ICertificateRequestProperties2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties2.xml' path='doc/member[@name="ICertificateRequestProperties2.get_AttestationCredentialCertificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AttestationCredentialCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")] ICertificate** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties2*, ICertificate**, int>)(lpVtbl[10]))((ICertificateRequestProperties2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties2.xml' path='doc/member[@name="ICertificateRequestProperties2.put_AttestationCredentialCertificate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_AttestationCredentialCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")] ICertificate* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties2*, ICertificate*, int>)(lpVtbl[11]))((ICertificateRequestProperties2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SmartcardReaderName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_SmartcardReaderName(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_SigningCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")] ICertificate** value);

        [VtblIndex(9)]
        HRESULT put_SigningCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")] ICertificate* value);

        [VtblIndex(10)]
        HRESULT get_AttestationCredentialCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")] ICertificate** value);

        [VtblIndex(11)]
        HRESULT put_AttestationCredentialCertificate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")] ICertificate* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SmartcardReaderName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_SmartcardReaderName;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificate**, int> get_SigningCertificate;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificate*, int> put_SigningCertificate;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificate**, int> get_AttestationCredentialCertificate;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificate*, int> put_AttestationCredentialCertificate;
    }
}
