// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ManipulationDelta.xml' path='doc/member[@name="ManipulationDelta"]/*' />
public partial struct ManipulationDelta
{
    /// <include file='ManipulationDelta.xml' path='doc/member[@name="ManipulationDelta.Translation"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::Point")]
    public Point Translation;

    /// <include file='ManipulationDelta.xml' path='doc/member[@name="ManipulationDelta.Scale"]/*' />
    public float Scale;

    /// <include file='ManipulationDelta.xml' path='doc/member[@name="ManipulationDelta.Rotation"]/*' />
    public float Rotation;

    /// <include file='ManipulationDelta.xml' path='doc/member[@name="ManipulationDelta.Expansion"]/*' />
    public float Expansion;
}
