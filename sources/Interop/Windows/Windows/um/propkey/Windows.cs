// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propkey.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AUDIO_CHANNELCOUNT_MONO"]/*' />
    [NativeTypeName("#define AUDIO_CHANNELCOUNT_MONO 1ul")]
    public const uint AUDIO_CHANNELCOUNT_MONO = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AUDIO_CHANNELCOUNT_STEREO"]/*' />
    [NativeTypeName("#define AUDIO_CHANNELCOUNT_STEREO 2ul")]
    public const uint AUDIO_CHANNELCOUNT_STEREO = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALENDAR_RESPONSESTATUS_NONE"]/*' />
    [NativeTypeName("#define CALENDAR_RESPONSESTATUS_NONE 0u")]
    public const uint CALENDAR_RESPONSESTATUS_NONE = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALENDAR_RESPONSESTATUS_ORGANIZED"]/*' />
    [NativeTypeName("#define CALENDAR_RESPONSESTATUS_ORGANIZED 1u")]
    public const uint CALENDAR_RESPONSESTATUS_ORGANIZED = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALENDAR_RESPONSESTATUS_TENTATIVE"]/*' />
    [NativeTypeName("#define CALENDAR_RESPONSESTATUS_TENTATIVE 2u")]
    public const uint CALENDAR_RESPONSESTATUS_TENTATIVE = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALENDAR_RESPONSESTATUS_ACCEPTED"]/*' />
    [NativeTypeName("#define CALENDAR_RESPONSESTATUS_ACCEPTED 3u")]
    public const uint CALENDAR_RESPONSESTATUS_ACCEPTED = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALENDAR_RESPONSESTATUS_DECLINED"]/*' />
    [NativeTypeName("#define CALENDAR_RESPONSESTATUS_DECLINED 4u")]
    public const uint CALENDAR_RESPONSESTATUS_DECLINED = 4U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALENDAR_RESPONSESTATUS_NOTRESPONDED"]/*' />
    [NativeTypeName("#define CALENDAR_RESPONSESTATUS_NOTRESPONDED 5u")]
    public const uint CALENDAR_RESPONSESTATUS_NOTRESPONDED = 5U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALENDAR_SHOWTIMEAS_FREE"]/*' />
    [NativeTypeName("#define CALENDAR_SHOWTIMEAS_FREE 0u")]
    public const uint CALENDAR_SHOWTIMEAS_FREE = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALENDAR_SHOWTIMEAS_TENTATIVE"]/*' />
    [NativeTypeName("#define CALENDAR_SHOWTIMEAS_TENTATIVE 1u")]
    public const uint CALENDAR_SHOWTIMEAS_TENTATIVE = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALENDAR_SHOWTIMEAS_BUSY"]/*' />
    [NativeTypeName("#define CALENDAR_SHOWTIMEAS_BUSY 2u")]
    public const uint CALENDAR_SHOWTIMEAS_BUSY = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALENDAR_SHOWTIMEAS_OOF"]/*' />
    [NativeTypeName("#define CALENDAR_SHOWTIMEAS_OOF 3u")]
    public const uint CALENDAR_SHOWTIMEAS_OOF = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMMUNICATION_DIRECTION_UNKNOWN"]/*' />
    [NativeTypeName("#define COMMUNICATION_DIRECTION_UNKNOWN 0u")]
    public const uint COMMUNICATION_DIRECTION_UNKNOWN = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMMUNICATION_DIRECTION_INCOMING"]/*' />
    [NativeTypeName("#define COMMUNICATION_DIRECTION_INCOMING 1u")]
    public const uint COMMUNICATION_DIRECTION_INCOMING = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMMUNICATION_DIRECTION_OUTGOING"]/*' />
    [NativeTypeName("#define COMMUNICATION_DIRECTION_OUTGOING 2u")]
    public const uint COMMUNICATION_DIRECTION_OUTGOING = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TASKSTATUS_NOTSTARTED"]/*' />
    [NativeTypeName("#define TASKSTATUS_NOTSTARTED 0u")]
    public const uint TASKSTATUS_NOTSTARTED = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TASKSTATUS_INPROGRESS"]/*' />
    [NativeTypeName("#define TASKSTATUS_INPROGRESS 1u")]
    public const uint TASKSTATUS_INPROGRESS = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TASKSTATUS_COMPLETE"]/*' />
    [NativeTypeName("#define TASKSTATUS_COMPLETE 2u")]
    public const uint TASKSTATUS_COMPLETE = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TASKSTATUS_WAITING"]/*' />
    [NativeTypeName("#define TASKSTATUS_WAITING 3u")]
    public const uint TASKSTATUS_WAITING = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TASKSTATUS_DEFERRED"]/*' />
    [NativeTypeName("#define TASKSTATUS_DEFERRED 4u")]
    public const uint TASKSTATUS_DEFERRED = 4U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GENDERVALUE_UNSPECIFIED"]/*' />
    [NativeTypeName("#define GENDERVALUE_UNSPECIFIED 0u")]
    public const uint GENDERVALUE_UNSPECIFIED = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GENDERVALUE_FEMALE"]/*' />
    [NativeTypeName("#define GENDERVALUE_FEMALE 1u")]
    public const uint GENDERVALUE_FEMALE = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GENDERVALUE_MALE"]/*' />
    [NativeTypeName("#define GENDERVALUE_MALE 2u")]
    public const uint GENDERVALUE_MALE = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CREATOROPENWITHUIOPTION_HIDDEN"]/*' />
    [NativeTypeName("#define CREATOROPENWITHUIOPTION_HIDDEN 0ul")]
    public const uint CREATOROPENWITHUIOPTION_HIDDEN = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CREATOROPENWITHUIOPTION_VISIBLE"]/*' />
    [NativeTypeName("#define CREATOROPENWITHUIOPTION_VISIBLE 1ul")]
    public const uint CREATOROPENWITHUIOPTION_VISIBLE = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ISDEFAULTSAVE_NONE"]/*' />
    [NativeTypeName("#define ISDEFAULTSAVE_NONE 0ul")]
    public const uint ISDEFAULTSAVE_NONE = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ISDEFAULTSAVE_OWNER"]/*' />
    [NativeTypeName("#define ISDEFAULTSAVE_OWNER 1ul")]
    public const uint ISDEFAULTSAVE_OWNER = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ISDEFAULTSAVE_NONOWNER"]/*' />
    [NativeTypeName("#define ISDEFAULTSAVE_NONOWNER 2ul")]
    public const uint ISDEFAULTSAVE_NONOWNER = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ISDEFAULTSAVE_BOTH"]/*' />
    [NativeTypeName("#define ISDEFAULTSAVE_BOTH 3ul")]
    public const uint ISDEFAULTSAVE_BOTH = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FILEOFFLINEAVAILABILITYSTATUS_NOTAVAILABLEOFFLINE"]/*' />
    [NativeTypeName("#define FILEOFFLINEAVAILABILITYSTATUS_NOTAVAILABLEOFFLINE 0ul")]
    public const uint FILEOFFLINEAVAILABILITYSTATUS_NOTAVAILABLEOFFLINE = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FILEOFFLINEAVAILABILITYSTATUS_PARTIAL"]/*' />
    [NativeTypeName("#define FILEOFFLINEAVAILABILITYSTATUS_PARTIAL 1ul")]
    public const uint FILEOFFLINEAVAILABILITYSTATUS_PARTIAL = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FILEOFFLINEAVAILABILITYSTATUS_COMPLETE"]/*' />
    [NativeTypeName("#define FILEOFFLINEAVAILABILITYSTATUS_COMPLETE 2ul")]
    public const uint FILEOFFLINEAVAILABILITYSTATUS_COMPLETE = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FILEOFFLINEAVAILABILITYSTATUS_COMPLETE_PINNED"]/*' />
    [NativeTypeName("#define FILEOFFLINEAVAILABILITYSTATUS_COMPLETE_PINNED 3ul")]
    public const uint FILEOFFLINEAVAILABILITYSTATUS_COMPLETE_PINNED = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FILEOFFLINEAVAILABILITYSTATUS_EXCLUDED"]/*' />
    [NativeTypeName("#define FILEOFFLINEAVAILABILITYSTATUS_EXCLUDED 4ul")]
    public const uint FILEOFFLINEAVAILABILITYSTATUS_EXCLUDED = 4U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FILEOFFLINEAVAILABILITYSTATUS_FOLDER_EMPTY"]/*' />
    [NativeTypeName("#define FILEOFFLINEAVAILABILITYSTATUS_FOLDER_EMPTY 5ul")]
    public const uint FILEOFFLINEAVAILABILITYSTATUS_FOLDER_EMPTY = 5U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLAGCOLOR_PURPLE"]/*' />
    [NativeTypeName("#define FLAGCOLOR_PURPLE 1u")]
    public const uint FLAGCOLOR_PURPLE = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLAGCOLOR_ORANGE"]/*' />
    [NativeTypeName("#define FLAGCOLOR_ORANGE 2u")]
    public const uint FLAGCOLOR_ORANGE = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLAGCOLOR_GREEN"]/*' />
    [NativeTypeName("#define FLAGCOLOR_GREEN 3u")]
    public const uint FLAGCOLOR_GREEN = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLAGCOLOR_YELLOW"]/*' />
    [NativeTypeName("#define FLAGCOLOR_YELLOW 4u")]
    public const uint FLAGCOLOR_YELLOW = 4U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLAGCOLOR_BLUE"]/*' />
    [NativeTypeName("#define FLAGCOLOR_BLUE 5u")]
    public const uint FLAGCOLOR_BLUE = 5U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLAGCOLOR_RED"]/*' />
    [NativeTypeName("#define FLAGCOLOR_RED 6u")]
    public const uint FLAGCOLOR_RED = 6U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLAGSTATUS_NOTFLAGGED"]/*' />
    [NativeTypeName("#define FLAGSTATUS_NOTFLAGGED 0l")]
    public const int FLAGSTATUS_NOTFLAGGED = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLAGSTATUS_COMPLETED"]/*' />
    [NativeTypeName("#define FLAGSTATUS_COMPLETED 1l")]
    public const int FLAGSTATUS_COMPLETED = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLAGSTATUS_FOLLOWUP"]/*' />
    [NativeTypeName("#define FLAGSTATUS_FOLLOWUP 2l")]
    public const int FLAGSTATUS_FOLLOWUP = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMPORTANCE_LOW_MIN"]/*' />
    [NativeTypeName("#define IMPORTANCE_LOW_MIN 0l")]
    public const int IMPORTANCE_LOW_MIN = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMPORTANCE_LOW_SET"]/*' />
    [NativeTypeName("#define IMPORTANCE_LOW_SET 1l")]
    public const int IMPORTANCE_LOW_SET = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMPORTANCE_LOW_MAX"]/*' />
    [NativeTypeName("#define IMPORTANCE_LOW_MAX 1l")]
    public const int IMPORTANCE_LOW_MAX = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMPORTANCE_NORMAL_MIN"]/*' />
    [NativeTypeName("#define IMPORTANCE_NORMAL_MIN 2l")]
    public const int IMPORTANCE_NORMAL_MIN = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMPORTANCE_NORMAL_SET"]/*' />
    [NativeTypeName("#define IMPORTANCE_NORMAL_SET 3l")]
    public const int IMPORTANCE_NORMAL_SET = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMPORTANCE_NORMAL_MAX"]/*' />
    [NativeTypeName("#define IMPORTANCE_NORMAL_MAX 4l")]
    public const int IMPORTANCE_NORMAL_MAX = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMPORTANCE_HIGH_MIN"]/*' />
    [NativeTypeName("#define IMPORTANCE_HIGH_MIN 5l")]
    public const int IMPORTANCE_HIGH_MIN = 5;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMPORTANCE_HIGH_SET"]/*' />
    [NativeTypeName("#define IMPORTANCE_HIGH_SET 5l")]
    public const int IMPORTANCE_HIGH_SET = 5;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMPORTANCE_HIGH_MAX"]/*' />
    [NativeTypeName("#define IMPORTANCE_HIGH_MAX 5l")]
    public const int IMPORTANCE_HIGH_MAX = 5;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_CALENDAR"]/*' />
    [NativeTypeName("#define KIND_CALENDAR L\"calendar\"")]
    public const string KIND_CALENDAR = "calendar";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_COMMUNICATION"]/*' />
    [NativeTypeName("#define KIND_COMMUNICATION L\"communication\"")]
    public const string KIND_COMMUNICATION = "communication";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_CONTACT"]/*' />
    [NativeTypeName("#define KIND_CONTACT L\"contact\"")]
    public const string KIND_CONTACT = "contact";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_DOCUMENT"]/*' />
    [NativeTypeName("#define KIND_DOCUMENT L\"document\"")]
    public const string KIND_DOCUMENT = "document";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_EMAIL"]/*' />
    [NativeTypeName("#define KIND_EMAIL L\"email\"")]
    public const string KIND_EMAIL = "email";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_FEED"]/*' />
    [NativeTypeName("#define KIND_FEED L\"feed\"")]
    public const string KIND_FEED = "feed";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_FOLDER"]/*' />
    [NativeTypeName("#define KIND_FOLDER L\"folder\"")]
    public const string KIND_FOLDER = "folder";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_GAME"]/*' />
    [NativeTypeName("#define KIND_GAME L\"game\"")]
    public const string KIND_GAME = "game";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_INSTANTMESSAGE"]/*' />
    [NativeTypeName("#define KIND_INSTANTMESSAGE L\"instantmessage\"")]
    public const string KIND_INSTANTMESSAGE = "instantmessage";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_JOURNAL"]/*' />
    [NativeTypeName("#define KIND_JOURNAL L\"journal\"")]
    public const string KIND_JOURNAL = "journal";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_LINK"]/*' />
    [NativeTypeName("#define KIND_LINK L\"link\"")]
    public const string KIND_LINK = "link";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_MOVIE"]/*' />
    [NativeTypeName("#define KIND_MOVIE L\"movie\"")]
    public const string KIND_MOVIE = "movie";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_MUSIC"]/*' />
    [NativeTypeName("#define KIND_MUSIC L\"music\"")]
    public const string KIND_MUSIC = "music";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_NOTE"]/*' />
    [NativeTypeName("#define KIND_NOTE L\"note\"")]
    public const string KIND_NOTE = "note";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_PICTURE"]/*' />
    [NativeTypeName("#define KIND_PICTURE L\"picture\"")]
    public const string KIND_PICTURE = "picture";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_PLAYLIST"]/*' />
    [NativeTypeName("#define KIND_PLAYLIST L\"playlist\"")]
    public const string KIND_PLAYLIST = "playlist";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_PROGRAM"]/*' />
    [NativeTypeName("#define KIND_PROGRAM L\"program\"")]
    public const string KIND_PROGRAM = "program";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_RECORDEDTV"]/*' />
    [NativeTypeName("#define KIND_RECORDEDTV L\"recordedtv\"")]
    public const string KIND_RECORDEDTV = "recordedtv";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_SEARCHFOLDER"]/*' />
    [NativeTypeName("#define KIND_SEARCHFOLDER L\"searchfolder\"")]
    public const string KIND_SEARCHFOLDER = "searchfolder";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_TASK"]/*' />
    [NativeTypeName("#define KIND_TASK L\"task\"")]
    public const string KIND_TASK = "task";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_VIDEO"]/*' />
    [NativeTypeName("#define KIND_VIDEO L\"video\"")]
    public const string KIND_VIDEO = "video";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_WEBHISTORY"]/*' />
    [NativeTypeName("#define KIND_WEBHISTORY L\"webhistory\"")]
    public const string KIND_WEBHISTORY = "webhistory";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KIND_UNKNOWN"]/*' />
    [NativeTypeName("#define KIND_UNKNOWN L\"unknown\"")]
    public const string KIND_UNKNOWN = "unknown";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OFFLINEAVAILABILITY_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define OFFLINEAVAILABILITY_NOT_AVAILABLE 0ul")]
    public const uint OFFLINEAVAILABILITY_NOT_AVAILABLE = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OFFLINEAVAILABILITY_AVAILABLE"]/*' />
    [NativeTypeName("#define OFFLINEAVAILABILITY_AVAILABLE 1ul")]
    public const uint OFFLINEAVAILABILITY_AVAILABLE = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OFFLINEAVAILABILITY_ALWAYS_AVAILABLE"]/*' />
    [NativeTypeName("#define OFFLINEAVAILABILITY_ALWAYS_AVAILABLE 2ul")]
    public const uint OFFLINEAVAILABILITY_ALWAYS_AVAILABLE = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OFFLINESTATUS_ONLINE"]/*' />
    [NativeTypeName("#define OFFLINESTATUS_ONLINE 0ul")]
    public const uint OFFLINESTATUS_ONLINE = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OFFLINESTATUS_OFFLINE"]/*' />
    [NativeTypeName("#define OFFLINESTATUS_OFFLINE 1ul")]
    public const uint OFFLINESTATUS_OFFLINE = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OFFLINESTATUS_OFFLINE_FORCED"]/*' />
    [NativeTypeName("#define OFFLINESTATUS_OFFLINE_FORCED 2ul")]
    public const uint OFFLINESTATUS_OFFLINE_FORCED = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OFFLINESTATUS_OFFLINE_SLOW"]/*' />
    [NativeTypeName("#define OFFLINESTATUS_OFFLINE_SLOW 3ul")]
    public const uint OFFLINESTATUS_OFFLINE_SLOW = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OFFLINESTATUS_OFFLINE_ERROR"]/*' />
    [NativeTypeName("#define OFFLINESTATUS_OFFLINE_ERROR 4ul")]
    public const uint OFFLINESTATUS_OFFLINE_ERROR = 4U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OFFLINESTATUS_OFFLINE_ITEM_VERSION_CONFLICT"]/*' />
    [NativeTypeName("#define OFFLINESTATUS_OFFLINE_ITEM_VERSION_CONFLICT 5ul")]
    public const uint OFFLINESTATUS_OFFLINE_ITEM_VERSION_CONFLICT = 5U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OFFLINESTATUS_OFFLINE_SUSPENDED"]/*' />
    [NativeTypeName("#define OFFLINESTATUS_OFFLINE_SUSPENDED 6ul")]
    public const uint OFFLINESTATUS_OFFLINE_SUSPENDED = 6U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PRIORITY_PROP_LOW"]/*' />
    [NativeTypeName("#define PRIORITY_PROP_LOW 0u")]
    public const uint PRIORITY_PROP_LOW = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PRIORITY_PROP_NORMAL"]/*' />
    [NativeTypeName("#define PRIORITY_PROP_NORMAL 1u")]
    public const uint PRIORITY_PROP_NORMAL = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PRIORITY_PROP_HIGH"]/*' />
    [NativeTypeName("#define PRIORITY_PROP_HIGH 2u")]
    public const uint PRIORITY_PROP_HIGH = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RATING_ONE_STAR_MIN"]/*' />
    [NativeTypeName("#define RATING_ONE_STAR_MIN 1ul")]
    public const uint RATING_ONE_STAR_MIN = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RATING_ONE_STAR_SET"]/*' />
    [NativeTypeName("#define RATING_ONE_STAR_SET 1ul")]
    public const uint RATING_ONE_STAR_SET = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RATING_ONE_STAR_MAX"]/*' />
    [NativeTypeName("#define RATING_ONE_STAR_MAX 12ul")]
    public const uint RATING_ONE_STAR_MAX = 12U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RATING_TWO_STARS_MIN"]/*' />
    [NativeTypeName("#define RATING_TWO_STARS_MIN 13ul")]
    public const uint RATING_TWO_STARS_MIN = 13U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RATING_TWO_STARS_SET"]/*' />
    [NativeTypeName("#define RATING_TWO_STARS_SET 25ul")]
    public const uint RATING_TWO_STARS_SET = 25U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RATING_TWO_STARS_MAX"]/*' />
    [NativeTypeName("#define RATING_TWO_STARS_MAX 37ul")]
    public const uint RATING_TWO_STARS_MAX = 37U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RATING_THREE_STARS_MIN"]/*' />
    [NativeTypeName("#define RATING_THREE_STARS_MIN 38ul")]
    public const uint RATING_THREE_STARS_MIN = 38U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RATING_THREE_STARS_SET"]/*' />
    [NativeTypeName("#define RATING_THREE_STARS_SET 50ul")]
    public const uint RATING_THREE_STARS_SET = 50U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RATING_THREE_STARS_MAX"]/*' />
    [NativeTypeName("#define RATING_THREE_STARS_MAX 62ul")]
    public const uint RATING_THREE_STARS_MAX = 62U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RATING_FOUR_STARS_MIN"]/*' />
    [NativeTypeName("#define RATING_FOUR_STARS_MIN 63ul")]
    public const uint RATING_FOUR_STARS_MIN = 63U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RATING_FOUR_STARS_SET"]/*' />
    [NativeTypeName("#define RATING_FOUR_STARS_SET 75ul")]
    public const uint RATING_FOUR_STARS_SET = 75U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RATING_FOUR_STARS_MAX"]/*' />
    [NativeTypeName("#define RATING_FOUR_STARS_MAX 87ul")]
    public const uint RATING_FOUR_STARS_MAX = 87U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RATING_FIVE_STARS_MIN"]/*' />
    [NativeTypeName("#define RATING_FIVE_STARS_MIN 88ul")]
    public const uint RATING_FIVE_STARS_MIN = 88U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RATING_FIVE_STARS_SET"]/*' />
    [NativeTypeName("#define RATING_FIVE_STARS_SET 99ul")]
    public const uint RATING_FIVE_STARS_SET = 99U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RATING_FIVE_STARS_MAX"]/*' />
    [NativeTypeName("#define RATING_FIVE_STARS_MAX 99ul")]
    public const uint RATING_FIVE_STARS_MAX = 99U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SENSITIVITY_PROP_NORMAL"]/*' />
    [NativeTypeName("#define SENSITIVITY_PROP_NORMAL 0u")]
    public const uint SENSITIVITY_PROP_NORMAL = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SENSITIVITY_PROP_PERSONAL"]/*' />
    [NativeTypeName("#define SENSITIVITY_PROP_PERSONAL 1u")]
    public const uint SENSITIVITY_PROP_PERSONAL = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SENSITIVITY_PROP_PRIVATE"]/*' />
    [NativeTypeName("#define SENSITIVITY_PROP_PRIVATE 2u")]
    public const uint SENSITIVITY_PROP_PRIVATE = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SENSITIVITY_PROP_CONFIDENTIAL"]/*' />
    [NativeTypeName("#define SENSITIVITY_PROP_CONFIDENTIAL 3u")]
    public const uint SENSITIVITY_PROP_CONFIDENTIAL = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHARINGSTATUS_NOTSHARED"]/*' />
    [NativeTypeName("#define SHARINGSTATUS_NOTSHARED 0ul")]
    public const uint SHARINGSTATUS_NOTSHARED = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHARINGSTATUS_SHARED"]/*' />
    [NativeTypeName("#define SHARINGSTATUS_SHARED 1ul")]
    public const uint SHARINGSTATUS_SHARED = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHARINGSTATUS_PRIVATE"]/*' />
    [NativeTypeName("#define SHARINGSTATUS_PRIVATE 2ul")]
    public const uint SHARINGSTATUS_PRIVATE = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORAGEPROVIDERCUSTOM_ICON_PHONE"]/*' />
    [NativeTypeName("#define STORAGEPROVIDERCUSTOM_ICON_PHONE 0ul")]
    public const uint STORAGEPROVIDERCUSTOM_ICON_PHONE = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORAGEPROVIDERUSERACCOUNTKIND_UNKNOWN"]/*' />
    [NativeTypeName("#define STORAGEPROVIDERUSERACCOUNTKIND_UNKNOWN 0ul")]
    public const uint STORAGEPROVIDERUSERACCOUNTKIND_UNKNOWN = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORAGEPROVIDERUSERACCOUNTKIND_CONSUMER"]/*' />
    [NativeTypeName("#define STORAGEPROVIDERUSERACCOUNTKIND_CONSUMER 1ul")]
    public const uint STORAGEPROVIDERUSERACCOUNTKIND_CONSUMER = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORAGEPROVIDERUSERACCOUNTKIND_BUSINESS"]/*' />
    [NativeTypeName("#define STORAGEPROVIDERUSERACCOUNTKIND_BUSINESS 2ul")]
    public const uint STORAGEPROVIDERUSERACCOUNTKIND_BUSINESS = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BLUETOOTH_ADDRESS_TYPE_PUBLIC"]/*' />
    [NativeTypeName("#define BLUETOOTH_ADDRESS_TYPE_PUBLIC 0")]
    public const int BLUETOOTH_ADDRESS_TYPE_PUBLIC = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BLUETOOTH_ADDRESS_TYPE_RANDOM"]/*' />
    [NativeTypeName("#define BLUETOOTH_ADDRESS_TYPE_RANDOM 1")]
    public const int BLUETOOTH_ADDRESS_TYPE_RANDOM = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BLUETOOTH_CACHE_MODE_CACHED"]/*' />
    [NativeTypeName("#define BLUETOOTH_CACHE_MODE_CACHED 0")]
    public const int BLUETOOTH_CACHE_MODE_CACHED = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BLUETOOTH_CACHED_MODE_UNCACHED"]/*' />
    [NativeTypeName("#define BLUETOOTH_CACHED_MODE_UNCACHED 1")]
    public const int BLUETOOTH_CACHED_MODE_UNCACHED = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PLAYBACKSTATE_UNKNOWN"]/*' />
    [NativeTypeName("#define PLAYBACKSTATE_UNKNOWN 0")]
    public const int PLAYBACKSTATE_UNKNOWN = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PLAYBACKSTATE_STOPPED"]/*' />
    [NativeTypeName("#define PLAYBACKSTATE_STOPPED 1")]
    public const int PLAYBACKSTATE_STOPPED = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PLAYBACKSTATE_PLAYING"]/*' />
    [NativeTypeName("#define PLAYBACKSTATE_PLAYING 2")]
    public const int PLAYBACKSTATE_PLAYING = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PLAYBACKSTATE_TRANSITIONING"]/*' />
    [NativeTypeName("#define PLAYBACKSTATE_TRANSITIONING 3")]
    public const int PLAYBACKSTATE_TRANSITIONING = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PLAYBACKSTATE_PAUSED"]/*' />
    [NativeTypeName("#define PLAYBACKSTATE_PAUSED 4")]
    public const int PLAYBACKSTATE_PAUSED = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PLAYBACKSTATE_RECORDINGPAUSED"]/*' />
    [NativeTypeName("#define PLAYBACKSTATE_RECORDINGPAUSED 5")]
    public const int PLAYBACKSTATE_RECORDINGPAUSED = 5;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PLAYBACKSTATE_RECORDING"]/*' />
    [NativeTypeName("#define PLAYBACKSTATE_RECORDING 6")]
    public const int PLAYBACKSTATE_RECORDING = 6;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PLAYBACKSTATE_NOMEDIA"]/*' />
    [NativeTypeName("#define PLAYBACKSTATE_NOMEDIA 7")]
    public const int PLAYBACKSTATE_NOMEDIA = 7;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LAYOUTPATTERN_CVMFB_ALPHA"]/*' />
    [NativeTypeName("#define LAYOUTPATTERN_CVMFB_ALPHA L\"alpha\"")]
    public const string LAYOUTPATTERN_CVMFB_ALPHA = "alpha";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LAYOUTPATTERN_CVMFB_BETA"]/*' />
    [NativeTypeName("#define LAYOUTPATTERN_CVMFB_BETA L\"beta\"")]
    public const string LAYOUTPATTERN_CVMFB_BETA = "beta";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LAYOUTPATTERN_CVMFB_GAMMA"]/*' />
    [NativeTypeName("#define LAYOUTPATTERN_CVMFB_GAMMA L\"gamma\"")]
    public const string LAYOUTPATTERN_CVMFB_GAMMA = "gamma";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LAYOUTPATTERN_CVMFB_DELTA"]/*' />
    [NativeTypeName("#define LAYOUTPATTERN_CVMFB_DELTA L\"delta\"")]
    public const string LAYOUTPATTERN_CVMFB_DELTA = "delta";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LAYOUTPATTERN_CVMFS_ALPHA"]/*' />
    [NativeTypeName("#define LAYOUTPATTERN_CVMFS_ALPHA L\"alpha\"")]
    public const string LAYOUTPATTERN_CVMFS_ALPHA = "alpha";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LAYOUTPATTERN_CVMFS_BETA"]/*' />
    [NativeTypeName("#define LAYOUTPATTERN_CVMFS_BETA L\"beta\"")]
    public const string LAYOUTPATTERN_CVMFS_BETA = "beta";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LAYOUTPATTERN_CVMFS_GAMMA"]/*' />
    [NativeTypeName("#define LAYOUTPATTERN_CVMFS_GAMMA L\"gamma\"")]
    public const string LAYOUTPATTERN_CVMFS_GAMMA = "gamma";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LAYOUTPATTERN_CVMFS_DELTA"]/*' />
    [NativeTypeName("#define LAYOUTPATTERN_CVMFS_DELTA L\"delta\"")]
    public const string LAYOUTPATTERN_CVMFS_DELTA = "delta";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LINK_STATUS_RESOLVED"]/*' />
    [NativeTypeName("#define LINK_STATUS_RESOLVED 1l")]
    public const int LINK_STATUS_RESOLVED = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LINK_STATUS_BROKEN"]/*' />
    [NativeTypeName("#define LINK_STATUS_BROKEN 2l")]
    public const int LINK_STATUS_BROKEN = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NOTE_COLOR_BLUE"]/*' />
    [NativeTypeName("#define NOTE_COLOR_BLUE 0u")]
    public const uint NOTE_COLOR_BLUE = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NOTE_COLOR_GREEN"]/*' />
    [NativeTypeName("#define NOTE_COLOR_GREEN 1u")]
    public const uint NOTE_COLOR_GREEN = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NOTE_COLOR_PINK"]/*' />
    [NativeTypeName("#define NOTE_COLOR_PINK 2u")]
    public const uint NOTE_COLOR_PINK = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NOTE_COLOR_YELLOW"]/*' />
    [NativeTypeName("#define NOTE_COLOR_YELLOW 3u")]
    public const uint NOTE_COLOR_YELLOW = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NOTE_COLOR_WHITE"]/*' />
    [NativeTypeName("#define NOTE_COLOR_WHITE 4u")]
    public const uint NOTE_COLOR_WHITE = 4U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NOTE_COLOR_LIGHTGREEN"]/*' />
    [NativeTypeName("#define NOTE_COLOR_LIGHTGREEN 5u")]
    public const uint NOTE_COLOR_LIGHTGREEN = 5U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_CONTRAST_NORMAL"]/*' />
    [NativeTypeName("#define PHOTO_CONTRAST_NORMAL 0ul")]
    public const uint PHOTO_CONTRAST_NORMAL = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_CONTRAST_SOFT"]/*' />
    [NativeTypeName("#define PHOTO_CONTRAST_SOFT 1ul")]
    public const uint PHOTO_CONTRAST_SOFT = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_CONTRAST_HARD"]/*' />
    [NativeTypeName("#define PHOTO_CONTRAST_HARD 2ul")]
    public const uint PHOTO_CONTRAST_HARD = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_EXPOSUREPROGRAM_UNKNOWN"]/*' />
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_UNKNOWN 0ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_UNKNOWN = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_EXPOSUREPROGRAM_MANUAL"]/*' />
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_MANUAL 1ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_MANUAL = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_EXPOSUREPROGRAM_NORMAL"]/*' />
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_NORMAL 2ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_NORMAL = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_EXPOSUREPROGRAM_APERTURE"]/*' />
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_APERTURE 3ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_APERTURE = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_EXPOSUREPROGRAM_SHUTTER"]/*' />
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_SHUTTER 4ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_SHUTTER = 4U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_EXPOSUREPROGRAM_CREATIVE"]/*' />
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_CREATIVE 5ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_CREATIVE = 5U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_EXPOSUREPROGRAM_ACTION"]/*' />
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_ACTION 6ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_ACTION = 6U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_EXPOSUREPROGRAM_PORTRAIT"]/*' />
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_PORTRAIT 7ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_PORTRAIT = 7U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_EXPOSUREPROGRAM_LANDSCAPE"]/*' />
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_LANDSCAPE 8ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_LANDSCAPE = 8U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_NONE"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_NONE 0")]
    public const int PHOTO_FLASH_NONE = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_FLASH"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_FLASH 1")]
    public const int PHOTO_FLASH_FLASH = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_WITHOUTSTROBE"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_WITHOUTSTROBE 5")]
    public const int PHOTO_FLASH_WITHOUTSTROBE = 5;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_WITHSTROBE"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_WITHSTROBE 7")]
    public const int PHOTO_FLASH_WITHSTROBE = 7;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_FLASH_COMPULSORY"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_FLASH_COMPULSORY 9")]
    public const int PHOTO_FLASH_FLASH_COMPULSORY = 9;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_FLASH_COMPULSORY_NORETURNLIGHT"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_FLASH_COMPULSORY_NORETURNLIGHT 13")]
    public const int PHOTO_FLASH_FLASH_COMPULSORY_NORETURNLIGHT = 13;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_FLASH_COMPULSORY_RETURNLIGHT"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_FLASH_COMPULSORY_RETURNLIGHT 15")]
    public const int PHOTO_FLASH_FLASH_COMPULSORY_RETURNLIGHT = 15;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_NONE_COMPULSORY"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_NONE_COMPULSORY 16")]
    public const int PHOTO_FLASH_NONE_COMPULSORY = 16;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_NONE_AUTO"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_NONE_AUTO 24")]
    public const int PHOTO_FLASH_NONE_AUTO = 24;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_FLASH_AUTO"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_FLASH_AUTO 25")]
    public const int PHOTO_FLASH_FLASH_AUTO = 25;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_FLASH_AUTO_NORETURNLIGHT"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_FLASH_AUTO_NORETURNLIGHT 29")]
    public const int PHOTO_FLASH_FLASH_AUTO_NORETURNLIGHT = 29;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_FLASH_AUTO_RETURNLIGHT"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_FLASH_AUTO_RETURNLIGHT 31")]
    public const int PHOTO_FLASH_FLASH_AUTO_RETURNLIGHT = 31;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_NOFUNCTION"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_NOFUNCTION 32")]
    public const int PHOTO_FLASH_NOFUNCTION = 32;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_FLASH_REDEYE"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_FLASH_REDEYE 65")]
    public const int PHOTO_FLASH_FLASH_REDEYE = 65;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_FLASH_REDEYE_NORETURNLIGHT"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_FLASH_REDEYE_NORETURNLIGHT 69")]
    public const int PHOTO_FLASH_FLASH_REDEYE_NORETURNLIGHT = 69;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_FLASH_REDEYE_RETURNLIGHT"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_FLASH_REDEYE_RETURNLIGHT 71")]
    public const int PHOTO_FLASH_FLASH_REDEYE_RETURNLIGHT = 71;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_FLASH_COMPULSORY_REDEYE"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_FLASH_COMPULSORY_REDEYE 73")]
    public const int PHOTO_FLASH_FLASH_COMPULSORY_REDEYE = 73;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_FLASH_COMPULSORY_REDEYE_NORETURNLIGHT"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_FLASH_COMPULSORY_REDEYE_NORETURNLIGHT 77")]
    public const int PHOTO_FLASH_FLASH_COMPULSORY_REDEYE_NORETURNLIGHT = 77;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_FLASH_COMPULSORY_REDEYE_RETURNLIGHT"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_FLASH_COMPULSORY_REDEYE_RETURNLIGHT 79")]
    public const int PHOTO_FLASH_FLASH_COMPULSORY_REDEYE_RETURNLIGHT = 79;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_FLASH_AUTO_REDEYE"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_FLASH_AUTO_REDEYE 89")]
    public const int PHOTO_FLASH_FLASH_AUTO_REDEYE = 89;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_FLASH_AUTO_REDEYE_NORETURNLIGHT"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_FLASH_AUTO_REDEYE_NORETURNLIGHT 93")]
    public const int PHOTO_FLASH_FLASH_AUTO_REDEYE_NORETURNLIGHT = 93;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_FLASH_FLASH_AUTO_REDEYE_RETURNLIGHT"]/*' />
    [NativeTypeName("#define PHOTO_FLASH_FLASH_AUTO_REDEYE_RETURNLIGHT 95")]
    public const int PHOTO_FLASH_FLASH_AUTO_REDEYE_RETURNLIGHT = 95;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_GAINCONTROL_NONE"]/*' />
    [NativeTypeName("#define PHOTO_GAINCONTROL_NONE 0.0")]
    public const double PHOTO_GAINCONTROL_NONE = 0.0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_GAINCONTROL_LOWGAINUP"]/*' />
    [NativeTypeName("#define PHOTO_GAINCONTROL_LOWGAINUP 1.0")]
    public const double PHOTO_GAINCONTROL_LOWGAINUP = 1.0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_GAINCONTROL_HIGHGAINUP"]/*' />
    [NativeTypeName("#define PHOTO_GAINCONTROL_HIGHGAINUP 2.0")]
    public const double PHOTO_GAINCONTROL_HIGHGAINUP = 2.0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_GAINCONTROL_LOWGAINDOWN"]/*' />
    [NativeTypeName("#define PHOTO_GAINCONTROL_LOWGAINDOWN 3.0")]
    public const double PHOTO_GAINCONTROL_LOWGAINDOWN = 3.0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_GAINCONTROL_HIGHGAINDOWN"]/*' />
    [NativeTypeName("#define PHOTO_GAINCONTROL_HIGHGAINDOWN 4.0")]
    public const double PHOTO_GAINCONTROL_HIGHGAINDOWN = 4.0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_LIGHTSOURCE_UNKNOWN"]/*' />
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_UNKNOWN 0ul")]
    public const uint PHOTO_LIGHTSOURCE_UNKNOWN = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_LIGHTSOURCE_DAYLIGHT"]/*' />
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_DAYLIGHT 1ul")]
    public const uint PHOTO_LIGHTSOURCE_DAYLIGHT = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_LIGHTSOURCE_FLUORESCENT"]/*' />
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_FLUORESCENT 2ul")]
    public const uint PHOTO_LIGHTSOURCE_FLUORESCENT = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_LIGHTSOURCE_TUNGSTEN"]/*' />
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_TUNGSTEN 3ul")]
    public const uint PHOTO_LIGHTSOURCE_TUNGSTEN = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_LIGHTSOURCE_STANDARD_A"]/*' />
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_STANDARD_A 17ul")]
    public const uint PHOTO_LIGHTSOURCE_STANDARD_A = 17U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_LIGHTSOURCE_STANDARD_B"]/*' />
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_STANDARD_B 18ul")]
    public const uint PHOTO_LIGHTSOURCE_STANDARD_B = 18U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_LIGHTSOURCE_STANDARD_C"]/*' />
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_STANDARD_C 19ul")]
    public const uint PHOTO_LIGHTSOURCE_STANDARD_C = 19U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_LIGHTSOURCE_D55"]/*' />
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_D55 20ul")]
    public const uint PHOTO_LIGHTSOURCE_D55 = 20U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_LIGHTSOURCE_D65"]/*' />
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_D65 21ul")]
    public const uint PHOTO_LIGHTSOURCE_D65 = 21U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_LIGHTSOURCE_D75"]/*' />
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_D75 22ul")]
    public const uint PHOTO_LIGHTSOURCE_D75 = 22U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_METERINGMODE_UNKNOWN"]/*' />
    [NativeTypeName("#define PHOTO_METERINGMODE_UNKNOWN 0u")]
    public const uint PHOTO_METERINGMODE_UNKNOWN = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_METERINGMODE_AVERAGE"]/*' />
    [NativeTypeName("#define PHOTO_METERINGMODE_AVERAGE 1u")]
    public const uint PHOTO_METERINGMODE_AVERAGE = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_METERINGMODE_CENTER"]/*' />
    [NativeTypeName("#define PHOTO_METERINGMODE_CENTER 2u")]
    public const uint PHOTO_METERINGMODE_CENTER = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_METERINGMODE_SPOT"]/*' />
    [NativeTypeName("#define PHOTO_METERINGMODE_SPOT 3u")]
    public const uint PHOTO_METERINGMODE_SPOT = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_METERINGMODE_MULTISPOT"]/*' />
    [NativeTypeName("#define PHOTO_METERINGMODE_MULTISPOT 4u")]
    public const uint PHOTO_METERINGMODE_MULTISPOT = 4U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_METERINGMODE_PATTERN"]/*' />
    [NativeTypeName("#define PHOTO_METERINGMODE_PATTERN 5u")]
    public const uint PHOTO_METERINGMODE_PATTERN = 5U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_METERINGMODE_PARTIAL"]/*' />
    [NativeTypeName("#define PHOTO_METERINGMODE_PARTIAL 6u")]
    public const uint PHOTO_METERINGMODE_PARTIAL = 6U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_ORIENTATION_NORMAL"]/*' />
    [NativeTypeName("#define PHOTO_ORIENTATION_NORMAL 1u")]
    public const uint PHOTO_ORIENTATION_NORMAL = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_ORIENTATION_FLIPHORIZONTAL"]/*' />
    [NativeTypeName("#define PHOTO_ORIENTATION_FLIPHORIZONTAL 2u")]
    public const uint PHOTO_ORIENTATION_FLIPHORIZONTAL = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_ORIENTATION_ROTATE180"]/*' />
    [NativeTypeName("#define PHOTO_ORIENTATION_ROTATE180 3u")]
    public const uint PHOTO_ORIENTATION_ROTATE180 = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_ORIENTATION_FLIPVERTICAL"]/*' />
    [NativeTypeName("#define PHOTO_ORIENTATION_FLIPVERTICAL 4u")]
    public const uint PHOTO_ORIENTATION_FLIPVERTICAL = 4U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_ORIENTATION_TRANSPOSE"]/*' />
    [NativeTypeName("#define PHOTO_ORIENTATION_TRANSPOSE 5u")]
    public const uint PHOTO_ORIENTATION_TRANSPOSE = 5U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_ORIENTATION_ROTATE270"]/*' />
    [NativeTypeName("#define PHOTO_ORIENTATION_ROTATE270 6u")]
    public const uint PHOTO_ORIENTATION_ROTATE270 = 6U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_ORIENTATION_TRANSVERSE"]/*' />
    [NativeTypeName("#define PHOTO_ORIENTATION_TRANSVERSE 7u")]
    public const uint PHOTO_ORIENTATION_TRANSVERSE = 7U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_ORIENTATION_ROTATE90"]/*' />
    [NativeTypeName("#define PHOTO_ORIENTATION_ROTATE90 8u")]
    public const uint PHOTO_ORIENTATION_ROTATE90 = 8U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_PHOTOMETRIC_RGB"]/*' />
    [NativeTypeName("#define PHOTO_PHOTOMETRIC_RGB 2u")]
    public const uint PHOTO_PHOTOMETRIC_RGB = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_PHOTOMETRIC_YCBCR"]/*' />
    [NativeTypeName("#define PHOTO_PHOTOMETRIC_YCBCR 6u")]
    public const uint PHOTO_PHOTOMETRIC_YCBCR = 6U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_PROGRAMMODE_NOTDEFINED"]/*' />
    [NativeTypeName("#define PHOTO_PROGRAMMODE_NOTDEFINED 0ul")]
    public const uint PHOTO_PROGRAMMODE_NOTDEFINED = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_PROGRAMMODE_MANUAL"]/*' />
    [NativeTypeName("#define PHOTO_PROGRAMMODE_MANUAL 1ul")]
    public const uint PHOTO_PROGRAMMODE_MANUAL = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_PROGRAMMODE_NORMAL"]/*' />
    [NativeTypeName("#define PHOTO_PROGRAMMODE_NORMAL 2ul")]
    public const uint PHOTO_PROGRAMMODE_NORMAL = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_PROGRAMMODE_APERTURE"]/*' />
    [NativeTypeName("#define PHOTO_PROGRAMMODE_APERTURE 3ul")]
    public const uint PHOTO_PROGRAMMODE_APERTURE = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_PROGRAMMODE_SHUTTER"]/*' />
    [NativeTypeName("#define PHOTO_PROGRAMMODE_SHUTTER 4ul")]
    public const uint PHOTO_PROGRAMMODE_SHUTTER = 4U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_PROGRAMMODE_CREATIVE"]/*' />
    [NativeTypeName("#define PHOTO_PROGRAMMODE_CREATIVE 5ul")]
    public const uint PHOTO_PROGRAMMODE_CREATIVE = 5U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_PROGRAMMODE_ACTION"]/*' />
    [NativeTypeName("#define PHOTO_PROGRAMMODE_ACTION 6ul")]
    public const uint PHOTO_PROGRAMMODE_ACTION = 6U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_PROGRAMMODE_PORTRAIT"]/*' />
    [NativeTypeName("#define PHOTO_PROGRAMMODE_PORTRAIT 7ul")]
    public const uint PHOTO_PROGRAMMODE_PORTRAIT = 7U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_PROGRAMMODE_LANDSCAPE"]/*' />
    [NativeTypeName("#define PHOTO_PROGRAMMODE_LANDSCAPE 8ul")]
    public const uint PHOTO_PROGRAMMODE_LANDSCAPE = 8U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_SATURATION_NORMAL"]/*' />
    [NativeTypeName("#define PHOTO_SATURATION_NORMAL 0ul")]
    public const uint PHOTO_SATURATION_NORMAL = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_SATURATION_LOW"]/*' />
    [NativeTypeName("#define PHOTO_SATURATION_LOW 1ul")]
    public const uint PHOTO_SATURATION_LOW = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_SATURATION_HIGH"]/*' />
    [NativeTypeName("#define PHOTO_SATURATION_HIGH 2ul")]
    public const uint PHOTO_SATURATION_HIGH = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_SHARPNESS_NORMAL"]/*' />
    [NativeTypeName("#define PHOTO_SHARPNESS_NORMAL 0ul")]
    public const uint PHOTO_SHARPNESS_NORMAL = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_SHARPNESS_SOFT"]/*' />
    [NativeTypeName("#define PHOTO_SHARPNESS_SOFT 1ul")]
    public const uint PHOTO_SHARPNESS_SOFT = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_SHARPNESS_HARD"]/*' />
    [NativeTypeName("#define PHOTO_SHARPNESS_HARD 2ul")]
    public const uint PHOTO_SHARPNESS_HARD = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_WHITEBALANCE_AUTO"]/*' />
    [NativeTypeName("#define PHOTO_WHITEBALANCE_AUTO 0ul")]
    public const uint PHOTO_WHITEBALANCE_AUTO = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PHOTO_WHITEBALANCE_MANUAL"]/*' />
    [NativeTypeName("#define PHOTO_WHITEBALANCE_MANUAL 1ul")]
    public const uint PHOTO_WHITEBALANCE_MANUAL = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MATCH_KIND_LEXICAL"]/*' />
    [NativeTypeName("#define MATCH_KIND_LEXICAL 1l")]
    public const int MATCH_KIND_LEXICAL = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MATCH_KIND_SEMANTIC"]/*' />
    [NativeTypeName("#define MATCH_KIND_SEMANTIC 2l")]
    public const int MATCH_KIND_SEMANTIC = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HOMEGROUPING_UNSPECIFIED"]/*' />
    [NativeTypeName("#define HOMEGROUPING_UNSPECIFIED 0ul")]
    public const uint HOMEGROUPING_UNSPECIFIED = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HOMEGROUPING_FREQUENT"]/*' />
    [NativeTypeName("#define HOMEGROUPING_FREQUENT 1ul")]
    public const uint HOMEGROUPING_FREQUENT = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HOMEGROUPING_PINNED"]/*' />
    [NativeTypeName("#define HOMEGROUPING_PINNED 2ul")]
    public const uint HOMEGROUPING_PINNED = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HOMEGROUPING_RECENT"]/*' />
    [NativeTypeName("#define HOMEGROUPING_RECENT 3ul")]
    public const uint HOMEGROUPING_RECENT = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HOMEGROUPING_RECOMMENDATIONS"]/*' />
    [NativeTypeName("#define HOMEGROUPING_RECOMMENDATIONS 4ul")]
    public const uint HOMEGROUPING_RECOMMENDATIONS = 4U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HOMEGROUPING_SHARED"]/*' />
    [NativeTypeName("#define HOMEGROUPING_SHARED 5ul")]
    public const uint HOMEGROUPING_SHARED = 5U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SFGAOSTR_FILESYS"]/*' />
    [NativeTypeName("#define SFGAOSTR_FILESYS L\"filesys\"")]
    public const string SFGAOSTR_FILESYS = "filesys";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SFGAOSTR_FILEANC"]/*' />
    [NativeTypeName("#define SFGAOSTR_FILEANC L\"fileanc\"")]
    public const string SFGAOSTR_FILEANC = "fileanc";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SFGAOSTR_STORAGEANC"]/*' />
    [NativeTypeName("#define SFGAOSTR_STORAGEANC L\"storageanc\"")]
    public const string SFGAOSTR_STORAGEANC = "storageanc";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SFGAOSTR_STREAM"]/*' />
    [NativeTypeName("#define SFGAOSTR_STREAM L\"stream\"")]
    public const string SFGAOSTR_STREAM = "stream";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SFGAOSTR_LINK"]/*' />
    [NativeTypeName("#define SFGAOSTR_LINK L\"link\"")]
    public const string SFGAOSTR_LINK = "link";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SFGAOSTR_HIDDEN"]/*' />
    [NativeTypeName("#define SFGAOSTR_HIDDEN L\"hidden\"")]
    public const string SFGAOSTR_HIDDEN = "hidden";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SFGAOSTR_SUPERHIDDEN"]/*' />
    [NativeTypeName("#define SFGAOSTR_SUPERHIDDEN L\"superhidden\"")]
    public const string SFGAOSTR_SUPERHIDDEN = "superhidden";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SFGAOSTR_FOLDER"]/*' />
    [NativeTypeName("#define SFGAOSTR_FOLDER L\"folder\"")]
    public const string SFGAOSTR_FOLDER = "folder";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SFGAOSTR_NONENUM"]/*' />
    [NativeTypeName("#define SFGAOSTR_NONENUM L\"nonenum\"")]
    public const string SFGAOSTR_NONENUM = "nonenum";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SFGAOSTR_BROWSABLE"]/*' />
    [NativeTypeName("#define SFGAOSTR_BROWSABLE L\"browsable\"")]
    public const string SFGAOSTR_BROWSABLE = "browsable";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SFGAOSTR_SYSTEM"]/*' />
    [NativeTypeName("#define SFGAOSTR_SYSTEM L\"system\"")]
    public const string SFGAOSTR_SYSTEM = "system";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SFGAOSTR_PLACEHOLDER"]/*' />
    [NativeTypeName("#define SFGAOSTR_PLACEHOLDER L\"placeholder\"")]
    public const string SFGAOSTR_PLACEHOLDER = "placeholder";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORAGEPROVIDERSTATE_NONE"]/*' />
    [NativeTypeName("#define STORAGEPROVIDERSTATE_NONE 0ul")]
    public const uint STORAGEPROVIDERSTATE_NONE = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORAGEPROVIDERSTATE_SPARSE"]/*' />
    [NativeTypeName("#define STORAGEPROVIDERSTATE_SPARSE 1ul")]
    public const uint STORAGEPROVIDERSTATE_SPARSE = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORAGEPROVIDERSTATE_IN_SYNC"]/*' />
    [NativeTypeName("#define STORAGEPROVIDERSTATE_IN_SYNC 2ul")]
    public const uint STORAGEPROVIDERSTATE_IN_SYNC = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORAGEPROVIDERSTATE_PINNED"]/*' />
    [NativeTypeName("#define STORAGEPROVIDERSTATE_PINNED 3ul")]
    public const uint STORAGEPROVIDERSTATE_PINNED = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORAGEPROVIDERSTATE_PENDING_UPLOAD"]/*' />
    [NativeTypeName("#define STORAGEPROVIDERSTATE_PENDING_UPLOAD 4ul")]
    public const uint STORAGEPROVIDERSTATE_PENDING_UPLOAD = 4U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORAGEPROVIDERSTATE_PENDING_DOWNLOAD"]/*' />
    [NativeTypeName("#define STORAGEPROVIDERSTATE_PENDING_DOWNLOAD 5ul")]
    public const uint STORAGEPROVIDERSTATE_PENDING_DOWNLOAD = 5U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORAGEPROVIDERSTATE_TRANSFERRING"]/*' />
    [NativeTypeName("#define STORAGEPROVIDERSTATE_TRANSFERRING 6ul")]
    public const uint STORAGEPROVIDERSTATE_TRANSFERRING = 6U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORAGEPROVIDERSTATE_ERROR"]/*' />
    [NativeTypeName("#define STORAGEPROVIDERSTATE_ERROR 7ul")]
    public const uint STORAGEPROVIDERSTATE_ERROR = 7U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORAGEPROVIDERSTATE_WARNING"]/*' />
    [NativeTypeName("#define STORAGEPROVIDERSTATE_WARNING 8ul")]
    public const uint STORAGEPROVIDERSTATE_WARNING = 8U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORAGEPROVIDERSTATE_EXCLUDED"]/*' />
    [NativeTypeName("#define STORAGEPROVIDERSTATE_EXCLUDED 9ul")]
    public const uint STORAGEPROVIDERSTATE_EXCLUDED = 9U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STORAGEPROVIDERSTATE_PENDING_UNSPECIFIED"]/*' />
    [NativeTypeName("#define STORAGEPROVIDERSTATE_PENDING_UNSPECIFIED 10ul")]
    public const uint STORAGEPROVIDERSTATE_PENDING_UNSPECIFIED = 10U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.APPUSERMODEL_STARTPINOPTION_DEFAULT"]/*' />
    [NativeTypeName("#define APPUSERMODEL_STARTPINOPTION_DEFAULT 0ul")]
    public const uint APPUSERMODEL_STARTPINOPTION_DEFAULT = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.APPUSERMODEL_STARTPINOPTION_NOPINONINSTALL"]/*' />
    [NativeTypeName("#define APPUSERMODEL_STARTPINOPTION_NOPINONINSTALL 1ul")]
    public const uint APPUSERMODEL_STARTPINOPTION_NOPINONINSTALL = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.APPUSERMODEL_STARTPINOPTION_USERPINNED"]/*' />
    [NativeTypeName("#define APPUSERMODEL_STARTPINOPTION_USERPINNED 2ul")]
    public const uint APPUSERMODEL_STARTPINOPTION_USERPINNED = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNC_HANDLERTYPE_OTHER"]/*' />
    [NativeTypeName("#define SYNC_HANDLERTYPE_OTHER 0ul")]
    public const uint SYNC_HANDLERTYPE_OTHER = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNC_HANDLERTYPE_PROGRAMS"]/*' />
    [NativeTypeName("#define SYNC_HANDLERTYPE_PROGRAMS 1ul")]
    public const uint SYNC_HANDLERTYPE_PROGRAMS = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNC_HANDLERTYPE_DEVICES"]/*' />
    [NativeTypeName("#define SYNC_HANDLERTYPE_DEVICES 2ul")]
    public const uint SYNC_HANDLERTYPE_DEVICES = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNC_HANDLERTYPE_FOLDERS"]/*' />
    [NativeTypeName("#define SYNC_HANDLERTYPE_FOLDERS 3ul")]
    public const uint SYNC_HANDLERTYPE_FOLDERS = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNC_HANDLERTYPE_WEBSERVICES"]/*' />
    [NativeTypeName("#define SYNC_HANDLERTYPE_WEBSERVICES 4ul")]
    public const uint SYNC_HANDLERTYPE_WEBSERVICES = 4U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNC_HANDLERTYPE_COMPUTERS"]/*' />
    [NativeTypeName("#define SYNC_HANDLERTYPE_COMPUTERS 5ul")]
    public const uint SYNC_HANDLERTYPE_COMPUTERS = 5U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNC_STATE_NOTSETUP"]/*' />
    [NativeTypeName("#define SYNC_STATE_NOTSETUP 0ul")]
    public const uint SYNC_STATE_NOTSETUP = 0U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNC_STATE_SYNCNOTRUN"]/*' />
    [NativeTypeName("#define SYNC_STATE_SYNCNOTRUN 1ul")]
    public const uint SYNC_STATE_SYNCNOTRUN = 1U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNC_STATE_IDLE"]/*' />
    [NativeTypeName("#define SYNC_STATE_IDLE 2ul")]
    public const uint SYNC_STATE_IDLE = 2U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNC_STATE_ERROR"]/*' />
    [NativeTypeName("#define SYNC_STATE_ERROR 3ul")]
    public const uint SYNC_STATE_ERROR = 3U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNC_STATE_PENDING"]/*' />
    [NativeTypeName("#define SYNC_STATE_PENDING 4ul")]
    public const uint SYNC_STATE_PENDING = 4U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNC_STATE_SYNCING"]/*' />
    [NativeTypeName("#define SYNC_STATE_SYNCING 5ul")]
    public const uint SYNC_STATE_SYNCING = 5U;
}
