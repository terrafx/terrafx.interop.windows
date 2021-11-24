// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows8.0")]
    public static extern HRESULT DCompositionCreateDevice(IDXGIDevice* dxgiDevice, [NativeTypeName("const IID &")] Guid* iid, void** dcompositionDevice);

    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows8.1")]
    public static extern HRESULT DCompositionCreateDevice2(IUnknown* renderingDevice, [NativeTypeName("const IID &")] Guid* iid, void** dcompositionDevice);

    [DllImport("dcomp", ExactSpelling = true)]
    public static extern HRESULT DCompositionCreateDevice3(IUnknown* renderingDevice, [NativeTypeName("const IID &")] Guid* iid, void** dcompositionDevice);

    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows8.0")]
    public static extern HRESULT DCompositionCreateSurfaceHandle([NativeTypeName("DWORD")] uint desiredAccess, SECURITY_ATTRIBUTES* securityAttributes, HANDLE* surfaceHandle);

    [DllImport("dcomp", ExactSpelling = true)]
    public static extern HRESULT DCompositionAttachMouseWheelToHwnd(IDCompositionVisual* visual, HWND hwnd, BOOL enable);

    [DllImport("dcomp", ExactSpelling = true)]
    public static extern HRESULT DCompositionAttachMouseDragToHwnd(IDCompositionVisual* visual, HWND hwnd, BOOL enable);
}
