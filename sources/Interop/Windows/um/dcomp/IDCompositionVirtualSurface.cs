// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE471C51-5F53-4A24-8D3E-D0C39C30B3F0")]
    public unsafe partial struct IDCompositionVirtualSurface
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginDraw([NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** updateObject, [NativeTypeName("POINT *")] POINT* updateOffset)
        {
            return lpVtbl->BeginDraw((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, updateOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndDraw()
        {
            return lpVtbl->EndDraw((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SuspendDraw()
        {
            return lpVtbl->SuspendDraw((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ResumeDraw()
        {
            return lpVtbl->ResumeDraw((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Scroll([NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY)
        {
            return lpVtbl->Scroll((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), scrollRect, clipRect, offsetX, offsetY);
        }

        [return: NativeTypeName("HRESULT")]
        public int Resize([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height)
        {
            return lpVtbl->Resize((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), width, height);
        }

        [return: NativeTypeName("HRESULT")]
        public int Trim([NativeTypeName("const RECT *")] RECT* rectangles, [NativeTypeName("UINT")] uint count)
        {
            return lpVtbl->Trim((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), rectangles, count);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVirtualSurface*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVirtualSurface*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVirtualSurface*, uint> Release;

            [NativeTypeName("HRESULT (const RECT *, const IID &, void **, POINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVirtualSurface*, RECT*, Guid*, void**, POINT*, int> BeginDraw;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVirtualSurface*, int> EndDraw;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVirtualSurface*, int> SuspendDraw;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVirtualSurface*, int> ResumeDraw;

            [NativeTypeName("HRESULT (const RECT *, const RECT *, int, int) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVirtualSurface*, RECT*, RECT*, int, int, int> Scroll;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVirtualSurface*, uint, uint, int> Resize;

            [NativeTypeName("HRESULT (const RECT *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDCompositionVirtualSurface*, RECT*, uint, int> Trim;
        }
    }
}
