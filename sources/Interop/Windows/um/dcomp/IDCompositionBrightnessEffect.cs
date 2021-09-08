// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6027496E-CB3A-49AB-934F-D798DA4F7DA6")]
    [NativeTypeName("struct IDCompositionBrightnessEffect : IDCompositionFilterEffect")]
    [NativeInheritance("IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionBrightnessEffect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionBrightnessEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionBrightnessEffect*, uint>)(lpVtbl[1]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionBrightnessEffect*, uint>)(lpVtbl[2]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* unmanaged<IDCompositionBrightnessEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetWhitePoint([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* whitePoint)
        {
            return ((delegate* unmanaged<IDCompositionBrightnessEffect*, D2D_VECTOR_2F*, int>)(lpVtbl[4]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlackPoint([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* blackPoint)
        {
            return ((delegate* unmanaged<IDCompositionBrightnessEffect*, D2D_VECTOR_2F*, int>)(lpVtbl[5]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointX(float whitePointX)
        {
            return ((delegate* unmanaged<IDCompositionBrightnessEffect*, float, int>)(lpVtbl[7]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePointX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointY(float whitePointY)
        {
            return ((delegate* unmanaged<IDCompositionBrightnessEffect*, float, int>)(lpVtbl[9]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePointY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int>)(lpVtbl[8]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointX(float blackPointX)
        {
            return ((delegate* unmanaged<IDCompositionBrightnessEffect*, float, int>)(lpVtbl[11]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPointX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int>)(lpVtbl[10]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointY(float blackPointY)
        {
            return ((delegate* unmanaged<IDCompositionBrightnessEffect*, float, int>)(lpVtbl[13]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPointY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int>)(lpVtbl[12]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
