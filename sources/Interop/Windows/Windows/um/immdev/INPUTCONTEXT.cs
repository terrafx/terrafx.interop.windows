// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public unsafe partial struct INPUTCONTEXT
{
    public HWND hWnd;

    public BOOL fOpen;

    public POINT ptStatusWndPos;

    public POINT ptSoftKbdPos;

    [NativeTypeName("DWORD")]
    public uint fdwConversion;

    [NativeTypeName("DWORD")]
    public uint fdwSentence;

    [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/immdev.h:873:5)")]
    public _lfFont_e__Union lfFont;

    public COMPOSITIONFORM cfCompForm;

    [NativeTypeName("CANDIDATEFORM [4]")]
    public _cfCandForm_e__FixedBuffer cfCandForm;

    public HIMCC hCompStr;

    public HIMCC hCandInfo;

    public HIMCC hGuideLine;

    public HIMCC hPrivate;

    [NativeTypeName("DWORD")]
    public uint dwNumMsgBuf;

    public HIMCC hMsgBuf;

    [NativeTypeName("DWORD")]
    public uint fdwInit;

    [NativeTypeName("DWORD [3]")]
    public fixed uint dwReserve[3];

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _lfFont_e__Union
    {
        [FieldOffset(0)]
        public LOGFONTA A;

        [FieldOffset(0)]
        public LOGFONTW W;
    }

    public partial struct _cfCandForm_e__FixedBuffer
    {
        public CANDIDATEFORM e0;
        public CANDIDATEFORM e1;
        public CANDIDATEFORM e2;
        public CANDIDATEFORM e3;

        public ref CANDIDATEFORM this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<CANDIDATEFORM> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 4);
    }
}
