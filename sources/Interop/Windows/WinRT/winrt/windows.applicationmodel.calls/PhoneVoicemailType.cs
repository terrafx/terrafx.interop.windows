// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneVoicemailType.xml' path='doc/member[@name="PhoneVoicemailType"]/*' />
public enum PhoneVoicemailType
{
    /// <include file='PhoneVoicemailType.xml' path='doc/member[@name="PhoneVoicemailType.PhoneVoicemailType_None"]/*' />
    PhoneVoicemailType_None = 0,

    /// <include file='PhoneVoicemailType.xml' path='doc/member[@name="PhoneVoicemailType.PhoneVoicemailType_Traditional"]/*' />
    PhoneVoicemailType_Traditional = 1,

    /// <include file='PhoneVoicemailType.xml' path='doc/member[@name="PhoneVoicemailType.PhoneVoicemailType_Visual"]/*' />
    PhoneVoicemailType_Visual = 2,
}
