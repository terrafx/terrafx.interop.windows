// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodecsdk.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FEAA2A8D-B3F3-43E4-B25C-D1DE990A1AE1")]
    public unsafe partial struct IWICMetadataBlockReader
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICMetadataBlockReader* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICMetadataBlockReader* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICMetadataBlockReader* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainerFormat(IWICMetadataBlockReader* This, [NativeTypeName("GUID")] Guid* pguidContainerFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCount(IWICMetadataBlockReader* This, [NativeTypeName("UINT")] uint* pcCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetReaderByIndex(IWICMetadataBlockReader* This, [NativeTypeName("UINT")] uint nIndex, IWICMetadataReader** ppIMetadataReader = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEnumerator(IWICMetadataBlockReader* This, IEnumUnknown** ppIEnumMetadata = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICMetadataBlockReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICMetadataBlockReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICMetadataBlockReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID")] Guid* pguidContainerFormat)
        {
            fixed (IWICMetadataBlockReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetContainerFormat>(lpVtbl->GetContainerFormat)(This, pguidContainerFormat);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT")] uint* pcCount)
        {
            fixed (IWICMetadataBlockReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCount>(lpVtbl->GetCount)(This, pcCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetReaderByIndex([NativeTypeName("UINT")] uint nIndex, IWICMetadataReader** ppIMetadataReader = null)
        {
            fixed (IWICMetadataBlockReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetReaderByIndex>(lpVtbl->GetReaderByIndex)(This, nIndex, ppIMetadataReader);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator(IEnumUnknown** ppIEnumMetadata = null)
        {
            fixed (IWICMetadataBlockReader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEnumerator>(lpVtbl->GetEnumerator)(This, ppIEnumMetadata);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetContainerFormat;

            public IntPtr GetCount;

            public IntPtr GetReaderByIndex;

            public IntPtr GetEnumerator;
        }
    }
}
