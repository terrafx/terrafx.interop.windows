// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE1572F4-5DD0-4777-998B-9279472AE63B")]
    public unsafe partial struct ID2D1GradientStopCollection1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetGradientStopCount()
        {
            return lpVtbl->GetGradientStopCount((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        public void GetGradientStops([NativeTypeName("D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount)
        {
            lpVtbl->GetGradientStops((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this), gradientStops, gradientStopsCount);
        }

        public D2D1_GAMMA GetColorInterpolationGamma()
        {
            return lpVtbl->GetColorInterpolationGamma((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        public D2D1_EXTEND_MODE GetExtendMode()
        {
            return lpVtbl->GetExtendMode((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        public void GetGradientStops1([NativeTypeName("D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount)
        {
            lpVtbl->GetGradientStops1((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this), gradientStops, gradientStopsCount);
        }

        public D2D1_COLOR_SPACE GetPreInterpolationSpace()
        {
            return lpVtbl->GetPreInterpolationSpace((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        public D2D1_COLOR_SPACE GetPostInterpolationSpace()
        {
            return lpVtbl->GetPostInterpolationSpace((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        public D2D1_BUFFER_PRECISION GetBufferPrecision()
        {
            return lpVtbl->GetBufferPrecision((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        public D2D1_COLOR_INTERPOLATION_MODE GetColorInterpolationMode()
        {
            return lpVtbl->GetColorInterpolationMode((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GradientStopCollection1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GradientStopCollection1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GradientStopCollection1*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GradientStopCollection1*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GradientStopCollection1*, uint> GetGradientStopCount;

            [NativeTypeName("void (D2D1_GRADIENT_STOP *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GradientStopCollection1*, D2D1_GRADIENT_STOP*, uint, void> GetGradientStops;

            [NativeTypeName("D2D1_GAMMA () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GradientStopCollection1*, D2D1_GAMMA> GetColorInterpolationGamma;

            [NativeTypeName("D2D1_EXTEND_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GradientStopCollection1*, D2D1_EXTEND_MODE> GetExtendMode;

            [NativeTypeName("void (D2D1_GRADIENT_STOP *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GradientStopCollection1*, D2D1_GRADIENT_STOP*, uint, void> GetGradientStops1;

            [NativeTypeName("D2D1_COLOR_SPACE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GradientStopCollection1*, D2D1_COLOR_SPACE> GetPreInterpolationSpace;

            [NativeTypeName("D2D1_COLOR_SPACE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GradientStopCollection1*, D2D1_COLOR_SPACE> GetPostInterpolationSpace;

            [NativeTypeName("D2D1_BUFFER_PRECISION () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GradientStopCollection1*, D2D1_BUFFER_PRECISION> GetBufferPrecision;

            [NativeTypeName("D2D1_COLOR_INTERPOLATION_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1GradientStopCollection1*, D2D1_COLOR_INTERPOLATION_MODE> GetColorInterpolationMode;
        }
    }
}
