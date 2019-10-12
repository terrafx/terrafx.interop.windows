// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>This object supplies the values for context-fill, context-stroke, and context-value that are used when rendering SVG glyphs.</summary>
    [Guid("AF671749-D241-4DB8-8E41-DCC2E5C1A438")]
    public unsafe partial struct ID2D1SvgGlyphStyle
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SvgGlyphStyle* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SvgGlyphStyle* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SvgGlyphStyle* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1SvgGlyphStyle* This, ID2D1Factory** factory);

        /// <summary>Provides values to an SVG glyph for fill. The brush with opacity set to 1 is used as the 'context-fill'. The opacity of the brush is used as the 'context-fill-opacity' value.</summary>
        /// <param name="brush">A null brush will cause the context-fill value to come from the defaultFillBrush. If the defaultFillBrush is also null, the context-fill value will be 'none'.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFill(ID2D1SvgGlyphStyle* This, ID2D1Brush* brush = null);

        /// <summary>Returns the requested fill parameters.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFill(ID2D1SvgGlyphStyle* This, ID2D1Brush** brush);

        /// <summary>Provides values to an SVG glyph for stroke properties. The brush with opacity set to 1 is used as the 'context-stroke'. The opacity of the brush is used as the 'context-stroke-opacity' value.</summary>
        /// <param name="brush">A null brush will cause the context-stroke value to be 'none'.</param>
        /// <param name="strokeWidth">Specifies the 'context-value' for the 'stroke-width' property.</param>
        /// <param name="dashes">Specifies the 'context-value' for the 'stroke-dasharray' property. A null value will cause the stroke-dasharray to be set to 'none'.</param>
        /// <param name="dashOffset">Specifies the 'context-value' for the 'stroke-dashoffset' property.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetStroke(ID2D1SvgGlyphStyle* This, ID2D1Brush* brush = null, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("FLOAT[]")] float* dashes = null, [NativeTypeName("UINT32")] uint dashesCount = 0, [NativeTypeName("FLOAT")] float dashOffset = 1.0f);

        /// <summary>Returns the number of dashes in the dash array.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetStrokeDashesCount(ID2D1SvgGlyphStyle* This);

        /// <summary>Returns the requested stroke parameters.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetStroke(ID2D1SvgGlyphStyle* This, ID2D1Brush** brush = null, [NativeTypeName("FLOAT")] float* strokeWidth = null, [NativeTypeName("FLOAT[]")] float* dashes = null, [NativeTypeName("UINT32")] uint dashesCount = 0, [NativeTypeName("FLOAT")] float* dashOffset = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1SvgGlyphStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1SvgGlyphStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SvgGlyphStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1SvgGlyphStyle* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFill(ID2D1Brush* brush = null)
        {
            fixed (ID2D1SvgGlyphStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFill>(lpVtbl->SetFill)(This, brush);
            }
        }

        public void GetFill(ID2D1Brush** brush)
        {
            fixed (ID2D1SvgGlyphStyle* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFill>(lpVtbl->GetFill)(This, brush);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStroke(ID2D1Brush* brush = null, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("FLOAT[]")] float* dashes = null, [NativeTypeName("UINT32")] uint dashesCount = 0, [NativeTypeName("FLOAT")] float dashOffset = 1.0f)
        {
            fixed (ID2D1SvgGlyphStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetStroke>(lpVtbl->SetStroke)(This, brush, strokeWidth, dashes, dashesCount, dashOffset);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetStrokeDashesCount()
        {
            fixed (ID2D1SvgGlyphStyle* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStrokeDashesCount>(lpVtbl->GetStrokeDashesCount)(This);
            }
        }

        public void GetStroke(ID2D1Brush** brush = null, [NativeTypeName("FLOAT")] float* strokeWidth = null, [NativeTypeName("FLOAT[]")] float* dashes = null, [NativeTypeName("UINT32")] uint dashesCount = 0, [NativeTypeName("FLOAT")] float* dashOffset = null)
        {
            fixed (ID2D1SvgGlyphStyle* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetStroke>(lpVtbl->GetStroke)(This, brush, strokeWidth, dashes, dashesCount, dashOffset);
            }
        }

        public partial struct Vtbl
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
