// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("FBEC5E44-F7BE-4B65-B7F8-C0C81FEF026D")]
    public unsafe struct IWICDevelopRaw
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICDevelopRaw* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICDevelopRaw* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICDevelopRaw* This
        );
        #endregion

        #region IWICBitmapSource Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSize(
            [In] IWICDevelopRaw* This,
            [Out, NativeTypeName("UINT")] uint* puiWidth,
            [Out, NativeTypeName("UINT")] uint* puiHeight
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPixelFormat(
            [In] IWICDevelopRaw* This,
            [Out, NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetResolution(
            [In] IWICDevelopRaw* This,
            [Out] double* pDpiX,
            [Out] double* pDpiY
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CopyPalette(
            [In] IWICDevelopRaw* This,
            [In] IWICPalette* pIPalette = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CopyPixels(
            [In] IWICDevelopRaw* This,
            [In, Optional] WICRect* prc,
            [In, NativeTypeName("UINT")] uint cbStride,
            [In, NativeTypeName("UINT")] uint cbBufferSize,
            [Out, NativeTypeName("BYTE[]")] byte* pbBuffer
        );
        #endregion

        #region IWICBitmapFrameDecode Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMetadataQueryReader(
            [In] IWICDevelopRaw* This,
            [Out] IWICMetadataQueryReader** ppIMetadataQueryReader = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetColorContexts(
            [In] IWICDevelopRaw* This,
            [In, NativeTypeName("UINT")] uint cCount,
            [In, Out, Optional, NativeTypeName("IWICColorContext*[]")] IWICColorContext** ppIColorContexts,
            [Out, NativeTypeName("UINT")] uint* pcActualCount
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetThumbnail(
            [In] IWICDevelopRaw* This,
            [Out] IWICBitmapSource** ppIThumbnail = null
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryRawCapabilitiesInfo(
            [In] IWICDevelopRaw* This,
            [In, Out] WICRawCapabilitiesInfo* pInfo
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _LoadParameterSet(
            [In] IWICDevelopRaw* This,
            [In] WICRawParameterSet ParameterSet
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetCurrentParameterSet(
            [In] IWICDevelopRaw* This,
            [Out] IPropertyBag2** ppCurrentParameterSet = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetExposureCompensation(
            [In] IWICDevelopRaw* This,
            [In] double ev
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetExposureCompensation(
            [In] IWICDevelopRaw* This,
            [Out] double* pEV
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetWhitePointRGB(
            [In] IWICDevelopRaw* This,
            [In, NativeTypeName("UINT")] uint Red,
            [In, NativeTypeName("UINT")] uint Green,
            [In, NativeTypeName("UINT")] uint Blue
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetWhitePointRGB(
            [In] IWICDevelopRaw* This,
            [Out, NativeTypeName("UINT")] uint* pRed,
            [Out, NativeTypeName("UINT")] uint* pGreen,
            [Out, NativeTypeName("UINT")] uint* pBlue
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetNamedWhitePoint(
            [In] IWICDevelopRaw* This,
            [In] WICNamedWhitePoint WhitePoint
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetNamedWhitePoint(
            [In] IWICDevelopRaw* This,
            [Out] WICNamedWhitePoint* pWhitePoint
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetWhitePointKelvin(
            [In] IWICDevelopRaw* This,
            [In, NativeTypeName("UINT")] uint WhitePointKelvin
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetWhitePointKelvin(
            [In] IWICDevelopRaw* This,
            [Out, NativeTypeName("UINT")] uint* pWhitePointKelvin
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetKelvinRangeInfo(
            [In] IWICDevelopRaw* This,
            [Out, NativeTypeName("UINT")] uint* pMinKelvinTemp,
            [Out, NativeTypeName("UINT")] uint* pMaxKelvinTemp,
            [Out, NativeTypeName("UINT")] uint* pKelvinTempStepValue
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetContrast(
            [In] IWICDevelopRaw* This,
            [In] double Contrast
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetContrast(
            [In] IWICDevelopRaw* This,
            [Out] double* pContrast
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetGamma(
            [In] IWICDevelopRaw* This,
            [In] double Gamma
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetGamma(
            [In] IWICDevelopRaw* This,
            [Out] double* pGamma
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetSharpness(
            [In] IWICDevelopRaw* This,
            [In] double Sharpness
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSharpness(
            [In] IWICDevelopRaw* This,
            [Out] double* pSharpness
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetSaturation(
            [In] IWICDevelopRaw* This,
            [In] double Saturation
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSaturation(
            [In] IWICDevelopRaw* This,
            [Out] double* pSaturation
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetTint(
            [In] IWICDevelopRaw* This,
            [In] double Tint
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetTint(
            [In] IWICDevelopRaw* This,
            [Out] double* pTint
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetNoiseReduction(
            [In] IWICDevelopRaw* This,
            [In] double NoiseReduction
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetNoiseReduction(
            [In] IWICDevelopRaw* This,
            [Out] double* pNoiseReduction
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetDestinationColorContext(
            [In] IWICDevelopRaw* This,
            [In] IWICColorContext* pColorContext = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetToneCurve(
            [In] IWICDevelopRaw* This,
            [In, NativeTypeName("UINT")] uint cbToneCurveSize,
            [In, NativeTypeName("WICRawToneCurve[]")] WICRawToneCurve* pToneCurve
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetToneCurve(
            [In] IWICDevelopRaw* This,
            [In, NativeTypeName("UINT")] uint cbToneCurveBufferSize,
            [Out, NativeTypeName("WICRawToneCurve[]")] WICRawToneCurve* pToneCurve = null,
            [In, Out, NativeTypeName("UINT")] uint* pcbActualToneCurveBufferSize = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetRotation(
            [In] IWICDevelopRaw* This,
            [In] double Rotation
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetRotation(
            [In] IWICDevelopRaw* This,
            [Out] double* pRotation
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetRenderMode(
            [In] IWICDevelopRaw* This,
            [In] WICRawRenderMode RenderMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetRenderMode(
            [In] IWICDevelopRaw* This,
            [Out] WICRawRenderMode* pRenderMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetNotificationCallback(
            [In] IWICDevelopRaw* This,
            [In] IWICDevelopRawNotificationCallback* pCallback = null
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region IWICBitmapSource Methods
        [return: NativeTypeName("HRESULT")]
        public int GetSize(
            [Out, NativeTypeName("UINT")] uint* puiWidth,
            [Out, NativeTypeName("UINT")] uint* puiHeight
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetSize>(lpVtbl->GetSize)(
                    This,
                    puiWidth,
                    puiHeight
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat(
            [Out, NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetPixelFormat>(lpVtbl->GetPixelFormat)(
                    This,
                    pPixelFormat
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResolution(
            [Out] double* pDpiX,
            [Out] double* pDpiY
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetResolution>(lpVtbl->GetResolution)(
                    This,
                    pDpiX,
                    pDpiY
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(
            [In] IWICPalette* pIPalette = null
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_CopyPalette>(lpVtbl->CopyPalette)(
                    This,
                    pIPalette
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels(
            [In, Optional] WICRect* prc,
            [In, NativeTypeName("UINT")] uint cbStride,
            [In, NativeTypeName("UINT")] uint cbBufferSize,
            [Out, NativeTypeName("BYTE[]")] byte* pbBuffer
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_CopyPixels>(lpVtbl->CopyPixels)(
                    This,
                    prc,
                    cbStride,
                    cbBufferSize,
                    pbBuffer
                );
            }
        }
        #endregion

        #region IWICBitmapFrameDecode Methods
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryReader(
            [Out] IWICMetadataQueryReader** ppIMetadataQueryReader = null
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetMetadataQueryReader>(lpVtbl->GetMetadataQueryReader)(
                    This,
                    ppIMetadataQueryReader
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorContexts(
            [In, NativeTypeName("UINT")] uint cCount,
            [In, Out, Optional, NativeTypeName("IWICColorContext*[]")] IWICColorContext** ppIColorContexts,
            [Out, NativeTypeName("UINT")] uint* pcActualCount
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetColorContexts>(lpVtbl->GetColorContexts)(
                    This,
                    cCount,
                    ppIColorContexts,
                    pcActualCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetThumbnail(
            [Out] IWICBitmapSource** ppIThumbnail = null
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetThumbnail>(lpVtbl->GetThumbnail)(
                    This,
                    ppIThumbnail
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryRawCapabilitiesInfo(
            [In, Out] WICRawCapabilitiesInfo* pInfo
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_QueryRawCapabilitiesInfo>(lpVtbl->QueryRawCapabilitiesInfo)(
                    This,
                    pInfo
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadParameterSet(
            [In] WICRawParameterSet ParameterSet
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_LoadParameterSet>(lpVtbl->LoadParameterSet)(
                    This,
                    ParameterSet
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentParameterSet(
            [Out] IPropertyBag2** ppCurrentParameterSet = null
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetCurrentParameterSet>(lpVtbl->GetCurrentParameterSet)(
                    This,
                    ppCurrentParameterSet
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetExposureCompensation(
            [In] double ev
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_SetExposureCompensation>(lpVtbl->SetExposureCompensation)(
                    This,
                    ev
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExposureCompensation(
            [Out] double* pEV
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetExposureCompensation>(lpVtbl->GetExposureCompensation)(
                    This,
                    pEV
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointRGB(
            [In, NativeTypeName("UINT")] uint Red,
            [In, NativeTypeName("UINT")] uint Green,
            [In, NativeTypeName("UINT")] uint Blue
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_SetWhitePointRGB>(lpVtbl->SetWhitePointRGB)(
                    This,
                    Red,
                    Green,
                    Blue
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWhitePointRGB(
            [Out, NativeTypeName("UINT")] uint* pRed,
            [Out, NativeTypeName("UINT")] uint* pGreen,
            [Out, NativeTypeName("UINT")] uint* pBlue
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetWhitePointRGB>(lpVtbl->GetWhitePointRGB)(
                    This,
                    pRed,
                    pGreen,
                    pBlue
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNamedWhitePoint(
            [In] WICNamedWhitePoint WhitePoint
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_SetNamedWhitePoint>(lpVtbl->SetNamedWhitePoint)(
                    This,
                    WhitePoint
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNamedWhitePoint(
            [Out] WICNamedWhitePoint* pWhitePoint
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetNamedWhitePoint>(lpVtbl->GetNamedWhitePoint)(
                    This,
                    pWhitePoint
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointKelvin(
            [In, NativeTypeName("UINT")] uint WhitePointKelvin
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_SetWhitePointKelvin>(lpVtbl->SetWhitePointKelvin)(
                    This,
                    WhitePointKelvin
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWhitePointKelvin(
            [Out, NativeTypeName("UINT")] uint* pWhitePointKelvin
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetWhitePointKelvin>(lpVtbl->GetWhitePointKelvin)(
                    This,
                    pWhitePointKelvin
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetKelvinRangeInfo(
            [Out, NativeTypeName("UINT")] uint* pMinKelvinTemp,
            [Out, NativeTypeName("UINT")] uint* pMaxKelvinTemp,
            [Out, NativeTypeName("UINT")] uint* pKelvinTempStepValue
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetKelvinRangeInfo>(lpVtbl->GetKelvinRangeInfo)(
                    This,
                    pMinKelvinTemp,
                    pMaxKelvinTemp,
                    pKelvinTempStepValue
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetContrast(
            [In] double Contrast
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_SetContrast>(lpVtbl->SetContrast)(
                    This,
                    Contrast
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContrast(
            [Out] double* pContrast
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetContrast>(lpVtbl->GetContrast)(
                    This,
                    pContrast
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGamma(
            [In] double Gamma
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_SetGamma>(lpVtbl->SetGamma)(
                    This,
                    Gamma
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGamma(
            [Out] double* pGamma
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetGamma>(lpVtbl->GetGamma)(
                    This,
                    pGamma
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSharpness(
            [In] double Sharpness
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_SetSharpness>(lpVtbl->SetSharpness)(
                    This,
                    Sharpness
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSharpness(
            [Out] double* pSharpness
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetSharpness>(lpVtbl->GetSharpness)(
                    This,
                    pSharpness
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSaturation(
            [In] double Saturation
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_SetSaturation>(lpVtbl->SetSaturation)(
                    This,
                    Saturation
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSaturation(
            [Out] double* pSaturation
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetSaturation>(lpVtbl->GetSaturation)(
                    This,
                    pSaturation
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTint(
            [In] double Tint
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_SetTint>(lpVtbl->SetTint)(
                    This,
                    Tint
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTint(
            [Out] double* pTint
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetTint>(lpVtbl->GetTint)(
                    This,
                    pTint
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNoiseReduction(
            [In] double NoiseReduction
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_SetNoiseReduction>(lpVtbl->SetNoiseReduction)(
                    This,
                    NoiseReduction
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNoiseReduction(
            [Out] double* pNoiseReduction
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetNoiseReduction>(lpVtbl->GetNoiseReduction)(
                    This,
                    pNoiseReduction
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDestinationColorContext(
            [In] IWICColorContext* pColorContext = null
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_SetDestinationColorContext>(lpVtbl->SetDestinationColorContext)(
                    This,
                    pColorContext
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetToneCurve(
            [In, NativeTypeName("UINT")] uint cbToneCurveSize,
            [In, NativeTypeName("WICRawToneCurve[]")] WICRawToneCurve* pToneCurve
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_SetToneCurve>(lpVtbl->SetToneCurve)(
                    This,
                    cbToneCurveSize,
                    pToneCurve
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetToneCurve(
            [In, NativeTypeName("UINT")] uint cbToneCurveBufferSize,
            [Out, NativeTypeName("WICRawToneCurve[]")] WICRawToneCurve* pToneCurve = null,
            [In, Out, NativeTypeName("UINT")] uint* pcbActualToneCurveBufferSize = null
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetToneCurve>(lpVtbl->GetToneCurve)(
                    This,
                    cbToneCurveBufferSize,
                    pToneCurve,
                    pcbActualToneCurveBufferSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRotation(
            [In] double Rotation
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_SetRotation>(lpVtbl->SetRotation)(
                    This,
                    Rotation
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRotation(
            [Out] double* pRotation
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetRotation>(lpVtbl->GetRotation)(
                    This,
                    pRotation
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRenderMode(
            [In] WICRawRenderMode RenderMode
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_SetRenderMode>(lpVtbl->SetRenderMode)(
                    This,
                    RenderMode
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRenderMode(
            [Out] WICRawRenderMode* pRenderMode
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_GetRenderMode>(lpVtbl->GetRenderMode)(
                    This,
                    pRenderMode
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotificationCallback(
            [In] IWICDevelopRawNotificationCallback* pCallback = null
        )
        {
            fixed (IWICDevelopRaw* This = &this)
            {
                return MarshalFunction<_SetNotificationCallback>(lpVtbl->SetNotificationCallback)(
                    This,
                    pCallback
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region IWICBitmapSource Fields
            public IntPtr GetSize;

            public IntPtr GetPixelFormat;

            public IntPtr GetResolution;

            public IntPtr CopyPalette;

            public IntPtr CopyPixels;
            #endregion

            #region IWICBitmapFrameDecode Fields
            public IntPtr GetMetadataQueryReader;

            public IntPtr GetColorContexts;

            public IntPtr GetThumbnail;
            #endregion

            #region Fields
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
            #endregion
        }
        #endregion
    }
}
