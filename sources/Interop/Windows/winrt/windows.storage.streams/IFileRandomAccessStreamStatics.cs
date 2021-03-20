// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("73550107-3B57-4B5D-8345-554D2FC621F0")]
    [NativeTypeName("struct IFileRandomAccessStreamStatics : IInspectable")]
    public unsafe partial struct IFileRandomAccessStreamStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IFileRandomAccessStreamStatics*, Guid*, void**, int>)(lpVtbl[0]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileRandomAccessStreamStatics*, uint>)(lpVtbl[1]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileRandomAccessStreamStatics*, uint>)(lpVtbl[2]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IFileRandomAccessStreamStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IFileRandomAccessStreamStatics*, IntPtr*, int>)(lpVtbl[4]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IFileRandomAccessStreamStatics*, TrustLevel*, int>)(lpVtbl[5]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenAsync([NativeTypeName("HSTRING")] IntPtr filePath, [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] int accessMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IFileRandomAccessStreamStatics*, IntPtr, int, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), filePath, accessMode, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenWithOptionsAsync([NativeTypeName("HSTRING")] IntPtr filePath, [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] int accessMode, [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] uint sharingOptions, [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")] FileOpenDisposition openDisposition, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IFileRandomAccessStreamStatics*, IntPtr, int, uint, FileOpenDisposition, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), filePath, accessMode, sharingOptions, openDisposition, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenTransactedWriteAsync([NativeTypeName("HSTRING")] IntPtr filePath, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IFileRandomAccessStreamStatics*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), filePath, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenTransactedWriteWithOptionsAsync([NativeTypeName("HSTRING")] IntPtr filePath, [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] uint openOptions, [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")] FileOpenDisposition openDisposition, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IFileRandomAccessStreamStatics*, IntPtr, uint, FileOpenDisposition, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), filePath, openOptions, openDisposition, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("HSTRING")] IntPtr filePath, [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] int accessMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IFileRandomAccessStreamStatics*, IUser*, IntPtr, int, IAsyncOperation<IntPtr>**, int>)(lpVtbl[10]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), user, filePath, accessMode, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenForUserWithOptionsAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("HSTRING")] IntPtr filePath, [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] int accessMode, [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] uint sharingOptions, [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")] FileOpenDisposition openDisposition, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IFileRandomAccessStreamStatics*, IUser*, IntPtr, int, uint, FileOpenDisposition, IAsyncOperation<IntPtr>**, int>)(lpVtbl[11]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), user, filePath, accessMode, sharingOptions, openDisposition, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenTransactedWriteForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("HSTRING")] IntPtr filePath, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IFileRandomAccessStreamStatics*, IUser*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[12]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), user, filePath, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenTransactedWriteForUserWithOptionsAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("HSTRING")] IntPtr filePath, [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] uint openOptions, [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")] FileOpenDisposition openDisposition, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IFileRandomAccessStreamStatics*, IUser*, IntPtr, uint, FileOpenDisposition, IAsyncOperation<IntPtr>**, int>)(lpVtbl[13]))((IFileRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), user, filePath, openOptions, openDisposition, operation);
        }
    }
}
