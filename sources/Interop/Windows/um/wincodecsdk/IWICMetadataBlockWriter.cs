// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodecsdk.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("08FB9676-B444-41E8-8DBE-6A53A542BFF1")]
    public unsafe struct IWICMetadataBlockWriter
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IWICMetadataBlockWriter* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IWICMetadataBlockWriter* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IWICMetadataBlockWriter* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainerFormat(
            [In] IWICMetadataBlockWriter* This,
            [Out, NativeTypeName("GUID")] Guid* pguidContainerFormat
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCount(
            [In] IWICMetadataBlockWriter* This,
            [Out, NativeTypeName("UINT")] uint* pcCount
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetReaderByIndex(
            [In] IWICMetadataBlockWriter* This,
            [In, NativeTypeName("UINT")] uint nIndex,
            [Out] IWICMetadataReader** ppIMetadataReader = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEnumerator(
            [In] IWICMetadataBlockWriter* This,
            [Out] IEnumUnknown** ppIEnumMetadata = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromBlockReader(
            [In] IWICMetadataBlockWriter* This,
            [In] IWICMetadataBlockReader* pIMDBlockReader = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWriterByIndex(
            [In] IWICMetadataBlockWriter* This,
            [In, NativeTypeName("UINT")] uint nIndex,
            [Out] IWICMetadataWriter** ppIMetadataWriter = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddWriter(
            [In] IWICMetadataBlockWriter* This,
            [In] IWICMetadataWriter* pIMetadataWriter = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetWriterByIndex(
            [In] IWICMetadataBlockWriter* This,
            [In, NativeTypeName("UINT")] uint nIndex,
            [In] IWICMetadataWriter* pIMetadataWriter = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveWriterByIndex(
            [In] IWICMetadataBlockWriter* This,
            [In, NativeTypeName("UINT")] uint nIndex
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICMetadataBlockWriter* This = &this)
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
            fixed (IWICMetadataBlockWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICMetadataBlockWriter* This = &this)
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
            fixed (IWICMetadataBlockWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainerFormat>(lpVtbl->GetContainerFormat)(
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
            fixed (IWICMetadataBlockWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCount>(lpVtbl->GetCount)(
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
            fixed (IWICMetadataBlockWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetReaderByIndex>(lpVtbl->GetReaderByIndex)(
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
            fixed (IWICMetadataBlockWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEnumerator>(lpVtbl->GetEnumerator)(
                    This,
                    ppIEnumMetadata
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromBlockReader(
            [In] IWICMetadataBlockReader* pIMDBlockReader = null
        )
        {
            fixed (IWICMetadataBlockWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InitializeFromBlockReader>(lpVtbl->InitializeFromBlockReader)(
                    This,
                    pIMDBlockReader
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWriterByIndex(
            [In, NativeTypeName("UINT")] uint nIndex,
            [Out] IWICMetadataWriter** ppIMetadataWriter = null
        )
        {
            fixed (IWICMetadataBlockWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetWriterByIndex>(lpVtbl->GetWriterByIndex)(
                    This,
                    nIndex,
                    ppIMetadataWriter
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddWriter(
            [In] IWICMetadataWriter* pIMetadataWriter = null
        )
        {
            fixed (IWICMetadataBlockWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddWriter>(lpVtbl->AddWriter)(
                    This,
                    pIMetadataWriter
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWriterByIndex(
            [In, NativeTypeName("UINT")] uint nIndex,
            [In] IWICMetadataWriter* pIMetadataWriter = null
        )
        {
            fixed (IWICMetadataBlockWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetWriterByIndex>(lpVtbl->SetWriterByIndex)(
                    This,
                    nIndex,
                    pIMetadataWriter
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveWriterByIndex(
            [In, NativeTypeName("UINT")] uint nIndex
        )
        {
            fixed (IWICMetadataBlockWriter* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveWriterByIndex>(lpVtbl->RemoveWriterByIndex)(
                    This,
                    nIndex
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetContainerFormat;

            public IntPtr GetCount;

            public IntPtr GetReaderByIndex;

            public IntPtr GetEnumerator;

            public IntPtr InitializeFromBlockReader;

            public IntPtr GetWriterByIndex;

            public IntPtr AddWriter;

            public IntPtr SetWriterByIndex;

            public IntPtr RemoveWriterByIndex;
        }
    }
}
