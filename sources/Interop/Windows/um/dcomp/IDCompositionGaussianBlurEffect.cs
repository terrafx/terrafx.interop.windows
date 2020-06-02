// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("45D4D0B7-1BD4-454E-8894-2BFA68443033")]
    public unsafe partial struct IDCompositionGaussianBlurEffect
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return lpVtbl->SetInput((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStandardDeviation(float amount)
        {
            return lpVtbl->SetStandardDeviation((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this), amount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStandardDeviation([NativeTypeName("IDCompositionAnimation *")] IDCompositionAnimation* animation)
        {
            return lpVtbl->SetStandardDeviation1((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderMode(D2D1_BORDER_MODE mode)
        {
            return lpVtbl->SetBorderMode((IDCompositionGaussianBlurEffect*)Unsafe.AsPointer(ref this), mode);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionGaussianBlurEffect*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionGaussianBlurEffect*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionGaussianBlurEffect*, uint> Release;

            [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionGaussianBlurEffect*, uint, IUnknown*, uint, int> SetInput;

            [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionGaussianBlurEffect*, float, int> SetStandardDeviation;

            [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionGaussianBlurEffect*, IDCompositionAnimation*, int> SetStandardDeviation1;

            [NativeTypeName("HRESULT (D2D1_BORDER_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionGaussianBlurEffect*, D2D1_BORDER_MODE, int> SetBorderMode;
        }
    }
}
