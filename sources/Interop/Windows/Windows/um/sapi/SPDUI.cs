// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SPDUI
{
    /// <include file='SPDUI.xml' path='doc/member[@name="SPDUI.SPDUI_EngineProperties"]/*' />
    [NativeTypeName("#define SPDUI_EngineProperties L\"EngineProperties\"")]
    public const string SPDUI_EngineProperties = "EngineProperties";

    /// <include file='SPDUI.xml' path='doc/member[@name="SPDUI.SPDUI_AddRemoveWord"]/*' />
    [NativeTypeName("#define SPDUI_AddRemoveWord L\"AddRemoveWord\"")]
    public const string SPDUI_AddRemoveWord = "AddRemoveWord";

    /// <include file='SPDUI.xml' path='doc/member[@name="SPDUI.SPDUI_UserTraining"]/*' />
    [NativeTypeName("#define SPDUI_UserTraining L\"UserTraining\"")]
    public const string SPDUI_UserTraining = "UserTraining";

    /// <include file='SPDUI.xml' path='doc/member[@name="SPDUI.SPDUI_MicTraining"]/*' />
    [NativeTypeName("#define SPDUI_MicTraining L\"MicTraining\"")]
    public const string SPDUI_MicTraining = "MicTraining";

    /// <include file='SPDUI.xml' path='doc/member[@name="SPDUI.SPDUI_RecoProfileProperties"]/*' />
    [NativeTypeName("#define SPDUI_RecoProfileProperties L\"RecoProfileProperties\"")]
    public const string SPDUI_RecoProfileProperties = "RecoProfileProperties";

    /// <include file='SPDUI.xml' path='doc/member[@name="SPDUI.SPDUI_AudioProperties"]/*' />
    [NativeTypeName("#define SPDUI_AudioProperties L\"AudioProperties\"")]
    public const string SPDUI_AudioProperties = "AudioProperties";

    /// <include file='SPDUI.xml' path='doc/member[@name="SPDUI.SPDUI_AudioVolume"]/*' />
    [NativeTypeName("#define SPDUI_AudioVolume L\"AudioVolume\"")]
    public const string SPDUI_AudioVolume = "AudioVolume";

    /// <include file='SPDUI.xml' path='doc/member[@name="SPDUI.SPDUI_UserEnrollment"]/*' />
    [NativeTypeName("#define SPDUI_UserEnrollment L\"UserEnrollment\"")]
    public const string SPDUI_UserEnrollment = "UserEnrollment";

    /// <include file='SPDUI.xml' path='doc/member[@name="SPDUI.SPDUI_ShareData"]/*' />
    [NativeTypeName("#define SPDUI_ShareData L\"ShareData\"")]
    public const string SPDUI_ShareData = "ShareData";

    /// <include file='SPDUI.xml' path='doc/member[@name="SPDUI.SPDUI_Tutorial"]/*' />
    [NativeTypeName("#define SPDUI_Tutorial L\"Tutorial\"")]
    public const string SPDUI_Tutorial = "Tutorial";
}
