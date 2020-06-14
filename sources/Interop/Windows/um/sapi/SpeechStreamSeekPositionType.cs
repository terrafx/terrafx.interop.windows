// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.STREAM_SEEK;

namespace TerraFX.Interop
{
    public enum SpeechStreamSeekPositionType
    {
        SSSPTRelativeToStart = STREAM_SEEK_SET,
        SSSPTRelativeToCurrentPosition = STREAM_SEEK_CUR,
        SSSPTRelativeToEnd = STREAM_SEEK_END,
    }
}
