// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct RM_FILTER_INFO
    {
        public RM_FILTER_ACTION FilterAction;

        public RM_FILTER_TRIGGER FilterTrigger;

        [NativeTypeName("DWORD")]
        public uint cbNextOffset;

        [NativeTypeName("_RM_FILTER_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/RestartManager.h:124:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref ushort* strFilename
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->strFilename;
                }
            }
        }

        public ref RM_UNIQUE_PROCESS Process
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Process, 1));
            }
        }

        public ref ushort* strServiceShortName
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->strServiceShortName;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* strFilename;

            [FieldOffset(0)]
            public RM_UNIQUE_PROCESS Process;

            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* strServiceShortName;
        }
    }
}
