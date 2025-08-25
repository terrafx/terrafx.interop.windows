// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyDerivationAlgorithmProvider.xml' path='doc/member[@name="IKeyDerivationAlgorithmProvider"]/*' />
[Guid("E1FBA83B-4671-43B7-9158-763AAA98B6BF")]
[NativeTypeName("struct IKeyDerivationAlgorithmProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyDerivationAlgorithmProvider : IKeyDerivationAlgorithmProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKeyDerivationAlgorithmProvider);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmProvider*, Guid*, void**, int>)(lpVtbl[0]))((IKeyDerivationAlgorithmProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmProvider*, uint>)(lpVtbl[1]))((IKeyDerivationAlgorithmProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmProvider*, uint>)(lpVtbl[2]))((IKeyDerivationAlgorithmProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmProvider*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyDerivationAlgorithmProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmProvider*, HSTRING*, int>)(lpVtbl[4]))((IKeyDerivationAlgorithmProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmProvider*, TrustLevel*, int>)(lpVtbl[5]))((IKeyDerivationAlgorithmProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyDerivationAlgorithmProvider.xml' path='doc/member[@name="IKeyDerivationAlgorithmProvider.get_AlgorithmName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AlgorithmName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmProvider*, HSTRING*, int>)(lpVtbl[6]))((IKeyDerivationAlgorithmProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyDerivationAlgorithmProvider.xml' path='doc/member[@name="IKeyDerivationAlgorithmProvider.CreateKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateKey([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* keyMaterial, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** key)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyDerivationAlgorithmProvider*, IBuffer*, ICryptographicKey**, int>)(lpVtbl[7]))((IKeyDerivationAlgorithmProvider*)Unsafe.AsPointer(ref this), keyMaterial, key);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AlgorithmName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT CreateKey([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* keyMaterial, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** key);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AlgorithmName;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::ICryptographicKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, ICryptographicKey**, int> CreateKey;
    }
}
