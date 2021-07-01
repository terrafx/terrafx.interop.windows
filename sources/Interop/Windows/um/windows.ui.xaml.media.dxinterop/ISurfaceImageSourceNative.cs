// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F2E9EDC1-D307-4525-9886-0FAFAA44163C")]
    [NativeTypeName("struct ISurfaceImageSourceNative : IUnknown")]
    public unsafe partial struct ISurfaceImageSourceNative
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNative*, Guid*, void**, int>)(lpVtbl[0]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNative*, uint>)(lpVtbl[1]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNative*, uint>)(lpVtbl[2]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDevice(IDXGIDevice* device)
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNative*, IDXGIDevice*, int>)(lpVtbl[3]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this), device);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginDraw(RECT updateRect, IDXGISurface** surface, POINT* offset)
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNative*, RECT, IDXGISurface**, POINT*, int>)(lpVtbl[4]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this), updateRect, surface, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndDraw()
        {
            return ((delegate* unmanaged<ISurfaceImageSourceNative*, int>)(lpVtbl[5]))((ISurfaceImageSourceNative*)Unsafe.AsPointer(ref this));
        }
    }
}
