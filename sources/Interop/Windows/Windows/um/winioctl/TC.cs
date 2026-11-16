// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static partial class TC
{
    /// <include file='TC.xml' path='doc/member[@name="TC.TC_PUBLIC_DEVICEDUMP_CONTENT_SMART"]/*' />
    [NativeTypeName("#define TC_PUBLIC_DEVICEDUMP_CONTENT_SMART 0x01")]
    public const int TC_PUBLIC_DEVICEDUMP_CONTENT_SMART = 0x01;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_PUBLIC_DEVICEDUMP_CONTENT_GPLOG"]/*' />
    [NativeTypeName("#define TC_PUBLIC_DEVICEDUMP_CONTENT_GPLOG 0x02")]
    public const int TC_PUBLIC_DEVICEDUMP_CONTENT_GPLOG = 0x02;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_PUBLIC_DEVICEDUMP_CONTENT_GPLOG_MAX"]/*' />
    [NativeTypeName("#define TC_PUBLIC_DEVICEDUMP_CONTENT_GPLOG_MAX 16")]
    public const int TC_PUBLIC_DEVICEDUMP_CONTENT_GPLOG_MAX = 16;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_DEVICEDUMP_SUBSECTION_DESC_LENGTH"]/*' />
    [NativeTypeName("#define TC_DEVICEDUMP_SUBSECTION_DESC_LENGTH 16")]
    public const int TC_DEVICEDUMP_SUBSECTION_DESC_LENGTH = 16;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_PUBLIC_DATA_TYPE_ATAGP"]/*' />
    [NativeTypeName("#define TC_PUBLIC_DATA_TYPE_ATAGP \"ATAGPLogPages\"")]
    public static ReadOnlySpan<byte> TC_PUBLIC_DATA_TYPE_ATAGP => "ATAGPLogPages"u8;

    /// <include file='TC.xml' path='doc/member[@name="TC.TC_PUBLIC_DATA_TYPE_ATASMART"]/*' />
    [NativeTypeName("#define TC_PUBLIC_DATA_TYPE_ATASMART \"ATASMARTPages\"")]
    public static ReadOnlySpan<byte> TC_PUBLIC_DATA_TYPE_ATASMART => "ATASMARTPages"u8;
}
