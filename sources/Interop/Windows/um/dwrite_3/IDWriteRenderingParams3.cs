// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The interface that represents text rendering settings for glyph rasterization and filtering.</summary>
    [Guid("B7924BAA-391B-412A-8C5C-E44CC2D867DC")]
    public unsafe struct IDWriteRenderingParams3
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteRenderingParams3* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteRenderingParams3* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteRenderingParams3* This);

        /// <summary>Gets the gamma value used for gamma correction. Valid values must be greater than zero and cannot exceed 256.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetGamma(IDWriteRenderingParams3* This);

        /// <summary>Gets the amount of contrast enhancement. Valid values are greater than or equal to zero.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetEnhancedContrast(IDWriteRenderingParams3* This);

        /// <summary>Gets the ClearType level. Valid values range from 0.0f (no ClearType) to 1.0f (full ClearType).</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate float _GetClearTypeLevel(IDWriteRenderingParams3* This);

        /// <summary>Gets the pixel geometry.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_PIXEL_GEOMETRY _GetPixelGeometry(IDWriteRenderingParams3* This);

        /// <summary>Gets the rendering mode.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_RENDERING_MODE _GetRenderingMode(IDWriteRenderingParams3* This);

        /// <summary>Gets the amount of contrast enhancement to use for grayscale antialiasing. Valid values are greater than or equal to zero.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetGrayscaleEnhancedContrast(IDWriteRenderingParams3* This);

        /// <summary>Gets the grid fitting mode.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_GRID_FIT_MODE _GetGridFitMode(IDWriteRenderingParams3* This);

        /// <summary>Gets the rendering mode.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_RENDERING_MODE1 _GetRenderingMode1(IDWriteRenderingParams3* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteRenderingParams3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteRenderingParams3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteRenderingParams3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetGamma()
        {
            fixed (IDWriteRenderingParams3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGamma>(lpVtbl->GetGamma)(This);
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetEnhancedContrast()
        {
            fixed (IDWriteRenderingParams3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEnhancedContrast>(lpVtbl->GetEnhancedContrast)(This);
            }
        }

        public float GetClearTypeLevel()
        {
            fixed (IDWriteRenderingParams3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetClearTypeLevel>(lpVtbl->GetClearTypeLevel)(This);
            }
        }

        public DWRITE_PIXEL_GEOMETRY GetPixelGeometry()
        {
            fixed (IDWriteRenderingParams3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPixelGeometry>(lpVtbl->GetPixelGeometry)(This);
            }
        }

        public DWRITE_RENDERING_MODE GetRenderingMode()
        {
            fixed (IDWriteRenderingParams3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRenderingMode>(lpVtbl->GetRenderingMode)(This);
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetGrayscaleEnhancedContrast()
        {
            fixed (IDWriteRenderingParams3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGrayscaleEnhancedContrast>(lpVtbl->GetGrayscaleEnhancedContrast)(This);
            }
        }

        public DWRITE_GRID_FIT_MODE GetGridFitMode()
        {
            fixed (IDWriteRenderingParams3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGridFitMode>(lpVtbl->GetGridFitMode)(This);
            }
        }

        public DWRITE_RENDERING_MODE1 GetRenderingMode1()
        {
            fixed (IDWriteRenderingParams3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRenderingMode1>(lpVtbl->GetRenderingMode1)(This);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetGamma;

            public IntPtr GetEnhancedContrast;

            public IntPtr GetClearTypeLevel;

            public IntPtr GetPixelGeometry;

            public IntPtr GetRenderingMode;

            public IntPtr GetGrayscaleEnhancedContrast;

            public IntPtr GetGridFitMode;

            public IntPtr GetRenderingMode1;
        }
    }
}
