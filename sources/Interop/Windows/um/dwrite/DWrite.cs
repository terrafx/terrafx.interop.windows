// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class DWrite
    {
        private const string LibraryPath = "DWrite";

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "DWriteCreateFactory", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DWriteCreateFactory(DWRITE_FACTORY_TYPE factoryType, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("IUnknown **")] IUnknown** factory);
    }
}