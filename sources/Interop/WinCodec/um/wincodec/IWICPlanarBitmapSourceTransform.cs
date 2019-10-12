// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3AFF9CCE-BE95-4303-B927-E7D16FF4A613")]
    public unsafe partial struct IWICPlanarBitmapSourceTransform
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICPlanarBitmapSourceTransform* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICPlanarBitmapSourceTransform* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICPlanarBitmapSourceTransform* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportTransform(IWICPlanarBitmapSourceTransform* This, [NativeTypeName("UINT")] uint* puiWidth, [NativeTypeName("UINT")] uint* puiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [NativeTypeName("WICPixelFormatGUID[]")] Guid* pguidDstFormats, [NativeTypeName("WICBitmapPlaneDescription[]")] WICBitmapPlaneDescription* pPlaneDescriptions, [NativeTypeName("UINT")] uint cPlanes, [NativeTypeName("BOOL")] int* pfIsSupported);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyPixels(IWICPlanarBitmapSourceTransform* This, [Optional] WICRect* prcSource, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [NativeTypeName("WICBitmapPlane[]")] WICBitmapPlane* pDstPlanes, [NativeTypeName("UINT")] uint cPlanes);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICPlanarBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICPlanarBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICPlanarBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportTransform([NativeTypeName("UINT")] uint* puiWidth, [NativeTypeName("UINT")] uint* puiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [NativeTypeName("WICPixelFormatGUID[]")] Guid* pguidDstFormats, [NativeTypeName("WICBitmapPlaneDescription[]")] WICBitmapPlaneDescription* pPlaneDescriptions, [NativeTypeName("UINT")] uint cPlanes, [NativeTypeName("BOOL")] int* pfIsSupported)
        {
            fixed (IWICPlanarBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportTransform>(lpVtbl->DoesSupportTransform)(This, puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupported);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([Optional] WICRect* prcSource, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [NativeTypeName("WICBitmapPlane[]")] WICBitmapPlane* pDstPlanes, [NativeTypeName("UINT")] uint cPlanes)
        {
            fixed (IWICPlanarBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyPixels>(lpVtbl->CopyPixels)(This, prcSource, uiWidth, uiHeight, dstTransform, dstPlanarOptions, pDstPlanes, cPlanes);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr DoesSupportTransform;

            public IntPtr CopyPixels;
        }
    }
}
