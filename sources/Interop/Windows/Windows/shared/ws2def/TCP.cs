// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TCP
{
    /// <include file='TCP.xml' path='doc/member[@name="TCP.TCP_NODELAY"]/*' />
    [NativeTypeName("#define TCP_NODELAY 0x0001")]
    public const int TCP_NODELAY = 0x0001;
}
