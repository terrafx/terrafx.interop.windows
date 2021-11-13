// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct FILE_QUERY_ON_DISK_VOL_INFO_BUFFER
    {
        public LARGE_INTEGER DirectoryCount;

        public LARGE_INTEGER FileCount;

        [NativeTypeName("WORD")]
        public ushort FsFormatMajVersion;

        [NativeTypeName("WORD")]
        public ushort FsFormatMinVersion;

        [NativeTypeName("WCHAR [12]")]
        public fixed ushort FsFormatName[12];

        public LARGE_INTEGER FormatTime;

        public LARGE_INTEGER LastUpdateTime;

        [NativeTypeName("WCHAR [34]")]
        public fixed ushort CopyrightInfo[34];

        [NativeTypeName("WCHAR [34]")]
        public fixed ushort AbstractInfo[34];

        [NativeTypeName("WCHAR [34]")]
        public fixed ushort FormattingImplementationInfo[34];

        [NativeTypeName("WCHAR [34]")]
        public fixed ushort LastModifyingImplementationInfo[34];
    }
}
