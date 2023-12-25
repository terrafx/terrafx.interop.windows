// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AudioBufferAccessMode.xml' path='doc/member[@name="AudioBufferAccessMode"]/*' />
public enum AudioBufferAccessMode
{
    /// <include file='AudioBufferAccessMode.xml' path='doc/member[@name="AudioBufferAccessMode.AudioBufferAccessMode_Read"]/*' />
    AudioBufferAccessMode_Read = 0,

    /// <include file='AudioBufferAccessMode.xml' path='doc/member[@name="AudioBufferAccessMode.AudioBufferAccessMode_ReadWrite"]/*' />
    AudioBufferAccessMode_ReadWrite = 1,

    /// <include file='AudioBufferAccessMode.xml' path='doc/member[@name="AudioBufferAccessMode.AudioBufferAccessMode_Write"]/*' />
    AudioBufferAccessMode_Write = 2,
}
