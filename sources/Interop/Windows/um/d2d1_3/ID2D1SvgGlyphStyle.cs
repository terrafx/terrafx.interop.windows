// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>This object supplies the values for context-fill, context-stroke, and context-value that are used when rendering SVG glyphs.</summary>
    [Guid("AF671749-D241-4DB8-8E41-DCC2E5C1A438")]
    public unsafe struct ID2D1SvgGlyphStyle
    {
        public readonly Vtbl* lpVtbl;

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1SvgGlyphStyle* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1SvgGlyphStyle* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1SvgGlyphStyle* This
        );

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1SvgGlyphStyle* This,
            [Out] ID2D1Factory** factory
        );

        /// <summary>Provides values to an SVG glyph for fill. The brush with opacity set to 1 is used as the 'context-fill'. The opacity of the brush is used as the 'context-fill-opacity' value.</summary>
        /// <param name="brush">A null brush will cause the context-fill value to come from the defaultFillBrush. If the defaultFillBrush is also null, the context-fill value will be 'none'.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetFill(
            [In] ID2D1SvgGlyphStyle* This,
            [In] ID2D1Brush* brush = null
        );

        /// <summary>Returns the requested fill parameters.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFill(
            [In] ID2D1SvgGlyphStyle* This,
            [Out] ID2D1Brush** brush
        );

        /// <summary>Provides values to an SVG glyph for stroke properties. The brush with opacity set to 1 is used as the 'context-stroke'. The opacity of the brush is used as the 'context-stroke-opacity' value.</summary>
        /// <param name="brush">A null brush will cause the context-stroke value to be 'none'.</param>
        /// <param name="strokeWidth">Specifies the 'context-value' for the 'stroke-width' property.</param>
        /// <param name="dashes">Specifies the 'context-value' for the 'stroke-dasharray' property. A null value will cause the stroke-dasharray to be set to 'none'.</param>
        /// <param name="dashOffset">Specifies the 'context-value' for the 'stroke-dashoffset' property.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetStroke(
            [In] ID2D1SvgGlyphStyle* This,
            [In] ID2D1Brush* brush = null,
            [In, NativeTypeName("FLOAT")] float strokeWidth = 1.0f,
            [In, NativeTypeName("FLOAT[]")] float* dashes = null,
            [In, NativeTypeName("UINT32")] uint dashesCount = 0,
            [In, NativeTypeName("FLOAT")] float dashOffset = 1.0f
        );

        /// <summary>Returns the number of dashes in the dash array.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetStrokeDashesCount(
            [In] ID2D1SvgGlyphStyle* This
        );

        /// <summary>Returns the requested stroke parameters.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetStroke(
            [In] ID2D1SvgGlyphStyle* This,
            [Out] ID2D1Brush** brush = null,
            [Out, NativeTypeName("FLOAT")] float* strokeWidth = null,
            [Out, NativeTypeName("FLOAT[]")] float* dashes = null,
            [In, NativeTypeName("UINT32")] uint dashesCount = 0,
            [Out, NativeTypeName("FLOAT")] float* dashOffset = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1SvgGlyphStyle* This = &this)
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
            fixed (ID2D1SvgGlyphStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SvgGlyphStyle* This = &this)
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
            fixed (ID2D1SvgGlyphStyle* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFill(
            [In] ID2D1Brush* brush = null
        )
        {
            fixed (ID2D1SvgGlyphStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFill>(lpVtbl->SetFill)(
                    This,
                    brush
                );
            }
        }

        public void GetFill(
            [Out] ID2D1Brush** brush
        )
        {
            fixed (ID2D1SvgGlyphStyle* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFill>(lpVtbl->GetFill)(
                    This,
                    brush
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStroke(
            [In] ID2D1Brush* brush = null,
            [In, NativeTypeName("FLOAT")] float strokeWidth = 1.0f,
            [In, NativeTypeName("FLOAT[]")] float* dashes = null,
            [In, NativeTypeName("UINT32")] uint dashesCount = 0,
            [In, NativeTypeName("FLOAT")] float dashOffset = 1.0f
        )
        {
            fixed (ID2D1SvgGlyphStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetStroke>(lpVtbl->SetStroke)(
                    This,
                    brush,
                    strokeWidth,
                    dashes,
                    dashesCount,
                    dashOffset
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetStrokeDashesCount()
        {
            fixed (ID2D1SvgGlyphStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStrokeDashesCount>(lpVtbl->GetStrokeDashesCount)(
                    This
                );
            }
        }

        public void GetStroke(
            [Out] ID2D1Brush** brush = null,
            [Out, NativeTypeName("FLOAT")] float* strokeWidth = null,
            [Out, NativeTypeName("FLOAT[]")] float* dashes = null,
            [In, NativeTypeName("UINT32")] uint dashesCount = 0,
            [Out, NativeTypeName("FLOAT")] float* dashOffset = null
        )
        {
            fixed (ID2D1SvgGlyphStyle* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetStroke>(lpVtbl->GetStroke)(
                    This,
                    brush,
                    strokeWidth,
                    dashes,
                    dashesCount,
                    dashOffset
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr SetFill;

            public IntPtr GetFill;

            public IntPtr SetStroke;

            public IntPtr GetStrokeDashesCount;

            public IntPtr GetStroke;
        }
    }
}
