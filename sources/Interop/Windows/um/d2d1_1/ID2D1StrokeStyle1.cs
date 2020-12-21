// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("10A72A66-E91C-43F4-993F-DDF4B82B0B4A")]
    [NativeTypeName("struct ID2D1StrokeStyle1 : ID2D1StrokeStyle")]
    public unsafe partial struct ID2D1StrokeStyle1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, uint>)(lpVtbl[1]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, uint>)(lpVtbl[2]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_CAP_STYLE GetStartCap()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, D2D1_CAP_STYLE>)(lpVtbl[4]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_CAP_STYLE GetEndCap()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, D2D1_CAP_STYLE>)(lpVtbl[5]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_CAP_STYLE GetDashCap()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, D2D1_CAP_STYLE>)(lpVtbl[6]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetMiterLimit()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, float>)(lpVtbl[7]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_LINE_JOIN GetLineJoin()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, D2D1_LINE_JOIN>)(lpVtbl[8]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetDashOffset()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, float>)(lpVtbl[9]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_DASH_STYLE GetDashStyle()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, D2D1_DASH_STYLE>)(lpVtbl[10]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetDashesCount()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, uint>)(lpVtbl[11]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDashes([NativeTypeName("FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, float*, uint, void>)(lpVtbl[12]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this), dashes, dashesCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_STROKE_TRANSFORM_TYPE GetStrokeTransformType()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle1*, D2D1_STROKE_TRANSFORM_TYPE>)(lpVtbl[13]))((ID2D1StrokeStyle1*)Unsafe.AsPointer(ref this));
        }
    }
}
