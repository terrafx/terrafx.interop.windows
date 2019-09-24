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
        public delegate int _QueryInterface(IWICMetadataReaderInfo* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICMetadataReaderInfo* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICMetadataReaderInfo* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetComponentType(IWICMetadataReaderInfo* This, WICComponentType* pType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCLSID(IWICMetadataReaderInfo* This, [NativeTypeName("CLSID")] Guid* pclsid);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSigningStatus(IWICMetadataReaderInfo* This, [NativeTypeName("DWORD")] uint* pStatus);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAuthor(IWICMetadataReaderInfo* This, [NativeTypeName("UINT")] uint cchAuthor, [Optional, NativeTypeName("WCHAR[]")] ushort* wzAuthor, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVendorGUID(IWICMetadataReaderInfo* This, [NativeTypeName("GUID")] Guid* pguidVendor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVersion(IWICMetadataReaderInfo* This, [NativeTypeName("UINT")] uint cchVersion, [Optional, NativeTypeName("WCHAR[]")] ushort* wzVersion, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSpecVersion(IWICMetadataReaderInfo* This, [NativeTypeName("UINT")] uint cchSpecVersion, [Optional, NativeTypeName("WCHAR[]")] ushort* wzSpecVersion, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFriendlyName(IWICMetadataReaderInfo* This, [NativeTypeName("UINT")] uint cchFriendlyName, [Optional, NativeTypeName("WCHAR[]")] ushort* wzFriendlyName, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataFormat(IWICMetadataReaderInfo* This, [NativeTypeName("GUID")] Guid* pguidMetadataFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainerFormats(IWICMetadataReaderInfo* This, [NativeTypeName("UINT")] uint cContainerFormats, [Optional, NativeTypeName("GUID[]")] Guid* pguidContainerFormats, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceManufacturer(IWICMetadataReaderInfo* This, [NativeTypeName("UINT")] uint cchDeviceManufacturer, [Optional, NativeTypeName("WCHAR[]")] ushort* wzDeviceManufacturer, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceModels(IWICMetadataReaderInfo* This, [NativeTypeName("UINT")] uint cchDeviceModels, [Optional, NativeTypeName("WCHAR[]")] ushort* wzDeviceModels, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesRequireFullStream(IWICMetadataReaderInfo* This, [NativeTypeName("BOOL")] int* pfRequiresFullStream);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportPadding(IWICMetadataReaderInfo* This, [NativeTypeName("BOOL")] int* pfSupportsPadding);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesRequireFixedSize(IWICMetadataReaderInfo* This, [NativeTypeName("BOOL")] int* pfFixedSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPatterns(IWICMetadataReaderInfo* This, [NativeTypeName("REFGUID")] Guid* guidContainerFormat, [NativeTypeName("UINT")] uint cbSize, WICMetadataPattern* pPattern = null, [NativeTypeName("UINT")] uint* pcCount = null, [NativeTypeName("UINT")] uint* pcbActual = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MatchesPattern(IWICMetadataReaderInfo* This, [NativeTypeName("REFGUID")] Guid* guidContainerFormat, [Optional] IStream* pIStream, [NativeTypeName("BOOL")] int* pfMatches);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInstance(IWICMetadataReaderInfo* This, IWICMetadataReader** ppIReader = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetComponentType>(lpVtbl->GetComponentType)(This, pType);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID")] Guid* pclsid)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCLSID>(lpVtbl->GetCLSID)(This, pclsid);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD")] uint* pStatus)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSigningStatus>(lpVtbl->GetSigningStatus)(This, pStatus);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [Optional, NativeTypeName("WCHAR[]")] ushort* wzAuthor, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAuthor>(lpVtbl->GetAuthor)(This, cchAuthor, wzAuthor, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID")] Guid* pguidVendor)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVendorGUID>(lpVtbl->GetVendorGUID)(This, pguidVendor);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [Optional, NativeTypeName("WCHAR[]")] ushort* wzVersion, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVersion>(lpVtbl->GetVersion)(This, cchVersion, wzVersion, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [Optional, NativeTypeName("WCHAR[]")] ushort* wzSpecVersion, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSpecVersion>(lpVtbl->GetSpecVersion)(This, cchSpecVersion, wzSpecVersion, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [Optional, NativeTypeName("WCHAR[]")] ushort* wzFriendlyName, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFriendlyName>(lpVtbl->GetFriendlyName)(This, cchFriendlyName, wzFriendlyName, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat([NativeTypeName("GUID")] Guid* pguidMetadataFormat)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetadataFormat>(lpVtbl->GetMetadataFormat)(This, pguidMetadataFormat);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormats([NativeTypeName("UINT")] uint cContainerFormats, [Optional, NativeTypeName("GUID[]")] Guid* pguidContainerFormats, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainerFormats>(lpVtbl->GetContainerFormats)(This, cContainerFormats, pguidContainerFormats, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer([NativeTypeName("UINT")] uint cchDeviceManufacturer, [Optional, NativeTypeName("WCHAR[]")] ushort* wzDeviceManufacturer, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDeviceManufacturer>(lpVtbl->GetDeviceManufacturer)(This, cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels([NativeTypeName("UINT")] uint cchDeviceModels, [Optional, NativeTypeName("WCHAR[]")] ushort* wzDeviceModels, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDeviceModels>(lpVtbl->GetDeviceModels)(This, cchDeviceModels, wzDeviceModels, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFullStream([NativeTypeName("BOOL")] int* pfRequiresFullStream)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesRequireFullStream>(lpVtbl->DoesRequireFullStream)(This, pfRequiresFullStream);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportPadding([NativeTypeName("BOOL")] int* pfSupportsPadding)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportPadding>(lpVtbl->DoesSupportPadding)(This, pfSupportsPadding);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFixedSize([NativeTypeName("BOOL")] int* pfFixedSize)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesRequireFixedSize>(lpVtbl->DoesRequireFixedSize)(This, pfFixedSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPatterns([NativeTypeName("REFGUID")] Guid* guidContainerFormat, [NativeTypeName("UINT")] uint cbSize, WICMetadataPattern* pPattern = null, [NativeTypeName("UINT")] uint* pcCount = null, [NativeTypeName("UINT")] uint* pcbActual = null)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPatterns>(lpVtbl->GetPatterns)(This, guidContainerFormat, cbSize, pPattern, pcCount, pcbActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MatchesPattern([NativeTypeName("REFGUID")] Guid* guidContainerFormat, [Optional] IStream* pIStream, [NativeTypeName("BOOL")] int* pfMatches)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MatchesPattern>(lpVtbl->MatchesPattern)(This, guidContainerFormat, pIStream, pfMatches);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance(IWICMetadataReader** ppIReader = null)
        {
            fixed (IWICMetadataReaderInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateInstance>(lpVtbl->CreateInstance)(This, ppIReader);
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
