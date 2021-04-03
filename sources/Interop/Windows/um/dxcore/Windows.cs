// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("DXCore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DXCoreCreateAdapterFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory);
    }
}
