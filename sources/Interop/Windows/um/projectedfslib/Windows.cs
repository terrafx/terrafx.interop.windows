// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("projectedfslib", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PrjStartVirtualizing([NativeTypeName("PCWSTR")] ushort* virtualizationRootPath, [NativeTypeName("const PRJ_CALLBACKS *")] PRJ_CALLBACKS* callbacks, [NativeTypeName("const void *")] void* instanceContext, [NativeTypeName("const PRJ_STARTVIRTUALIZING_OPTIONS *")] PRJ_STARTVIRTUALIZING_OPTIONS* options, [NativeTypeName("PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT *")] IntPtr* namespaceVirtualizationContext);

        [DllImport("projectedfslib", ExactSpelling = true)]
        public static extern void PrjStopVirtualizing([NativeTypeName("PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT")] IntPtr namespaceVirtualizationContext);

        [DllImport("projectedfslib", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PrjClearNegativePathCache([NativeTypeName("PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT")] IntPtr namespaceVirtualizationContext, [NativeTypeName("UINT32 *")] uint* totalEntryNumber);

        [DllImport("projectedfslib", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PrjGetVirtualizationInstanceInfo([NativeTypeName("PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT")] IntPtr namespaceVirtualizationContext, PRJ_VIRTUALIZATION_INSTANCE_INFO* virtualizationInstanceInfo);

        [DllImport("projectedfslib", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PrjMarkDirectoryAsPlaceholder([NativeTypeName("PCWSTR")] ushort* rootPathName, [NativeTypeName("PCWSTR")] ushort* targetPathName, [NativeTypeName("const PRJ_PLACEHOLDER_VERSION_INFO *")] PRJ_PLACEHOLDER_VERSION_INFO* versionInfo, [NativeTypeName("const GUID *")] Guid* virtualizationInstanceID);

        [DllImport("projectedfslib", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PrjWritePlaceholderInfo([NativeTypeName("PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT")] IntPtr namespaceVirtualizationContext, [NativeTypeName("PCWSTR")] ushort* destinationFileName, [NativeTypeName("const PRJ_PLACEHOLDER_INFO *")] PRJ_PLACEHOLDER_INFO* placeholderInfo, [NativeTypeName("UINT32")] uint placeholderInfoSize);

        [DllImport("projectedfslib", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PrjWritePlaceholderInfo2([NativeTypeName("PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT")] IntPtr namespaceVirtualizationContext, [NativeTypeName("PCWSTR")] ushort* destinationFileName, [NativeTypeName("const PRJ_PLACEHOLDER_INFO *")] PRJ_PLACEHOLDER_INFO* placeholderInfo, [NativeTypeName("UINT32")] uint placeholderInfoSize, [NativeTypeName("const PRJ_EXTENDED_INFO *")] PRJ_EXTENDED_INFO* ExtendedInfo);

        [DllImport("projectedfslib", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PrjUpdateFileIfNeeded([NativeTypeName("PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT")] IntPtr namespaceVirtualizationContext, [NativeTypeName("PCWSTR")] ushort* destinationFileName, [NativeTypeName("const PRJ_PLACEHOLDER_INFO *")] PRJ_PLACEHOLDER_INFO* placeholderInfo, [NativeTypeName("UINT32")] uint placeholderInfoSize, PRJ_UPDATE_TYPES updateFlags, PRJ_UPDATE_FAILURE_CAUSES* failureReason);

        [DllImport("projectedfslib", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PrjDeleteFile([NativeTypeName("PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT")] IntPtr namespaceVirtualizationContext, [NativeTypeName("PCWSTR")] ushort* destinationFileName, PRJ_UPDATE_TYPES updateFlags, PRJ_UPDATE_FAILURE_CAUSES* failureReason);

        [DllImport("projectedfslib", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PrjWriteFileData([NativeTypeName("PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT")] IntPtr namespaceVirtualizationContext, [NativeTypeName("const GUID *")] Guid* dataStreamId, void* buffer, [NativeTypeName("UINT64")] ulong byteOffset, [NativeTypeName("UINT32")] uint length);

        [DllImport("projectedfslib", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PrjGetOnDiskFileState([NativeTypeName("PCWSTR")] ushort* destinationFileName, PRJ_FILE_STATE* fileState);

        [DllImport("projectedfslib", ExactSpelling = true)]
        public static extern void* PrjAllocateAlignedBuffer([NativeTypeName("PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT")] IntPtr namespaceVirtualizationContext, [NativeTypeName("size_t")] nuint size);

        [DllImport("projectedfslib", ExactSpelling = true)]
        public static extern void PrjFreeAlignedBuffer(void* buffer);

        [DllImport("projectedfslib", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PrjCompleteCommand([NativeTypeName("PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT")] IntPtr namespaceVirtualizationContext, [NativeTypeName("INT32")] int commandId, [NativeTypeName("HRESULT")] int completionResult, PRJ_COMPLETE_COMMAND_EXTENDED_PARAMETERS* extendedParameters);

        [DllImport("projectedfslib", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PrjFillDirEntryBuffer([NativeTypeName("PCWSTR")] ushort* fileName, PRJ_FILE_BASIC_INFO* fileBasicInfo, [NativeTypeName("PRJ_DIR_ENTRY_BUFFER_HANDLE")] IntPtr dirEntryBufferHandle);

        [DllImport("projectedfslib", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PrjFillDirEntryBuffer2([NativeTypeName("PRJ_DIR_ENTRY_BUFFER_HANDLE")] IntPtr dirEntryBufferHandle, [NativeTypeName("PCWSTR")] ushort* fileName, PRJ_FILE_BASIC_INFO* fileBasicInfo, PRJ_EXTENDED_INFO* extendedInfo);

        [DllImport("projectedfslib", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte PrjFileNameMatch([NativeTypeName("PCWSTR")] ushort* fileNameToCheck, [NativeTypeName("PCWSTR")] ushort* pattern);

        [DllImport("projectedfslib", ExactSpelling = true)]
        public static extern int PrjFileNameCompare([NativeTypeName("PCWSTR")] ushort* fileName1, [NativeTypeName("PCWSTR")] ushort* fileName2);

        [DllImport("projectedfslib", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte PrjDoesNameContainWildCards([NativeTypeName("LPCWSTR")] ushort* fileName);
    }
}
