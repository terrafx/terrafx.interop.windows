// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class GAA
{
    /// <include file='GAA.xml' path='doc/member[@name="GAA.GAA_FLAG_SKIP_UNICAST"]/*' />
    [NativeTypeName("#define GAA_FLAG_SKIP_UNICAST 0x0001")]
    public const int GAA_FLAG_SKIP_UNICAST = 0x0001;

    /// <include file='GAA.xml' path='doc/member[@name="GAA.GAA_FLAG_SKIP_ANYCAST"]/*' />
    [NativeTypeName("#define GAA_FLAG_SKIP_ANYCAST 0x0002")]
    public const int GAA_FLAG_SKIP_ANYCAST = 0x0002;

    /// <include file='GAA.xml' path='doc/member[@name="GAA.GAA_FLAG_SKIP_MULTICAST"]/*' />
    [NativeTypeName("#define GAA_FLAG_SKIP_MULTICAST 0x0004")]
    public const int GAA_FLAG_SKIP_MULTICAST = 0x0004;

    /// <include file='GAA.xml' path='doc/member[@name="GAA.GAA_FLAG_SKIP_DNS_SERVER"]/*' />
    [NativeTypeName("#define GAA_FLAG_SKIP_DNS_SERVER 0x0008")]
    public const int GAA_FLAG_SKIP_DNS_SERVER = 0x0008;

    /// <include file='GAA.xml' path='doc/member[@name="GAA.GAA_FLAG_INCLUDE_PREFIX"]/*' />
    [NativeTypeName("#define GAA_FLAG_INCLUDE_PREFIX 0x0010")]
    public const int GAA_FLAG_INCLUDE_PREFIX = 0x0010;

    /// <include file='GAA.xml' path='doc/member[@name="GAA.GAA_FLAG_SKIP_FRIENDLY_NAME"]/*' />
    [NativeTypeName("#define GAA_FLAG_SKIP_FRIENDLY_NAME 0x0020")]
    public const int GAA_FLAG_SKIP_FRIENDLY_NAME = 0x0020;

    /// <include file='GAA.xml' path='doc/member[@name="GAA.GAA_FLAG_INCLUDE_WINS_INFO"]/*' />
    [NativeTypeName("#define GAA_FLAG_INCLUDE_WINS_INFO 0x0040")]
    public const int GAA_FLAG_INCLUDE_WINS_INFO = 0x0040;

    /// <include file='GAA.xml' path='doc/member[@name="GAA.GAA_FLAG_INCLUDE_GATEWAYS"]/*' />
    [NativeTypeName("#define GAA_FLAG_INCLUDE_GATEWAYS 0x0080")]
    public const int GAA_FLAG_INCLUDE_GATEWAYS = 0x0080;

    /// <include file='GAA.xml' path='doc/member[@name="GAA.GAA_FLAG_INCLUDE_ALL_INTERFACES"]/*' />
    [NativeTypeName("#define GAA_FLAG_INCLUDE_ALL_INTERFACES 0x0100")]
    public const int GAA_FLAG_INCLUDE_ALL_INTERFACES = 0x0100;

    /// <include file='GAA.xml' path='doc/member[@name="GAA.GAA_FLAG_INCLUDE_ALL_COMPARTMENTS"]/*' />
    [NativeTypeName("#define GAA_FLAG_INCLUDE_ALL_COMPARTMENTS 0x0200")]
    public const int GAA_FLAG_INCLUDE_ALL_COMPARTMENTS = 0x0200;

    /// <include file='GAA.xml' path='doc/member[@name="GAA.GAA_FLAG_INCLUDE_TUNNEL_BINDINGORDER"]/*' />
    [NativeTypeName("#define GAA_FLAG_INCLUDE_TUNNEL_BINDINGORDER 0x0400")]
    public const int GAA_FLAG_INCLUDE_TUNNEL_BINDINGORDER = 0x0400;

    /// <include file='GAA.xml' path='doc/member[@name="GAA.GAA_FLAG_SKIP_DNS_INFO"]/*' />
    [NativeTypeName("#define GAA_FLAG_SKIP_DNS_INFO 0x0800")]
    public const int GAA_FLAG_SKIP_DNS_INFO = 0x0800;
}
