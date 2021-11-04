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
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        public HRESULT ManipulationStarted(float x, float y)
        {
            return ((delegate* unmanaged<_IManipulationEvents*, float, float, int>)(lpVtbl[3]))((_IManipulationEvents*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ManipulationDelta(float x, float y, float translationDeltaX, float translationDeltaY, float scaleDelta, float expansionDelta, float rotationDelta, float cumulativeTranslationX, float cumulativeTranslationY, float cumulativeScale, float cumulativeExpansion, float cumulativeRotation)
        {
            return ((delegate* unmanaged<_IManipulationEvents*, float, float, float, float, float, float, float, float, float, float, float, float, int>)(lpVtbl[4]))((_IManipulationEvents*)Unsafe.AsPointer(ref this), x, y, translationDeltaX, translationDeltaY, scaleDelta, expansionDelta, rotationDelta, cumulativeTranslationX, cumulativeTranslationY, cumulativeScale, cumulativeExpansion, cumulativeRotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ManipulationCompleted(float x, float y, float cumulativeTranslationX, float cumulativeTranslationY, float cumulativeScale, float cumulativeExpansion, float cumulativeRotation)
        {
            return ((delegate* unmanaged<_IManipulationEvents*, float, float, float, float, float, float, float, int>)(lpVtbl[5]))((_IManipulationEvents*)Unsafe.AsPointer(ref this), x, y, cumulativeTranslationX, cumulativeTranslationY, cumulativeScale, cumulativeExpansion, cumulativeRotation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<_IManipulationEvents*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<_IManipulationEvents*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<_IManipulationEvents*, uint> Release;

            [NativeTypeName("HRESULT (FLOAT, FLOAT) __attribute__((stdcall))")]
            public delegate* unmanaged<_IManipulationEvents*, float, float, int> ManipulationStarted;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT) __attribute__((stdcall))")]
            public delegate* unmanaged<_IManipulationEvents*, float, float, float, float, float, float, float, float, float, float, float, float, int> ManipulationDelta;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT, FLOAT) __attribute__((stdcall))")]
            public delegate* unmanaged<_IManipulationEvents*, float, float, float, float, float, float, float, int> ManipulationCompleted;
        }
    }
}
