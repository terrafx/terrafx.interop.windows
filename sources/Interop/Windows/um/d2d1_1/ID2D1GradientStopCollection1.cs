// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Represents an collection of gradient stops that can then be the source resource for either a linear or radial gradient brush.</summary>
    [Guid("AE1572F4-5DD0-4777-998B-9279472AE63B")]
    public unsafe struct ID2D1GradientStopCollection1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1GradientStopCollection1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1GradientStopCollection1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1GradientStopCollection1* This
        );

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1GradientStopCollection1* This,
            [Out] ID2D1Factory** factory
        );

        /// <summary>Returns the number of stops in the gradient.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetGradientStopCount(
            [In] ID2D1GradientStopCollection1* This
        );

        /// <summary>Copies the gradient stops from the collection into the caller's interface.  The
        /// returned colors have straight alpha.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _GetGradientStops(
            [In] ID2D1GradientStopCollection1* This,
            [Out, NativeTypeName("D2D1_GRADIENT_STOP[]")] D2D1_GRADIENT_STOP* gradientStops,
            [In, NativeTypeName("UINT32")] uint gradientStopsCount
        );

        /// <summary>Returns whether the interpolation occurs with 1.0 or 2.2 gamma.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate D2D1_GAMMA _GetColorInterpolationGamma(
            [In] ID2D1GradientStopCollection1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate D2D1_EXTEND_MODE _GetExtendMode(
            [In] ID2D1GradientStopCollection1* This
        );

        /// <summary>Copies the gradient stops from the collection into the caller's memory. If this object was created using ID2D1DeviceContext::CreateGradientStopCollection, this method returns the same values as were specified in the creation method. If this object was created using ID2D1RenderTarget::CreateGradientStopCollection, the stops returned here will first be transformed into the gamma space specified by the colorInterpolationGamma parameter.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _GetGradientStops1(
            [In] ID2D1GradientStopCollection1* This,
            [Out, NativeTypeName("D2D1_GRADIENT_STOP[]")] D2D1_GRADIENT_STOP* gradientStops,
            [In, NativeTypeName("UINT32")] uint gradientStopsCount
        );

        /// <summary>Returns the color space in which interpolation occurs. If this object was created using ID2D1RenderTarget::CreateGradientStopCollection, this method returns the color space related to the color interpolation gamma.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate D2D1_COLOR_SPACE _GetPreInterpolationSpace(
            [In] ID2D1GradientStopCollection1* This
        );

        /// <summary>Returns the color space colors will be converted to after interpolation occurs. If this object was created using ID2D1RenderTarget::CreateGradientStopCollection, this method returns D2D1_COLOR_SPACE_SRGB.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate D2D1_COLOR_SPACE _GetPostInterpolationSpace(
            [In] ID2D1GradientStopCollection1* This
        );

        /// <summary>Returns the buffer precision of this gradient. If this object was created using ID2D1RenderTarget::CreateGradientStopCollection, this method returns D2D1_BUFFER_PRECISION_8BPC_UNORM.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate D2D1_BUFFER_PRECISION _GetBufferPrecision(
            [In] ID2D1GradientStopCollection1* This
        );

        /// <summary>Returns the interpolation mode used to interpolate colors in the gradient.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate D2D1_COLOR_INTERPOLATION_MODE _GetColorInterpolationMode(
            [In] ID2D1GradientStopCollection1* This
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1GradientStopCollection1* This = &this)
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
            fixed (ID2D1GradientStopCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1GradientStopCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        public void GetFactory(
            [Out] ID2D1Factory** factory
        )
        {
            fixed (ID2D1GradientStopCollection1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetGradientStopCount()
        {
            fixed (ID2D1GradientStopCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGradientStopCount>(lpVtbl->GetGradientStopCount)(
                    This
                );
            }
        }

        public void GetGradientStops(
            [Out, NativeTypeName("D2D1_GRADIENT_STOP[]")] D2D1_GRADIENT_STOP* gradientStops,
            [In, NativeTypeName("UINT32")] uint gradientStopsCount
        )
        {
            fixed (ID2D1GradientStopCollection1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetGradientStops>(lpVtbl->GetGradientStops)(
                    This,
                    gradientStops,
                    gradientStopsCount
                );
            }
        }

        public D2D1_GAMMA GetColorInterpolationGamma()
        {
            fixed (ID2D1GradientStopCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorInterpolationGamma>(lpVtbl->GetColorInterpolationGamma)(
                    This
                );
            }
        }

        public D2D1_EXTEND_MODE GetExtendMode()
        {
            fixed (ID2D1GradientStopCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetExtendMode>(lpVtbl->GetExtendMode)(
                    This
                );
            }
        }

        public void GetGradientStops1(
            [Out, NativeTypeName("D2D1_GRADIENT_STOP[]")] D2D1_GRADIENT_STOP* gradientStops,
            [In, NativeTypeName("UINT32")] uint gradientStopsCount
        )
        {
            fixed (ID2D1GradientStopCollection1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetGradientStops1>(lpVtbl->GetGradientStops1)(
                    This,
                    gradientStops,
                    gradientStopsCount
                );
            }
        }

        public D2D1_COLOR_SPACE GetPreInterpolationSpace()
        {
            fixed (ID2D1GradientStopCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPreInterpolationSpace>(lpVtbl->GetPreInterpolationSpace)(
                    This
                );
            }
        }

        public D2D1_COLOR_SPACE GetPostInterpolationSpace()
        {
            fixed (ID2D1GradientStopCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPostInterpolationSpace>(lpVtbl->GetPostInterpolationSpace)(
                    This
                );
            }
        }

        public D2D1_BUFFER_PRECISION GetBufferPrecision()
        {
            fixed (ID2D1GradientStopCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBufferPrecision>(lpVtbl->GetBufferPrecision)(
                    This
                );
            }
        }

        public D2D1_COLOR_INTERPOLATION_MODE GetColorInterpolationMode()
        {
            fixed (ID2D1GradientStopCollection1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorInterpolationMode>(lpVtbl->GetColorInterpolationMode)(
                    This
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr GetGradientStopCount;

            public IntPtr GetGradientStops;

            public IntPtr GetColorInterpolationGamma;

            public IntPtr GetExtendMode;

            public IntPtr GetGradientStops1;

            public IntPtr GetPreInterpolationSpace;

            public IntPtr GetPostInterpolationSpace;

            public IntPtr GetBufferPrecision;

            public IntPtr GetColorInterpolationMode;
        }
    }
}
