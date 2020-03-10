// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79CF2233-7536-4948-9D36-1E4692DC5760")]
    public unsafe partial struct ID3D11Debug
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11Debug* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11Debug* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11Debug* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFeatureMask(ID3D11Debug* pThis, [NativeTypeName("UINT")] uint Mask);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetFeatureMask(ID3D11Debug* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPresentPerRenderOpDelay(ID3D11Debug* pThis, [NativeTypeName("UINT")] uint Milliseconds);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetPresentPerRenderOpDelay(ID3D11Debug* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSwapChain(ID3D11Debug* pThis, [NativeTypeName("IDXGISwapChain *")] IDXGISwapChain* pSwapChain);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSwapChain(ID3D11Debug* pThis, [NativeTypeName("IDXGISwapChain **")] IDXGISwapChain** ppSwapChain);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ValidateContext(ID3D11Debug* pThis, [NativeTypeName("ID3D11DeviceContext *")] ID3D11DeviceContext* pContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReportLiveDeviceObjects(ID3D11Debug* pThis, D3D11_RLDO_FLAGS Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ValidateContextForDispatch(ID3D11Debug* pThis, [NativeTypeName("ID3D11DeviceContext *")] ID3D11DeviceContext* pContext);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11Debug*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11Debug*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11Debug*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFeatureMask([NativeTypeName("UINT")] uint Mask)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFeatureMask>(lpVtbl->SetFeatureMask)((ID3D11Debug*)Unsafe.AsPointer(ref this), Mask);
        }

        [return: NativeTypeName("UINT")]
        public uint GetFeatureMask()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFeatureMask>(lpVtbl->GetFeatureMask)((ID3D11Debug*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPresentPerRenderOpDelay([NativeTypeName("UINT")] uint Milliseconds)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPresentPerRenderOpDelay>(lpVtbl->SetPresentPerRenderOpDelay)((ID3D11Debug*)Unsafe.AsPointer(ref this), Milliseconds);
        }

        [return: NativeTypeName("UINT")]
        public uint GetPresentPerRenderOpDelay()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPresentPerRenderOpDelay>(lpVtbl->GetPresentPerRenderOpDelay)((ID3D11Debug*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSwapChain([NativeTypeName("IDXGISwapChain *")] IDXGISwapChain* pSwapChain)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSwapChain>(lpVtbl->SetSwapChain)((ID3D11Debug*)Unsafe.AsPointer(ref this), pSwapChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSwapChain([NativeTypeName("IDXGISwapChain **")] IDXGISwapChain** ppSwapChain)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSwapChain>(lpVtbl->GetSwapChain)((ID3D11Debug*)Unsafe.AsPointer(ref this), ppSwapChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int ValidateContext([NativeTypeName("ID3D11DeviceContext *")] ID3D11DeviceContext* pContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_ValidateContext>(lpVtbl->ValidateContext)((ID3D11Debug*)Unsafe.AsPointer(ref this), pContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReportLiveDeviceObjects(D3D11_RLDO_FLAGS Flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReportLiveDeviceObjects>(lpVtbl->ReportLiveDeviceObjects)((ID3D11Debug*)Unsafe.AsPointer(ref this), Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int ValidateContextForDispatch([NativeTypeName("ID3D11DeviceContext *")] ID3D11DeviceContext* pContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_ValidateContextForDispatch>(lpVtbl->ValidateContextForDispatch)((ID3D11Debug*)Unsafe.AsPointer(ref this), pContext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr SetFeatureMask;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public IntPtr GetFeatureMask;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public IntPtr SetPresentPerRenderOpDelay;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public IntPtr GetPresentPerRenderOpDelay;

            [NativeTypeName("HRESULT (IDXGISwapChain *) __attribute__((stdcall))")]
            public IntPtr SetSwapChain;

            [NativeTypeName("HRESULT (IDXGISwapChain **) __attribute__((stdcall))")]
            public IntPtr GetSwapChain;

            [NativeTypeName("HRESULT (ID3D11DeviceContext *) __attribute__((stdcall))")]
            public IntPtr ValidateContext;

            [NativeTypeName("HRESULT (D3D11_RLDO_FLAGS) __attribute__((stdcall))")]
            public IntPtr ReportLiveDeviceObjects;

            [NativeTypeName("HRESULT (ID3D11DeviceContext *) __attribute__((stdcall))")]
            public IntPtr ValidateContextForDispatch;
        }
    }
}
