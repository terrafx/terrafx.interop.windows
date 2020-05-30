// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmsyscom.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int MAXPNAMELEN = 32;

        public const int MAXERRORLENGTH = 256;

        public const int MAX_JOYSTICKOEMVXDNAME = 260;

        public const int TIME_MS = 0x0001;

        public const int TIME_SAMPLES = 0x0002;

        public const int TIME_BYTES = 0x0004;

        public const int TIME_SMPTE = 0x0008;

        public const int TIME_MIDI = 0x0010;

        public const int TIME_TICKS = 0x0020;

        public static uint MAKEFOURCC(byte ch0, byte ch1, byte ch2, byte ch3)
        {
            return ((uint)(byte)(ch0) | ((uint)(byte)(ch1) << 8) | ((uint)(byte)(ch2) << 16) | ((uint)(byte)(ch3) << 24));
        }

        public const int MM_JOY1MOVE = 0x3A0;

        public const int MM_JOY2MOVE = 0x3A1;

        public const int MM_JOY1ZMOVE = 0x3A2;

        public const int MM_JOY2ZMOVE = 0x3A3;

        public const int MM_JOY1BUTTONDOWN = 0x3B5;

        public const int MM_JOY2BUTTONDOWN = 0x3B6;

        public const int MM_JOY1BUTTONUP = 0x3B7;

        public const int MM_JOY2BUTTONUP = 0x3B8;

        public const int MM_MCINOTIFY = 0x3B9;

        public const int MM_WOM_OPEN = 0x3BB;

        public const int MM_WOM_CLOSE = 0x3BC;

        public const int MM_WOM_DONE = 0x3BD;

        public const int MM_WIM_OPEN = 0x3BE;

        public const int MM_WIM_CLOSE = 0x3BF;

        public const int MM_WIM_DATA = 0x3C0;

        public const int MM_MIM_OPEN = 0x3C1;

        public const int MM_MIM_CLOSE = 0x3C2;

        public const int MM_MIM_DATA = 0x3C3;

        public const int MM_MIM_LONGDATA = 0x3C4;

        public const int MM_MIM_ERROR = 0x3C5;

        public const int MM_MIM_LONGERROR = 0x3C6;

        public const int MM_MOM_OPEN = 0x3C7;

        public const int MM_MOM_CLOSE = 0x3C8;

        public const int MM_MOM_DONE = 0x3C9;

        public const int MM_DRVM_OPEN = 0x3D0;

        public const int MM_DRVM_CLOSE = 0x3D1;

        public const int MM_DRVM_DATA = 0x3D2;

        public const int MM_DRVM_ERROR = 0x3D3;

        public const int MM_STREAM_OPEN = 0x3D4;

        public const int MM_STREAM_CLOSE = 0x3D5;

        public const int MM_STREAM_DONE = 0x3D6;

        public const int MM_STREAM_ERROR = 0x3D7;

        public const int MM_MOM_POSITIONCB = 0x3CA;

        public const int MM_MCISIGNAL = 0x3CB;

        public const int MM_MIM_MOREDATA = 0x3CC;

        public const int MM_MIXM_LINE_CHANGE = 0x3D0;

        public const int MM_MIXM_CONTROL_CHANGE = 0x3D1;

        public const int MMSYSERR_BASE = 0;

        public const int WAVERR_BASE = 32;

        public const int MIDIERR_BASE = 64;

        public const int TIMERR_BASE = 96;

        public const int JOYERR_BASE = 160;

        public const int MCIERR_BASE = 256;

        public const int MIXERR_BASE = 1024;

        public const int MCI_STRING_OFFSET = 512;

        public const int MCI_VD_OFFSET = 1024;

        public const int MCI_CD_OFFSET = 1088;

        public const int MCI_WAVE_OFFSET = 1152;

        public const int MCI_SEQ_OFFSET = 1216;

        public const int MMSYSERR_NOERROR = 0;

        public const int MMSYSERR_ERROR = (MMSYSERR_BASE + 1);

        public const int MMSYSERR_BADDEVICEID = (MMSYSERR_BASE + 2);

        public const int MMSYSERR_NOTENABLED = (MMSYSERR_BASE + 3);

        public const int MMSYSERR_ALLOCATED = (MMSYSERR_BASE + 4);

        public const int MMSYSERR_INVALHANDLE = (MMSYSERR_BASE + 5);

        public const int MMSYSERR_NODRIVER = (MMSYSERR_BASE + 6);

        public const int MMSYSERR_NOMEM = (MMSYSERR_BASE + 7);

        public const int MMSYSERR_NOTSUPPORTED = (MMSYSERR_BASE + 8);

        public const int MMSYSERR_BADERRNUM = (MMSYSERR_BASE + 9);

        public const int MMSYSERR_INVALFLAG = (MMSYSERR_BASE + 10);

        public const int MMSYSERR_INVALPARAM = (MMSYSERR_BASE + 11);

        public const int MMSYSERR_HANDLEBUSY = (MMSYSERR_BASE + 12);

        public const int MMSYSERR_INVALIDALIAS = (MMSYSERR_BASE + 13);

        public const int MMSYSERR_BADDB = (MMSYSERR_BASE + 14);

        public const int MMSYSERR_KEYNOTFOUND = (MMSYSERR_BASE + 15);

        public const int MMSYSERR_READERROR = (MMSYSERR_BASE + 16);

        public const int MMSYSERR_WRITEERROR = (MMSYSERR_BASE + 17);

        public const int MMSYSERR_DELETEERROR = (MMSYSERR_BASE + 18);

        public const int MMSYSERR_VALNOTFOUND = (MMSYSERR_BASE + 19);

        public const int MMSYSERR_NODRIVERCB = (MMSYSERR_BASE + 20);

        public const int MMSYSERR_MOREDATA = (MMSYSERR_BASE + 21);

        public const int MMSYSERR_LASTERROR = (MMSYSERR_BASE + 21);

        public const int CALLBACK_TYPEMASK = 0x00070000;

        public const int CALLBACK_NULL = 0x00000000;

        public const int CALLBACK_WINDOW = 0x00010000;

        public const int CALLBACK_TASK = 0x00020000;

        public const int CALLBACK_FUNCTION = 0x00030000;

        public const int CALLBACK_THREAD = (CALLBACK_TASK);

        public const int CALLBACK_EVENT = 0x00050000;

    }
}
