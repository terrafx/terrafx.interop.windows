// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CharacterRange
    {
        [NativeTypeName("INT")]
        public int First;

        [NativeTypeName("INT")]
        public int Length;

        public CharacterRange([NativeTypeName("INT")] int first, [NativeTypeName("INT")] int length)
        {
            First = first;
            Length = length;
        }
    }
}
