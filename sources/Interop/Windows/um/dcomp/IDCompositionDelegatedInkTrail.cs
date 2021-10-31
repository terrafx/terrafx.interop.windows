// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C2448E9B-547D-4057-8CF5-8144EDE1C2DA")]
    [NativeTypeName("struct IDCompositionDelegatedInkTrail : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDCompositionDelegatedInkTrail
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionDelegatedInkTrail*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionDelegatedInkTrail*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionDelegatedInkTrail*, uint>)(lpVtbl[1]))((IDCompositionDelegatedInkTrail*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionDelegatedInkTrail*, uint>)(lpVtbl[2]))((IDCompositionDelegatedInkTrail*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddTrailPoints([NativeTypeName("const DCompositionInkTrailPoint *")] DCompositionInkTrailPoint* inkPoints, [NativeTypeName("UINT")] uint inkPointsCount, [NativeTypeName("UINT *")] uint* generationId)
        {
            return ((delegate* unmanaged<IDCompositionDelegatedInkTrail*, DCompositionInkTrailPoint*, uint, uint*, int>)(lpVtbl[3]))((IDCompositionDelegatedInkTrail*)Unsafe.AsPointer(ref this), inkPoints, inkPointsCount, generationId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AddTrailPointsWithPrediction([NativeTypeName("const DCompositionInkTrailPoint *")] DCompositionInkTrailPoint* inkPoints, [NativeTypeName("UINT")] uint inkPointsCount, [NativeTypeName("const DCompositionInkTrailPoint *")] DCompositionInkTrailPoint* predictedInkPoints, [NativeTypeName("UINT")] uint predictedInkPointsCount, [NativeTypeName("UINT *")] uint* generationId)
        {
            return ((delegate* unmanaged<IDCompositionDelegatedInkTrail*, DCompositionInkTrailPoint*, uint, DCompositionInkTrailPoint*, uint, uint*, int>)(lpVtbl[4]))((IDCompositionDelegatedInkTrail*)Unsafe.AsPointer(ref this), inkPoints, inkPointsCount, predictedInkPoints, predictedInkPointsCount, generationId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT RemoveTrailPoints([NativeTypeName("UINT")] uint generationId)
        {
            return ((delegate* unmanaged<IDCompositionDelegatedInkTrail*, uint, int>)(lpVtbl[5]))((IDCompositionDelegatedInkTrail*)Unsafe.AsPointer(ref this), generationId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT StartNewTrail([NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color)
        {
            return ((delegate* unmanaged<IDCompositionDelegatedInkTrail*, DXGI_RGBA*, int>)(lpVtbl[6]))((IDCompositionDelegatedInkTrail*)Unsafe.AsPointer(ref this), color);
        }
    }
}
