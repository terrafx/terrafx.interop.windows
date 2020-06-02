// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FEAA2A8D-B3F3-43E4-B25C-D1DE990A1AE1")]
    public unsafe partial struct IWICMetadataBlockReader
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return lpVtbl->GetContainerFormat((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* pcCount)
        {
            return lpVtbl->GetCount((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), pcCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetReaderByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IWICMetadataReader **")] IWICMetadataReader** ppIMetadataReader)
        {
            return lpVtbl->GetReaderByIndex((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator([NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppIEnumMetadata)
        {
            return lpVtbl->GetEnumerator((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockReader*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockReader*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockReader*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockReader*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockReader*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (UINT, IWICMetadataReader **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockReader*, uint, IWICMetadataReader**, int> GetReaderByIndex;

            [NativeTypeName("HRESULT (IEnumUnknown **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataBlockReader*, IEnumUnknown**, int> GetEnumerator;
        }
    }
}
