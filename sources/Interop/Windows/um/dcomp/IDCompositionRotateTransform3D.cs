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
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngle(float angle)
        {
            return lpVtbl->SetAngle((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), angle);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngle([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetAngle1((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAxisX(float axisX)
        {
            return lpVtbl->SetAxisX((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), axisX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAxisX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetAxisX1((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAxisY(float axisY)
        {
            return lpVtbl->SetAxisY((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), axisY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAxisY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetAxisY1((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAxisZ(float axisZ)
        {
            return lpVtbl->SetAxisZ((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), axisZ);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAxisZ([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetAxisZ1((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterX(float centerX)
        {
            return lpVtbl->SetCenterX((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), centerX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetCenterX1((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterY(float centerY)
        {
            return lpVtbl->SetCenterY((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), centerY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetCenterY1((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterZ(float centerZ)
        {
            return lpVtbl->SetCenterZ((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), centerZ);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterZ([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetCenterZ1((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, uint> Release;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, float, int> SetAngle;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int> SetAngle1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, float, int> SetAxisX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int> SetAxisX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, float, int> SetAxisY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int> SetAxisY1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, float, int> SetAxisZ;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int> SetAxisZ1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, float, int> SetCenterX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int> SetCenterX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, float, int> SetCenterY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int> SetCenterY1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, float, int> SetCenterZ;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int> SetCenterZ1;
        }
    }
}
