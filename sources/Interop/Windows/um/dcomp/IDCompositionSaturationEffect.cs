// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A08DEBDA-3258-4FA4-9F16-9174D3FE93B1")]
    [NativeTypeName("struct IDCompositionSaturationEffect : IDCompositionFilterEffect")]
    [NativeInheritance("IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionSaturationEffect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionSaturationEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionSaturationEffect*, uint>)(lpVtbl[1]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionSaturationEffect*, uint>)(lpVtbl[2]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetInput(uint index, IUnknown* input, uint flags)
        {
            return ((delegate* unmanaged<IDCompositionSaturationEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetSaturation(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionSaturationEffect*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetSaturation(float ratio)
        {
            return ((delegate* unmanaged<IDCompositionSaturationEffect*, float, int>)(lpVtbl[5]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this), ratio);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSaturationEffect*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSaturationEffect*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSaturationEffect*, uint> Release;

            [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSaturationEffect*, uint, IUnknown*, uint, int> SetInput;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSaturationEffect*, IDCompositionAnimation*, int> SetSaturation;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionSaturationEffect*, float, int> SetSaturation1;
        }
    }
}
