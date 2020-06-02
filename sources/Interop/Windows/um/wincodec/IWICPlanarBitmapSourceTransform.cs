// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3AFF9CCE-BE95-4303-B927-E7D16FF4A613")]
    public unsafe partial struct IWICPlanarBitmapSourceTransform
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportTransform([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [NativeTypeName("const WICPixelFormatGUID *")] Guid* pguidDstFormats, [NativeTypeName("WICBitmapPlaneDescription *")] WICBitmapPlaneDescription* pPlaneDescriptions, [NativeTypeName("UINT")] uint cPlanes, [NativeTypeName("BOOL *")] int* pfIsSupported)
        {
            return lpVtbl->DoesSupportTransform((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this), puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupported);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prcSource, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [NativeTypeName("const WICBitmapPlane *")] WICBitmapPlane* pDstPlanes, [NativeTypeName("UINT")] uint cPlanes)
        {
            return lpVtbl->CopyPixels((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this), prcSource, uiWidth, uiHeight, dstTransform, dstPlanarOptions, pDstPlanes, cPlanes);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICPlanarBitmapSourceTransform*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICPlanarBitmapSourceTransform*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICPlanarBitmapSourceTransform*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *, WICBitmapTransformOptions, WICPlanarOptions, const WICPixelFormatGUID *, WICBitmapPlaneDescription *, UINT, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICPlanarBitmapSourceTransform*, uint*, uint*, WICBitmapTransformOptions, WICPlanarOptions, Guid*, WICBitmapPlaneDescription*, uint, int*, int> DoesSupportTransform;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, WICBitmapTransformOptions, WICPlanarOptions, const WICBitmapPlane *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IWICPlanarBitmapSourceTransform*, WICRect*, uint, uint, WICBitmapTransformOptions, WICPlanarOptions, WICBitmapPlane*, uint, int> CopyPixels;
        }
    }
}
