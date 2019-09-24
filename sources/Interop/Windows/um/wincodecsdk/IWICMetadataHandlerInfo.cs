// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodecsdk.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("ABA958BF-C672-44D1-8D61-CE6DF2E682C2")]
    public unsafe struct IWICMetadataHandlerInfo
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICMetadataHandlerInfo* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICMetadataHandlerInfo* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICMetadataHandlerInfo* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetComponentType(
            [In] IWICMetadataHandlerInfo* This,
            [Out] WICComponentType* pType
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetCLSID(
            [In] IWICMetadataHandlerInfo* This,
            [Out, NativeTypeName("CLSID")] Guid* pclsid
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSigningStatus(
            [In] IWICMetadataHandlerInfo* This,
            [Out, NativeTypeName("DWORD")] uint* pStatus
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetAuthor(
            [In] IWICMetadataHandlerInfo* This,
            [In, NativeTypeName("UINT")] uint cchAuthor,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzAuthor,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetVendorGUID(
            [In] IWICMetadataHandlerInfo* This,
            [Out, NativeTypeName("GUID")] Guid* pguidVendor
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetVersion(
            [In] IWICMetadataHandlerInfo* This,
            [In, NativeTypeName("UINT")] uint cchVersion,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzVersion,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSpecVersion(
            [In] IWICMetadataHandlerInfo* This,
            [In, NativeTypeName("UINT")] uint cchSpecVersion,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzSpecVersion,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFriendlyName(
            [In] IWICMetadataHandlerInfo* This,
            [In, NativeTypeName("UINT")] uint cchFriendlyName,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzFriendlyName,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMetadataFormat(
            [In] IWICMetadataHandlerInfo* This,
            [Out, NativeTypeName("GUID")] Guid* pguidMetadataFormat
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetContainerFormats(
            [In] IWICMetadataHandlerInfo* This,
            [In, NativeTypeName("UINT")] uint cContainerFormats,
            [In, Out, Optional, NativeTypeName("GUID[]")] Guid* pguidContainerFormats,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDeviceManufacturer(
            [In] IWICMetadataHandlerInfo* This,
            [In, NativeTypeName("UINT")] uint cchDeviceManufacturer,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzDeviceManufacturer,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDeviceModels(
            [In] IWICMetadataHandlerInfo* This,
            [In, NativeTypeName("UINT")] uint cchDeviceModels,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzDeviceModels,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DoesRequireFullStream(
            [In] IWICMetadataHandlerInfo* This,
            [Out, NativeTypeName("BOOL")] int* pfRequiresFullStream
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DoesSupportPadding(
            [In] IWICMetadataHandlerInfo* This,
            [Out, NativeTypeName("BOOL")] int* pfSupportsPadding
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DoesRequireFixedSize(
            [In] IWICMetadataHandlerInfo* This,
            [Out, NativeTypeName("BOOL")] int* pfFixedSize
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
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
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICMetadataHandlerInfo* This = &this)
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
            fixed (IWICMetadataHandlerInfo* This = &this)
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
            fixed (IWICMetadataHandlerInfo* This = &this)
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
            fixed (IWICMetadataHandlerInfo* This = &this)
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
            fixed (IWICMetadataHandlerInfo* This = &this)
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
            fixed (IWICMetadataHandlerInfo* This = &this)
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
            fixed (IWICMetadataHandlerInfo* This = &this)
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
            fixed (IWICMetadataHandlerInfo* This = &this)
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
            fixed (IWICMetadataHandlerInfo* This = &this)
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
            fixed (IWICMetadataHandlerInfo* This = &this)
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
            fixed (IWICMetadataHandlerInfo* This = &this)
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
            fixed (IWICMetadataHandlerInfo* This = &this)
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
            fixed (IWICMetadataHandlerInfo* This = &this)
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
            fixed (IWICMetadataHandlerInfo* This = &this)
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
            fixed (IWICMetadataHandlerInfo* This = &this)
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
            fixed (IWICMetadataHandlerInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesRequireFixedSize>(lpVtbl->DoesRequireFixedSize)(
                    This,
                    pfFixedSize
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
        }
    }
}
