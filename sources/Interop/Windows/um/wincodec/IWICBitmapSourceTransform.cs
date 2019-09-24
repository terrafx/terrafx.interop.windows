// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3B16811B-6A43-4EC9-B713-3D5A0C13B940")]
    public unsafe struct IWICBitmapSourceTransform
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICBitmapSourceTransform* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICBitmapSourceTransform* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICBitmapSourceTransform* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyPixels(IWICBitmapSourceTransform* This, [Optional] WICRect* prc, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [Optional, NativeTypeName("WICPixelFormatGUID")] Guid* pguidDstFormat, WICBitmapTransformOptions dstTransform, [NativeTypeName("UINT")] uint nStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE[]")] byte* pbBuffer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClosestSize(IWICBitmapSourceTransform* This, [NativeTypeName("UINT")] uint* puiWidth, [NativeTypeName("UINT")] uint* puiHeight);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClosestPixelFormat(IWICBitmapSourceTransform* This, [NativeTypeName("WICPixelFormatGUID")] Guid* pguidDstFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportTransform(IWICBitmapSourceTransform* This, WICBitmapTransformOptions dstTransform, [NativeTypeName("BOOL")] int* pfIsSupported);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([Optional] WICRect* prc, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [Optional, NativeTypeName("WICPixelFormatGUID")] Guid* pguidDstFormat, WICBitmapTransformOptions dstTransform, [NativeTypeName("UINT")] uint nStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE[]")] byte* pbBuffer)
        {
            fixed (IWICBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyPixels>(lpVtbl->CopyPixels)(This, prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBuffer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClosestSize([NativeTypeName("UINT")] uint* puiWidth, [NativeTypeName("UINT")] uint* puiHeight)
        {
            fixed (IWICBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetClosestSize>(lpVtbl->GetClosestSize)(This, puiWidth, puiHeight);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClosestPixelFormat([NativeTypeName("WICPixelFormatGUID")] Guid* pguidDstFormat)
        {
            fixed (IWICBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetClosestPixelFormat>(lpVtbl->GetClosestPixelFormat)(This, pguidDstFormat);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportTransform(WICBitmapTransformOptions dstTransform, [NativeTypeName("BOOL")] int* pfIsSupported)
        {
            fixed (IWICBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportTransform>(lpVtbl->DoesSupportTransform)(This, dstTransform, pfIsSupported);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr CopyPixels;

            public IntPtr GetClosestSize;

            public IntPtr GetClosestPixelFormat;

            public IntPtr DoesSupportTransform;
        }
    }
}
