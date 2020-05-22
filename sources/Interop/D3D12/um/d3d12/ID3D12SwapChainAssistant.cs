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

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12SwapChainAssistant* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12SwapChainAssistant* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12SwapChainAssistant* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate LUID* _GetLUID(ID3D12SwapChainAssistant* pThis, LUID* _result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSwapChainObject(ID3D12SwapChainAssistant* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentResourceAndCommandQueue(ID3D12SwapChainAssistant* pThis, [NativeTypeName("const IID &")] Guid* riidResource, [NativeTypeName("void **")] void** ppvResource, [NativeTypeName("const IID &")] Guid* riidQueue, [NativeTypeName("void **")] void** ppvQueue);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InsertImplicitSync(ID3D12SwapChainAssistant* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
        }

        public LUID GetLUID()
        {
            LUID result;
            return *Marshal.GetDelegateForFunctionPointer<_GetLUID>(lpVtbl->GetLUID)((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSwapChainObject([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSwapChainObject>(lpVtbl->GetSwapChainObject)((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentResourceAndCommandQueue([NativeTypeName("const IID &")] Guid* riidResource, [NativeTypeName("void **")] void** ppvResource, [NativeTypeName("const IID &")] Guid* riidQueue, [NativeTypeName("void **")] void** ppvQueue)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCurrentResourceAndCommandQueue>(lpVtbl->GetCurrentResourceAndCommandQueue)((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riidResource, ppvResource, riidQueue, ppvQueue);
        }

        [return: NativeTypeName("HRESULT")]
        public int InsertImplicitSync()
        {
            return Marshal.GetDelegateForFunctionPointer<_InsertImplicitSync>(lpVtbl->InsertImplicitSync)((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("LUID () __attribute__((stdcall))")]
            public IntPtr GetLUID;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetSwapChainObject;

            [NativeTypeName("HRESULT (const IID &, void **, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetCurrentResourceAndCommandQueue;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr InsertImplicitSync;
        }
    }
}
