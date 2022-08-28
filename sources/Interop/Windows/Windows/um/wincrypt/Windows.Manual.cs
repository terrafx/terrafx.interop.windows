// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [NativeTypeName("#define HCCE_CURRENT_USER ((HCERTCHAINENGINE)NULL)")]
    public static HCERTCHAINENGINE HCCE_CURRENT_USER => ((HCERTCHAINENGINE)(NULL));

    [NativeTypeName("#define HCCE_LOCAL_MACHINE ((HCERTCHAINENGINE)0x1)")]
    public static HCERTCHAINENGINE HCCE_LOCAL_MACHINE => ((HCERTCHAINENGINE)(0x1));

    [NativeTypeName("#define HCCE_SERIAL_LOCAL_MACHINE ((HCERTCHAINENGINE)0x2)")]
    public static HCERTCHAINENGINE HCCE_SERIAL_LOCAL_MACHINE => ((HCERTCHAINENGINE)(0x2));
}
