// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.SPEVENTENUM;
using static TerraFX.Interop.SPPHRASERNG;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const float")]
        public const float Speech_Default_Weight = (1);

        [NativeTypeName("const LONG")]
        public const int Speech_Max_Word_Length = (128);

        [NativeTypeName("const LONG")]
        public const int Speech_Max_Pron_Length = (384);

        [NativeTypeName("const LONG")]
        public const int Speech_StreamPos_Asap = (0);

        [NativeTypeName("const LONG")]
        public const int Speech_StreamPos_RealTime = (-1);

        [NativeTypeName("const LONG")]
        public const int SpeechAllElements = (int)(SPPR_ALL_ELEMENTS);

        [NativeTypeName("#define _SAPI_VER 0x054")]
        public const int _SAPI_VER = 0x054;

        [NativeTypeName("#define SPDUI_EngineProperties L\"EngineProperties\"")]
        public const string SPDUI_EngineProperties = "EngineProperties";

        [NativeTypeName("#define SPDUI_AddRemoveWord L\"AddRemoveWord\"")]
        public const string SPDUI_AddRemoveWord = "AddRemoveWord";

        [NativeTypeName("#define SPDUI_UserTraining L\"UserTraining\"")]
        public const string SPDUI_UserTraining = "UserTraining";

        [NativeTypeName("#define SPDUI_MicTraining L\"MicTraining\"")]
        public const string SPDUI_MicTraining = "MicTraining";

        [NativeTypeName("#define SPDUI_RecoProfileProperties L\"RecoProfileProperties\"")]
        public const string SPDUI_RecoProfileProperties = "RecoProfileProperties";

        [NativeTypeName("#define SPDUI_AudioProperties L\"AudioProperties\"")]
        public const string SPDUI_AudioProperties = "AudioProperties";

        [NativeTypeName("#define SPDUI_AudioVolume L\"AudioVolume\"")]
        public const string SPDUI_AudioVolume = "AudioVolume";

        [NativeTypeName("#define SPDUI_UserEnrollment L\"UserEnrollment\"")]
        public const string SPDUI_UserEnrollment = "UserEnrollment";

        [NativeTypeName("#define SPDUI_ShareData L\"ShareData\"")]
        public const string SPDUI_ShareData = "ShareData";

        [NativeTypeName("#define SPDUI_Tutorial L\"Tutorial\"")]
        public const string SPDUI_Tutorial = "Tutorial";

        [NativeTypeName("#define SPREG_USER_ROOT L\"HKEY_CURRENT_USER\\\\SOFTWARE\\\\Microsoft\\\\Speech\"")]
        public const string SPREG_USER_ROOT = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech";

        [NativeTypeName("#define SPREG_LOCAL_MACHINE_ROOT L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\"")]
        public const string SPREG_LOCAL_MACHINE_ROOT = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech";

        [NativeTypeName("#define SPCAT_AUDIOOUT L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\AudioOutput\"")]
        public const string SPCAT_AUDIOOUT = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioOutput";

        [NativeTypeName("#define SPCAT_AUDIOIN L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\AudioInput\"")]
        public const string SPCAT_AUDIOIN = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioInput";

        [NativeTypeName("#define SPCAT_VOICES L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\Voices\"")]
        public const string SPCAT_VOICES = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\Voices";

        [NativeTypeName("#define SPCAT_RECOGNIZERS L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\Recognizers\"")]
        public const string SPCAT_RECOGNIZERS = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\Recognizers";

        [NativeTypeName("#define SPCAT_APPLEXICONS L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\AppLexicons\"")]
        public const string SPCAT_APPLEXICONS = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AppLexicons";

        [NativeTypeName("#define SPCAT_PHONECONVERTERS L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\PhoneConverters\"")]
        public const string SPCAT_PHONECONVERTERS = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\PhoneConverters";

        [NativeTypeName("#define SPCAT_TEXTNORMALIZERS L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\TextNormalizers\"")]
        public const string SPCAT_TEXTNORMALIZERS = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\TextNormalizers";

        [NativeTypeName("#define SPCAT_RECOPROFILES L\"HKEY_CURRENT_USER\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\RecoProfiles\"")]
        public const string SPCAT_RECOPROFILES = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech\\RecoProfiles";

        [NativeTypeName("#define SPMMSYS_AUDIO_IN_TOKEN_ID L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\AudioInput\\\\TokenEnums\\\\MMAudioIn\\\\\"")]
        public const string SPMMSYS_AUDIO_IN_TOKEN_ID = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioInput\\TokenEnums\\MMAudioIn\\";

        [NativeTypeName("#define SPMMSYS_AUDIO_OUT_TOKEN_ID L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\AudioOutput\\\\TokenEnums\\\\MMAudioOut\\\\\"")]
        public const string SPMMSYS_AUDIO_OUT_TOKEN_ID = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioOutput\\TokenEnums\\MMAudioOut\\";

        [NativeTypeName("#define SPCURRENT_USER_LEXICON_TOKEN_ID L\"HKEY_CURRENT_USER\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\CurrentUserLexicon\"")]
        public const string SPCURRENT_USER_LEXICON_TOKEN_ID = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech\\CurrentUserLexicon";

        [NativeTypeName("#define SPCURRENT_USER_SHORTCUT_TOKEN_ID L\"HKEY_CURRENT_USER\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\CurrentUserShortcut\"")]
        public const string SPCURRENT_USER_SHORTCUT_TOKEN_ID = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech\\CurrentUserShortcut";

        [NativeTypeName("#define SPTOKENVALUE_CLSID L\"CLSID\"")]
        public const string SPTOKENVALUE_CLSID = "CLSID";

        [NativeTypeName("#define SPTOKENKEY_FILES L\"Files\"")]
        public const string SPTOKENKEY_FILES = "Files";

        [NativeTypeName("#define SPTOKENKEY_UI L\"UI\"")]
        public const string SPTOKENKEY_UI = "UI";

        [NativeTypeName("#define SPTOKENKEY_ATTRIBUTES L\"Attributes\"")]
        public const string SPTOKENKEY_ATTRIBUTES = "Attributes";

        [NativeTypeName("#define SPTOKENKEY_RETAINEDAUDIO L\"SecondsPerRetainedAudioEvent\"")]
        public const string SPTOKENKEY_RETAINEDAUDIO = "SecondsPerRetainedAudioEvent";

        [NativeTypeName("#define SPTOKENKEY_AUDIO_LATENCY_WARNING L\"LatencyWarningThreshold\"")]
        public const string SPTOKENKEY_AUDIO_LATENCY_WARNING = "LatencyWarningThreshold";

        [NativeTypeName("#define SPTOKENKEY_AUDIO_LATENCY_TRUNCATE L\"LatencyTruncateThreshold\"")]
        public const string SPTOKENKEY_AUDIO_LATENCY_TRUNCATE = "LatencyTruncateThreshold";

        [NativeTypeName("#define SPTOKENKEY_AUDIO_LATENCY_UPDATE_INTERVAL L\"LatencyUpdateInterval\"")]
        public const string SPTOKENKEY_AUDIO_LATENCY_UPDATE_INTERVAL = "LatencyUpdateInterval";

        [NativeTypeName("#define SPVOICECATEGORY_TTSRATE L\"DefaultTTSRate\"")]
        public const string SPVOICECATEGORY_TTSRATE = "DefaultTTSRate";

        [NativeTypeName("#define SPPROP_RESOURCE_USAGE L\"ResourceUsage\"")]
        public const string SPPROP_RESOURCE_USAGE = "ResourceUsage";

        [NativeTypeName("#define SPPROP_HIGH_CONFIDENCE_THRESHOLD L\"HighConfidenceThreshold\"")]
        public const string SPPROP_HIGH_CONFIDENCE_THRESHOLD = "HighConfidenceThreshold";

        [NativeTypeName("#define SPPROP_NORMAL_CONFIDENCE_THRESHOLD L\"NormalConfidenceThreshold\"")]
        public const string SPPROP_NORMAL_CONFIDENCE_THRESHOLD = "NormalConfidenceThreshold";

        [NativeTypeName("#define SPPROP_LOW_CONFIDENCE_THRESHOLD L\"LowConfidenceThreshold\"")]
        public const string SPPROP_LOW_CONFIDENCE_THRESHOLD = "LowConfidenceThreshold";

        [NativeTypeName("#define SPPROP_RESPONSE_SPEED L\"ResponseSpeed\"")]
        public const string SPPROP_RESPONSE_SPEED = "ResponseSpeed";

        [NativeTypeName("#define SPPROP_COMPLEX_RESPONSE_SPEED L\"ComplexResponseSpeed\"")]
        public const string SPPROP_COMPLEX_RESPONSE_SPEED = "ComplexResponseSpeed";

        [NativeTypeName("#define SPPROP_ADAPTATION_ON L\"AdaptationOn\"")]
        public const string SPPROP_ADAPTATION_ON = "AdaptationOn";

        [NativeTypeName("#define SPPROP_PERSISTED_BACKGROUND_ADAPTATION L\"PersistedBackgroundAdaptation\"")]
        public const string SPPROP_PERSISTED_BACKGROUND_ADAPTATION = "PersistedBackgroundAdaptation";

        [NativeTypeName("#define SPPROP_PERSISTED_LANGUAGE_MODEL_ADAPTATION L\"PersistedLanguageModelAdaptation\"")]
        public const string SPPROP_PERSISTED_LANGUAGE_MODEL_ADAPTATION = "PersistedLanguageModelAdaptation";

        [NativeTypeName("#define SPPROP_UX_IS_LISTENING L\"UXIsListening\"")]
        public const string SPPROP_UX_IS_LISTENING = "UXIsListening";

        [NativeTypeName("#define SPTOPIC_SPELLING L\"Spelling\"")]
        public const string SPTOPIC_SPELLING = "Spelling";

        [NativeTypeName("#define SPWILDCARD L\"...\"")]
        public const string SPWILDCARD = "...";

        [NativeTypeName("#define SPDICTATION L\"*\"")]
        public const string SPDICTATION = "*";

        [NativeTypeName("#define SPINFDICTATION L\"*+\"")]
        public const string SPINFDICTATION = "*+";

        [NativeTypeName("#define SPREG_SAFE_USER_TOKENS L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\UserTokens\"")]
        public const string SPREG_SAFE_USER_TOKENS = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\UserTokens";

        [NativeTypeName("#define SP_LOW_CONFIDENCE ( -1 )")]
        public const int SP_LOW_CONFIDENCE = (-1);

        [NativeTypeName("#define SP_NORMAL_CONFIDENCE ( 0 )")]
        public const int SP_NORMAL_CONFIDENCE = (0);

        [NativeTypeName("#define SP_HIGH_CONFIDENCE ( +1 )")]
        public const int SP_HIGH_CONFIDENCE = (+1);

        [NativeTypeName("#define DEFAULT_WEIGHT ( 1 )")]
        public const int DEFAULT_WEIGHT = (1);

        [NativeTypeName("#define SP_MAX_WORD_LENGTH ( 128 )")]
        public const int SP_MAX_WORD_LENGTH = (128);

        [NativeTypeName("#define SP_MAX_PRON_LENGTH ( 384 )")]
        public const int SP_MAX_PRON_LENGTH = (384);

        [NativeTypeName("#define SP_EMULATE_RESULT ( 0x40000000 )")]
        public const int SP_EMULATE_RESULT = (0x40000000);

        [NativeTypeName("#define SPFEI_FLAGCHECK ( (1ui64 << SPEI_RESERVED1) | (1ui64 << SPEI_RESERVED2) )")]
        public const ulong SPFEI_FLAGCHECK = ((1UL << (int)(SPEI_RESERVED1)) | (1UL << (int)(SPEI_RESERVED2)));

        [NativeTypeName("#define SPFEI_ALL_TTS_EVENTS (0x000000000000FFFEui64 | SPFEI_FLAGCHECK)")]
        public const ulong SPFEI_ALL_TTS_EVENTS = (0x000000000000FFFEUL | ((1UL << (int)(SPEI_RESERVED1)) | (1UL << (int)(SPEI_RESERVED2))));

        [NativeTypeName("#define SPFEI_ALL_SR_EVENTS (0x003FFFFC00000000ui64 | SPFEI_FLAGCHECK)")]
        public const ulong SPFEI_ALL_SR_EVENTS = (0x003FFFFC00000000UL | ((1UL << (int)(SPEI_RESERVED1)) | (1UL << (int)(SPEI_RESERVED2))));

        [NativeTypeName("#define SPFEI_ALL_EVENTS 0xEFFFFFFFFFFFFFFFui64")]
        public const ulong SPFEI_ALL_EVENTS = 0xEFFFFFFFFFFFFFFFUL;

        [NativeTypeName("#define SP_SPPHRASESIZE_500 sizeof(SPPHRASE_50)")]
        public static readonly uint SP_SPPHRASESIZE_500 = unchecked((uint)(sizeof(SPPHRASE_50)));

        [NativeTypeName("#define SP_SPPHRASESIZE_530 sizeof(SPPHRASE_53)")]
        public static readonly uint SP_SPPHRASESIZE_530 = unchecked((uint)(sizeof(SPPHRASE_53)));

        [NativeTypeName("#define SP_GETWHOLEPHRASE SPPR_ALL_ELEMENTS")]
        public const SPPHRASERNG SP_GETWHOLEPHRASE = SPPR_ALL_ELEMENTS;

        [NativeTypeName("#define SPRR_ALL_ELEMENTS SPPR_ALL_ELEMENTS")]
        public const SPPHRASERNG SPRR_ALL_ELEMENTS = SPPR_ALL_ELEMENTS;

        [NativeTypeName("#define SP_STREAMPOS_ASAP ( 0 )")]
        public const int SP_STREAMPOS_ASAP = (0);

        [NativeTypeName("#define SP_STREAMPOS_REALTIME ( -1 )")]
        public const int SP_STREAMPOS_REALTIME = (-1);

        [NativeTypeName("#define SPRULETRANS_TEXTBUFFER (SPSTATEHANDLE)(-1)")]
        public static readonly IntPtr SPRULETRANS_TEXTBUFFER = (IntPtr)(-1);

        [NativeTypeName("#define SPRULETRANS_WILDCARD (SPSTATEHANDLE)(-2)")]
        public static readonly IntPtr SPRULETRANS_WILDCARD = (IntPtr)(-2);

        [NativeTypeName("#define SPRULETRANS_DICTATION (SPSTATEHANDLE)(-3)")]
        public static readonly IntPtr SPRULETRANS_DICTATION = (IntPtr)(-3);

        [NativeTypeName("#define SPRP_NORMAL 0")]
        public const int SPRP_NORMAL = 0;

        [NativeTypeName("#define SP_MAX_LANGIDS ( 20 )")]
        public const int SP_MAX_LANGIDS = (20);
    }
}
