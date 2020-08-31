// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD906C1-12E2-11DC-9FED-001143A055F9")]
    [NativeTypeName("struct ID2D1TessellationSink : IUnknown")]
    public unsafe partial struct ID2D1TessellationSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1TessellationSink*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1TessellationSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1TessellationSink*, uint>)(lpVtbl[1]))((ID2D1TessellationSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1TessellationSink*, uint>)(lpVtbl[2]))((ID2D1TessellationSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddTriangles([NativeTypeName("const D2D1_TRIANGLE *")] D2D1_TRIANGLE* triangles, [NativeTypeName("UINT32")] uint trianglesCount)
        {
            ((delegate* stdcall<ID2D1TessellationSink*, D2D1_TRIANGLE*, uint, void>)(lpVtbl[3]))((ID2D1TessellationSink*)Unsafe.AsPointer(ref this), triangles, trianglesCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* stdcall<ID2D1TessellationSink*, int>)(lpVtbl[4]))((ID2D1TessellationSink*)Unsafe.AsPointer(ref this));
        }
    }
}
