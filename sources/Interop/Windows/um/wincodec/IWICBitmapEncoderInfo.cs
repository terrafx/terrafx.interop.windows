// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("94C9B4EE-A09F-4F92-8A1E-4A9BCE7E76FB")]
    public unsafe struct IWICBitmapEncoderInfo
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICBitmapEncoderInfo* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICBitmapEncoderInfo* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICBitmapEncoderInfo* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetComponentType(
            [In] IWICBitmapEncoderInfo* This,
            [Out] WICComponentType* pType
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetCLSID(
            [In] IWICBitmapEncoderInfo* This,
            [Out, NativeTypeName("CLSID")] Guid* pclsid
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSigningStatus(
            [In] IWICBitmapEncoderInfo* This,
            [Out, NativeTypeName("DWORD")] uint* pStatus
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetAuthor(
            [In] IWICBitmapEncoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchAuthor,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzAuthor,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetVendorGUID(
            [In] IWICBitmapEncoderInfo* This,
            [Out, NativeTypeName("GUID")] Guid* pguidVendor
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetVersion(
            [In] IWICBitmapEncoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchVersion,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzVersion,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSpecVersion(
            [In] IWICBitmapEncoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchSpecVersion,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzSpecVersion,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFriendlyName(
            [In] IWICBitmapEncoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchFriendlyName,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzFriendlyName,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetContainerFormat(
            [In] IWICBitmapEncoderInfo* This,
            [Out, NativeTypeName("GUID")] Guid* pguidContainerFormat
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPixelFormats(
            [In] IWICBitmapEncoderInfo* This,
            [In, NativeTypeName("UINT")] uint cFormats,
            [In, Out, Optional, NativeTypeName("GUID[]")] Guid* pguidPixelFormats,
            [Out, NativeTypeName("UINT")] uint* pcActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetColorManagementVersion(
            [In] IWICBitmapEncoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchColorManagementVersion,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzColorManagementVersion,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDeviceManufacturer(
            [In] IWICBitmapEncoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchDeviceManufacturer,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzDeviceManufacturer,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDeviceModels(
            [In] IWICBitmapEncoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchDeviceModels,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzDeviceModels,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMimeTypes(
            [In] IWICBitmapEncoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchMimeTypes,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzMimeTypes,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFileExtensions(
            [In] IWICBitmapEncoderInfo* This,
            [In, NativeTypeName("UINT")] uint cchFileExtensions,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzFileExtensions,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DoesSupportAnimation(
            [In] IWICBitmapEncoderInfo* This,
            [Out, NativeTypeName("BOOL")] int* pfSupportAnimation
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DoesSupportChromakey(
            [In] IWICBitmapEncoderInfo* This,
            [Out, NativeTypeName("BOOL")] int* pfSupportChromakey
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DoesSupportLossless(
            [In] IWICBitmapEncoderInfo* This,
            [Out, NativeTypeName("BOOL")] int* pfSupportLossless
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DoesSupportMultiframe(
            [In] IWICBitmapEncoderInfo* This,
            [Out, NativeTypeName("BOOL")] int* pfSupportMultiframe
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _MatchesMimeType(
            [In] IWICBitmapEncoderInfo* This,
            [In, NativeTypeName("LPCWSTR")] char* wzMimeType,
            [Out, NativeTypeName("BOOL")] int* pfMatches
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateInstance(
            [In] IWICBitmapEncoderInfo* This,
            [Out] IWICBitmapEncoder** ppIBitmapEncoder = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
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
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MatchesMimeType>(lpVtbl->MatchesMimeType)(
                    This,
                    wzMimeType,
                    pfMatches
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance(
            [Out] IWICBitmapEncoder** ppIBitmapEncoder = null
        )
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateInstance>(lpVtbl->CreateInstance)(
                    This,
                    ppIBitmapEncoder
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

            public IntPtr CreateInstance;
        }
    }
}
