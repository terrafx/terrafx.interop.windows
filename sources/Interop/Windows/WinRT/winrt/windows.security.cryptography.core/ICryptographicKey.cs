// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICryptographicKey.xml' path='doc/member[@name="ICryptographicKey"]/*' />
[Guid("ED2A3B70-8E7B-4009-8401-FFD1A62EEB27")]
[NativeTypeName("struct ICryptographicKey : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICryptographicKey : ICryptographicKey.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICryptographicKey));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicKey*, Guid*, void**, int>)(lpVtbl[0]))((ICryptographicKey*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicKey*, uint>)(lpVtbl[1]))((ICryptographicKey*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicKey*, uint>)(lpVtbl[2]))((ICryptographicKey*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicKey*, uint*, Guid**, int>)(lpVtbl[3]))((ICryptographicKey*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicKey*, HSTRING*, int>)(lpVtbl[4]))((ICryptographicKey*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicKey*, TrustLevel*, int>)(lpVtbl[5]))((ICryptographicKey*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICryptographicKey.xml' path='doc/member[@name="ICryptographicKey.get_KeySize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_KeySize([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicKey*, uint*, int>)(lpVtbl[6]))((ICryptographicKey*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICryptographicKey.xml' path='doc/member[@name="ICryptographicKey.ExportDefaultPrivateKeyBlobType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ExportDefaultPrivateKeyBlobType([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicKey*, IBuffer**, int>)(lpVtbl[7]))((ICryptographicKey*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICryptographicKey.xml' path='doc/member[@name="ICryptographicKey.ExportPrivateKeyWithBlobType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ExportPrivateKeyWithBlobType([NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPrivateKeyBlobType")] CryptographicPrivateKeyBlobType BlobType, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicKey*, CryptographicPrivateKeyBlobType, IBuffer**, int>)(lpVtbl[8]))((ICryptographicKey*)Unsafe.AsPointer(ref this), BlobType, value);
    }

    /// <include file='ICryptographicKey.xml' path='doc/member[@name="ICryptographicKey.ExportDefaultPublicKeyBlobType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ExportDefaultPublicKeyBlobType([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicKey*, IBuffer**, int>)(lpVtbl[9]))((ICryptographicKey*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICryptographicKey.xml' path='doc/member[@name="ICryptographicKey.ExportPublicKeyWithBlobType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ExportPublicKeyWithBlobType([NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType")] CryptographicPublicKeyBlobType BlobType, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicKey*, CryptographicPublicKeyBlobType, IBuffer**, int>)(lpVtbl[10]))((ICryptographicKey*)Unsafe.AsPointer(ref this), BlobType, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_KeySize([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT ExportDefaultPrivateKeyBlobType([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(8)]
        HRESULT ExportPrivateKeyWithBlobType([NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPrivateKeyBlobType")] CryptographicPrivateKeyBlobType BlobType, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(9)]
        HRESULT ExportDefaultPublicKeyBlobType([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(10)]
        HRESULT ExportPublicKeyWithBlobType([NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType")] CryptographicPublicKeyBlobType BlobType, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_KeySize;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> ExportDefaultPrivateKeyBlobType;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::CryptographicPrivateKeyBlobType, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CryptographicPrivateKeyBlobType, IBuffer**, int> ExportPrivateKeyWithBlobType;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> ExportDefaultPublicKeyBlobType;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CryptographicPublicKeyBlobType, IBuffer**, int> ExportPublicKeyWithBlobType;
    }
}
