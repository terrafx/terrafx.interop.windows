// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("639CFAD8-0FB4-4B21-A58A-067920120009")]
    [NativeTypeName("struct IDWriteTextAnalysisSource1 : IDWriteTextAnalysisSource")]
    public unsafe partial struct IDWriteTextAnalysisSource1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, uint>)(lpVtbl[1]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, uint>)(lpVtbl[2]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTextAtPosition([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("const WCHAR **")] ushort** textString, [NativeTypeName("UINT32 *")] uint* textLength)
        {
            return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, uint, ushort**, uint*, int>)(lpVtbl[3]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textString, textLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTextBeforePosition([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("const WCHAR **")] ushort** textString, [NativeTypeName("UINT32 *")] uint* textLength)
        {
            return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, uint, ushort**, uint*, int>)(lpVtbl[4]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textString, textLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_READING_DIRECTION GetParagraphReadingDirection()
        {
            return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, DWRITE_READING_DIRECTION>)(lpVtbl[5]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32 *")] uint* textLength, [NativeTypeName("const WCHAR **")] ushort** localeName)
        {
            return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, uint, uint*, ushort**, int>)(lpVtbl[6]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textLength, localeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNumberSubstitution([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32 *")] uint* textLength, [NativeTypeName("IDWriteNumberSubstitution **")] IDWriteNumberSubstitution** numberSubstitution)
        {
            return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, uint, uint*, IDWriteNumberSubstitution**, int>)(lpVtbl[7]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textLength, numberSubstitution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVerticalGlyphOrientation([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32 *")] uint* textLength, [NativeTypeName("DWRITE_VERTICAL_GLYPH_ORIENTATION *")] DWRITE_VERTICAL_GLYPH_ORIENTATION* glyphOrientation, [NativeTypeName("UINT8 *")] byte* bidiLevel)
        {
            return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, uint, uint*, DWRITE_VERTICAL_GLYPH_ORIENTATION*, byte*, int>)(lpVtbl[8]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textLength, glyphOrientation, bidiLevel);
        }
    }
}
