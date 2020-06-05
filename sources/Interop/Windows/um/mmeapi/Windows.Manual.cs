// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int WAVERR_BADFORMAT = (WAVERR_BASE + 0);

        public const int WAVERR_STILLPLAYING = (WAVERR_BASE + 1);

        public const int WAVERR_UNPREPARED = (WAVERR_BASE + 2);

        public const int WAVERR_SYNC = (WAVERR_BASE + 3);

        public const int WAVERR_LASTERROR = (WAVERR_BASE + 3);

        public const int WOM_OPEN = MM_WOM_OPEN;

        public const int WOM_CLOSE = MM_WOM_CLOSE;

        public const int WOM_DONE = MM_WOM_DONE;

        public const int WIM_OPEN = MM_WIM_OPEN;

        public const int WIM_CLOSE = MM_WIM_CLOSE;

        public const int WIM_DATA = MM_WIM_DATA;

        public const uint WAVE_MAPPER = unchecked((uint)(-1));

        public const int WAVE_FORMAT_QUERY = 0x0001;

        public const int WAVE_ALLOWSYNC = 0x0002;

        public const int WAVE_MAPPED = 0x0004;

        public const int WAVE_FORMAT_DIRECT = 0x0008;

        public const int WAVE_FORMAT_DIRECT_QUERY = (WAVE_FORMAT_QUERY | WAVE_FORMAT_DIRECT);

        public const int WAVE_MAPPED_DEFAULT_COMMUNICATION_DEVICE = 0x0010;

        public const int WHDR_DONE = 0x00000001;

        public const int WHDR_PREPARED = 0x00000002;

        public const int WHDR_BEGINLOOP = 0x00000004;

        public const int WHDR_ENDLOOP = 0x00000008;

        public const int WHDR_INQUEUE = 0x00000010;

        public const int WAVECAPS_PITCH = 0x0001;

        public const int WAVECAPS_PLAYBACKRATE = 0x0002;

        public const int WAVECAPS_VOLUME = 0x0004;

        public const int WAVECAPS_LRVOLUME = 0x0008;

        public const int WAVECAPS_SYNC = 0x0010;

        public const int WAVECAPS_SAMPLEACCURATE = 0x0020;

        public const int WAVE_INVALIDFORMAT = 0x00000000;

        public const int WAVE_FORMAT_1M08 = 0x00000001 ;
                                                       
        public const int WAVE_FORMAT_1S08 = 0x00000002 ;
                                                       
        public const int WAVE_FORMAT_1M16 = 0x00000004 ;
                                                       
        public const int WAVE_FORMAT_1S16 = 0x00000008 ;
                                                       
        public const int WAVE_FORMAT_2M08 = 0x00000010 ;
                                                       
        public const int WAVE_FORMAT_2S08 = 0x00000020 ;
                                                       
        public const int WAVE_FORMAT_2M16 = 0x00000040 ;
                                                       
        public const int WAVE_FORMAT_2S16 = 0x00000080 ;
                                                       
        public const int WAVE_FORMAT_4M08 = 0x00000100 ;
                                                       
        public const int WAVE_FORMAT_4S08 = 0x00000200 ;
                                                       
        public const int WAVE_FORMAT_4M16 = 0x00000400 ;
                                                       
        public const int WAVE_FORMAT_4S16 = 0x00000800 ;
                                                       
        public const int WAVE_FORMAT_44M08 = 0x00000100;
                                                       
        public const int WAVE_FORMAT_44S08 = 0x00000200;
                                                       
        public const int WAVE_FORMAT_44M16 = 0x00000400;
                                                       
        public const int WAVE_FORMAT_44S16 = 0x00000800;
                                                       
        public const int WAVE_FORMAT_48M08 = 0x00001000;
                                                       
        public const int WAVE_FORMAT_48S08 = 0x00002000;
                                                       
        public const int WAVE_FORMAT_48M16 = 0x00004000;
                                                       
        public const int WAVE_FORMAT_48S16 = 0x00008000;
                                                       
        public const int WAVE_FORMAT_96M08 = 0x00010000;
                                                       
        public const int WAVE_FORMAT_96S08 = 0x00020000;
                                                       
        public const int WAVE_FORMAT_96M16 = 0x00040000;

        public const int WAVE_FORMAT_96S16 = 0x00080000;

        public const int MIDIERR_UNPREPARED = (MIDIERR_BASE + 0);

        public const int MIDIERR_STILLPLAYING = (MIDIERR_BASE + 1);

        public const int MIDIERR_NOMAP = (MIDIERR_BASE + 2);

        public const int MIDIERR_NOTREADY = (MIDIERR_BASE + 3);

        public const int MIDIERR_NODEVICE = (MIDIERR_BASE + 4);

        public const int MIDIERR_INVALIDSETUP = (MIDIERR_BASE + 5);

        public const int MIDIERR_BADOPENMODE = (MIDIERR_BASE + 6);

        public const int MIDIERR_DONT_CONTINUE = (MIDIERR_BASE + 7);

        public const int MIDIERR_LASTERROR = (MIDIERR_BASE + 7);

        public const int MIDIPATCHSIZE = 128;

        public const int MIM_OPEN = MM_MIM_OPEN;

        public const int MIM_CLOSE = MM_MIM_CLOSE;

        public const int MIM_DATA = MM_MIM_DATA;

        public const int MIM_LONGDATA = MM_MIM_LONGDATA;

        public const int MIM_ERROR = MM_MIM_ERROR;

        public const int MIM_LONGERROR = MM_MIM_LONGERROR;

        public const int MOM_OPEN = MM_MOM_OPEN;

        public const int MOM_CLOSE = MM_MOM_CLOSE;

        public const int MOM_DONE = MM_MOM_DONE;

        public const int MIM_MOREDATA = MM_MIM_MOREDATA;

        public const int MOM_POSITIONCB = MM_MOM_POSITIONCB;

        public const uint MIDIMAPPER = unchecked((uint)(-1));

        public const uint MIDI_MAPPER = unchecked((uint)(-1));

        public const int MIDI_IO_STATUS = 0x00000020;

        public const int MIDI_CACHE_ALL = 1;

        public const int MIDI_CACHE_BESTFIT = 2;

        public const int MIDI_CACHE_QUERY = 3;

        public const int MIDI_UNCACHE = 4;

        public const int MOD_MIDIPORT = 1;

        public const int MOD_SYNTH = 2;

        public const int MOD_SQSYNTH = 3;

        public const int MOD_FMSYNTH = 4;

        public const int MOD_MAPPER = 5;

        public const int MOD_WAVETABLE = 6;

        public const int MOD_SWSYNTH = 7;

        public const int MIDICAPS_VOLUME = 0x0001;

        public const int MIDICAPS_LRVOLUME = 0x0002;

        public const int MIDICAPS_CACHE = 0x0004;

        public const int MIDICAPS_STREAM = 0x0008;

        public const int MHDR_DONE = 0x00000001;

        public const int MHDR_PREPARED = 0x00000002;

        public const int MHDR_INQUEUE = 0x00000004;

        public const int MHDR_ISSTRM = 0x00000008;

        public const int MEVT_F_SHORT = 0x00000000;

        public const int MEVT_F_LONG = unchecked((int)0x80000000);

        public const int MEVT_F_CALLBACK = 0x40000000;

        public static byte MEVT_EVENTTYPE(uint x) => ((byte)(((x) >> 24) & 0xFF));

        public static uint MEVT_EVENTPARM(byte x) => ((uint)((x) & 0x00FFFFFFL));

        public const byte MEVT_SHORTMSG = ((byte)0x00);

        public const byte MEVT_TEMPO = ((byte)0x01);

        public const byte MEVT_NOP = ((byte)0x02);

        public const byte MEVT_LONGMSG = ((byte)0x80);

        public const byte MEVT_COMMENT = ((byte)0x82);

        public const byte MEVT_VERSION = ((byte)0x84);

        public const int MIDISTRM_ERROR = (-2);

        public const int MIDIPROP_SET = unchecked((int)0x80000000);

        public const int MIDIPROP_GET = 0x40000000;

        public const int MIDIPROP_TIMEDIV = 0x00000001;

        public const int MIDIPROP_TEMPO = 0x00000002;

        public const uint AUX_MAPPER = unchecked((uint)(-1));

        public const int AUXCAPS_CDAUDIO = 1;

        public const int AUXCAPS_AUXIN = 2;

        public const int AUXCAPS_VOLUME = 0x0001;

        public const int AUXCAPS_LRVOLUME = 0x0002;

        public const int MIXER_SHORT_NAME_CHARS = 16;

        public const int MIXER_LONG_NAME_CHARS = 64;

        public const int MIXERR_INVALLINE = (MIXERR_BASE + 0);

        public const int MIXERR_INVALCONTROL = (MIXERR_BASE + 1);

        public const int MIXERR_INVALVALUE = (MIXERR_BASE + 2);

        public const int MIXERR_LASTERROR = (MIXERR_BASE + 2);

        public const int MIXER_OBJECTF_HANDLE = unchecked((int)0x80000000);

        public const int MIXER_OBJECTF_MIXER = 0x00000000;

        public const int MIXER_OBJECTF_HMIXER = (MIXER_OBJECTF_HANDLE | MIXER_OBJECTF_MIXER);

        public const int MIXER_OBJECTF_WAVEOUT = 0x10000000;

        public const int MIXER_OBJECTF_HWAVEOUT = (MIXER_OBJECTF_HANDLE | MIXER_OBJECTF_WAVEOUT);

        public const int MIXER_OBJECTF_WAVEIN = 0x20000000;

        public const int MIXER_OBJECTF_HWAVEIN = (MIXER_OBJECTF_HANDLE | MIXER_OBJECTF_WAVEIN);

        public const int MIXER_OBJECTF_MIDIOUT = 0x30000000;

        public const int MIXER_OBJECTF_HMIDIOUT = (MIXER_OBJECTF_HANDLE | MIXER_OBJECTF_MIDIOUT);

        public const int MIXER_OBJECTF_MIDIIN = 0x40000000;

        public const int MIXER_OBJECTF_HMIDIIN = (MIXER_OBJECTF_HANDLE | MIXER_OBJECTF_MIDIIN);

        public const int MIXER_OBJECTF_AUX = 0x50000000;

        public const int MIXERLINE_LINEF_ACTIVE = 0x00000001;

        public const int MIXERLINE_LINEF_DISCONNECTED = 0x00008000;

        public const int MIXERLINE_LINEF_SOURCE = unchecked((int)0x80000000);

        public const int MIXERLINE_COMPONENTTYPE_DST_FIRST = 0x00000000;

        public const int MIXERLINE_COMPONENTTYPE_DST_UNDEFINED = (MIXERLINE_COMPONENTTYPE_DST_FIRST + 0);

        public const int MIXERLINE_COMPONENTTYPE_DST_DIGITAL = (MIXERLINE_COMPONENTTYPE_DST_FIRST + 1);

        public const int MIXERLINE_COMPONENTTYPE_DST_LINE = (MIXERLINE_COMPONENTTYPE_DST_FIRST + 2);

        public const int MIXERLINE_COMPONENTTYPE_DST_MONITOR = (MIXERLINE_COMPONENTTYPE_DST_FIRST + 3);

        public const int MIXERLINE_COMPONENTTYPE_DST_SPEAKERS = (MIXERLINE_COMPONENTTYPE_DST_FIRST + 4);

        public const int MIXERLINE_COMPONENTTYPE_DST_HEADPHONES = (MIXERLINE_COMPONENTTYPE_DST_FIRST + 5);

        public const int MIXERLINE_COMPONENTTYPE_DST_TELEPHONE = (MIXERLINE_COMPONENTTYPE_DST_FIRST + 6);

        public const int MIXERLINE_COMPONENTTYPE_DST_WAVEIN = (MIXERLINE_COMPONENTTYPE_DST_FIRST + 7);

        public const int MIXERLINE_COMPONENTTYPE_DST_VOICEIN = (MIXERLINE_COMPONENTTYPE_DST_FIRST + 8);

        public const int MIXERLINE_COMPONENTTYPE_DST_LAST = (MIXERLINE_COMPONENTTYPE_DST_FIRST + 8);

        public const int MIXERLINE_COMPONENTTYPE_SRC_FIRST = 0x00001000;

        public const int MIXERLINE_COMPONENTTYPE_SRC_UNDEFINED = (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 0);

        public const int MIXERLINE_COMPONENTTYPE_SRC_DIGITAL = (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 1);

        public const int MIXERLINE_COMPONENTTYPE_SRC_LINE = (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 2);

        public const int MIXERLINE_COMPONENTTYPE_SRC_MICROPHONE = (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 3);

        public const int MIXERLINE_COMPONENTTYPE_SRC_SYNTHESIZER = (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 4);

        public const int MIXERLINE_COMPONENTTYPE_SRC_COMPACTDISC = (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 5);

        public const int MIXERLINE_COMPONENTTYPE_SRC_TELEPHONE = (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 6);

        public const int MIXERLINE_COMPONENTTYPE_SRC_PCSPEAKER = (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 7);

        public const int MIXERLINE_COMPONENTTYPE_SRC_WAVEOUT = (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 8);

        public const int MIXERLINE_COMPONENTTYPE_SRC_AUXILIARY = (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 9);

        public const int MIXERLINE_COMPONENTTYPE_SRC_ANALOG = (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 10);

        public const int MIXERLINE_COMPONENTTYPE_SRC_LAST = (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 10);

        public const int MIXERLINE_TARGETTYPE_UNDEFINED = 0;

        public const int MIXERLINE_TARGETTYPE_WAVEOUT = 1;

        public const int MIXERLINE_TARGETTYPE_WAVEIN = 2;

        public const int MIXERLINE_TARGETTYPE_MIDIOUT = 3;

        public const int MIXERLINE_TARGETTYPE_MIDIIN = 4;

        public const int MIXERLINE_TARGETTYPE_AUX = 5;

        public const int MIXER_GETLINEINFOF_DESTINATION = 0x00000000;

        public const int MIXER_GETLINEINFOF_SOURCE = 0x00000001;

        public const int MIXER_GETLINEINFOF_LINEID = 0x00000002;

        public const int MIXER_GETLINEINFOF_COMPONENTTYPE = 0x00000003;

        public const int MIXER_GETLINEINFOF_TARGETTYPE = 0x00000004;

        public const int MIXER_GETLINEINFOF_QUERYMASK = 0x0000000F;

        public const int MIXERCONTROL_CONTROLF_UNIFORM = 0x00000001;

        public const int MIXERCONTROL_CONTROLF_MULTIPLE = 0x00000002;

        public const int MIXERCONTROL_CONTROLF_DISABLED = unchecked((int)0x80000000);

        public const int MIXERCONTROL_CT_CLASS_MASK = unchecked((int)0xF0000000);

        public const int MIXERCONTROL_CT_CLASS_CUSTOM = 0x00000000;

        public const int MIXERCONTROL_CT_CLASS_METER = 0x10000000;

        public const int MIXERCONTROL_CT_CLASS_SWITCH = 0x20000000;

        public const int MIXERCONTROL_CT_CLASS_NUMBER = 0x30000000;

        public const int MIXERCONTROL_CT_CLASS_SLIDER = 0x40000000;

        public const int MIXERCONTROL_CT_CLASS_FADER = 0x50000000;

        public const int MIXERCONTROL_CT_CLASS_TIME = 0x60000000;

        public const int MIXERCONTROL_CT_CLASS_LIST = 0x70000000;

        public const int MIXERCONTROL_CT_SUBCLASS_MASK = 0x0F000000;

        public const int MIXERCONTROL_CT_SC_SWITCH_BOOLEAN = 0x00000000;

        public const int MIXERCONTROL_CT_SC_SWITCH_BUTTON = 0x01000000;

        public const int MIXERCONTROL_CT_SC_METER_POLLED = 0x00000000;

        public const int MIXERCONTROL_CT_SC_TIME_MICROSECS = 0x00000000;

        public const int MIXERCONTROL_CT_SC_TIME_MILLISECS = 0x01000000;

        public const int MIXERCONTROL_CT_SC_LIST_SINGLE = 0x00000000;

        public const int MIXERCONTROL_CT_SC_LIST_MULTIPLE = 0x01000000;

        public const int MIXERCONTROL_CT_UNITS_MASK = 0x00FF0000;

        public const int MIXERCONTROL_CT_UNITS_CUSTOM = 0x00000000;

        public const int MIXERCONTROL_CT_UNITS_BOOLEAN = 0x00010000;

        public const int MIXERCONTROL_CT_UNITS_SIGNED = 0x00020000;

        public const int MIXERCONTROL_CT_UNITS_UNSIGNED = 0x00030000;

        public const int MIXERCONTROL_CT_UNITS_DECIBELS = 0x00040000;

        public const int MIXERCONTROL_CT_UNITS_PERCENT = 0x00050000;

        public const int MIXERCONTROL_CONTROLTYPE_CUSTOM = (MIXERCONTROL_CT_CLASS_CUSTOM | MIXERCONTROL_CT_UNITS_CUSTOM);

        public const int MIXERCONTROL_CONTROLTYPE_BOOLEANMETER = (MIXERCONTROL_CT_CLASS_METER | MIXERCONTROL_CT_SC_METER_POLLED | MIXERCONTROL_CT_UNITS_BOOLEAN);

        public const int MIXERCONTROL_CONTROLTYPE_SIGNEDMETER = (MIXERCONTROL_CT_CLASS_METER | MIXERCONTROL_CT_SC_METER_POLLED | MIXERCONTROL_CT_UNITS_SIGNED);

        public const int MIXERCONTROL_CONTROLTYPE_PEAKMETER = (MIXERCONTROL_CONTROLTYPE_SIGNEDMETER + 1);

        public const int MIXERCONTROL_CONTROLTYPE_UNSIGNEDMETER = (MIXERCONTROL_CT_CLASS_METER | MIXERCONTROL_CT_SC_METER_POLLED | MIXERCONTROL_CT_UNITS_UNSIGNED);

        public const int MIXERCONTROL_CONTROLTYPE_BOOLEAN = (MIXERCONTROL_CT_CLASS_SWITCH | MIXERCONTROL_CT_SC_SWITCH_BOOLEAN | MIXERCONTROL_CT_UNITS_BOOLEAN);

        public const int MIXERCONTROL_CONTROLTYPE_ONOFF = (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 1);

        public const int MIXERCONTROL_CONTROLTYPE_MUTE = (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 2);

        public const int MIXERCONTROL_CONTROLTYPE_MONO = (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 3);

        public const int MIXERCONTROL_CONTROLTYPE_LOUDNESS = (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 4);

        public const int MIXERCONTROL_CONTROLTYPE_STEREOENH = (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 5);

        public const int MIXERCONTROL_CONTROLTYPE_BASS_BOOST = (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 0x00002277);

        public const int MIXERCONTROL_CONTROLTYPE_BUTTON = (MIXERCONTROL_CT_CLASS_SWITCH | MIXERCONTROL_CT_SC_SWITCH_BUTTON | MIXERCONTROL_CT_UNITS_BOOLEAN);

        public const int MIXERCONTROL_CONTROLTYPE_DECIBELS = (MIXERCONTROL_CT_CLASS_NUMBER | MIXERCONTROL_CT_UNITS_DECIBELS);

        public const int MIXERCONTROL_CONTROLTYPE_SIGNED = (MIXERCONTROL_CT_CLASS_NUMBER | MIXERCONTROL_CT_UNITS_SIGNED);

        public const int MIXERCONTROL_CONTROLTYPE_UNSIGNED = (MIXERCONTROL_CT_CLASS_NUMBER | MIXERCONTROL_CT_UNITS_UNSIGNED);

        public const int MIXERCONTROL_CONTROLTYPE_PERCENT = (MIXERCONTROL_CT_CLASS_NUMBER | MIXERCONTROL_CT_UNITS_PERCENT);

        public const int MIXERCONTROL_CONTROLTYPE_SLIDER = (MIXERCONTROL_CT_CLASS_SLIDER | MIXERCONTROL_CT_UNITS_SIGNED);

        public const int MIXERCONTROL_CONTROLTYPE_PAN = (MIXERCONTROL_CONTROLTYPE_SLIDER + 1);

        public const int MIXERCONTROL_CONTROLTYPE_QSOUNDPAN = (MIXERCONTROL_CONTROLTYPE_SLIDER + 2);

        public const int MIXERCONTROL_CONTROLTYPE_FADER = (MIXERCONTROL_CT_CLASS_FADER | MIXERCONTROL_CT_UNITS_UNSIGNED);

        public const int MIXERCONTROL_CONTROLTYPE_VOLUME = (MIXERCONTROL_CONTROLTYPE_FADER + 1);

        public const int MIXERCONTROL_CONTROLTYPE_BASS = (MIXERCONTROL_CONTROLTYPE_FADER + 2);

        public const int MIXERCONTROL_CONTROLTYPE_TREBLE = (MIXERCONTROL_CONTROLTYPE_FADER + 3);

        public const int MIXERCONTROL_CONTROLTYPE_EQUALIZER = (MIXERCONTROL_CONTROLTYPE_FADER + 4);

        public const int MIXERCONTROL_CONTROLTYPE_SINGLESELECT = (MIXERCONTROL_CT_CLASS_LIST | MIXERCONTROL_CT_SC_LIST_SINGLE | MIXERCONTROL_CT_UNITS_BOOLEAN);

        public const int MIXERCONTROL_CONTROLTYPE_MUX = (MIXERCONTROL_CONTROLTYPE_SINGLESELECT + 1);

        public const int MIXERCONTROL_CONTROLTYPE_MULTIPLESELECT = (MIXERCONTROL_CT_CLASS_LIST | MIXERCONTROL_CT_SC_LIST_MULTIPLE | MIXERCONTROL_CT_UNITS_BOOLEAN);

        public const int MIXERCONTROL_CONTROLTYPE_MIXER = (MIXERCONTROL_CONTROLTYPE_MULTIPLESELECT + 1);

        public const int MIXERCONTROL_CONTROLTYPE_MICROTIME = (MIXERCONTROL_CT_CLASS_TIME | MIXERCONTROL_CT_SC_TIME_MICROSECS | MIXERCONTROL_CT_UNITS_UNSIGNED);

        public const int MIXERCONTROL_CONTROLTYPE_MILLITIME = (MIXERCONTROL_CT_CLASS_TIME | MIXERCONTROL_CT_SC_TIME_MILLISECS | MIXERCONTROL_CT_UNITS_UNSIGNED);

        public const int MIXER_GETLINECONTROLSF_ALL = 0x00000000;

        public const int MIXER_GETLINECONTROLSF_ONEBYID = 0x00000001;

        public const int MIXER_GETLINECONTROLSF_ONEBYTYPE = 0x00000002;

        public const int MIXER_GETLINECONTROLSF_QUERYMASK = 0x0000000F;

        public const int MIXER_GETCONTROLDETAILSF_VALUE = 0x00000000;

        public const int MIXER_GETCONTROLDETAILSF_LISTTEXT = 0x00000001;

        public const int MIXER_GETCONTROLDETAILSF_QUERYMASK = 0x0000000F;

        public const int MIXER_SETCONTROLDETAILSF_VALUE = 0x00000000;

        public const int MIXER_SETCONTROLDETAILSF_CUSTOM = 0x00000001;

        public const int MIXER_SETCONTROLDETAILSF_QUERYMASK = 0x0000000F;
    }
}
