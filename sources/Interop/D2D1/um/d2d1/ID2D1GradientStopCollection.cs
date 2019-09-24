// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Represents an collection of gradient stops that can then be the source resource for either a linear or radial gradient brush.</summary>
    [Guid("2CD906A7-12E2-11DC-9FED-001143A055F9")]
    public unsafe struct ID2D1GradientStopCollection
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1GradientStopCollection* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1GradientStopCollection* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1GradientStopCollection* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1GradientStopCollection* This, ID2D1Factory** factory);

        /// <summary>Returns the number of stops in the gradient.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetGradientStopCount(ID2D1GradientStopCollection* This);

        /// <summary>Copies the gradient stops from the collection into the caller's interface.  The
        /// returned colors have straight alpha.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetGradientStops(ID2D1GradientStopCollection* This, [NativeTypeName("D2D1_GRADIENT_STOP[]")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount);

        /// <summary>Returns whether the interpolation occurs with 1.0 or 2.2 gamma.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_GAMMA _GetColorInterpolationGamma(ID2D1GradientStopCollection* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_EXTEND_MODE _GetExtendMode(ID2D1GradientStopCollection* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1GradientStopCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1GradientStopCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1GradientStopCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1GradientStopCollection* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetGradientStopCount()
        {
            fixed (ID2D1GradientStopCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGradientStopCount>(lpVtbl->GetGradientStopCount)(This);
            }
        }

        public void GetGradientStops([NativeTypeName("D2D1_GRADIENT_STOP[]")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount)
        {
            fixed (ID2D1GradientStopCollection* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetGradientStops>(lpVtbl->GetGradientStops)(This, gradientStops, gradientStopsCount);
            }
        }

        public D2D1_GAMMA GetColorInterpolationGamma()
        {
            fixed (ID2D1GradientStopCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorInterpolationGamma>(lpVtbl->GetColorInterpolationGamma)(This);
            }
        }

        public D2D1_EXTEND_MODE GetExtendMode()
        {
            fixed (ID2D1GradientStopCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetExtendMode>(lpVtbl->GetExtendMode)(This);
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
        }
    }
}
