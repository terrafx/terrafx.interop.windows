// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICryptographicEngineStatics2.xml' path='doc/member[@name="ICryptographicEngineStatics2"]/*' />
[Guid("675948FE-DF9F-4191-92C7-6CE6F58420E0")]
[NativeTypeName("struct ICryptographicEngineStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICryptographicEngineStatics2 : ICryptographicEngineStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICryptographicEngineStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics2*, Guid*, void**, int>)(lpVtbl[0]))((ICryptographicEngineStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics2*, uint>)(lpVtbl[1]))((ICryptographicEngineStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics2*, uint>)(lpVtbl[2]))((ICryptographicEngineStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((ICryptographicEngineStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics2*, HSTRING*, int>)(lpVtbl[4]))((ICryptographicEngineStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics2*, TrustLevel*, int>)(lpVtbl[5]))((ICryptographicEngineStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICryptographicEngineStatics2.xml' path='doc/member[@name="ICryptographicEngineStatics2.SignHashedData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SignHashedData([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics2*, ICryptographicKey*, IBuffer*, IBuffer**, int>)(lpVtbl[6]))((ICryptographicEngineStatics2*)Unsafe.AsPointer(ref this), key, data, value);
    }

    /// <include file='ICryptographicEngineStatics2.xml' path='doc/member[@name="ICryptographicEngineStatics2.VerifySignatureWithHashInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT VerifySignatureWithHashInput([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* signature, [NativeTypeName("boolean *")] byte* isAuthenticated)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics2*, ICryptographicKey*, IBuffer*, IBuffer*, byte*, int>)(lpVtbl[7]))((ICryptographicEngineStatics2*)Unsafe.AsPointer(ref this), key, data, signature, isAuthenticated);
    }

    /// <include file='ICryptographicEngineStatics2.xml' path='doc/member[@name="ICryptographicEngineStatics2.DecryptAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DecryptAsync([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* iv, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<Pointer<IBuffer>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics2*, ICryptographicKey*, IBuffer*, IBuffer*, IAsyncOperation<Pointer<IBuffer>>**, int>)(lpVtbl[8]))((ICryptographicEngineStatics2*)Unsafe.AsPointer(ref this), key, data, iv, value);
    }

    /// <include file='ICryptographicEngineStatics2.xml' path='doc/member[@name="ICryptographicEngineStatics2.SignAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SignAsync([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<Pointer<IBuffer>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics2*, ICryptographicKey*, IBuffer*, IAsyncOperation<Pointer<IBuffer>>**, int>)(lpVtbl[9]))((ICryptographicEngineStatics2*)Unsafe.AsPointer(ref this), key, data, value);
    }

    /// <include file='ICryptographicEngineStatics2.xml' path='doc/member[@name="ICryptographicEngineStatics2.SignHashedDataAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SignHashedDataAsync([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<Pointer<IBuffer>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicEngineStatics2*, ICryptographicKey*, IBuffer*, IAsyncOperation<Pointer<IBuffer>>**, int>)(lpVtbl[10]))((ICryptographicEngineStatics2*)Unsafe.AsPointer(ref this), key, data, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SignHashedData([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(7)]
        HRESULT VerifySignatureWithHashInput([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* signature, [NativeTypeName("boolean *")] byte* isAuthenticated);

        [VtblIndex(8)]
        HRESULT DecryptAsync([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* iv, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<Pointer<IBuffer>>** value);

        [VtblIndex(9)]
        HRESULT SignAsync([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<Pointer<IBuffer>>** value);

        [VtblIndex(10)]
        HRESULT SignHashedDataAsync([NativeTypeName("ABI::Windows::Security::Cryptography::Core::ICryptographicKey *")] ICryptographicKey* key, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* data, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<Pointer<IBuffer>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICryptographicKey*, IBuffer*, IBuffer**, int> SignHashedData;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICryptographicKey*, IBuffer*, IBuffer*, byte*, int> VerifySignatureWithHashInput;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICryptographicKey*, IBuffer*, IBuffer*, IAsyncOperation<Pointer<IBuffer>>**, int> DecryptAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICryptographicKey*, IBuffer*, IAsyncOperation<Pointer<IBuffer>>**, int> SignAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::Core::ICryptographicKey *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICryptographicKey*, IBuffer*, IAsyncOperation<Pointer<IBuffer>>**, int> SignHashedDataAsync;
    }
}
