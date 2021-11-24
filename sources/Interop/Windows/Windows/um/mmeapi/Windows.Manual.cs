// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public static byte MEVT_EVENTTYPE(uint x) => ((byte)(((x) >> 24) & 0xFF));

    public static uint MEVT_EVENTPARM(byte x) => ((uint)((x) & 0x00FFFFFFL));
}
