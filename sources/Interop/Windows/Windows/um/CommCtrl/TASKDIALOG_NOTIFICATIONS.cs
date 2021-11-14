// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum TASKDIALOG_NOTIFICATIONS
    {
        TDN_CREATED = 0,
        TDN_NAVIGATED = 1,
        TDN_BUTTON_CLICKED = 2,
        TDN_HYPERLINK_CLICKED = 3,
        TDN_TIMER = 4,
        TDN_DESTROYED = 5,
        TDN_RADIO_BUTTON_CLICKED = 6,
        TDN_DIALOG_CONSTRUCTED = 7,
        TDN_VERIFICATION_CLICKED = 8,
        TDN_HELP = 9,
        TDN_EXPANDO_BUTTON_CLICKED = 10,
    }
}
