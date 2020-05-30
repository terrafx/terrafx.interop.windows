// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Windows.Media.Audio", EntryPoint = "CreateAudioVolumeMeter", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateAudioVolumeMeter([NativeTypeName("IUnknown **")] IUnknown** ppApo);

        [DllImport("Windows.Media.Audio", EntryPoint = "CreateAudioReverb", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateAudioReverb([NativeTypeName("IUnknown **")] IUnknown** ppApo);
    }
}
