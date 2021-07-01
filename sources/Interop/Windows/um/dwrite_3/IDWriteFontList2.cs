// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C0763A34-77AF-445A-B735-08C37B0A5BF5")]
    [NativeTypeName("struct IDWriteFontList2 : IDWriteFontList1")]
    public unsafe partial struct IDWriteFontList2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontList2*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontList2*, uint>)(lpVtbl[1]))((IDWriteFontList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontList2*, uint>)(lpVtbl[2]))((IDWriteFontList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection(IDWriteFontCollection** fontCollection)
        {
            return ((delegate* unmanaged<IDWriteFontList2*, IDWriteFontCollection**, int>)(lpVtbl[3]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), fontCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontCount()
        {
            return ((delegate* unmanaged<IDWriteFontList2*, uint>)(lpVtbl[4]))((IDWriteFontList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFont([NativeTypeName("UINT32")] uint index, IDWriteFont** font)
        {
            return ((delegate* unmanaged<IDWriteFontList2*, uint, IDWriteFont**, int>)(lpVtbl[5]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), index, font);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex)
        {
            return ((delegate* unmanaged<IDWriteFontList2*, uint, DWRITE_LOCALITY>)(lpVtbl[6]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), listIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFont([NativeTypeName("UINT32")] uint listIndex, IDWriteFont3** font)
        {
            return ((delegate* unmanaged<IDWriteFontList2*, uint, IDWriteFont3**, int>)(lpVtbl[7]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), listIndex, font);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFaceReference** fontFaceReference)
        {
            return ((delegate* unmanaged<IDWriteFontList2*, uint, IDWriteFontFaceReference**, int>)(lpVtbl[8]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontSet(IDWriteFontSet1** fontSet)
        {
            return ((delegate* unmanaged<IDWriteFontList2*, IDWriteFontSet1**, int>)(lpVtbl[9]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), fontSet);
        }
    }
}
