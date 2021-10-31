// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D31FBE17-F157-41A2-8D24-CB779E0560E8")]
    [NativeTypeName("struct IDWriteColorGlyphRunEnumerator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDWriteColorGlyphRunEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteColorGlyphRunEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator*, uint>)(lpVtbl[1]))((IDWriteColorGlyphRunEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator*, uint>)(lpVtbl[2]))((IDWriteColorGlyphRunEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext(BOOL* hasRun)
        {
            return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator*, BOOL*, int>)(lpVtbl[3]))((IDWriteColorGlyphRunEnumerator*)Unsafe.AsPointer(ref this), hasRun);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentRun([NativeTypeName("const DWRITE_COLOR_GLYPH_RUN **")] DWRITE_COLOR_GLYPH_RUN** colorGlyphRun)
        {
            return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator*, DWRITE_COLOR_GLYPH_RUN**, int>)(lpVtbl[4]))((IDWriteColorGlyphRunEnumerator*)Unsafe.AsPointer(ref this), colorGlyphRun);
        }
    }
}
