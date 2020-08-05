// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("06791122-C6F0-417D-8323-269E987F5954")]
    [NativeTypeName("struct IDCompositionTranslateTransform : IDCompositionTransform")]
    public unsafe partial struct IDCompositionTranslateTransform
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionTranslateTransform*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionTranslateTransform*, uint>)(lpVtbl[1]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionTranslateTransform*, uint>)(lpVtbl[2]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX(float offsetX)
        {
            return ((delegate* stdcall<IDCompositionTranslateTransform*, float, int>)(lpVtbl[3]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), offsetX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionTranslateTransform*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY(float offsetY)
        {
            return ((delegate* stdcall<IDCompositionTranslateTransform*, float, int>)(lpVtbl[5]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), offsetY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionTranslateTransform*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
