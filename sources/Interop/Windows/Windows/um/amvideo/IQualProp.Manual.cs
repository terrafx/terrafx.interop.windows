// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

[Guid("1BD0ECB0-F8E2-11CE-AAC6-0020AF0B99A3")]
public partial struct IQualProp
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IQualProp;
}
