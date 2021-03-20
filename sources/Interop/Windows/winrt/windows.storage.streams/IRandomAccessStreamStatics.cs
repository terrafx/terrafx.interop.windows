// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("524CEDCF-6E29-4CE5-9573-6B753DB66C3A")]
    [NativeTypeName("struct IRandomAccessStreamStatics : IInspectable")]
    public unsafe partial struct IRandomAccessStreamStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRandomAccessStreamStatics*, Guid*, void**, int>)(lpVtbl[0]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRandomAccessStreamStatics*, uint>)(lpVtbl[1]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRandomAccessStreamStatics*, uint>)(lpVtbl[2]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRandomAccessStreamStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRandomAccessStreamStatics*, IntPtr*, int>)(lpVtbl[4]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRandomAccessStreamStatics*, TrustLevel*, int>)(lpVtbl[5]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* source, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* destination, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **")] IAsyncOperationWithProgress<ulong, ulong>** operation)
        {
            return ((delegate* unmanaged<IRandomAccessStreamStatics*, IInputStream*, IOutputStream*, IAsyncOperationWithProgress<ulong, ulong>**, int>)(lpVtbl[6]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), source, destination, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopySizeAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* source, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* destination, [NativeTypeName("UINT64")] ulong bytesToCopy, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **")] IAsyncOperationWithProgress<ulong, ulong>** operation)
        {
            return ((delegate* unmanaged<IRandomAccessStreamStatics*, IInputStream*, IOutputStream*, ulong, IAsyncOperationWithProgress<ulong, ulong>**, int>)(lpVtbl[7]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), source, destination, bytesToCopy, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyAndCloseAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* source, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* destination, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **")] IAsyncOperationWithProgress<ulong, ulong>** operation)
        {
            return ((delegate* unmanaged<IRandomAccessStreamStatics*, IInputStream*, IOutputStream*, IAsyncOperationWithProgress<ulong, ulong>**, int>)(lpVtbl[8]))((IRandomAccessStreamStatics*)Unsafe.AsPointer(ref this), source, destination, operation);
        }
    }
}
