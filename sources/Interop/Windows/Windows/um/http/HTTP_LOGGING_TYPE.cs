// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_LOGGING_TYPE.xml' path='doc/member[@name="HTTP_LOGGING_TYPE"]/*' />
public enum HTTP_LOGGING_TYPE
{
    /// <include file='HTTP_LOGGING_TYPE.xml' path='doc/member[@name="HTTP_LOGGING_TYPE.HttpLoggingTypeW3C"]/*' />
    HttpLoggingTypeW3C,

    /// <include file='HTTP_LOGGING_TYPE.xml' path='doc/member[@name="HTTP_LOGGING_TYPE.HttpLoggingTypeIIS"]/*' />
    HttpLoggingTypeIIS,

    /// <include file='HTTP_LOGGING_TYPE.xml' path='doc/member[@name="HTTP_LOGGING_TYPE.HttpLoggingTypeNCSA"]/*' />
    HttpLoggingTypeNCSA,

    /// <include file='HTTP_LOGGING_TYPE.xml' path='doc/member[@name="HTTP_LOGGING_TYPE.HttpLoggingTypeRaw"]/*' />
    HttpLoggingTypeRaw,
}
