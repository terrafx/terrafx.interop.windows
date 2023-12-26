// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.directx.direct3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='Direct3DUsage.xml' path='doc/member[@name="Direct3DUsage"]/*' />
public enum Direct3DUsage
{
    /// <include file='Direct3DUsage.xml' path='doc/member[@name="Direct3DUsage.Direct3DUsage_Default"]/*' />
    Direct3DUsage_Default = 0,

    /// <include file='Direct3DUsage.xml' path='doc/member[@name="Direct3DUsage.Direct3DUsage_Immutable"]/*' />
    Direct3DUsage_Immutable = 1,

    /// <include file='Direct3DUsage.xml' path='doc/member[@name="Direct3DUsage.Direct3DUsage_Dynamic"]/*' />
    Direct3DUsage_Dynamic = 2,

    /// <include file='Direct3DUsage.xml' path='doc/member[@name="Direct3DUsage.Direct3DUsage_Staging"]/*' />
    Direct3DUsage_Staging = 3,
}
