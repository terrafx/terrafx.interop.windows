// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICertificateChain.xml' path='doc/member[@name="ICertificateChain"]/*' />
[Guid("20BF5385-3691-4501-A62C-FD97278B31EE")]
[NativeTypeName("struct ICertificateChain : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateChain : ICertificateChain.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICertificateChain));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateChain*, Guid*, void**, int>)(lpVtbl[0]))((ICertificateChain*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateChain*, uint>)(lpVtbl[1]))((ICertificateChain*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateChain*, uint>)(lpVtbl[2]))((ICertificateChain*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateChain*, uint*, Guid**, int>)(lpVtbl[3]))((ICertificateChain*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateChain*, HSTRING*, int>)(lpVtbl[4]))((ICertificateChain*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateChain*, TrustLevel*, int>)(lpVtbl[5]))((ICertificateChain*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICertificateChain.xml' path='doc/member[@name="ICertificateChain.Validate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Validate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ChainValidationResult *")] ChainValidationResult* status)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateChain*, ChainValidationResult*, int>)(lpVtbl[6]))((ICertificateChain*)Unsafe.AsPointer(ref this), status);
    }

    /// <include file='ICertificateChain.xml' path='doc/member[@name="ICertificateChain.ValidateWithParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ValidateWithParameters([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::IChainValidationParameters *")] IChainValidationParameters* parameter, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ChainValidationResult *")] ChainValidationResult* status)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateChain*, IChainValidationParameters*, ChainValidationResult*, int>)(lpVtbl[7]))((ICertificateChain*)Unsafe.AsPointer(ref this), parameter, status);
    }

    /// <include file='ICertificateChain.xml' path='doc/member[@name="ICertificateChain.GetCertificates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetCertificates([NativeTypeName("boolean")] byte includeRoot, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **")] IVectorView<IntPtr>** certificates)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateChain*, byte, IVectorView<IntPtr>**, int>)(lpVtbl[8]))((ICertificateChain*)Unsafe.AsPointer(ref this), includeRoot, certificates);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Validate([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ChainValidationResult *")] ChainValidationResult* status);

        [VtblIndex(7)]
        HRESULT ValidateWithParameters([NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::IChainValidationParameters *")] IChainValidationParameters* parameter, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ChainValidationResult *")] ChainValidationResult* status);

        [VtblIndex(8)]
        HRESULT GetCertificates([NativeTypeName("boolean")] byte includeRoot, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **")] IVectorView<IntPtr>** certificates);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::ChainValidationResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ChainValidationResult*, int> Validate;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Certificates::IChainValidationParameters *, ABI::Windows::Security::Cryptography::Certificates::ChainValidationResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IChainValidationParameters*, ChainValidationResult*, int> ValidateWithParameters;

        [NativeTypeName("HRESULT (boolean, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, IVectorView<IntPtr>**, int> GetCertificates;
    }
}
