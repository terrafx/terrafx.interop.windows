// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("08FB9676-B444-41E8-8DBE-6A53A542BFF1")]
    [NativeTypeName("struct IWICMetadataBlockWriter : IWICMetadataBlockReader")]
    public unsafe partial struct IWICMetadataBlockWriter
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICMetadataBlockWriter*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICMetadataBlockWriter*, uint>)(lpVtbl[1]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICMetadataBlockWriter*, uint>)(lpVtbl[2]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return ((delegate* stdcall<IWICMetadataBlockWriter*, Guid*, int>)(lpVtbl[3]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* pcCount)
        {
            return ((delegate* stdcall<IWICMetadataBlockWriter*, uint*, int>)(lpVtbl[4]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pcCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetReaderByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IWICMetadataReader **")] IWICMetadataReader** ppIMetadataReader)
        {
            return ((delegate* stdcall<IWICMetadataBlockWriter*, uint, IWICMetadataReader**, int>)(lpVtbl[5]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator([NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppIEnumMetadata)
        {
            return ((delegate* stdcall<IWICMetadataBlockWriter*, IEnumUnknown**, int>)(lpVtbl[6]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromBlockReader([NativeTypeName("IWICMetadataBlockReader *")] IWICMetadataBlockReader* pIMDBlockReader)
        {
            return ((delegate* stdcall<IWICMetadataBlockWriter*, IWICMetadataBlockReader*, int>)(lpVtbl[7]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMDBlockReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWriterByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IWICMetadataWriter **")] IWICMetadataWriter** ppIMetadataWriter)
        {
            return ((delegate* stdcall<IWICMetadataBlockWriter*, uint, IWICMetadataWriter**, int>)(lpVtbl[8]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddWriter([NativeTypeName("IWICMetadataWriter *")] IWICMetadataWriter* pIMetadataWriter)
        {
            return ((delegate* stdcall<IWICMetadataBlockWriter*, IWICMetadataWriter*, int>)(lpVtbl[9]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMetadataWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWriterByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IWICMetadataWriter *")] IWICMetadataWriter* pIMetadataWriter)
        {
            return ((delegate* stdcall<IWICMetadataBlockWriter*, uint, IWICMetadataWriter*, int>)(lpVtbl[10]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, pIMetadataWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveWriterByIndex([NativeTypeName("UINT")] uint nIndex)
        {
            return ((delegate* stdcall<IWICMetadataBlockWriter*, uint, int>)(lpVtbl[11]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex);
        }
    }
}
