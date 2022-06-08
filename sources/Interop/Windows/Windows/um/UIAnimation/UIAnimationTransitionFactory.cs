// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='UIAnimationTransitionFactory.xml' path='doc/member[@name="UIAnimationTransitionFactory"]/*' />
[Guid("8A9B1CDD-FCD7-419C-8B44-42FD17DB1887")]
public partial struct UIAnimationTransitionFactory : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_UIAnimationTransitionFactory;
}
