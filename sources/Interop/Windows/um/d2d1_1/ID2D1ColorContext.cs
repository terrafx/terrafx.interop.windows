// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1C4820BB-5771-4518-A581-2FE4DD0EC657")]
    public unsafe partial struct ID2D1ColorContext
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1ColorContext*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1ColorContext*, uint>)(lpVtbl[1]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1ColorContext*, uint>)(lpVtbl[2]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1ColorContext*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this), factory);
        }

        public D2D1_COLOR_SPACE GetColorSpace()
        {
            return ((delegate* stdcall<ID2D1ColorContext*, D2D1_COLOR_SPACE>)(lpVtbl[4]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetProfileSize()
        {
            return ((delegate* stdcall<ID2D1ColorContext*, uint>)(lpVtbl[5]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProfile([NativeTypeName("BYTE *")] byte* profile, [NativeTypeName("UINT32")] uint profileSize)
        {
            return ((delegate* stdcall<ID2D1ColorContext*, byte*, uint, int>)(lpVtbl[6]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this), profile, profileSize);
        }
    }
}
