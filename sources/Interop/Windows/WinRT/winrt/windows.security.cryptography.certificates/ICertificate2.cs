// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICertificate2.xml' path='doc/member[@name="ICertificate2"]/*' />
[Guid("17B8374C-8A25-4D96-A492-8FC29AC4FDA6")]
[NativeTypeName("struct ICertificate2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificate2 : ICertificate2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICertificate2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate2*, Guid*, void**, int>)(lpVtbl[0]))((ICertificate2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate2*, uint>)(lpVtbl[1]))((ICertificate2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate2*, uint>)(lpVtbl[2]))((ICertificate2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate2*, uint*, Guid**, int>)(lpVtbl[3]))((ICertificate2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate2*, HSTRING*, int>)(lpVtbl[4]))((ICertificate2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate2*, TrustLevel*, int>)(lpVtbl[5]))((ICertificate2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICertificate2.xml' path='doc/member[@name="ICertificate2.get_IsSecurityDeviceBound"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsSecurityDeviceBound([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate2*, byte*, int>)(lpVtbl[6]))((ICertificate2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificate2.xml' path='doc/member[@name="ICertificate2.get_KeyUsages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_KeyUsages([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateKeyUsages **")] ICertificateKeyUsages** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate2*, ICertificateKeyUsages**, int>)(lpVtbl[7]))((ICertificate2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificate2.xml' path='doc/member[@name="ICertificate2.get_KeyAlgorithmName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_KeyAlgorithmName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate2*, HSTRING*, int>)(lpVtbl[8]))((ICertificate2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificate2.xml' path='doc/member[@name="ICertificate2.get_SignatureAlgorithmName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SignatureAlgorithmName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate2*, HSTRING*, int>)(lpVtbl[9]))((ICertificate2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificate2.xml' path='doc/member[@name="ICertificate2.get_SignatureHashAlgorithmName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SignatureHashAlgorithmName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate2*, HSTRING*, int>)(lpVtbl[10]))((ICertificate2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificate2.xml' path='doc/member[@name="ICertificate2.get_SubjectAlternativeName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SubjectAlternativeName([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ISubjectAlternativeNameInfo **")] ISubjectAlternativeNameInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificate2*, ISubjectAlternativeNameInfo**, int>)(lpVtbl[11]))((ICertificate2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsSecurityDeviceBound([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_KeyUsages([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateKeyUsages **")] ICertificateKeyUsages** value);

        [VtblIndex(8)]
        HRESULT get_KeyAlgorithmName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_SignatureAlgorithmName(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_SignatureHashAlgorithmName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_SubjectAlternativeName([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ISubjectAlternativeNameInfo **")] ISubjectAlternativeNameInfo** value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSecurityDeviceBound;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificateKeyUsages **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificateKeyUsages**, int> get_KeyUsages;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_KeyAlgorithmName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SignatureAlgorithmName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SignatureHashAlgorithmName;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ISubjectAlternativeNameInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISubjectAlternativeNameInfo**, int> get_SubjectAlternativeName;
    }
}
