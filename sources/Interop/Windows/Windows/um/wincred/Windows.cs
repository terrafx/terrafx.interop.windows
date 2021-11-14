// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredWriteW([NativeTypeName("PCREDENTIALW")] CREDENTIALW* Credential, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredWriteA([NativeTypeName("PCREDENTIALA")] CREDENTIALA* Credential, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredReadW([NativeTypeName("LPCWSTR")] ushort* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIALW *")] CREDENTIALW** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredReadA([NativeTypeName("LPCSTR")] sbyte* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIALA *")] CREDENTIALA** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredEnumerateW([NativeTypeName("LPCWSTR")] ushort* Filter, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD *")] uint* Count, [NativeTypeName("PCREDENTIALW **")] CREDENTIALW*** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredEnumerateA([NativeTypeName("LPCSTR")] sbyte* Filter, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD *")] uint* Count, [NativeTypeName("PCREDENTIALA **")] CREDENTIALA*** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredWriteDomainCredentialsW([NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONW")] CREDENTIAL_TARGET_INFORMATIONW* TargetInfo, [NativeTypeName("PCREDENTIALW")] CREDENTIALW* Credential, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredWriteDomainCredentialsA([NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONA")] CREDENTIAL_TARGET_INFORMATIONA* TargetInfo, [NativeTypeName("PCREDENTIALA")] CREDENTIALA* Credential, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredReadDomainCredentialsW([NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONW")] CREDENTIAL_TARGET_INFORMATIONW* TargetInfo, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD *")] uint* Count, [NativeTypeName("PCREDENTIALW **")] CREDENTIALW*** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredReadDomainCredentialsA([NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONA")] CREDENTIAL_TARGET_INFORMATIONA* TargetInfo, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD *")] uint* Count, [NativeTypeName("PCREDENTIALA **")] CREDENTIALA*** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredDeleteW([NativeTypeName("LPCWSTR")] ushort* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredDeleteA([NativeTypeName("LPCSTR")] sbyte* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredRenameW([NativeTypeName("LPCWSTR")] ushort* OldTargetName, [NativeTypeName("LPCWSTR")] ushort* NewTargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredRenameA([NativeTypeName("LPCSTR")] sbyte* OldTargetName, [NativeTypeName("LPCSTR")] sbyte* NewTargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredGetTargetInfoW([NativeTypeName("LPCWSTR")] ushort* TargetName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONW *")] CREDENTIAL_TARGET_INFORMATIONW** TargetInfo);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredGetTargetInfoA([NativeTypeName("LPCSTR")] sbyte* TargetName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONA *")] CREDENTIAL_TARGET_INFORMATIONA** TargetInfo);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredMarshalCredentialW(CRED_MARSHAL_TYPE CredType, [NativeTypeName("PVOID")] void* Credential, [NativeTypeName("LPWSTR *")] ushort** MarshaledCredential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredMarshalCredentialA(CRED_MARSHAL_TYPE CredType, [NativeTypeName("PVOID")] void* Credential, [NativeTypeName("LPSTR *")] sbyte** MarshaledCredential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredUnmarshalCredentialW([NativeTypeName("LPCWSTR")] ushort* MarshaledCredential, [NativeTypeName("PCRED_MARSHAL_TYPE")] CRED_MARSHAL_TYPE* CredType, [NativeTypeName("PVOID *")] void** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredUnmarshalCredentialA([NativeTypeName("LPCSTR")] sbyte* MarshaledCredential, [NativeTypeName("PCRED_MARSHAL_TYPE")] CRED_MARSHAL_TYPE* CredType, [NativeTypeName("PVOID *")] void** Credential);

        [DllImport("advapi32", ExactSpelling = true)]
        public static extern BOOL CredIsMarshaledCredentialW([NativeTypeName("LPCWSTR")] ushort* MarshaledCredential);

        [DllImport("advapi32", ExactSpelling = true)]
        public static extern BOOL CredIsMarshaledCredentialA([NativeTypeName("LPCSTR")] sbyte* MarshaledCredential);

        [DllImport("credui", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredUnPackAuthenticationBufferW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PVOID")] void* pAuthBuffer, [NativeTypeName("DWORD")] uint cbAuthBuffer, [NativeTypeName("LPWSTR")] ushort* pszUserName, [NativeTypeName("DWORD *")] uint* pcchMaxUserName, [NativeTypeName("LPWSTR")] ushort* pszDomainName, [NativeTypeName("DWORD *")] uint* pcchMaxDomainName, [NativeTypeName("LPWSTR")] ushort* pszPassword, [NativeTypeName("DWORD *")] uint* pcchMaxPassword);

        [DllImport("credui", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredUnPackAuthenticationBufferA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PVOID")] void* pAuthBuffer, [NativeTypeName("DWORD")] uint cbAuthBuffer, [NativeTypeName("LPSTR")] sbyte* pszUserName, [NativeTypeName("DWORD *")] uint* pcchlMaxUserName, [NativeTypeName("LPSTR")] sbyte* pszDomainName, [NativeTypeName("DWORD *")] uint* pcchMaxDomainName, [NativeTypeName("LPSTR")] sbyte* pszPassword, [NativeTypeName("DWORD *")] uint* pcchMaxPassword);

        [DllImport("credui", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredPackAuthenticationBufferW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszUserName, [NativeTypeName("LPWSTR")] ushort* pszPassword, [NativeTypeName("PBYTE")] byte* pPackedCredentials, [NativeTypeName("DWORD *")] uint* pcbPackedCredentials);

        [DllImport("credui", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredPackAuthenticationBufferA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* pszUserName, [NativeTypeName("LPSTR")] sbyte* pszPassword, [NativeTypeName("PBYTE")] byte* pPackedCredentials, [NativeTypeName("DWORD *")] uint* pcbPackedCredentials);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredProtectW(BOOL fAsSelf, [NativeTypeName("LPWSTR")] ushort* pszCredentials, [NativeTypeName("DWORD")] uint cchCredentials, [NativeTypeName("LPWSTR")] ushort* pszProtectedCredentials, [NativeTypeName("DWORD *")] uint* pcchMaxChars, CRED_PROTECTION_TYPE* ProtectionType);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredProtectA(BOOL fAsSelf, [NativeTypeName("LPSTR")] sbyte* pszCredentials, [NativeTypeName("DWORD")] uint cchCredentials, [NativeTypeName("LPSTR")] sbyte* pszProtectedCredentials, [NativeTypeName("DWORD *")] uint* pcchMaxChars, CRED_PROTECTION_TYPE* ProtectionType);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredUnprotectW(BOOL fAsSelf, [NativeTypeName("LPWSTR")] ushort* pszProtectedCredentials, [NativeTypeName("DWORD")] uint cchProtectedCredentials, [NativeTypeName("LPWSTR")] ushort* pszCredentials, [NativeTypeName("DWORD *")] uint* pcchMaxChars);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredUnprotectA(BOOL fAsSelf, [NativeTypeName("LPSTR")] sbyte* pszProtectedCredentials, [NativeTypeName("DWORD")] uint cchProtectedCredentials, [NativeTypeName("LPSTR")] sbyte* pszCredentials, [NativeTypeName("DWORD *")] uint* pcchMaxChars);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredIsProtectedW([NativeTypeName("LPWSTR")] ushort* pszProtectedCredentials, CRED_PROTECTION_TYPE* pProtectionType);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredIsProtectedA([NativeTypeName("LPSTR")] sbyte* pszProtectedCredentials, CRED_PROTECTION_TYPE* pProtectionType);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredFindBestCredentialW([NativeTypeName("LPCWSTR")] ushort* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIALW *")] CREDENTIALW** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredFindBestCredentialA([NativeTypeName("LPCSTR")] sbyte* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIALA *")] CREDENTIALA** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CredGetSessionTypes([NativeTypeName("DWORD")] uint MaximumPersistCount, [NativeTypeName("LPDWORD")] uint* MaximumPersist);

        [DllImport("advapi32", ExactSpelling = true)]
        public static extern void CredFree([NativeTypeName("PVOID")] void* Buffer);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIPromptForCredentialsW([NativeTypeName("PCREDUI_INFOW")] CREDUI_INFOW* pUiInfo, [NativeTypeName("PCWSTR")] ushort* pszTargetName, [NativeTypeName("PCtxtHandle")] SecHandle* pContext, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("PWSTR")] ushort* pszUserName, [NativeTypeName("ULONG")] uint ulUserNameBufferSize, [NativeTypeName("PWSTR")] ushort* pszPassword, [NativeTypeName("ULONG")] uint ulPasswordBufferSize, BOOL* save, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIPromptForCredentialsA([NativeTypeName("PCREDUI_INFOA")] CREDUI_INFOA* pUiInfo, [NativeTypeName("PCSTR")] sbyte* pszTargetName, [NativeTypeName("PCtxtHandle")] SecHandle* pContext, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("PSTR")] sbyte* pszUserName, [NativeTypeName("ULONG")] uint ulUserNameBufferSize, [NativeTypeName("PSTR")] sbyte* pszPassword, [NativeTypeName("ULONG")] uint ulPasswordBufferSize, BOOL* save, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIPromptForWindowsCredentialsW([NativeTypeName("PCREDUI_INFOW")] CREDUI_INFOW* pUiInfo, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("ULONG *")] uint* pulAuthPackage, [NativeTypeName("LPCVOID")] void* pvInAuthBuffer, [NativeTypeName("ULONG")] uint ulInAuthBufferSize, [NativeTypeName("LPVOID *")] void** ppvOutAuthBuffer, [NativeTypeName("ULONG *")] uint* pulOutAuthBufferSize, BOOL* pfSave, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIPromptForWindowsCredentialsA([NativeTypeName("PCREDUI_INFOA")] CREDUI_INFOA* pUiInfo, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("ULONG *")] uint* pulAuthPackage, [NativeTypeName("LPCVOID")] void* pvInAuthBuffer, [NativeTypeName("ULONG")] uint ulInAuthBufferSize, [NativeTypeName("LPVOID *")] void** ppvOutAuthBuffer, [NativeTypeName("ULONG *")] uint* pulOutAuthBufferSize, BOOL* pfSave, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIParseUserNameW([NativeTypeName("PCWSTR")] ushort* UserName, [NativeTypeName("WCHAR *")] ushort* user, [NativeTypeName("ULONG")] uint userBufferSize, [NativeTypeName("WCHAR *")] ushort* domain, [NativeTypeName("ULONG")] uint domainBufferSize);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIParseUserNameA([NativeTypeName("PCSTR")] sbyte* userName, [NativeTypeName("CHAR *")] sbyte* user, [NativeTypeName("ULONG")] uint userBufferSize, [NativeTypeName("CHAR *")] sbyte* domain, [NativeTypeName("ULONG")] uint domainBufferSize);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUICmdLinePromptForCredentialsW([NativeTypeName("PCWSTR")] ushort* pszTargetName, [NativeTypeName("PCtxtHandle")] SecHandle* pContext, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("PWSTR")] ushort* UserName, [NativeTypeName("ULONG")] uint ulUserBufferSize, [NativeTypeName("PWSTR")] ushort* pszPassword, [NativeTypeName("ULONG")] uint ulPasswordBufferSize, [NativeTypeName("PBOOL")] BOOL* pfSave, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUICmdLinePromptForCredentialsA([NativeTypeName("PCSTR")] sbyte* pszTargetName, [NativeTypeName("PCtxtHandle")] SecHandle* pContext, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("PSTR")] sbyte* UserName, [NativeTypeName("ULONG")] uint ulUserBufferSize, [NativeTypeName("PSTR")] sbyte* pszPassword, [NativeTypeName("ULONG")] uint ulPasswordBufferSize, [NativeTypeName("PBOOL")] BOOL* pfSave, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIConfirmCredentialsW([NativeTypeName("PCWSTR")] ushort* pszTargetName, BOOL bConfirm);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIConfirmCredentialsA([NativeTypeName("PCSTR")] sbyte* pszTargetName, BOOL bConfirm);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIStoreSSOCredW([NativeTypeName("PCWSTR")] ushort* pszRealm, [NativeTypeName("PCWSTR")] ushort* pszUsername, [NativeTypeName("PCWSTR")] ushort* pszPassword, BOOL bPersist);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIReadSSOCredW([NativeTypeName("PCWSTR")] ushort* pszRealm, [NativeTypeName("PWSTR *")] ushort** ppszUsername);

        [NativeTypeName("#define CREDUI_MAX_MESSAGE_LENGTH 1024")]
        public const int CREDUI_MAX_MESSAGE_LENGTH = 1024;

        [NativeTypeName("#define CREDUI_MAX_CAPTION_LENGTH 128")]
        public const int CREDUI_MAX_CAPTION_LENGTH = 128;

        [NativeTypeName("#define CREDUI_MAX_GENERIC_TARGET_LENGTH CRED_MAX_GENERIC_TARGET_NAME_LENGTH")]
        public const int CREDUI_MAX_GENERIC_TARGET_LENGTH = 32767;

        [NativeTypeName("#define CREDUI_MAX_DOMAIN_TARGET_LENGTH CRED_MAX_DOMAIN_TARGET_NAME_LENGTH")]
        public const int CREDUI_MAX_DOMAIN_TARGET_LENGTH = (256 + 1 + 80);

        [NativeTypeName("#define CREDUI_MAX_USERNAME_LENGTH CRED_MAX_USERNAME_LENGTH")]
        public const int CREDUI_MAX_USERNAME_LENGTH = (256 + 1 + 256);

        [NativeTypeName("#define CREDUI_MAX_PASSWORD_LENGTH (512 / 2)")]
        public const int CREDUI_MAX_PASSWORD_LENGTH = (512 / 2);

        [NativeTypeName("#define CREDUI_FLAGS_INCORRECT_PASSWORD 0x00001")]
        public const int CREDUI_FLAGS_INCORRECT_PASSWORD = 0x00001;

        [NativeTypeName("#define CREDUI_FLAGS_DO_NOT_PERSIST 0x00002")]
        public const int CREDUI_FLAGS_DO_NOT_PERSIST = 0x00002;

        [NativeTypeName("#define CREDUI_FLAGS_REQUEST_ADMINISTRATOR 0x00004")]
        public const int CREDUI_FLAGS_REQUEST_ADMINISTRATOR = 0x00004;

        [NativeTypeName("#define CREDUI_FLAGS_EXCLUDE_CERTIFICATES 0x00008")]
        public const int CREDUI_FLAGS_EXCLUDE_CERTIFICATES = 0x00008;

        [NativeTypeName("#define CREDUI_FLAGS_REQUIRE_CERTIFICATE 0x00010")]
        public const int CREDUI_FLAGS_REQUIRE_CERTIFICATE = 0x00010;

        [NativeTypeName("#define CREDUI_FLAGS_SHOW_SAVE_CHECK_BOX 0x00040")]
        public const int CREDUI_FLAGS_SHOW_SAVE_CHECK_BOX = 0x00040;

        [NativeTypeName("#define CREDUI_FLAGS_ALWAYS_SHOW_UI 0x00080")]
        public const int CREDUI_FLAGS_ALWAYS_SHOW_UI = 0x00080;

        [NativeTypeName("#define CREDUI_FLAGS_REQUIRE_SMARTCARD 0x00100")]
        public const int CREDUI_FLAGS_REQUIRE_SMARTCARD = 0x00100;

        [NativeTypeName("#define CREDUI_FLAGS_PASSWORD_ONLY_OK 0x00200")]
        public const int CREDUI_FLAGS_PASSWORD_ONLY_OK = 0x00200;

        [NativeTypeName("#define CREDUI_FLAGS_VALIDATE_USERNAME 0x00400")]
        public const int CREDUI_FLAGS_VALIDATE_USERNAME = 0x00400;

        [NativeTypeName("#define CREDUI_FLAGS_COMPLETE_USERNAME 0x00800")]
        public const int CREDUI_FLAGS_COMPLETE_USERNAME = 0x00800;

        [NativeTypeName("#define CREDUI_FLAGS_PERSIST 0x01000")]
        public const int CREDUI_FLAGS_PERSIST = 0x01000;

        [NativeTypeName("#define CREDUI_FLAGS_SERVER_CREDENTIAL 0x04000")]
        public const int CREDUI_FLAGS_SERVER_CREDENTIAL = 0x04000;

        [NativeTypeName("#define CREDUI_FLAGS_EXPECT_CONFIRMATION 0x20000")]
        public const int CREDUI_FLAGS_EXPECT_CONFIRMATION = 0x20000;

        [NativeTypeName("#define CREDUI_FLAGS_GENERIC_CREDENTIALS 0x40000")]
        public const int CREDUI_FLAGS_GENERIC_CREDENTIALS = 0x40000;

        [NativeTypeName("#define CREDUI_FLAGS_USERNAME_TARGET_CREDENTIALS 0x80000")]
        public const int CREDUI_FLAGS_USERNAME_TARGET_CREDENTIALS = 0x80000;

        [NativeTypeName("#define CREDUI_FLAGS_KEEP_USERNAME 0x100000")]
        public const int CREDUI_FLAGS_KEEP_USERNAME = 0x100000;

        [NativeTypeName("#define CREDUI_FLAGS_PROMPT_VALID ( \\\r\n        CREDUI_FLAGS_INCORRECT_PASSWORD | \\\r\n        CREDUI_FLAGS_DO_NOT_PERSIST | \\\r\n        CREDUI_FLAGS_REQUEST_ADMINISTRATOR | \\\r\n        CREDUI_FLAGS_EXCLUDE_CERTIFICATES | \\\r\n        CREDUI_FLAGS_REQUIRE_CERTIFICATE | \\\r\n        CREDUI_FLAGS_SHOW_SAVE_CHECK_BOX | \\\r\n        CREDUI_FLAGS_ALWAYS_SHOW_UI | \\\r\n        CREDUI_FLAGS_REQUIRE_SMARTCARD | \\\r\n        CREDUI_FLAGS_PASSWORD_ONLY_OK | \\\r\n        CREDUI_FLAGS_VALIDATE_USERNAME | \\\r\n        CREDUI_FLAGS_COMPLETE_USERNAME | \\\r\n        CREDUI_FLAGS_PERSIST | \\\r\n        CREDUI_FLAGS_SERVER_CREDENTIAL | \\\r\n        CREDUI_FLAGS_EXPECT_CONFIRMATION | \\\r\n        CREDUI_FLAGS_GENERIC_CREDENTIALS | \\\r\n        CREDUI_FLAGS_USERNAME_TARGET_CREDENTIALS | \\\r\n        CREDUI_FLAGS_KEEP_USERNAME )")]
        public const int CREDUI_FLAGS_PROMPT_VALID = (0x00001 | 0x00002 | 0x00004 | 0x00008 | 0x00010 | 0x00040 | 0x00080 | 0x00100 | 0x00200 | 0x00400 | 0x00800 | 0x01000 | 0x04000 | 0x20000 | 0x40000 | 0x80000 | 0x100000);

        [NativeTypeName("#define CREDUIWIN_GENERIC 0x00000001")]
        public const int CREDUIWIN_GENERIC = 0x00000001;

        [NativeTypeName("#define CREDUIWIN_CHECKBOX 0x00000002")]
        public const int CREDUIWIN_CHECKBOX = 0x00000002;

        [NativeTypeName("#define CREDUIWIN_AUTHPACKAGE_ONLY 0x00000010")]
        public const int CREDUIWIN_AUTHPACKAGE_ONLY = 0x00000010;

        [NativeTypeName("#define CREDUIWIN_IN_CRED_ONLY 0x00000020")]
        public const int CREDUIWIN_IN_CRED_ONLY = 0x00000020;

        [NativeTypeName("#define CREDUIWIN_ENUMERATE_ADMINS 0x00000100")]
        public const int CREDUIWIN_ENUMERATE_ADMINS = 0x00000100;

        [NativeTypeName("#define CREDUIWIN_ENUMERATE_CURRENT_USER 0x00000200")]
        public const int CREDUIWIN_ENUMERATE_CURRENT_USER = 0x00000200;

        [NativeTypeName("#define CREDUIWIN_SECURE_PROMPT 0x00001000")]
        public const int CREDUIWIN_SECURE_PROMPT = 0x00001000;

        [NativeTypeName("#define CREDUIWIN_PREPROMPTING 0X00002000")]
        public const int CREDUIWIN_PREPROMPTING = 0X00002000;

        [NativeTypeName("#define CREDUIWIN_PACK_32_WOW 0x10000000")]
        public const int CREDUIWIN_PACK_32_WOW = 0x10000000;

        [NativeTypeName("#define CREDUIWIN_IGNORE_CLOUDAUTHORITY_NAME 0x00040000")]
        public const int CREDUIWIN_IGNORE_CLOUDAUTHORITY_NAME = 0x00040000;

        [NativeTypeName("#define CREDUIWIN_DOWNLEVEL_HELLO_AS_SMART_CARD 0x80000000")]
        public const uint CREDUIWIN_DOWNLEVEL_HELLO_AS_SMART_CARD = 0x80000000;

        [NativeTypeName("#define CREDUIWIN_VALID_FLAGS ( \\\r\n        CREDUIWIN_GENERIC                | \\\r\n        CREDUIWIN_CHECKBOX               | \\\r\n        CREDUIWIN_AUTHPACKAGE_ONLY       | \\\r\n        CREDUIWIN_IN_CRED_ONLY           | \\\r\n        CREDUIWIN_ENUMERATE_ADMINS       | \\\r\n        CREDUIWIN_ENUMERATE_CURRENT_USER | \\\r\n        CREDUIWIN_SECURE_PROMPT          | \\\r\n        CREDUIWIN_PREPROMPTING           | \\\r\n        CREDUIWIN_PACK_32_WOW            | \\\r\n        CREDUIWIN_IGNORE_CLOUDAUTHORITY_NAME    | \\\r\n        CREDUIWIN_DOWNLEVEL_HELLO_AS_SMART_CARD )")]
        public const uint CREDUIWIN_VALID_FLAGS = (0x00000001 | 0x00000002 | 0x00000010 | 0x00000020 | 0x00000100 | 0x00000200 | 0x00001000 | 0X00002000 | 0x10000000 | 0x00040000 | 0x80000000);

        [NativeTypeName("#define CredWrite CredWriteW")]
        public static delegate*<CREDENTIALW*, uint, BOOL> CredWrite => &CredWriteW;

        [NativeTypeName("#define CredRead CredReadW")]
        public static delegate*<ushort*, uint, uint, CREDENTIALW**, BOOL> CredRead => &CredReadW;

        [NativeTypeName("#define CredEnumerate CredEnumerateW")]
        public static delegate*<ushort*, uint, uint*, CREDENTIALW***, BOOL> CredEnumerate => &CredEnumerateW;

        [NativeTypeName("#define CredWriteDomainCredentials CredWriteDomainCredentialsW")]
        public static delegate*<CREDENTIAL_TARGET_INFORMATIONW*, CREDENTIALW*, uint, BOOL> CredWriteDomainCredentials => &CredWriteDomainCredentialsW;

        [NativeTypeName("#define CredReadDomainCredentials CredReadDomainCredentialsW")]
        public static delegate*<CREDENTIAL_TARGET_INFORMATIONW*, uint, uint*, CREDENTIALW***, BOOL> CredReadDomainCredentials => &CredReadDomainCredentialsW;

        [NativeTypeName("#define CredDelete CredDeleteW")]
        public static delegate*<ushort*, uint, uint, BOOL> CredDelete => &CredDeleteW;

        [NativeTypeName("#define CredRename CredRenameW")]
        public static delegate*<ushort*, ushort*, uint, uint, BOOL> CredRename => &CredRenameW;

        [NativeTypeName("#define CredGetTargetInfo CredGetTargetInfoW")]
        public static delegate*<ushort*, uint, CREDENTIAL_TARGET_INFORMATIONW**, BOOL> CredGetTargetInfo => &CredGetTargetInfoW;

        [NativeTypeName("#define CredMarshalCredential CredMarshalCredentialW")]
        public static delegate*<CRED_MARSHAL_TYPE, void*, ushort**, BOOL> CredMarshalCredential => &CredMarshalCredentialW;

        [NativeTypeName("#define CredUnmarshalCredential CredUnmarshalCredentialW")]
        public static delegate*<ushort*, CRED_MARSHAL_TYPE*, void**, BOOL> CredUnmarshalCredential => &CredUnmarshalCredentialW;

        [NativeTypeName("#define CredIsMarshaledCredential CredIsMarshaledCredentialW")]
        public static delegate*<ushort*, BOOL> CredIsMarshaledCredential => &CredIsMarshaledCredentialW;

        [NativeTypeName("#define CredUnPackAuthenticationBuffer CredUnPackAuthenticationBufferW")]
        public static delegate*<uint, void*, uint, ushort*, uint*, ushort*, uint*, ushort*, uint*, BOOL> CredUnPackAuthenticationBuffer => &CredUnPackAuthenticationBufferW;

        [NativeTypeName("#define CredPackAuthenticationBuffer CredPackAuthenticationBufferW")]
        public static delegate*<uint, ushort*, ushort*, byte*, uint*, BOOL> CredPackAuthenticationBuffer => &CredPackAuthenticationBufferW;

        [NativeTypeName("#define CredProtect CredProtectW")]
        public static delegate*<BOOL, ushort*, uint, ushort*, uint*, CRED_PROTECTION_TYPE*, BOOL> CredProtect => &CredProtectW;

        [NativeTypeName("#define CredUnprotect CredUnprotectW")]
        public static delegate*<BOOL, ushort*, uint, ushort*, uint*, BOOL> CredUnprotect => &CredUnprotectW;

        [NativeTypeName("#define CredIsProtected CredIsProtectedW")]
        public static delegate*<ushort*, CRED_PROTECTION_TYPE*, BOOL> CredIsProtected => &CredIsProtectedW;

        [NativeTypeName("#define CredFindBestCredential CredFindBestCredentialW")]
        public static delegate*<ushort*, uint, uint, CREDENTIALW**, BOOL> CredFindBestCredential => &CredFindBestCredentialW;

        [NativeTypeName("#define CredUIPromptForCredentials CredUIPromptForCredentialsW")]
        public static delegate*<CREDUI_INFOW*, ushort*, SecHandle*, uint, ushort*, uint, ushort*, uint, BOOL*, uint, uint> CredUIPromptForCredentials => &CredUIPromptForCredentialsW;

        [NativeTypeName("#define CredUIPromptForWindowsCredentials CredUIPromptForWindowsCredentialsW")]
        public static delegate*<CREDUI_INFOW*, uint, uint*, void*, uint, void**, uint*, BOOL*, uint, uint> CredUIPromptForWindowsCredentials => &CredUIPromptForWindowsCredentialsW;

        [NativeTypeName("#define CredUIParseUserName CredUIParseUserNameW")]
        public static delegate*<ushort*, ushort*, uint, ushort*, uint, uint> CredUIParseUserName => &CredUIParseUserNameW;

        [NativeTypeName("#define CredUICmdLinePromptForCredentials CredUICmdLinePromptForCredentialsW")]
        public static delegate*<ushort*, SecHandle*, uint, ushort*, uint, ushort*, uint, BOOL*, uint, uint> CredUICmdLinePromptForCredentials => &CredUICmdLinePromptForCredentialsW;

        [NativeTypeName("#define CredUIConfirmCredentials CredUIConfirmCredentialsW")]
        public static delegate*<ushort*, BOOL, uint> CredUIConfirmCredentials => &CredUIConfirmCredentialsW;
    }
}
