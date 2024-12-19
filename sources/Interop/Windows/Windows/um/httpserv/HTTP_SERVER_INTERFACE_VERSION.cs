// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SERVER_INTERFACE_VERSION.xml' path='doc/member[@name="HTTP_SERVER_INTERFACE_VERSION"]/*' />
public enum HTTP_SERVER_INTERFACE_VERSION
{
    /// <include file='HTTP_SERVER_INTERFACE_VERSION.xml' path='doc/member[@name="HTTP_SERVER_INTERFACE_VERSION.HTTP_SERVER_INTERFACE_V2"]/*' />
    HTTP_SERVER_INTERFACE_V2,

    /// <include file='HTTP_SERVER_INTERFACE_VERSION.xml' path='doc/member[@name="HTTP_SERVER_INTERFACE_VERSION.HTTP_SERVER_INTERFACE_V3"]/*' />
    HTTP_SERVER_INTERFACE_V3,
}
