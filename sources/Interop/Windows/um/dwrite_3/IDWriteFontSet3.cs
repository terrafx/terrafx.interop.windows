// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7C073EF2-A7F4-4045-8C32-8AB8AE640F90")]
    [NativeTypeName("struct IDWriteFontSet3 : IDWriteFontSet2")]
    [NativeInheritance("IDWriteFontSet2")]
    public unsafe partial struct IDWriteFontSet3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, uint>)(lpVtbl[1]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, uint>)(lpVtbl[2]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontCount()
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, uint>)(lpVtbl[3]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFaceReference** fontFaceReference)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, uint, IDWriteFontFaceReference**, int>)(lpVtbl[4]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT FindFontFaceReference(IDWriteFontFaceReference* fontFaceReference, [NativeTypeName("UINT32 *")] uint* listIndex, BOOL* exists)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, IDWriteFontFaceReference*, uint*, BOOL*, int>)(lpVtbl[5]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), fontFaceReference, listIndex, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT FindFontFace(IDWriteFontFace* fontFace, [NativeTypeName("UINT32 *")] uint* listIndex, BOOL* exists)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, IDWriteFontFace*, uint*, BOOL*, int>)(lpVtbl[6]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), fontFace, listIndex, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetPropertyValues([NativeTypeName("UINT32")] uint listIndex, DWRITE_FONT_PROPERTY_ID propertyId, BOOL* exists, IDWriteLocalizedStrings** values)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, uint, DWRITE_FONT_PROPERTY_ID, BOOL*, IDWriteLocalizedStrings**, int>)(lpVtbl[9]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), listIndex, propertyId, exists, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, [NativeTypeName("const WCHAR *")] ushort* preferredLocaleNames, IDWriteStringList** values)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, DWRITE_FONT_PROPERTY_ID, ushort*, IDWriteStringList**, int>)(lpVtbl[8]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), propertyID, preferredLocaleNames, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, IDWriteStringList** values)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, DWRITE_FONT_PROPERTY_ID, IDWriteStringList**, int>)(lpVtbl[7]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), propertyID, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetPropertyOccurrenceCount([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* property, [NativeTypeName("UINT32 *")] uint* propertyOccurrenceCount)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, DWRITE_FONT_PROPERTY*, uint*, int>)(lpVtbl[10]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), property, propertyOccurrenceCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetMatchingFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, IDWriteFontSet** filteredSet)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, DWRITE_FONT_PROPERTY*, uint, IDWriteFontSet**, int>)(lpVtbl[12]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), properties, propertyCount, filteredSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetMatchingFonts([NativeTypeName("const WCHAR *")] ushort* familyName, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, IDWriteFontSet** filteredSet)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, ushort*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontSet**, int>)(lpVtbl[11]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), familyName, fontWeight, fontStretch, fontStyle, filteredSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetMatchingFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* fontProperty, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontSet1** matchingFonts)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, DWRITE_FONT_PROPERTY*, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontSet1**, int>)(lpVtbl[13]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), fontProperty, fontAxisValues, fontAxisValueCount, matchingFonts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetFirstFontResources(IDWriteFontSet1** filteredFontSet)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, IDWriteFontSet1**, int>)(lpVtbl[14]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), filteredFontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetFilteredFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, BOOL selectAnyProperty, IDWriteFontSet1** filteredFontSet)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, DWRITE_FONT_PROPERTY*, uint, BOOL, IDWriteFontSet1**, int>)(lpVtbl[17]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), properties, propertyCount, selectAnyProperty, filteredFontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetFilteredFonts([NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, BOOL selectAnyRange, IDWriteFontSet1** filteredFontSet)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, DWRITE_FONT_AXIS_RANGE*, uint, BOOL, IDWriteFontSet1**, int>)(lpVtbl[16]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount, selectAnyRange, filteredFontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetFilteredFonts([NativeTypeName("const UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint indexCount, IDWriteFontSet1** filteredFontSet)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, uint*, uint, IDWriteFontSet1**, int>)(lpVtbl[15]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), indices, indexCount, filteredFontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetFilteredFontIndices([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, BOOL selectAnyProperty, [NativeTypeName("UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint maxIndexCount, [NativeTypeName("UINT32 *")] uint* actualIndexCount)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, DWRITE_FONT_PROPERTY*, uint, BOOL, uint*, uint, uint*, int>)(lpVtbl[19]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), properties, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetFilteredFontIndices([NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, BOOL selectAnyRange, [NativeTypeName("UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint maxIndexCount, [NativeTypeName("UINT32 *")] uint* actualIndexCount)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, DWRITE_FONT_AXIS_RANGE*, uint, BOOL, uint*, uint, uint*, int>)(lpVtbl[18]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount, selectAnyRange, indices, maxIndexCount, actualIndexCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetFontAxisRanges(DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint maxFontAxisRangeCount, [NativeTypeName("UINT32 *")] uint* actualFontAxisRangeCount)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, DWRITE_FONT_AXIS_RANGE*, uint, uint*, int>)(lpVtbl[21]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetFontAxisRanges([NativeTypeName("UINT32")] uint listIndex, DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint maxFontAxisRangeCount, [NativeTypeName("UINT32 *")] uint* actualFontAxisRangeCount)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, uint, DWRITE_FONT_AXIS_RANGE*, uint, uint*, int>)(lpVtbl[20]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), listIndex, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFaceReference1** fontFaceReference)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, uint, IDWriteFontFaceReference1**, int>)(lpVtbl[22]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT CreateFontResource([NativeTypeName("UINT32")] uint listIndex, IDWriteFontResource** fontResource)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, uint, IDWriteFontResource**, int>)(lpVtbl[23]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), listIndex, fontResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT CreateFontFace([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFace5** fontFace)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, uint, IDWriteFontFace5**, int>)(lpVtbl[24]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), listIndex, fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, uint, DWRITE_LOCALITY>)(lpVtbl[25]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), listIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HANDLE")]
        public IntPtr GetExpirationEvent()
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, IntPtr>)(lpVtbl[26]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public DWRITE_FONT_SOURCE_TYPE GetFontSourceType([NativeTypeName("UINT32")] uint fontIndex)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, uint, DWRITE_FONT_SOURCE_TYPE>)(lpVtbl[27]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), fontIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontSourceNameLength([NativeTypeName("UINT32")] uint listIndex)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, uint, uint>)(lpVtbl[28]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), listIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT GetFontSourceName([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR *")] ushort* stringBuffer, [NativeTypeName("UINT32")] uint stringBufferSize)
        {
            return ((delegate* unmanaged<IDWriteFontSet3*, uint, ushort*, uint, int>)(lpVtbl[29]))((IDWriteFontSet3*)Unsafe.AsPointer(ref this), listIndex, stringBuffer, stringBufferSize);
        }
    }
}
