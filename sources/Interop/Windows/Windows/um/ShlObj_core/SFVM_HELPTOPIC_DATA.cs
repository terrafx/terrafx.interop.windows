// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SFVM_HELPTOPIC_DATA
    {
        [NativeTypeName("WCHAR [260]")]
        public fixed ushort wszHelpFile[260];

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort wszHelpTopic[260];
    }
}
