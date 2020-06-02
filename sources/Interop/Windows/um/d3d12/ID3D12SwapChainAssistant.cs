// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F1DF64B6-57FD-49CD-8807-C0EB88B45C8F")]
    public unsafe partial struct ID3D12SwapChainAssistant
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
        }

        public LUID GetLUID()
        {
            LUID result;
            return *lpVtbl->GetLUID((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSwapChainObject([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return lpVtbl->GetSwapChainObject((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentResourceAndCommandQueue([NativeTypeName("const IID &")] Guid* riidResource, [NativeTypeName("void **")] void** ppvResource, [NativeTypeName("const IID &")] Guid* riidQueue, [NativeTypeName("void **")] void** ppvQueue)
        {
            return lpVtbl->GetCurrentResourceAndCommandQueue((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riidResource, ppvResource, riidQueue, ppvQueue);
        }

        [return: NativeTypeName("HRESULT")]
        public int InsertImplicitSync()
        {
            return lpVtbl->InsertImplicitSync((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12SwapChainAssistant*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12SwapChainAssistant*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12SwapChainAssistant*, uint> Release;

            [NativeTypeName("LUID () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12SwapChainAssistant*, LUID*, LUID*> GetLUID;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12SwapChainAssistant*, Guid*, void**, int> GetSwapChainObject;

            [NativeTypeName("HRESULT (const IID &, void **, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int> GetCurrentResourceAndCommandQueue;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12SwapChainAssistant*, int> InsertImplicitSync;
        }
    }
}
