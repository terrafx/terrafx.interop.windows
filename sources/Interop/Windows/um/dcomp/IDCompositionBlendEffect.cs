// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("33ECDC0A-578A-4A11-9C14-0CB90517F9C5")]
    [NativeTypeName("struct IDCompositionBlendEffect : IDCompositionFilterEffect")]
    [NativeInheritance("IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionBlendEffect
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionBlendEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionBlendEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionBlendEffect*, uint>)(lpVtbl[1]))((IDCompositionBlendEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionBlendEffect*, uint>)(lpVtbl[2]))((IDCompositionBlendEffect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* unmanaged<IDCompositionBlendEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionBlendEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetMode(D2D1_BLEND_MODE mode)
        {
            return ((delegate* unmanaged<IDCompositionBlendEffect*, D2D1_BLEND_MODE, int>)(lpVtbl[4]))((IDCompositionBlendEffect*)Unsafe.AsPointer(ref this), mode);
        }
    }
}
