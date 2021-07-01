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
    public unsafe partial struct IDCompositionSaturationEffect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionSaturationEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionSaturationEffect*, uint>)(lpVtbl[1]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionSaturationEffect*, uint>)(lpVtbl[2]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* unmanaged<IDCompositionSaturationEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSaturation(float ratio)
        {
            return ((delegate* unmanaged<IDCompositionSaturationEffect*, float, int>)(lpVtbl[5]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this), ratio);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSaturation(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionSaturationEffect*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
