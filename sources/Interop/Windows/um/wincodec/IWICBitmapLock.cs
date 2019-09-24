// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000123-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe struct IWICBitmapLock
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICBitmapLock* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICBitmapLock* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICBitmapLock* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSize(
            [In] IWICBitmapLock* This,
            [Out, NativeTypeName("UINT")] uint* puiWidth,
            [Out, NativeTypeName("UINT")] uint* puiHeight
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetStride(
            [In] IWICBitmapLock* This,
            [Out, NativeTypeName("UINT")] uint* pcbStride
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDataPointer(
            [In] IWICBitmapLock* This,
            [Out, NativeTypeName("UINT")] uint* pcbBufferSize,
            [Out, NativeTypeName("WICInProcPointer[]")] byte** ppbData = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPixelFormat(
            [In] IWICBitmapLock* This,
            [Out, NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize(
            [Out, NativeTypeName("UINT")] uint* puiWidth,
            [Out, NativeTypeName("UINT")] uint* puiHeight
        )
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)(
                    This,
                    puiWidth,
                    puiHeight
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStride(
            [Out, NativeTypeName("UINT")] uint* pcbStride
        )
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStride>(lpVtbl->GetStride)(
                    This,
                    pcbStride
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDataPointer(
            [Out, NativeTypeName("UINT")] uint* pcbBufferSize,
            [Out, NativeTypeName("WICInProcPointer[]")] byte** ppbData = null
        )
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDataPointer>(lpVtbl->GetDataPointer)(
                    This,
                    pcbBufferSize,
                    ppbData
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat(
            [Out, NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat
        )
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPixelFormat>(lpVtbl->GetPixelFormat)(
                    This,
                    pPixelFormat
                );
            }
        }

        public struct Vtbl
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
