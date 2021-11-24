// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.CLSCTX;

namespace TerraFX.Interop.Windows;

public enum SpeechTokenContext
{
    STCInprocServer = CLSCTX_INPROC_SERVER,
    STCInprocHandler = CLSCTX_INPROC_HANDLER,
    STCLocalServer = CLSCTX_LOCAL_SERVER,
    STCRemoteServer = CLSCTX_REMOTE_SERVER,
    STCAll = (((CLSCTX_INPROC_SERVER | CLSCTX_INPROC_HANDLER) | CLSCTX_LOCAL_SERVER) | CLSCTX_REMOTE_SERVER),
}
