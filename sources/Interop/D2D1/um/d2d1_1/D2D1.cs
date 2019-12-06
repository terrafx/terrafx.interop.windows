// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class D2D1
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D2D1CreateDevice", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D2D1CreateDevice([NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("const D2D1_CREATION_PROPERTIES *")] D2D1_CREATION_PROPERTIES* creationProperties, [NativeTypeName("ID2D1Device **")] ID2D1Device** d2dDevice);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D2D1CreateDeviceContext", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D2D1CreateDeviceContext([NativeTypeName("IDXGISurface *")] IDXGISurface* dxgiSurface, [NativeTypeName("const D2D1_CREATION_PROPERTIES *")] D2D1_CREATION_PROPERTIES* creationProperties, [NativeTypeName("ID2D1DeviceContext **")] ID2D1DeviceContext** d2dDeviceContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D2D1ConvertColorSpace", ExactSpelling = true)]
        [return: NativeTypeName("D2D1_COLOR_F")]
        public static extern DXGI_RGBA D2D1ConvertColorSpace(D2D1_COLOR_SPACE sourceColorSpace, D2D1_COLOR_SPACE destinationColorSpace, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color);
    }
}
