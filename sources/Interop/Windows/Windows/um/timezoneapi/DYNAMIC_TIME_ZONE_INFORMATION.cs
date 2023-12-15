// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/timezoneapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION"]/*' />
public partial struct DYNAMIC_TIME_ZONE_INFORMATION
{
    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.Bias"]/*' />
    [NativeTypeName("LONG")]
    public int Bias;

    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.StandardName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _StandardName_e__FixedBuffer StandardName;

    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.StandardDate"]/*' />
    public SYSTEMTIME StandardDate;

    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.StandardBias"]/*' />
    [NativeTypeName("LONG")]
    public int StandardBias;

    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.DaylightName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _DaylightName_e__FixedBuffer DaylightName;

    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.DaylightDate"]/*' />
    public SYSTEMTIME DaylightDate;

    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.DaylightBias"]/*' />
    [NativeTypeName("LONG")]
    public int DaylightBias;

    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.TimeZoneKeyName"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _TimeZoneKeyName_e__FixedBuffer TimeZoneKeyName;

    /// <include file='DYNAMIC_TIME_ZONE_INFORMATION.xml' path='doc/member[@name="DYNAMIC_TIME_ZONE_INFORMATION.DynamicDaylightTimeDisabled"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte DynamicDaylightTimeDisabled;

    /// <include file='_StandardName_e__FixedBuffer.xml' path='doc/member[@name="_StandardName_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _StandardName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_DaylightName_e__FixedBuffer.xml' path='doc/member[@name="_DaylightName_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _DaylightName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_TimeZoneKeyName_e__FixedBuffer.xml' path='doc/member[@name="_TimeZoneKeyName_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _TimeZoneKeyName_e__FixedBuffer
    {
        public char e0;
    }
}
