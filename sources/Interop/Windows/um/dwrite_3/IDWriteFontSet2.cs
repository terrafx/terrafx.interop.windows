// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DC7EAD19-E54C-43AF-B2DA-4E2B79BA3F7F")]
    [NativeTypeName("struct IDWriteFontSet2 : IDWriteFontSet1")]
    public unsafe partial struct IDWriteFontSet2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, uint>)(lpVtbl[1]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, uint>)(lpVtbl[2]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontCount()
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, uint>)(lpVtbl[3]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFaceReference** fontFaceReference)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, uint, IDWriteFontFaceReference**, int>)(lpVtbl[4]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindFontFaceReference(IDWriteFontFaceReference* fontFaceReference, [NativeTypeName("UINT32 *")] uint* listIndex, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, IDWriteFontFaceReference*, uint*, int*, int>)(lpVtbl[5]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), fontFaceReference, listIndex, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindFontFace(IDWriteFontFace* fontFace, [NativeTypeName("UINT32 *")] uint* listIndex, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, IDWriteFontFace*, uint*, int*, int>)(lpVtbl[6]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), fontFace, listIndex, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyValues([NativeTypeName("UINT32")] uint listIndex, DWRITE_FONT_PROPERTY_ID propertyId, [NativeTypeName("BOOL *")] int* exists, IDWriteLocalizedStrings** values)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, uint, DWRITE_FONT_PROPERTY_ID, int*, IDWriteLocalizedStrings**, int>)(lpVtbl[9]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), listIndex, propertyId, exists, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, [NativeTypeName("const WCHAR *")] ushort* preferredLocaleNames, IDWriteStringList** values)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, DWRITE_FONT_PROPERTY_ID, ushort*, IDWriteStringList**, int>)(lpVtbl[8]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), propertyID, preferredLocaleNames, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, IDWriteStringList** values)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, DWRITE_FONT_PROPERTY_ID, IDWriteStringList**, int>)(lpVtbl[7]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), propertyID, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyOccurrenceCount([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* property, [NativeTypeName("UINT32 *")] uint* propertyOccurrenceCount)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, DWRITE_FONT_PROPERTY*, uint*, int>)(lpVtbl[10]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), property, propertyOccurrenceCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, IDWriteFontSet** filteredSet)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, DWRITE_FONT_PROPERTY*, uint, IDWriteFontSet**, int>)(lpVtbl[12]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), properties, propertyCount, filteredSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts([NativeTypeName("const WCHAR *")] ushort* familyName, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, IDWriteFontSet** filteredSet)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, ushort*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontSet**, int>)(lpVtbl[11]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), familyName, fontWeight, fontStretch, fontStyle, filteredSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* fontProperty, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontSet1** matchingFonts)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, DWRITE_FONT_PROPERTY*, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontSet1**, int>)(lpVtbl[13]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), fontProperty, fontAxisValues, fontAxisValueCount, matchingFonts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFirstFontResources(IDWriteFontSet1** filteredFontSet)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, IDWriteFontSet1**, int>)(lpVtbl[14]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), filteredFontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFilteredFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, [NativeTypeName("BOOL")] int selectAnyProperty, IDWriteFontSet1** filteredFontSet)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, DWRITE_FONT_PROPERTY*, uint, int, IDWriteFontSet1**, int>)(lpVtbl[17]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), properties, propertyCount, selectAnyProperty, filteredFontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFilteredFonts([NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, [NativeTypeName("BOOL")] int selectAnyRange, IDWriteFontSet1** filteredFontSet)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, DWRITE_FONT_AXIS_RANGE*, uint, int, IDWriteFontSet1**, int>)(lpVtbl[16]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount, selectAnyRange, filteredFontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFilteredFonts([NativeTypeName("const UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint indexCount, IDWriteFontSet1** filteredFontSet)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, uint*, uint, IDWriteFontSet1**, int>)(lpVtbl[15]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), indices, indexCount, filteredFontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFilteredFontIndices([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, [NativeTypeName("BOOL")] int selectAnyProperty, [NativeTypeName("UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint maxIndexCount, [NativeTypeName("UINT32 *")] uint* actualIndexCount)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, DWRITE_FONT_PROPERTY*, uint, int, uint*, uint, uint*, int>)(lpVtbl[19]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), properties, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFilteredFontIndices([NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, [NativeTypeName("BOOL")] int selectAnyRange, [NativeTypeName("UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint maxIndexCount, [NativeTypeName("UINT32 *")] uint* actualIndexCount)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, DWRITE_FONT_AXIS_RANGE*, uint, int, uint*, uint, uint*, int>)(lpVtbl[18]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount, selectAnyRange, indices, maxIndexCount, actualIndexCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontAxisRanges(DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint maxFontAxisRangeCount, [NativeTypeName("UINT32 *")] uint* actualFontAxisRangeCount)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, DWRITE_FONT_AXIS_RANGE*, uint, uint*, int>)(lpVtbl[21]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontAxisRanges([NativeTypeName("UINT32")] uint listIndex, DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint maxFontAxisRangeCount, [NativeTypeName("UINT32 *")] uint* actualFontAxisRangeCount)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, uint, DWRITE_FONT_AXIS_RANGE*, uint, uint*, int>)(lpVtbl[20]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), listIndex, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFaceReference1** fontFaceReference)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, uint, IDWriteFontFaceReference1**, int>)(lpVtbl[22]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontResource([NativeTypeName("UINT32")] uint listIndex, IDWriteFontResource** fontResource)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, uint, IDWriteFontResource**, int>)(lpVtbl[23]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), listIndex, fontResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFace5** fontFace)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, uint, IDWriteFontFace5**, int>)(lpVtbl[24]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), listIndex, fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex)
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, uint, DWRITE_LOCALITY>)(lpVtbl[25]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this), listIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HANDLE")]
        public IntPtr GetExpirationEvent()
        {
            return ((delegate* unmanaged<IDWriteFontSet2*, IntPtr>)(lpVtbl[26]))((IDWriteFontSet2*)Unsafe.AsPointer(ref this));
        }
    }
}
