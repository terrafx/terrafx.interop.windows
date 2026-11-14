// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WS_MATCH_URL
{
    /// <include file='WS_MATCH_URL.xml' path='doc/member[@name="WS_MATCH_URL.WS_MATCH_URL_DNS_HOST"]/*' />
    public const int WS_MATCH_URL_DNS_HOST = 0x1;
    /// <include file='WS_MATCH_URL.xml' path='doc/member[@name="WS_MATCH_URL.WS_MATCH_URL_DNS_FULLY_QUALIFIED_HOST"]/*' />
    public const int WS_MATCH_URL_DNS_FULLY_QUALIFIED_HOST = 0x2;
    /// <include file='WS_MATCH_URL.xml' path='doc/member[@name="WS_MATCH_URL.WS_MATCH_URL_NETBIOS_HOST"]/*' />
    public const int WS_MATCH_URL_NETBIOS_HOST = 0x4;
    /// <include file='WS_MATCH_URL.xml' path='doc/member[@name="WS_MATCH_URL.WS_MATCH_URL_LOCAL_HOST"]/*' />
    public const int WS_MATCH_URL_LOCAL_HOST = 0x8;
    /// <include file='WS_MATCH_URL.xml' path='doc/member[@name="WS_MATCH_URL.WS_MATCH_URL_HOST_ADDRESSES"]/*' />
    public const int WS_MATCH_URL_HOST_ADDRESSES = 0x10;
    /// <include file='WS_MATCH_URL.xml' path='doc/member[@name="WS_MATCH_URL.WS_MATCH_URL_THIS_HOST"]/*' />
    public const int WS_MATCH_URL_THIS_HOST = (WS_MATCH_URL_DNS_HOST | WS_MATCH_URL_DNS_FULLY_QUALIFIED_HOST | WS_MATCH_URL_NETBIOS_HOST | WS_MATCH_URL_LOCAL_HOST | WS_MATCH_URL_HOST_ADDRESSES);
    /// <include file='WS_MATCH_URL.xml' path='doc/member[@name="WS_MATCH_URL.WS_MATCH_URL_PORT"]/*' />
    public const int WS_MATCH_URL_PORT = 0x20;
    /// <include file='WS_MATCH_URL.xml' path='doc/member[@name="WS_MATCH_URL.WS_MATCH_URL_EXACT_PATH"]/*' />
    public const int WS_MATCH_URL_EXACT_PATH = 0x40;
    /// <include file='WS_MATCH_URL.xml' path='doc/member[@name="WS_MATCH_URL.WS_MATCH_URL_PREFIX_PATH"]/*' />
    public const int WS_MATCH_URL_PREFIX_PATH = 0x80;
    /// <include file='WS_MATCH_URL.xml' path='doc/member[@name="WS_MATCH_URL.WS_MATCH_URL_NO_QUERY"]/*' />
    public const int WS_MATCH_URL_NO_QUERY = 0x100;
}
