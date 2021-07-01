// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_TIMED_TEXT_TRACK_KIND
    {
        MF_TIMED_TEXT_TRACK_KIND_UNKNOWN = 0,
        MF_TIMED_TEXT_TRACK_KIND_SUBTITLES = 1,
        MF_TIMED_TEXT_TRACK_KIND_CAPTIONS = 2,
        MF_TIMED_TEXT_TRACK_KIND_METADATA = 3,
    }
}
