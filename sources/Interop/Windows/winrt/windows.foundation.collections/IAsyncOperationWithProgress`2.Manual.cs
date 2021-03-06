// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B5D036D7-E297-498F-BA60-0289E76E23DD")]
    public unsafe partial struct IAsyncOperationWithProgress<TResult, TProgress>
        where TResult : unmanaged
        where TProgress : unmanaged
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAsyncOperationWithProgress<TResult, TProgress>*, Guid*, void**, int>)(lpVtbl[0]))((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAsyncOperationWithProgress<TResult, TProgress>*, uint>)(lpVtbl[1]))((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAsyncOperationWithProgress<TResult, TProgress>*, uint>)(lpVtbl[2]))((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAsyncOperationWithProgress<TResult, TProgress>*, uint*, Guid**, int>)(lpVtbl[3]))((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAsyncOperationWithProgress<TResult, TProgress>*, IntPtr*, int>)(lpVtbl[4]))((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAsyncOperationWithProgress<TResult, TProgress>*, TrustLevel*, int>)(lpVtbl[5]))((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Progress([NativeTypeName("IAsyncOperationProgressHandler<TResult_logical, TProgress_logical> *")] IAsyncOperationProgressHandler<TResult, TProgress>* handler)
        {
            return ((delegate* unmanaged<IAsyncOperationWithProgress<TResult, TProgress>*, IAsyncOperationProgressHandler<TResult, TProgress>*, int>)(lpVtbl[6]))((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Progress([NativeTypeName("IAsyncOperationProgressHandler<TResult_logical, TProgress_logical> **")] IAsyncOperationProgressHandler<TResult, TProgress>** handler)
        {
            return ((delegate* unmanaged<IAsyncOperationWithProgress<TResult, TProgress>*, IAsyncOperationProgressHandler<TResult, TProgress>**, int>)(lpVtbl[7]))((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Completed([NativeTypeName("IAsyncOperationWithProgressCompletedHandler<TResult_logical, TProgress_logical> *")] IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>* handler)
        {
            return ((delegate* unmanaged<IAsyncOperationWithProgress<TResult, TProgress>*, IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>*, int>)(lpVtbl[8]))((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Completed([NativeTypeName("IAsyncOperationWithProgressCompletedHandler<TResult_logical, TProgress_logical> **")] IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>** handler)
        {
            return ((delegate* unmanaged<IAsyncOperationWithProgress<TResult, TProgress>*, IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>**, int>)(lpVtbl[9]))((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResults([NativeTypeName("TResult_abi *")] TResult* results)
        {
            return ((delegate* unmanaged<IAsyncOperationWithProgress<TResult, TProgress>*, TResult*, int>)(lpVtbl[10]))((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this), results);
        }
    }
}
