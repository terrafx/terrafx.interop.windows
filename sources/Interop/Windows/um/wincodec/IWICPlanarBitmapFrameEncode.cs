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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICPlanarBitmapFrameEncode*, Guid*, void**, int>)(lpVtbl[0]))((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICPlanarBitmapFrameEncode*, uint>)(lpVtbl[1]))((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICPlanarBitmapFrameEncode*, uint>)(lpVtbl[2]))((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WritePixels([NativeTypeName("UINT")] uint lineCount, [NativeTypeName("WICBitmapPlane *")] WICBitmapPlane* pPlanes, [NativeTypeName("UINT")] uint cPlanes)
        {
            return ((delegate* stdcall<IWICPlanarBitmapFrameEncode*, uint, WICBitmapPlane*, uint, int>)(lpVtbl[3]))((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this), lineCount, pPlanes, cPlanes);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteSource([NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** ppPlanes, [NativeTypeName("UINT")] uint cPlanes, [NativeTypeName("WICRect *")] WICRect* prcSource)
        {
            return ((delegate* stdcall<IWICPlanarBitmapFrameEncode*, IWICBitmapSource**, uint, WICRect*, int>)(lpVtbl[4]))((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this), ppPlanes, cPlanes, prcSource);
        }
    }
}
