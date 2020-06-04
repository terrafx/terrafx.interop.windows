// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6DB9F920-0770-4781-B0C6-381912F9D167")]
    public unsafe partial struct IDCompositionHueRotationEffect
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionHueRotationEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionHueRotationEffect*, uint>)(lpVtbl[1]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionHueRotationEffect*, uint>)(lpVtbl[2]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* stdcall<IDCompositionHueRotationEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngle(float amountDegrees)
        {
            return ((delegate* stdcall<IDCompositionHueRotationEffect*, float, int>)(lpVtbl[4]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this), amountDegrees);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngle([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionHueRotationEffect*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
