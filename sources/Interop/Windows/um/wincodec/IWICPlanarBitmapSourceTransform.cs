// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3AFF9CCE-BE95-4303-B927-E7D16FF4A613")]
    [NativeTypeName("struct IWICPlanarBitmapSourceTransform : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICPlanarBitmapSourceTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICPlanarBitmapSourceTransform*, Guid*, void**, int>)(lpVtbl[0]))((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICPlanarBitmapSourceTransform*, uint>)(lpVtbl[1]))((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICPlanarBitmapSourceTransform*, uint>)(lpVtbl[2]))((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT DoesSupportTransform(uint* puiWidth, uint* puiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [NativeTypeName("const WICPixelFormatGUID *")] Guid* pguidDstFormats, WICBitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, BOOL* pfIsSupported)
        {
            return ((delegate* unmanaged<IWICPlanarBitmapSourceTransform*, uint*, uint*, WICBitmapTransformOptions, WICPlanarOptions, Guid*, WICBitmapPlaneDescription*, uint, BOOL*, int>)(lpVtbl[3]))((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this), puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CopyPixels([NativeTypeName("const WICRect *")] WICRect* prcSource, uint uiWidth, uint uiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [NativeTypeName("const WICBitmapPlane *")] WICBitmapPlane* pDstPlanes, uint cPlanes)
        {
            return ((delegate* unmanaged<IWICPlanarBitmapSourceTransform*, WICRect*, uint, uint, WICBitmapTransformOptions, WICPlanarOptions, WICBitmapPlane*, uint, int>)(lpVtbl[4]))((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this), prcSource, uiWidth, uiHeight, dstTransform, dstPlanarOptions, pDstPlanes, cPlanes);
        }
    }
}
