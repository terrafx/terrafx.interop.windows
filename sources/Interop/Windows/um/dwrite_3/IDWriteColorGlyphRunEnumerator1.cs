// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7C5F86DA-C7A1-4F05-B8E1-55A179FE5A35")]
    public unsafe partial struct IDWriteColorGlyphRunEnumerator1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasRun)
        {
            return lpVtbl->MoveNext((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), hasRun);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentRun([NativeTypeName("const DWRITE_COLOR_GLYPH_RUN **")] DWRITE_COLOR_GLYPH_RUN** colorGlyphRun)
        {
            return lpVtbl->GetCurrentRun((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), colorGlyphRun);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentRun([NativeTypeName("const DWRITE_COLOR_GLYPH_RUN1 **")] DWRITE_COLOR_GLYPH_RUN1** colorGlyphRun)
        {
            return lpVtbl->GetCurrentRun1((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), colorGlyphRun);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteColorGlyphRunEnumerator1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteColorGlyphRunEnumerator1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteColorGlyphRunEnumerator1*, uint> Release;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteColorGlyphRunEnumerator1*, int*, int> MoveNext;

            [NativeTypeName("HRESULT (const DWRITE_COLOR_GLYPH_RUN **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteColorGlyphRunEnumerator1*, DWRITE_COLOR_GLYPH_RUN**, int> GetCurrentRun;

            [NativeTypeName("HRESULT (const DWRITE_COLOR_GLYPH_RUN1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteColorGlyphRunEnumerator1*, DWRITE_COLOR_GLYPH_RUN1**, int> GetCurrentRun1;
        }
    }
}
