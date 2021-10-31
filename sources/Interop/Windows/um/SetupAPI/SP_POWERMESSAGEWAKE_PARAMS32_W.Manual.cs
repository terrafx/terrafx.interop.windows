// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct SP_POWERMESSAGEWAKE_PARAMS32_W
    {
        public SP_CLASSINSTALL_HEADER32 ClassInstallHeader;

        [NativeTypeName("WCHAR [512]")]
        public fixed ushort PowerMessageWake[512];
    }
}
