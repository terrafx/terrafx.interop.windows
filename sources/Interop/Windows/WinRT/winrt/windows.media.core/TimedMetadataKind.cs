// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TimedMetadataKind.xml' path='doc/member[@name="TimedMetadataKind"]/*' />
public enum TimedMetadataKind
{
    /// <include file='TimedMetadataKind.xml' path='doc/member[@name="TimedMetadataKind.TimedMetadataKind_Caption"]/*' />
    TimedMetadataKind_Caption = 0,

    /// <include file='TimedMetadataKind.xml' path='doc/member[@name="TimedMetadataKind.TimedMetadataKind_Chapter"]/*' />
    TimedMetadataKind_Chapter = 1,

    /// <include file='TimedMetadataKind.xml' path='doc/member[@name="TimedMetadataKind.TimedMetadataKind_Custom"]/*' />
    TimedMetadataKind_Custom = 2,

    /// <include file='TimedMetadataKind.xml' path='doc/member[@name="TimedMetadataKind.TimedMetadataKind_Data"]/*' />
    TimedMetadataKind_Data = 3,

    /// <include file='TimedMetadataKind.xml' path='doc/member[@name="TimedMetadataKind.TimedMetadataKind_Description"]/*' />
    TimedMetadataKind_Description = 4,

    /// <include file='TimedMetadataKind.xml' path='doc/member[@name="TimedMetadataKind.TimedMetadataKind_Subtitle"]/*' />
    TimedMetadataKind_Subtitle = 5,

    /// <include file='TimedMetadataKind.xml' path='doc/member[@name="TimedMetadataKind.TimedMetadataKind_ImageSubtitle"]/*' />
    TimedMetadataKind_ImageSubtitle = 6,

    /// <include file='TimedMetadataKind.xml' path='doc/member[@name="TimedMetadataKind.TimedMetadataKind_Speech"]/*' />
    TimedMetadataKind_Speech = 7,
}
