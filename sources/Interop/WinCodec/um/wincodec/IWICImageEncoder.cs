// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IWICImageEncoder
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICImageEncoder* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICImageEncoder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICImageEncoder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteFrame(IWICImageEncoder* pThis, [NativeTypeName("ID2D1Image *")] IUnknown* pImage, [NativeTypeName("IWICBitmapFrameEncode *")] IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteFrameThumbnail(IWICImageEncoder* pThis, [NativeTypeName("ID2D1Image *")] IUnknown* pImage, [NativeTypeName("IWICBitmapFrameEncode *")] IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteThumbnail(IWICImageEncoder* pThis, [NativeTypeName("ID2D1Image *")] IUnknown* pImage, [NativeTypeName("IWICBitmapEncoder *")] IWICBitmapEncoder* pEncoder, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICImageEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICImageEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICImageEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteFrame([NativeTypeName("ID2D1Image *")] IUnknown* pImage, [NativeTypeName("IWICBitmapFrameEncode *")] IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters)
        {
            return Marshal.GetDelegateForFunctionPointer<_WriteFrame>(lpVtbl->WriteFrame)((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pFrameEncode, pImageParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteFrameThumbnail([NativeTypeName("ID2D1Image *")] IUnknown* pImage, [NativeTypeName("IWICBitmapFrameEncode *")] IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters)
        {
            return Marshal.GetDelegateForFunctionPointer<_WriteFrameThumbnail>(lpVtbl->WriteFrameThumbnail)((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pFrameEncode, pImageParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteThumbnail([NativeTypeName("ID2D1Image *")] IUnknown* pImage, [NativeTypeName("IWICBitmapEncoder *")] IWICBitmapEncoder* pEncoder, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters)
        {
            return Marshal.GetDelegateForFunctionPointer<_WriteThumbnail>(lpVtbl->WriteThumbnail)((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pEncoder, pImageParameters);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (ID2D1Image *, IWICBitmapFrameEncode *, const WICImageParameters *) __attribute__((stdcall))")]
            public IntPtr WriteFrame;

            [NativeTypeName("HRESULT (ID2D1Image *, IWICBitmapFrameEncode *, const WICImageParameters *) __attribute__((stdcall))")]
            public IntPtr WriteFrameThumbnail;

            [NativeTypeName("HRESULT (ID2D1Image *, IWICBitmapEncoder *, const WICImageParameters *) __attribute__((stdcall))")]
            public IntPtr WriteThumbnail;
        }
    }
}
