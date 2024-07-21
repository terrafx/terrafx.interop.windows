// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_UNKNOWN_ENDPOINT_IDENTITY.xml' path='doc/member[@name="WS_UNKNOWN_ENDPOINT_IDENTITY"]/*' />
public unsafe partial struct WS_UNKNOWN_ENDPOINT_IDENTITY
{
    /// <include file='WS_UNKNOWN_ENDPOINT_IDENTITY.xml' path='doc/member[@name="WS_UNKNOWN_ENDPOINT_IDENTITY.identity"]/*' />
    public WS_ENDPOINT_IDENTITY identity;

    /// <include file='WS_UNKNOWN_ENDPOINT_IDENTITY.xml' path='doc/member[@name="WS_UNKNOWN_ENDPOINT_IDENTITY.element"]/*' />
    [NativeTypeName("WS_XML_BUFFER*")]
    public void* element;
}
