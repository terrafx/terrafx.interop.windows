// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D8F5B23F-D429-4a91-B55A-D2F45FD75B18")]
    public unsafe partial struct IDCompositionRotateTransform3D
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, uint>)(lpVtbl[1]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, uint>)(lpVtbl[2]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngle(float angle)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[3]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), angle);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngle([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAxisX(float axisX)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[5]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), axisX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAxisX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAxisY(float axisY)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[7]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), axisY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAxisY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[8]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAxisZ(float axisZ)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[9]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), axisZ);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAxisZ([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[10]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterX(float centerX)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[11]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), centerX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[12]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterY(float centerY)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[13]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), centerY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[14]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterZ(float centerZ)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[15]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), centerZ);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterZ([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return ((delegate* stdcall<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[16]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
