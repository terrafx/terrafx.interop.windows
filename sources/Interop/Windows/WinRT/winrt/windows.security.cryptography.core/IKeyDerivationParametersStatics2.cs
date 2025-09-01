// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyDerivationParametersStatics2.xml' path='doc/member[@name="IKeyDerivationParametersStatics2"]/*' />
[Guid("A5783DD5-58E3-4EFB-B283-A1653126E1BE")]
[NativeTypeName("struct IKeyDerivationParametersStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyDerivationParametersStatics2 : IKeyDerivationParametersStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKeyDerivationParametersStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationParametersStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IKeyDerivationParametersStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationParametersStatics2*, uint>)(lpVtbl[1]))((IKeyDerivationParametersStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationParametersStatics2*, uint>)(lpVtbl[2]))((IKeyDerivationParametersStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationParametersStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyDerivationParametersStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationParametersStatics2*, HSTRING*, int>)(lpVtbl[4]))((IKeyDerivationParametersStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationParametersStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IKeyDerivationParametersStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyDerivationParametersStatics2.xml' path='doc/member[@name="IKeyDerivationParametersStatics2.BuildForCapi1Kdf"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BuildForCapi1Kdf([NativeTypeName("ABI::Windows::Security::Cryptography::Core::Capi1KdfTargetAlgorithm")] Capi1KdfTargetAlgorithm capi1KdfTargetAlgorithm, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **")] IKeyDerivationParameters** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationParametersStatics2*, Capi1KdfTargetAlgorithm, IKeyDerivationParameters**, int>)(lpVtbl[6]))((IKeyDerivationParametersStatics2*)Unsafe.AsPointer(ref this), capi1KdfTargetAlgorithm, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT BuildForCapi1Kdf([NativeTypeName("ABI::Windows::Security::Cryptography::Core::Capi1KdfTargetAlgorithm")] Capi1KdfTargetAlgorithm capi1KdfTargetAlgorithm, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **")] IKeyDerivationParameters** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::Capi1KdfTargetAlgorithm, ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Capi1KdfTargetAlgorithm, IKeyDerivationParameters**, int> BuildForCapi1Kdf;
    }
}
