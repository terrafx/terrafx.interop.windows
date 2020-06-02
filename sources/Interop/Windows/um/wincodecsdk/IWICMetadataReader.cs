// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9204FE99-D8FC-4FD5-A001-9536B067A899")]
    public unsafe partial struct IWICMetadataReader
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICMetadataReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICMetadataReader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICMetadataReader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat([NativeTypeName("GUID *")] Guid* pguidMetadataFormat)
        {
            return lpVtbl->GetMetadataFormat((IWICMetadataReader*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataHandlerInfo([NativeTypeName("IWICMetadataHandlerInfo **")] IWICMetadataHandlerInfo** ppIHandler)
        {
            return lpVtbl->GetMetadataHandlerInfo((IWICMetadataReader*)Unsafe.AsPointer(ref this), ppIHandler);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* pcCount)
        {
            return lpVtbl->GetCount((IWICMetadataReader*)Unsafe.AsPointer(ref this), pcCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValueByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return lpVtbl->GetValueByIndex((IWICMetadataReader*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return lpVtbl->GetValue((IWICMetadataReader*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator([NativeTypeName("IWICEnumMetadataItem **")] IWICEnumMetadataItem** ppIEnumMetadata)
        {
            return lpVtbl->GetEnumerator((IWICMetadataReader*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataReader*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataReader*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataReader*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataReader*, Guid*, int> GetMetadataFormat;

            [NativeTypeName("HRESULT (IWICMetadataHandlerInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataReader*, IWICMetadataHandlerInfo**, int> GetMetadataHandlerInfo;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataReader*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (UINT, PROPVARIANT *, PROPVARIANT *, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataReader*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> GetValueByIndex;

            [NativeTypeName("HRESULT (const PROPVARIANT *, const PROPVARIANT *, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataReader*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> GetValue;

            [NativeTypeName("HRESULT (IWICEnumMetadataItem **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataReader*, IWICEnumMetadataItem**, int> GetEnumerator;
        }
    }
}
