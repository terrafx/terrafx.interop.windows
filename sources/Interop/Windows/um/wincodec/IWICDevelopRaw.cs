// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FBEC5E44-F7BE-4B65-B7F8-C0C81FEF026D")]
    [NativeTypeName("struct IWICDevelopRaw : IWICBitmapFrameDecode")]
    public unsafe partial struct IWICDevelopRaw
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, Guid*, void**, int>)(lpVtbl[0]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, uint>)(lpVtbl[1]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, uint>)(lpVtbl[2]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, uint*, uint*, int>)(lpVtbl[3]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, Guid*, int>)(lpVtbl[4]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResolution([NativeTypeName("double *")] double* pDpiX, [NativeTypeName("double *")] double* pDpiY)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double*, double*, int>)(lpVtbl[5]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, IWICPalette*, int>)(lpVtbl[6]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, WICRect*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryReader([NativeTypeName("IWICMetadataQueryReader **")] IWICMetadataQueryReader** ppIMetadataQueryReader)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, IWICMetadataQueryReader**, int>)(lpVtbl[8]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorContexts([NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContexts, [NativeTypeName("UINT *")] uint* pcActualCount)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, uint, IWICColorContext**, uint*, int>)(lpVtbl[9]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetThumbnail([NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** ppIThumbnail)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, IWICBitmapSource**, int>)(lpVtbl[10]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppIThumbnail);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryRawCapabilitiesInfo([NativeTypeName("WICRawCapabilitiesInfo *")] WICRawCapabilitiesInfo* pInfo)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, WICRawCapabilitiesInfo*, int>)(lpVtbl[11]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadParameterSet(WICRawParameterSet ParameterSet)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, WICRawParameterSet, int>)(lpVtbl[12]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ParameterSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentParameterSet([NativeTypeName("IPropertyBag2 **")] IPropertyBag2** ppCurrentParameterSet)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, IPropertyBag2**, int>)(lpVtbl[13]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppCurrentParameterSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetExposureCompensation(double ev)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double, int>)(lpVtbl[14]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetExposureCompensation([NativeTypeName("double *")] double* pEV)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double*, int>)(lpVtbl[15]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pEV);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointRGB([NativeTypeName("UINT")] uint Red, [NativeTypeName("UINT")] uint Green, [NativeTypeName("UINT")] uint Blue)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, uint, uint, uint, int>)(lpVtbl[16]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Red, Green, Blue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWhitePointRGB([NativeTypeName("UINT *")] uint* pRed, [NativeTypeName("UINT *")] uint* pGreen, [NativeTypeName("UINT *")] uint* pBlue)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, uint*, uint*, uint*, int>)(lpVtbl[17]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRed, pGreen, pBlue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNamedWhitePoint(WICNamedWhitePoint WhitePoint)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, WICNamedWhitePoint, int>)(lpVtbl[18]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), WhitePoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNamedWhitePoint([NativeTypeName("WICNamedWhitePoint *")] WICNamedWhitePoint* pWhitePoint)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, WICNamedWhitePoint*, int>)(lpVtbl[19]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pWhitePoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointKelvin([NativeTypeName("UINT")] uint WhitePointKelvin)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, uint, int>)(lpVtbl[20]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), WhitePointKelvin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWhitePointKelvin([NativeTypeName("UINT *")] uint* pWhitePointKelvin)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, uint*, int>)(lpVtbl[21]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pWhitePointKelvin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetKelvinRangeInfo([NativeTypeName("UINT *")] uint* pMinKelvinTemp, [NativeTypeName("UINT *")] uint* pMaxKelvinTemp, [NativeTypeName("UINT *")] uint* pKelvinTempStepValue)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, uint*, uint*, uint*, int>)(lpVtbl[22]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pMinKelvinTemp, pMaxKelvinTemp, pKelvinTempStepValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetContrast(double Contrast)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double, int>)(lpVtbl[23]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Contrast);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContrast([NativeTypeName("double *")] double* pContrast)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double*, int>)(lpVtbl[24]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pContrast);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGamma(double Gamma)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double, int>)(lpVtbl[25]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Gamma);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGamma([NativeTypeName("double *")] double* pGamma)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double*, int>)(lpVtbl[26]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pGamma);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSharpness(double Sharpness)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double, int>)(lpVtbl[27]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Sharpness);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSharpness([NativeTypeName("double *")] double* pSharpness)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double*, int>)(lpVtbl[28]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pSharpness);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSaturation(double Saturation)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double, int>)(lpVtbl[29]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Saturation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSaturation([NativeTypeName("double *")] double* pSaturation)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double*, int>)(lpVtbl[30]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pSaturation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTint(double Tint)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double, int>)(lpVtbl[31]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Tint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTint([NativeTypeName("double *")] double* pTint)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double*, int>)(lpVtbl[32]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pTint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNoiseReduction(double NoiseReduction)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double, int>)(lpVtbl[33]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), NoiseReduction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNoiseReduction([NativeTypeName("double *")] double* pNoiseReduction)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double*, int>)(lpVtbl[34]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pNoiseReduction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDestinationColorContext([NativeTypeName("IWICColorContext *")] IWICColorContext* pColorContext)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, IWICColorContext*, int>)(lpVtbl[35]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pColorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetToneCurve([NativeTypeName("UINT")] uint cbToneCurveSize, [NativeTypeName("const WICRawToneCurve *")] WICRawToneCurve* pToneCurve)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, uint, WICRawToneCurve*, int>)(lpVtbl[36]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cbToneCurveSize, pToneCurve);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetToneCurve([NativeTypeName("UINT")] uint cbToneCurveBufferSize, [NativeTypeName("WICRawToneCurve *")] WICRawToneCurve* pToneCurve, [NativeTypeName("UINT *")] uint* pcbActualToneCurveBufferSize)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, uint, WICRawToneCurve*, uint*, int>)(lpVtbl[37]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cbToneCurveBufferSize, pToneCurve, pcbActualToneCurveBufferSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRotation(double Rotation)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double, int>)(lpVtbl[38]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Rotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRotation([NativeTypeName("double *")] double* pRotation)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, double*, int>)(lpVtbl[39]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRenderMode(WICRawRenderMode RenderMode)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, WICRawRenderMode, int>)(lpVtbl[40]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), RenderMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRenderMode([NativeTypeName("WICRawRenderMode *")] WICRawRenderMode* pRenderMode)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, WICRawRenderMode*, int>)(lpVtbl[41]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRenderMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotificationCallback([NativeTypeName("IWICDevelopRawNotificationCallback *")] IWICDevelopRawNotificationCallback* pCallback)
        {
            return ((delegate* unmanaged<IWICDevelopRaw*, IWICDevelopRawNotificationCallback*, int>)(lpVtbl[42]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pCallback);
        }
    }
}
