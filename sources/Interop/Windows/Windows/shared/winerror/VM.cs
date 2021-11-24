// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class VM
{
    [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_PARTITION_STATE_NOT_FOUND _HRESULT_TYPEDEF_(0xC0370500L)")]
    public const int VM_SAVED_STATE_DUMP_E_PARTITION_STATE_NOT_FOUND = unchecked((int)(0xC0370500));

    [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_GUEST_MEMORY_NOT_FOUND _HRESULT_TYPEDEF_(0xC0370501L)")]
    public const int VM_SAVED_STATE_DUMP_E_GUEST_MEMORY_NOT_FOUND = unchecked((int)(0xC0370501));

    [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_NO_VP_FOUND_IN_PARTITION_STATE _HRESULT_TYPEDEF_(0xC0370502L)")]
    public const int VM_SAVED_STATE_DUMP_E_NO_VP_FOUND_IN_PARTITION_STATE = unchecked((int)(0xC0370502));

    [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_NESTED_VIRTUALIZATION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0xC0370503L)")]
    public const int VM_SAVED_STATE_DUMP_E_NESTED_VIRTUALIZATION_NOT_SUPPORTED = unchecked((int)(0xC0370503));

    [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_WINDOWS_KERNEL_IMAGE_NOT_FOUND _HRESULT_TYPEDEF_(0xC0370504L)")]
    public const int VM_SAVED_STATE_DUMP_E_WINDOWS_KERNEL_IMAGE_NOT_FOUND = unchecked((int)(0xC0370504));

    [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_PXE_NOT_PRESENT _HRESULT_TYPEDEF_(0xC0370505L)")]
    public const int VM_SAVED_STATE_DUMP_E_PXE_NOT_PRESENT = unchecked((int)(0xC0370505));

    [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_PDPTE_NOT_PRESENT _HRESULT_TYPEDEF_(0xC0370506L)")]
    public const int VM_SAVED_STATE_DUMP_E_PDPTE_NOT_PRESENT = unchecked((int)(0xC0370506));

    [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_PDE_NOT_PRESENT _HRESULT_TYPEDEF_(0xC0370507L)")]
    public const int VM_SAVED_STATE_DUMP_E_PDE_NOT_PRESENT = unchecked((int)(0xC0370507));

    [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_PTE_NOT_PRESENT _HRESULT_TYPEDEF_(0xC0370508L)")]
    public const int VM_SAVED_STATE_DUMP_E_PTE_NOT_PRESENT = unchecked((int)(0xC0370508));

    [NativeTypeName("#define VM_SAVED_STATE_DUMP_E_VP_VTL_NOT_ENABLED _HRESULT_TYPEDEF_(0xC0370509L)")]
    public const int VM_SAVED_STATE_DUMP_E_VP_VTL_NOT_ENABLED = unchecked((int)(0xC0370509));
}
