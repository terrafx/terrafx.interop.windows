// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oobenotification.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL OOBEComplete([NativeTypeName("PBOOL")] BOOL* isOOBEComplete);
}
