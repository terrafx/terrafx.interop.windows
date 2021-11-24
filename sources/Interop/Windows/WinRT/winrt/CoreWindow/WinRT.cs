// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

public static unsafe partial class WinRT
{
    [DllImport("windows.ui.dll", ExactSpelling = true)]
    public static extern HRESULT CreateControlInput([NativeTypeName("const IID &")] Guid* riid, void** ppv);

    [DllImport("windows.ui.dll", ExactSpelling = true)]
    public static extern HRESULT CreateControlInputEx(IUnknown* pCoreWindow, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
}
