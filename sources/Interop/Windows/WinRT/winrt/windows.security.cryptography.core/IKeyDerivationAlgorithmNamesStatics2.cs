// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyDerivationAlgorithmNamesStatics2.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics2"]/*' />
[Guid("57953FAB-6044-466F-97F4-337B7808384D")]
[NativeTypeName("struct IKeyDerivationAlgorithmNamesStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyDerivationAlgorithmNamesStatics2 : IKeyDerivationAlgorithmNamesStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKeyDerivationAlgorithmNamesStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IKeyDerivationAlgorithmNamesStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics2*, uint>)(lpVtbl[1]))((IKeyDerivationAlgorithmNamesStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics2*, uint>)(lpVtbl[2]))((IKeyDerivationAlgorithmNamesStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyDerivationAlgorithmNamesStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics2*, HSTRING*, int>)(lpVtbl[4]))((IKeyDerivationAlgorithmNamesStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IKeyDerivationAlgorithmNamesStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics2.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics2.get_CapiKdfMd5"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CapiKdfMd5(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics2*, HSTRING*, int>)(lpVtbl[6]))((IKeyDerivationAlgorithmNamesStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics2.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics2.get_CapiKdfSha1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CapiKdfSha1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics2*, HSTRING*, int>)(lpVtbl[7]))((IKeyDerivationAlgorithmNamesStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics2.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics2.get_CapiKdfSha256"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CapiKdfSha256(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics2*, HSTRING*, int>)(lpVtbl[8]))((IKeyDerivationAlgorithmNamesStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics2.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics2.get_CapiKdfSha384"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CapiKdfSha384(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics2*, HSTRING*, int>)(lpVtbl[9]))((IKeyDerivationAlgorithmNamesStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmNamesStatics2.xml' path='doc/member[@name="IKeyDerivationAlgorithmNamesStatics2.get_CapiKdfSha512"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CapiKdfSha512(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmNamesStatics2*, HSTRING*, int>)(lpVtbl[10]))((IKeyDerivationAlgorithmNamesStatics2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CapiKdfMd5(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_CapiKdfSha1(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_CapiKdfSha256(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_CapiKdfSha384(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_CapiKdfSha512(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CapiKdfMd5;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CapiKdfSha1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CapiKdfSha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CapiKdfSha384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CapiKdfSha512;
    }
}
