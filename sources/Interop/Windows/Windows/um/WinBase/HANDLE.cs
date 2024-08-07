// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct HANDLE
{
    [NativeTypeName("#define HANDLE_FLAG_INHERIT 0x00000001")]
    public const int HANDLE_FLAG_INHERIT = 0x00000001;

    [NativeTypeName("#define HANDLE_FLAG_PROTECT_FROM_CLOSE 0x00000002")]
    public const int HANDLE_FLAG_PROTECT_FROM_CLOSE = 0x00000002;
}
