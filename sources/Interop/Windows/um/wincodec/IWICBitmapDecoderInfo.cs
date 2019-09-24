// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D8CD007F-D08F-4191-9BFC-236EA7F0E4B5")]
    public unsafe struct IWICBitmapDecoderInfo
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IWICBitmapDecoderInfo* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IWICBitmapDecoderInfo* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IWICBitmapDecoderInfo* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetComponentType(
            [In] IWICBitmapDecoderInfo* This,
            [Out] WICComponentType* pType
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCLSID(
            [In] IWICBitmapDecoderInfo* This,
            [Out, NativeTypeName("CLSID")] Guid* pclsid
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSigningStatus(
            [In] IWICBitmapDecoderInfo* This,
            [Out, NativeTypeName("DWORD")] uint* pStatus
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAuthor(
            [In] IWICBitmapDecoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchAuthor,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzAuthor,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVendorGUID(
            [In] IWICBitmapDecoderInfo* This,
            [Out, NativeTypeName("GUID")] Guid* pguidVendor
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVersion(
            [In] IWICBitmapDecoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchVersion,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzVersion,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSpecVersion(
            [In] IWICBitmapDecoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchSpecVersion,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzSpecVersion,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFriendlyName(
            [In] IWICBitmapDecoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchFriendlyName,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzFriendlyName,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainerFormat(
            [In] IWICBitmapDecoderInfo* This,
            [Out, NativeTypeName("GUID")] Guid* pguidContainerFormat
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPixelFormats(
            [In] IWICBitmapDecoderInfo* This,
            [In, NativeTypeName("UINT")] uint cFormats,
            [In, Out, Optional, NativeTypeName("GUID[]")] Guid* pguidPixelFormats,
            [Out, NativeTypeName("UINT")] uint* pcActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetColorManagementVersion(
            [In] IWICBitmapDecoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchColorManagementVersion,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzColorManagementVersion,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceManufacturer(
            [In] IWICBitmapDecoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchDeviceManufacturer,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzDeviceManufacturer,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceModels(
            [In] IWICBitmapDecoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchDeviceModels,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzDeviceModels,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMimeTypes(
            [In] IWICBitmapDecoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchMimeTypes,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzMimeTypes,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFileExtensions(
            [In] IWICBitmapDecoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchFileExtensions,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzFileExtensions,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportAnimation(
            [In] IWICBitmapDecoderInfo* This,
            [Out, NativeTypeName("BOOL")] int* pfSupportAnimation
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportChromakey(
            [In] IWICBitmapDecoderInfo* This,
            [Out, NativeTypeName("BOOL")] int* pfSupportChromakey
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportLossless(
            [In] IWICBitmapDecoderInfo* This,
            [Out, NativeTypeName("BOOL")] int* pfSupportLossless
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportMultiframe(
            [In] IWICBitmapDecoderInfo* This,
            [Out, NativeTypeName("BOOL")] int* pfSupportMultiframe
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MatchesMimeType(
            [In] IWICBitmapDecoderInfo* This,
            [In, NativeTypeName("LPCWSTR")] char* wzMimeType,
            [Out, NativeTypeName("BOOL")] int* pfMatches
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPatterns(
            [In] IWICBitmapDecoderInfo* This,
            [In, NativeTypeName("UINT")] uint cbSizePatterns,
            [Out, Optional, NativeTypeName("WICBitmapPattern[]")] WICBitmapPattern* pPatterns,
            [Out, Optional, NativeTypeName("UINT")] uint* pcPatterns,
            [Out, NativeTypeName("UINT")] uint* pcbPatternsActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MatchesPattern(
            [In] IWICBitmapDecoderInfo* This,
            [In, Optional] IStream* pIStream,
            [Out, NativeTypeName("BOOL")] int* pfMatches
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInstance(
            [In] IWICBitmapDecoderInfo* This,
            [Out] IWICBitmapDecoder** ppIBitmapDecoder = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(
            [Out] WICComponentType* pType
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetComponentType>(lpVtbl->GetComponentType)(
                    This,
                    pType
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCLSID(
            [Out, NativeTypeName("CLSID")] Guid* pclsid
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCLSID>(lpVtbl->GetCLSID)(
                    This,
                    pclsid
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus(
            [Out, NativeTypeName("DWORD")] uint* pStatus
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSigningStatus>(lpVtbl->GetSigningStatus)(
                    This,
                    pStatus
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthor(
            [In, NativeTypeName("UINT")] uint cchAuthor,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzAuthor,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAuthor>(lpVtbl->GetAuthor)(
                    This,
                    cchAuthor,
                    wzAuthor,
                    pcchActual
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID(
            [Out, NativeTypeName("GUID")] Guid* pguidVendor
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVendorGUID>(lpVtbl->GetVendorGUID)(
                    This,
                    pguidVendor
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion(
            [In, NativeTypeName("UINT")] uint cchVersion,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzVersion,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVersion>(lpVtbl->GetVersion)(
                    This,
                    cchVersion,
                    wzVersion,
                    pcchActual
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion(
            [In, NativeTypeName("UINT")] uint cchSpecVersion,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzSpecVersion,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSpecVersion>(lpVtbl->GetSpecVersion)(
                    This,
                    cchSpecVersion,
                    wzSpecVersion,
                    pcchActual
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName(
            [In, NativeTypeName("UINT")] uint cchFriendlyName,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzFriendlyName,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFriendlyName>(lpVtbl->GetFriendlyName)(
                    This,
                    cchFriendlyName,
                    wzFriendlyName,
                    pcchActual
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat(
            [Out, NativeTypeName("GUID")] Guid* pguidContainerFormat
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainerFormat>(lpVtbl->GetContainerFormat)(
                    This,
                    pguidContainerFormat
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormats(
            [In, NativeTypeName("UINT")] uint cFormats,
            [In, Out, Optional, NativeTypeName("GUID[]")] Guid* pguidPixelFormats,
            [Out, NativeTypeName("UINT")] uint* pcActual
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPixelFormats>(lpVtbl->GetPixelFormats)(
                    This,
                    cFormats,
                    pguidPixelFormats,
                    pcActual
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorManagementVersion(
            [In, NativeTypeName("UINT")] uint cchColorManagementVersion,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzColorManagementVersion,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorManagementVersion>(lpVtbl->GetColorManagementVersion)(
                    This,
                    cchColorManagementVersion,
                    wzColorManagementVersion,
                    pcchActual
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer(
            [In, NativeTypeName("UINT")] uint cchDeviceManufacturer,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzDeviceManufacturer,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDeviceManufacturer>(lpVtbl->GetDeviceManufacturer)(
                    This,
                    cchDeviceManufacturer,
                    wzDeviceManufacturer,
                    pcchActual
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels(
            [In, NativeTypeName("UINT")] uint cchDeviceModels,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzDeviceModels,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDeviceModels>(lpVtbl->GetDeviceModels)(
                    This,
                    cchDeviceModels,
                    wzDeviceModels,
                    pcchActual
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMimeTypes(
            [In, NativeTypeName("UINT")] uint cchMimeTypes,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzMimeTypes,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMimeTypes>(lpVtbl->GetMimeTypes)(
                    This,
                    cchMimeTypes,
                    wzMimeTypes,
                    pcchActual
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileExtensions(
            [In, NativeTypeName("UINT")] uint cchFileExtensions,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzFileExtensions,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFileExtensions>(lpVtbl->GetFileExtensions)(
                    This,
                    cchFileExtensions,
                    wzFileExtensions,
                    pcchActual
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportAnimation(
            [Out, NativeTypeName("BOOL")] int* pfSupportAnimation
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportAnimation>(lpVtbl->DoesSupportAnimation)(
                    This,
                    pfSupportAnimation
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportChromakey(
            [Out, NativeTypeName("BOOL")] int* pfSupportChromakey
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportChromakey>(lpVtbl->DoesSupportChromakey)(
                    This,
                    pfSupportChromakey
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportLossless(
            [Out, NativeTypeName("BOOL")] int* pfSupportLossless
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportLossless>(lpVtbl->DoesSupportLossless)(
                    This,
                    pfSupportLossless
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportMultiframe(
            [Out, NativeTypeName("BOOL")] int* pfSupportMultiframe
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportMultiframe>(lpVtbl->DoesSupportMultiframe)(
                    This,
                    pfSupportMultiframe
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MatchesMimeType(
            [In, NativeTypeName("LPCWSTR")] char* wzMimeType,
            [Out, NativeTypeName("BOOL")] int* pfMatches
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MatchesMimeType>(lpVtbl->MatchesMimeType)(
                    This,
                    wzMimeType,
                    pfMatches
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPatterns(
            [In, NativeTypeName("UINT")] uint cbSizePatterns,
            [Out, Optional, NativeTypeName("WICBitmapPattern[]")] WICBitmapPattern* pPatterns,
            [Out, Optional, NativeTypeName("UINT")] uint* pcPatterns,
            [Out, NativeTypeName("UINT")] uint* pcbPatternsActual
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPatterns>(lpVtbl->GetPatterns)(
                    This,
                    cbSizePatterns,
                    pPatterns,
                    pcPatterns,
                    pcbPatternsActual
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MatchesPattern(
            [In, Optional] IStream* pIStream,
            [Out, NativeTypeName("BOOL")] int* pfMatches
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MatchesPattern>(lpVtbl->MatchesPattern)(
                    This,
                    pIStream,
                    pfMatches
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance(
            [Out] IWICBitmapDecoder** ppIBitmapDecoder = null
        )
        {
            fixed (IWICBitmapDecoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateInstance>(lpVtbl->CreateInstance)(
                    This,
                    ppIBitmapDecoder
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetComponentType;

            public IntPtr GetCLSID;

            public IntPtr GetSigningStatus;

            public IntPtr GetAuthor;

            public IntPtr GetVendorGUID;

            public IntPtr GetVersion;

            public IntPtr GetSpecVersion;

            public IntPtr GetFriendlyName;

            public IntPtr GetContainerFormat;

            public IntPtr GetPixelFormats;

            public IntPtr GetColorManagementVersion;

            public IntPtr GetDeviceManufacturer;

            public IntPtr GetDeviceModels;

            public IntPtr GetMimeTypes;

            public IntPtr GetFileExtensions;

            public IntPtr DoesSupportAnimation;

            public IntPtr DoesSupportChromakey;

            public IntPtr DoesSupportLossless;

            public IntPtr DoesSupportMultiframe;

            public IntPtr MatchesMimeType;

            public IntPtr GetPatterns;

            public IntPtr MatchesPattern;

            public IntPtr CreateInstance;
        }
    }
}
