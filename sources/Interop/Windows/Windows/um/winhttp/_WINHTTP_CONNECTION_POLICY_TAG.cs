// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='_WINHTTP_CONNECTION_POLICY_TAG.xml' path='doc/member[@name="_WINHTTP_CONNECTION_POLICY_TAG"]/*' />
public enum _WINHTTP_CONNECTION_POLICY_TAG
{
    /// <include file='_WINHTTP_CONNECTION_POLICY_TAG.xml' path='doc/member[@name="_WINHTTP_CONNECTION_POLICY_TAG.TAG_WINHTTP_CONNECTION_POLICY_TAG_DEFAULT"]/*' />
    TAG_WINHTTP_CONNECTION_POLICY_TAG_DEFAULT = 0,

    /// <include file='_WINHTTP_CONNECTION_POLICY_TAG.xml' path='doc/member[@name="_WINHTTP_CONNECTION_POLICY_TAG.TAG_WINHTTP_CONNECTION_POLICY_TAG_CONNECTION_MANAGER"]/*' />
    TAG_WINHTTP_CONNECTION_POLICY_TAG_CONNECTION_MANAGER,

    /// <include file='_WINHTTP_CONNECTION_POLICY_TAG.xml' path='doc/member[@name="_WINHTTP_CONNECTION_POLICY_TAG.TAG_WINHTTP_CONNECTION_POLICY_TAG_WWWPT"]/*' />
    TAG_WINHTTP_CONNECTION_POLICY_TAG_WWWPT,
}
