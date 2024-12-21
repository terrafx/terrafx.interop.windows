// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='PresentStatus.xml' path='doc/member[@name="PresentStatus"]/*' />
public enum PresentStatus
{
    /// <include file='PresentStatus.xml' path='doc/member[@name="PresentStatus.PresentStatus_Queued"]/*' />
    PresentStatus_Queued = 0,

    /// <include file='PresentStatus.xml' path='doc/member[@name="PresentStatus.PresentStatus_Skipped"]/*' />
    PresentStatus_Skipped = 1,

    /// <include file='PresentStatus.xml' path='doc/member[@name="PresentStatus.PresentStatus_Canceled"]/*' />
    PresentStatus_Canceled = 2,
}
