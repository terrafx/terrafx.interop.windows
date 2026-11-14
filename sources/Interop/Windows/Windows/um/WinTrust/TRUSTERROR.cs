// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TRUSTERROR
{
    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_WVTPARAMS"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_WVTPARAMS 0")]
    public const int TRUSTERROR_STEP_WVTPARAMS = 0;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_FILEIO"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_FILEIO 2")]
    public const int TRUSTERROR_STEP_FILEIO = 2;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_SIP"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_SIP 3")]
    public const int TRUSTERROR_STEP_SIP = 3;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_SIPSUBJINFO"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_SIPSUBJINFO 5")]
    public const int TRUSTERROR_STEP_SIPSUBJINFO = 5;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_CATALOGFILE"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_CATALOGFILE 6")]
    public const int TRUSTERROR_STEP_CATALOGFILE = 6;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_CERTSTORE"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_CERTSTORE 7")]
    public const int TRUSTERROR_STEP_CERTSTORE = 7;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_MESSAGE"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_MESSAGE 8")]
    public const int TRUSTERROR_STEP_MESSAGE = 8;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_MSG_SIGNERCOUNT"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_SIGNERCOUNT 9")]
    public const int TRUSTERROR_STEP_MSG_SIGNERCOUNT = 9;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_MSG_INNERCNTTYPE"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_INNERCNTTYPE 10")]
    public const int TRUSTERROR_STEP_MSG_INNERCNTTYPE = 10;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_MSG_INNERCNT"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_INNERCNT 11")]
    public const int TRUSTERROR_STEP_MSG_INNERCNT = 11;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_MSG_STORE"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_STORE 12")]
    public const int TRUSTERROR_STEP_MSG_STORE = 12;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_MSG_SIGNERINFO"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_SIGNERINFO 13")]
    public const int TRUSTERROR_STEP_MSG_SIGNERINFO = 13;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_MSG_SIGNERCERT"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_SIGNERCERT 14")]
    public const int TRUSTERROR_STEP_MSG_SIGNERCERT = 14;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_MSG_CERTCHAIN"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_CERTCHAIN 15")]
    public const int TRUSTERROR_STEP_MSG_CERTCHAIN = 15;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_MSG_COUNTERSIGINFO"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_COUNTERSIGINFO 16")]
    public const int TRUSTERROR_STEP_MSG_COUNTERSIGINFO = 16;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_MSG_COUNTERSIGCERT"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_COUNTERSIGCERT 17")]
    public const int TRUSTERROR_STEP_MSG_COUNTERSIGCERT = 17;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_VERIFY_MSGHASH"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_VERIFY_MSGHASH 18")]
    public const int TRUSTERROR_STEP_VERIFY_MSGHASH = 18;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_VERIFY_MSGINDIRECTDATA"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_VERIFY_MSGINDIRECTDATA 19")]
    public const int TRUSTERROR_STEP_VERIFY_MSGINDIRECTDATA = 19;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_FINAL_WVTINIT"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_FINAL_WVTINIT 30")]
    public const int TRUSTERROR_STEP_FINAL_WVTINIT = 30;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_FINAL_INITPROV"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_FINAL_INITPROV 31")]
    public const int TRUSTERROR_STEP_FINAL_INITPROV = 31;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_FINAL_OBJPROV"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_FINAL_OBJPROV 32")]
    public const int TRUSTERROR_STEP_FINAL_OBJPROV = 32;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_FINAL_SIGPROV"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_FINAL_SIGPROV 33")]
    public const int TRUSTERROR_STEP_FINAL_SIGPROV = 33;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_FINAL_CERTPROV"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_FINAL_CERTPROV 34")]
    public const int TRUSTERROR_STEP_FINAL_CERTPROV = 34;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_FINAL_CERTCHKPROV"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_FINAL_CERTCHKPROV 35")]
    public const int TRUSTERROR_STEP_FINAL_CERTCHKPROV = 35;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_FINAL_POLICYPROV"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_FINAL_POLICYPROV 36")]
    public const int TRUSTERROR_STEP_FINAL_POLICYPROV = 36;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_STEP_FINAL_UIPROV"]/*' />
    [NativeTypeName("#define TRUSTERROR_STEP_FINAL_UIPROV 37")]
    public const int TRUSTERROR_STEP_FINAL_UIPROV = 37;

    /// <include file='TRUSTERROR.xml' path='doc/member[@name="TRUSTERROR.TRUSTERROR_MAX_STEPS"]/*' />
    [NativeTypeName("#define TRUSTERROR_MAX_STEPS 38")]
    public const int TRUSTERROR_MAX_STEPS = 38;
}
