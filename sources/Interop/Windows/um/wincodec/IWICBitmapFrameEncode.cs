// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000105-A8F2-4877-BA0A-FD2B6645FB94")]
    [NativeTypeName("struct IWICBitmapFrameEncode : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICBitmapFrameEncode
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICBitmapFrameEncode*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICBitmapFrameEncode*, uint>)(lpVtbl[1]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICBitmapFrameEncode*, uint>)(lpVtbl[2]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(IPropertyBag2* pIEncoderOptions)
        {
            return ((delegate* unmanaged<IWICBitmapFrameEncode*, IPropertyBag2*, int>)(lpVtbl[3]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIEncoderOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetSize([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight)
        {
            return ((delegate* unmanaged<IWICBitmapFrameEncode*, uint, uint, int>)(lpVtbl[4]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), uiWidth, uiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetResolution(double dpiX, double dpiY)
        {
            return ((delegate* unmanaged<IWICBitmapFrameEncode*, double, double, int>)(lpVtbl[5]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return ((delegate* unmanaged<IWICBitmapFrameEncode*, Guid*, int>)(lpVtbl[6]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetColorContexts([NativeTypeName("UINT")] uint cCount, IWICColorContext** ppIColorContext)
        {
            return ((delegate* unmanaged<IWICBitmapFrameEncode*, uint, IWICColorContext**, int>)(lpVtbl[7]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), cCount, ppIColorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetPalette(IWICPalette* pIPalette)
        {
            return ((delegate* unmanaged<IWICBitmapFrameEncode*, IWICPalette*, int>)(lpVtbl[8]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int SetThumbnail(IWICBitmapSource* pIThumbnail)
        {
            return ((delegate* unmanaged<IWICBitmapFrameEncode*, IWICBitmapSource*, int>)(lpVtbl[9]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIThumbnail);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int WritePixels([NativeTypeName("UINT")] uint lineCount, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbPixels)
        {
            return ((delegate* unmanaged<IWICBitmapFrameEncode*, uint, uint, uint, byte*, int>)(lpVtbl[10]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), lineCount, cbStride, cbBufferSize, pbPixels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int WriteSource(IWICBitmapSource* pIBitmapSource, WICRect* prc)
        {
            return ((delegate* unmanaged<IWICBitmapFrameEncode*, IWICBitmapSource*, WICRect*, int>)(lpVtbl[11]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIBitmapSource, prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* unmanaged<IWICBitmapFrameEncode*, int>)(lpVtbl[12]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter)
        {
            return ((delegate* unmanaged<IWICBitmapFrameEncode*, IWICMetadataQueryWriter**, int>)(lpVtbl[13]))((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), ppIMetadataQueryWriter);
        }
    }
}
