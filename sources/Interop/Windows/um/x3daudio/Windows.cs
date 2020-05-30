// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("X3DAudio1_7", EntryPoint = "X3DAudioInitialize", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int X3DAudioInitialize([NativeTypeName("UINT32")] uint SpeakerChannelMask, [NativeTypeName("FLOAT32")] float SpeedOfSound, [NativeTypeName("X3DAUDIO_HANDLE")] byte Instance);

        [DllImport("X3DAudio1_7", EntryPoint = "X3DAudioCalculate", ExactSpelling = true)]
        public static extern void X3DAudioCalculate([NativeTypeName("const X3DAUDIO_HANDLE")] byte Instance, [NativeTypeName("const X3DAUDIO_LISTENER *")] X3DAUDIO_LISTENER* pListener, [NativeTypeName("const X3DAUDIO_EMITTER *")] X3DAUDIO_EMITTER* pEmitter, [NativeTypeName("UINT32")] uint Flags, [NativeTypeName("X3DAUDIO_DSP_SETTINGS *")] X3DAUDIO_DSP_SETTINGS* pDSPSettings);
    }
}
