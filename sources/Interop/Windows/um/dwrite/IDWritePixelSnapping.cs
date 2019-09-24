// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The IDWritePixelSnapping interface defines the pixel snapping properties of a text renderer.</summary>
    [Guid("EAF3A2DA-ECF4-4D24-B644-B34F6842024B")]
    public unsafe struct IDWritePixelSnapping
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWritePixelSnapping* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWritePixelSnapping* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWritePixelSnapping* This);

        /// <summary>Determines whether pixel snapping is disabled. The recommended default is FALSE, unless doing animation that requires subpixel vertical placement.</summary>
        /// <param name="clientDrawingContext">The context passed to IDWriteTextLayout::Draw.</param>
        /// <param name="isDisabled">Receives TRUE if pixel snapping is disabled or FALSE if it not.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsPixelSnappingDisabled(IDWritePixelSnapping* This, [Optional] void* clientDrawingContext, [NativeTypeName("BOOL")] int* isDisabled);

        /// <summary>Gets the current transform that maps abstract coordinates to DIPs, which may disable pixel snapping upon any rotation or shear.</summary>
        /// <param name="clientDrawingContext">The context passed to IDWriteTextLayout::Draw.</param>
        /// <param name="transform">Receives the transform.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentTransform(IDWritePixelSnapping* This, [Optional] void* clientDrawingContext, DWRITE_MATRIX* transform);

        /// <summary>Gets the number of physical pixels per DIP. A DIP (device-independent pixel) is 1/96 inch, so the pixelsPerDip value is the number of logical pixels per inch divided by 96 (yielding a value of 1 for 96 DPI and 1.25 for 120).</summary>
        /// <param name="clientDrawingContext">The context passed to IDWriteTextLayout::Draw.</param>
        /// <param name="pixelsPerDip">Receives the number of physical pixels per DIP.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPixelsPerDip(IDWritePixelSnapping* This, [Optional] void* clientDrawingContext, [NativeTypeName("FLOAT")] float* pixelsPerDip);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWritePixelSnapping* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWritePixelSnapping* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWritePixelSnapping* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int IsPixelSnappingDisabled([Optional] void* clientDrawingContext, [NativeTypeName("BOOL")] int* isDisabled)
        {
            fixed (IDWritePixelSnapping* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsPixelSnappingDisabled>(lpVtbl->IsPixelSnappingDisabled)(This, clientDrawingContext, isDisabled);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentTransform([Optional] void* clientDrawingContext, DWRITE_MATRIX* transform)
        {
            fixed (IDWritePixelSnapping* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCurrentTransform>(lpVtbl->GetCurrentTransform)(This, clientDrawingContext, transform);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelsPerDip([Optional] void* clientDrawingContext, [NativeTypeName("FLOAT")] float* pixelsPerDip)
        {
            fixed (IDWritePixelSnapping* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPixelsPerDip>(lpVtbl->GetPixelsPerDip)(This, clientDrawingContext, pixelsPerDip);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr IsPixelSnappingDisabled;

            public IntPtr GetCurrentTransform;

            public IntPtr GetPixelsPerDip;
        }
    }
}
