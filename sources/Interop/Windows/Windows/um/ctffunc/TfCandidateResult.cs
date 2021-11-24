// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum TfCandidateResult
{
    CAND_FINALIZED = 0,
    CAND_SELECTED = 0x1,
    CAND_CANCELED = 0x2,
}
