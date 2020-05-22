// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3B16811B-6A43-4EC9-B713-3D5A0C13B940")]
    public unsafe partial struct IWICBitmapSourceTransform
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICBitmapSourceTransform* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICBitmapSourceTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICBitmapSourceTransform* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyPixels(IWICBitmapSourceTransform* pThis, [NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat, WICBitmapTransformOptions dstTransform, [NativeTypeName("UINT")] uint nStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClosestSize(IWICBitmapSourceTransform* pThis, [NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClosestPixelFormat(IWICBitmapSourceTransform* pThis, [NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportTransform(IWICBitmapSourceTransform* pThis, WICBitmapTransformOptions dstTransform, [NativeTypeName("BOOL *")] int* pfIsSupported);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat, WICBitmapTransformOptions dstTransform, [NativeTypeName("UINT")] uint nStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyPixels>(lpVtbl->CopyPixels)((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClosestSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetClosestSize>(lpVtbl->GetClosestSize)((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClosestPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetClosestPixelFormat>(lpVtbl->GetClosestPixelFormat)((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), pguidDstFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportTransform(WICBitmapTransformOptions dstTransform, [NativeTypeName("BOOL *")] int* pfIsSupported)
        {
            return Marshal.GetDelegateForFunctionPointer<_DoesSupportTransform>(lpVtbl->DoesSupportTransform)((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), dstTransform, pfIsSupported);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, WICPixelFormatGUID *, WICBitmapTransformOptions, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public IntPtr CopyPixels;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetClosestSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public IntPtr GetClosestPixelFormat;

            [NativeTypeName("HRESULT (WICBitmapTransformOptions, BOOL *) __attribute__((stdcall))")]
            public IntPtr DoesSupportTransform;
        }
    }
}
