// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_SYSTEM_STORE_RELOCATE_PARA
    {
        [NativeTypeName("_CERT_SYSTEM_STORE_RELOCATE_PARA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/wincrypt.h:9483:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("_CERT_SYSTEM_STORE_RELOCATE_PARA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/wincrypt.h:9487:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public ref HKEY hKeyBase
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union* pField = &Anonymous1)
                {
                    return ref pField->hKeyBase;
                }
            }
        }

        public ref void* pvBase
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous1_e__Union* pField = &Anonymous1)
                {
                    return ref pField->pvBase;
                }
            }
        }

        public ref void* pvSystemStore
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union* pField = &Anonymous2)
                {
                    return ref pField->pvSystemStore;
                }
            }
        }

        public ref sbyte* pszSystemStore
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union* pField = &Anonymous2)
                {
                    return ref pField->pszSystemStore;
                }
            }
        }

        public ref ushort* pwszSystemStore
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous2_e__Union* pField = &Anonymous2)
                {
                    return ref pField->pwszSystemStore;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            public HKEY hKeyBase;

            [FieldOffset(0)]
            public void* pvBase;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            public void* pvSystemStore;

            [FieldOffset(0)]
            [NativeTypeName("LPCSTR")]
            public sbyte* pszSystemStore;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pwszSystemStore;
        }
    }
}
