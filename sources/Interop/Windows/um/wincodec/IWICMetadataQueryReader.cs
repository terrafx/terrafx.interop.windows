// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30989668-E1C9-4597-B395-458EEDB808DF")]
    public unsafe struct IWICMetadataQueryReader
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICMetadataQueryReader* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICMetadataQueryReader* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICMetadataQueryReader* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetContainerFormat(
            [In] IWICMetadataQueryReader* This,
            [Out, NativeTypeName("GUID")] Guid* pguidContainerFormat
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetLocation(
            [In] IWICMetadataQueryReader* This,
            [In, NativeTypeName("UINT")] uint cchMaxLength,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzNamespace,
            [Out, NativeTypeName("UINT")] uint* pcchActualLength
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMetadataByName(
            [In] IWICMetadataQueryReader* This,
            [In, NativeTypeName("LPCWSTR")] char* wzName,
            [In, Out] PROPVARIANT* pvarValue = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetEnumerator(
            [In] IWICMetadataQueryReader* This,
            [Out] IEnumString** ppIEnumString = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICMetadataQueryReader* This = &this)
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
            fixed (IWICMetadataQueryReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICMetadataQueryReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat(
            [Out, NativeTypeName("GUID")] Guid* pguidContainerFormat
        )
        {
            fixed (IWICMetadataQueryReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainerFormat>(lpVtbl->GetContainerFormat)(
                    This,
                    pguidContainerFormat
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocation(
            [In, NativeTypeName("UINT")] uint cchMaxLength,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzNamespace,
            [Out, NativeTypeName("UINT")] uint* pcchActualLength
        )
        {
            fixed (IWICMetadataQueryReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocation>(lpVtbl->GetLocation)(
                    This,
                    cchMaxLength,
                    wzNamespace,
                    pcchActualLength
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataByName(
            [In, NativeTypeName("LPCWSTR")] char* wzName,
            [In, Out] PROPVARIANT* pvarValue = null
        )
        {
            fixed (IWICMetadataQueryReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMetadataByName>(lpVtbl->GetMetadataByName)(
                    This,
                    wzName,
                    pvarValue
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator(
            [Out] IEnumString** ppIEnumString = null
        )
        {
            fixed (IWICMetadataQueryReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEnumerator>(lpVtbl->GetEnumerator)(
                    This,
                    ppIEnumString
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetContainerFormat;

            public IntPtr GetLocation;

            public IntPtr GetMetadataByName;

            public IntPtr GetEnumerator;
        }
    }
}
