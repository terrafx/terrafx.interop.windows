// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("d2d1", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("const D2D1_FACTORY_OPTIONS *")] D2D1_FACTORY_OPTIONS* pFactoryOptions, [NativeTypeName("void **")] void** ppIFactory);

        [DllImport("d2d1", ExactSpelling = true)]
        public static extern void D2D1MakeRotateMatrix([NativeTypeName("FLOAT")] float angle, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);

        [DllImport("d2d1", ExactSpelling = true)]
        public static extern void D2D1MakeSkewMatrix([NativeTypeName("FLOAT")] float angleX, [NativeTypeName("FLOAT")] float angleY, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);

        [DllImport("d2d1", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int D2D1IsMatrixInvertible([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);

        [DllImport("d2d1", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int D2D1InvertMatrix([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);

        [return: NativeTypeName("HRESULT")]
        public static int D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** factory)
        {
            return D2D1CreateFactory(factoryType, riid, null, factory);
        }

        [NativeTypeName("#define D2D1_DEFAULT_FLATTENING_TOLERANCE (0.25f)")]
        public const float D2D1_DEFAULT_FLATTENING_TOLERANCE = (0.25f);

        public static readonly Guid IID_ID2D1Resource = new Guid(0x2CD90691, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1Image = new Guid(0x65019F75, 0x8DA2, 0x497C, 0xB3, 0x2C, 0xDF, 0xA3, 0x4E, 0x48, 0xED, 0xE6);

        public static readonly Guid IID_ID2D1Bitmap = new Guid(0xA2296057, 0xEA42, 0x4099, 0x98, 0x3B, 0x53, 0x9F, 0xB6, 0x50, 0x54, 0x26);

        public static readonly Guid IID_ID2D1GradientStopCollection = new Guid(0x2CD906A7, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1Brush = new Guid(0x2CD906A8, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1BitmapBrush = new Guid(0x2CD906AA, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1SolidColorBrush = new Guid(0x2CD906A9, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1LinearGradientBrush = new Guid(0x2CD906AB, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1RadialGradientBrush = new Guid(0x2CD906AC, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1StrokeStyle = new Guid(0x2CD9069D, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1Geometry = new Guid(0x2CD906A1, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1RectangleGeometry = new Guid(0x2CD906A2, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1RoundedRectangleGeometry = new Guid(0x2CD906A3, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1EllipseGeometry = new Guid(0x2CD906A4, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1GeometryGroup = new Guid(0x2CD906A6, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1TransformedGeometry = new Guid(0x2CD906BB, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1SimplifiedGeometrySink = new Guid(0x2CD9069E, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1GeometrySink = new Guid(0x2CD9069F, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1TessellationSink = new Guid(0x2CD906C1, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1PathGeometry = new Guid(0x2CD906A5, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1Mesh = new Guid(0x2CD906C2, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1Layer = new Guid(0x2CD9069B, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1DrawingStateBlock = new Guid(0x28506E39, 0xEBF6, 0x46A1, 0xBB, 0x47, 0xFD, 0x85, 0x56, 0x5A, 0xB9, 0x57);

        public static readonly Guid IID_ID2D1RenderTarget = new Guid(0x2CD90694, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1BitmapRenderTarget = new Guid(0x2CD90695, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1HwndRenderTarget = new Guid(0x2CD90698, 0x12E2, 0x11DC, 0x9F, 0xED, 0x00, 0x11, 0x43, 0xA0, 0x55, 0xF9);

        public static readonly Guid IID_ID2D1GdiInteropRenderTarget = new Guid(0xE0DB51C3, 0x6F77, 0x4BAE, 0xB3, 0xD5, 0xE4, 0x75, 0x09, 0xB3, 0x58, 0x38);

        public static readonly Guid IID_ID2D1DCRenderTarget = new Guid(0x1C51BC64, 0xDE61, 0x46FD, 0x98, 0x99, 0x63, 0xA5, 0xD8, 0xF0, 0x39, 0x50);

        public static readonly Guid IID_ID2D1Factory = new Guid(0x06152247, 0x6F50, 0x465A, 0x92, 0x45, 0x11, 0x8B, 0xFD, 0x3B, 0x60, 0x07);
    }
}
