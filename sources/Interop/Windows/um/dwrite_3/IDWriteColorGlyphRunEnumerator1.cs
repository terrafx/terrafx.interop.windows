// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7C5F86DA-C7A1-4F05-B8E1-55A179FE5A35")]
    [NativeTypeName("struct IDWriteColorGlyphRunEnumerator1 : IDWriteColorGlyphRunEnumerator")]
    [NativeInheritance("IDWriteColorGlyphRunEnumerator")]
    public unsafe partial struct IDWriteColorGlyphRunEnumerator1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator1*, uint>)(lpVtbl[1]))((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator1*, uint>)(lpVtbl[2]))((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasRun)
        {
            return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator1*, int*, int>)(lpVtbl[3]))((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), hasRun);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentRun([NativeTypeName("const DWRITE_COLOR_GLYPH_RUN **")] DWRITE_COLOR_GLYPH_RUN** colorGlyphRun)
        {
            return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator1*, DWRITE_COLOR_GLYPH_RUN**, int>)(lpVtbl[4]))((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), colorGlyphRun);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentRun([NativeTypeName("const DWRITE_COLOR_GLYPH_RUN1 **")] DWRITE_COLOR_GLYPH_RUN1** colorGlyphRun)
        {
            return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator1*, DWRITE_COLOR_GLYPH_RUN1**, int>)(lpVtbl[5]))((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), colorGlyphRun);
        }
    }
}
