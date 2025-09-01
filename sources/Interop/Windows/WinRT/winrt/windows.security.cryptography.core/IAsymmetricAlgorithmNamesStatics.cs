// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics"]/*' />
[Guid("CAF6FCE4-67C0-46AA-84F9-752E77449F9B")]
[NativeTypeName("struct IAsymmetricAlgorithmNamesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAsymmetricAlgorithmNamesStatics : IAsymmetricAlgorithmNamesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAsymmetricAlgorithmNamesStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, uint>)(lpVtbl[1]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, uint>)(lpVtbl[2]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[4]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_RsaPkcs1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_RsaPkcs1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[6]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_RsaOaepSha1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RsaOaepSha1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[7]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_RsaOaepSha256"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RsaOaepSha256(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[8]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_RsaOaepSha384"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_RsaOaepSha384(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[9]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_RsaOaepSha512"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RsaOaepSha512(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[10]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_EcdsaP256Sha256"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_EcdsaP256Sha256(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[11]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_EcdsaP384Sha384"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_EcdsaP384Sha384(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[12]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_EcdsaP521Sha512"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_EcdsaP521Sha512(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[13]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_DsaSha1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_DsaSha1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[14]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_DsaSha256"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_DsaSha256(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[15]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_RsaSignPkcs1Sha1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_RsaSignPkcs1Sha1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[16]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_RsaSignPkcs1Sha256"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_RsaSignPkcs1Sha256(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[17]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_RsaSignPkcs1Sha384"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_RsaSignPkcs1Sha384(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[18]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_RsaSignPkcs1Sha512"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_RsaSignPkcs1Sha512(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[19]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_RsaSignPssSha1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_RsaSignPssSha1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[20]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_RsaSignPssSha256"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_RsaSignPssSha256(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[21]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_RsaSignPssSha384"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_RsaSignPssSha384(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[22]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="IAsymmetricAlgorithmNamesStatics.get_RsaSignPssSha512"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_RsaSignPssSha512(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[23]))((IAsymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_RsaPkcs1(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_RsaOaepSha1(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_RsaOaepSha256(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_RsaOaepSha384(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_RsaOaepSha512(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_EcdsaP256Sha256(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_EcdsaP384Sha384(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_EcdsaP521Sha512(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_DsaSha1(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_DsaSha256(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_RsaSignPkcs1Sha1(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_RsaSignPkcs1Sha256(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_RsaSignPkcs1Sha384(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_RsaSignPkcs1Sha512(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_RsaSignPssSha1(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_RsaSignPssSha256(HSTRING* value);

        [VtblIndex(22)]
        HRESULT get_RsaSignPssSha384(HSTRING* value);

        [VtblIndex(23)]
        HRESULT get_RsaSignPssSha512(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RsaPkcs1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RsaOaepSha1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RsaOaepSha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RsaOaepSha384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RsaOaepSha512;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_EcdsaP256Sha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_EcdsaP384Sha384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_EcdsaP521Sha512;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DsaSha1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DsaSha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RsaSignPkcs1Sha1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RsaSignPkcs1Sha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RsaSignPkcs1Sha384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RsaSignPkcs1Sha512;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RsaSignPssSha1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RsaSignPssSha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RsaSignPssSha384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RsaSignPssSha512;
    }
}
