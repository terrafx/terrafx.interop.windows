// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageFileStatics.xml' path='doc/member[@name="IStorageFileStatics"]/*' />
[Guid("5984C710-DAF2-43C8-8BB4-A4D3EACFD03F")]
[NativeTypeName("struct IStorageFileStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageFileStatics : IStorageFileStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageFileStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFileStatics*, Guid*, void**, int>)(lpVtbl[0]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFileStatics*, uint>)(lpVtbl[1]))((IStorageFileStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFileStatics*, uint>)(lpVtbl[2]))((IStorageFileStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFileStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFileStatics*, HSTRING*, int>)(lpVtbl[4]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFileStatics*, TrustLevel*, int>)(lpVtbl[5]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageFileStatics.xml' path='doc/member[@name="IStorageFileStatics.GetFileFromPathAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFileFromPathAsync(HSTRING path, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFileStatics*, HSTRING, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[6]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), path, operation);
    }

    /// <include file='IStorageFileStatics.xml' path='doc/member[@name="IStorageFileStatics.GetFileFromApplicationUriAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFileFromApplicationUriAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFileStatics*, IUriRuntimeClass*, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[7]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), uri, operation);
    }

    /// <include file='IStorageFileStatics.xml' path='doc/member[@name="IStorageFileStatics.CreateStreamedFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateStreamedFileAsync(HSTRING displayNameWithExtension, [NativeTypeName("ABI::Windows::Storage::IStreamedFileDataRequestedHandler *")] IStreamedFileDataRequestedHandler* dataRequested, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* thumbnail, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFileStatics*, HSTRING, IStreamedFileDataRequestedHandler*, IRandomAccessStreamReference*, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[8]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), displayNameWithExtension, dataRequested, thumbnail, operation);
    }

    /// <include file='IStorageFileStatics.xml' path='doc/member[@name="IStorageFileStatics.ReplaceWithStreamedFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ReplaceWithStreamedFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* fileToReplace, [NativeTypeName("ABI::Windows::Storage::IStreamedFileDataRequestedHandler *")] IStreamedFileDataRequestedHandler* dataRequested, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* thumbnail, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFileStatics*, IStorageFile*, IStreamedFileDataRequestedHandler*, IRandomAccessStreamReference*, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[9]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), fileToReplace, dataRequested, thumbnail, operation);
    }

    /// <include file='IStorageFileStatics.xml' path='doc/member[@name="IStorageFileStatics.CreateStreamedFileFromUriAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateStreamedFileFromUriAsync(HSTRING displayNameWithExtension, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* thumbnail, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFileStatics*, HSTRING, IUriRuntimeClass*, IRandomAccessStreamReference*, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[10]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), displayNameWithExtension, uri, thumbnail, operation);
    }

    /// <include file='IStorageFileStatics.xml' path='doc/member[@name="IStorageFileStatics.ReplaceWithStreamedFileFromUriAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ReplaceWithStreamedFileFromUriAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* fileToReplace, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* thumbnail, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageFileStatics*, IStorageFile*, IUriRuntimeClass*, IRandomAccessStreamReference*, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[11]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), fileToReplace, uri, thumbnail, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetFileFromPathAsync(HSTRING path, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);

        [VtblIndex(7)]
        HRESULT GetFileFromApplicationUriAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);

        [VtblIndex(8)]
        HRESULT CreateStreamedFileAsync(HSTRING displayNameWithExtension, [NativeTypeName("ABI::Windows::Storage::IStreamedFileDataRequestedHandler *")] IStreamedFileDataRequestedHandler* dataRequested, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* thumbnail, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);

        [VtblIndex(9)]
        HRESULT ReplaceWithStreamedFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* fileToReplace, [NativeTypeName("ABI::Windows::Storage::IStreamedFileDataRequestedHandler *")] IStreamedFileDataRequestedHandler* dataRequested, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* thumbnail, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);

        [VtblIndex(10)]
        HRESULT CreateStreamedFileFromUriAsync(HSTRING displayNameWithExtension, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* thumbnail, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);

        [VtblIndex(11)]
        HRESULT ReplaceWithStreamedFileFromUriAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* fileToReplace, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* thumbnail, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IStorageFile>>**, int> GetFileFromPathAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperation<Pointer<IStorageFile>>**, int> GetFileFromApplicationUriAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::IStreamedFileDataRequestedHandler *, ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IStreamedFileDataRequestedHandler*, IRandomAccessStreamReference*, IAsyncOperation<Pointer<IStorageFile>>**, int> CreateStreamedFileAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::IStreamedFileDataRequestedHandler *, ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IStreamedFileDataRequestedHandler*, IRandomAccessStreamReference*, IAsyncOperation<Pointer<IStorageFile>>**, int> ReplaceWithStreamedFileAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IUriRuntimeClass*, IRandomAccessStreamReference*, IAsyncOperation<Pointer<IStorageFile>>**, int> CreateStreamedFileFromUriAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IUriRuntimeClass*, IRandomAccessStreamReference*, IAsyncOperation<Pointer<IStorageFile>>**, int> ReplaceWithStreamedFileFromUriAsync;
    }
}
