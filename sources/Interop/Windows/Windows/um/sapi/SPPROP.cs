// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SPPROP
{
    /// <include file='SPPROP.xml' path='doc/member[@name="SPPROP.SPPROP_RESOURCE_USAGE"]/*' />
    [NativeTypeName("#define SPPROP_RESOURCE_USAGE L\"ResourceUsage\"")]
    public const string SPPROP_RESOURCE_USAGE = "ResourceUsage";

    /// <include file='SPPROP.xml' path='doc/member[@name="SPPROP.SPPROP_HIGH_CONFIDENCE_THRESHOLD"]/*' />
    [NativeTypeName("#define SPPROP_HIGH_CONFIDENCE_THRESHOLD L\"HighConfidenceThreshold\"")]
    public const string SPPROP_HIGH_CONFIDENCE_THRESHOLD = "HighConfidenceThreshold";

    /// <include file='SPPROP.xml' path='doc/member[@name="SPPROP.SPPROP_NORMAL_CONFIDENCE_THRESHOLD"]/*' />
    [NativeTypeName("#define SPPROP_NORMAL_CONFIDENCE_THRESHOLD L\"NormalConfidenceThreshold\"")]
    public const string SPPROP_NORMAL_CONFIDENCE_THRESHOLD = "NormalConfidenceThreshold";

    /// <include file='SPPROP.xml' path='doc/member[@name="SPPROP.SPPROP_LOW_CONFIDENCE_THRESHOLD"]/*' />
    [NativeTypeName("#define SPPROP_LOW_CONFIDENCE_THRESHOLD L\"LowConfidenceThreshold\"")]
    public const string SPPROP_LOW_CONFIDENCE_THRESHOLD = "LowConfidenceThreshold";

    /// <include file='SPPROP.xml' path='doc/member[@name="SPPROP.SPPROP_RESPONSE_SPEED"]/*' />
    [NativeTypeName("#define SPPROP_RESPONSE_SPEED L\"ResponseSpeed\"")]
    public const string SPPROP_RESPONSE_SPEED = "ResponseSpeed";

    /// <include file='SPPROP.xml' path='doc/member[@name="SPPROP.SPPROP_COMPLEX_RESPONSE_SPEED"]/*' />
    [NativeTypeName("#define SPPROP_COMPLEX_RESPONSE_SPEED L\"ComplexResponseSpeed\"")]
    public const string SPPROP_COMPLEX_RESPONSE_SPEED = "ComplexResponseSpeed";

    /// <include file='SPPROP.xml' path='doc/member[@name="SPPROP.SPPROP_ADAPTATION_ON"]/*' />
    [NativeTypeName("#define SPPROP_ADAPTATION_ON L\"AdaptationOn\"")]
    public const string SPPROP_ADAPTATION_ON = "AdaptationOn";

    /// <include file='SPPROP.xml' path='doc/member[@name="SPPROP.SPPROP_PERSISTED_BACKGROUND_ADAPTATION"]/*' />
    [NativeTypeName("#define SPPROP_PERSISTED_BACKGROUND_ADAPTATION L\"PersistedBackgroundAdaptation\"")]
    public const string SPPROP_PERSISTED_BACKGROUND_ADAPTATION = "PersistedBackgroundAdaptation";

    /// <include file='SPPROP.xml' path='doc/member[@name="SPPROP.SPPROP_PERSISTED_LANGUAGE_MODEL_ADAPTATION"]/*' />
    [NativeTypeName("#define SPPROP_PERSISTED_LANGUAGE_MODEL_ADAPTATION L\"PersistedLanguageModelAdaptation\"")]
    public const string SPPROP_PERSISTED_LANGUAGE_MODEL_ADAPTATION = "PersistedLanguageModelAdaptation";

    /// <include file='SPPROP.xml' path='doc/member[@name="SPPROP.SPPROP_UX_IS_LISTENING"]/*' />
    [NativeTypeName("#define SPPROP_UX_IS_LISTENING L\"UXIsListening\"")]
    public const string SPPROP_UX_IS_LISTENING = "UXIsListening";
}
