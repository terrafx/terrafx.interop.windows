// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetCurrentPackageId([NativeTypeName("UINT32 *")] uint* bufferLength, [NativeTypeName("BYTE *")] byte* buffer);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetCurrentPackageFullName([NativeTypeName("UINT32 *")] uint* packageFullNameLength, [NativeTypeName("PWSTR")] ushort* packageFullName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetCurrentPackageFamilyName([NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetCurrentPackagePath([NativeTypeName("UINT32 *")] uint* pathLength, [NativeTypeName("PWSTR")] ushort* path);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackageId([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("UINT32 *")] uint* bufferLength, [NativeTypeName("BYTE *")] byte* buffer);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackageFullName([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("UINT32 *")] uint* packageFullNameLength, [NativeTypeName("PWSTR")] ushort* packageFullName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackageFullNameFromToken([NativeTypeName("HANDLE")] IntPtr token, [NativeTypeName("UINT32 *")] uint* packageFullNameLength, [NativeTypeName("PWSTR")] ushort* packageFullName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackageFamilyName([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackageFamilyNameFromToken([NativeTypeName("HANDLE")] IntPtr token, [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackagePath([NativeTypeName("const PACKAGE_ID *")] PACKAGE_ID* packageId, [NativeTypeName("const UINT32")] uint reserved, [NativeTypeName("UINT32 *")] uint* pathLength, [NativeTypeName("PWSTR")] ushort* path);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackagePathByFullName([NativeTypeName("PCWSTR")] ushort* packageFullName, [NativeTypeName("UINT32 *")] uint* pathLength, [NativeTypeName("PWSTR")] ushort* path);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetStagedPackagePathByFullName([NativeTypeName("PCWSTR")] ushort* packageFullName, [NativeTypeName("UINT32 *")] uint* pathLength, [NativeTypeName("PWSTR")] ushort* path);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackagePathByFullName2([NativeTypeName("PCWSTR")] ushort* packageFullName, PackagePathType packagePathType, [NativeTypeName("UINT32 *")] uint* pathLength, [NativeTypeName("PWSTR")] ushort* path);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetStagedPackagePathByFullName2([NativeTypeName("PCWSTR")] ushort* packageFullName, PackagePathType packagePathType, [NativeTypeName("UINT32 *")] uint* pathLength, [NativeTypeName("PWSTR")] ushort* path);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetCurrentPackageInfo2([NativeTypeName("const UINT32")] uint flags, PackagePathType packagePathType, [NativeTypeName("UINT32 *")] uint* bufferLength, [NativeTypeName("BYTE *")] byte* buffer, [NativeTypeName("UINT32 *")] uint* count);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetCurrentPackagePath2(PackagePathType packagePathType, [NativeTypeName("UINT32 *")] uint* pathLength, [NativeTypeName("PWSTR")] ushort* path);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetCurrentApplicationUserModelId([NativeTypeName("UINT32 *")] uint* applicationUserModelIdLength, [NativeTypeName("PWSTR")] ushort* applicationUserModelId);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetApplicationUserModelId([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("UINT32 *")] uint* applicationUserModelIdLength, [NativeTypeName("PWSTR")] ushort* applicationUserModelId);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetApplicationUserModelIdFromToken([NativeTypeName("HANDLE")] IntPtr token, [NativeTypeName("UINT32 *")] uint* applicationUserModelIdLength, [NativeTypeName("PWSTR")] ushort* applicationUserModelId);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int VerifyPackageFullName([NativeTypeName("PCWSTR")] ushort* packageFullName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int VerifyPackageFamilyName([NativeTypeName("PCWSTR")] ushort* packageFamilyName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int VerifyPackageId([NativeTypeName("const PACKAGE_ID *")] PACKAGE_ID* packageId);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int VerifyApplicationUserModelId([NativeTypeName("PCWSTR")] ushort* applicationUserModelId);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int VerifyPackageRelativeApplicationId([NativeTypeName("PCWSTR")] ushort* packageRelativeApplicationId);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int PackageIdFromFullName([NativeTypeName("PCWSTR")] ushort* packageFullName, [NativeTypeName("const UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* bufferLength, [NativeTypeName("BYTE *")] byte* buffer);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int PackageFullNameFromId([NativeTypeName("const PACKAGE_ID *")] PACKAGE_ID* packageId, [NativeTypeName("UINT32 *")] uint* packageFullNameLength, [NativeTypeName("PWSTR")] ushort* packageFullName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int PackageFamilyNameFromId([NativeTypeName("const PACKAGE_ID *")] PACKAGE_ID* packageId, [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int PackageFamilyNameFromFullName([NativeTypeName("PCWSTR")] ushort* packageFullName, [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int PackageNameAndPublisherIdFromFamilyName([NativeTypeName("PCWSTR")] ushort* packageFamilyName, [NativeTypeName("UINT32 *")] uint* packageNameLength, [NativeTypeName("PWSTR")] ushort* packageName, [NativeTypeName("UINT32 *")] uint* packagePublisherIdLength, [NativeTypeName("PWSTR")] ushort* packagePublisherId);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int FormatApplicationUserModelId([NativeTypeName("PCWSTR")] ushort* packageFamilyName, [NativeTypeName("PCWSTR")] ushort* packageRelativeApplicationId, [NativeTypeName("UINT32 *")] uint* applicationUserModelIdLength, [NativeTypeName("PWSTR")] ushort* applicationUserModelId);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ParseApplicationUserModelId([NativeTypeName("PCWSTR")] ushort* applicationUserModelId, [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName, [NativeTypeName("UINT32 *")] uint* packageRelativeApplicationIdLength, [NativeTypeName("PWSTR")] ushort* packageRelativeApplicationId);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackagesByPackageFamily([NativeTypeName("PCWSTR")] ushort* packageFamilyName, [NativeTypeName("UINT32 *")] uint* count, [NativeTypeName("PWSTR *")] ushort** packageFullNames, [NativeTypeName("UINT32 *")] uint* bufferLength, [NativeTypeName("WCHAR *")] ushort* buffer);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int FindPackagesByPackageFamily([NativeTypeName("PCWSTR")] ushort* packageFamilyName, [NativeTypeName("UINT32")] uint packageFilters, [NativeTypeName("UINT32 *")] uint* count, [NativeTypeName("PWSTR *")] ushort** packageFullNames, [NativeTypeName("UINT32 *")] uint* bufferLength, [NativeTypeName("WCHAR *")] ushort* buffer, [NativeTypeName("UINT32 *")] uint* packageProperties);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetStagedPackageOrigin([NativeTypeName("PCWSTR")] ushort* packageFullName, PackageOrigin* origin);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetCurrentPackageInfo([NativeTypeName("const UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* bufferLength, [NativeTypeName("BYTE *")] byte* buffer, [NativeTypeName("UINT32 *")] uint* count);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int OpenPackageInfoByFullName([NativeTypeName("PCWSTR")] ushort* packageFullName, [NativeTypeName("const UINT32")] uint reserved, [NativeTypeName("PACKAGE_INFO_REFERENCE *")] PACKAGE_INFO_REFERENCE** packageInfoReference);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int OpenPackageInfoByFullNameForUser([NativeTypeName("PSID")] void* userSid, [NativeTypeName("PCWSTR")] ushort* packageFullName, [NativeTypeName("const UINT32")] uint reserved, [NativeTypeName("PACKAGE_INFO_REFERENCE *")] PACKAGE_INFO_REFERENCE** packageInfoReference);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ClosePackageInfo([NativeTypeName("PACKAGE_INFO_REFERENCE")] PACKAGE_INFO_REFERENCE* packageInfoReference);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackageInfo([NativeTypeName("PACKAGE_INFO_REFERENCE")] PACKAGE_INFO_REFERENCE* packageInfoReference, [NativeTypeName("const UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* bufferLength, [NativeTypeName("BYTE *")] byte* buffer, [NativeTypeName("UINT32 *")] uint* count);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackageApplicationIds([NativeTypeName("PACKAGE_INFO_REFERENCE")] PACKAGE_INFO_REFERENCE* packageInfoReference, [NativeTypeName("UINT32 *")] uint* bufferLength, [NativeTypeName("BYTE *")] byte* buffer, [NativeTypeName("UINT32 *")] uint* count);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int AppPolicyGetLifecycleManagement([NativeTypeName("HANDLE")] IntPtr processToken, AppPolicyLifecycleManagement* policy);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int AppPolicyGetWindowingModel([NativeTypeName("HANDLE")] IntPtr processToken, AppPolicyWindowingModel* policy);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int AppPolicyGetMediaFoundationCodecLoading([NativeTypeName("HANDLE")] IntPtr processToken, AppPolicyMediaFoundationCodecLoading* policy);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int AppPolicyGetClrCompat([NativeTypeName("HANDLE")] IntPtr processToken, AppPolicyClrCompat* policy);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int AppPolicyGetThreadInitializationType([NativeTypeName("HANDLE")] IntPtr processToken, AppPolicyThreadInitializationType* policy);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int AppPolicyGetShowDeveloperDiagnostic([NativeTypeName("HANDLE")] IntPtr processToken, AppPolicyShowDeveloperDiagnostic* policy);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int AppPolicyGetProcessTerminationMethod([NativeTypeName("HANDLE")] IntPtr processToken, AppPolicyProcessTerminationMethod* policy);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int AppPolicyGetCreateFileAccess([NativeTypeName("HANDLE")] IntPtr processToken, AppPolicyCreateFileAccess* policy);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackageInfo2([NativeTypeName("PACKAGE_INFO_REFERENCE")] PACKAGE_INFO_REFERENCE* packageInfoReference, [NativeTypeName("const UINT32")] uint flags, PackagePathType packagePathType, [NativeTypeName("UINT32 *")] uint* bufferLength, [NativeTypeName("BYTE *")] byte* buffer, [NativeTypeName("UINT32 *")] uint* count);

        [NativeTypeName("#define PACKAGE_PROPERTY_FRAMEWORK 0x00000001")]
        public const int PACKAGE_PROPERTY_FRAMEWORK = 0x00000001;

        [NativeTypeName("#define PACKAGE_PROPERTY_RESOURCE 0x00000002")]
        public const int PACKAGE_PROPERTY_RESOURCE = 0x00000002;

        [NativeTypeName("#define PACKAGE_PROPERTY_BUNDLE 0x00000004")]
        public const int PACKAGE_PROPERTY_BUNDLE = 0x00000004;

        [NativeTypeName("#define PACKAGE_PROPERTY_OPTIONAL 0x00000008")]
        public const int PACKAGE_PROPERTY_OPTIONAL = 0x00000008;

        [NativeTypeName("#define PACKAGE_FILTER_HEAD 0x00000010")]
        public const int PACKAGE_FILTER_HEAD = 0x00000010;

        [NativeTypeName("#define PACKAGE_FILTER_DIRECT 0x00000020")]
        public const int PACKAGE_FILTER_DIRECT = 0x00000020;

        [NativeTypeName("#define PACKAGE_FILTER_RESOURCE 0x00000040")]
        public const int PACKAGE_FILTER_RESOURCE = 0x00000040;

        [NativeTypeName("#define PACKAGE_FILTER_BUNDLE 0x00000080")]
        public const int PACKAGE_FILTER_BUNDLE = 0x00000080;

        [NativeTypeName("#define PACKAGE_INFORMATION_BASIC 0x00000000")]
        public const int PACKAGE_INFORMATION_BASIC = 0x00000000;

        [NativeTypeName("#define PACKAGE_INFORMATION_FULL 0x00000100")]
        public const int PACKAGE_INFORMATION_FULL = 0x00000100;

        [NativeTypeName("#define PACKAGE_PROPERTY_DEVELOPMENT_MODE 0x00010000")]
        public const int PACKAGE_PROPERTY_DEVELOPMENT_MODE = 0x00010000;

        [NativeTypeName("#define PACKAGE_FILTER_OPTIONAL 0x00020000")]
        public const int PACKAGE_FILTER_OPTIONAL = 0x00020000;

        [NativeTypeName("#define PACKAGE_PROPERTY_IS_IN_RELATED_SET 0x00040000")]
        public const int PACKAGE_PROPERTY_IS_IN_RELATED_SET = 0x00040000;

        [NativeTypeName("#define PACKAGE_FILTER_IS_IN_RELATED_SET PACKAGE_PROPERTY_IS_IN_RELATED_SET")]
        public const int PACKAGE_FILTER_IS_IN_RELATED_SET = 0x00040000;

        [NativeTypeName("#define PACKAGE_PROPERTY_STATIC 0x00080000")]
        public const int PACKAGE_PROPERTY_STATIC = 0x00080000;

        [NativeTypeName("#define PACKAGE_FILTER_STATIC PACKAGE_PROPERTY_STATIC")]
        public const int PACKAGE_FILTER_STATIC = 0x00080000;

        [NativeTypeName("#define PACKAGE_PROPERTY_DYNAMIC 0x00100000")]
        public const int PACKAGE_PROPERTY_DYNAMIC = 0x00100000;

        [NativeTypeName("#define PACKAGE_FILTER_DYNAMIC PACKAGE_PROPERTY_DYNAMIC")]
        public const int PACKAGE_FILTER_DYNAMIC = 0x00100000;

        [NativeTypeName("#define PACKAGE_FILTER_ALL_LOADED 0")]
        public const int PACKAGE_FILTER_ALL_LOADED = 0;
    }
}
