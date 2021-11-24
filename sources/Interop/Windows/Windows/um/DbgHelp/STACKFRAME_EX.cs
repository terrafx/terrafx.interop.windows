// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct STACKFRAME_EX
{
    public ADDRESS64 AddrPC;

    public ADDRESS64 AddrReturn;

    public ADDRESS64 AddrFrame;

    public ADDRESS64 AddrStack;

    public ADDRESS64 AddrBStore;

    [NativeTypeName("PVOID")]
    public void* FuncTableEntry;

    [NativeTypeName("DWORD64 [4]")]
    public fixed ulong Params[4];

    public BOOL Far;

    public BOOL Virtual;

    [NativeTypeName("DWORD64 [3]")]
    public fixed ulong Reserved[3];

    public KDHELP64 KdHelp;

    [NativeTypeName("DWORD")]
    public uint StackFrameSize;

    [NativeTypeName("DWORD")]
    public uint InlineFrameContext;
}
