// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFASYNC_WORKQUEUE_TYPE
    {
        MF_STANDARD_WORKQUEUE = 0,
        MF_WINDOW_WORKQUEUE = 1,
        MF_MULTITHREADED_WORKQUEUE = 2,
    }
}
