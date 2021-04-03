// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CE25F8FD-863B-4D13-9651-C1F88DC73FE2")]
    [NativeTypeName("struct IDWriteAsyncResult : IUnknown")]
    public unsafe partial struct IDWriteAsyncResult
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteAsyncResult*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteAsyncResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteAsyncResult*, uint>)(lpVtbl[1]))((IDWriteAsyncResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteAsyncResult*, uint>)(lpVtbl[2]))((IDWriteAsyncResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HANDLE")]
        public IntPtr GetWaitHandle()
        {
            return ((delegate* unmanaged<IDWriteAsyncResult*, IntPtr>)(lpVtbl[3]))((IDWriteAsyncResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResult()
        {
            return ((delegate* unmanaged<IDWriteAsyncResult*, int>)(lpVtbl[4]))((IDWriteAsyncResult*)Unsafe.AsPointer(ref this));
        }
    }
}
