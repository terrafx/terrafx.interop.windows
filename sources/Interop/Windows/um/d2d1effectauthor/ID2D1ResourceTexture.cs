// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("688D15C3-02B0-438D-B13A-D1B44C32C39A")]
    public unsafe partial struct ID2D1ResourceTexture
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1ResourceTexture*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1ResourceTexture*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1ResourceTexture*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Update([NativeTypeName("const UINT32 *")] uint* minimumExtents, [NativeTypeName("const UINT32 *")] uint* maximimumExtents, [NativeTypeName("const UINT32 *")] uint* strides, [NativeTypeName("UINT32")] uint dimensions, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataCount)
        {
            return lpVtbl->Update((ID2D1ResourceTexture*)Unsafe.AsPointer(ref this), minimumExtents, maximimumExtents, strides, dimensions, data, dataCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ResourceTexture*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ResourceTexture*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ResourceTexture*, uint> Release;

            [NativeTypeName("HRESULT (const UINT32 *, const UINT32 *, const UINT32 *, UINT32, const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int> Update;
        }
    }
}
