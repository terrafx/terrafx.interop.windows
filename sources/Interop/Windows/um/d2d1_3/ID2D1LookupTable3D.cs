// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("53DD9855-A3B0-4D5B-82E1-26E25C5E5797")]
    [NativeTypeName("struct ID2D1LookupTable3D : ID2D1Resource")]
    public unsafe partial struct ID2D1LookupTable3D
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1LookupTable3D*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1LookupTable3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1LookupTable3D*, uint>)(lpVtbl[1]))((ID2D1LookupTable3D*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1LookupTable3D*, uint>)(lpVtbl[2]))((ID2D1LookupTable3D*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1LookupTable3D*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1LookupTable3D*)Unsafe.AsPointer(ref this), factory);
        }
    }
}
