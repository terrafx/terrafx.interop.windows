// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHashAlgorithmNamesStatics.xml' path='doc/member[@name="IHashAlgorithmNamesStatics"]/*' />
[Guid("6B5E0516-DE96-4F0A-8D57-DCC9DAE36C76")]
[NativeTypeName("struct IHashAlgorithmNamesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHashAlgorithmNamesStatics : IHashAlgorithmNamesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHashAlgorithmNamesStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmNamesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IHashAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmNamesStatics*, uint>)(lpVtbl[1]))((IHashAlgorithmNamesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmNamesStatics*, uint>)(lpVtbl[2]))((IHashAlgorithmNamesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmNamesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IHashAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[4]))((IHashAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmNamesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IHashAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHashAlgorithmNamesStatics.xml' path='doc/member[@name="IHashAlgorithmNamesStatics.get_Md5"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Md5(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[6]))((IHashAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHashAlgorithmNamesStatics.xml' path='doc/member[@name="IHashAlgorithmNamesStatics.get_Sha1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Sha1(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[7]))((IHashAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHashAlgorithmNamesStatics.xml' path='doc/member[@name="IHashAlgorithmNamesStatics.get_Sha256"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Sha256(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[8]))((IHashAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHashAlgorithmNamesStatics.xml' path='doc/member[@name="IHashAlgorithmNamesStatics.get_Sha384"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Sha384(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[9]))((IHashAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHashAlgorithmNamesStatics.xml' path='doc/member[@name="IHashAlgorithmNamesStatics.get_Sha512"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Sha512(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHashAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[10]))((IHashAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Md5(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Sha1(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Sha256(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Sha384(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Sha512(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Md5;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Sha1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Sha256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Sha384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Sha512;
    }
}
