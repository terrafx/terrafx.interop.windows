// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public static partial class TC
    {
        [NativeTypeName("#define TC_PUBLIC_DEVICEDUMP_CONTENT_SMART 0x01")]
        public const int TC_PUBLIC_DEVICEDUMP_CONTENT_SMART = 0x01;

        [NativeTypeName("#define TC_PUBLIC_DEVICEDUMP_CONTENT_GPLOG 0x02")]
        public const int TC_PUBLIC_DEVICEDUMP_CONTENT_GPLOG = 0x02;

        [NativeTypeName("#define TC_PUBLIC_DEVICEDUMP_CONTENT_GPLOG_MAX 16")]
        public const int TC_PUBLIC_DEVICEDUMP_CONTENT_GPLOG_MAX = 16;

        [NativeTypeName("#define TC_DEVICEDUMP_SUBSECTION_DESC_LENGTH 16")]
        public const int TC_DEVICEDUMP_SUBSECTION_DESC_LENGTH = 16;

        [NativeTypeName("#define TC_PUBLIC_DATA_TYPE_ATAGP \"ATAGPLogPages\"")]
        public static ReadOnlySpan<byte> TC_PUBLIC_DATA_TYPE_ATAGP => new byte[] { 0x41, 0x54, 0x41, 0x47, 0x50, 0x4C, 0x6F, 0x67, 0x50, 0x61, 0x67, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define TC_PUBLIC_DATA_TYPE_ATASMART \"ATASMARTPages\"")]
        public static ReadOnlySpan<byte> TC_PUBLIC_DATA_TYPE_ATASMART => new byte[] { 0x41, 0x54, 0x41, 0x53, 0x4D, 0x41, 0x52, 0x54, 0x50, 0x61, 0x67, 0x65, 0x73, 0x00 };
    }
}
