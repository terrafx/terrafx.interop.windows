// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFileRandomAccessStreamStatics.xml' path='doc/member[@name="IFileRandomAccessStreamStatics"]/*' />
[Guid("73550107-3B57-4B5D-8345-554D2FC621F0")]
[NativeTypeName("struct IFileRandomAccessStreamStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileRandomAccessStreamStatics : IFileRandomAccessStreamStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IFileRandomAccessStreamStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRandomAccessStreamStatics*, Guid*, void**, int>)(lpVtbl[0]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRandomAccessStreamStatics*, uint>)(lpVtbl[1]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRandomAccessStreamStatics*, uint>)(lpVtbl[2]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRandomAccessStreamStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRandomAccessStreamStatics*, HSTRING*, int>)(lpVtbl[4]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRandomAccessStreamStatics*, TrustLevel*, int>)(lpVtbl[5]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFileRandomAccessStreamStatics.xml' path='doc/member[@name="IFileRandomAccessStreamStatics.OpenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OpenAsync(HSTRING filePath, [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<Pointer<IRandomAccessStream>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRandomAccessStreamStatics*, HSTRING, FileAccessMode, IAsyncOperation<Pointer<IRandomAccessStream>>**, int>)(lpVtbl[6]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), filePath, accessMode, operation);
    }

    /// <include file='IFileRandomAccessStreamStatics.xml' path='doc/member[@name="IFileRandomAccessStreamStatics.OpenWithOptionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OpenWithOptionsAsync(HSTRING filePath, [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode, [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] StorageOpenOptions sharingOptions, [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")] FileOpenDisposition openDisposition, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<Pointer<IRandomAccessStream>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRandomAccessStreamStatics*, HSTRING, FileAccessMode, StorageOpenOptions, FileOpenDisposition, IAsyncOperation<Pointer<IRandomAccessStream>>**, int>)(lpVtbl[7]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), filePath, accessMode, sharingOptions, openDisposition, operation);
    }

    /// <include file='IFileRandomAccessStreamStatics.xml' path='doc/member[@name="IFileRandomAccessStreamStatics.OpenTransactedWriteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OpenTransactedWriteAsync(HSTRING filePath, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<Pointer<IStorageStreamTransaction>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRandomAccessStreamStatics*, HSTRING, IAsyncOperation<Pointer<IStorageStreamTransaction>>**, int>)(lpVtbl[8]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), filePath, operation);
    }

    /// <include file='IFileRandomAccessStreamStatics.xml' path='doc/member[@name="IFileRandomAccessStreamStatics.OpenTransactedWriteWithOptionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OpenTransactedWriteWithOptionsAsync(HSTRING filePath, [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] StorageOpenOptions openOptions, [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")] FileOpenDisposition openDisposition, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<Pointer<IStorageStreamTransaction>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRandomAccessStreamStatics*, HSTRING, StorageOpenOptions, FileOpenDisposition, IAsyncOperation<Pointer<IStorageStreamTransaction>>**, int>)(lpVtbl[9]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), filePath, openOptions, openDisposition, operation);
    }

    /// <include file='IFileRandomAccessStreamStatics.xml' path='doc/member[@name="IFileRandomAccessStreamStatics.OpenForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OpenForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING filePath, [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<Pointer<IRandomAccessStream>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRandomAccessStreamStatics*, IUser*, HSTRING, FileAccessMode, IAsyncOperation<Pointer<IRandomAccessStream>>**, int>)(lpVtbl[10]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), user, filePath, accessMode, operation);
    }

    /// <include file='IFileRandomAccessStreamStatics.xml' path='doc/member[@name="IFileRandomAccessStreamStatics.OpenForUserWithOptionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT OpenForUserWithOptionsAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING filePath, [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode, [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] StorageOpenOptions sharingOptions, [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")] FileOpenDisposition openDisposition, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<Pointer<IRandomAccessStream>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRandomAccessStreamStatics*, IUser*, HSTRING, FileAccessMode, StorageOpenOptions, FileOpenDisposition, IAsyncOperation<Pointer<IRandomAccessStream>>**, int>)(lpVtbl[11]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), user, filePath, accessMode, sharingOptions, openDisposition, operation);
    }

    /// <include file='IFileRandomAccessStreamStatics.xml' path='doc/member[@name="IFileRandomAccessStreamStatics.OpenTransactedWriteForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT OpenTransactedWriteForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING filePath, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<Pointer<IStorageStreamTransaction>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRandomAccessStreamStatics*, IUser*, HSTRING, IAsyncOperation<Pointer<IStorageStreamTransaction>>**, int>)(lpVtbl[12]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), user, filePath, operation);
    }

    /// <include file='IFileRandomAccessStreamStatics.xml' path='doc/member[@name="IFileRandomAccessStreamStatics.OpenTransactedWriteForUserWithOptionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT OpenTransactedWriteForUserWithOptionsAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING filePath, [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] StorageOpenOptions openOptions, [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")] FileOpenDisposition openDisposition, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<Pointer<IStorageStreamTransaction>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileRandomAccessStreamStatics*, IUser*, HSTRING, StorageOpenOptions, FileOpenDisposition, IAsyncOperation<Pointer<IStorageStreamTransaction>>**, int>)(lpVtbl[13]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), user, filePath, openOptions, openDisposition, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT OpenAsync(HSTRING filePath, [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<Pointer<IRandomAccessStream>>** operation);

        [VtblIndex(7)]
        HRESULT OpenWithOptionsAsync(HSTRING filePath, [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode, [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] StorageOpenOptions sharingOptions, [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")] FileOpenDisposition openDisposition, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<Pointer<IRandomAccessStream>>** operation);

        [VtblIndex(8)]
        HRESULT OpenTransactedWriteAsync(HSTRING filePath, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<Pointer<IStorageStreamTransaction>>** operation);

        [VtblIndex(9)]
        HRESULT OpenTransactedWriteWithOptionsAsync(HSTRING filePath, [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] StorageOpenOptions openOptions, [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")] FileOpenDisposition openDisposition, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<Pointer<IStorageStreamTransaction>>** operation);

        [VtblIndex(10)]
        HRESULT OpenForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING filePath, [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<Pointer<IRandomAccessStream>>** operation);

        [VtblIndex(11)]
        HRESULT OpenForUserWithOptionsAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING filePath, [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode, [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] StorageOpenOptions sharingOptions, [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")] FileOpenDisposition openDisposition, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<Pointer<IRandomAccessStream>>** operation);

        [VtblIndex(12)]
        HRESULT OpenTransactedWriteForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING filePath, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<Pointer<IStorageStreamTransaction>>** operation);

        [VtblIndex(13)]
        HRESULT OpenTransactedWriteForUserWithOptionsAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING filePath, [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] StorageOpenOptions openOptions, [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")] FileOpenDisposition openDisposition, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<Pointer<IStorageStreamTransaction>>** operation);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::FileAccessMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, FileAccessMode, IAsyncOperation<Pointer<IRandomAccessStream>>**, int> OpenAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::FileAccessMode, ABI::Windows::Storage::StorageOpenOptions, ABI::Windows::Storage::Streams::FileOpenDisposition, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, FileAccessMode, StorageOpenOptions, FileOpenDisposition, IAsyncOperation<Pointer<IRandomAccessStream>>**, int> OpenWithOptionsAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IStorageStreamTransaction>>**, int> OpenTransactedWriteAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::StorageOpenOptions, ABI::Windows::Storage::Streams::FileOpenDisposition, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, StorageOpenOptions, FileOpenDisposition, IAsyncOperation<Pointer<IStorageStreamTransaction>>**, int> OpenTransactedWriteWithOptionsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Storage::FileAccessMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, HSTRING, FileAccessMode, IAsyncOperation<Pointer<IRandomAccessStream>>**, int> OpenForUserAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Storage::FileAccessMode, ABI::Windows::Storage::StorageOpenOptions, ABI::Windows::Storage::Streams::FileOpenDisposition, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, HSTRING, FileAccessMode, StorageOpenOptions, FileOpenDisposition, IAsyncOperation<Pointer<IRandomAccessStream>>**, int> OpenForUserWithOptionsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, HSTRING, IAsyncOperation<Pointer<IStorageStreamTransaction>>**, int> OpenTransactedWriteForUserAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Storage::StorageOpenOptions, ABI::Windows::Storage::Streams::FileOpenDisposition, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, HSTRING, StorageOpenOptions, FileOpenDisposition, IAsyncOperation<Pointer<IStorageStreamTransaction>>**, int> OpenTransactedWriteForUserWithOptionsAsync;
    }
}
