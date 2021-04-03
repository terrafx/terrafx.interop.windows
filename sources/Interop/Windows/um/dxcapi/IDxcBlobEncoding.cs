// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7241D424-2646-4191-97C0-98E96E42FC68")]
    [NativeTypeName("struct IDxcBlobEncoding : IDxcBlob")]
    public unsafe partial struct IDxcBlobEncoding
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDxcBlobEncoding*, Guid*, void**, int>)(lpVtbl[0]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDxcBlobEncoding*, uint>)(lpVtbl[1]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDxcBlobEncoding*, uint>)(lpVtbl[2]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LPVOID")]
        public void* GetBufferPointer()
        {
            return ((delegate* unmanaged<IDxcBlobEncoding*, void*>)(lpVtbl[3]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("SIZE_T")]
        public nuint GetBufferSize()
        {
            return ((delegate* unmanaged<IDxcBlobEncoding*, nuint>)(lpVtbl[4]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEncoding([NativeTypeName("BOOL *")] int* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage)
        {
            return ((delegate* unmanaged<IDxcBlobEncoding*, int*, uint*, int>)(lpVtbl[5]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this), pKnown, pCodePage);
        }
    }
}
