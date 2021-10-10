// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BAB20D63-4361-45DA-A24F-AB8508846B5B")]
    [NativeTypeName("struct IUIAnimationPrimitiveInterpolation : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationPrimitiveInterpolation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationPrimitiveInterpolation*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationPrimitiveInterpolation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationPrimitiveInterpolation*, uint>)(lpVtbl[1]))((IUIAnimationPrimitiveInterpolation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationPrimitiveInterpolation*, uint>)(lpVtbl[2]))((IUIAnimationPrimitiveInterpolation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int AddCubic([NativeTypeName("UINT")] uint dimension, [NativeTypeName("UI_ANIMATION_SECONDS")] double beginOffset, [NativeTypeName("FLOAT")] float constantCoefficient, [NativeTypeName("FLOAT")] float linearCoefficient, [NativeTypeName("FLOAT")] float quadraticCoefficient, [NativeTypeName("FLOAT")] float cubicCoefficient)
        {
            return ((delegate* unmanaged<IUIAnimationPrimitiveInterpolation*, uint, double, float, float, float, float, int>)(lpVtbl[3]))((IUIAnimationPrimitiveInterpolation*)Unsafe.AsPointer(ref this), dimension, beginOffset, constantCoefficient, linearCoefficient, quadraticCoefficient, cubicCoefficient);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int AddSinusoidal([NativeTypeName("UINT")] uint dimension, [NativeTypeName("UI_ANIMATION_SECONDS")] double beginOffset, [NativeTypeName("FLOAT")] float bias, [NativeTypeName("FLOAT")] float amplitude, [NativeTypeName("FLOAT")] float frequency, [NativeTypeName("FLOAT")] float phase)
        {
            return ((delegate* unmanaged<IUIAnimationPrimitiveInterpolation*, uint, double, float, float, float, float, int>)(lpVtbl[4]))((IUIAnimationPrimitiveInterpolation*)Unsafe.AsPointer(ref this), dimension, beginOffset, bias, amplitude, frequency, phase);
        }
    }
}
