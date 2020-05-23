// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("d2d1", EntryPoint = "D2D1CreateDevice", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D2D1CreateDevice([NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("const D2D1_CREATION_PROPERTIES *")] D2D1_CREATION_PROPERTIES* creationProperties, [NativeTypeName("ID2D1Device **")] ID2D1Device** d2dDevice);

        [DllImport("d2d1", EntryPoint = "D2D1CreateDeviceContext", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D2D1CreateDeviceContext([NativeTypeName("IDXGISurface *")] IDXGISurface* dxgiSurface, [NativeTypeName("const D2D1_CREATION_PROPERTIES *")] D2D1_CREATION_PROPERTIES* creationProperties, [NativeTypeName("ID2D1DeviceContext **")] ID2D1DeviceContext** d2dDeviceContext);

        [DllImport("d2d1", EntryPoint = "D2D1ConvertColorSpace", ExactSpelling = true)]
        [return: NativeTypeName("D2D1_COLOR_F")]
        public static extern DXGI_RGBA D2D1ConvertColorSpace(D2D1_COLOR_SPACE sourceColorSpace, D2D1_COLOR_SPACE destinationColorSpace, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color);

        [DllImport("d2d1", EntryPoint = "D2D1SinCos", ExactSpelling = true)]
        public static extern void D2D1SinCos([NativeTypeName("FLOAT")] float angle, [NativeTypeName("FLOAT *")] float* s, [NativeTypeName("FLOAT *")] float* c);

        [DllImport("d2d1", EntryPoint = "D2D1Tan", ExactSpelling = true)]
        [return: NativeTypeName("FLOAT")]
        public static extern float D2D1Tan([NativeTypeName("FLOAT")] float angle);

        [DllImport("d2d1", EntryPoint = "D2D1Vec3Length", ExactSpelling = true)]
        [return: NativeTypeName("FLOAT")]
        public static extern float D2D1Vec3Length([NativeTypeName("FLOAT")] float x, [NativeTypeName("FLOAT")] float y, [NativeTypeName("FLOAT")] float z);
    }
}
