// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E87A44C4-B76E-4C47-8B09-298EB12A2714")]
    public unsafe struct IWICBitmapCodecInfo
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICBitmapCodecInfo* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICBitmapCodecInfo* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICBitmapCodecInfo* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetComponentType(IWICBitmapCodecInfo* This, WICComponentType* pType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCLSID(IWICBitmapCodecInfo* This, [NativeTypeName("CLSID")] Guid* pclsid);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSigningStatus(IWICBitmapCodecInfo* This, [NativeTypeName("DWORD")] uint* pStatus);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAuthor(IWICBitmapCodecInfo* This, [NativeTypeName("UINT")] uint cchAuthor, [Optional, NativeTypeName("WCHAR[]")] char* wzAuthor, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVendorGUID(IWICBitmapCodecInfo* This, [NativeTypeName("GUID")] Guid* pguidVendor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVersion(IWICBitmapCodecInfo* This, [NativeTypeName("UINT")] uint cchVersion, [Optional, NativeTypeName("WCHAR[]")] char* wzVersion, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSpecVersion(IWICBitmapCodecInfo* This, [NativeTypeName("UINT")] uint cchSpecVersion, [Optional, NativeTypeName("WCHAR[]")] char* wzSpecVersion, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFriendlyName(IWICBitmapCodecInfo* This, [NativeTypeName("UINT")] uint cchFriendlyName, [Optional, NativeTypeName("WCHAR[]")] char* wzFriendlyName, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainerFormat(IWICBitmapCodecInfo* This, [NativeTypeName("GUID")] Guid* pguidContainerFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPixelFormats(IWICBitmapCodecInfo* This, [NativeTypeName("UINT")] uint cFormats, [Optional, NativeTypeName("GUID[]")] Guid* pguidPixelFormats, [NativeTypeName("UINT")] uint* pcActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetColorManagementVersion(IWICBitmapCodecInfo* This, [NativeTypeName("UINT")] uint cchColorManagementVersion, [Optional, NativeTypeName("WCHAR[]")] char* wzColorManagementVersion, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceManufacturer(IWICBitmapCodecInfo* This, [NativeTypeName("UINT")] uint cchDeviceManufacturer, [Optional, NativeTypeName("WCHAR[]")] char* wzDeviceManufacturer, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceModels(IWICBitmapCodecInfo* This, [NativeTypeName("UINT")] uint cchDeviceModels, [Optional, NativeTypeName("WCHAR[]")] char* wzDeviceModels, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMimeTypes(IWICBitmapCodecInfo* This, [NativeTypeName("UINT")] uint cchMimeTypes, [Optional, NativeTypeName("WCHAR[]")] char* wzMimeTypes, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFileExtensions(IWICBitmapCodecInfo* This, [NativeTypeName("UINT")] uint cchFileExtensions, [Optional, NativeTypeName("WCHAR[]")] char* wzFileExtensions, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportAnimation(IWICBitmapCodecInfo* This, [NativeTypeName("BOOL")] int* pfSupportAnimation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportChromakey(IWICBitmapCodecInfo* This, [NativeTypeName("BOOL")] int* pfSupportChromakey);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportLossless(IWICBitmapCodecInfo* This, [NativeTypeName("BOOL")] int* pfSupportLossless);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportMultiframe(IWICBitmapCodecInfo* This, [NativeTypeName("BOOL")] int* pfSupportMultiframe);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MatchesMimeType(IWICBitmapCodecInfo* This, [NativeTypeName("LPCWSTR")] char* wzMimeType, [NativeTypeName("BOOL")] int* pfMatches);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetComponentType>(lpVtbl->GetComponentType)(This, pType);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID")] Guid* pclsid)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCLSID>(lpVtbl->GetCLSID)(This, pclsid);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD")] uint* pStatus)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSigningStatus>(lpVtbl->GetSigningStatus)(This, pStatus);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [Optional, NativeTypeName("WCHAR[]")] char* wzAuthor, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAuthor>(lpVtbl->GetAuthor)(This, cchAuthor, wzAuthor, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID")] Guid* pguidVendor)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVendorGUID>(lpVtbl->GetVendorGUID)(This, pguidVendor);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [Optional, NativeTypeName("WCHAR[]")] char* wzVersion, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVersion>(lpVtbl->GetVersion)(This, cchVersion, wzVersion, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [Optional, NativeTypeName("WCHAR[]")] char* wzSpecVersion, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSpecVersion>(lpVtbl->GetSpecVersion)(This, cchSpecVersion, wzSpecVersion, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [Optional, NativeTypeName("WCHAR[]")] char* wzFriendlyName, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFriendlyName>(lpVtbl->GetFriendlyName)(This, cchFriendlyName, wzFriendlyName, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID")] Guid* pguidContainerFormat)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainerFormat>(lpVtbl->GetContainerFormat)(This, pguidContainerFormat);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormats([NativeTypeName("UINT")] uint cFormats, [Optional, NativeTypeName("GUID[]")] Guid* pguidPixelFormats, [NativeTypeName("UINT")] uint* pcActual)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPixelFormats>(lpVtbl->GetPixelFormats)(This, cFormats, pguidPixelFormats, pcActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorManagementVersion([NativeTypeName("UINT")] uint cchColorManagementVersion, [Optional, NativeTypeName("WCHAR[]")] char* wzColorManagementVersion, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorManagementVersion>(lpVtbl->GetColorManagementVersion)(This, cchColorManagementVersion, wzColorManagementVersion, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer([NativeTypeName("UINT")] uint cchDeviceManufacturer, [Optional, NativeTypeName("WCHAR[]")] char* wzDeviceManufacturer, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDeviceManufacturer>(lpVtbl->GetDeviceManufacturer)(This, cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels([NativeTypeName("UINT")] uint cchDeviceModels, [Optional, NativeTypeName("WCHAR[]")] char* wzDeviceModels, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDeviceModels>(lpVtbl->GetDeviceModels)(This, cchDeviceModels, wzDeviceModels, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMimeTypes([NativeTypeName("UINT")] uint cchMimeTypes, [Optional, NativeTypeName("WCHAR[]")] char* wzMimeTypes, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMimeTypes>(lpVtbl->GetMimeTypes)(This, cchMimeTypes, wzMimeTypes, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileExtensions([NativeTypeName("UINT")] uint cchFileExtensions, [Optional, NativeTypeName("WCHAR[]")] char* wzFileExtensions, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFileExtensions>(lpVtbl->GetFileExtensions)(This, cchFileExtensions, wzFileExtensions, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportAnimation([NativeTypeName("BOOL")] int* pfSupportAnimation)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportAnimation>(lpVtbl->DoesSupportAnimation)(This, pfSupportAnimation);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportChromakey([NativeTypeName("BOOL")] int* pfSupportChromakey)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportChromakey>(lpVtbl->DoesSupportChromakey)(This, pfSupportChromakey);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportLossless([NativeTypeName("BOOL")] int* pfSupportLossless)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportLossless>(lpVtbl->DoesSupportLossless)(This, pfSupportLossless);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportMultiframe([NativeTypeName("BOOL")] int* pfSupportMultiframe)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportMultiframe>(lpVtbl->DoesSupportMultiframe)(This, pfSupportMultiframe);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MatchesMimeType([NativeTypeName("LPCWSTR")] char* wzMimeType, [NativeTypeName("BOOL")] int* pfMatches)
        {
            fixed (IWICBitmapCodecInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MatchesMimeType>(lpVtbl->MatchesMimeType)(This, wzMimeType, pfMatches);
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
        }
    }
}
