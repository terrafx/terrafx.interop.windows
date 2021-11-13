// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct WIN32_FIND_STREAM_DATA
    {
        public LARGE_INTEGER StreamSize;

        [NativeTypeName("WCHAR [296]")]
        public fixed ushort cStreamName[296];
    }
}
