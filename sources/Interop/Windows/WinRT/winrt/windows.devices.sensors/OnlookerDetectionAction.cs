// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='OnlookerDetectionAction.xml' path='doc/member[@name="OnlookerDetectionAction"]/*' />
public enum OnlookerDetectionAction
{
    /// <include file='OnlookerDetectionAction.xml' path='doc/member[@name="OnlookerDetectionAction.OnlookerDetectionAction_Dim"]/*' />
    OnlookerDetectionAction_Dim = 0,

    /// <include file='OnlookerDetectionAction.xml' path='doc/member[@name="OnlookerDetectionAction.OnlookerDetectionAction_Notify"]/*' />
    OnlookerDetectionAction_Notify = 1,

    /// <include file='OnlookerDetectionAction.xml' path='doc/member[@name="OnlookerDetectionAction.OnlookerDetectionAction_DimAndNotify"]/*' />
    OnlookerDetectionAction_DimAndNotify = 2,
}
