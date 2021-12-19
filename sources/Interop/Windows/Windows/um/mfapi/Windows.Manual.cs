// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public static uint FCC(uint ch4) => ((((uint)(ch4) & 0xFF) << 24) | (((uint)(ch4) & 0xFF00) << 8) | (((uint)(ch4) & 0xFF0000) >> 8) | (((uint)(ch4) & 0xFF000000) >> 24));
}
