// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("3AFF9CCE-BE95-4303-B927-E7D16FF4A613")]
    public unsafe struct IWICPlanarBitmapSourceTransform
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICPlanarBitmapSourceTransform* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICPlanarBitmapSourceTransform* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICPlanarBitmapSourceTransform* This
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DoesSupportTransform(
            [In] IWICPlanarBitmapSourceTransform* This,
            [In, Out, NativeTypeName("UINT")] uint* puiWidth,
            [In, Out, NativeTypeName("UINT")] uint* puiHeight,
            [In] WICBitmapTransformOptions dstTransform,
            [In] WICPlanarOptions dstPlanarOptions,
            [In, NativeTypeName("WICPixelFormatGUID[]")] Guid* pguidDstFormats,
            [Out, NativeTypeName("WICBitmapPlaneDescription[]")] WICBitmapPlaneDescription* pPlaneDescriptions,
            [In, NativeTypeName("UINT")] uint cPlanes,
            [Out, NativeTypeName("BOOL")] int* pfIsSupported
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CopyPixels(
            [In] IWICPlanarBitmapSourceTransform* This,
            [In, Optional] WICRect* prcSource,
            [In, NativeTypeName("UINT")] uint uiWidth,
            [In, NativeTypeName("UINT")] uint uiHeight,
            [In] WICBitmapTransformOptions dstTransform,
            [In] WICPlanarOptions dstPlanarOptions,
            [In, NativeTypeName("WICBitmapPlane[]")] WICBitmapPlane* pDstPlanes,
            [In, NativeTypeName("UINT")] uint cPlanes
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICPlanarBitmapSourceTransform* This = &this)
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
            fixed (IWICPlanarBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICPlanarBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportTransform(
            [In, Out, NativeTypeName("UINT")] uint* puiWidth,
            [In, Out, NativeTypeName("UINT")] uint* puiHeight,
            [In] WICBitmapTransformOptions dstTransform,
            [In] WICPlanarOptions dstPlanarOptions,
            [In, NativeTypeName("WICPixelFormatGUID[]")] Guid* pguidDstFormats,
            [Out, NativeTypeName("WICBitmapPlaneDescription[]")] WICBitmapPlaneDescription* pPlaneDescriptions,
            [In, NativeTypeName("UINT")] uint cPlanes,
            [Out, NativeTypeName("BOOL")] int* pfIsSupported
        )
        {
            fixed (IWICPlanarBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DoesSupportTransform>(lpVtbl->DoesSupportTransform)(
                    This,
                    puiWidth,
                    puiHeight,
                    dstTransform,
                    dstPlanarOptions,
                    pguidDstFormats,
                    pPlaneDescriptions,
                    cPlanes,
                    pfIsSupported
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels(
            [In, Optional] WICRect* prcSource,
            [In, NativeTypeName("UINT")] uint uiWidth,
            [In, NativeTypeName("UINT")] uint uiHeight,
            [In] WICBitmapTransformOptions dstTransform,
            [In] WICPlanarOptions dstPlanarOptions,
            [In, NativeTypeName("WICBitmapPlane[]")] WICBitmapPlane* pDstPlanes,
            [In, NativeTypeName("UINT")] uint cPlanes
        )
        {
            fixed (IWICPlanarBitmapSourceTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyPixels>(lpVtbl->CopyPixels)(
                    This,
                    prcSource,
                    uiWidth,
                    uiHeight,
                    dstTransform,
                    dstPlanarOptions,
                    pDstPlanes,
                    cPlanes
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region Fields
            public IntPtr DoesSupportTransform;

            public IntPtr CopyPixels;
            #endregion
        }
        #endregion
    }
}
