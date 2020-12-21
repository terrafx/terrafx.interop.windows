// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_STREAM_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbContent;

        [NativeTypeName("PFN_CMSG_STREAM_OUTPUT")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, byte*, uint, int, int> pfnStreamOutput;
#else
        public void* _pfnStreamOutput;

        public delegate* unmanaged[Stdcall]<void*, byte*, uint, int, int> pfnStreamOutput
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, byte*, uint, int, int>)_pfnStreamOutput;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnStreamOutput = value;
            }
        }
#endif

        [NativeTypeName("void *")]
        public void* pvArg;
    }
}
