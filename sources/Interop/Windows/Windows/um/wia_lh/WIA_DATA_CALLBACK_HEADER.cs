// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='WIA_DATA_CALLBACK_HEADER.xml' path='doc/member[@name="WIA_DATA_CALLBACK_HEADER"]/*' />
public partial struct WIA_DATA_CALLBACK_HEADER
{
    /// <include file='WIA_DATA_CALLBACK_HEADER.xml' path='doc/member[@name="WIA_DATA_CALLBACK_HEADER.lSize"]/*' />
    [NativeTypeName("LONG")]
    public int lSize;

    /// <include file='WIA_DATA_CALLBACK_HEADER.xml' path='doc/member[@name="WIA_DATA_CALLBACK_HEADER.guidFormatID"]/*' />
    public Guid guidFormatID;

    /// <include file='WIA_DATA_CALLBACK_HEADER.xml' path='doc/member[@name="WIA_DATA_CALLBACK_HEADER.lBufferSize"]/*' />
    [NativeTypeName("LONG")]
    public int lBufferSize;

    /// <include file='WIA_DATA_CALLBACK_HEADER.xml' path='doc/member[@name="WIA_DATA_CALLBACK_HEADER.lPageCount"]/*' />
    [NativeTypeName("LONG")]
    public int lPageCount;
}
