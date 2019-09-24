// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("04C75BF8-3CE1-473B-ACC5-3CC4F5E94999")]
    public unsafe struct IWICImageEncoder
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IWICImageEncoder* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IWICImageEncoder* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IWICImageEncoder* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteFrame(
            [In] IWICImageEncoder* This,
            [In] ID2D1Image* pImage,
            [In] IWICBitmapFrameEncode* pFrameEncode,
            [In] WICImageParameters* pImageParameters
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteFrameThumbnail(
            [In] IWICImageEncoder* This,
            [In] ID2D1Image* pImage,
            [In] IWICBitmapFrameEncode* pFrameEncode,
            [In] WICImageParameters* pImageParameters
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteThumbnail(
            [In] IWICImageEncoder* This,
            [In] ID2D1Image* pImage,
            [In] IWICBitmapEncoder* pEncoder,
            [In] WICImageParameters* pImageParameters
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICImageEncoder* This = &this)
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
            fixed (IWICImageEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICImageEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteFrame(
            [In] ID2D1Image* pImage,
            [In] IWICBitmapFrameEncode* pFrameEncode,
            [In] WICImageParameters* pImageParameters
        )
        {
            fixed (IWICImageEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WriteFrame>(lpVtbl->WriteFrame)(
                    This,
                    pImage,
                    pFrameEncode,
                    pImageParameters
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteFrameThumbnail(
            [In] ID2D1Image* pImage,
            [In] IWICBitmapFrameEncode* pFrameEncode,
            [In] WICImageParameters* pImageParameters
        )
        {
            fixed (IWICImageEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WriteFrameThumbnail>(lpVtbl->WriteFrameThumbnail)(
                    This,
                    pImage,
                    pFrameEncode,
                    pImageParameters
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteThumbnail(
            [In] ID2D1Image* pImage,
            [In] IWICBitmapEncoder* pEncoder,
            [In] WICImageParameters* pImageParameters
        )
        {
            fixed (IWICImageEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WriteThumbnail>(lpVtbl->WriteThumbnail)(
                    This,
                    pImage,
                    pEncoder,
                    pImageParameters
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr WriteFrame;

            public IntPtr WriteFrameThumbnail;

            public IntPtr WriteThumbnail;
        }
    }
}
