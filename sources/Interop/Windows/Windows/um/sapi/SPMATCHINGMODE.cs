// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum SPMATCHINGMODE
{
    AllWords = 0,
    Subsequence = 1,
    OrderedSubset = 3,
    SubsequenceContentRequired = 5,
    OrderedSubsetContentRequired = 7,
}
