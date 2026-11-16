// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FIND_FIRST_EX_CASE_SENSITIVE"]/*' />
    [NativeTypeName("#define FIND_FIRST_EX_CASE_SENSITIVE 0x00000001")]
    public const int FIND_FIRST_EX_CASE_SENSITIVE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FIND_FIRST_EX_LARGE_FETCH"]/*' />
    [NativeTypeName("#define FIND_FIRST_EX_LARGE_FETCH 0x00000002")]
    public const int FIND_FIRST_EX_LARGE_FETCH = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FIND_FIRST_EX_ON_DISK_ENTRIES_ONLY"]/*' />
    [NativeTypeName("#define FIND_FIRST_EX_ON_DISK_ENTRIES_ONLY 0x00000004")]
    public const int FIND_FIRST_EX_ON_DISK_ENTRIES_ONLY = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LOCKFILE_FAIL_IMMEDIATELY"]/*' />
    [NativeTypeName("#define LOCKFILE_FAIL_IMMEDIATELY 0x00000001")]
    public const int LOCKFILE_FAIL_IMMEDIATELY = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LOCKFILE_EXCLUSIVE_LOCK"]/*' />
    [NativeTypeName("#define LOCKFILE_EXCLUSIVE_LOCK 0x00000002")]
    public const int LOCKFILE_EXCLUSIVE_LOCK = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXIT_THREAD_DEBUG_EVENT"]/*' />
    [NativeTypeName("#define EXIT_THREAD_DEBUG_EVENT 4")]
    public const int EXIT_THREAD_DEBUG_EVENT = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXIT_PROCESS_DEBUG_EVENT"]/*' />
    [NativeTypeName("#define EXIT_PROCESS_DEBUG_EVENT 5")]
    public const int EXIT_PROCESS_DEBUG_EVENT = 5;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNLOAD_DLL_DEBUG_EVENT"]/*' />
    [NativeTypeName("#define UNLOAD_DLL_DEBUG_EVENT 7")]
    public const int UNLOAD_DLL_DEBUG_EVENT = 7;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OUTPUT_DEBUG_STRING_EVENT"]/*' />
    [NativeTypeName("#define OUTPUT_DEBUG_STRING_EVENT 8")]
    public const int OUTPUT_DEBUG_STRING_EVENT = 8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RIP_EVENT"]/*' />
    [NativeTypeName("#define RIP_EVENT 9")]
    public const int RIP_EVENT = 9;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STILL_ACTIVE"]/*' />
    [NativeTypeName("#define STILL_ACTIVE STATUS_PENDING")]
    public const uint STILL_ACTIVE = ((uint)(0x00000103));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CONTROL_C_EXIT"]/*' />
    [NativeTypeName("#define CONTROL_C_EXIT STATUS_CONTROL_C_EXIT")]
    public const uint CONTROL_C_EXIT = ((uint)(0xC000013A));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LHND"]/*' />
    [NativeTypeName("#define LHND (LMEM_MOVEABLE | LMEM_ZEROINIT)")]
    public const int LHND = (0x0002 | 0x0040);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LPTR"]/*' />
    [NativeTypeName("#define LPTR (LMEM_FIXED | LMEM_ZEROINIT)")]
    public const int LPTR = (0x0000 | 0x0040);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NONZEROLHND"]/*' />
    [NativeTypeName("#define NONZEROLHND (LMEM_MOVEABLE)")]
    public const int NONZEROLHND = (0x0002);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NONZEROLPTR"]/*' />
    [NativeTypeName("#define NONZEROLPTR (LMEM_FIXED)")]
    public const int NONZEROLPTR = (0x0000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NUMA_NO_PREFERRED_NODE"]/*' />
    [NativeTypeName("#define NUMA_NO_PREFERRED_NODE ((DWORD) -1)")]
    public const uint NUMA_NO_PREFERRED_NODE = unchecked((uint)(-1));
}
