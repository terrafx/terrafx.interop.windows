// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct CORRELATION_VECTOR
    {
        [NativeTypeName("CHAR")]
        public sbyte Version;

        [NativeTypeName("CHAR [129]")]
        public fixed sbyte Vector[129];
    }
}
