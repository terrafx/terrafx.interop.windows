// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F292E401-C050-4CDE-83D7-04962D3B23C2")]
    public unsafe partial struct ID2D1GradientMesh
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1GradientMesh*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1GradientMesh*, uint>)(lpVtbl[1]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1GradientMesh*, uint>)(lpVtbl[2]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1GradientMesh*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPatchCount()
        {
            return ((delegate* stdcall<ID2D1GradientMesh*, uint>)(lpVtbl[4]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPatches([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("D2D1_GRADIENT_MESH_PATCH *")] D2D1_GRADIENT_MESH_PATCH* patches, [NativeTypeName("UINT32")] uint patchesCount)
        {
            return ((delegate* stdcall<ID2D1GradientMesh*, uint, D2D1_GRADIENT_MESH_PATCH*, uint, int>)(lpVtbl[5]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this), startIndex, patches, patchesCount);
        }
    }
}
