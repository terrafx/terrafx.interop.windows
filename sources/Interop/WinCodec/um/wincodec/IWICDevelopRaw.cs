// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FBEC5E44-F7BE-4B65-B7F8-C0C81FEF026D")]
    public unsafe partial struct IWICDevelopRaw
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICDevelopRaw* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICDevelopRaw* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICDevelopRaw* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSize(IWICDevelopRaw* pThis, [NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPixelFormat(IWICDevelopRaw* pThis, [NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResolution(IWICDevelopRaw* pThis, [NativeTypeName("double *")] double* pDpiX, [NativeTypeName("double *")] double* pDpiY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyPalette(IWICDevelopRaw* pThis, [NativeTypeName("IWICPalette *")] IWICPalette* pIPalette);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyPixels(IWICDevelopRaw* pThis, [NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataQueryReader(IWICDevelopRaw* pThis, [NativeTypeName("IWICMetadataQueryReader **")] IWICMetadataQueryReader** ppIMetadataQueryReader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetColorContexts(IWICDevelopRaw* pThis, [NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContexts, [NativeTypeName("UINT *")] uint* pcActualCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetThumbnail(IWICDevelopRaw* pThis, [NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** ppIThumbnail);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryRawCapabilitiesInfo(IWICDevelopRaw* pThis, [NativeTypeName("WICRawCapabilitiesInfo *")] WICRawCapabilitiesInfo* pInfo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadParameterSet(IWICDevelopRaw* pThis, WICRawParameterSet ParameterSet);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentParameterSet(IWICDevelopRaw* pThis, [NativeTypeName("IPropertyBag2 **")] IPropertyBag2** ppCurrentParameterSet);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetExposureCompensation(IWICDevelopRaw* pThis, double ev);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetExposureCompensation(IWICDevelopRaw* pThis, [NativeTypeName("double *")] double* pEV);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetWhitePointRGB(IWICDevelopRaw* pThis, [NativeTypeName("UINT")] uint Red, [NativeTypeName("UINT")] uint Green, [NativeTypeName("UINT")] uint Blue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWhitePointRGB(IWICDevelopRaw* pThis, [NativeTypeName("UINT *")] uint* pRed, [NativeTypeName("UINT *")] uint* pGreen, [NativeTypeName("UINT *")] uint* pBlue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetNamedWhitePoint(IWICDevelopRaw* pThis, WICNamedWhitePoint WhitePoint);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetNamedWhitePoint(IWICDevelopRaw* pThis, [NativeTypeName("WICNamedWhitePoint *")] WICNamedWhitePoint* pWhitePoint);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetWhitePointKelvin(IWICDevelopRaw* pThis, [NativeTypeName("UINT")] uint WhitePointKelvin);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWhitePointKelvin(IWICDevelopRaw* pThis, [NativeTypeName("UINT *")] uint* pWhitePointKelvin);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetKelvinRangeInfo(IWICDevelopRaw* pThis, [NativeTypeName("UINT *")] uint* pMinKelvinTemp, [NativeTypeName("UINT *")] uint* pMaxKelvinTemp, [NativeTypeName("UINT *")] uint* pKelvinTempStepValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetContrast(IWICDevelopRaw* pThis, double Contrast);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContrast(IWICDevelopRaw* pThis, [NativeTypeName("double *")] double* pContrast);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGamma(IWICDevelopRaw* pThis, double Gamma);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGamma(IWICDevelopRaw* pThis, [NativeTypeName("double *")] double* pGamma);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSharpness(IWICDevelopRaw* pThis, double Sharpness);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSharpness(IWICDevelopRaw* pThis, [NativeTypeName("double *")] double* pSharpness);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSaturation(IWICDevelopRaw* pThis, double Saturation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSaturation(IWICDevelopRaw* pThis, [NativeTypeName("double *")] double* pSaturation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTint(IWICDevelopRaw* pThis, double Tint);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTint(IWICDevelopRaw* pThis, [NativeTypeName("double *")] double* pTint);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetNoiseReduction(IWICDevelopRaw* pThis, double NoiseReduction);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetNoiseReduction(IWICDevelopRaw* pThis, [NativeTypeName("double *")] double* pNoiseReduction);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDestinationColorContext(IWICDevelopRaw* pThis, [NativeTypeName("IWICColorContext *")] IWICColorContext* pColorContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetToneCurve(IWICDevelopRaw* pThis, [NativeTypeName("UINT")] uint cbToneCurveSize, [NativeTypeName("const WICRawToneCurve *")] WICRawToneCurve* pToneCurve);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetToneCurve(IWICDevelopRaw* pThis, [NativeTypeName("UINT")] uint cbToneCurveBufferSize, [NativeTypeName("WICRawToneCurve *")] WICRawToneCurve* pToneCurve, [NativeTypeName("UINT *")] uint* pcbActualToneCurveBufferSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRotation(IWICDevelopRaw* pThis, double Rotation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRotation(IWICDevelopRaw* pThis, [NativeTypeName("double *")] double* pRotation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRenderMode(IWICDevelopRaw* pThis, WICRawRenderMode RenderMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRenderMode(IWICDevelopRaw* pThis, [NativeTypeName("WICRawRenderMode *")] WICRawRenderMode* pRenderMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetNotificationCallback(IWICDevelopRaw* pThis, [NativeTypeName("IWICDevelopRawNotificationCallback *")] IWICDevelopRawNotificationCallback* pCallback);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICDevelopRaw*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICDevelopRaw*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPixelFormat>(lpVtbl->GetPixelFormat)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResolution([NativeTypeName("double *")] double* pDpiX, [NativeTypeName("double *")] double* pDpiY)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetResolution>(lpVtbl->GetResolution)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyPalette>(lpVtbl->CopyPalette)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyPixels>(lpVtbl->CopyPixels)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryReader([NativeTypeName("IWICMetadataQueryReader **")] IWICMetadataQueryReader** ppIMetadataQueryReader)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMetadataQueryReader>(lpVtbl->GetMetadataQueryReader)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorContexts([NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContexts, [NativeTypeName("UINT *")] uint* pcActualCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetColorContexts>(lpVtbl->GetColorContexts)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetThumbnail([NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** ppIThumbnail)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetThumbnail>(lpVtbl->GetThumbnail)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppIThumbnail);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryRawCapabilitiesInfo([NativeTypeName("WICRawCapabilitiesInfo *")] WICRawCapabilitiesInfo* pInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryRawCapabilitiesInfo>(lpVtbl->QueryRawCapabilitiesInfo)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadParameterSet(WICRawParameterSet ParameterSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_LoadParameterSet>(lpVtbl->LoadParameterSet)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ParameterSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentParameterSet([NativeTypeName("IPropertyBag2 **")] IPropertyBag2** ppCurrentParameterSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCurrentParameterSet>(lpVtbl->GetCurrentParameterSet)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppCurrentParameterSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetExposureCompensation(double ev)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetExposureCompensation>(lpVtbl->SetExposureCompensation)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ev);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExposureCompensation([NativeTypeName("double *")] double* pEV)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetExposureCompensation>(lpVtbl->GetExposureCompensation)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pEV);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointRGB([NativeTypeName("UINT")] uint Red, [NativeTypeName("UINT")] uint Green, [NativeTypeName("UINT")] uint Blue)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetWhitePointRGB>(lpVtbl->SetWhitePointRGB)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Red, Green, Blue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWhitePointRGB([NativeTypeName("UINT *")] uint* pRed, [NativeTypeName("UINT *")] uint* pGreen, [NativeTypeName("UINT *")] uint* pBlue)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWhitePointRGB>(lpVtbl->GetWhitePointRGB)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRed, pGreen, pBlue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNamedWhitePoint(WICNamedWhitePoint WhitePoint)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetNamedWhitePoint>(lpVtbl->SetNamedWhitePoint)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), WhitePoint);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNamedWhitePoint([NativeTypeName("WICNamedWhitePoint *")] WICNamedWhitePoint* pWhitePoint)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNamedWhitePoint>(lpVtbl->GetNamedWhitePoint)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pWhitePoint);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointKelvin([NativeTypeName("UINT")] uint WhitePointKelvin)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetWhitePointKelvin>(lpVtbl->SetWhitePointKelvin)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), WhitePointKelvin);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWhitePointKelvin([NativeTypeName("UINT *")] uint* pWhitePointKelvin)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWhitePointKelvin>(lpVtbl->GetWhitePointKelvin)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pWhitePointKelvin);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetKelvinRangeInfo([NativeTypeName("UINT *")] uint* pMinKelvinTemp, [NativeTypeName("UINT *")] uint* pMaxKelvinTemp, [NativeTypeName("UINT *")] uint* pKelvinTempStepValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetKelvinRangeInfo>(lpVtbl->GetKelvinRangeInfo)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pMinKelvinTemp, pMaxKelvinTemp, pKelvinTempStepValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetContrast(double Contrast)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetContrast>(lpVtbl->SetContrast)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Contrast);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContrast([NativeTypeName("double *")] double* pContrast)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetContrast>(lpVtbl->GetContrast)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pContrast);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGamma(double Gamma)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGamma>(lpVtbl->SetGamma)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Gamma);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGamma([NativeTypeName("double *")] double* pGamma)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGamma>(lpVtbl->GetGamma)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pGamma);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSharpness(double Sharpness)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSharpness>(lpVtbl->SetSharpness)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Sharpness);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSharpness([NativeTypeName("double *")] double* pSharpness)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSharpness>(lpVtbl->GetSharpness)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pSharpness);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSaturation(double Saturation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSaturation>(lpVtbl->SetSaturation)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Saturation);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSaturation([NativeTypeName("double *")] double* pSaturation)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSaturation>(lpVtbl->GetSaturation)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pSaturation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTint(double Tint)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTint>(lpVtbl->SetTint)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Tint);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTint([NativeTypeName("double *")] double* pTint)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTint>(lpVtbl->GetTint)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pTint);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNoiseReduction(double NoiseReduction)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetNoiseReduction>(lpVtbl->SetNoiseReduction)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), NoiseReduction);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNoiseReduction([NativeTypeName("double *")] double* pNoiseReduction)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNoiseReduction>(lpVtbl->GetNoiseReduction)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pNoiseReduction);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDestinationColorContext([NativeTypeName("IWICColorContext *")] IWICColorContext* pColorContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetDestinationColorContext>(lpVtbl->SetDestinationColorContext)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pColorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetToneCurve([NativeTypeName("UINT")] uint cbToneCurveSize, [NativeTypeName("const WICRawToneCurve *")] WICRawToneCurve* pToneCurve)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetToneCurve>(lpVtbl->SetToneCurve)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cbToneCurveSize, pToneCurve);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetToneCurve([NativeTypeName("UINT")] uint cbToneCurveBufferSize, [NativeTypeName("WICRawToneCurve *")] WICRawToneCurve* pToneCurve, [NativeTypeName("UINT *")] uint* pcbActualToneCurveBufferSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetToneCurve>(lpVtbl->GetToneCurve)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cbToneCurveBufferSize, pToneCurve, pcbActualToneCurveBufferSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRotation(double Rotation)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRotation>(lpVtbl->SetRotation)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Rotation);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRotation([NativeTypeName("double *")] double* pRotation)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRotation>(lpVtbl->GetRotation)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRotation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRenderMode(WICRawRenderMode RenderMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRenderMode>(lpVtbl->SetRenderMode)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), RenderMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRenderMode([NativeTypeName("WICRawRenderMode *")] WICRawRenderMode* pRenderMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRenderMode>(lpVtbl->GetRenderMode)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRenderMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotificationCallback([NativeTypeName("IWICDevelopRawNotificationCallback *")] IWICDevelopRawNotificationCallback* pCallback)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetNotificationCallback>(lpVtbl->SetNotificationCallback)((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pCallback);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public IntPtr GetPixelFormat;

            [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
            public IntPtr GetResolution;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public IntPtr CopyPalette;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public IntPtr CopyPixels;

            [NativeTypeName("HRESULT (IWICMetadataQueryReader **) __attribute__((stdcall))")]
            public IntPtr GetMetadataQueryReader;

            [NativeTypeName("HRESULT (UINT, IWICColorContext **, UINT *) __attribute__((stdcall))")]
            public IntPtr GetColorContexts;

            [NativeTypeName("HRESULT (IWICBitmapSource **) __attribute__((stdcall))")]
            public IntPtr GetThumbnail;

            [NativeTypeName("HRESULT (WICRawCapabilitiesInfo *) __attribute__((stdcall))")]
            public IntPtr QueryRawCapabilitiesInfo;

            [NativeTypeName("HRESULT (WICRawParameterSet) __attribute__((stdcall))")]
            public IntPtr LoadParameterSet;

            [NativeTypeName("HRESULT (IPropertyBag2 **) __attribute__((stdcall))")]
            public IntPtr GetCurrentParameterSet;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public IntPtr SetExposureCompensation;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public IntPtr GetExposureCompensation;

            [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((stdcall))")]
            public IntPtr SetWhitePointRGB;

            [NativeTypeName("HRESULT (UINT *, UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetWhitePointRGB;

            [NativeTypeName("HRESULT (WICNamedWhitePoint) __attribute__((stdcall))")]
            public IntPtr SetNamedWhitePoint;

            [NativeTypeName("HRESULT (WICNamedWhitePoint *) __attribute__((stdcall))")]
            public IntPtr GetNamedWhitePoint;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr SetWhitePointKelvin;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public IntPtr GetWhitePointKelvin;

            [NativeTypeName("HRESULT (UINT *, UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetKelvinRangeInfo;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public IntPtr SetContrast;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public IntPtr GetContrast;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public IntPtr SetGamma;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public IntPtr GetGamma;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public IntPtr SetSharpness;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public IntPtr GetSharpness;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public IntPtr SetSaturation;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public IntPtr GetSaturation;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public IntPtr SetTint;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public IntPtr GetTint;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public IntPtr SetNoiseReduction;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public IntPtr GetNoiseReduction;

            [NativeTypeName("HRESULT (IWICColorContext *) __attribute__((stdcall))")]
            public IntPtr SetDestinationColorContext;

            [NativeTypeName("HRESULT (UINT, const WICRawToneCurve *) __attribute__((stdcall))")]
            public IntPtr SetToneCurve;

            [NativeTypeName("HRESULT (UINT, WICRawToneCurve *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetToneCurve;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public IntPtr SetRotation;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public IntPtr GetRotation;

            [NativeTypeName("HRESULT (WICRawRenderMode) __attribute__((stdcall))")]
            public IntPtr SetRenderMode;

            [NativeTypeName("HRESULT (WICRawRenderMode *) __attribute__((stdcall))")]
            public IntPtr GetRenderMode;

            [NativeTypeName("HRESULT (IWICDevelopRawNotificationCallback *) __attribute__((stdcall))")]
            public IntPtr SetNotificationCallback;
        }
    }
}
