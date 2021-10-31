// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gamingtcui.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowGameInviteUI([NativeTypeName("HSTRING")] IntPtr serviceConfigurationId, [NativeTypeName("HSTRING")] IntPtr sessionTemplateName, [NativeTypeName("HSTRING")] IntPtr sessionId, [NativeTypeName("HSTRING")] IntPtr invitationDisplayText, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowPlayerPickerUI([NativeTypeName("HSTRING")] IntPtr promptDisplayText, [NativeTypeName("const HSTRING *")] IntPtr* xuids, [NativeTypeName("size_t")] nuint xuidsCount, [NativeTypeName("const HSTRING *")] IntPtr* preSelectedXuids, [NativeTypeName("size_t")] nuint preSelectedXuidsCount, [NativeTypeName("size_t")] nuint minSelectionCount, [NativeTypeName("size_t")] nuint maxSelectionCount, [NativeTypeName("PlayerPickerUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, IntPtr*, nuint, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowProfileCardUI([NativeTypeName("HSTRING")] IntPtr targetUserXuid, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowChangeFriendRelationshipUI([NativeTypeName("HSTRING")] IntPtr targetUserXuid, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowTitleAchievementsUI([NativeTypeName("UINT32")] uint titleId, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ProcessPendingGameUI(BOOL waitForCompletion);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern BOOL TryCancelPendingGameUI();

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT CheckGamingPrivilegeWithUI([NativeTypeName("UINT32")] uint privilegeId, [NativeTypeName("HSTRING")] IntPtr scope, [NativeTypeName("HSTRING")] IntPtr policy, [NativeTypeName("HSTRING")] IntPtr friendlyMessage, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT CheckGamingPrivilegeSilently([NativeTypeName("UINT32")] uint privilegeId, [NativeTypeName("HSTRING")] IntPtr scope, [NativeTypeName("HSTRING")] IntPtr policy, BOOL* hasPrivilege);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowGameInviteUIForUser(IInspectable* user, [NativeTypeName("HSTRING")] IntPtr serviceConfigurationId, [NativeTypeName("HSTRING")] IntPtr sessionTemplateName, [NativeTypeName("HSTRING")] IntPtr sessionId, [NativeTypeName("HSTRING")] IntPtr invitationDisplayText, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowPlayerPickerUIForUser(IInspectable* user, [NativeTypeName("HSTRING")] IntPtr promptDisplayText, [NativeTypeName("const HSTRING *")] IntPtr* xuids, [NativeTypeName("size_t")] nuint xuidsCount, [NativeTypeName("const HSTRING *")] IntPtr* preSelectedXuids, [NativeTypeName("size_t")] nuint preSelectedXuidsCount, [NativeTypeName("size_t")] nuint minSelectionCount, [NativeTypeName("size_t")] nuint maxSelectionCount, [NativeTypeName("PlayerPickerUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, IntPtr*, nuint, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowProfileCardUIForUser(IInspectable* user, [NativeTypeName("HSTRING")] IntPtr targetUserXuid, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowChangeFriendRelationshipUIForUser(IInspectable* user, [NativeTypeName("HSTRING")] IntPtr targetUserXuid, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowTitleAchievementsUIForUser(IInspectable* user, [NativeTypeName("UINT32")] uint titleId, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT CheckGamingPrivilegeWithUIForUser(IInspectable* user, [NativeTypeName("UINT32")] uint privilegeId, [NativeTypeName("HSTRING")] IntPtr scope, [NativeTypeName("HSTRING")] IntPtr policy, [NativeTypeName("HSTRING")] IntPtr friendlyMessage, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT CheckGamingPrivilegeSilentlyForUser(IInspectable* user, [NativeTypeName("UINT32")] uint privilegeId, [NativeTypeName("HSTRING")] IntPtr scope, [NativeTypeName("HSTRING")] IntPtr policy, BOOL* hasPrivilege);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowGameInviteUIWithContext([NativeTypeName("HSTRING")] IntPtr serviceConfigurationId, [NativeTypeName("HSTRING")] IntPtr sessionTemplateName, [NativeTypeName("HSTRING")] IntPtr sessionId, [NativeTypeName("HSTRING")] IntPtr invitationDisplayText, [NativeTypeName("HSTRING")] IntPtr customActivationContext, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowGameInviteUIWithContextForUser(IInspectable* user, [NativeTypeName("HSTRING")] IntPtr serviceConfigurationId, [NativeTypeName("HSTRING")] IntPtr sessionTemplateName, [NativeTypeName("HSTRING")] IntPtr sessionId, [NativeTypeName("HSTRING")] IntPtr invitationDisplayText, [NativeTypeName("HSTRING")] IntPtr customActivationContext, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowGameInfoUI([NativeTypeName("UINT32")] uint titleId, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowGameInfoUIForUser(IInspectable* user, [NativeTypeName("UINT32")] uint titleId, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowFindFriendsUI([NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowFindFriendsUIForUser(IInspectable* user, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowCustomizeUserProfileUI([NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowCustomizeUserProfileUIForUser(IInspectable* user, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowUserSettingsUI([NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        public static extern HRESULT ShowUserSettingsUIForUser(IInspectable* user, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<HRESULT, void*, void> completionRoutine, void* context);
    }
}
