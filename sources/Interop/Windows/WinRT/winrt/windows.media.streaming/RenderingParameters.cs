// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RenderingParameters.xml' path='doc/member[@name="RenderingParameters"]/*' />
public partial struct RenderingParameters
{
    /// <include file='RenderingParameters.xml' path='doc/member[@name="RenderingParameters.volume"]/*' />
    [NativeTypeName("UINT32")]
    public uint volume;

    /// <include file='RenderingParameters.xml' path='doc/member[@name="RenderingParameters.mute"]/*' />
    [NativeTypeName("boolean")]
    public byte mute;
}
