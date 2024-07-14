// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CodecKind.xml' path='doc/member[@name="CodecKind"]/*' />
public enum CodecKind
{
    /// <include file='CodecKind.xml' path='doc/member[@name="CodecKind.CodecKind_Audio"]/*' />
    CodecKind_Audio = 0,

    /// <include file='CodecKind.xml' path='doc/member[@name="CodecKind.CodecKind_Video"]/*' />
    CodecKind_Video = 1,
}
