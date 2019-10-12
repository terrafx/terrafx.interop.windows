// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FBEC5E44-F7BE-4B65-B7F8-C0C81FEF026D")]
    public unsafe partial struct IWICDevelopRaw
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICDevelopRaw* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICDevelopRaw* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICDevelopRaw* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSize(IWICDevelopRaw* This, [NativeTypeName("UINT")] uint* puiWidth, [NativeTypeName("UINT")] uint* puiHeight);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPixelFormat(IWICDevelopRaw* This, [NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResolution(IWICDevelopRaw* This, double* pDpiX, double* pDpiY);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyPalette(IWICDevelopRaw* This, IWICPalette* pIPalette = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyPixels(IWICDevelopRaw* This, [Optional] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE[]")] byte* pbBuffer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataQueryReader(IWICDevelopRaw* This, IWICMetadataQueryReader** ppIMetadataQueryReader = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetColorContexts(IWICDevelopRaw* This, [NativeTypeName("UINT")] uint cCount, [Optional, NativeTypeName("IWICColorContext*[]")] IWICColorContext** ppIColorContexts, [NativeTypeName("UINT")] uint* pcActualCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetThumbnail(IWICDevelopRaw* This, IWICBitmapSource** ppIThumbnail = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryRawCapabilitiesInfo(IWICDevelopRaw* This, WICRawCapabilitiesInfo* pInfo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadParameterSet(IWICDevelopRaw* This, WICRawParameterSet ParameterSet);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentParameterSet(IWICDevelopRaw* This, IPropertyBag2** ppCurrentParameterSet = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetExposureCompensation(IWICDevelopRaw* This, double ev);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetExposureCompensation(IWICDevelopRaw* This, double* pEV);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetWhitePointRGB(IWICDevelopRaw* This, [NativeTypeName("UINT")] uint Red, [NativeTypeName("UINT")] uint Green, [NativeTypeName("UINT")] uint Blue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWhitePointRGB(IWICDevelopRaw* This, [NativeTypeName("UINT")] uint* pRed, [NativeTypeName("UINT")] uint* pGreen, [NativeTypeName("UINT")] uint* pBlue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetNamedWhitePoint(IWICDevelopRaw* This, WICNamedWhitePoint WhitePoint);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetNamedWhitePoint(IWICDevelopRaw* This, WICNamedWhitePoint* pWhitePoint);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetWhitePointKelvin(IWICDevelopRaw* This, [NativeTypeName("UINT")] uint WhitePointKelvin);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWhitePointKelvin(IWICDevelopRaw* This, [NativeTypeName("UINT")] uint* pWhitePointKelvin);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetKelvinRangeInfo(IWICDevelopRaw* This, [NativeTypeName("UINT")] uint* pMinKelvinTemp, [NativeTypeName("UINT")] uint* pMaxKelvinTemp, [NativeTypeName("UINT")] uint* pKelvinTempStepValue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetContrast(IWICDevelopRaw* This, double Contrast);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContrast(IWICDevelopRaw* This, double* pContrast);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGamma(IWICDevelopRaw* This, double Gamma);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGamma(IWICDevelopRaw* This, double* pGamma);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSharpness(IWICDevelopRaw* This, double Sharpness);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSharpness(IWICDevelopRaw* This, double* pSharpness);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSaturation(IWICDevelopRaw* This, double Saturation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSaturation(IWICDevelopRaw* This, double* pSaturation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTint(IWICDevelopRaw* This, double Tint);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTint(IWICDevelopRaw* This, double* pTint);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetNoiseReduction(IWICDevelopRaw* This, double NoiseReduction);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetNoiseReduction(IWICDevelopRaw* This, double* pNoiseReduction);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDestinationColorContext(IWICDevelopRaw* This, IWICColorContext* pColorContext = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetToneCurve(IWICDevelopRaw* This, [NativeTypeName("UINT")] uint cbToneCurveSize, [NativeTypeName("WICRawToneCurve[]")] WICRawToneCurve* pToneCurve);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetToneCurve(IWICDevelopRaw* This, [NativeTypeName("UINT")] uint cbToneCurveBufferSize, [NativeTypeName("WICRawToneCurve[]")] WICRawToneCurve* pToneCurve = null, [NativeTypeName("UINT")] uint* pcbActualToneCurveBufferSize = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRotation(IWICDevelopRaw* This, double Rotation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRotation(IWICDevelopRaw* This, double* pRotation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRenderMode(IWICDevelopRaw* This, WICRawRenderMode RenderMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRenderMode(IWICDevelopRaw* This, WICRawRenderMode* pRenderMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetNotificationCallback(IWICDevelopRaw* This, IWICDevelopRawNotificationCallback* pCallback = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT")] uint* puiWidth, [NativeTypeName("UINT")] uint* puiHeight)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)(This, puiWidth, puiHeight);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPixelFormat>(lpVtbl->GetPixelFormat)(This, pPixelFormat);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResolution(double* pDpiX, double* pDpiY)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetResolution>(lpVtbl->GetResolution)(This, pDpiX, pDpiY);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette = null)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyPalette>(lpVtbl->CopyPalette)(This, pIPalette);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([Optional] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE[]")] byte* pbBuffer)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyPixels>(lpVtbl->CopyPixels)(This, prc, cbStride, cbBufferSize, pbBuffer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader = null)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetadataQueryReader>(lpVtbl->GetMetadataQueryReader)(This, ppIMetadataQueryReader);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorContexts([NativeTypeName("UINT")] uint cCount, [Optional, NativeTypeName("IWICColorContext*[]")] IWICColorContext** ppIColorContexts, [NativeTypeName("UINT")] uint* pcActualCount)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorContexts>(lpVtbl->GetColorContexts)(This, cCount, ppIColorContexts, pcActualCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetThumbnail(IWICBitmapSource** ppIThumbnail = null)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetThumbnail>(lpVtbl->GetThumbnail)(This, ppIThumbnail);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryRawCapabilitiesInfo(WICRawCapabilitiesInfo* pInfo)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryRawCapabilitiesInfo>(lpVtbl->QueryRawCapabilitiesInfo)(This, pInfo);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadParameterSet(WICRawParameterSet ParameterSet)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_LoadParameterSet>(lpVtbl->LoadParameterSet)(This, ParameterSet);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentParameterSet(IPropertyBag2** ppCurrentParameterSet = null)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCurrentParameterSet>(lpVtbl->GetCurrentParameterSet)(This, ppCurrentParameterSet);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetExposureCompensation(double ev)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetExposureCompensation>(lpVtbl->SetExposureCompensation)(This, ev);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExposureCompensation(double* pEV)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetExposureCompensation>(lpVtbl->GetExposureCompensation)(This, pEV);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointRGB([NativeTypeName("UINT")] uint Red, [NativeTypeName("UINT")] uint Green, [NativeTypeName("UINT")] uint Blue)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetWhitePointRGB>(lpVtbl->SetWhitePointRGB)(This, Red, Green, Blue);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWhitePointRGB([NativeTypeName("UINT")] uint* pRed, [NativeTypeName("UINT")] uint* pGreen, [NativeTypeName("UINT")] uint* pBlue)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetWhitePointRGB>(lpVtbl->GetWhitePointRGB)(This, pRed, pGreen, pBlue);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNamedWhitePoint(WICNamedWhitePoint WhitePoint)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetNamedWhitePoint>(lpVtbl->SetNamedWhitePoint)(This, WhitePoint);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNamedWhitePoint(WICNamedWhitePoint* pWhitePoint)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNamedWhitePoint>(lpVtbl->GetNamedWhitePoint)(This, pWhitePoint);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointKelvin([NativeTypeName("UINT")] uint WhitePointKelvin)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetWhitePointKelvin>(lpVtbl->SetWhitePointKelvin)(This, WhitePointKelvin);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWhitePointKelvin([NativeTypeName("UINT")] uint* pWhitePointKelvin)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetWhitePointKelvin>(lpVtbl->GetWhitePointKelvin)(This, pWhitePointKelvin);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetKelvinRangeInfo([NativeTypeName("UINT")] uint* pMinKelvinTemp, [NativeTypeName("UINT")] uint* pMaxKelvinTemp, [NativeTypeName("UINT")] uint* pKelvinTempStepValue)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetKelvinRangeInfo>(lpVtbl->GetKelvinRangeInfo)(This, pMinKelvinTemp, pMaxKelvinTemp, pKelvinTempStepValue);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetContrast(double Contrast)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetContrast>(lpVtbl->SetContrast)(This, Contrast);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContrast(double* pContrast)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContrast>(lpVtbl->GetContrast)(This, pContrast);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGamma(double Gamma)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetGamma>(lpVtbl->SetGamma)(This, Gamma);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGamma(double* pGamma)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGamma>(lpVtbl->GetGamma)(This, pGamma);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSharpness(double Sharpness)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetSharpness>(lpVtbl->SetSharpness)(This, Sharpness);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSharpness(double* pSharpness)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSharpness>(lpVtbl->GetSharpness)(This, pSharpness);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSaturation(double Saturation)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetSaturation>(lpVtbl->SetSaturation)(This, Saturation);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSaturation(double* pSaturation)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSaturation>(lpVtbl->GetSaturation)(This, pSaturation);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTint(double Tint)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetTint>(lpVtbl->SetTint)(This, Tint);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTint(double* pTint)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTint>(lpVtbl->GetTint)(This, pTint);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNoiseReduction(double NoiseReduction)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetNoiseReduction>(lpVtbl->SetNoiseReduction)(This, NoiseReduction);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNoiseReduction(double* pNoiseReduction)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNoiseReduction>(lpVtbl->GetNoiseReduction)(This, pNoiseReduction);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDestinationColorContext(IWICColorContext* pColorContext = null)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetDestinationColorContext>(lpVtbl->SetDestinationColorContext)(This, pColorContext);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetToneCurve([NativeTypeName("UINT")] uint cbToneCurveSize, [NativeTypeName("WICRawToneCurve[]")] WICRawToneCurve* pToneCurve)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetToneCurve>(lpVtbl->SetToneCurve)(This, cbToneCurveSize, pToneCurve);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetToneCurve([NativeTypeName("UINT")] uint cbToneCurveBufferSize, [NativeTypeName("WICRawToneCurve[]")] WICRawToneCurve* pToneCurve = null, [NativeTypeName("UINT")] uint* pcbActualToneCurveBufferSize = null)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetToneCurve>(lpVtbl->GetToneCurve)(This, cbToneCurveBufferSize, pToneCurve, pcbActualToneCurveBufferSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRotation(double Rotation)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetRotation>(lpVtbl->SetRotation)(This, Rotation);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRotation(double* pRotation)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRotation>(lpVtbl->GetRotation)(This, pRotation);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRenderMode(WICRawRenderMode RenderMode)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetRenderMode>(lpVtbl->SetRenderMode)(This, RenderMode);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRenderMode(WICRawRenderMode* pRenderMode)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRenderMode>(lpVtbl->GetRenderMode)(This, pRenderMode);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotificationCallback(IWICDevelopRawNotificationCallback* pCallback = null)
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetNotificationCallback>(lpVtbl->SetNotificationCallback)(This, pCallback);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetSize;

            public IntPtr GetPixelFormat;

            public IntPtr GetResolution;

            public IntPtr CopyPalette;

            public IntPtr CopyPixels;

            public IntPtr GetMetadataQueryReader;

            public IntPtr GetColorContexts;

            public IntPtr GetThumbnail;

            public IntPtr QueryRawCapabilitiesInfo;

            public IntPtr LoadParameterSet;

            public IntPtr GetCurrentParameterSet;

            public IntPtr SetExposureCompensation;

            public IntPtr GetExposureCompensation;

            public IntPtr SetWhitePointRGB;

            public IntPtr GetWhitePointRGB;

            public IntPtr SetNamedWhitePoint;

            public IntPtr GetNamedWhitePoint;

            public IntPtr SetWhitePointKelvin;

            public IntPtr GetWhitePointKelvin;

            public IntPtr GetKelvinRangeInfo;

            public IntPtr SetContrast;

            public IntPtr GetContrast;

            public IntPtr SetGamma;

            public IntPtr GetGamma;

            public IntPtr SetSharpness;

            public IntPtr GetSharpness;

            public IntPtr SetSaturation;

            public IntPtr GetSaturation;

            public IntPtr SetTint;

            public IntPtr GetTint;

            public IntPtr SetNoiseReduction;

            public IntPtr GetNoiseReduction;

            public IntPtr SetDestinationColorContext;

            public IntPtr SetToneCurve;

            public IntPtr GetToneCurve;

            public IntPtr SetRotation;

            public IntPtr GetRotation;

            public IntPtr SetRenderMode;

            public IntPtr GetRenderMode;

            public IntPtr SetNotificationCallback;
        }
    }
}
