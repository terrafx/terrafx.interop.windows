// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public static unsafe partial class D2D1
    {
        private const string DllName = nameof(D2D1);

        public const ulong D2D1_INVALID_TAG = ULONGLONG_MAX;

        public const float D2D1_DEFAULT_FLATTENING_TOLERANCE = 0.25f;

        // This defines the superset of interpolation mode supported by D2D APIs and built-in effects

        public const int D2D1_INTERPOLATION_MODE_DEFINITION_NEAREST_NEIGHBOR = 0;

        public const int D2D1_INTERPOLATION_MODE_DEFINITION_LINEAR = 1;

        public const int D2D1_INTERPOLATION_MODE_DEFINITION_CUBIC = 2;

        public const int D2D1_INTERPOLATION_MODE_DEFINITION_MULTI_SAMPLE_LINEAR = 3;

        public const int D2D1_INTERPOLATION_MODE_DEFINITION_ANISOTROPIC = 4;

        public const int D2D1_INTERPOLATION_MODE_DEFINITION_HIGH_QUALITY_CUBIC = 5;

        public const int D2D1_INTERPOLATION_MODE_DEFINITION_FANT = 6;

        public const int D2D1_INTERPOLATION_MODE_DEFINITION_MIPMAP_LINEAR = 7;

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

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D2D1CreateFactory", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D2D1CreateFactory(
            [In] D2D1_FACTORY_TYPE factoryType,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [In, Optional] D2D1_FACTORY_OPTIONS* pFactoryOptions,
            [Out] void** ppIFactory
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D2D1MakeRotateMatrix", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void D2D1MakeRotateMatrix(
            [In, NativeTypeName("FLOAT")] float angle,
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center,
            [Out, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* matrix
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D2D1MakeSkewMatrix", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void D2D1MakeSkewMatrix(
            [In, NativeTypeName("FLOAT")] float angleX,
            [In, NativeTypeName("FLOAT")] float angleY,
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center,
            [Out, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* matrix
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D2D1IsMatrixInvertible", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("BOOL")]
        public static extern int D2D1IsMatrixInvertible(
            [In, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* matrix
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D2D1InvertMatrix", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("BOOL")]
        public static extern int D2D1InvertMatrix(
            [In, Out, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* matrix
        );
    }
}
