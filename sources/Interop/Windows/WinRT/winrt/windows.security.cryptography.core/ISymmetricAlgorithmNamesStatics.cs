// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics"]/*' />
[Guid("6870727B-C996-4EAE-84D7-79B2AEB73B9C")]
[NativeTypeName("struct ISymmetricAlgorithmNamesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISymmetricAlgorithmNamesStatics : ISymmetricAlgorithmNamesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISymmetricAlgorithmNamesStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, uint>)(lpVtbl[1]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, uint>)(lpVtbl[2]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[4]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_DesCbc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DesCbc(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[6]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_DesEcb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DesEcb(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[7]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_TripleDesCbc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_TripleDesCbc(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[8]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_TripleDesEcb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TripleDesEcb(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[9]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_Rc2Cbc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Rc2Cbc(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[10]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_Rc2Ecb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Rc2Ecb(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[11]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_AesCbc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AesCbc(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[12]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_AesEcb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_AesEcb(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[13]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_AesGcm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_AesGcm(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[14]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_AesCcm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_AesCcm(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[15]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_AesCbcPkcs7"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_AesCbcPkcs7(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[16]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_AesEcbPkcs7"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_AesEcbPkcs7(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[17]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_DesCbcPkcs7"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_DesCbcPkcs7(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[18]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_DesEcbPkcs7"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_DesEcbPkcs7(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[19]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_TripleDesCbcPkcs7"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_TripleDesCbcPkcs7(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[20]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_TripleDesEcbPkcs7"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_TripleDesEcbPkcs7(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[21]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_Rc2CbcPkcs7"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Rc2CbcPkcs7(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[22]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_Rc2EcbPkcs7"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_Rc2EcbPkcs7(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[23]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricAlgorithmNamesStatics.xml' path='doc/member[@name="ISymmetricAlgorithmNamesStatics.get_Rc4"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_Rc4(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[24]))((ISymmetricAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DesCbc(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_DesEcb(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_TripleDesCbc(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_TripleDesEcb(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Rc2Cbc(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Rc2Ecb(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_AesCbc(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_AesEcb(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_AesGcm(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_AesCcm(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_AesCbcPkcs7(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_AesEcbPkcs7(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_DesCbcPkcs7(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_DesEcbPkcs7(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_TripleDesCbcPkcs7(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_TripleDesEcbPkcs7(HSTRING* value);

        [VtblIndex(22)]
        HRESULT get_Rc2CbcPkcs7(HSTRING* value);

        [VtblIndex(23)]
        HRESULT get_Rc2EcbPkcs7(HSTRING* value);

        [VtblIndex(24)]
        HRESULT get_Rc4(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DesCbc;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DesEcb;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TripleDesCbc;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TripleDesEcb;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Rc2Cbc;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Rc2Ecb;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AesCbc;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AesEcb;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AesGcm;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AesCcm;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AesCbcPkcs7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AesEcbPkcs7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DesCbcPkcs7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DesEcbPkcs7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TripleDesCbcPkcs7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TripleDesEcbPkcs7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Rc2CbcPkcs7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Rc2EcbPkcs7;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Rc4;
    }
}
