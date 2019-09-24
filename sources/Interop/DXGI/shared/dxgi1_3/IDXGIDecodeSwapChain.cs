// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2633066B-4514-4C7A-8FD8-12EA98059D18")]
    public unsafe struct IDXGIDecodeSwapChain
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIDecodeSwapChain* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIDecodeSwapChain* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIDecodeSwapChain* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PresentBuffer(IDXGIDecodeSwapChain* This, [NativeTypeName("UINT")] uint BufferToPresent, [NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSourceRect(IDXGIDecodeSwapChain* This, RECT* pRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetTargetRect(IDXGIDecodeSwapChain* This, RECT* pRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDestSize(IDXGIDecodeSwapChain* This, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSourceRect(IDXGIDecodeSwapChain* This, RECT* pRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTargetRect(IDXGIDecodeSwapChain* This, RECT* pRect);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDestSize(IDXGIDecodeSwapChain* This, [NativeTypeName("UINT")] uint* pWidth, [NativeTypeName("UINT")] uint* pHeight);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetColorSpace(IDXGIDecodeSwapChain* This, DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS ColorSpace);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS _GetColorSpace(IDXGIDecodeSwapChain* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDXGIDecodeSwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGIDecodeSwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIDecodeSwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PresentBuffer([NativeTypeName("UINT")] uint BufferToPresent, [NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags)
        {
            fixed (IDXGIDecodeSwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PresentBuffer>(lpVtbl->PresentBuffer)(This, BufferToPresent, SyncInterval, Flags);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSourceRect(RECT* pRect)
        {
            fixed (IDXGIDecodeSwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetSourceRect>(lpVtbl->SetSourceRect)(This, pRect);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTargetRect(RECT* pRect)
        {
            fixed (IDXGIDecodeSwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetTargetRect>(lpVtbl->SetTargetRect)(This, pRect);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDestSize([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height)
        {
            fixed (IDXGIDecodeSwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetDestSize>(lpVtbl->SetDestSize)(This, Width, Height);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSourceRect(RECT* pRect)
        {
            fixed (IDXGIDecodeSwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSourceRect>(lpVtbl->GetSourceRect)(This, pRect);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTargetRect(RECT* pRect)
        {
            fixed (IDXGIDecodeSwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTargetRect>(lpVtbl->GetTargetRect)(This, pRect);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDestSize([NativeTypeName("UINT")] uint* pWidth, [NativeTypeName("UINT")] uint* pHeight)
        {
            fixed (IDXGIDecodeSwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDestSize>(lpVtbl->GetDestSize)(This, pWidth, pHeight);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorSpace(DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS ColorSpace)
        {
            fixed (IDXGIDecodeSwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetColorSpace>(lpVtbl->SetColorSpace)(This, ColorSpace);
            }
        }

        public DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS GetColorSpace()
        {
            fixed (IDXGIDecodeSwapChain* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorSpace>(lpVtbl->GetColorSpace)(This);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr PresentBuffer;

            public IntPtr SetSourceRect;

            public IntPtr SetTargetRect;

            public IntPtr SetDestSize;

            public IntPtr GetSourceRect;

            public IntPtr GetTargetRect;

            public IntPtr GetDestSize;

            public IntPtr SetColorSpace;

            public IntPtr GetColorSpace;
        }
    }
}
