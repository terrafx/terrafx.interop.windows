// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodecsdk.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ABA958BF-C672-44D1-8D61-CE6DF2E682C2")]
    public unsafe struct IWICMetadataHandlerInfo
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICMetadataHandlerInfo* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICMetadataHandlerInfo* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICMetadataHandlerInfo* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetComponentType(IWICMetadataHandlerInfo* This, WICComponentType* pType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCLSID(IWICMetadataHandlerInfo* This, [NativeTypeName("CLSID")] Guid* pclsid);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSigningStatus(IWICMetadataHandlerInfo* This, [NativeTypeName("DWORD")] uint* pStatus);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAuthor(IWICMetadataHandlerInfo* This, [NativeTypeName("UINT")] uint cchAuthor, [Optional, NativeTypeName("WCHAR[]")] ushort* wzAuthor, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVendorGUID(IWICMetadataHandlerInfo* This, [NativeTypeName("GUID")] Guid* pguidVendor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVersion(IWICMetadataHandlerInfo* This, [NativeTypeName("UINT")] uint cchVersion, [Optional, NativeTypeName("WCHAR[]")] ushort* wzVersion, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSpecVersion(IWICMetadataHandlerInfo* This, [NativeTypeName("UINT")] uint cchSpecVersion, [Optional, NativeTypeName("WCHAR[]")] ushort* wzSpecVersion, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFriendlyName(IWICMetadataHandlerInfo* This, [NativeTypeName("UINT")] uint cchFriendlyName, [Optional, NativeTypeName("WCHAR[]")] ushort* wzFriendlyName, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataFormat(IWICMetadataHandlerInfo* This, [NativeTypeName("GUID")] Guid* pguidMetadataFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainerFormats(IWICMetadataHandlerInfo* This, [NativeTypeName("UINT")] uint cContainerFormats, [Optional, NativeTypeName("GUID[]")] Guid* pguidContainerFormats, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceManufacturer(IWICMetadataHandlerInfo* This, [NativeTypeName("UINT")] uint cchDeviceManufacturer, [Optional, NativeTypeName("WCHAR[]")] ushort* wzDeviceManufacturer, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceModels(IWICMetadataHandlerInfo* This, [NativeTypeName("UINT")] uint cchDeviceModels, [Optional, NativeTypeName("WCHAR[]")] ushort* wzDeviceModels, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesRequireFullStream(IWICMetadataHandlerInfo* This, [NativeTypeName("BOOL")] int* pfRequiresFullStream);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportPadding(IWICMetadataHandlerInfo* This, [NativeTypeName("BOOL")] int* pfSupportsPadding);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesRequireFixedSize(IWICMetadataHandlerInfo* This, [NativeTypeName("BOOL")] int* pfFixedSize);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetComponentType>(lpVtbl->GetComponentType)(This, pType);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID")] Guid* pclsid)
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCLSID>(lpVtbl->GetCLSID)(This, pclsid);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD")] uint* pStatus)
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSigningStatus>(lpVtbl->GetSigningStatus)(This, pStatus);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [Optional, NativeTypeName("WCHAR[]")] ushort* wzAuthor, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAuthor>(lpVtbl->GetAuthor)(This, cchAuthor, wzAuthor, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID")] Guid* pguidVendor)
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVendorGUID>(lpVtbl->GetVendorGUID)(This, pguidVendor);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [Optional, NativeTypeName("WCHAR[]")] ushort* wzVersion, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVersion>(lpVtbl->GetVersion)(This, cchVersion, wzVersion, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [Optional, NativeTypeName("WCHAR[]")] ushort* wzSpecVersion, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSpecVersion>(lpVtbl->GetSpecVersion)(This, cchSpecVersion, wzSpecVersion, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [Optional, NativeTypeName("WCHAR[]")] ushort* wzFriendlyName, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFriendlyName>(lpVtbl->GetFriendlyName)(This, cchFriendlyName, wzFriendlyName, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat([NativeTypeName("GUID")] Guid* pguidMetadataFormat)
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetadataFormat>(lpVtbl->GetMetadataFormat)(This, pguidMetadataFormat);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormats([NativeTypeName("UINT")] uint cContainerFormats, [Optional, NativeTypeName("GUID[]")] Guid* pguidContainerFormats, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainerFormats>(lpVtbl->GetContainerFormats)(This, cContainerFormats, pguidContainerFormats, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer([NativeTypeName("UINT")] uint cchDeviceManufacturer, [Optional, NativeTypeName("WCHAR[]")] ushort* wzDeviceManufacturer, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDeviceManufacturer>(lpVtbl->GetDeviceManufacturer)(This, cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels([NativeTypeName("UINT")] uint cchDeviceModels, [Optional, NativeTypeName("WCHAR[]")] ushort* wzDeviceModels, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDeviceModels>(lpVtbl->GetDeviceModels)(This, cchDeviceModels, wzDeviceModels, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFullStream([NativeTypeName("BOOL")] int* pfRequiresFullStream)
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesRequireFullStream>(lpVtbl->DoesRequireFullStream)(This, pfRequiresFullStream);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportPadding([NativeTypeName("BOOL")] int* pfSupportsPadding)
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportPadding>(lpVtbl->DoesSupportPadding)(This, pfSupportsPadding);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFixedSize([NativeTypeName("BOOL")] int* pfFixedSize)
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesRequireFixedSize>(lpVtbl->DoesRequireFixedSize)(This, pfFixedSize);
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
        }
    }
}
