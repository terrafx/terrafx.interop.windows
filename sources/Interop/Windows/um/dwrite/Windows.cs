// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("DWrite", EntryPoint = "DWriteCreateFactory", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DWriteCreateFactory(DWRITE_FACTORY_TYPE factoryType, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("IUnknown **")] IUnknown** factory);

        [NativeTypeName("#define DWRITE_ALPHA_MAX 255")]
        public const int DWRITE_ALPHA_MAX = 255;

        [NativeTypeName("#define FACILITY_DWRITE 0x898")]
        public const int FACILITY_DWRITE = 0x898;

        [NativeTypeName("#define DWRITE_ERR_BASE 0x5000")]
        public const int DWRITE_ERR_BASE = 0x5000;
    }
}
