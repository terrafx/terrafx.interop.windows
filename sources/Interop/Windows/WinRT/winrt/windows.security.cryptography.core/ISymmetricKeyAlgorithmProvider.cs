// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISymmetricKeyAlgorithmProvider.xml' path='doc/member[@name="ISymmetricKeyAlgorithmProvider"]/*' />
[Guid("3D7E4A33-3BD0-4902-8AC8-470D50D21376")]
[NativeTypeName("struct ISymmetricKeyAlgorithmProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISymmetricKeyAlgorithmProvider : ISymmetricKeyAlgorithmProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISymmetricKeyAlgorithmProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricKeyAlgorithmProvider*, Guid*, void**, int>)(lpVtbl[0]))((ISymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricKeyAlgorithmProvider*, uint>)(lpVtbl[1]))((ISymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricKeyAlgorithmProvider*, uint>)(lpVtbl[2]))((ISymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricKeyAlgorithmProvider*, uint*, Guid**, int>)(lpVtbl[3]))((ISymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricKeyAlgorithmProvider*, HSTRING*, int>)(lpVtbl[4]))((ISymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricKeyAlgorithmProvider*, TrustLevel*, int>)(lpVtbl[5]))((ISymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISymmetricKeyAlgorithmProvider.xml' path='doc/member[@name="ISymmetricKeyAlgorithmProvider.get_AlgorithmName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AlgorithmName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricKeyAlgorithmProvider*, HSTRING*, int>)(lpVtbl[6]))((ISymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricKeyAlgorithmProvider.xml' path='doc/member[@name="ISymmetricKeyAlgorithmProvider.get_BlockLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BlockLength([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricKeyAlgorithmProvider*, uint*, int>)(lpVtbl[7]))((ISymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISymmetricKeyAlgorithmProvider.xml' path='doc/member[@name="ISymmetricKeyAlgorithmProvider.CreateSymmetricKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateSymmetricKey([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* keyMaterial, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** key)
    {
        return ((delegate* unmanaged[MemberFunction]<ISymmetricKeyAlgorithmProvider*, IBuffer*, ICryptographicKey**, int>)(lpVtbl[8]))((ISymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), keyMaterial, key);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AlgorithmName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_BlockLength([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT CreateSymmetricKey([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* keyMaterial, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** key);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_BlockLength;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::ICryptographicKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, ICryptographicKey**, int> CreateSymmetricKey;
    }
}
