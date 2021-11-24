// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("7C5F86DA-C7A1-4F05-B8E1-55A179FE5A35")]
[NativeTypeName("struct IDWriteColorGlyphRunEnumerator1 : IDWriteColorGlyphRunEnumerator")]
[NativeInheritance("IDWriteColorGlyphRunEnumerator")]
public unsafe partial struct IDWriteColorGlyphRunEnumerator1 : IDWriteColorGlyphRunEnumerator1.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
    public HRESULT MoveNext(BOOL* hasRun)
    {
        return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator1*, BOOL*, int>)(lpVtbl[3]))((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), hasRun);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCurrentRun([NativeTypeName("const DWRITE_COLOR_GLYPH_RUN **")] DWRITE_COLOR_GLYPH_RUN** colorGlyphRun)
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteColorGlyphRunEnumerator1*, DWRITE_COLOR_GLYPH_RUN**, int>)(lpVtbl[4]))((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), colorGlyphRun);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentRun([NativeTypeName("const DWRITE_COLOR_GLYPH_RUN1 **")] DWRITE_COLOR_GLYPH_RUN1** colorGlyphRun)
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteColorGlyphRunEnumerator1*, DWRITE_COLOR_GLYPH_RUN1**, int>)(lpVtbl[5]))((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), colorGlyphRun);
    }

    public interface Interface : IDWriteColorGlyphRunEnumerator.Interface
    {
        [VtblIndex(5)]
        HRESULT GetCurrentRun([NativeTypeName("const DWRITE_COLOR_GLYPH_RUN1 **")] DWRITE_COLOR_GLYPH_RUN1** colorGlyphRun);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteColorGlyphRunEnumerator1*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteColorGlyphRunEnumerator1*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteColorGlyphRunEnumerator1*, uint> Release;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteColorGlyphRunEnumerator1*, BOOL*, int> MoveNext;

        [NativeTypeName("HRESULT (const DWRITE_COLOR_GLYPH_RUN **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteColorGlyphRunEnumerator1*, DWRITE_COLOR_GLYPH_RUN**, int> GetCurrentRun;

        [NativeTypeName("HRESULT (const DWRITE_COLOR_GLYPH_RUN1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteColorGlyphRunEnumerator1*, DWRITE_COLOR_GLYPH_RUN1**, int> GetCurrentRun1;
    }
}
