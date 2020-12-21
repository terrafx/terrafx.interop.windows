// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6027496E-CB3A-49AB-934F-D798DA4F7DA6")]
    [NativeTypeName("struct IDCompositionBrightnessEffect : IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionBrightnessEffect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, uint>)(lpVtbl[1]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, uint>)(lpVtbl[2]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWhitePoint([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* whitePoint)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, D2D_VECTOR_2F*, int>)(lpVtbl[4]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlackPoint([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* blackPoint)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, D2D_VECTOR_2F*, int>)(lpVtbl[5]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointX(float whitePointX)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, float, int>)(lpVtbl[6]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePointX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointY(float whitePointY)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, float, int>)(lpVtbl[8]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePointY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointX(float blackPointX)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, float, int>)(lpVtbl[10]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPointX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int>)(lpVtbl[11]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointY(float blackPointY)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, float, int>)(lpVtbl[12]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPointY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int>)(lpVtbl[13]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
