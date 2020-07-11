// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F2E9EDC1-D307-4525-9886-0FAFAA44163C")]
    public unsafe partial struct ISurfaceImageSourceNative
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISurfaceImageSourceNative*, Guid*, void**, int>)(lpVtbl[0]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISurfaceImageSourceNative*, uint>)(lpVtbl[1]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISurfaceImageSourceNative*, uint>)(lpVtbl[2]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDevice([NativeTypeName("IDXGIDevice *")] IDXGIDevice* device)
        {
            return ((delegate* stdcall<ISurfaceImageSourceNative*, IDXGIDevice*, int>)(lpVtbl[3]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this), device);
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginDraw(RECT updateRect, [NativeTypeName("IDXGISurface **")] IDXGISurface** surface, [NativeTypeName("POINT *")] POINT* offset)
        {
            return ((delegate* stdcall<ISurfaceImageSourceNative*, RECT, IDXGISurface**, POINT*, int>)(lpVtbl[4]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this), updateRect, surface, offset);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndDraw()
        {
            return ((delegate* stdcall<ISurfaceImageSourceNative*, int>)(lpVtbl[5]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this));
        }
    }
}
