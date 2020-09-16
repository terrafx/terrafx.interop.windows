// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CF7B26FC-9A00-485B-8147-3E789D5E8F67")]
    [NativeTypeName("struct IAMAsyncReaderTimestampScaling : IUnknown")]
    public unsafe partial struct IAMAsyncReaderTimestampScaling
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAMAsyncReaderTimestampScaling*, Guid*, void**, int>)(lpVtbl[0]))((IAMAsyncReaderTimestampScaling*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMAsyncReaderTimestampScaling*, uint>)(lpVtbl[1]))((IAMAsyncReaderTimestampScaling*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMAsyncReaderTimestampScaling*, uint>)(lpVtbl[2]))((IAMAsyncReaderTimestampScaling*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTimestampMode([NativeTypeName("BOOL *")] int* pfRaw)
        {
            return ((delegate* unmanaged<IAMAsyncReaderTimestampScaling*, int*, int>)(lpVtbl[3]))((IAMAsyncReaderTimestampScaling*)Unsafe.AsPointer(ref this), pfRaw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTimestampMode([NativeTypeName("BOOL")] int fRaw)
        {
            return ((delegate* unmanaged<IAMAsyncReaderTimestampScaling*, int, int>)(lpVtbl[4]))((IAMAsyncReaderTimestampScaling*)Unsafe.AsPointer(ref this), fRaw);
        }
    }
}
