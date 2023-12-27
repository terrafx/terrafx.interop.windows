// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundDownloader.xml' path='doc/member[@name="IBackgroundDownloader"]/*' />
[Guid("C1C79333-6649-4B1D-A826-A4B3DD234D0B")]
[NativeTypeName("struct IBackgroundDownloader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundDownloader : IBackgroundDownloader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundDownloader));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundDownloader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader*, uint>)(lpVtbl[1]))((IBackgroundDownloader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader*, uint>)(lpVtbl[2]))((IBackgroundDownloader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundDownloader*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundDownloader*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundDownloader*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundDownloader.xml' path='doc/member[@name="IBackgroundDownloader.CreateDownload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateDownload([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* resultFile, [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IDownloadOperation **")] IDownloadOperation** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader*, IUriRuntimeClass*, IStorageFile*, IDownloadOperation**, int>)(lpVtbl[6]))((IBackgroundDownloader*)Unsafe.AsPointer(ref this), uri, resultFile, operation);
    }

    /// <include file='IBackgroundDownloader.xml' path='doc/member[@name="IBackgroundDownloader.CreateDownloadFromFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateDownloadFromFile([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* resultFile, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* requestBodyFile, [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IDownloadOperation **")] IDownloadOperation** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader*, IUriRuntimeClass*, IStorageFile*, IStorageFile*, IDownloadOperation**, int>)(lpVtbl[7]))((IBackgroundDownloader*)Unsafe.AsPointer(ref this), uri, resultFile, requestBodyFile, operation);
    }

    /// <include file='IBackgroundDownloader.xml' path='doc/member[@name="IBackgroundDownloader.CreateDownloadAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateDownloadAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* resultFile, [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* requestBodyStream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **")] IAsyncOperation<Pointer<IDownloadOperation>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundDownloader*, IUriRuntimeClass*, IStorageFile*, IInputStream*, IAsyncOperation<Pointer<IDownloadOperation>>**, int>)(lpVtbl[8]))((IBackgroundDownloader*)Unsafe.AsPointer(ref this), uri, resultFile, requestBodyStream, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateDownload([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* resultFile, [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IDownloadOperation **")] IDownloadOperation** operation);

        [VtblIndex(7)]
        HRESULT CreateDownloadFromFile([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* resultFile, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* requestBodyFile, [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IDownloadOperation **")] IDownloadOperation** operation);

        [VtblIndex(8)]
        HRESULT CreateDownloadAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* resultFile, [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* requestBodyStream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **")] IAsyncOperation<Pointer<IDownloadOperation>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Storage::IStorageFile *, ABI::Windows::Networking::BackgroundTransfer::IDownloadOperation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IStorageFile*, IDownloadOperation**, int> CreateDownload;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::IStorageFile *, ABI::Windows::Networking::BackgroundTransfer::IDownloadOperation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IStorageFile*, IStorageFile*, IDownloadOperation**, int> CreateDownloadFromFile;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IStorageFile*, IInputStream*, IAsyncOperation<Pointer<IDownloadOperation>>**, int> CreateDownloadAsync;
    }
}
