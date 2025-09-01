// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_REQUEST_DSCP_INFO.xml' path='doc/member[@name="HTTP_REQUEST_DSCP_INFO"]/*' />
public partial struct HTTP_REQUEST_DSCP_INFO
{
    /// <include file='HTTP_REQUEST_DSCP_INFO.xml' path='doc/member[@name="HTTP_REQUEST_DSCP_INFO.DscpTag"]/*' />
    public byte DscpTag;
}
