// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='WIA_FORMAT_INFO.xml' path='doc/member[@name="WIA_FORMAT_INFO"]/*' />
public partial struct WIA_FORMAT_INFO
{
    /// <include file='WIA_FORMAT_INFO.xml' path='doc/member[@name="WIA_FORMAT_INFO.guidFormatID"]/*' />
    public Guid guidFormatID;

    /// <include file='WIA_FORMAT_INFO.xml' path='doc/member[@name="WIA_FORMAT_INFO.lTymed"]/*' />
    [NativeTypeName("LONG")]
    public int lTymed;
}
