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
        public delegate int _QueryInterface(IWICImageEncoder* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICImageEncoder* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICImageEncoder* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteFrame(IWICImageEncoder* This, IntPtr pImage, IWICBitmapFrameEncode* pFrameEncode, WICImageParameters* pImageParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteFrameThumbnail(IWICImageEncoder* This, IntPtr pImage, IWICBitmapFrameEncode* pFrameEncode, WICImageParameters* pImageParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteThumbnail(IWICImageEncoder* This, IntPtr pImage, IWICBitmapEncoder* pEncoder, WICImageParameters* pImageParameters);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICImageEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICImageEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICImageEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteFrame(IntPtr pImage, IWICBitmapFrameEncode* pFrameEncode, WICImageParameters* pImageParameters)
        {
            fixed (IWICImageEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WriteFrame>(lpVtbl->WriteFrame)(This, pImage, pFrameEncode, pImageParameters);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteFrameThumbnail(IntPtr pImage, IWICBitmapFrameEncode* pFrameEncode, WICImageParameters* pImageParameters)
        {
            fixed (IWICImageEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WriteFrameThumbnail>(lpVtbl->WriteFrameThumbnail)(This, pImage, pFrameEncode, pImageParameters);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteThumbnail(IntPtr pImage, IWICBitmapEncoder* pEncoder, WICImageParameters* pImageParameters)
        {
            fixed (IWICImageEncoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WriteThumbnail>(lpVtbl->WriteThumbnail)(This, pImage, pEncoder, pImageParameters);
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
