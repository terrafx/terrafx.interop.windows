// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='_SECURITY_ANTITAMPER_ENTITLEMENT.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_ENTITLEMENT"]/*' />
public unsafe partial struct _SECURITY_ANTITAMPER_ENTITLEMENT
{
    /// <include file='_SECURITY_ANTITAMPER_ENTITLEMENT.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_ENTITLEMENT.RequiredSigningLevel"]/*' />
    [NativeTypeName("SE_SIGNING_LEVEL")]
    public byte RequiredSigningLevel;

    /// <include file='_SECURITY_ANTITAMPER_ENTITLEMENT.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_ENTITLEMENT.RequiredSidCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint RequiredSidCount;

    /// <include file='_SECURITY_ANTITAMPER_ENTITLEMENT.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_ENTITLEMENT.RequiredSids"]/*' />
    [NativeTypeName("PSID *")]
    public void** RequiredSids;
}
