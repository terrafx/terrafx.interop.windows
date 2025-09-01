// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='FRAME_MARGIN.xml' path='doc/member[@name="FRAME_MARGIN"]/*' />
public partial struct FRAME_MARGIN
{
    /// <include file='FRAME_MARGIN.xml' path='doc/member[@name="FRAME_MARGIN.left"]/*' />
    public short left;

    /// <include file='FRAME_MARGIN.xml' path='doc/member[@name="FRAME_MARGIN.right"]/*' />
    public short right;

    /// <include file='FRAME_MARGIN.xml' path='doc/member[@name="FRAME_MARGIN.top"]/*' />
    public short top;

    /// <include file='FRAME_MARGIN.xml' path='doc/member[@name="FRAME_MARGIN.bottom"]/*' />
    public short bottom;
}
