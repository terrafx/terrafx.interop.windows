// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct STACKFRAME
    {
        public ADDRESS AddrPC;

        public ADDRESS AddrReturn;

        public ADDRESS AddrFrame;

        public ADDRESS AddrStack;

        [NativeTypeName("PVOID")]
        public void* FuncTableEntry;

        [NativeTypeName("DWORD [4]")]
        public fixed uint Params[4];

        public BOOL Far;

        public BOOL Virtual;

        [NativeTypeName("DWORD [3]")]
        public fixed uint Reserved[3];

        public KDHELP KdHelp;

        public ADDRESS AddrBStore;
    }
}
