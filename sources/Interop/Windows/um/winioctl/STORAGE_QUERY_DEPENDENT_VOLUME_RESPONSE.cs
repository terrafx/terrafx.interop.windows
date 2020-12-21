// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE
    {
        [NativeTypeName("DWORD")]
        public uint ResponseLevel;

        [NativeTypeName("DWORD")]
        public uint NumberEntries;

        [NativeTypeName("_STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:13374:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY Lev1Depends
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Lev1Depends, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Lev1Depends;
#endif
            }
        }

        public unsafe ref STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY Lev2Depends
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Lev2Depends, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->Lev2Depends;
#endif
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY []")]
            public STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY Lev1Depends;

            [FieldOffset(0)]
            [NativeTypeName("STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY []")]
            public STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY Lev2Depends;
        }
    }
}
