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
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngleX(float angleX)
        {
            return lpVtbl->SetAngleX((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), angleX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngleX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetAngleX1((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngleY(float angleY)
        {
            return lpVtbl->SetAngleY((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), angleY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAngleY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetAngleY1((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterX(float centerX)
        {
            return lpVtbl->SetCenterX((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), centerX);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterX([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetCenterX1((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterY(float centerY)
        {
            return lpVtbl->SetCenterY((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), centerY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCenterY([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetCenterY1((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionSkewTransform*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionSkewTransform*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionSkewTransform*, uint> Release;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionSkewTransform*, float, int> SetAngleX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionSkewTransform*, IDCompositionAnimation*, int> SetAngleX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionSkewTransform*, float, int> SetAngleY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionSkewTransform*, IDCompositionAnimation*, int> SetAngleY1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionSkewTransform*, float, int> SetCenterX;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionSkewTransform*, IDCompositionAnimation*, int> SetCenterX1;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionSkewTransform*, float, int> SetCenterY;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionSkewTransform*, IDCompositionAnimation*, int> SetCenterY1;
        }
    }
}
