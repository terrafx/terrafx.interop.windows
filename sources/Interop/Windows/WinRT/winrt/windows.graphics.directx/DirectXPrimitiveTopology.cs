// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.directx.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DirectXPrimitiveTopology.xml' path='doc/member[@name="DirectXPrimitiveTopology"]/*' />
public enum DirectXPrimitiveTopology
{
    /// <include file='DirectXPrimitiveTopology.xml' path='doc/member[@name="DirectXPrimitiveTopology.DirectXPrimitiveTopology_Undefined"]/*' />
    DirectXPrimitiveTopology_Undefined = 0,

    /// <include file='DirectXPrimitiveTopology.xml' path='doc/member[@name="DirectXPrimitiveTopology.DirectXPrimitiveTopology_PointList"]/*' />
    DirectXPrimitiveTopology_PointList = 1,

    /// <include file='DirectXPrimitiveTopology.xml' path='doc/member[@name="DirectXPrimitiveTopology.DirectXPrimitiveTopology_LineList"]/*' />
    DirectXPrimitiveTopology_LineList = 2,

    /// <include file='DirectXPrimitiveTopology.xml' path='doc/member[@name="DirectXPrimitiveTopology.DirectXPrimitiveTopology_LineStrip"]/*' />
    DirectXPrimitiveTopology_LineStrip = 3,

    /// <include file='DirectXPrimitiveTopology.xml' path='doc/member[@name="DirectXPrimitiveTopology.DirectXPrimitiveTopology_TriangleList"]/*' />
    DirectXPrimitiveTopology_TriangleList = 4,

    /// <include file='DirectXPrimitiveTopology.xml' path='doc/member[@name="DirectXPrimitiveTopology.DirectXPrimitiveTopology_TriangleStrip"]/*' />
    DirectXPrimitiveTopology_TriangleStrip = 5,
}
