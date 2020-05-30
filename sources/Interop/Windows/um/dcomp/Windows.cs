// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("dcomp", EntryPoint = "DCompositionCreateDevice", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DCompositionCreateDevice([NativeTypeName("IDXGIDevice *")] IDXGIDevice* dxgiDevice, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** dcompositionDevice);

        [DllImport("dcomp", EntryPoint = "DCompositionCreateDevice2", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DCompositionCreateDevice2([NativeTypeName("IUnknown *")] IUnknown* renderingDevice, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** dcompositionDevice);

        [DllImport("dcomp", EntryPoint = "DCompositionCreateDevice3", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DCompositionCreateDevice3([NativeTypeName("IUnknown *")] IUnknown* renderingDevice, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** dcompositionDevice);

        [DllImport("dcomp", EntryPoint = "DCompositionCreateSurfaceHandle", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DCompositionCreateSurfaceHandle([NativeTypeName("DWORD")] uint desiredAccess, [NativeTypeName("SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* securityAttributes, [NativeTypeName("HANDLE *")] IntPtr* surfaceHandle);

        [DllImport("dcomp", EntryPoint = "DCompositionAttachMouseWheelToHwnd", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DCompositionAttachMouseWheelToHwnd([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("BOOL")] int enable);

        [DllImport("dcomp", EntryPoint = "DCompositionAttachMouseDragToHwnd", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DCompositionAttachMouseDragToHwnd([NativeTypeName("IDCompositionVisual *")] IDCompositionVisual* visual, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("BOOL")] int enable);
    }
}
