// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyCredential.xml' path='doc/member[@name="IKeyCredential"]/*' />
[Guid("9585EF8D-457B-4847-B11A-FA960BBDB138")]
[NativeTypeName("struct IKeyCredential : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyCredential : IKeyCredential.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKeyCredential));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredential*, Guid*, void**, int>)(lpVtbl[0]))((IKeyCredential*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredential*, uint>)(lpVtbl[1]))((IKeyCredential*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredential*, uint>)(lpVtbl[2]))((IKeyCredential*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredential*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyCredential*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredential*, HSTRING*, int>)(lpVtbl[4]))((IKeyCredential*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredential*, TrustLevel*, int>)(lpVtbl[5]))((IKeyCredential*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyCredential.xml' path='doc/member[@name="IKeyCredential.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredential*, HSTRING*, int>)(lpVtbl[6]))((IKeyCredential*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyCredential.xml' path='doc/member[@name="IKeyCredential.RetrievePublicKeyWithDefaultBlobType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RetrievePublicKeyWithDefaultBlobType([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredential*, IBuffer**, int>)(lpVtbl[7]))((IKeyCredential*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyCredential.xml' path='doc/member[@name="IKeyCredential.RetrievePublicKeyWithBlobType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RetrievePublicKeyWithBlobType([NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType")] CryptographicPublicKeyBlobType blobType, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredential*, CryptographicPublicKeyBlobType, IBuffer**, int>)(lpVtbl[8]))((IKeyCredential*)Unsafe.AsPointer(ref this), blobType, value);
    }

    /// <include file='IKeyCredential.xml' path='doc/member[@name="IKeyCredential.RequestSignAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestSignAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialOperationResult_t **")] IAsyncOperation<Pointer<IKeyCredentialOperationResult>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredential*, IBuffer*, IAsyncOperation<Pointer<IKeyCredentialOperationResult>>**, int>)(lpVtbl[9]))((IKeyCredential*)Unsafe.AsPointer(ref this), data, value);
    }

    /// <include file='IKeyCredential.xml' path='doc/member[@name="IKeyCredential.GetAttestationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetAttestationAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialAttestationResult_t **")] IAsyncOperation<Pointer<IKeyCredentialAttestationResult>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyCredential*, IAsyncOperation<Pointer<IKeyCredentialAttestationResult>>**, int>)(lpVtbl[10]))((IKeyCredential*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT RetrievePublicKeyWithDefaultBlobType([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(8)]
        HRESULT RetrievePublicKeyWithBlobType([NativeTypeName("ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType")] CryptographicPublicKeyBlobType blobType, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(9)]
        HRESULT RequestSignAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialOperationResult_t **")] IAsyncOperation<Pointer<IKeyCredentialOperationResult>>** value);

        [VtblIndex(10)]
        HRESULT GetAttestationAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialAttestationResult_t **")] IAsyncOperation<Pointer<IKeyCredentialAttestationResult>>** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> RetrievePublicKeyWithDefaultBlobType;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CryptographicPublicKeyBlobType, IBuffer**, int> RetrievePublicKeyWithBlobType;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialOperationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IAsyncOperation<Pointer<IKeyCredentialOperationResult>>**, int> RequestSignAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CKeyCredentialAttestationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IKeyCredentialAttestationResult>>**, int> GetAttestationAsync;
    }
}
