// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("334b1f50-2292-4b35-99a1-25588d8c17fe")]
    public unsafe partial struct IDxcContainerBuilder
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDxcContainerBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDxcContainerBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IDxcBlob *")] IDxcBlob* pDxilContainerHeader)
        {
            return lpVtbl->Load((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), pDxilContainerHeader);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddPart([NativeTypeName("UINT32")] uint fourCC, [NativeTypeName("IDxcBlob *")] IDxcBlob* pSource)
        {
            return lpVtbl->AddPart((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), fourCC, pSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemovePart([NativeTypeName("UINT32")] uint fourCC)
        {
            return lpVtbl->RemovePart((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), fourCC);
        }

        [return: NativeTypeName("HRESULT")]
        public int SerializeContainer([NativeTypeName("IDxcOperationResult **")] IDxcOperationResult** ppResult)
        {
            return lpVtbl->SerializeContainer((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), ppResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcContainerBuilder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcContainerBuilder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcContainerBuilder*, uint> Release;

            [NativeTypeName("HRESULT (IDxcBlob *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcContainerBuilder*, IDxcBlob*, int> Load;

            [NativeTypeName("HRESULT (UINT32, IDxcBlob *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcContainerBuilder*, uint, IDxcBlob*, int> AddPart;

            [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcContainerBuilder*, uint, int> RemovePart;

            [NativeTypeName("HRESULT (IDxcOperationResult **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcContainerBuilder*, IDxcOperationResult**, int> SerializeContainer;
        }
    }
}
