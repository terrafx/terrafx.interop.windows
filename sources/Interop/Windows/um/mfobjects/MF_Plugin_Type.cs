// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum MF_Plugin_Type : uint
    {
        MF_Plugin_Type_MFT = 0,
        MF_Plugin_Type_MediaSource = 1,
        MF_Plugin_Type_MFT_MatchOutputType = 2,
        MF_Plugin_Type_Other = unchecked((uint)-1),
    }
}
