// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F928B7B8-2221-40C1-B72E-7E82F1974D1A")]
    public unsafe partial struct IWICPlanarBitmapFrameEncode
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WritePixels([NativeTypeName("UINT")] uint lineCount, [NativeTypeName("WICBitmapPlane *")] WICBitmapPlane* pPlanes, [NativeTypeName("UINT")] uint cPlanes)
        {
            return lpVtbl->WritePixels((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this), lineCount, pPlanes, cPlanes);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteSource([NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** ppPlanes, [NativeTypeName("UINT")] uint cPlanes, [NativeTypeName("WICRect *")] WICRect* prcSource)
        {
            return lpVtbl->WriteSource((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this), ppPlanes, cPlanes, prcSource);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICPlanarBitmapFrameEncode*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICPlanarBitmapFrameEncode*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICPlanarBitmapFrameEncode*, uint> Release;

            [NativeTypeName("HRESULT (UINT, WICBitmapPlane *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IWICPlanarBitmapFrameEncode*, uint, WICBitmapPlane*, uint, int> WritePixels;

            [NativeTypeName("HRESULT (IWICBitmapSource **, UINT, WICRect *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICPlanarBitmapFrameEncode*, IWICBitmapSource**, uint, WICRect*, int> WriteSource;
        }
    }
}
