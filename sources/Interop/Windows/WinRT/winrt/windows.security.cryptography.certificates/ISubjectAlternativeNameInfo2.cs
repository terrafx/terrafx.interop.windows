// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISubjectAlternativeNameInfo2.xml' path='doc/member[@name="ISubjectAlternativeNameInfo2"]/*' />
[Guid("437A78C6-1C51-41EA-B34A-3D654398A370")]
[NativeTypeName("struct ISubjectAlternativeNameInfo2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISubjectAlternativeNameInfo2 : ISubjectAlternativeNameInfo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISubjectAlternativeNameInfo2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISubjectAlternativeNameInfo2*, Guid*, void**, int>)(lpVtbl[0]))((ISubjectAlternativeNameInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISubjectAlternativeNameInfo2*, uint>)(lpVtbl[1]))((ISubjectAlternativeNameInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISubjectAlternativeNameInfo2*, uint>)(lpVtbl[2]))((ISubjectAlternativeNameInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISubjectAlternativeNameInfo2*, uint*, Guid**, int>)(lpVtbl[3]))((ISubjectAlternativeNameInfo2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISubjectAlternativeNameInfo2*, HSTRING*, int>)(lpVtbl[4]))((ISubjectAlternativeNameInfo2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISubjectAlternativeNameInfo2*, TrustLevel*, int>)(lpVtbl[5]))((ISubjectAlternativeNameInfo2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISubjectAlternativeNameInfo2.xml' path='doc/member[@name="ISubjectAlternativeNameInfo2.get_EmailNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EmailNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISubjectAlternativeNameInfo2*, IVector<HSTRING>**, int>)(lpVtbl[6]))((ISubjectAlternativeNameInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISubjectAlternativeNameInfo2.xml' path='doc/member[@name="ISubjectAlternativeNameInfo2.get_IPAddresses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IPAddresses([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISubjectAlternativeNameInfo2*, IVector<HSTRING>**, int>)(lpVtbl[7]))((ISubjectAlternativeNameInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISubjectAlternativeNameInfo2.xml' path='doc/member[@name="ISubjectAlternativeNameInfo2.get_Urls"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Urls([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISubjectAlternativeNameInfo2*, IVector<HSTRING>**, int>)(lpVtbl[8]))((ISubjectAlternativeNameInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISubjectAlternativeNameInfo2.xml' path='doc/member[@name="ISubjectAlternativeNameInfo2.get_DnsNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DnsNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISubjectAlternativeNameInfo2*, IVector<HSTRING>**, int>)(lpVtbl[9]))((ISubjectAlternativeNameInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISubjectAlternativeNameInfo2.xml' path='doc/member[@name="ISubjectAlternativeNameInfo2.get_DistinguishedNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DistinguishedNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISubjectAlternativeNameInfo2*, IVector<HSTRING>**, int>)(lpVtbl[10]))((ISubjectAlternativeNameInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISubjectAlternativeNameInfo2.xml' path='doc/member[@name="ISubjectAlternativeNameInfo2.get_PrincipalNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PrincipalNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISubjectAlternativeNameInfo2*, IVector<HSTRING>**, int>)(lpVtbl[11]))((ISubjectAlternativeNameInfo2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISubjectAlternativeNameInfo2.xml' path='doc/member[@name="ISubjectAlternativeNameInfo2.get_Extension"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Extension([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateExtension **")] ICertificateExtension** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISubjectAlternativeNameInfo2*, ICertificateExtension**, int>)(lpVtbl[12]))((ISubjectAlternativeNameInfo2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EmailNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(7)]
        HRESULT get_IPAddresses([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(8)]
        HRESULT get_Urls([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(9)]
        HRESULT get_DnsNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(10)]
        HRESULT get_DistinguishedNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(11)]
        HRESULT get_PrincipalNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(12)]
        HRESULT get_Extension([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificateExtension **")] ICertificateExtension** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_EmailNames;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_IPAddresses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_Urls;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_DnsNames;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_DistinguishedNames;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_PrincipalNames;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificateExtension **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICertificateExtension**, int> get_Extension;
    }
}
