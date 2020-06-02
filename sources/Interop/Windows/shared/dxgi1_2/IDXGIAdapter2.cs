// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0AA1AE0A-FA0E-4B84-8644-E05FF8E5ACB5")]
    public unsafe partial struct IDXGIAdapter2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXGIAdapter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXGIAdapter2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXGIAdapter2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((IDXGIAdapter2*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return lpVtbl->SetPrivateDataInterface((IDXGIAdapter2*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((IDXGIAdapter2*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return lpVtbl->GetParent((IDXGIAdapter2*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumOutputs([NativeTypeName("UINT")] uint Output, [NativeTypeName("IDXGIOutput **")] IDXGIOutput** ppOutput)
        {
            return lpVtbl->EnumOutputs((IDXGIAdapter2*)Unsafe.AsPointer(ref this), Output, ppOutput);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("DXGI_ADAPTER_DESC *")] DXGI_ADAPTER_DESC* pDesc)
        {
            return lpVtbl->GetDesc((IDXGIAdapter2*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckInterfaceSupport([NativeTypeName("const GUID &")] Guid* InterfaceName, [NativeTypeName("LARGE_INTEGER *")] LARGE_INTEGER* pUMDVersion)
        {
            return lpVtbl->CheckInterfaceSupport((IDXGIAdapter2*)Unsafe.AsPointer(ref this), InterfaceName, pUMDVersion);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc1([NativeTypeName("DXGI_ADAPTER_DESC1 *")] DXGI_ADAPTER_DESC1* pDesc)
        {
            return lpVtbl->GetDesc1((IDXGIAdapter2*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc2([NativeTypeName("DXGI_ADAPTER_DESC2 *")] DXGI_ADAPTER_DESC2* pDesc)
        {
            return lpVtbl->GetDesc2((IDXGIAdapter2*)Unsafe.AsPointer(ref this), pDesc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIAdapter2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIAdapter2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIAdapter2*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIAdapter2*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIAdapter2*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIAdapter2*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIAdapter2*, Guid*, void**, int> GetParent;

            [NativeTypeName("HRESULT (UINT, IDXGIOutput **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIAdapter2*, uint, IDXGIOutput**, int> EnumOutputs;

            [NativeTypeName("HRESULT (DXGI_ADAPTER_DESC *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIAdapter2*, DXGI_ADAPTER_DESC*, int> GetDesc;

            [NativeTypeName("HRESULT (const GUID &, LARGE_INTEGER *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIAdapter2*, Guid*, LARGE_INTEGER*, int> CheckInterfaceSupport;

            [NativeTypeName("HRESULT (DXGI_ADAPTER_DESC1 *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIAdapter2*, DXGI_ADAPTER_DESC1*, int> GetDesc1;

            [NativeTypeName("HRESULT (DXGI_ADAPTER_DESC2 *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIAdapter2*, DXGI_ADAPTER_DESC2*, int> GetDesc2;
        }
    }
}
