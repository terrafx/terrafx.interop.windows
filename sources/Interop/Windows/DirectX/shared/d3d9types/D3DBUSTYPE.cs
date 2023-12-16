// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE"]/*' />
public enum D3DBUSTYPE
{
    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSTYPE_OTHER"]/*' />
    D3DBUSTYPE_OTHER = 0x00000000,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSTYPE_PCI"]/*' />
    D3DBUSTYPE_PCI = 0x00000001,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSTYPE_PCIX"]/*' />
    D3DBUSTYPE_PCIX = 0x00000002,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSTYPE_PCIEXPRESS"]/*' />
    D3DBUSTYPE_PCIEXPRESS = 0x00000003,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSTYPE_AGP"]/*' />
    D3DBUSTYPE_AGP = 0x00000004,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_INSIDE_OF_CHIPSET"]/*' />
    D3DBUSIMPL_MODIFIER_INSIDE_OF_CHIPSET = 0x00010000,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP"]/*' />
    D3DBUSIMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP = 0x00020000,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET"]/*' />
    D3DBUSIMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET = 0x00030000,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR"]/*' />
    D3DBUSIMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR = 0x00040000,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE"]/*' />
    D3DBUSIMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE = 0x00050000,

    /// <include file='D3DBUSTYPE.xml' path='doc/member[@name="D3DBUSTYPE.D3DBUSIMPL_MODIFIER_NON_STANDARD"]/*' />
    D3DBUSIMPL_MODIFIER_NON_STANDARD = unchecked((int)(0x80000000)),
}
