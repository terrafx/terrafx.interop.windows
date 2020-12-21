// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct COPYFILE2_EXTENDED_PARAMETERS
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwCopyFlags;

        [NativeTypeName("BOOL *")]
        public int* pfCancel;

        [NativeTypeName("PCOPYFILE2_PROGRESS_ROUTINE")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<COPYFILE2_MESSAGE*, void*, COPYFILE2_MESSAGE_ACTION> pProgressRoutine;
#else
        public void* _pProgressRoutine;

        public delegate* unmanaged[Stdcall]<COPYFILE2_MESSAGE*, void*, COPYFILE2_MESSAGE_ACTION> pProgressRoutine
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<COPYFILE2_MESSAGE*, void*, COPYFILE2_MESSAGE_ACTION>)_pProgressRoutine;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pProgressRoutine = value;
            }
        }
#endif

        [NativeTypeName("PVOID")]
        public void* pvCallbackContext;
    }
}
