// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5009834F-2D6A-41CE-9E1B-17C5AFF7A782")]
    [NativeTypeName("struct IWICBitmapFlipRotator : IWICBitmapSource")]
    [NativeInheritance("IWICBitmapSource")]
    public unsafe partial struct IWICBitmapFlipRotator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICBitmapFlipRotator*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICBitmapFlipRotator*, uint>)(lpVtbl[1]))((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICBitmapFlipRotator*, uint>)(lpVtbl[2]))((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return ((delegate* unmanaged<IWICBitmapFlipRotator*, uint*, uint*, int>)(lpVtbl[3]))((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return ((delegate* unmanaged<IWICBitmapFlipRotator*, Guid*, int>)(lpVtbl[4]))((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetResolution(double* pDpiX, double* pDpiY)
        {
            return ((delegate* unmanaged<IWICBitmapFlipRotator*, double*, double*, int>)(lpVtbl[5]))((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette)
        {
            return ((delegate* unmanaged<IWICBitmapFlipRotator*, IWICPalette*, int>)(lpVtbl[6]))((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return ((delegate* unmanaged<IWICBitmapFlipRotator*, WICRect*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(IWICBitmapSource* pISource, WICBitmapTransformOptions options)
        {
            return ((delegate* unmanaged<IWICBitmapFlipRotator*, IWICBitmapSource*, WICBitmapTransformOptions, int>)(lpVtbl[8]))((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this), pISource, options);
        }
    }
}
