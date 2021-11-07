// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetCurrentPackageId([NativeTypeName("UINT32 *")] uint* bufferLength, byte* buffer);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetCurrentPackageFullName([NativeTypeName("UINT32 *")] uint* packageFullNameLength, [NativeTypeName("PWSTR")] ushort* packageFullName);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetCurrentPackageFamilyName([NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetCurrentPackagePath([NativeTypeName("UINT32 *")] uint* pathLength, [NativeTypeName("PWSTR")] ushort* path);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackageId(HANDLE hProcess, [NativeTypeName("UINT32 *")] uint* bufferLength, byte* buffer);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackageFullName(HANDLE hProcess, [NativeTypeName("UINT32 *")] uint* packageFullNameLength, [NativeTypeName("PWSTR")] ushort* packageFullName);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernelbase", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackageFullNameFromToken(HANDLE token, [NativeTypeName("UINT32 *")] uint* packageFullNameLength, [NativeTypeName("PWSTR")] ushort* packageFullName);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackageFamilyName(HANDLE hProcess, [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernelbase", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackageFamilyNameFromToken(HANDLE token, [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackagePath([NativeTypeName("const PACKAGE_ID *")] PACKAGE_ID* packageId, [NativeTypeName("const UINT32")] uint reserved, [NativeTypeName("UINT32 *")] uint* pathLength, [NativeTypeName("PWSTR")] ushort* path);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackagePathByFullName([NativeTypeName("PCWSTR")] ushort* packageFullName, [NativeTypeName("UINT32 *")] uint* pathLength, [NativeTypeName("PWSTR")] ushort* path);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetStagedPackagePathByFullName([NativeTypeName("PCWSTR")] ushort* packageFullName, [NativeTypeName("UINT32 *")] uint* pathLength, [NativeTypeName("PWSTR")] ushort* path);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetCurrentApplicationUserModelId([NativeTypeName("UINT32 *")] uint* applicationUserModelIdLength, [NativeTypeName("PWSTR")] ushort* applicationUserModelId);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetApplicationUserModelId(HANDLE hProcess, [NativeTypeName("UINT32 *")] uint* applicationUserModelIdLength, [NativeTypeName("PWSTR")] ushort* applicationUserModelId);

        [DllImport("kernelbase", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetApplicationUserModelIdFromToken(HANDLE token, [NativeTypeName("UINT32 *")] uint* applicationUserModelIdLength, [NativeTypeName("PWSTR")] ushort* applicationUserModelId);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int PackageIdFromFullName([NativeTypeName("PCWSTR")] ushort* packageFullName, [NativeTypeName("const UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* bufferLength, byte* buffer);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int PackageFullNameFromId([NativeTypeName("const PACKAGE_ID *")] PACKAGE_ID* packageId, [NativeTypeName("UINT32 *")] uint* packageFullNameLength, [NativeTypeName("PWSTR")] ushort* packageFullName);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int PackageFamilyNameFromId([NativeTypeName("const PACKAGE_ID *")] PACKAGE_ID* packageId, [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int PackageFamilyNameFromFullName([NativeTypeName("PCWSTR")] ushort* packageFullName, [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int PackageNameAndPublisherIdFromFamilyName([NativeTypeName("PCWSTR")] ushort* packageFamilyName, [NativeTypeName("UINT32 *")] uint* packageNameLength, [NativeTypeName("PWSTR")] ushort* packageName, [NativeTypeName("UINT32 *")] uint* packagePublisherIdLength, [NativeTypeName("PWSTR")] ushort* packagePublisherId);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int FormatApplicationUserModelId([NativeTypeName("PCWSTR")] ushort* packageFamilyName, [NativeTypeName("PCWSTR")] ushort* packageRelativeApplicationId, [NativeTypeName("UINT32 *")] uint* applicationUserModelIdLength, [NativeTypeName("PWSTR")] ushort* applicationUserModelId);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ParseApplicationUserModelId([NativeTypeName("PCWSTR")] ushort* applicationUserModelId, [NativeTypeName("UINT32 *")] uint* packageFamilyNameLength, [NativeTypeName("PWSTR")] ushort* packageFamilyName, [NativeTypeName("UINT32 *")] uint* packageRelativeApplicationIdLength, [NativeTypeName("PWSTR")] ushort* packageRelativeApplicationId);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackagesByPackageFamily([NativeTypeName("PCWSTR")] ushort* packageFamilyName, [NativeTypeName("UINT32 *")] uint* count, [NativeTypeName("PWSTR *")] ushort** packageFullNames, [NativeTypeName("UINT32 *")] uint* bufferLength, [NativeTypeName("WCHAR *")] ushort* buffer);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int FindPackagesByPackageFamily([NativeTypeName("PCWSTR")] ushort* packageFamilyName, [NativeTypeName("UINT32")] uint packageFilters, [NativeTypeName("UINT32 *")] uint* count, [NativeTypeName("PWSTR *")] ushort** packageFullNames, [NativeTypeName("UINT32 *")] uint* bufferLength, [NativeTypeName("WCHAR *")] ushort* buffer, [NativeTypeName("UINT32 *")] uint* packageProperties);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("kernelbase", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetStagedPackageOrigin([NativeTypeName("PCWSTR")] ushort* packageFullName, PackageOrigin* origin);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetCurrentPackageInfo([NativeTypeName("const UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* bufferLength, byte* buffer, [NativeTypeName("UINT32 *")] uint* count);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int OpenPackageInfoByFullName([NativeTypeName("PCWSTR")] ushort* packageFullName, [NativeTypeName("const UINT32")] uint reserved, PACKAGE_INFO_REFERENCE* packageInfoReference);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ClosePackageInfo(PACKAGE_INFO_REFERENCE packageInfoReference);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackageInfo(PACKAGE_INFO_REFERENCE packageInfoReference, [NativeTypeName("const UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* bufferLength, byte* buffer, [NativeTypeName("UINT32 *")] uint* count);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetPackageApplicationIds(PACKAGE_INFO_REFERENCE packageInfoReference, [NativeTypeName("UINT32 *")] uint* bufferLength, byte* buffer, [NativeTypeName("UINT32 *")] uint* count);

        [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int AppPolicyGetLifecycleManagement(HANDLE processToken, AppPolicyLifecycleManagement* policy);

        [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int AppPolicyGetWindowingModel(HANDLE processToken, AppPolicyWindowingModel* policy);

        [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int AppPolicyGetMediaFoundationCodecLoading(HANDLE processToken, AppPolicyMediaFoundationCodecLoading* policy);

        [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int AppPolicyGetClrCompat(HANDLE processToken, AppPolicyClrCompat* policy);

        [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int AppPolicyGetThreadInitializationType(HANDLE processToken, AppPolicyThreadInitializationType* policy);

        [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int AppPolicyGetShowDeveloperDiagnostic(HANDLE processToken, AppPolicyShowDeveloperDiagnostic* policy);

        [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int AppPolicyGetProcessTerminationMethod(HANDLE processToken, AppPolicyProcessTerminationMethod* policy);

        [DllImport("api-ms-win-appmodel-runtime-l1-1-2", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int AppPolicyGetCreateFileAccess(HANDLE processToken, AppPolicyCreateFileAccess* policy);

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

        [NativeTypeName("#define PACKAGE_PROPERTY_HOSTRUNTIME 0x00200000")]
        public const int PACKAGE_PROPERTY_HOSTRUNTIME = 0x00200000;

        [NativeTypeName("#define PACKAGE_FILTER_HOSTRUNTIME PACKAGE_PROPERTY_HOSTRUNTIME")]
        public const int PACKAGE_FILTER_HOSTRUNTIME = 0x00200000;

        [NativeTypeName("#define PACKAGE_FILTER_ALL_LOADED 0")]
        public const int PACKAGE_FILTER_ALL_LOADED = 0;
    }
}
