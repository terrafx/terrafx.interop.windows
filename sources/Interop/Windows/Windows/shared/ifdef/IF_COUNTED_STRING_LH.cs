// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct IF_COUNTED_STRING_LH
    {
        public ushort Length;

        [NativeTypeName("WCHAR [257]")]
        public fixed ushort String[257];
    }
}
