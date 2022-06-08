// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='UIAnimationManager2.xml' path='doc/member[@name="UIAnimationManager2"]/*' />
[Guid("D25D8842-8884-4A4A-B321-091314379BDD")]
public partial struct UIAnimationManager2 : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_UIAnimationManager2;
}
