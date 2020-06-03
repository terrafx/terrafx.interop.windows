// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E57AA735-DCDB-4c72-9C61-0591F58889EE")]
    public unsafe partial struct IDCompositionSkewTransform
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionSkewTransform*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionSkewTransform*, uint>)(lpVtbl[1]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionSkewTransform*, uint>)(lpVtbl[2]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngleX(float angleX)
        {
            return ((delegate* stdcall<IDCompositionSkewTransform*, float, int>)(lpVtbl[3]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), angleX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngleX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionSkewTransform*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngleY(float angleY)
        {
            return ((delegate* stdcall<IDCompositionSkewTransform*, float, int>)(lpVtbl[5]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), angleY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngleY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionSkewTransform*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterX(float centerX)
        {
            return ((delegate* stdcall<IDCompositionSkewTransform*, float, int>)(lpVtbl[7]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), centerX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionSkewTransform*, IDCompositionAnimation*, int>)(lpVtbl[8]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterY(float centerY)
        {
            return ((delegate* stdcall<IDCompositionSkewTransform*, float, int>)(lpVtbl[9]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), centerY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionSkewTransform*, IDCompositionAnimation*, int>)(lpVtbl[10]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
