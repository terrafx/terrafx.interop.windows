// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/libloaderapi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Kernel32
    {
        public const int FIND_RESOURCE_DIRECTORY_TYPES = 0x0100;

        public const int FIND_RESOURCE_DIRECTORY_NAMES = 0x0200;

        public const int FIND_RESOURCE_DIRECTORY_LANGUAGES = 0x0400;

        public const int RESOURCE_ENUM_LN = 0x0001;

        public const int RESOURCE_ENUM_MUI = 0x0002;

        public const int RESOURCE_ENUM_MUI_SYSTEM = 0x0004;

        public const int RESOURCE_ENUM_VALIDATE = 0x0008;

        public const int RESOURCE_ENUM_MODULE_EXACT = 0x0010;

        public const int SUPPORT_LANG_NUMBER = 32;

        public const int GET_MODULE_HANDLE_EX_FLAG_PIN = 0x00000001;

        public const int GET_MODULE_HANDLE_EX_FLAG_UNCHANGED_REFCOUNT = 0x00000002;

        public const int GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS = 0x00000004;

        public const int CURRENT_IMPORT_REDIRECTION_VERSION = 1;

        public const int DONT_RESOLVE_DLL_REFERENCES = 0x00000001;

        public const int LOAD_LIBRARY_AS_DATAFILE = 0x00000002;

        public const int LOAD_WITH_ALTERED_SEARCH_PATH = 0x00000008;

        public const int LOAD_IGNORE_CODE_AUTHZ_LEVEL = 0x00000010;

        public const int LOAD_LIBRARY_AS_IMAGE_RESOURCE = 0x00000020;

        public const int LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 0x00000040;

        public const int LOAD_LIBRARY_REQUIRE_SIGNED_TARGET = 0x00000080;

        public const int LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR = 0x00000100;

        public const int LOAD_LIBRARY_SEARCH_APPLICATION_DIR = 0x00000200;

        public const int LOAD_LIBRARY_SEARCH_USER_DIRS = 0x00000400;

        public const int LOAD_LIBRARY_SEARCH_SYSTEM32 = 0x00000800;

        public const int LOAD_LIBRARY_SEARCH_DEFAULT_DIRS = 0x00001000;

        public const int LOAD_LIBRARY_SAFE_CURRENT_DIRS = 0x00002000;

        public const int LOAD_LIBRARY_SEARCH_SYSTEM32_NO_FORWARDER = 0x00004000;

        public const int LOAD_LIBRARY_OS_INTEGRITY_CONTINUITY = 0x00008000;
    }
}
