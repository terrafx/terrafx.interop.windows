// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT"]/*' />
public partial struct INPUTCONTEXT
{
    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.hWnd"]/*' />
    public HWND hWnd;

    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.fOpen"]/*' />
    public BOOL fOpen;

    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.ptStatusWndPos"]/*' />
    public POINT ptStatusWndPos;

    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.ptSoftKbdPos"]/*' />
    public POINT ptSoftKbdPos;

    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.fdwConversion"]/*' />
    [NativeTypeName("DWORD")]
    public uint fdwConversion;

    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.fdwSentence"]/*' />
    [NativeTypeName("DWORD")]
    public uint fdwSentence;

    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.lfFont"]/*' />
    [NativeTypeName("__AnonymousRecord_immdev_L873_C5")]
    public _lfFont_e__Union lfFont;

    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.cfCompForm"]/*' />
    public COMPOSITIONFORM cfCompForm;

    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.cfCandForm"]/*' />
    [NativeTypeName("CANDIDATEFORM[4]")]
    public _cfCandForm_e__FixedBuffer cfCandForm;

    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.hCompStr"]/*' />
    public HIMCC hCompStr;

    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.hCandInfo"]/*' />
    public HIMCC hCandInfo;

    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.hGuideLine"]/*' />
    public HIMCC hGuideLine;

    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.hPrivate"]/*' />
    public HIMCC hPrivate;

    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.dwNumMsgBuf"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNumMsgBuf;

    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.hMsgBuf"]/*' />
    public HIMCC hMsgBuf;

    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.fdwInit"]/*' />
    [NativeTypeName("DWORD")]
    public uint fdwInit;

    /// <include file='INPUTCONTEXT.xml' path='doc/member[@name="INPUTCONTEXT.dwReserve"]/*' />
    [NativeTypeName("DWORD[3]")]
    public _dwReserve_e__FixedBuffer dwReserve;

    /// <include file='_lfFont_e__Union.xml' path='doc/member[@name="_lfFont_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _lfFont_e__Union
    {
        /// <include file='_lfFont_e__Union.xml' path='doc/member[@name="_lfFont_e__Union.A"]/*' />
        [FieldOffset(0)]
        public LOGFONTA A;

        /// <include file='_lfFont_e__Union.xml' path='doc/member[@name="_lfFont_e__Union.W"]/*' />
        [FieldOffset(0)]
        public LOGFONTW W;
    }

    /// <include file='_cfCandForm_e__FixedBuffer.xml' path='doc/member[@name="_cfCandForm_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _cfCandForm_e__FixedBuffer
    {
        public CANDIDATEFORM e0;
    }

    /// <include file='_dwReserve_e__FixedBuffer.xml' path='doc/member[@name="_dwReserve_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _dwReserve_e__FixedBuffer
    {
        public uint e0;
    }
}
