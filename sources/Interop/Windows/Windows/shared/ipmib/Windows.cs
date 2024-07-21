// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    [NativeTypeName("#define ICMP6_INFOMSG_MASK 0x80")]
    public const int ICMP6_INFOMSG_MASK = 0x80;
}
