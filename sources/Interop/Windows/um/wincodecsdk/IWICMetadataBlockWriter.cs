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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return lpVtbl->GetContainerFormat((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* pcCount)
        {
            return lpVtbl->GetCount((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pcCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetReaderByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IWICMetadataReader **")] IWICMetadataReader** ppIMetadataReader)
        {
            return lpVtbl->GetReaderByIndex((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator([NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppIEnumMetadata)
        {
            return lpVtbl->GetEnumerator((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromBlockReader([NativeTypeName("IWICMetadataBlockReader *")] IWICMetadataBlockReader* pIMDBlockReader)
        {
            return lpVtbl->InitializeFromBlockReader((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMDBlockReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWriterByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IWICMetadataWriter **")] IWICMetadataWriter** ppIMetadataWriter)
        {
            return lpVtbl->GetWriterByIndex((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddWriter([NativeTypeName("IWICMetadataWriter *")] IWICMetadataWriter* pIMetadataWriter)
        {
            return lpVtbl->AddWriter((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMetadataWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWriterByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IWICMetadataWriter *")] IWICMetadataWriter* pIMetadataWriter)
        {
            return lpVtbl->SetWriterByIndex((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, pIMetadataWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveWriterByIndex([NativeTypeName("UINT")] uint nIndex)
        {
            return lpVtbl->RemoveWriterByIndex((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockWriter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockWriter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockWriter*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockWriter*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockWriter*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (UINT, IWICMetadataReader **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockWriter*, uint, IWICMetadataReader**, int> GetReaderByIndex;

            [NativeTypeName("HRESULT (IEnumUnknown **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockWriter*, IEnumUnknown**, int> GetEnumerator;

            [NativeTypeName("HRESULT (IWICMetadataBlockReader *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockWriter*, IWICMetadataBlockReader*, int> InitializeFromBlockReader;

            [NativeTypeName("HRESULT (UINT, IWICMetadataWriter **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockWriter*, uint, IWICMetadataWriter**, int> GetWriterByIndex;

            [NativeTypeName("HRESULT (IWICMetadataWriter *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockWriter*, IWICMetadataWriter*, int> AddWriter;

            [NativeTypeName("HRESULT (UINT, IWICMetadataWriter *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockWriter*, uint, IWICMetadataWriter*, int> SetWriterByIndex;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockWriter*, uint, int> RemoveWriterByIndex;
        }
    }
}
