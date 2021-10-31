// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DispatcherQueue.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("coremessaging", ExactSpelling = true)]
        public static extern HRESULT CreateDispatcherQueueController(DispatcherQueueOptions options, [NativeTypeName("ABI::Windows::System::IDispatcherQueueController **")] void** dispatcherQueueController);
    }
}
