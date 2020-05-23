// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("08FB9676-B444-41E8-8DBE-6A53A542BFF1")]
    public unsafe partial struct IWICMetadataBlockWriter
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICMetadataBlockWriter* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICMetadataBlockWriter* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICMetadataBlockWriter* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainerFormat(IWICMetadataBlockWriter* pThis, [NativeTypeName("GUID *")] Guid* pguidContainerFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCount(IWICMetadataBlockWriter* pThis, [NativeTypeName("UINT *")] uint* pcCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetReaderByIndex(IWICMetadataBlockWriter* pThis, [NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IWICMetadataReader **")] IWICMetadataReader** ppIMetadataReader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEnumerator(IWICMetadataBlockWriter* pThis, [NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppIEnumMetadata);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromBlockReader(IWICMetadataBlockWriter* pThis, [NativeTypeName("IWICMetadataBlockReader *")] IWICMetadataBlockReader* pIMDBlockReader);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWriterByIndex(IWICMetadataBlockWriter* pThis, [NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IWICMetadataWriter **")] IWICMetadataWriter** ppIMetadataWriter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddWriter(IWICMetadataBlockWriter* pThis, [NativeTypeName("IWICMetadataWriter *")] IWICMetadataWriter* pIMetadataWriter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetWriterByIndex(IWICMetadataBlockWriter* pThis, [NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IWICMetadataWriter *")] IWICMetadataWriter* pIMetadataWriter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveWriterByIndex(IWICMetadataBlockWriter* pThis, [NativeTypeName("UINT")] uint nIndex);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetContainerFormat>(lpVtbl->GetContainerFormat)((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* pcCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCount>(lpVtbl->GetCount)((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pcCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetReaderByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IWICMetadataReader **")] IWICMetadataReader** ppIMetadataReader)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetReaderByIndex>(lpVtbl->GetReaderByIndex)((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator([NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppIEnumMetadata)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEnumerator>(lpVtbl->GetEnumerator)((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromBlockReader([NativeTypeName("IWICMetadataBlockReader *")] IWICMetadataBlockReader* pIMDBlockReader)
        {
            return Marshal.GetDelegateForFunctionPointer<_InitializeFromBlockReader>(lpVtbl->InitializeFromBlockReader)((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMDBlockReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWriterByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IWICMetadataWriter **")] IWICMetadataWriter** ppIMetadataWriter)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWriterByIndex>(lpVtbl->GetWriterByIndex)((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddWriter([NativeTypeName("IWICMetadataWriter *")] IWICMetadataWriter* pIMetadataWriter)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddWriter>(lpVtbl->AddWriter)((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMetadataWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWriterByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IWICMetadataWriter *")] IWICMetadataWriter* pIMetadataWriter)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetWriterByIndex>(lpVtbl->SetWriterByIndex)((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, pIMetadataWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveWriterByIndex([NativeTypeName("UINT")] uint nIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_RemoveWriterByIndex>(lpVtbl->RemoveWriterByIndex)((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public IntPtr GetContainerFormat;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public IntPtr GetCount;

            [NativeTypeName("HRESULT (UINT, IWICMetadataReader **) __attribute__((stdcall))")]
            public IntPtr GetReaderByIndex;

            [NativeTypeName("HRESULT (IEnumUnknown **) __attribute__((stdcall))")]
            public IntPtr GetEnumerator;

            [NativeTypeName("HRESULT (IWICMetadataBlockReader *) __attribute__((stdcall))")]
            public IntPtr InitializeFromBlockReader;

            [NativeTypeName("HRESULT (UINT, IWICMetadataWriter **) __attribute__((stdcall))")]
            public IntPtr GetWriterByIndex;

            [NativeTypeName("HRESULT (IWICMetadataWriter *) __attribute__((stdcall))")]
            public IntPtr AddWriter;

            [NativeTypeName("HRESULT (UINT, IWICMetadataWriter *) __attribute__((stdcall))")]
            public IntPtr SetWriterByIndex;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr RemoveWriterByIndex;
        }
    }
}
