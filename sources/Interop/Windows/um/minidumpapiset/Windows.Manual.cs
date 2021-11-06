// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [return: NativeTypeName("PVOID")]
        public static void* RVA_TO_ADDR([NativeTypeName("PVOID")] void* Mapping, [NativeTypeName("ULONG")] uint Rva)
        {
            return (void*)((nuint)Mapping + Rva);
        }
    }
}
