// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("16CDFF07-C503-419C-83F2-0965C7AF1FA6")]
    [NativeTypeName("struct IDCompositionMatrixTransform : IDCompositionTransform")]
    [NativeInheritance("IDCompositionTransform")]
    public unsafe partial struct IDCompositionMatrixTransform : IDCompositionMatrixTransform.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionMatrixTransform*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionMatrixTransform*, uint>)(lpVtbl[1]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionMatrixTransform*, uint>)(lpVtbl[2]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetMatrix([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix)
        {
            return ((delegate* unmanaged<IDCompositionMatrixTransform*, D2D_MATRIX_3X2_F*, int>)(lpVtbl[3]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this), matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetMatrixElement(int row, int column, IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionMatrixTransform*, int, int, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this), row, column, animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetMatrixElement(int row, int column, float value)
        {
            return ((delegate* unmanaged<IDCompositionMatrixTransform*, int, int, float, int>)(lpVtbl[5]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this), row, column, value);
        }

        public interface Interface : IDCompositionTransform.Interface
        {
            [VtblIndex(3)]
            HRESULT SetMatrix([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix);

            [VtblIndex(4)]
            HRESULT SetMatrixElement(int row, int column, IDCompositionAnimation* animation);

            [VtblIndex(5)]
            HRESULT SetMatrixElement(int row, int column, float value);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionMatrixTransform*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionMatrixTransform*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionMatrixTransform*, uint> Release;

            [NativeTypeName("HRESULT (const D2D_MATRIX_3X2_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionMatrixTransform*, D2D_MATRIX_3X2_F*, int> SetMatrix;

            [NativeTypeName("HRESULT (int, int, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionMatrixTransform*, int, int, IDCompositionAnimation*, int> SetMatrixElement;

            [NativeTypeName("HRESULT (int, int, float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionMatrixTransform*, int, int, float, int> SetMatrixElement1;
        }
    }
}
