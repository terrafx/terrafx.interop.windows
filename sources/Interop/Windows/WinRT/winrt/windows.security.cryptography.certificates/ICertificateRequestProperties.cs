// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties"]/*' />
[Guid("487E84F6-94E2-4DCE-8833-1A700A37A29A")]
[NativeTypeName("struct ICertificateRequestProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateRequestProperties : ICertificateRequestProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICertificateRequestProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, Guid*, void**, int>)(lpVtbl[0]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, uint>)(lpVtbl[1]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, uint>)(lpVtbl[2]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, uint*, Guid**, int>)(lpVtbl[3]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, HSTRING*, int>)(lpVtbl[4]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, TrustLevel*, int>)(lpVtbl[5]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.get_Subject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Subject(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, HSTRING*, int>)(lpVtbl[6]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.put_Subject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Subject(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, HSTRING, int>)(lpVtbl[7]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.get_KeyAlgorithmName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_KeyAlgorithmName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, HSTRING*, int>)(lpVtbl[8]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.put_KeyAlgorithmName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_KeyAlgorithmName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, HSTRING, int>)(lpVtbl[9]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.get_KeySize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_KeySize([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, uint*, int>)(lpVtbl[10]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.put_KeySize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_KeySize([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, uint, int>)(lpVtbl[11]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.get_FriendlyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FriendlyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, HSTRING*, int>)(lpVtbl[12]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.put_FriendlyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_FriendlyName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, HSTRING, int>)(lpVtbl[13]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.get_HashAlgorithmName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_HashAlgorithmName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, HSTRING*, int>)(lpVtbl[14]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.put_HashAlgorithmName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_HashAlgorithmName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, HSTRING, int>)(lpVtbl[15]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.get_Exportable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Exportable([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption *")] ExportOption* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, ExportOption*, int>)(lpVtbl[16]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.put_Exportable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Exportable([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption")] ExportOption value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, ExportOption, int>)(lpVtbl[17]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.get_KeyUsages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_KeyUsages([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::EnrollKeyUsages *")] EnrollKeyUsages* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, EnrollKeyUsages*, int>)(lpVtbl[18]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.put_KeyUsages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_KeyUsages([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::EnrollKeyUsages")] EnrollKeyUsages value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, EnrollKeyUsages, int>)(lpVtbl[19]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.get_KeyProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_KeyProtectionLevel([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel *")] KeyProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, KeyProtectionLevel*, int>)(lpVtbl[20]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.put_KeyProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_KeyProtectionLevel([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel")] KeyProtectionLevel value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, KeyProtectionLevel, int>)(lpVtbl[21]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.get_KeyStorageProviderName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_KeyStorageProviderName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, HSTRING*, int>)(lpVtbl[22]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties.xml' path='doc/member[@name="ICertificateRequestProperties.put_KeyStorageProviderName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_KeyStorageProviderName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties*, HSTRING, int>)(lpVtbl[23]))((ICertificateRequestProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Subject(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Subject(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_KeyAlgorithmName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_KeyAlgorithmName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_KeySize([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT put_KeySize([NativeTypeName("UINT32")] uint value);

        [VtblIndex(12)]
        HRESULT get_FriendlyName(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_FriendlyName(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_HashAlgorithmName(HSTRING* value);

        [VtblIndex(15)]
        HRESULT put_HashAlgorithmName(HSTRING value);

        [VtblIndex(16)]
        HRESULT get_Exportable([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption *")] ExportOption* value);

        [VtblIndex(17)]
        HRESULT put_Exportable([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ExportOption")] ExportOption value);

        [VtblIndex(18)]
        HRESULT get_KeyUsages([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::EnrollKeyUsages *")] EnrollKeyUsages* value);

        [VtblIndex(19)]
        HRESULT put_KeyUsages([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::EnrollKeyUsages")] EnrollKeyUsages value);

        [VtblIndex(20)]
        HRESULT get_KeyProtectionLevel([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel *")] KeyProtectionLevel* value);

        [VtblIndex(21)]
        HRESULT put_KeyProtectionLevel([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel")] KeyProtectionLevel value);

        [VtblIndex(22)]
        HRESULT get_KeyStorageProviderName(HSTRING* value);

        [VtblIndex(23)]
        HRESULT put_KeyStorageProviderName(HSTRING value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Subject;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Subject;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_KeyAlgorithmName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_KeyAlgorithmName;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_KeySize;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_KeySize;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FriendlyName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_FriendlyName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HashAlgorithmName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_HashAlgorithmName;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ExportOption *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ExportOption*, int> get_Exportable;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ExportOption) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ExportOption, int> put_Exportable;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::EnrollKeyUsages *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EnrollKeyUsages*, int> get_KeyUsages;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::EnrollKeyUsages) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EnrollKeyUsages, int> put_KeyUsages;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, KeyProtectionLevel*, int> get_KeyProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::KeyProtectionLevel) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, KeyProtectionLevel, int> put_KeyProtectionLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_KeyStorageProviderName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_KeyStorageProviderName;
    }
}
