// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ACD16696-8C14-4F5D-877E-FE3FC1D32737")]
    [NativeTypeName("struct IDWriteFont : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDWriteFont
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFont*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFont*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFont*, uint>)(lpVtbl[1]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFont*, uint>)(lpVtbl[2]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily(IDWriteFontFamily** fontFamily)
        {
            return ((delegate* unmanaged<IDWriteFont*, IDWriteFontFamily**, int>)(lpVtbl[3]))((IDWriteFont*)Unsafe.AsPointer(ref this), fontFamily);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public DWRITE_FONT_WEIGHT GetWeight()
        {
            return ((delegate* unmanaged<IDWriteFont*, DWRITE_FONT_WEIGHT>)(lpVtbl[4]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public DWRITE_FONT_STRETCH GetStretch()
        {
            return ((delegate* unmanaged<IDWriteFont*, DWRITE_FONT_STRETCH>)(lpVtbl[5]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public DWRITE_FONT_STYLE GetStyle()
        {
            return ((delegate* unmanaged<IDWriteFont*, DWRITE_FONT_STYLE>)(lpVtbl[6]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("BOOL")]
        public int IsSymbolFont()
        {
            return ((delegate* unmanaged<IDWriteFont*, int>)(lpVtbl[7]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetFaceNames(IDWriteLocalizedStrings** names)
        {
            return ((delegate* unmanaged<IDWriteFont*, IDWriteLocalizedStrings**, int>)(lpVtbl[8]))((IDWriteFont*)Unsafe.AsPointer(ref this), names);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, IDWriteLocalizedStrings** informationalStrings, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* unmanaged<IDWriteFont*, DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings**, int*, int>)(lpVtbl[9]))((IDWriteFont*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            return ((delegate* unmanaged<IDWriteFont*, DWRITE_FONT_SIMULATIONS>)(lpVtbl[10]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void GetMetrics(DWRITE_FONT_METRICS* fontMetrics)
        {
            ((delegate* unmanaged<IDWriteFont*, DWRITE_FONT_METRICS*, void>)(lpVtbl[11]))((IDWriteFont*)Unsafe.AsPointer(ref this), fontMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int HasCharacter([NativeTypeName("UINT32")] uint unicodeValue, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* unmanaged<IDWriteFont*, uint, int*, int>)(lpVtbl[12]))((IDWriteFont*)Unsafe.AsPointer(ref this), unicodeValue, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace(IDWriteFontFace** fontFace)
        {
            return ((delegate* unmanaged<IDWriteFont*, IDWriteFontFace**, int>)(lpVtbl[13]))((IDWriteFont*)Unsafe.AsPointer(ref this), fontFace);
        }
    }
}
