// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_ANTIALIAS_MODE;
using static TerraFX.Interop.D2D1_BITMAP_OPTIONS;
using static TerraFX.Interop.D2D1_BORDER_MODE;
using static TerraFX.Interop.D2D1_CAP_STYLE;
using static TerraFX.Interop.D2D1_COLOR_SPACE;
using static TerraFX.Interop.D2D1_DASH_STYLE;
using static TerraFX.Interop.D2D1_DPICOMPENSATION_PROP;
using static TerraFX.Interop.D2D1_EXTEND_MODE;
using static TerraFX.Interop.D2D1_INTERPOLATION_MODE;
using static TerraFX.Interop.D2D1_LAYER_OPTIONS1;
using static TerraFX.Interop.D2D1_LINE_JOIN;
using static TerraFX.Interop.D2D1_PRIMITIVE_BLEND;
using static TerraFX.Interop.D2D1_PRINT_FONT_SUBSET_MODE;
using static TerraFX.Interop.D2D1_STROKE_TRANSFORM_TYPE;
using static TerraFX.Interop.D2D1_TEXT_ANTIALIAS_MODE;
using static TerraFX.Interop.D2D1_UNIT_MODE;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [return: NativeTypeName("D2D1_COLOR_F")]
        public static DXGI_RGBA ConvertColorSpace(D2D1_COLOR_SPACE sourceColorSpace, D2D1_COLOR_SPACE destinationColorSpace, [NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color)
        {
            return D2D1ConvertColorSpace(sourceColorSpace, destinationColorSpace, color);
        }

        public static D2D1_DRAWING_STATE_DESCRIPTION1 DrawingStateDescription1(D2D1_ANTIALIAS_MODE antialiasMode = D2D1_ANTIALIAS_MODE_PER_PRIMITIVE, D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode = D2D1_TEXT_ANTIALIAS_MODE_DEFAULT, [NativeTypeName("D2D1_TAG")] ulong tag1 = 0, [NativeTypeName("D2D1_TAG")] ulong tag2 = 0, D2D1_PRIMITIVE_BLEND primitiveBlend = D2D1_PRIMITIVE_BLEND_SOURCE_OVER, D2D1_UNIT_MODE unitMode = D2D1_UNIT_MODE_DIPS)
        {
            return DrawingStateDescription1(antialiasMode, textAntialiasMode, tag1, tag2, IdentityMatrix, primitiveBlend, unitMode);
        }

        public static D2D1_DRAWING_STATE_DESCRIPTION1 DrawingStateDescription1([Optional] D2D1_ANTIALIAS_MODE antialiasMode, [Optional] D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode, [NativeTypeName("D2D1_TAG"), Optional] ulong tag1, [NativeTypeName("D2D1_TAG"), Optional] ulong tag2, [NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2D_MATRIX_3X2_F transform, D2D1_PRIMITIVE_BLEND primitiveBlend = D2D1_PRIMITIVE_BLEND_SOURCE_OVER, D2D1_UNIT_MODE unitMode = D2D1_UNIT_MODE_DIPS)
        {
            D2D1_DRAWING_STATE_DESCRIPTION1 drawingStateDescription1;

            drawingStateDescription1.antialiasMode = antialiasMode;
            drawingStateDescription1.textAntialiasMode = textAntialiasMode;
            drawingStateDescription1.tag1 = tag1;
            drawingStateDescription1.tag2 = tag2;
            drawingStateDescription1.transform = transform;
            drawingStateDescription1.primitiveBlend = primitiveBlend;
            drawingStateDescription1.unitMode = unitMode;

            return drawingStateDescription1;
        }

        public static D2D1_DRAWING_STATE_DESCRIPTION1 DrawingStateDescription1([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION &")] in D2D1_DRAWING_STATE_DESCRIPTION desc, D2D1_PRIMITIVE_BLEND primitiveBlend = D2D1_PRIMITIVE_BLEND_SOURCE_OVER, D2D1_UNIT_MODE unitMode = D2D1_UNIT_MODE_DIPS)
        {
            D2D1_DRAWING_STATE_DESCRIPTION1 drawingStateDescription1;

            drawingStateDescription1.antialiasMode = desc.antialiasMode;
            drawingStateDescription1.textAntialiasMode = desc.textAntialiasMode;
            drawingStateDescription1.tag1 = desc.tag1;
            drawingStateDescription1.tag2 = desc.tag2;
            drawingStateDescription1.transform = desc.transform;
            drawingStateDescription1.primitiveBlend = primitiveBlend;
            drawingStateDescription1.unitMode = unitMode;

            return drawingStateDescription1;
        }

        public static D2D1_BITMAP_PROPERTIES1 BitmapProperties1(D2D1_BITMAP_OPTIONS bitmapOptions = D2D1_BITMAP_OPTIONS_NONE, [NativeTypeName("const D2D1_PIXEL_FORMAT")] D2D1_PIXEL_FORMAT pixelFormat = default, [NativeTypeName("FLOAT")] float dpiX = 96.0f, [NativeTypeName("FLOAT")] float dpiY = 96.0f, ID2D1ColorContext *colorContext = null)
        {
            D2D1_BITMAP_PROPERTIES1 bitmapProperties = new D2D1_BITMAP_PROPERTIES1
            {
                pixelFormat = pixelFormat,
                dpiX = dpiX,
                dpiY = dpiY,
                bitmapOptions = bitmapOptions,
                colorContext = colorContext
            };
            return bitmapProperties;
        }

        public static D2D1_LAYER_PARAMETERS1 LayerParameters1([NativeTypeName("ID2D1Geometry *"), Optional] ID2D1Geometry* geometricMask, [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode, [NativeTypeName("FLOAT")] float opacity = 1.0f, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush = null, D2D1_LAYER_OPTIONS1 layerOptions = D2D1_LAYER_OPTIONS1_NONE)
        {
            return LayerParameters1(InfiniteRect, geometricMask, maskAntialiasMode, IdentityMatrix, opacity, opacityBrush, layerOptions);
        }

        public static D2D1_LAYER_PARAMETERS1 LayerParameters1([NativeTypeName("const D2D1_RECT_F")] in D2D_RECT_F contentBounds, [NativeTypeName("ID2D1Geometry *"), Optional] ID2D1Geometry* geometricMask, [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode, [NativeTypeName("FLOAT")] float opacity = 1.0f, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush = null, D2D1_LAYER_OPTIONS1 layerOptions = D2D1_LAYER_OPTIONS1_NONE)
        {
            return LayerParameters1(contentBounds, geometricMask, maskAntialiasMode, IdentityMatrix, opacity, opacityBrush, layerOptions);
        }

        public static D2D1_LAYER_PARAMETERS1 LayerParameters1([NativeTypeName("ID2D1Geometry *"), Optional] ID2D1Geometry* geometricMask, [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F maskTransform, [NativeTypeName("FLOAT")] float opacity = 1.0f, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush = null, D2D1_LAYER_OPTIONS1 layerOptions = D2D1_LAYER_OPTIONS1_NONE)
        {
            return LayerParameters1(InfiniteRect, geometricMask, maskAntialiasMode, maskTransform, opacity, opacityBrush, layerOptions);
        }

        public static D2D1_LAYER_PARAMETERS1 LayerParameters1([NativeTypeName("const D2D1_RECT_F")] in D2D_RECT_F contentBounds, [NativeTypeName("ID2D1Geometry *"), Optional] ID2D1Geometry* geometricMask, [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode, [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F maskTransform, [NativeTypeName("FLOAT")] float opacity = 1.0f, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush = null, D2D1_LAYER_OPTIONS1 layerOptions = D2D1_LAYER_OPTIONS1_NONE)
        {
            D2D1_LAYER_PARAMETERS1 layerParameters = default;

            layerParameters.contentBounds = contentBounds;
            layerParameters.geometricMask = geometricMask;
            layerParameters.maskAntialiasMode = maskAntialiasMode;
            layerParameters.maskTransform = maskTransform;
            layerParameters.opacity = opacity;
            layerParameters.opacityBrush = opacityBrush;
            layerParameters.layerOptions = layerOptions;

            return layerParameters;
        }

        public static D2D1_STROKE_STYLE_PROPERTIES1 StrokeStyleProperties1(D2D1_CAP_STYLE startCap = D2D1_CAP_STYLE_FLAT, D2D1_CAP_STYLE endCap = D2D1_CAP_STYLE_FLAT, D2D1_CAP_STYLE dashCap = D2D1_CAP_STYLE_FLAT, D2D1_LINE_JOIN lineJoin = D2D1_LINE_JOIN_MITER, [NativeTypeName("FLOAT")] float miterLimit = 10.0f, D2D1_DASH_STYLE dashStyle = D2D1_DASH_STYLE_SOLID, [NativeTypeName("FLOAT")] float dashOffset = 0.0f, D2D1_STROKE_TRANSFORM_TYPE transformType = D2D1_STROKE_TRANSFORM_TYPE_NORMAL)
        {
            D2D1_STROKE_STYLE_PROPERTIES1 strokeStyleProperties;

            strokeStyleProperties.startCap = startCap;
            strokeStyleProperties.endCap = endCap;
            strokeStyleProperties.dashCap = dashCap;
            strokeStyleProperties.lineJoin = lineJoin;
            strokeStyleProperties.miterLimit = miterLimit;
            strokeStyleProperties.dashStyle = dashStyle;
            strokeStyleProperties.dashOffset = dashOffset;
            strokeStyleProperties.transformType = transformType;

            return strokeStyleProperties;
        }

        public static D2D1_IMAGE_BRUSH_PROPERTIES ImageBrushProperties([NativeTypeName("D2D1_RECT_F")] D2D_RECT_F sourceRectangle, D2D1_EXTEND_MODE extendModeX = D2D1_EXTEND_MODE_CLAMP, D2D1_EXTEND_MODE extendModeY = D2D1_EXTEND_MODE_CLAMP, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR)
        {
            D2D1_IMAGE_BRUSH_PROPERTIES imageBrushProperties;

            imageBrushProperties.extendModeX = extendModeX;
            imageBrushProperties.extendModeY = extendModeY;
            imageBrushProperties.interpolationMode = interpolationMode;
            imageBrushProperties.sourceRectangle = sourceRectangle;

            return imageBrushProperties;
        }

        public static D2D1_BITMAP_BRUSH_PROPERTIES1 BitmapBrushProperties1(D2D1_EXTEND_MODE extendModeX = D2D1_EXTEND_MODE_CLAMP, D2D1_EXTEND_MODE extendModeY = D2D1_EXTEND_MODE_CLAMP, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR)
        {
            D2D1_BITMAP_BRUSH_PROPERTIES1 bitmapBrush1Properties;

            bitmapBrush1Properties.extendModeX = extendModeX;
            bitmapBrush1Properties.extendModeY = extendModeY;
            bitmapBrush1Properties.interpolationMode = interpolationMode;

            return bitmapBrush1Properties;
        }

        public static D2D1_PRINT_CONTROL_PROPERTIES PrintControlProperties(D2D1_PRINT_FONT_SUBSET_MODE fontSubsetMode = D2D1_PRINT_FONT_SUBSET_MODE_DEFAULT, [NativeTypeName("FLOAT")] float rasterDpi = 150.0f, D2D1_COLOR_SPACE colorSpace = D2D1_COLOR_SPACE_SRGB)
        {
            D2D1_PRINT_CONTROL_PROPERTIES printControlProps;

            printControlProps.fontSubset = fontSubsetMode;
            printControlProps.rasterDPI = rasterDpi;
            printControlProps.colorSpace = colorSpace;

            return printControlProps;
        }

        public static D2D1_RENDERING_CONTROLS RenderingControls(D2D1_BUFFER_PRECISION bufferPrecision, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U tileSize)
        {
            D2D1_RENDERING_CONTROLS renderingControls;

            renderingControls.bufferPrecision = bufferPrecision;
            renderingControls.tileSize = tileSize;

            return renderingControls;
        }

        public static D2D1_EFFECT_INPUT_DESCRIPTION EffectInputDescription([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("UINT32")] uint inputIndex, [NativeTypeName("D2D1_RECT_F")] D2D_RECT_F inputRectangle)
        {
            D2D1_EFFECT_INPUT_DESCRIPTION description;

            description.effect = effect;
            description.inputIndex = inputIndex;
            description.inputRectangle = inputRectangle;

            return description;
        }

        public static D2D1_CREATION_PROPERTIES CreationProperties(D2D1_THREADING_MODE threadingMode, D2D1_DEBUG_LEVEL debugLevel, D2D1_DEVICE_CONTEXT_OPTIONS options)
        {
            D2D1_CREATION_PROPERTIES creationProperties;

            creationProperties.threadingMode = threadingMode;
            creationProperties.debugLevel = debugLevel;
            creationProperties.options = options;

            return creationProperties;
        }

        [return: NativeTypeName("D2D1_VECTOR_2F")]
        public static D2D_VECTOR_2F Vector2F([NativeTypeName("FLOAT")] float x = 0.0f, [NativeTypeName("FLOAT")] float y = 0.0f)
        {
            D2D_VECTOR_2F vec2 = new D2D_VECTOR_2F
            {
                x = x,
                y = y,
            };
            return vec2;
        }

        [return: NativeTypeName("D2D1_VECTOR_2F")]
        public static D2D_VECTOR_3F Vector3F([NativeTypeName("FLOAT")] float x = 0.0f, [NativeTypeName("FLOAT")] float y = 0.0f, [NativeTypeName("FLOAT")] float z = 0.0f)
        {
            D2D_VECTOR_3F vec3 = new D2D_VECTOR_3F
            {
                x = x,
                y = y,
                z = z,
            };
            return vec3;
        }

        [return: NativeTypeName("D2D1_VECTOR_2F")]
        public static D2D_VECTOR_4F Vector4F([NativeTypeName("FLOAT")] float x = 0.0f, [NativeTypeName("FLOAT")] float y = 0.0f, [NativeTypeName("FLOAT")] float z = 0.0f, [NativeTypeName("FLOAT")] float w = 0.0f)
        {
            D2D_VECTOR_4F vec4 = new D2D_VECTOR_4F
            {
                x = x,
                y = y,
                z = z,
                w = w,
            };
            return vec4;
        }

        [return: NativeTypeName("D2D1_POINT_2L")]
        public static POINT Point2L([NativeTypeName("INT32")] int x = 0, [NativeTypeName("INT32")] int y = 0)
        {
            POINT point = new POINT
            {
                x = x,
                y = y,
            };
            return point;
        }

        [return: NativeTypeName("D2D1_RECT_L")]
        public static RECT RectL([NativeTypeName("INT32")] int left = 0, [NativeTypeName("INT32")] int top = 0, [NativeTypeName("INT32")] int right = 0, [NativeTypeName("INT32")] int bottom = 0)
        {
            RECT rect = new RECT
            {
                left = left,
                top = top,
                right = right,
                bottom = bottom,
            };
            return rect;
        }

        [return: NativeTypeName("HRESULT")]
        public static int SetDpiCompensatedEffectInput([NativeTypeName("ID2D1DeviceContext *")] ID2D1DeviceContext *deviceContext, [NativeTypeName("ID2D1Effect *")] ID2D1Effect *effect, [NativeTypeName("UINT32")] uint inputIndex, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* inputBitmap, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_BORDER_MODE borderMode = D2D1_BORDER_MODE_HARD)
        {
            int hr = S_OK;
            ID2D1Effect *dpiCompensationEffect = null;

            if (inputBitmap != null)
            {
                effect->SetInput(inputIndex, null);
                return hr;
            }

            Guid effectId = CLSID_D2D1DpiCompensation;
            hr = deviceContext->CreateEffect(&effectId, &dpiCompensationEffect);

            if (SUCCEEDED(hr))
            {
                if (SUCCEEDED(hr))
                {
                    dpiCompensationEffect->SetInput(0, (ID2D1Image*)inputBitmap);

                    D2D_POINT_2F bitmapDpi;

                    inputBitmap->GetDpi(&bitmapDpi.x, &bitmapDpi.y);
                    hr = dpiCompensationEffect->SetValue(D2D1_DPICOMPENSATION_PROP_INPUT_DPI, &bitmapDpi);
                }

                if (SUCCEEDED(hr))
                {
                    hr = dpiCompensationEffect->SetValue(D2D1_DPICOMPENSATION_PROP_INTERPOLATION_MODE, &interpolationMode);
                }

                if (SUCCEEDED(hr))
                {
                    hr = dpiCompensationEffect->SetValue(D2D1_DPICOMPENSATION_PROP_BORDER_MODE, &borderMode);
                }

                if (SUCCEEDED(hr))
                {
                    effect->SetInputEffect(inputIndex, dpiCompensationEffect);
                }

                if (dpiCompensationEffect != null)
                {
                    dpiCompensationEffect->Release();
                }
            }

            return hr;
        }
    }
}
