// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FD0ECB6B-91E6-411E-8655-395E760F91B4")]
    [NativeTypeName("struct ID2D1GdiMetafileSink1 : ID2D1GdiMetafileSink")]
    public unsafe partial struct ID2D1GdiMetafileSink1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1GdiMetafileSink1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1GdiMetafileSink1*, uint>)(lpVtbl[1]))((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1GdiMetafileSink1*, uint>)(lpVtbl[2]))((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessRecord([NativeTypeName("DWORD")] uint recordType, [NativeTypeName("const void *")] void* recordData, [NativeTypeName("DWORD")] uint recordDataSize)
        {
            return ((delegate* unmanaged<ID2D1GdiMetafileSink1*, uint, void*, uint, int>)(lpVtbl[3]))((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this), recordType, recordData, recordDataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessRecord([NativeTypeName("DWORD")] uint recordType, [NativeTypeName("const void *")] void* recordData, [NativeTypeName("DWORD")] uint recordDataSize, [NativeTypeName("UINT32")] uint flags)
        {
            return ((delegate* unmanaged<ID2D1GdiMetafileSink1*, uint, void*, uint, uint, int>)(lpVtbl[4]))((ID2D1GdiMetafileSink1*)Unsafe.AsPointer(ref this), recordType, recordData, recordDataSize, flags);
        }
    }
}
