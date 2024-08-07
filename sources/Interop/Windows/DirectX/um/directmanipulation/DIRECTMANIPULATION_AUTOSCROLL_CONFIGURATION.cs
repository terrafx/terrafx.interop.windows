// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION"]/*' />
[SupportedOSPlatform("windows6.3")]
public enum DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION
{
    /// <include file='DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION.DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION_STOP"]/*' />
    DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION_STOP = 0,

    /// <include file='DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION.DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION_FORWARD"]/*' />
    DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION_FORWARD = 1,

    /// <include file='DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION.xml' path='doc/member[@name="DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION.DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION_REVERSE"]/*' />
    DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION_REVERSE = 2,
}
