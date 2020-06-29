// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Windows.UI", EntryPoint = "CreateControlInput", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateControlInput([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("Windows.UI", EntryPoint = "CreateControlInputEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateControlInputEx([NativeTypeName("IUnknown *")] IUnknown* pCoreWindow, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);
    }
}
