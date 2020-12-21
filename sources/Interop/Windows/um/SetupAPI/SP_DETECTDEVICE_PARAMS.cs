// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct SP_DETECTDEVICE_PARAMS
    {
        public SP_CLASSINSTALL_HEADER ClassInstallHeader;

        [NativeTypeName("PDETECT_PROGRESS_NOTIFY")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<void*, uint, int> DetectProgressNotify;
#else
        public void* _DetectProgressNotify;

        public delegate* unmanaged[Stdcall]<void*, uint, int> DetectProgressNotify
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<void*, uint, int>)_DetectProgressNotify;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _DetectProgressNotify = value;
            }
        }
#endif

        [NativeTypeName("PVOID")]
        public void* ProgressNotifyParam;
    }
}
