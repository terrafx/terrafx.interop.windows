// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAsymmetricKeyAlgorithmProvider.xml' path='doc/member[@name="IAsymmetricKeyAlgorithmProvider"]/*' />
[Guid("E8D2FF37-6259-4E88-B7E0-94191FDE699E")]
[NativeTypeName("struct IAsymmetricKeyAlgorithmProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAsymmetricKeyAlgorithmProvider : IAsymmetricKeyAlgorithmProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAsymmetricKeyAlgorithmProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricKeyAlgorithmProvider*, Guid*, void**, int>)(lpVtbl[0]))((IAsymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricKeyAlgorithmProvider*, uint>)(lpVtbl[1]))((IAsymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricKeyAlgorithmProvider*, uint>)(lpVtbl[2]))((IAsymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricKeyAlgorithmProvider*, uint*, Guid**, int>)(lpVtbl[3]))((IAsymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricKeyAlgorithmProvider*, HSTRING*, int>)(lpVtbl[4]))((IAsymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricKeyAlgorithmProvider*, TrustLevel*, int>)(lpVtbl[5]))((IAsymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAsymmetricKeyAlgorithmProvider.xml' path='doc/member[@name="IAsymmetricKeyAlgorithmProvider.get_AlgorithmName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AlgorithmName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricKeyAlgorithmProvider*, HSTRING*, int>)(lpVtbl[6]))((IAsymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAsymmetricKeyAlgorithmProvider.xml' path='doc/member[@name="IAsymmetricKeyAlgorithmProvider.CreateKeyPair"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateKeyPair([NativeTypeName("UINT32")] uint keySize, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** key)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricKeyAlgorithmProvider*, uint, ICryptographicKey**, int>)(lpVtbl[7]))((IAsymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), keySize, key);
    }

    /// <include file='IAsymmetricKeyAlgorithmProvider.xml' path='doc/member[@name="IAsymmetricKeyAlgorithmProvider.ImportDefaultPrivateKeyBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ImportDefaultPrivateKeyBlob([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* keyBlob, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** key)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricKeyAlgorithmProvider*, IBuffer*, ICryptographicKey**, int>)(lpVtbl[8]))((IAsymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), keyBlob, key);
    }

    /// <include file='IAsymmetricKeyAlgorithmProvider.xml' path='doc/member[@name="IAsymmetricKeyAlgorithmProvider.ImportKeyPairWithBlobType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ImportKeyPairWithBlobType([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* keyBlob, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPrivateKeyBlobType")] CryptographicPrivateKeyBlobType BlobType, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** key)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricKeyAlgorithmProvider*, IBuffer*, CryptographicPrivateKeyBlobType, ICryptographicKey**, int>)(lpVtbl[9]))((IAsymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), keyBlob, BlobType, key);
    }

    /// <include file='IAsymmetricKeyAlgorithmProvider.xml' path='doc/member[@name="IAsymmetricKeyAlgorithmProvider.ImportDefaultPublicKeyBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ImportDefaultPublicKeyBlob([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* keyBlob, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** key)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricKeyAlgorithmProvider*, IBuffer*, ICryptographicKey**, int>)(lpVtbl[10]))((IAsymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), keyBlob, key);
    }

    /// <include file='IAsymmetricKeyAlgorithmProvider.xml' path='doc/member[@name="IAsymmetricKeyAlgorithmProvider.ImportPublicKeyWithBlobType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ImportPublicKeyWithBlobType([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* keyBlob, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType")] CryptographicPublicKeyBlobType BlobType, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** key)
    {
        return ((delegate* unmanaged[MemberFunction]<IAsymmetricKeyAlgorithmProvider*, IBuffer*, CryptographicPublicKeyBlobType, ICryptographicKey**, int>)(lpVtbl[11]))((IAsymmetricKeyAlgorithmProvider*)Unsafe.AsPointer(ref this), keyBlob, BlobType, key);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AlgorithmName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT CreateKeyPair([NativeTypeName("UINT32")] uint keySize, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** key);

        [VtblIndex(8)]
        HRESULT ImportDefaultPrivateKeyBlob([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* keyBlob, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** key);

        [VtblIndex(9)]
        HRESULT ImportKeyPairWithBlobType([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* keyBlob, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPrivateKeyBlobType")] CryptographicPrivateKeyBlobType BlobType, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** key);

        [VtblIndex(10)]
        HRESULT ImportDefaultPublicKeyBlob([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* keyBlob, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** key);

        [VtblIndex(11)]
        HRESULT ImportPublicKeyWithBlobType([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* keyBlob, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType")] CryptographicPublicKeyBlobType BlobType, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey **")] ICryptographicKey** key);
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

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Security::Cryptography::Core::ICryptographicKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, ICryptographicKey**, int> CreateKeyPair;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::ICryptographicKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, ICryptographicKey**, int> ImportDefaultPrivateKeyBlob;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::CryptographicPrivateKeyBlobType, ABI::Windows::Security::Cryptography::Core::ICryptographicKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, CryptographicPrivateKeyBlobType, ICryptographicKey**, int> ImportKeyPairWithBlobType;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::ICryptographicKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, ICryptographicKey**, int> ImportDefaultPublicKeyBlob;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType, ABI::Windows::Security::Cryptography::Core::ICryptographicKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, CryptographicPublicKeyBlobType, ICryptographicKey**, int> ImportPublicKeyWithBlobType;
    }
}
