// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("82237326-8111-4F7C-BCF4-B5C1175564FE")]
    public unsafe partial struct ID2D1GdiMetafileSink
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1GdiMetafileSink*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1GdiMetafileSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1GdiMetafileSink*, uint>)(lpVtbl[1]))((ID2D1GdiMetafileSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1GdiMetafileSink*, uint>)(lpVtbl[2]))((ID2D1GdiMetafileSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessRecord([NativeTypeName("DWORD")] uint recordType, [NativeTypeName("const void *")] void* recordData, [NativeTypeName("DWORD")] uint recordDataSize)
        {
            return ((delegate* stdcall<ID2D1GdiMetafileSink*, uint, void*, uint, int>)(lpVtbl[3]))((ID2D1GdiMetafileSink*)Unsafe.AsPointer(ref this), recordType, recordData, recordDataSize);
        }
    }
}
