// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000302-A8F2-4877-BA0A-FD2B6645FB94")]
    [NativeTypeName("struct IWICBitmapScaler : IWICBitmapSource")]
    public unsafe partial struct IWICBitmapScaler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICBitmapScaler*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapScaler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICBitmapScaler*, uint>)(lpVtbl[1]))((IWICBitmapScaler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICBitmapScaler*, uint>)(lpVtbl[2]))((IWICBitmapScaler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return ((delegate* unmanaged<IWICBitmapScaler*, uint*, uint*, int>)(lpVtbl[3]))((IWICBitmapScaler*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return ((delegate* unmanaged<IWICBitmapScaler*, Guid*, int>)(lpVtbl[4]))((IWICBitmapScaler*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResolution(double* pDpiX, double* pDpiY)
        {
            return ((delegate* unmanaged<IWICBitmapScaler*, double*, double*, int>)(lpVtbl[5]))((IWICBitmapScaler*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette)
        {
            return ((delegate* unmanaged<IWICBitmapScaler*, IWICPalette*, int>)(lpVtbl[6]))((IWICBitmapScaler*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return ((delegate* unmanaged<IWICBitmapScaler*, WICRect*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICBitmapScaler*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(IWICBitmapSource* pISource, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, WICBitmapInterpolationMode mode)
        {
            return ((delegate* unmanaged<IWICBitmapScaler*, IWICBitmapSource*, uint, uint, WICBitmapInterpolationMode, int>)(lpVtbl[8]))((IWICBitmapScaler*)Unsafe.AsPointer(ref this), pISource, uiWidth, uiHeight, mode);
        }
    }
}
