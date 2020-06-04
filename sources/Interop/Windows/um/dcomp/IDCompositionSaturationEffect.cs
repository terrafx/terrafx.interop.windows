// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A08DEBDA-3258-4FA4-9F16-9174D3FE93B1")]
    public unsafe partial struct IDCompositionSaturationEffect
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionSaturationEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionSaturationEffect*, uint>)(lpVtbl[1]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionSaturationEffect*, uint>)(lpVtbl[2]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* stdcall<IDCompositionSaturationEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSaturation(float ratio)
        {
            return ((delegate* stdcall<IDCompositionSaturationEffect*, float, int>)(lpVtbl[4]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this), ratio);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSaturation([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionSaturationEffect*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionSaturationEffect*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
