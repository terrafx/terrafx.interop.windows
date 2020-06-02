// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("48570B85-D1EE-4FCD-A250-EB350722B037")]
    public unsafe partial struct ID3D11Buffer
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D11Buffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D11Buffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D11Buffer*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            lpVtbl->GetDevice((ID3D11Buffer*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((ID3D11Buffer*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((ID3D11Buffer*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return lpVtbl->SetPrivateDataInterface((ID3D11Buffer*)Unsafe.AsPointer(ref this), guid, pData);
        }

        public void GetType([NativeTypeName("D3D11_RESOURCE_DIMENSION *")] D3D11_RESOURCE_DIMENSION* pResourceDimension)
        {
            lpVtbl->GetType((ID3D11Buffer*)Unsafe.AsPointer(ref this), pResourceDimension);
        }

        public void SetEvictionPriority([NativeTypeName("UINT")] uint EvictionPriority)
        {
            lpVtbl->SetEvictionPriority((ID3D11Buffer*)Unsafe.AsPointer(ref this), EvictionPriority);
        }

        [return: NativeTypeName("UINT")]
        public uint GetEvictionPriority()
        {
            return lpVtbl->GetEvictionPriority((ID3D11Buffer*)Unsafe.AsPointer(ref this));
        }

        public void GetDesc([NativeTypeName("D3D11_BUFFER_DESC *")] D3D11_BUFFER_DESC* pDesc)
        {
            lpVtbl->GetDesc((ID3D11Buffer*)Unsafe.AsPointer(ref this), pDesc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Buffer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Buffer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Buffer*, uint> Release;

            [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Buffer*, ID3D11Device**, void> GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Buffer*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Buffer*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Buffer*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("void (D3D11_RESOURCE_DIMENSION *) __attribute__((stdcall))")]
            public new delegate* stdcall<ID3D11Buffer*, D3D11_RESOURCE_DIMENSION*, void> GetType;

            [NativeTypeName("void (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Buffer*, uint, void> SetEvictionPriority;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Buffer*, uint> GetEvictionPriority;

            [NativeTypeName("void (D3D11_BUFFER_DESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Buffer*, D3D11_BUFFER_DESC*, void> GetDesc;
        }
    }
}
