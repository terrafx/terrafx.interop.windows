// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodecsdk.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("FEAA2A8D-B3F3-43E4-B25C-D1DE990A1AE1")]
    public unsafe struct IWICMetadataBlockReader
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICMetadataBlockReader* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICMetadataBlockReader* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICMetadataBlockReader* This
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetContainerFormat(
            [In] IWICMetadataBlockReader* This,
            [Out, NativeTypeName("GUID")] Guid* pguidContainerFormat
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetCount(
            [In] IWICMetadataBlockReader* This,
            [Out, NativeTypeName("UINT")] uint* pcCount
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetReaderByIndex(
            [In] IWICMetadataBlockReader* This,
            [In, NativeTypeName("UINT")] uint nIndex,
            [Out] IWICMetadataReader** ppIMetadataReader = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetEnumerator(
            [In] IWICMetadataBlockReader* This,
            [Out] IEnumUnknown** ppIEnumMetadata = null
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICMetadataBlockReader* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICMetadataBlockReader* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICMetadataBlockReader* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat(
            [Out, NativeTypeName("GUID")] Guid* pguidContainerFormat
        )
        {
            fixed (IWICMetadataBlockReader* This = &this)
            {
                return MarshalFunction<_GetContainerFormat>(lpVtbl->GetContainerFormat)(
                    This,
                    pguidContainerFormat
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount(
            [Out, NativeTypeName("UINT")] uint* pcCount
        )
        {
            fixed (IWICMetadataBlockReader* This = &this)
            {
                return MarshalFunction<_GetCount>(lpVtbl->GetCount)(
                    This,
                    pcCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetReaderByIndex(
            [In, NativeTypeName("UINT")] uint nIndex,
            [Out] IWICMetadataReader** ppIMetadataReader = null
        )
        {
            fixed (IWICMetadataBlockReader* This = &this)
            {
                return MarshalFunction<_GetReaderByIndex>(lpVtbl->GetReaderByIndex)(
                    This,
                    nIndex,
                    ppIMetadataReader
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator(
            [Out] IEnumUnknown** ppIEnumMetadata = null
        )
        {
            fixed (IWICMetadataBlockReader* This = &this)
            {
                return MarshalFunction<_GetEnumerator>(lpVtbl->GetEnumerator)(
                    This,
                    ppIEnumMetadata
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region Fields
            public IntPtr GetContainerFormat;

            public IntPtr GetCount;

            public IntPtr GetReaderByIndex;

            public IntPtr GetEnumerator;
            #endregion
        }
        #endregion
    }
}
