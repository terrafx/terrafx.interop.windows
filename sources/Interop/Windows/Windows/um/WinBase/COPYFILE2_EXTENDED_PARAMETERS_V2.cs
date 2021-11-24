// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public unsafe partial struct COPYFILE2_EXTENDED_PARAMETERS_V2
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwCopyFlags;

    public BOOL* pfCancel;

    [NativeTypeName("PCOPYFILE2_PROGRESS_ROUTINE")]
    public delegate* unmanaged<COPYFILE2_MESSAGE*, void*, COPYFILE2_MESSAGE_ACTION> pProgressRoutine;

    [NativeTypeName("PVOID")]
    public void* pvCallbackContext;

    [NativeTypeName("DWORD")]
    public uint dwCopyFlagsV2;

    [NativeTypeName("ULONG")]
    public uint ioDesiredSize;

    [NativeTypeName("ULONG")]
    public uint ioDesiredRate;

    [NativeTypeName("PVOID [8]")]
    public _reserved_e__FixedBuffer reserved;

    public unsafe partial struct _reserved_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public void* e2;
        public void* e3;
        public void* e4;
        public void* e5;
        public void* e6;
        public void* e7;

        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
