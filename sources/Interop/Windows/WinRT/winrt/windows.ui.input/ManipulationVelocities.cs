// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ManipulationVelocities.xml' path='doc/member[@name="ManipulationVelocities"]/*' />
public partial struct ManipulationVelocities
{
    /// <include file='ManipulationVelocities.xml' path='doc/member[@name="ManipulationVelocities.Linear"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Point")]
    public Point Linear;

    /// <include file='ManipulationVelocities.xml' path='doc/member[@name="ManipulationVelocities.Angular"]/*' />
    public float Angular;

    /// <include file='ManipulationVelocities.xml' path='doc/member[@name="ManipulationVelocities.Expansion"]/*' />
    public float Expansion;
}
