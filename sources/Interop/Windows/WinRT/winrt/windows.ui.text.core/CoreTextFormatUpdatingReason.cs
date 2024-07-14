// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CoreTextFormatUpdatingReason.xml' path='doc/member[@name="CoreTextFormatUpdatingReason"]/*' />
public enum CoreTextFormatUpdatingReason
{
    /// <include file='CoreTextFormatUpdatingReason.xml' path='doc/member[@name="CoreTextFormatUpdatingReason.CoreTextFormatUpdatingReason_None"]/*' />
    CoreTextFormatUpdatingReason_None = 0,

    /// <include file='CoreTextFormatUpdatingReason.xml' path='doc/member[@name="CoreTextFormatUpdatingReason.CoreTextFormatUpdatingReason_CompositionUnconverted"]/*' />
    CoreTextFormatUpdatingReason_CompositionUnconverted = 1,

    /// <include file='CoreTextFormatUpdatingReason.xml' path='doc/member[@name="CoreTextFormatUpdatingReason.CoreTextFormatUpdatingReason_CompositionConverted"]/*' />
    CoreTextFormatUpdatingReason_CompositionConverted = 2,

    /// <include file='CoreTextFormatUpdatingReason.xml' path='doc/member[@name="CoreTextFormatUpdatingReason.CoreTextFormatUpdatingReason_CompositionTargetUnconverted"]/*' />
    CoreTextFormatUpdatingReason_CompositionTargetUnconverted = 3,

    /// <include file='CoreTextFormatUpdatingReason.xml' path='doc/member[@name="CoreTextFormatUpdatingReason.CoreTextFormatUpdatingReason_CompositionTargetConverted"]/*' />
    CoreTextFormatUpdatingReason_CompositionTargetConverted = 4,
}
