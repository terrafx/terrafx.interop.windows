// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/handleapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [NativeTypeName("#define INVALID_HANDLE_VALUE ((HANDLE)(LONG_PTR)-1)")]
    public static HANDLE INVALID_HANDLE_VALUE => unchecked((HANDLE)((nint)(-1)));
}
