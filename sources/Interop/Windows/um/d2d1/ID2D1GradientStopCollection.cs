// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD906A7-12E2-11DC-9FED-001143A055F9")]
    [NativeTypeName("struct ID2D1GradientStopCollection : ID2D1Resource")]
    public unsafe partial struct ID2D1GradientStopCollection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1GradientStopCollection*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1GradientStopCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1GradientStopCollection*, uint>)(lpVtbl[1]))((ID2D1GradientStopCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1GradientStopCollection*, uint>)(lpVtbl[2]))((ID2D1GradientStopCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1GradientStopCollection*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1GradientStopCollection*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetGradientStopCount()
        {
            return ((delegate* stdcall<ID2D1GradientStopCollection*, uint>)(lpVtbl[4]))((ID2D1GradientStopCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetGradientStops([NativeTypeName("D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount)
        {
            ((delegate* stdcall<ID2D1GradientStopCollection*, D2D1_GRADIENT_STOP*, uint, void>)(lpVtbl[5]))((ID2D1GradientStopCollection*)Unsafe.AsPointer(ref this), gradientStops, gradientStopsCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_GAMMA GetColorInterpolationGamma()
        {
            return ((delegate* stdcall<ID2D1GradientStopCollection*, D2D1_GAMMA>)(lpVtbl[6]))((ID2D1GradientStopCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_EXTEND_MODE GetExtendMode()
        {
            return ((delegate* stdcall<ID2D1GradientStopCollection*, D2D1_EXTEND_MODE>)(lpVtbl[7]))((ID2D1GradientStopCollection*)Unsafe.AsPointer(ref this));
        }
    }
}
