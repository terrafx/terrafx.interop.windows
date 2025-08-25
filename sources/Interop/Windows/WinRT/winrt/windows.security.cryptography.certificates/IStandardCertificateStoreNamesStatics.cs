// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStandardCertificateStoreNamesStatics.xml' path='doc/member[@name="IStandardCertificateStoreNamesStatics"]/*' />
[Guid("0C154ADB-A496-41F8-8FE5-9E96F36EFBF8")]
[NativeTypeName("struct IStandardCertificateStoreNamesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStandardCertificateStoreNamesStatics : IStandardCertificateStoreNamesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStandardCertificateStoreNamesStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardCertificateStoreNamesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IStandardCertificateStoreNamesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardCertificateStoreNamesStatics*, uint>)(lpVtbl[1]))((IStandardCertificateStoreNamesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardCertificateStoreNamesStatics*, uint>)(lpVtbl[2]))((IStandardCertificateStoreNamesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardCertificateStoreNamesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IStandardCertificateStoreNamesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardCertificateStoreNamesStatics*, HSTRING*, int>)(lpVtbl[4]))((IStandardCertificateStoreNamesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardCertificateStoreNamesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IStandardCertificateStoreNamesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStandardCertificateStoreNamesStatics.xml' path='doc/member[@name="IStandardCertificateStoreNamesStatics.get_Personal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Personal(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardCertificateStoreNamesStatics*, HSTRING*, int>)(lpVtbl[6]))((IStandardCertificateStoreNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardCertificateStoreNamesStatics.xml' path='doc/member[@name="IStandardCertificateStoreNamesStatics.get_TrustedRootCertificationAuthorities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TrustedRootCertificationAuthorities(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardCertificateStoreNamesStatics*, HSTRING*, int>)(lpVtbl[7]))((IStandardCertificateStoreNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStandardCertificateStoreNamesStatics.xml' path='doc/member[@name="IStandardCertificateStoreNamesStatics.get_IntermediateCertificationAuthorities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IntermediateCertificationAuthorities(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStandardCertificateStoreNamesStatics*, HSTRING*, int>)(lpVtbl[8]))((IStandardCertificateStoreNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Personal(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_TrustedRootCertificationAuthorities(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_IntermediateCertificationAuthorities(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Personal;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TrustedRootCertificationAuthorities;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_IntermediateCertificationAuthorities;
    }
}
