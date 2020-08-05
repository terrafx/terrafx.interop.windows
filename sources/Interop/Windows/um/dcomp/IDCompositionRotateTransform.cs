// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("641ED83C-AE96-46C5-90DC-32774CC5C6D5")]
    [NativeTypeName("struct IDCompositionRotateTransform : IDCompositionTransform")]
    public unsafe partial struct IDCompositionRotateTransform
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionRotateTransform*, uint>)(lpVtbl[1]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionRotateTransform*, uint>)(lpVtbl[2]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngle(float angle)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform*, float, int>)(lpVtbl[3]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), angle);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngle([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterX(float centerX)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform*, float, int>)(lpVtbl[5]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), centerX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterY(float centerY)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform*, float, int>)(lpVtbl[7]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), centerY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform*, IDCompositionAnimation*, int>)(lpVtbl[8]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
