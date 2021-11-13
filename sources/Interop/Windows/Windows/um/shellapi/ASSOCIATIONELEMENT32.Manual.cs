// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct ASSOCIATIONELEMENT32
    {
        public ASSOCCLASS ac;

        public HKEY hkClass;

        [NativeTypeName("PCWSTR")]
        public ushort* pszClass;
    }
}
