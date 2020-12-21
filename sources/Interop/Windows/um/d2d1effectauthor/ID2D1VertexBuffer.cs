// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B8B1336-00A5-4668-92B7-CED5D8BF9B7B")]
    [NativeTypeName("struct ID2D1VertexBuffer : IUnknown")]
    public unsafe partial struct ID2D1VertexBuffer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1VertexBuffer*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1VertexBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1VertexBuffer*, uint>)(lpVtbl[1]))((ID2D1VertexBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1VertexBuffer*, uint>)(lpVtbl[2]))((ID2D1VertexBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Map([NativeTypeName("BYTE **")] byte** data, [NativeTypeName("UINT32")] uint bufferSize)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1VertexBuffer*, byte**, uint, int>)(lpVtbl[3]))((ID2D1VertexBuffer*)Unsafe.AsPointer(ref this), data, bufferSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unmap()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1VertexBuffer*, int>)(lpVtbl[4]))((ID2D1VertexBuffer*)Unsafe.AsPointer(ref this));
        }
    }
}
