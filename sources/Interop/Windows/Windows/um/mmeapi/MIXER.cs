// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MIXER
{
    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_SHORT_NAME_CHARS"]/*' />
    [NativeTypeName("#define MIXER_SHORT_NAME_CHARS 16")]
    public const int MIXER_SHORT_NAME_CHARS = 16;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_LONG_NAME_CHARS"]/*' />
    [NativeTypeName("#define MIXER_LONG_NAME_CHARS 64")]
    public const int MIXER_LONG_NAME_CHARS = 64;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_OBJECTF_HANDLE"]/*' />
    [NativeTypeName("#define MIXER_OBJECTF_HANDLE 0x80000000L")]
    public const uint MIXER_OBJECTF_HANDLE = 0x80000000;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_OBJECTF_MIXER"]/*' />
    [NativeTypeName("#define MIXER_OBJECTF_MIXER 0x00000000L")]
    public const int MIXER_OBJECTF_MIXER = 0x00000000;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_OBJECTF_HMIXER"]/*' />
    [NativeTypeName("#define MIXER_OBJECTF_HMIXER (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_MIXER)")]
    public const uint MIXER_OBJECTF_HMIXER = (0x80000000 | 0x00000000);

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_OBJECTF_WAVEOUT"]/*' />
    [NativeTypeName("#define MIXER_OBJECTF_WAVEOUT 0x10000000L")]
    public const int MIXER_OBJECTF_WAVEOUT = 0x10000000;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_OBJECTF_HWAVEOUT"]/*' />
    [NativeTypeName("#define MIXER_OBJECTF_HWAVEOUT (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_WAVEOUT)")]
    public const uint MIXER_OBJECTF_HWAVEOUT = (0x80000000 | 0x10000000);

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_OBJECTF_WAVEIN"]/*' />
    [NativeTypeName("#define MIXER_OBJECTF_WAVEIN 0x20000000L")]
    public const int MIXER_OBJECTF_WAVEIN = 0x20000000;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_OBJECTF_HWAVEIN"]/*' />
    [NativeTypeName("#define MIXER_OBJECTF_HWAVEIN (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_WAVEIN)")]
    public const uint MIXER_OBJECTF_HWAVEIN = (0x80000000 | 0x20000000);

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_OBJECTF_MIDIOUT"]/*' />
    [NativeTypeName("#define MIXER_OBJECTF_MIDIOUT 0x30000000L")]
    public const int MIXER_OBJECTF_MIDIOUT = 0x30000000;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_OBJECTF_HMIDIOUT"]/*' />
    [NativeTypeName("#define MIXER_OBJECTF_HMIDIOUT (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_MIDIOUT)")]
    public const uint MIXER_OBJECTF_HMIDIOUT = (0x80000000 | 0x30000000);

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_OBJECTF_MIDIIN"]/*' />
    [NativeTypeName("#define MIXER_OBJECTF_MIDIIN 0x40000000L")]
    public const int MIXER_OBJECTF_MIDIIN = 0x40000000;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_OBJECTF_HMIDIIN"]/*' />
    [NativeTypeName("#define MIXER_OBJECTF_HMIDIIN (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_MIDIIN)")]
    public const uint MIXER_OBJECTF_HMIDIIN = (0x80000000 | 0x40000000);

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_OBJECTF_AUX"]/*' />
    [NativeTypeName("#define MIXER_OBJECTF_AUX 0x50000000L")]
    public const int MIXER_OBJECTF_AUX = 0x50000000;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_GETLINEINFOF_DESTINATION"]/*' />
    [NativeTypeName("#define MIXER_GETLINEINFOF_DESTINATION 0x00000000L")]
    public const int MIXER_GETLINEINFOF_DESTINATION = 0x00000000;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_GETLINEINFOF_SOURCE"]/*' />
    [NativeTypeName("#define MIXER_GETLINEINFOF_SOURCE 0x00000001L")]
    public const int MIXER_GETLINEINFOF_SOURCE = 0x00000001;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_GETLINEINFOF_LINEID"]/*' />
    [NativeTypeName("#define MIXER_GETLINEINFOF_LINEID 0x00000002L")]
    public const int MIXER_GETLINEINFOF_LINEID = 0x00000002;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_GETLINEINFOF_COMPONENTTYPE"]/*' />
    [NativeTypeName("#define MIXER_GETLINEINFOF_COMPONENTTYPE 0x00000003L")]
    public const int MIXER_GETLINEINFOF_COMPONENTTYPE = 0x00000003;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_GETLINEINFOF_TARGETTYPE"]/*' />
    [NativeTypeName("#define MIXER_GETLINEINFOF_TARGETTYPE 0x00000004L")]
    public const int MIXER_GETLINEINFOF_TARGETTYPE = 0x00000004;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_GETLINEINFOF_QUERYMASK"]/*' />
    [NativeTypeName("#define MIXER_GETLINEINFOF_QUERYMASK 0x0000000FL")]
    public const int MIXER_GETLINEINFOF_QUERYMASK = 0x0000000F;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_GETLINECONTROLSF_ALL"]/*' />
    [NativeTypeName("#define MIXER_GETLINECONTROLSF_ALL 0x00000000L")]
    public const int MIXER_GETLINECONTROLSF_ALL = 0x00000000;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_GETLINECONTROLSF_ONEBYID"]/*' />
    [NativeTypeName("#define MIXER_GETLINECONTROLSF_ONEBYID 0x00000001L")]
    public const int MIXER_GETLINECONTROLSF_ONEBYID = 0x00000001;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_GETLINECONTROLSF_ONEBYTYPE"]/*' />
    [NativeTypeName("#define MIXER_GETLINECONTROLSF_ONEBYTYPE 0x00000002L")]
    public const int MIXER_GETLINECONTROLSF_ONEBYTYPE = 0x00000002;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_GETLINECONTROLSF_QUERYMASK"]/*' />
    [NativeTypeName("#define MIXER_GETLINECONTROLSF_QUERYMASK 0x0000000FL")]
    public const int MIXER_GETLINECONTROLSF_QUERYMASK = 0x0000000F;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_GETCONTROLDETAILSF_VALUE"]/*' />
    [NativeTypeName("#define MIXER_GETCONTROLDETAILSF_VALUE 0x00000000L")]
    public const int MIXER_GETCONTROLDETAILSF_VALUE = 0x00000000;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_GETCONTROLDETAILSF_LISTTEXT"]/*' />
    [NativeTypeName("#define MIXER_GETCONTROLDETAILSF_LISTTEXT 0x00000001L")]
    public const int MIXER_GETCONTROLDETAILSF_LISTTEXT = 0x00000001;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_GETCONTROLDETAILSF_QUERYMASK"]/*' />
    [NativeTypeName("#define MIXER_GETCONTROLDETAILSF_QUERYMASK 0x0000000FL")]
    public const int MIXER_GETCONTROLDETAILSF_QUERYMASK = 0x0000000F;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_SETCONTROLDETAILSF_VALUE"]/*' />
    [NativeTypeName("#define MIXER_SETCONTROLDETAILSF_VALUE 0x00000000L")]
    public const int MIXER_SETCONTROLDETAILSF_VALUE = 0x00000000;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_SETCONTROLDETAILSF_CUSTOM"]/*' />
    [NativeTypeName("#define MIXER_SETCONTROLDETAILSF_CUSTOM 0x00000001L")]
    public const int MIXER_SETCONTROLDETAILSF_CUSTOM = 0x00000001;

    /// <include file='MIXER.xml' path='doc/member[@name="MIXER.MIXER_SETCONTROLDETAILSF_QUERYMASK"]/*' />
    [NativeTypeName("#define MIXER_SETCONTROLDETAILSF_QUERYMASK 0x0000000FL")]
    public const int MIXER_SETCONTROLDETAILSF_QUERYMASK = 0x0000000F;
}
