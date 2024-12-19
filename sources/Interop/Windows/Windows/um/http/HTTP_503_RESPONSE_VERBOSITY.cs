// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_503_RESPONSE_VERBOSITY.xml' path='doc/member[@name="HTTP_503_RESPONSE_VERBOSITY"]/*' />
public enum HTTP_503_RESPONSE_VERBOSITY
{
    /// <include file='HTTP_503_RESPONSE_VERBOSITY.xml' path='doc/member[@name="HTTP_503_RESPONSE_VERBOSITY.Http503ResponseVerbosityBasic"]/*' />
    Http503ResponseVerbosityBasic,

    /// <include file='HTTP_503_RESPONSE_VERBOSITY.xml' path='doc/member[@name="HTTP_503_RESPONSE_VERBOSITY.Http503ResponseVerbosityLimited"]/*' />
    Http503ResponseVerbosityLimited,

    /// <include file='HTTP_503_RESPONSE_VERBOSITY.xml' path='doc/member[@name="HTTP_503_RESPONSE_VERBOSITY.Http503ResponseVerbosityFull"]/*' />
    Http503ResponseVerbosityFull,
}
