// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICryptographicEngineStatics.xml' path='doc/member[@name="ICryptographicEngineStatics"]/*' />
[Guid("9FEA0639-6FF7-4C85-A095-95EB31715EB9")]
[NativeTypeName("struct ICryptographicEngineStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICryptographicEngineStatics : ICryptographicEngineStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICryptographicEngineStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICryptographicEngineStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics*, uint>)(lpVtbl[1]))((ICryptographicEngineStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics*, uint>)(lpVtbl[2]))((ICryptographicEngineStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICryptographicEngineStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics*, HSTRING*, int>)(lpVtbl[4]))((ICryptographicEngineStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICryptographicEngineStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICryptographicEngineStatics.xml' path='doc/member[@name="ICryptographicEngineStatics.Encrypt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Encrypt([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* iv, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics*, ICryptographicKey*, IBuffer*, IBuffer*, IBuffer**, int>)(lpVtbl[6]))((ICryptographicEngineStatics*)Unsafe.AsPointer(ref this), key, data, iv, value);
    }

    /// <include file='ICryptographicEngineStatics.xml' path='doc/member[@name="ICryptographicEngineStatics.Decrypt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Decrypt([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* iv, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics*, ICryptographicKey*, IBuffer*, IBuffer*, IBuffer**, int>)(lpVtbl[7]))((ICryptographicEngineStatics*)Unsafe.AsPointer(ref this), key, data, iv, value);
    }

    /// <include file='ICryptographicEngineStatics.xml' path='doc/member[@name="ICryptographicEngineStatics.EncryptAndAuthenticate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EncryptAndAuthenticate([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* nonce, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* authenticatedData, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IEncryptedAndAuthenticatedData **")] IEncryptedAndAuthenticatedData** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics*, ICryptographicKey*, IBuffer*, IBuffer*, IBuffer*, IEncryptedAndAuthenticatedData**, int>)(lpVtbl[8]))((ICryptographicEngineStatics*)Unsafe.AsPointer(ref this), key, data, nonce, authenticatedData, value);
    }

    /// <include file='ICryptographicEngineStatics.xml' path='doc/member[@name="ICryptographicEngineStatics.DecryptAndAuthenticate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DecryptAndAuthenticate([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* nonce, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* authenticationTag, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* authenticatedData, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics*, ICryptographicKey*, IBuffer*, IBuffer*, IBuffer*, IBuffer*, IBuffer**, int>)(lpVtbl[9]))((ICryptographicEngineStatics*)Unsafe.AsPointer(ref this), key, data, nonce, authenticationTag, authenticatedData, value);
    }

    /// <include file='ICryptographicEngineStatics.xml' path='doc/member[@name="ICryptographicEngineStatics.Sign"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Sign([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics*, ICryptographicKey*, IBuffer*, IBuffer**, int>)(lpVtbl[10]))((ICryptographicEngineStatics*)Unsafe.AsPointer(ref this), key, data, value);
    }

    /// <include file='ICryptographicEngineStatics.xml' path='doc/member[@name="ICryptographicEngineStatics.VerifySignature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT VerifySignature([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* signature, [NativeTypeName("boolean *")] byte* isAuthenticated)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics*, ICryptographicKey*, IBuffer*, IBuffer*, byte*, int>)(lpVtbl[11]))((ICryptographicEngineStatics*)Unsafe.AsPointer(ref this), key, data, signature, isAuthenticated);
    }

    /// <include file='ICryptographicEngineStatics.xml' path='doc/member[@name="ICryptographicEngineStatics.DeriveKeyMaterial"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DeriveKeyMaterial([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters *")] IKeyDerivationParameters* parameters, [NativeTypeName("UINT32")] uint desiredKeySize, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** keyMaterial)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics*, ICryptographicKey*, IKeyDerivationParameters*, uint, IBuffer**, int>)(lpVtbl[12]))((ICryptographicEngineStatics*)Unsafe.AsPointer(ref this), key, parameters, desiredKeySize, keyMaterial);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Encrypt([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* iv, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(7)]
        HRESULT Decrypt([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* iv, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(8)]
        HRESULT EncryptAndAuthenticate([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* nonce, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* authenticatedData, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IEncryptedAndAuthenticatedData **")] IEncryptedAndAuthenticatedData** value);

        [VtblIndex(9)]
        HRESULT DecryptAndAuthenticate([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* nonce, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* authenticationTag, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* authenticatedData, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(10)]
        HRESULT Sign([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(11)]
        HRESULT VerifySignature([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* signature, [NativeTypeName("boolean *")] byte* isAuthenticated);

        [VtblIndex(12)]
        HRESULT DeriveKeyMaterial([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters *")] IKeyDerivationParameters* parameters, [NativeTypeName("UINT32")] uint desiredKeySize, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** keyMaterial);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICryptographicKey*, IBuffer*, IBuffer*, IBuffer**, int> Encrypt;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICryptographicKey*, IBuffer*, IBuffer*, IBuffer**, int> Decrypt;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Core::IEncryptedAndAuthenticatedData **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICryptographicKey*, IBuffer*, IBuffer*, IBuffer*, IEncryptedAndAuthenticatedData**, int> EncryptAndAuthenticate;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICryptographicKey*, IBuffer*, IBuffer*, IBuffer*, IBuffer*, IBuffer**, int> DecryptAndAuthenticate;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICryptographicKey*, IBuffer*, IBuffer**, int> Sign;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICryptographicKey*, IBuffer*, IBuffer*, byte*, int> VerifySignature;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Security::Cryptography::Core::IKeyDerivationParameters *, UINT32, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICryptographicKey*, IKeyDerivationParameters*, uint, IBuffer**, int> DeriveKeyMaterial;
    }
}
