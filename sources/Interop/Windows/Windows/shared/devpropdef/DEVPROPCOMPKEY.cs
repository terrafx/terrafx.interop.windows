// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/devpropdef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct DEVPROPCOMPKEY
{
    public DEVPROPKEY Key;

    public DEVPROPSTORE Store;

    [NativeTypeName("PCWSTR")]
    public ushort* LocaleName;
}
