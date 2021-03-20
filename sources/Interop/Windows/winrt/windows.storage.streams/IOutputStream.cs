// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("905A0FE6-BC53-11DF-8C49-001E4FC686DA")]
    [NativeTypeName("struct IOutputStream : IInspectable")]
    public unsafe partial struct IOutputStream
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IOutputStream*, Guid*, void**, int>)(lpVtbl[0]))((IOutputStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOutputStream*, uint>)(lpVtbl[1]))((IOutputStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOutputStream*, uint>)(lpVtbl[2]))((IOutputStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IOutputStream*, uint*, Guid**, int>)(lpVtbl[3]))((IOutputStream*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IOutputStream*, IntPtr*, int>)(lpVtbl[4]))((IOutputStream*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IOutputStream*, TrustLevel*, int>)(lpVtbl[5]))((IOutputStream*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT32_UINT32_t **")] IAsyncOperationWithProgress<uint, uint>** operation)
        {
            return ((delegate* unmanaged<IOutputStream*, IBuffer*, IAsyncOperationWithProgress<uint, uint>**, int>)(lpVtbl[6]))((IOutputStream*)Unsafe.AsPointer(ref this), buffer, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FlushAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** operation)
        {
            return ((delegate* unmanaged<IOutputStream*, IAsyncOperation<byte>**, int>)(lpVtbl[7]))((IOutputStream*)Unsafe.AsPointer(ref this), operation);
        }
    }
}
