// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("08FB9676-B444-41E8-8DBE-6A53A542BFF1")]
    [NativeTypeName("struct IWICMetadataBlockWriter : IWICMetadataBlockReader")]
    [NativeInheritance("IWICMetadataBlockReader")]
    public unsafe partial struct IWICMetadataBlockWriter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint>)(lpVtbl[1]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint>)(lpVtbl[2]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, Guid*, int>)(lpVtbl[3]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* pcCount)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint*, int>)(lpVtbl[4]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pcCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetReaderByIndex([NativeTypeName("UINT")] uint nIndex, IWICMetadataReader** ppIMetadataReader)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint, IWICMetadataReader**, int>)(lpVtbl[5]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator(IEnumUnknown** ppIEnumMetadata)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, IEnumUnknown**, int>)(lpVtbl[6]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromBlockReader(IWICMetadataBlockReader* pIMDBlockReader)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, IWICMetadataBlockReader*, int>)(lpVtbl[7]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMDBlockReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetWriterByIndex([NativeTypeName("UINT")] uint nIndex, IWICMetadataWriter** ppIMetadataWriter)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint, IWICMetadataWriter**, int>)(lpVtbl[8]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int AddWriter(IWICMetadataWriter* pIMetadataWriter)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, IWICMetadataWriter*, int>)(lpVtbl[9]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMetadataWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetWriterByIndex([NativeTypeName("UINT")] uint nIndex, IWICMetadataWriter* pIMetadataWriter)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint, IWICMetadataWriter*, int>)(lpVtbl[10]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, pIMetadataWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveWriterByIndex([NativeTypeName("UINT")] uint nIndex)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint, int>)(lpVtbl[11]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex);
        }
    }
}
