// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MKRREDUCE
    {
        MKRREDUCE_ONE = (3 << 16),
        MKRREDUCE_TOUSER = (2 << 16),
        MKRREDUCE_THROUGHUSER = (1 << 16),
        MKRREDUCE_ALL = 0,
    }
}
