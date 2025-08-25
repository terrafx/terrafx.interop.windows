// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundUploader.xml' path='doc/member[@name="IBackgroundUploader"]/*' />
[Guid("C595C9AE-CEAD-465B-8801-C55AC90A01CE")]
[NativeTypeName("struct IBackgroundUploader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundUploader : IBackgroundUploader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBackgroundUploader);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploader*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundUploader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploader*, uint>)(lpVtbl[1]))((IBackgroundUploader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploader*, uint>)(lpVtbl[2]))((IBackgroundUploader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploader*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundUploader*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploader*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundUploader*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploader*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundUploader*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundUploader.xml' path='doc/member[@name="IBackgroundUploader.CreateUpload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateUpload([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* sourceFile, [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IUploadOperation **")] IUploadOperation** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploader*, IUriRuntimeClass*, IStorageFile*, IUploadOperation**, int>)(lpVtbl[6]))((IBackgroundUploader*)Unsafe.AsPointer(ref this), uri, sourceFile, operation);
    }

    /// <include file='IBackgroundUploader.xml' path='doc/member[@name="IBackgroundUploader.CreateUploadFromStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateUploadFromStreamAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* sourceStream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **")] IAsyncOperation<Pointer<IUploadOperation>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploader*, IUriRuntimeClass*, IInputStream*, IAsyncOperation<Pointer<IUploadOperation>>**, int>)(lpVtbl[7]))((IBackgroundUploader*)Unsafe.AsPointer(ref this), uri, sourceStream, operation);
    }

    /// <include file='IBackgroundUploader.xml' path='doc/member[@name="IBackgroundUploader.CreateUploadWithFormDataAndAutoBoundaryAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateUploadWithFormDataAndAutoBoundaryAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferContentPart_t *")] IIterable<Pointer<IBackgroundTransferContentPart>>* parts, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **")] IAsyncOperation<Pointer<IUploadOperation>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploader*, IUriRuntimeClass*, IIterable<Pointer<IBackgroundTransferContentPart>>*, IAsyncOperation<Pointer<IUploadOperation>>**, int>)(lpVtbl[8]))((IBackgroundUploader*)Unsafe.AsPointer(ref this), uri, parts, operation);
    }

    /// <include file='IBackgroundUploader.xml' path='doc/member[@name="IBackgroundUploader.CreateUploadWithSubTypeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateUploadWithSubTypeAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferContentPart_t *")] IIterable<Pointer<IBackgroundTransferContentPart>>* parts, HSTRING subType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **")] IAsyncOperation<Pointer<IUploadOperation>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploader*, IUriRuntimeClass*, IIterable<Pointer<IBackgroundTransferContentPart>>*, HSTRING, IAsyncOperation<Pointer<IUploadOperation>>**, int>)(lpVtbl[9]))((IBackgroundUploader*)Unsafe.AsPointer(ref this), uri, parts, subType, operation);
    }

    /// <include file='IBackgroundUploader.xml' path='doc/member[@name="IBackgroundUploader.CreateUploadWithSubTypeAndBoundaryAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateUploadWithSubTypeAndBoundaryAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferContentPart_t *")] IIterable<Pointer<IBackgroundTransferContentPart>>* parts, HSTRING subType, HSTRING boundary, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **")] IAsyncOperation<Pointer<IUploadOperation>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundUploader*, IUriRuntimeClass*, IIterable<Pointer<IBackgroundTransferContentPart>>*, HSTRING, HSTRING, IAsyncOperation<Pointer<IUploadOperation>>**, int>)(lpVtbl[10]))((IBackgroundUploader*)Unsafe.AsPointer(ref this), uri, parts, subType, boundary, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateUpload([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* sourceFile, [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IUploadOperation **")] IUploadOperation** operation);

        [VtblIndex(7)]
        HRESULT CreateUploadFromStreamAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* sourceStream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **")] IAsyncOperation<Pointer<IUploadOperation>>** operation);

        [VtblIndex(8)]
        HRESULT CreateUploadWithFormDataAndAutoBoundaryAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferContentPart_t *")] IIterable<Pointer<IBackgroundTransferContentPart>>* parts, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **")] IAsyncOperation<Pointer<IUploadOperation>>** operation);

        [VtblIndex(9)]
        HRESULT CreateUploadWithSubTypeAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferContentPart_t *")] IIterable<Pointer<IBackgroundTransferContentPart>>* parts, HSTRING subType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **")] IAsyncOperation<Pointer<IUploadOperation>>** operation);

        [VtblIndex(10)]
        HRESULT CreateUploadWithSubTypeAndBoundaryAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferContentPart_t *")] IIterable<Pointer<IBackgroundTransferContentPart>>* parts, HSTRING subType, HSTRING boundary, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **")] IAsyncOperation<Pointer<IUploadOperation>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Storage::IStorageFile *, ABI::Windows::Networking::BackgroundTransfer::IUploadOperation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IStorageFile*, IUploadOperation**, int> CreateUpload;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IInputStream*, IAsyncOperation<Pointer<IUploadOperation>>**, int> CreateUploadFromStreamAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferContentPart_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IIterable<Pointer<IBackgroundTransferContentPart>>*, IAsyncOperation<Pointer<IUploadOperation>>**, int> CreateUploadWithFormDataAndAutoBoundaryAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferContentPart_t *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IIterable<Pointer<IBackgroundTransferContentPart>>*, HSTRING, IAsyncOperation<Pointer<IUploadOperation>>**, int> CreateUploadWithSubTypeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferContentPart_t *, HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IIterable<Pointer<IBackgroundTransferContentPart>>*, HSTRING, HSTRING, IAsyncOperation<Pointer<IUploadOperation>>**, int> CreateUploadWithSubTypeAndBoundaryAsync;
    }
}
