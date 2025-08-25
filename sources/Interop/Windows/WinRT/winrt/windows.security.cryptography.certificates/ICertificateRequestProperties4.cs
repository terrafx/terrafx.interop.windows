// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICertificateRequestProperties4.xml' path='doc/member[@name="ICertificateRequestProperties4"]/*' />
[Guid("4E429AD2-1C61-4FEA-B8FE-135FB19CDCE4")]
[NativeTypeName("struct ICertificateRequestProperties4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateRequestProperties4 : ICertificateRequestProperties4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICertificateRequestProperties4);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties4*, Guid*, void**, int>)(lpVtbl[0]))((ICertificateRequestProperties4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties4*, uint>)(lpVtbl[1]))((ICertificateRequestProperties4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties4*, uint>)(lpVtbl[2]))((ICertificateRequestProperties4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties4*, uint*, Guid**, int>)(lpVtbl[3]))((ICertificateRequestProperties4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties4*, HSTRING*, int>)(lpVtbl[4]))((ICertificateRequestProperties4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties4*, TrustLevel*, int>)(lpVtbl[5]))((ICertificateRequestProperties4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICertificateRequestProperties4.xml' path='doc/member[@name="ICertificateRequestProperties4.get_SuppressedDefaults"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SuppressedDefaults([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties4*, IVector<HSTRING>**, int>)(lpVtbl[6]))((ICertificateRequestProperties4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties4.xml' path='doc/member[@name="ICertificateRequestProperties4.get_SubjectAlternativeName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SubjectAlternativeName([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ISubjectAlternativeNameInfo **")] ISubjectAlternativeNameInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties4*, ISubjectAlternativeNameInfo**, int>)(lpVtbl[7]))((ICertificateRequestProperties4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateRequestProperties4.xml' path='doc/member[@name="ICertificateRequestProperties4.get_Extensions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Extensions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSecurity__CCryptography__CCertificates__CCertificateExtension_t **")] IVector<Pointer<ICertificateExtension>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateRequestProperties4*, IVector<Pointer<ICertificateExtension>>**, int>)(lpVtbl[8]))((ICertificateRequestProperties4*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SuppressedDefaults([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(7)]
        HRESULT get_SubjectAlternativeName([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ISubjectAlternativeNameInfo **")] ISubjectAlternativeNameInfo** value);

        [VtblIndex(8)]
        HRESULT get_Extensions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSecurity__CCryptography__CCertificates__CCertificateExtension_t **")] IVector<Pointer<ICertificateExtension>>** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_SuppressedDefaults;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ISubjectAlternativeNameInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISubjectAlternativeNameInfo**, int> get_SubjectAlternativeName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSecurity__CCryptography__CCertificates__CCertificateExtension_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<ICertificateExtension>>**, int> get_Extensions;
    }
}
