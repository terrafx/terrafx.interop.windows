// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD9069D-12E2-11DC-9FED-001143A055F9")]
    [NativeTypeName("struct ID2D1StrokeStyle : ID2D1Resource")]
    public unsafe partial struct ID2D1StrokeStyle
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle*, uint>)(lpVtbl[1]))((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle*, uint>)(lpVtbl[2]))((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1StrokeStyle*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_CAP_STYLE GetStartCap()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle*, D2D1_CAP_STYLE>)(lpVtbl[4]))((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_CAP_STYLE GetEndCap()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle*, D2D1_CAP_STYLE>)(lpVtbl[5]))((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_CAP_STYLE GetDashCap()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle*, D2D1_CAP_STYLE>)(lpVtbl[6]))((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetMiterLimit()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle*, float>)(lpVtbl[7]))((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_LINE_JOIN GetLineJoin()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle*, D2D1_LINE_JOIN>)(lpVtbl[8]))((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("FLOAT")]
        public float GetDashOffset()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle*, float>)(lpVtbl[9]))((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_DASH_STYLE GetDashStyle()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle*, D2D1_DASH_STYLE>)(lpVtbl[10]))((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetDashesCount()
        {
            return ((delegate* unmanaged<ID2D1StrokeStyle*, uint>)(lpVtbl[11]))((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDashes([NativeTypeName("FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount)
        {
            ((delegate* unmanaged<ID2D1StrokeStyle*, float*, uint, void>)(lpVtbl[12]))((ID2D1StrokeStyle*)Unsafe.AsPointer(ref this), dashes, dashesCount);
        }
    }
}
