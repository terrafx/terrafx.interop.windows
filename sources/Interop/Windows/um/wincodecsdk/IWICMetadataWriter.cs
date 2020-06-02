// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F7836E16-3BE0-470B-86BB-160D0AECD7DE")]
    public unsafe partial struct IWICMetadataWriter
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICMetadataWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICMetadataWriter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICMetadataWriter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat([NativeTypeName("GUID *")] Guid* pguidMetadataFormat)
        {
            return lpVtbl->GetMetadataFormat((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataHandlerInfo([NativeTypeName("IWICMetadataHandlerInfo **")] IWICMetadataHandlerInfo** ppIHandler)
        {
            return lpVtbl->GetMetadataHandlerInfo((IWICMetadataWriter*)Unsafe.AsPointer(ref this), ppIHandler);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* pcCount)
        {
            return lpVtbl->GetCount((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pcCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValueByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return lpVtbl->GetValueByIndex((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return lpVtbl->GetValue((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator([NativeTypeName("IWICEnumMetadataItem **")] IWICEnumMetadataItem** ppIEnumMetadata)
        {
            return lpVtbl->GetEnumerator((IWICMetadataWriter*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return lpVtbl->SetValue((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetValueByIndex([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return lpVtbl->SetValueByIndex((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId)
        {
            return lpVtbl->RemoveValue((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveValueByIndex([NativeTypeName("UINT")] uint nIndex)
        {
            return lpVtbl->RemoveValueByIndex((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriter*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriter*, Guid*, int> GetMetadataFormat;

            [NativeTypeName("HRESULT (IWICMetadataHandlerInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriter*, IWICMetadataHandlerInfo**, int> GetMetadataHandlerInfo;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriter*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (UINT, PROPVARIANT *, PROPVARIANT *, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriter*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> GetValueByIndex;

            [NativeTypeName("HRESULT (const PROPVARIANT *, const PROPVARIANT *, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriter*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> GetValue;

            [NativeTypeName("HRESULT (IWICEnumMetadataItem **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriter*, IWICEnumMetadataItem**, int> GetEnumerator;

            [NativeTypeName("HRESULT (const PROPVARIANT *, const PROPVARIANT *, const PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriter*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> SetValue;

            [NativeTypeName("HRESULT (UINT, const PROPVARIANT *, const PROPVARIANT *, const PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriter*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> SetValueByIndex;

            [NativeTypeName("HRESULT (const PROPVARIANT *, const PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriter*, PROPVARIANT*, PROPVARIANT*, int> RemoveValue;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriter*, uint, int> RemoveValueByIndex;
        }
    }
}
