// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

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
}
