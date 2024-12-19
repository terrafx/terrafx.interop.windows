// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_LOGGING_ROLLOVER_TYPE.xml' path='doc/member[@name="HTTP_LOGGING_ROLLOVER_TYPE"]/*' />
public enum HTTP_LOGGING_ROLLOVER_TYPE
{
    /// <include file='HTTP_LOGGING_ROLLOVER_TYPE.xml' path='doc/member[@name="HTTP_LOGGING_ROLLOVER_TYPE.HttpLoggingRolloverSize"]/*' />
    HttpLoggingRolloverSize,

    /// <include file='HTTP_LOGGING_ROLLOVER_TYPE.xml' path='doc/member[@name="HTTP_LOGGING_ROLLOVER_TYPE.HttpLoggingRolloverDaily"]/*' />
    HttpLoggingRolloverDaily,

    /// <include file='HTTP_LOGGING_ROLLOVER_TYPE.xml' path='doc/member[@name="HTTP_LOGGING_ROLLOVER_TYPE.HttpLoggingRolloverWeekly"]/*' />
    HttpLoggingRolloverWeekly,

    /// <include file='HTTP_LOGGING_ROLLOVER_TYPE.xml' path='doc/member[@name="HTTP_LOGGING_ROLLOVER_TYPE.HttpLoggingRolloverMonthly"]/*' />
    HttpLoggingRolloverMonthly,

    /// <include file='HTTP_LOGGING_ROLLOVER_TYPE.xml' path='doc/member[@name="HTTP_LOGGING_ROLLOVER_TYPE.HttpLoggingRolloverHourly"]/*' />
    HttpLoggingRolloverHourly,
}
