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
        public delegate int _QueryInterface(IWICBitmapEncoderInfo* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICBitmapEncoderInfo* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICBitmapEncoderInfo* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetComponentType(IWICBitmapEncoderInfo* This, WICComponentType* pType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCLSID(IWICBitmapEncoderInfo* This, [NativeTypeName("CLSID")] Guid* pclsid);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSigningStatus(IWICBitmapEncoderInfo* This, [NativeTypeName("DWORD")] uint* pStatus);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAuthor(IWICBitmapEncoderInfo* This, [NativeTypeName("UINT")] uint cchAuthor, [Optional, NativeTypeName("WCHAR[]")] char* wzAuthor, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVendorGUID(IWICBitmapEncoderInfo* This, [NativeTypeName("GUID")] Guid* pguidVendor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVersion(IWICBitmapEncoderInfo* This, [NativeTypeName("UINT")] uint cchVersion, [Optional, NativeTypeName("WCHAR[]")] char* wzVersion, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSpecVersion(IWICBitmapEncoderInfo* This, [NativeTypeName("UINT")] uint cchSpecVersion, [Optional, NativeTypeName("WCHAR[]")] char* wzSpecVersion, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFriendlyName(IWICBitmapEncoderInfo* This, [NativeTypeName("UINT")] uint cchFriendlyName, [Optional, NativeTypeName("WCHAR[]")] char* wzFriendlyName, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainerFormat(IWICBitmapEncoderInfo* This, [NativeTypeName("GUID")] Guid* pguidContainerFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPixelFormats(IWICBitmapEncoderInfo* This, [NativeTypeName("UINT")] uint cFormats, [Optional, NativeTypeName("GUID[]")] Guid* pguidPixelFormats, [NativeTypeName("UINT")] uint* pcActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetColorManagementVersion(IWICBitmapEncoderInfo* This, [NativeTypeName("UINT")] uint cchColorManagementVersion, [Optional, NativeTypeName("WCHAR[]")] char* wzColorManagementVersion, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceManufacturer(IWICBitmapEncoderInfo* This, [NativeTypeName("UINT")] uint cchDeviceManufacturer, [Optional, NativeTypeName("WCHAR[]")] char* wzDeviceManufacturer, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceModels(IWICBitmapEncoderInfo* This, [NativeTypeName("UINT")] uint cchDeviceModels, [Optional, NativeTypeName("WCHAR[]")] char* wzDeviceModels, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMimeTypes(IWICBitmapEncoderInfo* This, [NativeTypeName("UINT")] uint cchMimeTypes, [Optional, NativeTypeName("WCHAR[]")] char* wzMimeTypes, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFileExtensions(IWICBitmapEncoderInfo* This, [NativeTypeName("UINT")] uint cchFileExtensions, [Optional, NativeTypeName("WCHAR[]")] char* wzFileExtensions, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportAnimation(IWICBitmapEncoderInfo* This, [NativeTypeName("BOOL")] int* pfSupportAnimation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportChromakey(IWICBitmapEncoderInfo* This, [NativeTypeName("BOOL")] int* pfSupportChromakey);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportLossless(IWICBitmapEncoderInfo* This, [NativeTypeName("BOOL")] int* pfSupportLossless);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportMultiframe(IWICBitmapEncoderInfo* This, [NativeTypeName("BOOL")] int* pfSupportMultiframe);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MatchesMimeType(IWICBitmapEncoderInfo* This, [NativeTypeName("LPCWSTR")] char* wzMimeType, [NativeTypeName("BOOL")] int* pfMatches);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInstance(IWICBitmapEncoderInfo* This, IWICBitmapEncoder** ppIBitmapEncoder = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetComponentType>(lpVtbl->GetComponentType)(This, pType);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID")] Guid* pclsid)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCLSID>(lpVtbl->GetCLSID)(This, pclsid);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD")] uint* pStatus)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSigningStatus>(lpVtbl->GetSigningStatus)(This, pStatus);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [Optional, NativeTypeName("WCHAR[]")] char* wzAuthor, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAuthor>(lpVtbl->GetAuthor)(This, cchAuthor, wzAuthor, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID")] Guid* pguidVendor)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVendorGUID>(lpVtbl->GetVendorGUID)(This, pguidVendor);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [Optional, NativeTypeName("WCHAR[]")] char* wzVersion, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVersion>(lpVtbl->GetVersion)(This, cchVersion, wzVersion, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [Optional, NativeTypeName("WCHAR[]")] char* wzSpecVersion, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSpecVersion>(lpVtbl->GetSpecVersion)(This, cchSpecVersion, wzSpecVersion, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [Optional, NativeTypeName("WCHAR[]")] char* wzFriendlyName, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFriendlyName>(lpVtbl->GetFriendlyName)(This, cchFriendlyName, wzFriendlyName, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID")] Guid* pguidContainerFormat)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainerFormat>(lpVtbl->GetContainerFormat)(This, pguidContainerFormat);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormats([NativeTypeName("UINT")] uint cFormats, [Optional, NativeTypeName("GUID[]")] Guid* pguidPixelFormats, [NativeTypeName("UINT")] uint* pcActual)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPixelFormats>(lpVtbl->GetPixelFormats)(This, cFormats, pguidPixelFormats, pcActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorManagementVersion([NativeTypeName("UINT")] uint cchColorManagementVersion, [Optional, NativeTypeName("WCHAR[]")] char* wzColorManagementVersion, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorManagementVersion>(lpVtbl->GetColorManagementVersion)(This, cchColorManagementVersion, wzColorManagementVersion, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer([NativeTypeName("UINT")] uint cchDeviceManufacturer, [Optional, NativeTypeName("WCHAR[]")] char* wzDeviceManufacturer, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDeviceManufacturer>(lpVtbl->GetDeviceManufacturer)(This, cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels([NativeTypeName("UINT")] uint cchDeviceModels, [Optional, NativeTypeName("WCHAR[]")] char* wzDeviceModels, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDeviceModels>(lpVtbl->GetDeviceModels)(This, cchDeviceModels, wzDeviceModels, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMimeTypes([NativeTypeName("UINT")] uint cchMimeTypes, [Optional, NativeTypeName("WCHAR[]")] char* wzMimeTypes, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMimeTypes>(lpVtbl->GetMimeTypes)(This, cchMimeTypes, wzMimeTypes, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileExtensions([NativeTypeName("UINT")] uint cchFileExtensions, [Optional, NativeTypeName("WCHAR[]")] char* wzFileExtensions, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFileExtensions>(lpVtbl->GetFileExtensions)(This, cchFileExtensions, wzFileExtensions, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportAnimation([NativeTypeName("BOOL")] int* pfSupportAnimation)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportAnimation>(lpVtbl->DoesSupportAnimation)(This, pfSupportAnimation);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportChromakey([NativeTypeName("BOOL")] int* pfSupportChromakey)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportChromakey>(lpVtbl->DoesSupportChromakey)(This, pfSupportChromakey);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportLossless([NativeTypeName("BOOL")] int* pfSupportLossless)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportLossless>(lpVtbl->DoesSupportLossless)(This, pfSupportLossless);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportMultiframe([NativeTypeName("BOOL")] int* pfSupportMultiframe)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportMultiframe>(lpVtbl->DoesSupportMultiframe)(This, pfSupportMultiframe);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MatchesMimeType([NativeTypeName("LPCWSTR")] char* wzMimeType, [NativeTypeName("BOOL")] int* pfMatches)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MatchesMimeType>(lpVtbl->MatchesMimeType)(This, wzMimeType, pfMatches);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance(IWICBitmapEncoder** ppIBitmapEncoder = null)
        {
            fixed (IWICBitmapEncoderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateInstance>(lpVtbl->CreateInstance)(This, ppIBitmapEncoder);
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
