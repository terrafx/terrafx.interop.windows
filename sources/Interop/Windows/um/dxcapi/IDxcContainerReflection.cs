// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("d2c21b26-8350-4bdc-976a-331ce6f4c54c")]
    public unsafe partial struct IDxcContainerReflection
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDxcContainerReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDxcContainerReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDxcContainerReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IDxcBlob *")] IDxcBlob* pContainer)
        {
            return lpVtbl->Load((IDxcContainerReflection*)Unsafe.AsPointer(ref this), pContainer);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPartCount([NativeTypeName("UINT32 *")] uint* pResult)
        {
            return lpVtbl->GetPartCount((IDxcContainerReflection*)Unsafe.AsPointer(ref this), pResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPartKind([NativeTypeName("UINT32")] uint idx, [NativeTypeName("UINT32 *")] uint* pResult)
        {
            return lpVtbl->GetPartKind((IDxcContainerReflection*)Unsafe.AsPointer(ref this), idx, pResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPartContent([NativeTypeName("UINT32")] uint idx, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppResult)
        {
            return lpVtbl->GetPartContent((IDxcContainerReflection*)Unsafe.AsPointer(ref this), idx, ppResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindFirstPartKind([NativeTypeName("UINT32")] uint kind, [NativeTypeName("UINT32 *")] uint* pResult)
        {
            return lpVtbl->FindFirstPartKind((IDxcContainerReflection*)Unsafe.AsPointer(ref this), kind, pResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPartReflection([NativeTypeName("UINT32")] uint idx, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->GetPartReflection((IDxcContainerReflection*)Unsafe.AsPointer(ref this), idx, iid, ppvObject);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcContainerReflection*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcContainerReflection*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcContainerReflection*, uint> Release;

            [NativeTypeName("HRESULT (IDxcBlob *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcContainerReflection*, IDxcBlob*, int> Load;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcContainerReflection*, uint*, int> GetPartCount;

            [NativeTypeName("HRESULT (UINT32, UINT32 *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcContainerReflection*, uint, uint*, int> GetPartKind;

            [NativeTypeName("HRESULT (UINT32, IDxcBlob **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcContainerReflection*, uint, IDxcBlob**, int> GetPartContent;

            [NativeTypeName("HRESULT (UINT32, UINT32 *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcContainerReflection*, uint, uint*, int> FindFirstPartKind;

            [NativeTypeName("HRESULT (UINT32, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcContainerReflection*, uint, Guid*, void**, int> GetPartReflection;
        }
    }
}
