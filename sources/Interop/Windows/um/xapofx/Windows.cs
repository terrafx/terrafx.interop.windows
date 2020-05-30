// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Windows.Media.Audio", EntryPoint = "CreateFX", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateFX([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("IUnknown **")] IUnknown** pEffect, [NativeTypeName("const void *")] void* pInitDat = null, [NativeTypeName("UINT32")] uint InitDataByteSize = 0);
    }
}
