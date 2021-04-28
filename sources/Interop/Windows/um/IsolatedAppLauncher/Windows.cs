// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IsolatedAppLauncher.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("shcore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IsProcessInWDAGContainer([NativeTypeName("PVOID")] void* Reserved, [NativeTypeName("BOOL *")] int* isProcessInWDAGContainer);

        [DllImport("shcore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IsProcessInIsolatedContainer([NativeTypeName("BOOL *")] int* isProcessInIsolatedContainer);

        public static readonly Guid IID_IIsolatedAppLauncher = new Guid(0xF686878F, 0x7B42, 0x4CC4, 0x96, 0xFB, 0xF4, 0xF3, 0xB6, 0xE3, 0xD2, 0x4D);

        public static readonly Guid CLSID_IsolatedAppLauncher = new Guid(0xBC812430, 0xE75E, 0x4FD1, 0x96, 0x41, 0x1F, 0x9F, 0x1E, 0x2D, 0x9A, 0x1F);
    }
}
