// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='LinkType.xml' path='doc/member[@name="LinkType"]/*' />
public enum LinkType
{
    /// <include file='LinkType.xml' path='doc/member[@name="LinkType.LinkType_Undefined"]/*' />
    LinkType_Undefined = 0,

    /// <include file='LinkType.xml' path='doc/member[@name="LinkType.LinkType_NotALink"]/*' />
    LinkType_NotALink = 1,

    /// <include file='LinkType.xml' path='doc/member[@name="LinkType.LinkType_ClientLink"]/*' />
    LinkType_ClientLink = 2,

    /// <include file='LinkType.xml' path='doc/member[@name="LinkType.LinkType_FriendlyLinkName"]/*' />
    LinkType_FriendlyLinkName = 3,

    /// <include file='LinkType.xml' path='doc/member[@name="LinkType.LinkType_FriendlyLinkAddress"]/*' />
    LinkType_FriendlyLinkAddress = 4,

    /// <include file='LinkType.xml' path='doc/member[@name="LinkType.LinkType_AutoLink"]/*' />
    LinkType_AutoLink = 5,

    /// <include file='LinkType.xml' path='doc/member[@name="LinkType.LinkType_AutoLinkEmail"]/*' />
    LinkType_AutoLinkEmail = 6,

    /// <include file='LinkType.xml' path='doc/member[@name="LinkType.LinkType_AutoLinkPhone"]/*' />
    LinkType_AutoLinkPhone = 7,

    /// <include file='LinkType.xml' path='doc/member[@name="LinkType.LinkType_AutoLinkPath"]/*' />
    LinkType_AutoLinkPath = 8,
}
