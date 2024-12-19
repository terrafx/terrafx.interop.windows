// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB"]/*' />
public enum HTTP_VERB
{
    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbUnparsed"]/*' />
    HttpVerbUnparsed,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbUnknown"]/*' />
    HttpVerbUnknown,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbInvalid"]/*' />
    HttpVerbInvalid,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbOPTIONS"]/*' />
    HttpVerbOPTIONS,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbGET"]/*' />
    HttpVerbGET,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbHEAD"]/*' />
    HttpVerbHEAD,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbPOST"]/*' />
    HttpVerbPOST,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbPUT"]/*' />
    HttpVerbPUT,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbDELETE"]/*' />
    HttpVerbDELETE,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbTRACE"]/*' />
    HttpVerbTRACE,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbCONNECT"]/*' />
    HttpVerbCONNECT,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbTRACK"]/*' />
    HttpVerbTRACK,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbMOVE"]/*' />
    HttpVerbMOVE,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbCOPY"]/*' />
    HttpVerbCOPY,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbPROPFIND"]/*' />
    HttpVerbPROPFIND,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbPROPPATCH"]/*' />
    HttpVerbPROPPATCH,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbMKCOL"]/*' />
    HttpVerbMKCOL,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbLOCK"]/*' />
    HttpVerbLOCK,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbUNLOCK"]/*' />
    HttpVerbUNLOCK,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbSEARCH"]/*' />
    HttpVerbSEARCH,

    /// <include file='HTTP_VERB.xml' path='doc/member[@name="HTTP_VERB.HttpVerbMaximum"]/*' />
    HttpVerbMaximum,
}
