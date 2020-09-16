// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4AD18AC0-CFD2-4C2F-BB62-96E54FDB6879")]
    [NativeTypeName("struct IDCompositionShadowEffect : IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionShadowEffect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, uint>)(lpVtbl[1]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, uint>)(lpVtbl[2]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStandardDeviation(float amount)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, float, int>)(lpVtbl[4]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStandardDeviation([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetColor([NativeTypeName("const D2D1_VECTOR_4F &")] D2D_VECTOR_4F* color)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, D2D_VECTOR_4F*, int>)(lpVtbl[6]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRed(float amount)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, float, int>)(lpVtbl[7]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRed([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, IDCompositionAnimation*, int>)(lpVtbl[8]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGreen(float amount)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, float, int>)(lpVtbl[9]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGreen([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, IDCompositionAnimation*, int>)(lpVtbl[10]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlue(float amount)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, float, int>)(lpVtbl[11]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlue([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, IDCompositionAnimation*, int>)(lpVtbl[12]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAlpha(float amount)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, float, int>)(lpVtbl[13]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAlpha([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionShadowEffect*, IDCompositionAnimation*, int>)(lpVtbl[14]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
