// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Kernel32
    {
        public const int CREATE_NEW = 1;

        public const int CREATE_ALWAYS = 2;

        public const int OPEN_EXISTING = 3;

        public const int OPEN_ALWAYS = 4;

        public const int TRUNCATE_EXISTING = 5;

        public const uint INVALID_FILE_SIZE = 0xFFFFFFFF;

        public const uint INVALID_SET_FILE_POINTER = unchecked((uint)-1);

        public const uint INVALID_FILE_ATTRIBUTES = unchecked((uint)-1);
    }
}
