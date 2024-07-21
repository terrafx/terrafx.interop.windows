// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PowerlineFrequency.xml' path='doc/member[@name="PowerlineFrequency"]/*' />
public enum PowerlineFrequency
{
    /// <include file='PowerlineFrequency.xml' path='doc/member[@name="PowerlineFrequency.PowerlineFrequency_Disabled"]/*' />
    PowerlineFrequency_Disabled = 0,

    /// <include file='PowerlineFrequency.xml' path='doc/member[@name="PowerlineFrequency.PowerlineFrequency_FiftyHertz"]/*' />
    PowerlineFrequency_FiftyHertz = 1,

    /// <include file='PowerlineFrequency.xml' path='doc/member[@name="PowerlineFrequency.PowerlineFrequency_SixtyHertz"]/*' />
    PowerlineFrequency_SixtyHertz = 2,

    /// <include file='PowerlineFrequency.xml' path='doc/member[@name="PowerlineFrequency.PowerlineFrequency_Auto"]/*' />
    PowerlineFrequency_Auto = 3,
}
