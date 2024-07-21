// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TextPredictionOptions.xml' path='doc/member[@name="TextPredictionOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum TextPredictionOptions : uint
{
    /// <include file='TextPredictionOptions.xml' path='doc/member[@name="TextPredictionOptions.TextPredictionOptions_None"]/*' />
    TextPredictionOptions_None = 0,

    /// <include file='TextPredictionOptions.xml' path='doc/member[@name="TextPredictionOptions.TextPredictionOptions_Predictions"]/*' />
    TextPredictionOptions_Predictions = 0x1,

    /// <include file='TextPredictionOptions.xml' path='doc/member[@name="TextPredictionOptions.TextPredictionOptions_Corrections"]/*' />
    TextPredictionOptions_Corrections = 0x2,
}
