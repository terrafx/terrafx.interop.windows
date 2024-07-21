// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyDerivationAlgorithmProviderStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmProviderStatics"]/*' />
[Guid("0A22097A-0A1C-443B-9418-B9498AEB1603")]
[NativeTypeName("struct IKeyDerivationAlgorithmProviderStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyDerivationAlgorithmProviderStatics : IKeyDerivationAlgorithmProviderStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKeyDerivationAlgorithmProviderStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmProviderStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKeyDerivationAlgorithmProviderStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmProviderStatics*, uint>)(lpVtbl[1]))((IKeyDerivationAlgorithmProviderStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmProviderStatics*, uint>)(lpVtbl[2]))((IKeyDerivationAlgorithmProviderStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmProviderStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyDerivationAlgorithmProviderStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmProviderStatics*, HSTRING*, int>)(lpVtbl[4]))((IKeyDerivationAlgorithmProviderStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmProviderStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKeyDerivationAlgorithmProviderStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyDerivationAlgorithmProviderStatics.xml' path='doc/member[@name="IKeyDerivationAlgorithmProviderStatics.OpenAlgorithm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OpenAlgorithm(HSTRING algorithm, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IKeyDerivationAlgorithmProvider **")] IKeyDerivationAlgorithmProvider** provider)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmProviderStatics*, HSTRING, IKeyDerivationAlgorithmProvider**, int>)(lpVtbl[6]))((IKeyDerivationAlgorithmProviderStatics*)Unsafe.AsPointer(ref this), algorithm, provider);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT OpenAlgorithm(HSTRING algorithm, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IKeyDerivationAlgorithmProvider **")] IKeyDerivationAlgorithmProvider** provider);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Security::Cryptography::Core::IKeyDerivationAlgorithmProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IKeyDerivationAlgorithmProvider**, int> OpenAlgorithm;
    }
}
