// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D31FBE17-F157-41A2-8D24-CB779E0560E8")]
    [NativeTypeName("struct IDWriteColorGlyphRunEnumerator : IUnknown")]
    public unsafe partial struct IDWriteColorGlyphRunEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteColorGlyphRunEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator*, uint>)(lpVtbl[1]))((IDWriteColorGlyphRunEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator*, uint>)(lpVtbl[2]))((IDWriteColorGlyphRunEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasRun)
        {
            return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator*, int*, int>)(lpVtbl[3]))((IDWriteColorGlyphRunEnumerator*)Unsafe.AsPointer(ref this), hasRun);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentRun([NativeTypeName("const DWRITE_COLOR_GLYPH_RUN **")] DWRITE_COLOR_GLYPH_RUN** colorGlyphRun)
        {
            return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator*, DWRITE_COLOR_GLYPH_RUN**, int>)(lpVtbl[4]))((IDWriteColorGlyphRunEnumerator*)Unsafe.AsPointer(ref this), colorGlyphRun);
        }
    }
}
