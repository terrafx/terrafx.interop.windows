// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class NI
{
    /// <include file='NI.xml' path='doc/member[@name="NI.NI_OPENCANDIDATE"]/*' />
    [NativeTypeName("#define NI_OPENCANDIDATE 0x0010")]
    public const int NI_OPENCANDIDATE = 0x0010;

    /// <include file='NI.xml' path='doc/member[@name="NI.NI_CLOSECANDIDATE"]/*' />
    [NativeTypeName("#define NI_CLOSECANDIDATE 0x0011")]
    public const int NI_CLOSECANDIDATE = 0x0011;

    /// <include file='NI.xml' path='doc/member[@name="NI.NI_SELECTCANDIDATESTR"]/*' />
    [NativeTypeName("#define NI_SELECTCANDIDATESTR 0x0012")]
    public const int NI_SELECTCANDIDATESTR = 0x0012;

    /// <include file='NI.xml' path='doc/member[@name="NI.NI_CHANGECANDIDATELIST"]/*' />
    [NativeTypeName("#define NI_CHANGECANDIDATELIST 0x0013")]
    public const int NI_CHANGECANDIDATELIST = 0x0013;

    /// <include file='NI.xml' path='doc/member[@name="NI.NI_FINALIZECONVERSIONRESULT"]/*' />
    [NativeTypeName("#define NI_FINALIZECONVERSIONRESULT 0x0014")]
    public const int NI_FINALIZECONVERSIONRESULT = 0x0014;

    /// <include file='NI.xml' path='doc/member[@name="NI.NI_COMPOSITIONSTR"]/*' />
    [NativeTypeName("#define NI_COMPOSITIONSTR 0x0015")]
    public const int NI_COMPOSITIONSTR = 0x0015;

    /// <include file='NI.xml' path='doc/member[@name="NI.NI_SETCANDIDATE_PAGESTART"]/*' />
    [NativeTypeName("#define NI_SETCANDIDATE_PAGESTART 0x0016")]
    public const int NI_SETCANDIDATE_PAGESTART = 0x0016;

    /// <include file='NI.xml' path='doc/member[@name="NI.NI_SETCANDIDATE_PAGESIZE"]/*' />
    [NativeTypeName("#define NI_SETCANDIDATE_PAGESIZE 0x0017")]
    public const int NI_SETCANDIDATE_PAGESIZE = 0x0017;

    /// <include file='NI.xml' path='doc/member[@name="NI.NI_IMEMENUSELECTED"]/*' />
    [NativeTypeName("#define NI_IMEMENUSELECTED 0x0018")]
    public const int NI_IMEMENUSELECTED = 0x0018;
}
