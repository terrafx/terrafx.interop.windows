// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SpeechTokenShellFolder
    {
        STSF_AppData = 0x1a,
        STSF_LocalAppData = 0x1c,
        STSF_CommonAppData = 0x23,
        STSF_FlagCreate = 0x8000,
    }
}
