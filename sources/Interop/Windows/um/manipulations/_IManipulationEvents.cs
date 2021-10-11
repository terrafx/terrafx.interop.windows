// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4F62C8DA-9C53-4B22-93DF-927A862BBB03")]
    [NativeTypeName("struct _IManipulationEvents : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct _IManipulationEvents
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<_IManipulationEvents*, Guid*, void**, int>)(lpVtbl[0]))((_IManipulationEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<_IManipulationEvents*, uint>)(lpVtbl[1]))((_IManipulationEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<_IManipulationEvents*, uint>)(lpVtbl[2]))((_IManipulationEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int ManipulationStarted([NativeTypeName("FLOAT")] float x, [NativeTypeName("FLOAT")] float y)
        {
            return ((delegate* unmanaged<_IManipulationEvents*, float, float, int>)(lpVtbl[3]))((_IManipulationEvents*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ManipulationDelta([NativeTypeName("FLOAT")] float x, [NativeTypeName("FLOAT")] float y, [NativeTypeName("FLOAT")] float translationDeltaX, [NativeTypeName("FLOAT")] float translationDeltaY, [NativeTypeName("FLOAT")] float scaleDelta, [NativeTypeName("FLOAT")] float expansionDelta, [NativeTypeName("FLOAT")] float rotationDelta, [NativeTypeName("FLOAT")] float cumulativeTranslationX, [NativeTypeName("FLOAT")] float cumulativeTranslationY, [NativeTypeName("FLOAT")] float cumulativeScale, [NativeTypeName("FLOAT")] float cumulativeExpansion, [NativeTypeName("FLOAT")] float cumulativeRotation)
        {
            return ((delegate* unmanaged<_IManipulationEvents*, float, float, float, float, float, float, float, float, float, float, float, float, int>)(lpVtbl[4]))((_IManipulationEvents*)Unsafe.AsPointer(ref this), x, y, translationDeltaX, translationDeltaY, scaleDelta, expansionDelta, rotationDelta, cumulativeTranslationX, cumulativeTranslationY, cumulativeScale, cumulativeExpansion, cumulativeRotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int ManipulationCompleted([NativeTypeName("FLOAT")] float x, [NativeTypeName("FLOAT")] float y, [NativeTypeName("FLOAT")] float cumulativeTranslationX, [NativeTypeName("FLOAT")] float cumulativeTranslationY, [NativeTypeName("FLOAT")] float cumulativeScale, [NativeTypeName("FLOAT")] float cumulativeExpansion, [NativeTypeName("FLOAT")] float cumulativeRotation)
        {
            return ((delegate* unmanaged<_IManipulationEvents*, float, float, float, float, float, float, float, int>)(lpVtbl[5]))((_IManipulationEvents*)Unsafe.AsPointer(ref this), x, y, cumulativeTranslationX, cumulativeTranslationY, cumulativeScale, cumulativeExpansion, cumulativeRotation);
        }
    }
}
