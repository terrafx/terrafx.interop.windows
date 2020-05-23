// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum COPYFILE2_MESSAGE_ACTION
    {
        COPYFILE2_PROGRESS_CONTINUE = 0,
        COPYFILE2_PROGRESS_CANCEL,
        COPYFILE2_PROGRESS_STOP,
        COPYFILE2_PROGRESS_QUIET,
        COPYFILE2_PROGRESS_PAUSE,
    }
}
