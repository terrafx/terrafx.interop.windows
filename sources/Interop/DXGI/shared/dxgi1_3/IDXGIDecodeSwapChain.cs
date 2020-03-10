// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2633066B-4514-4C7A-8FD8-12EA98059D18")]
    public unsafe partial struct IDXGIDecodeSwapChain
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIDecodeSwapChain* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIDecodeSwapChain* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIDecodeSwapChain* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PresentBuffer(IDXGIDecodeSwapChain* pThis, [NativeTypeName("UINT")] uint BufferToPresent, [NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSourceRect(IDXGIDecodeSwapChain* pThis, [NativeTypeName("const RECT *")] RECT* pRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTargetRect(IDXGIDecodeSwapChain* pThis, [NativeTypeName("const RECT *")] RECT* pRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDestSize(IDXGIDecodeSwapChain* pThis, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSourceRect(IDXGIDecodeSwapChain* pThis, [NativeTypeName("RECT *")] RECT* pRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTargetRect(IDXGIDecodeSwapChain* pThis, [NativeTypeName("RECT *")] RECT* pRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDestSize(IDXGIDecodeSwapChain* pThis, [NativeTypeName("UINT *")] uint* pWidth, [NativeTypeName("UINT *")] uint* pHeight);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetColorSpace(IDXGIDecodeSwapChain* pThis, DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS ColorSpace);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS _GetColorSpace(IDXGIDecodeSwapChain* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PresentBuffer([NativeTypeName("UINT")] uint BufferToPresent, [NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_PresentBuffer>(lpVtbl->PresentBuffer)((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), BufferToPresent, SyncInterval, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSourceRect([NativeTypeName("const RECT *")] RECT* pRect)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSourceRect>(lpVtbl->SetSourceRect)((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTargetRect([NativeTypeName("const RECT *")] RECT* pRect)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetTargetRect>(lpVtbl->SetTargetRect)((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDestSize([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetDestSize>(lpVtbl->SetDestSize)((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), Width, Height);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSourceRect([NativeTypeName("RECT *")] RECT* pRect)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSourceRect>(lpVtbl->GetSourceRect)((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTargetRect([NativeTypeName("RECT *")] RECT* pRect)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTargetRect>(lpVtbl->GetTargetRect)((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDestSize([NativeTypeName("UINT *")] uint* pWidth, [NativeTypeName("UINT *")] uint* pHeight)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDestSize>(lpVtbl->GetDestSize)((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pWidth, pHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorSpace(DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS ColorSpace)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetColorSpace>(lpVtbl->SetColorSpace)((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), ColorSpace);
        }

        public DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS GetColorSpace()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetColorSpace>(lpVtbl->GetColorSpace)((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((stdcall))")]
            public IntPtr PresentBuffer;

            [NativeTypeName("HRESULT (const RECT *) __attribute__((stdcall))")]
            public IntPtr SetSourceRect;

            [NativeTypeName("HRESULT (const RECT *) __attribute__((stdcall))")]
            public IntPtr SetTargetRect;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
            public IntPtr SetDestSize;

            [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
            public IntPtr GetSourceRect;

            [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
            public IntPtr GetTargetRect;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetDestSize;

            [NativeTypeName("HRESULT (DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS) __attribute__((stdcall))")]
            public IntPtr SetColorSpace;

            [NativeTypeName("DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS () __attribute__((stdcall))")]
            public IntPtr GetColorSpace;
        }
    }
}
