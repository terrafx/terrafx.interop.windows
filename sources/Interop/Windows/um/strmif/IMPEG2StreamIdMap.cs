// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D0E04C47-25B8-4369-925A-362A01D95444")]
    [NativeTypeName("struct IMPEG2StreamIdMap : IUnknown")]
    public unsafe partial struct IMPEG2StreamIdMap
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMPEG2StreamIdMap*, Guid*, void**, int>)(lpVtbl[0]))((IMPEG2StreamIdMap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMPEG2StreamIdMap*, uint>)(lpVtbl[1]))((IMPEG2StreamIdMap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMPEG2StreamIdMap*, uint>)(lpVtbl[2]))((IMPEG2StreamIdMap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MapStreamId([NativeTypeName("ULONG")] uint ulStreamId, [NativeTypeName("DWORD")] uint MediaSampleContent, [NativeTypeName("ULONG")] uint ulSubstreamFilterValue, int iDataOffset)
        {
            return ((delegate* stdcall<IMPEG2StreamIdMap*, uint, uint, uint, int, int>)(lpVtbl[3]))((IMPEG2StreamIdMap*)Unsafe.AsPointer(ref this), ulStreamId, MediaSampleContent, ulSubstreamFilterValue, iDataOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnmapStreamId([NativeTypeName("ULONG")] uint culStreamId, [NativeTypeName("ULONG *")] uint* pulStreamId)
        {
            return ((delegate* stdcall<IMPEG2StreamIdMap*, uint, uint*, int>)(lpVtbl[4]))((IMPEG2StreamIdMap*)Unsafe.AsPointer(ref this), culStreamId, pulStreamId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumStreamIdMap([NativeTypeName("IEnumStreamIdMap **")] IEnumStreamIdMap** ppIEnumStreamIdMap)
        {
            return ((delegate* stdcall<IMPEG2StreamIdMap*, IEnumStreamIdMap**, int>)(lpVtbl[5]))((IMPEG2StreamIdMap*)Unsafe.AsPointer(ref this), ppIEnumStreamIdMap);
        }
    }
}
