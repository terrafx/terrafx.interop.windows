// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICmsDetachedSignatureStatics.xml' path='doc/member[@name="ICmsDetachedSignatureStatics"]/*' />
[Guid("3D114CFD-BF9B-4682-9BE6-91F57C053808")]
[NativeTypeName("struct ICmsDetachedSignatureStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICmsDetachedSignatureStatics : ICmsDetachedSignatureStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICmsDetachedSignatureStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsDetachedSignatureStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICmsDetachedSignatureStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsDetachedSignatureStatics*, uint>)(lpVtbl[1]))((ICmsDetachedSignatureStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsDetachedSignatureStatics*, uint>)(lpVtbl[2]))((ICmsDetachedSignatureStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsDetachedSignatureStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICmsDetachedSignatureStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsDetachedSignatureStatics*, HSTRING*, int>)(lpVtbl[4]))((ICmsDetachedSignatureStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsDetachedSignatureStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICmsDetachedSignatureStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICmsDetachedSignatureStatics.xml' path='doc/member[@name="ICmsDetachedSignatureStatics.GenerateSignatureAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GenerateSignatureAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* data, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCmsSignerInfo_t *")] IIterable<Pointer<ICmsSignerInfo>>* signers, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *")] IIterable<Pointer<ICertificate>>* certificates, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<Pointer<IBuffer>>** outputBlob)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsDetachedSignatureStatics*, IInputStream*, IIterable<Pointer<ICmsSignerInfo>>*, IIterable<Pointer<ICertificate>>*, IAsyncOperation<Pointer<IBuffer>>**, int>)(lpVtbl[6]))((ICmsDetachedSignatureStatics*)Unsafe.AsPointer(ref this), data, signers, certificates, outputBlob);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GenerateSignatureAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* data, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCmsSignerInfo_t *")] IIterable<Pointer<ICmsSignerInfo>>* signers, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *")] IIterable<Pointer<ICertificate>>* certificates, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<Pointer<IBuffer>>** outputBlob);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCmsSignerInfo_t *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream*, IIterable<Pointer<ICmsSignerInfo>>*, IIterable<Pointer<ICertificate>>*, IAsyncOperation<Pointer<IBuffer>>**, int> GenerateSignatureAsync;
    }
}
