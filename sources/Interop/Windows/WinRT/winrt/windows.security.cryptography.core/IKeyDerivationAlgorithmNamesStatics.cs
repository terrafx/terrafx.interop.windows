// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyDerivationAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics"]/*' />
[Guid("7B6E363E-94D2-4739-A57B-022E0C3A402A")]
[NativeTypeName("struct IKeyDerivationAlgorithmNamesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyDerivationAlgorithmNamesStatics : IKeyDerivationAlgorithmNamesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKeyDerivationAlgorithmNamesStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, uint>)(lpVtbl[1]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, uint>)(lpVtbl[2]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[4]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics.get_Pbkdf2Md5"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Pbkdf2Md5(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[6]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics.get_Pbkdf2Sha1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Pbkdf2Sha1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[7]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics.get_Pbkdf2Sha256"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Pbkdf2Sha256(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[8]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics.get_Pbkdf2Sha384"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Pbkdf2Sha384(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[9]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics.get_Pbkdf2Sha512"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Pbkdf2Sha512(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[10]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics.get_Sp800108CtrHmacMd5"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Sp800108CtrHmacMd5(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[11]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics.get_Sp800108CtrHmacSha1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Sp800108CtrHmacSha1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[12]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics.get_Sp800108CtrHmacSha256"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Sp800108CtrHmacSha256(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[13]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics.get_Sp800108CtrHmacSha384"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Sp800108CtrHmacSha384(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[14]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics.get_Sp800108CtrHmacSha512"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Sp800108CtrHmacSha512(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[15]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics.get_Sp80056aConcatMd5"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Sp80056aConcatMd5(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[16]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics.get_Sp80056aConcatSha1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Sp80056aConcatSha1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[17]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics.get_Sp80056aConcatSha256"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Sp80056aConcatSha256(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[18]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics.get_Sp80056aConcatSha384"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_Sp80056aConcatSha384(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[19]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics.get_Sp80056aConcatSha512"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Sp80056aConcatSha512(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[20]))((IKeyDerivationAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Pbkdf2Md5(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Pbkdf2Sha1(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Pbkdf2Sha256(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Pbkdf2Sha384(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Pbkdf2Sha512(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Sp800108CtrHmacMd5(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Sp800108CtrHmacSha1(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_Sp800108CtrHmacSha256(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_Sp800108CtrHmacSha384(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_Sp800108CtrHmacSha512(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_Sp80056aConcatMd5(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_Sp80056aConcatSha1(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_Sp80056aConcatSha256(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_Sp80056aConcatSha384(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_Sp80056aConcatSha512(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Pbkdf2Md5;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Pbkdf2Sha1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Pbkdf2Sha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Pbkdf2Sha384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Pbkdf2Sha512;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Sp800108CtrHmacMd5;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Sp800108CtrHmacSha1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Sp800108CtrHmacSha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Sp800108CtrHmacSha384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Sp800108CtrHmacSha512;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Sp80056aConcatMd5;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Sp80056aConcatSha1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Sp80056aConcatSha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Sp80056aConcatSha384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Sp80056aConcatSha512;
    }
}
