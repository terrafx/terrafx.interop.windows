// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcsplugin.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='GamutShellTriangle.xml' path='doc/member[@name="GamutShellTriangle"]/*' />
public partial struct GamutShellTriangle
{
    /// <include file='GamutShellTriangle.xml' path='doc/member[@name="GamutShellTriangle.aVertexIndex"]/*' />
    [NativeTypeName("UINT[3]")]
    public _aVertexIndex_e__FixedBuffer aVertexIndex;

    /// <include file='_aVertexIndex_e__FixedBuffer.xml' path='doc/member[@name="_aVertexIndex_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _aVertexIndex_e__FixedBuffer
    {
        public uint e0;
    }
}
