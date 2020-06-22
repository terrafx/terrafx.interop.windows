// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DMO_INPUT_DATA_BUFFER_FLAGS
    {
        DMO_INPUT_DATA_BUFFERF_SYNCPOINT = 0x1,
        DMO_INPUT_DATA_BUFFERF_TIME = 0x2,
        DMO_INPUT_DATA_BUFFERF_TIMELENGTH = 0x4,
        DMO_INPUT_DATA_BUFFERF_DISCONTINUITY = 0x8,
    }
}
