// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct NONCLIENTMETRICSA
    {
        public uint cbSize;

        public int iBorderWidth;

        public int iScrollWidth;

        public int iScrollHeight;

        public int iCaptionWidth;

        public int iCaptionHeight;

        public LOGFONTA lfCaptionFont;

        public int iSmCaptionWidth;

        public int iSmCaptionHeight;

        public LOGFONTA lfSmCaptionFont;

        public int iMenuWidth;

        public int iMenuHeight;

        public LOGFONTA lfMenuFont;

        public LOGFONTA lfStatusFont;

        public LOGFONTA lfMessageFont;

        public int iPaddedBorderWidth;
    }
}
