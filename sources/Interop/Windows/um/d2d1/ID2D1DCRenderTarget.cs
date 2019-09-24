// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_BITMAP_INTERPOLATION_MODE;
using static TerraFX.Interop.D2D1_DRAW_TEXT_OPTIONS;
using static TerraFX.Interop.DWRITE_MEASURING_MODE;

namespace TerraFX.Interop
{
    /// <summary>Issues drawing commands to a GDI device context.</summary>
    [Guid("1C51BC64-DE61-46FD-9899-63A5D8F03950")]
    public unsafe struct ID2D1DCRenderTarget
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1DCRenderTarget* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1DCRenderTarget* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1DCRenderTarget* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1DCRenderTarget* This, ID2D1Factory** factory);

        /// <summary>Create a D2D bitmap by copying from memory, or create uninitialized.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmap(ID2D1DCRenderTarget* This, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [Optional] void* srcData, [NativeTypeName("UINT32")] uint pitch, D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap);

        /// <summary>Create a D2D bitmap by copying a WIC bitmap.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromWicBitmap(ID2D1DCRenderTarget* This, IWICBitmapSource* wicBitmapSource, [Optional] D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap);

        /// <summary>Create a D2D bitmap by sharing bits from another resource. The bitmap must be compatible with the render target for the call to succeed. For example, an IWICBitmap can be shared with a software target, or a DXGI surface can be shared with a DXGI render target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSharedBitmap(ID2D1DCRenderTarget* This, [NativeTypeName("REFIID")] Guid* riid, void* data, [Optional] D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap);

        /// <summary>Creates a bitmap brush. The bitmap is scaled, rotated, skewed or tiled to fill or pen a geometry.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapBrush(ID2D1DCRenderTarget* This, [Optional] ID2D1Bitmap* bitmap, [Optional] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1BitmapBrush** bitmapBrush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSolidColorBrush(ID2D1DCRenderTarget* This, [NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1SolidColorBrush** solidColorBrush);

        /// <summary>A gradient stop collection represents a set of stops in an ideal unit length. This is the source resource for a linear gradient and radial gradient brush.</summary>
        /// <param name="colorInterpolationGamma">Specifies which space the color interpolation occurs in.</param>
        /// <param name="extendMode">Specifies how the gradient will be extended outside of the unit length.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateGradientStopCollection(ID2D1DCRenderTarget* This, [NativeTypeName("D2D1_GRADIENT_STOP[]")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, ID2D1GradientStopCollection** gradientStopCollection);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateLinearGradientBrush(ID2D1DCRenderTarget* This, D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRadialGradientBrush(ID2D1DCRenderTarget* This, D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush);

        /// <summary>Creates a bitmap render target whose bitmap can be used as a source for rendering in the API.</summary>
        /// <param name="desiredSize">The requested size of the target in DIPs. If the pixel size is not specified, the DPI is inherited from the parent target. However, the render target will never contain a fractional number of pixels.</param>
        /// <param name="desiredPixelSize">The requested size of the render target in pixels. If the DIP size is also specified, the DPI is calculated from these two values. If the desired size is not specified, the DPI is inherited from the parent render target. If neither value is specified, the compatible render target will be the same size and have the same DPI as the parent target.</param>
        /// <param name="desiredFormat">The desired pixel format. The format must be compatible with the parent render target type. If the format is not specified, it will be inherited from the parent render target.</param>
        /// <param name="options">Allows the caller to retrieve a GDI compatible render target.</param>
        /// <param name="bitmapRenderTarget">The returned bitmap render target.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateCompatibleRenderTarget(ID2D1DCRenderTarget* This, [Optional, NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F* desiredSize, [Optional, NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U* desiredPixelSize, [Optional] D2D1_PIXEL_FORMAT* desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, ID2D1BitmapRenderTarget** bitmapRenderTarget);

        /// <summary>Creates a layer resource that can be used on any target and which will resize under the covers if necessary.</summary>
        /// <param name="size">The resolution independent minimum size hint for the layer resource. Specify this to prevent unwanted reallocation of the layer backing store. The size is in DIPs, but, it is unaffected by the current world transform. If the size is unspecified, the returned resource is a placeholder and the backing store will be allocated to be the minimum size that can hold the content when the layer is pushed.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateLayer(ID2D1DCRenderTarget* This, [Optional, NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F* size, ID2D1Layer** layer);

        /// <summary>Create a D2D mesh.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMesh(ID2D1DCRenderTarget* This, ID2D1Mesh** mesh);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawLine(ID2D1DCRenderTarget* This, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawRectangle(ID2D1DCRenderTarget* This, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rect, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillRectangle(ID2D1DCRenderTarget* This, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rect, ID2D1Brush* brush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawRoundedRectangle(ID2D1DCRenderTarget* This, D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillRoundedRectangle(ID2D1DCRenderTarget* This, D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawEllipse(ID2D1DCRenderTarget* This, D2D1_ELLIPSE* ellipse, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillEllipse(ID2D1DCRenderTarget* This, D2D1_ELLIPSE* ellipse, ID2D1Brush* brush);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawGeometry(ID2D1DCRenderTarget* This, ID2D1Geometry* geometry, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null);

        /// <param name="opacityBrush">An optionally specified opacity brush. Only the alpha channel of the corresponding brush will be sampled and will be applied to the entire fill of the geometry. If this brush is specified, the fill brush must be a bitmap brush with an extend mode of D2D1_EXTEND_MODE_CLAMP.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillGeometry(ID2D1DCRenderTarget* This, ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush = null);

        /// <summary>Fill a mesh. Since meshes can only render aliased content, the render target antialiasing mode must be set to aliased.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillMesh(ID2D1DCRenderTarget* This, ID2D1Mesh* mesh, ID2D1Brush* brush);

        /// <summary>Fill using the alpha channel of the supplied opacity mask bitmap. The brush opacity will be modulated by the mask. The render target antialiasing mode must be set to aliased.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FillOpacityMask(ID2D1DCRenderTarget* This, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, D2D1_OPACITY_MASK_CONTENT content, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawBitmap(ID2D1DCRenderTarget* This, ID2D1Bitmap* bitmap, [Optional, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle, [NativeTypeName("FLOAT")] float opacity = 1.0f, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null);

        /// <summary>Draws the text within the given layout rectangle and by default also performs baseline snapping.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawText(ID2D1DCRenderTarget* This, [NativeTypeName("WCHAR[]")] char* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* layoutRect, ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL);

        /// <summary>Draw a text layout object. If the layout is not subsequently changed, this can be more efficient than DrawText when drawing the same layout repeatedly.</summary>
        /// <param name="options">The specified text options. If D2D1_DRAW_TEXT_OPTIONS_CLIP is used, the text is clipped to the layout bounds. These bounds are derived from the origin and the layout bounds of the corresponding IDWriteTextLayout object.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawTextLayout(ID2D1DCRenderTarget* This, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin, IDWriteTextLayout* textLayout, ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _DrawGlyphRun(ID2D1DCRenderTarget* This, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, DWRITE_GLYPH_RUN* glyphRun, ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTransform(ID2D1DCRenderTarget* This, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTransform(ID2D1DCRenderTarget* This, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetAntialiasMode(ID2D1DCRenderTarget* This, D2D1_ANTIALIAS_MODE antialiasMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_ANTIALIAS_MODE _GetAntialiasMode(ID2D1DCRenderTarget* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTextAntialiasMode(ID2D1DCRenderTarget* This, D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_TEXT_ANTIALIAS_MODE _GetTextAntialiasMode(ID2D1DCRenderTarget* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTextRenderingParams(ID2D1DCRenderTarget* This, IDWriteRenderingParams* textRenderingParams = null);

        /// <summary>Retrieve the text render parameters. NOTE: If NULL is specified to SetTextRenderingParameters, NULL will be returned.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTextRenderingParams(ID2D1DCRenderTarget* This, IDWriteRenderingParams** textRenderingParams);

        /// <summary>Set a tag to correspond to the succeeding primitives. If an error occurs rendering a primitive, the tags can be returned from the Flush or EndDraw call.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetTags(ID2D1DCRenderTarget* This, [NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2);

        /// <summary>Retrieves the currently set tags. This does not retrieve the tags corresponding to any primitive that is in error.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetTags(ID2D1DCRenderTarget* This, [NativeTypeName("D2D1_TAG")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG")] ulong* tag2 = null);

        /// <summary>Start a layer of drawing calls. The way in which the layer must be resolved is specified first as well as the logical resource that stores the layer parameters. The supplied layer resource might grow if the specified content cannot fit inside it. The layer will grow monotonically on each axis.  If a NULL ID2D1Layer is provided, then a layer resource will be allocated automatically.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PushLayer(ID2D1DCRenderTarget* This, D2D1_LAYER_PARAMETERS* layerParameters, ID2D1Layer* layer = null);

        /// <summary>Ends a layer that was defined with particular layer resources.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PopLayer(ID2D1DCRenderTarget* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Flush(ID2D1DCRenderTarget* This, [NativeTypeName("D2D1_TAG")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG")] ulong* tag2 = null);

        /// <summary>Gets the current drawing state and saves it into the supplied IDrawingStatckBlock.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SaveDrawingState(ID2D1DCRenderTarget* This, ID2D1DrawingStateBlock* drawingStateBlock);

        /// <summary>Copies the state stored in the block interface.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _RestoreDrawingState(ID2D1DCRenderTarget* This, ID2D1DrawingStateBlock* drawingStateBlock);

        /// <summary>Pushes a clip. The clip can be antialiased. The clip must be axis aligned. If the current world transform is not axis preserving, then the bounding box of the transformed clip rect will be used. The clip will remain in effect until a PopAxisAligned clip call is made.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PushAxisAlignedClip(ID2D1DCRenderTarget* This, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PopAxisAlignedClip(ID2D1DCRenderTarget* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Clear(ID2D1DCRenderTarget* This, [NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* clearColor = null);

        /// <summary>Start drawing on this render target. Draw calls can only be issued between a BeginDraw and EndDraw call.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _BeginDraw(ID2D1DCRenderTarget* This);

        /// <summary>Ends drawing on the render target, error results can be retrieved at this time, or when calling flush.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EndDraw(ID2D1DCRenderTarget* This, [NativeTypeName("D2D1_TAG")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG")] ulong* tag2 = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_PIXEL_FORMAT* _GetPixelFormat(ID2D1DCRenderTarget* This, D2D1_PIXEL_FORMAT* _result);

        /// <summary>Sets the DPI on the render target. This results in the render target being interpreted to a different scale. Neither DPI can be negative. If zero is specified for both, the system DPI is chosen. If one is zero and the other unspecified, the DPI is not changed.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetDpi(ID2D1DCRenderTarget* This, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY);

        /// <summary>Return the current DPI from the target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDpi(ID2D1DCRenderTarget* This, [NativeTypeName("FLOAT")] float* dpiX, [NativeTypeName("FLOAT")] float* dpiY);

        /// <summary>Returns the size of the render target in DIPs.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        public delegate D2D_SIZE_F* _GetSize(ID2D1DCRenderTarget* This, D2D_SIZE_F* _result);

        /// <summary>Returns the size of the render target in pixels.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_SIZE_U")]
        public delegate D2D_SIZE_U* _GetPixelSize(ID2D1DCRenderTarget* This, D2D_SIZE_U* _result);

        /// <summary>Returns the maximum bitmap and render target size that is guaranteed to be supported by the render target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetMaximumBitmapSize(ID2D1DCRenderTarget* This);

        /// <summary>Returns true if the given properties are supported by this render target. The DPI is ignored. NOTE: If the render target type is software, then neither D2D1_FEATURE_LEVEL_9 nor D2D1_FEATURE_LEVEL_10 will be considered to be supported.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsSupported(ID2D1DCRenderTarget* This, D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindDC(ID2D1DCRenderTarget* This, [NativeTypeName("HDC")] IntPtr hDC, RECT* pSubRect);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [Optional] void* srcData, [NativeTypeName("UINT32")] uint pitch, D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmap>(lpVtbl->CreateBitmap)(This, size, srcData, pitch, bitmapProperties, bitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, [Optional] D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromWicBitmap>(lpVtbl->CreateBitmapFromWicBitmap)(This, wicBitmapSource, bitmapProperties, bitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSharedBitmap([NativeTypeName("REFIID")] Guid* riid, void* data, [Optional] D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSharedBitmap>(lpVtbl->CreateSharedBitmap)(This, riid, data, bitmapProperties, bitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([Optional] ID2D1Bitmap* bitmap, [Optional] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateBitmapBrush>(lpVtbl->CreateBitmapBrush)(This, bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSolidColorBrush([NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSolidColorBrush>(lpVtbl->CreateSolidColorBrush)(This, color, brushProperties, solidColorBrush);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGradientStopCollection([NativeTypeName("D2D1_GRADIENT_STOP[]")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, ID2D1GradientStopCollection** gradientStopCollection)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateGradientStopCollection>(lpVtbl->CreateGradientStopCollection)(This, gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLinearGradientBrush(D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateLinearGradientBrush>(lpVtbl->CreateLinearGradientBrush)(This, linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRadialGradientBrush(D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, [Optional] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateRadialGradientBrush>(lpVtbl->CreateRadialGradientBrush)(This, radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([Optional, NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F* desiredSize, [Optional, NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U* desiredPixelSize, [Optional] D2D1_PIXEL_FORMAT* desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateCompatibleRenderTarget>(lpVtbl->CreateCompatibleRenderTarget)(This, desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLayer([Optional, NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F* size, ID2D1Layer** layer)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateLayer>(lpVtbl->CreateLayer)(This, size, layer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMesh(ID2D1Mesh** mesh)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateMesh>(lpVtbl->CreateMesh)(This, mesh);
            }
        }

        public void DrawLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawLine>(lpVtbl->DrawLine)(This, point0, point1, brush, strokeWidth, strokeStyle);
            }
        }

        public void DrawRectangle([NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rect, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawRectangle>(lpVtbl->DrawRectangle)(This, rect, brush, strokeWidth, strokeStyle);
            }
        }

        public void FillRectangle([NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* rect, ID2D1Brush* brush)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_FillRectangle>(lpVtbl->FillRectangle)(This, rect, brush);
            }
        }

        public void DrawRoundedRectangle(D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawRoundedRectangle>(lpVtbl->DrawRoundedRectangle)(This, roundedRect, brush, strokeWidth, strokeStyle);
            }
        }

        public void FillRoundedRectangle(D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_FillRoundedRectangle>(lpVtbl->FillRoundedRectangle)(This, roundedRect, brush);
            }
        }

        public void DrawEllipse(D2D1_ELLIPSE* ellipse, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawEllipse>(lpVtbl->DrawEllipse)(This, ellipse, brush, strokeWidth, strokeStyle);
            }
        }

        public void FillEllipse(D2D1_ELLIPSE* ellipse, ID2D1Brush* brush)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_FillEllipse>(lpVtbl->FillEllipse)(This, ellipse, brush);
            }
        }

        public void DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawGeometry>(lpVtbl->DrawGeometry)(This, geometry, brush, strokeWidth, strokeStyle);
            }
        }

        public void FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush = null)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_FillGeometry>(lpVtbl->FillGeometry)(This, geometry, brush, opacityBrush);
            }
        }

        public void FillMesh(ID2D1Mesh* mesh, ID2D1Brush* brush)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_FillMesh>(lpVtbl->FillMesh)(This, mesh, brush);
            }
        }

        public void FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, D2D1_OPACITY_MASK_CONTENT content, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_FillOpacityMask>(lpVtbl->FillOpacityMask)(This, opacityMask, brush, content, destinationRectangle, sourceRectangle);
            }
        }

        public void DrawBitmap(ID2D1Bitmap* bitmap, [Optional, NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle, [NativeTypeName("FLOAT")] float opacity = 1.0f, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawBitmap>(lpVtbl->DrawBitmap)(This, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
            }
        }

        public void DrawText([NativeTypeName("WCHAR[]")] char* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* layoutRect, ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawText>(lpVtbl->DrawText)(This, @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
            }
        }

        public void DrawTextLayout([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin, IDWriteTextLayout* textLayout, ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawTextLayout>(lpVtbl->DrawTextLayout)(This, origin, textLayout, defaultFillBrush, options);
            }
        }

        public void DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, DWRITE_GLYPH_RUN* glyphRun, ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_DrawGlyphRun>(lpVtbl->DrawGlyphRun)(This, baselineOrigin, glyphRun, foregroundBrush, measuringMode);
            }
        }

        public void SetTransform([NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetTransform>(lpVtbl->SetTransform)(This, transform);
            }
        }

        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetTransform>(lpVtbl->GetTransform)(This, transform);
            }
        }

        public void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetAntialiasMode>(lpVtbl->SetAntialiasMode)(This, antialiasMode);
            }
        }

        public D2D1_ANTIALIAS_MODE GetAntialiasMode()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAntialiasMode>(lpVtbl->GetAntialiasMode)(This);
            }
        }

        public void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetTextAntialiasMode>(lpVtbl->SetTextAntialiasMode)(This, textAntialiasMode);
            }
        }

        public D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTextAntialiasMode>(lpVtbl->GetTextAntialiasMode)(This);
            }
        }

        public void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams = null)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetTextRenderingParams>(lpVtbl->SetTextRenderingParams)(This, textRenderingParams);
            }
        }

        public void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetTextRenderingParams>(lpVtbl->GetTextRenderingParams)(This, textRenderingParams);
            }
        }

        public void SetTags([NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetTags>(lpVtbl->SetTags)(This, tag1, tag2);
            }
        }

        public void GetTags([NativeTypeName("D2D1_TAG")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG")] ulong* tag2 = null)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetTags>(lpVtbl->GetTags)(This, tag1, tag2);
            }
        }

        public void PushLayer(D2D1_LAYER_PARAMETERS* layerParameters, ID2D1Layer* layer = null)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_PushLayer>(lpVtbl->PushLayer)(This, layerParameters, layer);
            }
        }

        public void PopLayer()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_PopLayer>(lpVtbl->PopLayer)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Flush([NativeTypeName("D2D1_TAG")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG")] ulong* tag2 = null)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Flush>(lpVtbl->Flush)(This, tag1, tag2);
            }
        }

        public void SaveDrawingState(ID2D1DrawingStateBlock* drawingStateBlock)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SaveDrawingState>(lpVtbl->SaveDrawingState)(This, drawingStateBlock);
            }
        }

        public void RestoreDrawingState(ID2D1DrawingStateBlock* drawingStateBlock)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_RestoreDrawingState>(lpVtbl->RestoreDrawingState)(This, drawingStateBlock);
            }
        }

        public void PushAxisAlignedClip([NativeTypeName("D2D1_RECT_F")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_PushAxisAlignedClip>(lpVtbl->PushAxisAlignedClip)(This, clipRect, antialiasMode);
            }
        }

        public void PopAxisAlignedClip()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_PopAxisAlignedClip>(lpVtbl->PopAxisAlignedClip)(This);
            }
        }

        public void Clear([NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* clearColor = null)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_Clear>(lpVtbl->Clear)(This, clearColor);
            }
        }

        public void BeginDraw()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_BeginDraw>(lpVtbl->BeginDraw)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EndDraw([NativeTypeName("D2D1_TAG")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG")] ulong* tag2 = null)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EndDraw>(lpVtbl->EndDraw)(This, tag1, tag2);
            }
        }

        public D2D1_PIXEL_FORMAT GetPixelFormat()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                D2D1_PIXEL_FORMAT result;
                return *Marshal.GetDelegateForFunctionPointer<_GetPixelFormat>(lpVtbl->GetPixelFormat)(This, &result);
            }
        }

        public void SetDpi([NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetDpi>(lpVtbl->SetDpi)(This, dpiX, dpiY);
            }
        }

        public void GetDpi([NativeTypeName("FLOAT")] float* dpiX, [NativeTypeName("FLOAT")] float* dpiY)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDpi>(lpVtbl->GetDpi)(This, dpiX, dpiY);
            }
        }

        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetSize()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                D2D_SIZE_F result;
                return *Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)(This, &result);
            }
        }

        [return: NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U GetPixelSize()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                D2D_SIZE_U result;
                return *Marshal.GetDelegateForFunctionPointer<_GetPixelSize>(lpVtbl->GetPixelSize)(This, &result);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetMaximumBitmapSize()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMaximumBitmapSize>(lpVtbl->GetMaximumBitmapSize)(This);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsSupported(D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsSupported>(lpVtbl->IsSupported)(This, renderTargetProperties);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int BindDC([NativeTypeName("HDC")] IntPtr hDC, RECT* pSubRect)
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_BindDC>(lpVtbl->BindDC)(This, hDC, pSubRect);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr CreateBitmap;

            public IntPtr CreateBitmapFromWicBitmap;

            public IntPtr CreateSharedBitmap;

            public IntPtr CreateBitmapBrush;

            public IntPtr CreateSolidColorBrush;

            public IntPtr CreateGradientStopCollection;

            public IntPtr CreateLinearGradientBrush;

            public IntPtr CreateRadialGradientBrush;

            public IntPtr CreateCompatibleRenderTarget;

            public IntPtr CreateLayer;

            public IntPtr CreateMesh;

            public IntPtr DrawLine;

            public IntPtr DrawRectangle;

            public IntPtr FillRectangle;

            public IntPtr DrawRoundedRectangle;

            public IntPtr FillRoundedRectangle;

            public IntPtr DrawEllipse;

            public IntPtr FillEllipse;

            public IntPtr DrawGeometry;

            public IntPtr FillGeometry;

            public IntPtr FillMesh;

            public IntPtr FillOpacityMask;

            public IntPtr DrawBitmap;

            public IntPtr DrawText;

            public IntPtr DrawTextLayout;

            public IntPtr DrawGlyphRun;

            public IntPtr SetTransform;

            public IntPtr GetTransform;

            public IntPtr SetAntialiasMode;

            public IntPtr GetAntialiasMode;

            public IntPtr SetTextAntialiasMode;

            public IntPtr GetTextAntialiasMode;

            public IntPtr SetTextRenderingParams;

            public IntPtr GetTextRenderingParams;

            public IntPtr SetTags;

            public IntPtr GetTags;

            public IntPtr PushLayer;

            public IntPtr PopLayer;

            public IntPtr Flush;

            public IntPtr SaveDrawingState;

            public IntPtr RestoreDrawingState;

            public IntPtr PushAxisAlignedClip;

            public IntPtr PopAxisAlignedClip;

            public IntPtr Clear;

            public IntPtr BeginDraw;

            public IntPtr EndDraw;

            public IntPtr GetPixelFormat;

            public IntPtr SetDpi;

            public IntPtr GetDpi;

            public IntPtr GetSize;

            public IntPtr GetPixelSize;

            public IntPtr GetMaximumBitmapSize;

            public IntPtr IsSupported;

            public IntPtr BindDC;
        }
    }
}
