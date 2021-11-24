// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern HRESULT PrjStartVirtualizing([NativeTypeName("PCWSTR")] ushort* virtualizationRootPath, [NativeTypeName("const PRJ_CALLBACKS *")] PRJ_CALLBACKS* callbacks, [NativeTypeName("const void *")] void* instanceContext, [NativeTypeName("const PRJ_STARTVIRTUALIZING_OPTIONS *")] PRJ_STARTVIRTUALIZING_OPTIONS* options, PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT* namespaceVirtualizationContext);

    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern void PrjStopVirtualizing(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext);

    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern HRESULT PrjClearNegativePathCache(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, [NativeTypeName("UINT32 *")] uint* totalEntryNumber);

    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern HRESULT PrjGetVirtualizationInstanceInfo(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, PRJ_VIRTUALIZATION_INSTANCE_INFO* virtualizationInstanceInfo);

    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern HRESULT PrjMarkDirectoryAsPlaceholder([NativeTypeName("PCWSTR")] ushort* rootPathName, [NativeTypeName("PCWSTR")] ushort* targetPathName, [NativeTypeName("const PRJ_PLACEHOLDER_VERSION_INFO *")] PRJ_PLACEHOLDER_VERSION_INFO* versionInfo, [NativeTypeName("const GUID *")] Guid* virtualizationInstanceID);

    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern HRESULT PrjWritePlaceholderInfo(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, [NativeTypeName("PCWSTR")] ushort* destinationFileName, [NativeTypeName("const PRJ_PLACEHOLDER_INFO *")] PRJ_PLACEHOLDER_INFO* placeholderInfo, [NativeTypeName("UINT32")] uint placeholderInfoSize);

    [SupportedOSPlatform("windows10.0.19041.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern HRESULT PrjWritePlaceholderInfo2(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, [NativeTypeName("PCWSTR")] ushort* destinationFileName, [NativeTypeName("const PRJ_PLACEHOLDER_INFO *")] PRJ_PLACEHOLDER_INFO* placeholderInfo, [NativeTypeName("UINT32")] uint placeholderInfoSize, [NativeTypeName("const PRJ_EXTENDED_INFO *")] PRJ_EXTENDED_INFO* ExtendedInfo);

    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern HRESULT PrjUpdateFileIfNeeded(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, [NativeTypeName("PCWSTR")] ushort* destinationFileName, [NativeTypeName("const PRJ_PLACEHOLDER_INFO *")] PRJ_PLACEHOLDER_INFO* placeholderInfo, [NativeTypeName("UINT32")] uint placeholderInfoSize, PRJ_UPDATE_TYPES updateFlags, PRJ_UPDATE_FAILURE_CAUSES* failureReason);

    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern HRESULT PrjDeleteFile(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, [NativeTypeName("PCWSTR")] ushort* destinationFileName, PRJ_UPDATE_TYPES updateFlags, PRJ_UPDATE_FAILURE_CAUSES* failureReason);

    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern HRESULT PrjWriteFileData(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, [NativeTypeName("const GUID *")] Guid* dataStreamId, void* buffer, [NativeTypeName("UINT64")] ulong byteOffset, [NativeTypeName("UINT32")] uint length);

    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern HRESULT PrjGetOnDiskFileState([NativeTypeName("PCWSTR")] ushort* destinationFileName, PRJ_FILE_STATE* fileState);

    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern void* PrjAllocateAlignedBuffer(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, [NativeTypeName("size_t")] nuint size);

    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern void PrjFreeAlignedBuffer(void* buffer);

    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern HRESULT PrjCompleteCommand(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT namespaceVirtualizationContext, [NativeTypeName("INT32")] int commandId, HRESULT completionResult, PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS* extendedParameters);

    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern HRESULT PrjFillDirEntryBuffer([NativeTypeName("PCWSTR")] ushort* fileName, PRJ_FILE_BASIC_INFO* fileBasicInfo, PRJ_DIR_ENTRY_BUFFER_HANDLE dirEntryBufferHandle);

    [SupportedOSPlatform("windows10.0.19041.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern HRESULT PrjFillDirEntryBuffer2(PRJ_DIR_ENTRY_BUFFER_HANDLE dirEntryBufferHandle, [NativeTypeName("PCWSTR")] ushort* fileName, PRJ_FILE_BASIC_INFO* fileBasicInfo, PRJ_EXTENDED_INFO* extendedInfo);

    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte PrjFileNameMatch([NativeTypeName("PCWSTR")] ushort* fileNameToCheck, [NativeTypeName("PCWSTR")] ushort* pattern);

    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    public static extern int PrjFileNameCompare([NativeTypeName("PCWSTR")] ushort* fileName1, [NativeTypeName("PCWSTR")] ushort* fileName2);

    [SupportedOSPlatform("windows10.0.17763.0")]
    [DllImport("projectedfslib", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte PrjDoesNameContainWildCards([NativeTypeName("LPCWSTR")] ushort* fileName);
}
