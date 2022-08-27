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
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionCreateDevice"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DCompositionCreateDevice(IDXGIDevice* dxgiDevice, [NativeTypeName("const IID &")] Guid* iid, void** dcompositionDevice);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionCreateDevice2"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT DCompositionCreateDevice2(IUnknown* renderingDevice, [NativeTypeName("const IID &")] Guid* iid, void** dcompositionDevice);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionCreateDevice3"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    public static extern HRESULT DCompositionCreateDevice3(IUnknown* renderingDevice, [NativeTypeName("const IID &")] Guid* iid, void** dcompositionDevice);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionCreateSurfaceHandle"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DCompositionCreateSurfaceHandle([NativeTypeName("DWORD")] uint desiredAccess, SECURITY_ATTRIBUTES* securityAttributes, HANDLE* surfaceHandle);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionAttachMouseWheelToHwnd"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    public static extern HRESULT DCompositionAttachMouseWheelToHwnd(IDCompositionVisual* visual, HWND hwnd, BOOL enable);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionAttachMouseDragToHwnd"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    public static extern HRESULT DCompositionAttachMouseDragToHwnd(IDCompositionVisual* visual, HWND hwnd, BOOL enable);
}
