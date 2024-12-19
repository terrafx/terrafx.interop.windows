// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_LOG_DATA.xml' path='doc/member[@name="HTTP_LOG_DATA"]/*' />
public partial struct HTTP_LOG_DATA
{
    /// <include file='HTTP_LOG_DATA.xml' path='doc/member[@name="HTTP_LOG_DATA.Type"]/*' />
    public HTTP_LOG_DATA_TYPE Type;
}
