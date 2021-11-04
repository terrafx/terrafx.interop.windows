// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F292E401-C050-4CDE-83D7-04962D3B23C2")]
    [NativeTypeName("struct ID2D1GradientMesh : ID2D1Resource")]
    [NativeInheritance("ID2D1Resource")]
    public unsafe partial struct ID2D1GradientMesh
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1GradientMesh*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1GradientMesh*, uint>)(lpVtbl[1]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1GradientMesh*, uint>)(lpVtbl[2]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1GradientMesh*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("UINT32")]
        public uint GetPatchCount()
        {
            return ((delegate* unmanaged<ID2D1GradientMesh*, uint>)(lpVtbl[4]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPatches([NativeTypeName("UINT32")] uint startIndex, D2D1_GRADIENT_MESH_PATCH* patches, [NativeTypeName("UINT32")] uint patchesCount)
        {
            return ((delegate* unmanaged<ID2D1GradientMesh*, uint, D2D1_GRADIENT_MESH_PATCH*, uint, int>)(lpVtbl[5]))((ID2D1GradientMesh*)Unsafe.AsPointer(ref this), startIndex, patches, patchesCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1GradientMesh*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1GradientMesh*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1GradientMesh*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1GradientMesh*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1GradientMesh*, uint> GetPatchCount;

            [NativeTypeName("HRESULT (UINT32, D2D1_GRADIENT_MESH_PATCH *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1GradientMesh*, uint, D2D1_GRADIENT_MESH_PATCH*, uint, int> GetPatches;
        }
    }
}
