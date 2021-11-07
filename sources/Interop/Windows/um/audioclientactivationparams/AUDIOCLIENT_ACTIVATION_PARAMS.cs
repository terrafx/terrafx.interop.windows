// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audioclientactivationparams.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0.19043.0")]
    public partial struct AUDIOCLIENT_ACTIVATION_PARAMS
    {
        public AUDIOCLIENT_ACTIVATION_TYPE ActivationType;

        [NativeTypeName("AUDIOCLIENT_ACTIVATION_PARAMS::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/audioclientactivationparams.h:94:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS ProcessLoopbackParams
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ProcessLoopbackParams, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS ProcessLoopbackParams;
        }
    }
}
