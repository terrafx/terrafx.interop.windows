// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A4D055A6-F9E3-4E25-93B7-9E309F3AF8E9")]
    [NativeTypeName("struct IDWriteFontCollection3 : IDWriteFontCollection2")]
    public unsafe partial struct IDWriteFontCollection3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontCollection3*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontCollection3*, uint>)(lpVtbl[1]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontCollection3*, uint>)(lpVtbl[2]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyCount()
        {
            return ((delegate* unmanaged<IDWriteFontCollection3*, uint>)(lpVtbl[3]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily** fontFamily)
        {
            return ((delegate* unmanaged<IDWriteFontCollection3*, uint, IDWriteFontFamily**, int>)(lpVtbl[4]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), index, fontFamily);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindFamilyName([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("UINT32 *")] uint* index, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* unmanaged<IDWriteFontCollection3*, ushort*, uint*, int*, int>)(lpVtbl[5]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), familyName, index, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFromFontFace(IDWriteFontFace* fontFace, IDWriteFont** font)
        {
            return ((delegate* unmanaged<IDWriteFontCollection3*, IDWriteFontFace*, IDWriteFont**, int>)(lpVtbl[6]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), fontFace, font);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontSet(IDWriteFontSet** fontSet)
        {
            return ((delegate* unmanaged<IDWriteFontCollection3*, IDWriteFontSet**, int>)(lpVtbl[7]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), fontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily1** fontFamily)
        {
            return ((delegate* unmanaged<IDWriteFontCollection3*, uint, IDWriteFontFamily1**, int>)(lpVtbl[8]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), index, fontFamily);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily2** fontFamily)
        {
            return ((delegate* unmanaged<IDWriteFontCollection3*, uint, IDWriteFontFamily2**, int>)(lpVtbl[9]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), index, fontFamily);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontList2** fontList)
        {
            return ((delegate* unmanaged<IDWriteFontCollection3*, ushort*, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontList2**, int>)(lpVtbl[10]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), familyName, fontAxisValues, fontAxisValueCount, fontList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_FAMILY_MODEL GetFontFamilyModel()
        {
            return ((delegate* unmanaged<IDWriteFontCollection3*, DWRITE_FONT_FAMILY_MODEL>)(lpVtbl[11]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontSet(IDWriteFontSet1** fontSet)
        {
            return ((delegate* unmanaged<IDWriteFontCollection3*, IDWriteFontSet1**, int>)(lpVtbl[12]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), fontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HANDLE")]
        public IntPtr GetExpirationEvent()
        {
            return ((delegate* unmanaged<IDWriteFontCollection3*, IntPtr>)(lpVtbl[13]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
        }
    }
}
