// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CodecCategory.xml' path='doc/member[@name="CodecCategory"]/*' />
public enum CodecCategory
{
    /// <include file='CodecCategory.xml' path='doc/member[@name="CodecCategory.CodecCategory_Encoder"]/*' />
    CodecCategory_Encoder = 0,

    /// <include file='CodecCategory.xml' path='doc/member[@name="CodecCategory.CodecCategory_Decoder"]/*' />
    CodecCategory_Decoder = 1,
}
