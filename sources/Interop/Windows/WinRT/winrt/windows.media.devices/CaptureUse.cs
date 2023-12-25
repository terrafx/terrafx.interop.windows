// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CaptureUse.xml' path='doc/member[@name="CaptureUse"]/*' />
public enum CaptureUse
{
    /// <include file='CaptureUse.xml' path='doc/member[@name="CaptureUse.CaptureUse_None"]/*' />
    CaptureUse_None = 0,

    /// <include file='CaptureUse.xml' path='doc/member[@name="CaptureUse.CaptureUse_Photo"]/*' />
    CaptureUse_Photo = 1,

    /// <include file='CaptureUse.xml' path='doc/member[@name="CaptureUse.CaptureUse_Video"]/*' />
    CaptureUse_Video = 2,
}
