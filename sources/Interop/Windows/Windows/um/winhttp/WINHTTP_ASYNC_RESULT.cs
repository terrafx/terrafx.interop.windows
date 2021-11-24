// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct WINHTTP_ASYNC_RESULT
{
    [NativeTypeName("DWORD_PTR")]
    public nuint dwResult;

    [NativeTypeName("DWORD")]
    public uint dwError;
}
