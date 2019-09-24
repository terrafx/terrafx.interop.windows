// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodecsdk.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EEBF1F5B-07C1-4447-A3AB-22ACAF78A804")]
    public unsafe struct IWICMetadataReaderInfo
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IWICMetadataReaderInfo* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IWICMetadataReaderInfo* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IWICMetadataReaderInfo* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetComponentType(
            [In] IWICMetadataReaderInfo* This,
            [Out] WICComponentType* pType
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCLSID(
            [In] IWICMetadataReaderInfo* This,
            [Out, NativeTypeName("CLSID")] Guid* pclsid
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSigningStatus(
            [In] IWICMetadataReaderInfo* This,
            [Out, NativeTypeName("DWORD")] uint* pStatus
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAuthor(
            [In] IWICMetadataReaderInfo* This,
            [In, NativeTypeName("UINT")] uint cchAuthor,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzAuthor,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVendorGUID(
            [In] IWICMetadataReaderInfo* This,
            [Out, NativeTypeName("GUID")] Guid* pguidVendor
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVersion(
            [In] IWICMetadataReaderInfo* This,
            [In, NativeTypeName("UINT")] uint cchVersion,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzVersion,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSpecVersion(
            [In] IWICMetadataReaderInfo* This,
            [In, NativeTypeName("UINT")] uint cchSpecVersion,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzSpecVersion,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFriendlyName(
            [In] IWICMetadataReaderInfo* This,
            [In, NativeTypeName("UINT")] uint cchFriendlyName,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzFriendlyName,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataFormat(
            [In] IWICMetadataReaderInfo* This,
            [Out, NativeTypeName("GUID")] Guid* pguidMetadataFormat
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainerFormats(
            [In] IWICMetadataReaderInfo* This,
            [In, NativeTypeName("UINT")] uint cContainerFormats,
            [In, Out, Optional, NativeTypeName("GUID[]")] Guid* pguidContainerFormats,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceManufacturer(
            [In] IWICMetadataReaderInfo* This,
            [In, NativeTypeName("UINT")] uint cchDeviceManufacturer,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzDeviceManufacturer,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceModels(
            [In] IWICMetadataReaderInfo* This,
            [In, NativeTypeName("UINT")] uint cchDeviceModels,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzDeviceModels,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesRequireFullStream(
            [In] IWICMetadataReaderInfo* This,
            [Out, NativeTypeName("BOOL")] int* pfRequiresFullStream
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportPadding(
            [In] IWICMetadataReaderInfo* This,
            [Out, NativeTypeName("BOOL")] int* pfSupportsPadding
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesRequireFixedSize(
            [In] IWICMetadataReaderInfo* This,
            [Out, NativeTypeName("BOOL")] int* pfFixedSize
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPatterns(
            [In] IWICMetadataReaderInfo* This,
            [In, NativeTypeName("REFGUID")] Guid* guidContainerFormat,
            [In, NativeTypeName("UINT")] uint cbSize,
            [Out] WICMetadataPattern* pPattern = null,
            [Out, NativeTypeName("UINT")] uint* pcCount = null,
            [Out, NativeTypeName("UINT")] uint* pcbActual = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MatchesPattern(
            [In] IWICMetadataReaderInfo* This,
            [In, NativeTypeName("REFGUID")] Guid* guidContainerFormat,
            [In, Optional] IStream* pIStream,
            [Out, NativeTypeName("BOOL")] int* pfMatches
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInstance(
            [In] IWICMetadataReaderInfo* This,
            [Out] IWICMetadataReader** ppIReader = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICMetadataReaderInfo* This = &this)
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
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICMetadataReaderInfo* This = &this)
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
            fixed (IWICMetadataReaderInfo* This = &this)
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
            fixed (IWICMetadataReaderInfo* This = &this)
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
            fixed (IWICMetadataReaderInfo* This = &this)
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
            fixed (IWICMetadataReaderInfo* This = &this)
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
            fixed (IWICMetadataReaderInfo* This = &this)
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
            fixed (IWICMetadataReaderInfo* This = &this)
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
            fixed (IWICMetadataReaderInfo* This = &this)
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
            fixed (IWICMetadataReaderInfo* This = &this)
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
        public int GetMetadataFormat(
            [Out, NativeTypeName("GUID")] Guid* pguidMetadataFormat
        )
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetadataFormat>(lpVtbl->GetMetadataFormat)(
                    This,
                    pguidMetadataFormat
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormats(
            [In, NativeTypeName("UINT")] uint cContainerFormats,
            [In, Out, Optional, NativeTypeName("GUID[]")] Guid* pguidContainerFormats,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        )
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainerFormats>(lpVtbl->GetContainerFormats)(
                    This,
                    cContainerFormats,
                    pguidContainerFormats,
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
            fixed (IWICMetadataReaderInfo* This = &this)
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
            fixed (IWICMetadataReaderInfo* This = &this)
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
        public int DoesRequireFullStream(
            [Out, NativeTypeName("BOOL")] int* pfRequiresFullStream
        )
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesRequireFullStream>(lpVtbl->DoesRequireFullStream)(
                    This,
                    pfRequiresFullStream
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportPadding(
            [Out, NativeTypeName("BOOL")] int* pfSupportsPadding
        )
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportPadding>(lpVtbl->DoesSupportPadding)(
                    This,
                    pfSupportsPadding
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFixedSize(
            [Out, NativeTypeName("BOOL")] int* pfFixedSize
        )
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesRequireFixedSize>(lpVtbl->DoesRequireFixedSize)(
                    This,
                    pfFixedSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPatterns(
            [In, NativeTypeName("REFGUID")] Guid* guidContainerFormat,
            [In, NativeTypeName("UINT")] uint cbSize,
            [Out] WICMetadataPattern* pPattern = null,
            [Out, NativeTypeName("UINT")] uint* pcCount = null,
            [Out, NativeTypeName("UINT")] uint* pcbActual = null
        )
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPatterns>(lpVtbl->GetPatterns)(
                    This,
                    guidContainerFormat,
                    cbSize,
                    pPattern,
                    pcCount,
                    pcbActual
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MatchesPattern(
            [In, NativeTypeName("REFGUID")] Guid* guidContainerFormat,
            [In, Optional] IStream* pIStream,
            [Out, NativeTypeName("BOOL")] int* pfMatches
        )
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MatchesPattern>(lpVtbl->MatchesPattern)(
                    This,
                    guidContainerFormat,
                    pIStream,
                    pfMatches
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance(
            [Out] IWICMetadataReader** ppIReader = null
        )
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateInstance>(lpVtbl->CreateInstance)(
                    This,
                    ppIReader
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

            public IntPtr GetMetadataFormat;

            public IntPtr GetContainerFormats;

            public IntPtr GetDeviceManufacturer;

            public IntPtr GetDeviceModels;

            public IntPtr DoesRequireFullStream;

            public IntPtr DoesSupportPadding;

            public IntPtr DoesRequireFixedSize;

            public IntPtr GetPatterns;

            public IntPtr MatchesPattern;

            public IntPtr CreateInstance;
        }
    }
}
