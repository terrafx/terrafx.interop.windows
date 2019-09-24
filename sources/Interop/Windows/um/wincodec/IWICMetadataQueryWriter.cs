// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("A721791A-0DEF-4D06-BD91-2118BF1DB10B")]
    public unsafe struct IWICMetadataQueryWriter
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICMetadataQueryWriter* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICMetadataQueryWriter* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICMetadataQueryWriter* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetContainerFormat(
            [In] IWICMetadataQueryWriter* This,
            [Out, NativeTypeName("GUID")] Guid* pguidContainerFormat
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetLocation(
            [In] IWICMetadataQueryWriter* This,
            [In, NativeTypeName("UINT")] uint cchMaxLength,
            [In, Out, Optional, NativeTypeName("WCHAR[]")] char* wzNamespace,
            [Out, NativeTypeName("UINT")] uint* pcchActualLength
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMetadataByName(
            [In] IWICMetadataQueryWriter* This,
            [In, NativeTypeName("LPCWSTR")] char* wzName,
            [In, Out] PROPVARIANT* pvarValue = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetEnumerator(
            [In] IWICMetadataQueryWriter* This,
            [Out] IEnumString** ppIEnumString = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetMetadataByName(
            [In] IWICMetadataQueryWriter* This,
            [In, NativeTypeName("LPCWSTR")] char* wzName,
            [In] PROPVARIANT* pvarValue
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RemoveMetadataByName(
            [In] IWICMetadataQueryWriter* This,
            [In, NativeTypeName("LPCWSTR")] char* wzName
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICMetadataQueryWriter* This = &this)
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
            fixed (IWICMetadataQueryWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICMetadataQueryWriter* This = &this)
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
            fixed (IWICMetadataQueryWriter* This = &this)
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
            fixed (IWICMetadataQueryWriter* This = &this)
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
            fixed (IWICMetadataQueryWriter* This = &this)
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
            fixed (IWICMetadataQueryWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEnumerator>(lpVtbl->GetEnumerator)(
                    This,
                    ppIEnumString
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMetadataByName(
            [In, NativeTypeName("LPCWSTR")] char* wzName,
            [In] PROPVARIANT* pvarValue
        )
        {
            fixed (IWICMetadataQueryWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetMetadataByName>(lpVtbl->SetMetadataByName)(
                    This,
                    wzName,
                    pvarValue
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveMetadataByName(
            [In, NativeTypeName("LPCWSTR")] char* wzName
        )
        {
            fixed (IWICMetadataQueryWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveMetadataByName>(lpVtbl->RemoveMetadataByName)(
                    This,
                    wzName
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

            public IntPtr SetMetadataByName;

            public IntPtr RemoveMetadataByName;
        }
    }
}
