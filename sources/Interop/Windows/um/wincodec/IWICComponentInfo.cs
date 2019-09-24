// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("23BC3F0A-698B-4357-886B-F24D50671334")]
    public unsafe struct IWICComponentInfo
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICComponentInfo* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICComponentInfo* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICComponentInfo* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetComponentType(
            [In] IWICComponentInfo* This,
            [Out] WICComponentType* pType
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetCLSID(
            [In] IWICComponentInfo* This,
            [Out, NativeTypeName("CLSID")] Guid* pclsid
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSigningStatus(
            [In] IWICComponentInfo* This,
            [Out, NativeTypeName("DWORD")] uint* pStatus
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetAuthor(
            [In] IWICComponentInfo* This,
            [In, NativeTypeName("UINT")] uint cchAuthor,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzAuthor,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetVendorGUID(
            [In] IWICComponentInfo* This,
            [Out, NativeTypeName("GUID")] Guid* pguidVendor
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetVersion(
            [In] IWICComponentInfo* This,
            [In, NativeTypeName("UINT")] uint cchVersion,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzVersion,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSpecVersion(
            [In] IWICComponentInfo* This,
            [In, NativeTypeName("UINT")] uint cchSpecVersion,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzSpecVersion,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFriendlyName(
            [In] IWICComponentInfo* This,
            [In, NativeTypeName("UINT")] uint cchFriendlyName,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzFriendlyName,
            [Out, NativeTypeName("UINT")] uint* pcchActual
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICComponentInfo* This = &this)
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
            fixed (IWICComponentInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICComponentInfo* This = &this)
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
            fixed (IWICComponentInfo* This = &this)
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
            fixed (IWICComponentInfo* This = &this)
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
            fixed (IWICComponentInfo* This = &this)
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
            fixed (IWICComponentInfo* This = &this)
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
            fixed (IWICComponentInfo* This = &this)
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
            fixed (IWICComponentInfo* This = &this)
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
            fixed (IWICComponentInfo* This = &this)
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
            fixed (IWICComponentInfo* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFriendlyName>(lpVtbl->GetFriendlyName)(
                    This,
                    cchFriendlyName,
                    wzFriendlyName,
                    pcchActual
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
        }
    }
}
