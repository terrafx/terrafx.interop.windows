// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A7929A74-E6B2-4BD6-8B95-4040119CA34D")]
    [NativeTypeName("struct IDCompositionEffectGroup : IDCompositionEffect")]
    [NativeInheritance("IDCompositionEffect")]
    public unsafe partial struct IDCompositionEffectGroup
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionEffectGroup*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionEffectGroup*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionEffectGroup*, uint>)(lpVtbl[1]))((IDCompositionEffectGroup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionEffectGroup*, uint>)(lpVtbl[2]))((IDCompositionEffectGroup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetOpacity(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionEffectGroup*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionEffectGroup*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetOpacity(float opacity)
        {
            return ((delegate* unmanaged<IDCompositionEffectGroup*, float, int>)(lpVtbl[4]))((IDCompositionEffectGroup*)Unsafe.AsPointer(ref this), opacity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetTransform3D(IDCompositionTransform3D* transform3D)
        {
            return ((delegate* unmanaged<IDCompositionEffectGroup*, IDCompositionTransform3D*, int>)(lpVtbl[5]))((IDCompositionEffectGroup*)Unsafe.AsPointer(ref this), transform3D);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionEffectGroup*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionEffectGroup*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionEffectGroup*, uint> Release;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionEffectGroup*, IDCompositionAnimation*, int> SetOpacity;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionEffectGroup*, float, int> SetOpacity1;

            [NativeTypeName("HRESULT (IDCompositionTransform3D *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionEffectGroup*, IDCompositionTransform3D*, int> SetTransform3D;
        }
    }
}
