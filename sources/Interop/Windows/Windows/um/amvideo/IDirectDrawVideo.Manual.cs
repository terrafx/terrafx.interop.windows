// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

[Guid("36D39EB0-DD75-11CE-BF0E-00AA0055595A")]
public partial struct IDirectDrawVideo
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IDirectDrawVideo;
}
