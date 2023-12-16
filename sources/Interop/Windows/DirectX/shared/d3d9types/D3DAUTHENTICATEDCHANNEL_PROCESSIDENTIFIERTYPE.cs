// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE"]/*' />
public enum D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE
{
    /// <include file='D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE.PROCESSIDTYPE_UNKNOWN"]/*' />
    PROCESSIDTYPE_UNKNOWN = 0,

    /// <include file='D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE.PROCESSIDTYPE_DWM"]/*' />
    PROCESSIDTYPE_DWM = 1,

    /// <include file='D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE.PROCESSIDTYPE_HANDLE"]/*' />
    PROCESSIDTYPE_HANDLE = 2,
}
