// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PngFilterMode.xml' path='doc/member[@name="PngFilterMode"]/*' />
public enum PngFilterMode
{
    /// <include file='PngFilterMode.xml' path='doc/member[@name="PngFilterMode.PngFilterMode_Automatic"]/*' />
    PngFilterMode_Automatic = 0,

    /// <include file='PngFilterMode.xml' path='doc/member[@name="PngFilterMode.PngFilterMode_None"]/*' />
    PngFilterMode_None = 1,

    /// <include file='PngFilterMode.xml' path='doc/member[@name="PngFilterMode.PngFilterMode_Sub"]/*' />
    PngFilterMode_Sub = 2,

    /// <include file='PngFilterMode.xml' path='doc/member[@name="PngFilterMode.PngFilterMode_Up"]/*' />
    PngFilterMode_Up = 3,

    /// <include file='PngFilterMode.xml' path='doc/member[@name="PngFilterMode.PngFilterMode_Average"]/*' />
    PngFilterMode_Average = 4,

    /// <include file='PngFilterMode.xml' path='doc/member[@name="PngFilterMode.PngFilterMode_Paeth"]/*' />
    PngFilterMode_Paeth = 5,

    /// <include file='PngFilterMode.xml' path='doc/member[@name="PngFilterMode.PngFilterMode_Adaptive"]/*' />
    PngFilterMode_Adaptive = 6,
}
