// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000123-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe partial struct IWICBitmapLock
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICBitmapLock* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICBitmapLock* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICBitmapLock* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSize(IWICBitmapLock* This, [NativeTypeName("UINT")] uint* puiWidth, [NativeTypeName("UINT")] uint* puiHeight);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetStride(IWICBitmapLock* This, [NativeTypeName("UINT")] uint* pcbStride);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDataPointer(IWICBitmapLock* This, [NativeTypeName("UINT")] uint* pcbBufferSize, [NativeTypeName("WICInProcPointer[]")] byte** ppbData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPixelFormat(IWICBitmapLock* This, [NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT")] uint* puiWidth, [NativeTypeName("UINT")] uint* puiHeight)
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)(This, puiWidth, puiHeight);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStride([NativeTypeName("UINT")] uint* pcbStride)
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStride>(lpVtbl->GetStride)(This, pcbStride);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDataPointer([NativeTypeName("UINT")] uint* pcbBufferSize, [NativeTypeName("WICInProcPointer[]")] byte** ppbData = null)
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDataPointer>(lpVtbl->GetDataPointer)(This, pcbBufferSize, ppbData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat)
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPixelFormat>(lpVtbl->GetPixelFormat)(This, pPixelFormat);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetSize;

            public IntPtr GetStride;

            public IntPtr GetDataPointer;

            public IntPtr GetPixelFormat;
        }
    }
}
