// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMacAlgorithmProviderStatics.xml' path='doc/member[@name="IMacAlgorithmProviderStatics"]/*' />
[Guid("C9BDC147-CC77-4DF0-9E4E-B921E080644C")]
[NativeTypeName("struct IMacAlgorithmProviderStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMacAlgorithmProviderStatics : IMacAlgorithmProviderStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMacAlgorithmProviderStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProviderStatics*, Guid*, void**, int>)(lpVtbl[0]))((IMacAlgorithmProviderStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProviderStatics*, uint>)(lpVtbl[1]))((IMacAlgorithmProviderStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProviderStatics*, uint>)(lpVtbl[2]))((IMacAlgorithmProviderStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProviderStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IMacAlgorithmProviderStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProviderStatics*, HSTRING*, int>)(lpVtbl[4]))((IMacAlgorithmProviderStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProviderStatics*, TrustLevel*, int>)(lpVtbl[5]))((IMacAlgorithmProviderStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMacAlgorithmProviderStatics.xml' path='doc/member[@name="IMacAlgorithmProviderStatics.OpenAlgorithm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OpenAlgorithm(HSTRING algorithm, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IMacAlgorithmProvider **")] IMacAlgorithmProvider** provider)
    {
        return ((delegate* unmanaged[MemberFunction]<IMacAlgorithmProviderStatics*, HSTRING, IMacAlgorithmProvider**, int>)(lpVtbl[6]))((IMacAlgorithmProviderStatics*)Unsafe.AsPointer(ref this), algorithm, provider);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT OpenAlgorithm(HSTRING algorithm, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IMacAlgorithmProvider **")] IMacAlgorithmProvider** provider);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Security::Cryptography::Core::IMacAlgorithmProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IMacAlgorithmProvider**, int> OpenAlgorithm;
    }
}
