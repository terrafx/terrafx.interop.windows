// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AlternateNormalizationFormat.xml' path='doc/member[@name="AlternateNormalizationFormat"]/*' />
public enum AlternateNormalizationFormat
{
    /// <include file='AlternateNormalizationFormat.xml' path='doc/member[@name="AlternateNormalizationFormat.AlternateNormalizationFormat_NotNormalized"]/*' />
    AlternateNormalizationFormat_NotNormalized = 0,

    /// <include file='AlternateNormalizationFormat.xml' path='doc/member[@name="AlternateNormalizationFormat.AlternateNormalizationFormat_Number"]/*' />
    AlternateNormalizationFormat_Number = 1,

    /// <include file='AlternateNormalizationFormat.xml' path='doc/member[@name="AlternateNormalizationFormat.AlternateNormalizationFormat_Currency"]/*' />
    AlternateNormalizationFormat_Currency = 3,

    /// <include file='AlternateNormalizationFormat.xml' path='doc/member[@name="AlternateNormalizationFormat.AlternateNormalizationFormat_Date"]/*' />
    AlternateNormalizationFormat_Date = 4,

    /// <include file='AlternateNormalizationFormat.xml' path='doc/member[@name="AlternateNormalizationFormat.AlternateNormalizationFormat_Time"]/*' />
    AlternateNormalizationFormat_Time = 5,
}
