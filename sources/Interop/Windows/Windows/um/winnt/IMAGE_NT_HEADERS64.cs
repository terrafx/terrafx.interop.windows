// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct IMAGE_NT_HEADERS64
    {
        [NativeTypeName("DWORD")]
        public uint Signature;

        public IMAGE_FILE_HEADER FileHeader;

        public IMAGE_OPTIONAL_HEADER64 OptionalHeader;
    }
}
