// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    public static unsafe partial class D2D1
    {
        #region Constants
        public const uint D2D1_INVALID_PROPERTY_INDEX = uint.MaxValue;
        #endregion

        #region IID_* Constants
        public static readonly Guid IID_ID2D1GdiMetafileSink = new Guid(0x82237326, 0x8111, 0x4F7C, 0xBC, 0xF4, 0xB5, 0xC1, 0x17, 0x55, 0x64, 0xFE);

        public static readonly Guid IID_ID2D1GdiMetafile = new Guid(0x2F543DC3, 0xCFC1, 0x4211, 0x86, 0x4F, 0xCF, 0xD9, 0x1C, 0x6F, 0x33, 0x95);

        public static readonly Guid IID_ID2D1CommandSink = new Guid(0x54D7898A, 0xA061, 0x40A7, 0xBE, 0xC7, 0xE4, 0x65, 0xBC, 0xBA, 0x2C, 0x4F);

        public static readonly Guid IID_ID2D1CommandList = new Guid(0xB4F34A19, 0x2383, 0x4D76, 0x94, 0xF6, 0xEC, 0x34, 0x36, 0x57, 0xC3, 0xDC);

        public static readonly Guid IID_ID2D1PrintControl = new Guid(0x2C1D867D, 0xC290, 0x41C8, 0xAE, 0x7E, 0x34, 0xA9, 0x87, 0x02, 0xE9, 0xA5);

        public static readonly Guid IID_ID2D1ImageBrush = new Guid(0xFE9E984D, 0x3F95, 0x407C, 0xB5, 0xDB, 0xCB, 0x94, 0xD4, 0xE8, 0xF8, 0x7C);

        public static readonly Guid IID_ID2D1BitmapBrush1 = new Guid(0x41343A53, 0xE41A, 0x49A2, 0x91, 0xCD, 0x21, 0x79, 0x3B, 0xBB, 0x62, 0xE5);

        public static readonly Guid IID_ID2D1StrokeStyle1 = new Guid(0x10A72A66, 0xE91C, 0x43F4, 0x99, 0x3F, 0xDD, 0xF4, 0xB8, 0x2B, 0x0B, 0x4A);

        public static readonly Guid IID_ID2D1PathGeometry1 = new Guid(0x62BAA2D2, 0xAB54, 0x41B7, 0xB8, 0x72, 0x78, 0x7E, 0x01, 0x06, 0xA4, 0x21);

        public static readonly Guid IID_ID2D1Properties = new Guid(0x483473D7, 0xCD46, 0x4F9D, 0x9D, 0x3A, 0x31, 0x12, 0xAA, 0x80, 0x15, 0x9D);

        public static readonly Guid IID_ID2D1Effect = new Guid(0x28211A43, 0x7D89, 0x476F, 0x81, 0x81, 0x2D, 0x61, 0x59, 0xB2, 0x20, 0xAD);

        public static readonly Guid IID_ID2D1Bitmap1 = new Guid(0xA898A84C, 0x3873, 0x4588, 0xB0, 0x8B, 0xEB, 0xBF, 0x97, 0x8D, 0xF0, 0x41);

        public static readonly Guid IID_ID2D1ColorContext = new Guid(0x1C4820BB, 0x5771, 0x4518, 0xA5, 0x81, 0x2F, 0xE4, 0xDD, 0x0E, 0xC6, 0x57);

        public static readonly Guid IID_ID2D1GradientStopCollection1 = new Guid(0xAE1572F4, 0x5DD0, 0x4777, 0x99, 0x8B, 0x92, 0x79, 0x47, 0x2A, 0xE6, 0x3B);

        public static readonly Guid IID_ID2D1DrawingStateBlock1 = new Guid(0x689F1F85, 0xC72E, 0x4E33, 0x8F, 0x19, 0x85, 0x75, 0x4E, 0xFD, 0x5A, 0xCE);

        public static readonly Guid IID_ID2D1DeviceContext = new Guid(0xE8F7FE7A, 0x191C, 0x466D, 0xAD, 0x95, 0x97, 0x56, 0x78, 0xBD, 0xA9, 0x98);

        public static readonly Guid IID_ID2D1Device = new Guid(0x47DD575D, 0xAC05, 0x4CDD, 0x80, 0x49, 0x9B, 0x02, 0xCD, 0x16, 0xF4, 0x4C);

        public static readonly Guid IID_ID2D1Factory1 = new Guid(0xBB12D362, 0xDAEE, 0x4B9A, 0xAA, 0x1D, 0x14, 0xBA, 0x40, 0x1C, 0xFA, 0x1F);

        public static readonly Guid IID_ID2D1Multithread = new Guid(0x31E6E7BC, 0xE0FF, 0x4D46, 0x8C, 0x64, 0xA0, 0xA8, 0xC4, 0x1C, 0x15, 0xD3);
        #endregion

        #region External Methods
        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D2D1CreateDevice", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D2D1CreateDevice(
            [In] IDXGIDevice* dxgiDevice,
            [In, Optional] D2D1_CREATION_PROPERTIES* creationProperties,
            [Out] ID2D1Device** d2dDevice
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D2D1CreateDeviceContext", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int D2D1CreateDeviceContext(
            [In] IDXGISurface* dxgiSurface,
            [In, Optional] D2D1_CREATION_PROPERTIES* creationProperties,
            [Out] ID2D1DeviceContext** d2dDeviceContext
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D2D1ConvertColorSpace", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("D2D1_COLOR_F")]
        public static extern DXGI_RGBA D2D1ConvertColorSpace(
            [In] D2D1_COLOR_SPACE sourceColorSpace,
            [In] D2D1_COLOR_SPACE destinationColorSpace,
            [In, NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D2D1SinCos", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        public static extern void D2D1SinCos(
          [In, NativeTypeName("FLOAT")] float angle,
          [Out, NativeTypeName("FLOAT")] float* s,
          [Out, NativeTypeName("FLOAT")] float* c
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D2D1Tan", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("FLOAT")]
        public static extern float D2D1Tan(
            [In, NativeTypeName("FLOAT")] float angle
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D2D1Vec3Length", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("FLOAT")]
        public static extern float D2D1Vec3Length(
          [In, NativeTypeName("FLOAT")] float x,
          [In, NativeTypeName("FLOAT")] float y,
          [In, NativeTypeName("FLOAT")] float z
        );
        #endregion
    }
}
