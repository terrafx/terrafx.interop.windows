// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F928B7B8-2221-40C1-B72E-7E82F1974D1A")]
    public unsafe partial struct IWICPlanarBitmapFrameEncode
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICPlanarBitmapFrameEncode* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICPlanarBitmapFrameEncode* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICPlanarBitmapFrameEncode* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WritePixels(IWICPlanarBitmapFrameEncode* This, [NativeTypeName("UINT")] uint lineCount, [NativeTypeName("WICBitmapPlane[]")] WICBitmapPlane* pPlanes, [NativeTypeName("UINT")] uint cPlanes);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteSource(IWICPlanarBitmapFrameEncode* This, [NativeTypeName("IWICBitmapSource*[]")] IWICBitmapSource** ppPlanes, [NativeTypeName("UINT")] uint cPlanes, WICRect* prcSource = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICPlanarBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICPlanarBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICPlanarBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WritePixels([NativeTypeName("UINT")] uint lineCount, [NativeTypeName("WICBitmapPlane[]")] WICBitmapPlane* pPlanes, [NativeTypeName("UINT")] uint cPlanes)
        {
            fixed (IWICPlanarBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WritePixels>(lpVtbl->WritePixels)(This, lineCount, pPlanes, cPlanes);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteSource([NativeTypeName("IWICBitmapSource*[]")] IWICBitmapSource** ppPlanes, [NativeTypeName("UINT")] uint cPlanes, WICRect* prcSource = null)
        {
            fixed (IWICPlanarBitmapFrameEncode* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WriteSource>(lpVtbl->WriteSource)(This, ppPlanes, cPlanes, prcSource);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr WritePixels;

            public IntPtr WriteSource;
        }
    }
}
