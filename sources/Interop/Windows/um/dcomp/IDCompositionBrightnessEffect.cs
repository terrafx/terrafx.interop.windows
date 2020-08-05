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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionBrightnessEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionBrightnessEffect*, uint>)(lpVtbl[1]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionBrightnessEffect*, uint>)(lpVtbl[2]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* stdcall<IDCompositionBrightnessEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePoint([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* whitePoint)
        {
            return ((delegate* stdcall<IDCompositionBrightnessEffect*, D2D_VECTOR_2F*, int>)(lpVtbl[4]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePoint);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlackPoint([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* blackPoint)
        {
            return ((delegate* stdcall<IDCompositionBrightnessEffect*, D2D_VECTOR_2F*, int>)(lpVtbl[5]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPoint);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointX(float whitePointX)
        {
            return ((delegate* stdcall<IDCompositionBrightnessEffect*, float, int>)(lpVtbl[6]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePointX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointY(float whitePointY)
        {
            return ((delegate* stdcall<IDCompositionBrightnessEffect*, float, int>)(lpVtbl[8]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), whitePointY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointX(float blackPointX)
        {
            return ((delegate* stdcall<IDCompositionBrightnessEffect*, float, int>)(lpVtbl[10]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPointX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int>)(lpVtbl[11]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointY(float blackPointY)
        {
            return ((delegate* stdcall<IDCompositionBrightnessEffect*, float, int>)(lpVtbl[12]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), blackPointY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlackPointY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionBrightnessEffect*, IDCompositionAnimation*, int>)(lpVtbl[13]))((IDCompositionBrightnessEffect*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
