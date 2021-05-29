// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.SPFILEMODE;

namespace TerraFX.Interop
{
    public enum SpeechStreamFileMode
    {
        SSFMOpenForRead = SPFM_OPEN_READONLY,
        SSFMOpenReadWrite = SPFM_OPEN_READWRITE,
        SSFMCreate = SPFM_CREATE,
        SSFMCreateForWrite = SPFM_CREATE_ALWAYS,
    }
}
