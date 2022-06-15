// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("00000000-0000-0000-0000-000000000000")]
public partial struct CIE4ConnectionPoint
{
    static ref readonly Guid IHaveNativeGuid.GUID => throw new NotImplementedException();
}
