// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A3F84EAB-0FAA-497E-A39C-EE6ED60B2D84")]
    [NativeTypeName("struct IDxcBlobUtf16 : IDxcBlobEncoding")]
    public unsafe partial struct IDxcBlobUtf16
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDxcBlobUtf16*, Guid*, void**, int>)(lpVtbl[0]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDxcBlobUtf16*, uint>)(lpVtbl[1]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDxcBlobUtf16*, uint>)(lpVtbl[2]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LPVOID")]
        public void* GetBufferPointer()
        {
            return ((delegate* unmanaged<IDxcBlobUtf16*, void*>)(lpVtbl[3]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("SIZE_T")]
        public nuint GetBufferSize()
        {
            return ((delegate* unmanaged<IDxcBlobUtf16*, nuint>)(lpVtbl[4]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEncoding([NativeTypeName("BOOL *")] int* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage)
        {
            return ((delegate* unmanaged<IDxcBlobUtf16*, int*, uint*, int>)(lpVtbl[5]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this), pKnown, pCodePage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("LPCWSTR")]
        public ushort* GetStringPointer()
        {
            return ((delegate* unmanaged<IDxcBlobUtf16*, ushort*>)(lpVtbl[6]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("SIZE_T")]
        public nuint GetStringLength()
        {
            return ((delegate* unmanaged<IDxcBlobUtf16*, nuint>)(lpVtbl[7]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
        }
    }
}
