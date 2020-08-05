// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("33ECDC0A-578A-4A11-9C14-0CB90517F9C5")]
    [NativeTypeName("struct IDCompositionBlendEffect : IDCompositionFilterEffect")]
    public unsafe partial struct IDCompositionBlendEffect
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionBlendEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionBlendEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionBlendEffect*, uint>)(lpVtbl[1]))((IDCompositionBlendEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionBlendEffect*, uint>)(lpVtbl[2]))((IDCompositionBlendEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* stdcall<IDCompositionBlendEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionBlendEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMode(D2D1_BLEND_MODE mode)
        {
            return ((delegate* stdcall<IDCompositionBlendEffect*, D2D1_BLEND_MODE, int>)(lpVtbl[4]))((IDCompositionBlendEffect*)Unsafe.AsPointer(ref this), mode);
        }
    }
}
