// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("mmdevapi", EntryPoint = "ActivateAudioInterfaceAsync", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ActivateAudioInterfaceAsync([NativeTypeName("LPCWSTR")] ushort* deviceInterfacePath, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* activationParams, [NativeTypeName("IActivateAudioInterfaceCompletionHandler *")] IActivateAudioInterfaceCompletionHandler* completionHandler, [NativeTypeName("IActivateAudioInterfaceAsyncOperation **")] IActivateAudioInterfaceAsyncOperation** activationOperation);
    }
}
