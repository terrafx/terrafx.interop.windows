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
    public unsafe partial struct IWICMetadataBlockWriter : IWICMetadataBlockWriter.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        public HRESULT GetContainerFormat(Guid* pguidContainerFormat)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, Guid*, int>)(lpVtbl[3]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCount(uint* pcCount)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint*, int>)(lpVtbl[4]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pcCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetReaderByIndex(uint nIndex, IWICMetadataReader** ppIMetadataReader)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint, IWICMetadataReader**, int>)(lpVtbl[5]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetEnumerator(IEnumUnknown** ppIEnumMetadata)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, IEnumUnknown**, int>)(lpVtbl[6]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT InitializeFromBlockReader(IWICMetadataBlockReader* pIMDBlockReader)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, IWICMetadataBlockReader*, int>)(lpVtbl[7]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMDBlockReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetWriterByIndex(uint nIndex, IWICMetadataWriter** ppIMetadataWriter)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint, IWICMetadataWriter**, int>)(lpVtbl[8]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT AddWriter(IWICMetadataWriter* pIMetadataWriter)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, IWICMetadataWriter*, int>)(lpVtbl[9]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMetadataWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetWriterByIndex(uint nIndex, IWICMetadataWriter* pIMetadataWriter)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint, IWICMetadataWriter*, int>)(lpVtbl[10]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, pIMetadataWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT RemoveWriterByIndex(uint nIndex)
        {
            return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint, int>)(lpVtbl[11]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex);
        }

        public interface Interface : IWICMetadataBlockReader.Interface
        {
            [VtblIndex(7)]
            HRESULT InitializeFromBlockReader(IWICMetadataBlockReader* pIMDBlockReader);

            [VtblIndex(8)]
            HRESULT GetWriterByIndex(uint nIndex, IWICMetadataWriter** ppIMetadataWriter);

            [VtblIndex(9)]
            HRESULT AddWriter(IWICMetadataWriter* pIMetadataWriter);

            [VtblIndex(10)]
            HRESULT SetWriterByIndex(uint nIndex, IWICMetadataWriter* pIMetadataWriter);

            [VtblIndex(11)]
            HRESULT RemoveWriterByIndex(uint nIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataBlockWriter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataBlockWriter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataBlockWriter*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataBlockWriter*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataBlockWriter*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (UINT, IWICMetadataReader **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataBlockWriter*, uint, IWICMetadataReader**, int> GetReaderByIndex;

            [NativeTypeName("HRESULT (IEnumUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataBlockWriter*, IEnumUnknown**, int> GetEnumerator;

            [NativeTypeName("HRESULT (IWICMetadataBlockReader *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataBlockWriter*, IWICMetadataBlockReader*, int> InitializeFromBlockReader;

            [NativeTypeName("HRESULT (UINT, IWICMetadataWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataBlockWriter*, uint, IWICMetadataWriter**, int> GetWriterByIndex;

            [NativeTypeName("HRESULT (IWICMetadataWriter *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataBlockWriter*, IWICMetadataWriter*, int> AddWriter;

            [NativeTypeName("HRESULT (UINT, IWICMetadataWriter *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataBlockWriter*, uint, IWICMetadataWriter*, int> SetWriterByIndex;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataBlockWriter*, uint, int> RemoveWriterByIndex;
        }
    }
}
