// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("3B16811B-6A43-4EC9-B713-3D5A0C13B940")]
    public unsafe struct IWICBitmapSourceTransform
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICBitmapSourceTransform* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICBitmapSourceTransform* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICBitmapSourceTransform* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CopyPixels(
            [In] IWICBitmapSourceTransform* This,
            [In, Optional] WICRect* prc,
            [In, NativeTypeName("UINT")] uint uiWidth,
            [In, NativeTypeName("UINT")] uint uiHeight,
            [In, Optional, NativeTypeName("WICPixelFormatGUID")] Guid* pguidDstFormat,
            [In] WICBitmapTransformOptions dstTransform,
            [In, NativeTypeName("UINT")] uint nStride,
            [In, NativeTypeName("UINT")] uint cbBufferSize,
            [Out, NativeTypeName("BYTE[]")] byte* pbBuffer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetClosestSize(
            [In] IWICBitmapSourceTransform* This,
            [In, Out, NativeTypeName("UINT")] uint* puiWidth,
            [In, Out, NativeTypeName("UINT")] uint* puiHeight
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetClosestPixelFormat(
            [In] IWICBitmapSourceTransform* This,
            [In, Out, NativeTypeName("WICPixelFormatGUID")] Guid* pguidDstFormat
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DoesSupportTransform(
            [In] IWICBitmapSourceTransform* This,
            [In] WICBitmapTransformOptions dstTransform,
            [Out, NativeTypeName("BOOL")] int* pfIsSupported
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICBitmapSourceTransform* This = &this)
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
            fixed (IWICBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels(
            [In, Optional] WICRect* prc,
            [In, NativeTypeName("UINT")] uint uiWidth,
            [In, NativeTypeName("UINT")] uint uiHeight,
            [In, Optional, NativeTypeName("WICPixelFormatGUID")] Guid* pguidDstFormat,
            [In] WICBitmapTransformOptions dstTransform,
            [In, NativeTypeName("UINT")] uint nStride,
            [In, NativeTypeName("UINT")] uint cbBufferSize,
            [Out, NativeTypeName("BYTE[]")] byte* pbBuffer
        )
        {
            fixed (IWICBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyPixels>(lpVtbl->CopyPixels)(
                    This,
                    prc,
                    uiWidth,
                    uiHeight,
                    pguidDstFormat,
                    dstTransform,
                    nStride,
                    cbBufferSize,
                    pbBuffer
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClosestSize(
            [In, Out, NativeTypeName("UINT")] uint* puiWidth,
            [In, Out, NativeTypeName("UINT")] uint* puiHeight
        )
        {
            fixed (IWICBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetClosestSize>(lpVtbl->GetClosestSize)(
                    This,
                    puiWidth,
                    puiHeight
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClosestPixelFormat(
            [In, Out, NativeTypeName("WICPixelFormatGUID")] Guid* pguidDstFormat
        )
        {
            fixed (IWICBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetClosestPixelFormat>(lpVtbl->GetClosestPixelFormat)(
                    This,
                    pguidDstFormat
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportTransform(
            [In] WICBitmapTransformOptions dstTransform,
            [Out, NativeTypeName("BOOL")] int* pfIsSupported
        )
        {
            fixed (IWICBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportTransform>(lpVtbl->DoesSupportTransform)(
                    This,
                    dstTransform,
                    pfIsSupported
                );
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
