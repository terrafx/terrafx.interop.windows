// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.RUNTIME_REPORT_TYPE;

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NO_SUBGROUP_GUID"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid NO_SUBGROUP_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x3E, 0x41, 0xA3, 0xFE,
                0x05, 0x7E,
                0x11, 0x49,
                0x9A,
                0x71,
                0x70,
                0x03,
                0x31,
                0xF1,
                0xC2,
                0x94
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ALL_POWERSCHEMES_GUID"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ALL_POWERSCHEMES_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x5E, 0xE9, 0xA1, 0x68,
                0xEA, 0x13,
                0xE1, 0x41,
                0x80,
                0x11,
                0x0C,
                0x49,
                0x6C,
                0xA4,
                0x90,
                0xB0
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ANYSIZE_ARRAY"]/*' />
    [NativeTypeName("#define ANYSIZE_ARRAY 1")]
    public const int ANYSIZE_ARRAY = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.X86_CACHE_ALIGNMENT_SIZE"]/*' />
    [NativeTypeName("#define X86_CACHE_ALIGNMENT_SIZE 64")]
    public const int X86_CACHE_ALIGNMENT_SIZE = 64;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ARM_CACHE_ALIGNMENT_SIZE"]/*' />
    [NativeTypeName("#define ARM_CACHE_ALIGNMENT_SIZE 128")]
    public const int ARM_CACHE_ALIGNMENT_SIZE = 128;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PRAGMA_DEPRECATED_DDK"]/*' />
    [NativeTypeName("#define PRAGMA_DEPRECATED_DDK 0")]
    public const int PRAGMA_DEPRECATED_DDK = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UCSCHAR_INVALID_CHARACTER"]/*' />
    [NativeTypeName("#define UCSCHAR_INVALID_CHARACTER (0xffffffff)")]
    public const uint UCSCHAR_INVALID_CHARACTER = (0xffffffff);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MIN_UCSCHAR"]/*' />
    [NativeTypeName("#define MIN_UCSCHAR (0)")]
    public const int MIN_UCSCHAR = (0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ALL_PROCESSOR_GROUPS"]/*' />
    [NativeTypeName("#define ALL_PROCESSOR_GROUPS 0xffff")]
    public const int ALL_PROCESSOR_GROUPS = 0xffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.APPLICATION_ERROR_MASK"]/*' />
    [NativeTypeName("#define APPLICATION_ERROR_MASK 0x20000000")]
    public const int APPLICATION_ERROR_MASK = 0x20000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MAXLONGLONG"]/*' />
    [NativeTypeName("#define MAXLONGLONG (0x7fffffffffffffff)")]
    public const long MAXLONGLONG = (0x7fffffffffffffff);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ANSI_NULL"]/*' />
    [NativeTypeName("#define ANSI_NULL ((CHAR)0)")]
    public const sbyte ANSI_NULL = ((sbyte)(0));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNICODE_NULL"]/*' />
    [NativeTypeName("#define UNICODE_NULL ((WCHAR)0)")]
    public const char UNICODE_NULL = ((char)(0));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNICODE_STRING_MAX_BYTES"]/*' />
    [NativeTypeName("#define UNICODE_STRING_MAX_BYTES ((WORD  ) 65534)")]
    public const ushort UNICODE_STRING_MAX_BYTES = ((ushort)(65534));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNICODE_STRING_MAX_CHARS"]/*' />
    [NativeTypeName("#define UNICODE_STRING_MAX_CHARS (32767)")]
    public const int UNICODE_STRING_MAX_CHARS = (32767);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MINCHAR"]/*' />
    [NativeTypeName("#define MINCHAR 0x80")]
    public const int MINCHAR = 0x80;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MAXCHAR"]/*' />
    [NativeTypeName("#define MAXCHAR 0x7f")]
    public const int MAXCHAR = 0x7f;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MINSHORT"]/*' />
    [NativeTypeName("#define MINSHORT 0x8000")]
    public const int MINSHORT = 0x8000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MAXSHORT"]/*' />
    [NativeTypeName("#define MAXSHORT 0x7fff")]
    public const int MAXSHORT = 0x7fff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MINLONG"]/*' />
    [NativeTypeName("#define MINLONG 0x80000000")]
    public const uint MINLONG = 0x80000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MAXLONG"]/*' />
    [NativeTypeName("#define MAXLONG 0x7fffffff")]
    public const int MAXLONG = 0x7fffffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MAXBYTE"]/*' />
    [NativeTypeName("#define MAXBYTE 0xff")]
    public const int MAXBYTE = 0xff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MAXWORD"]/*' />
    [NativeTypeName("#define MAXWORD 0xffff")]
    public const int MAXWORD = 0xffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MAXDWORD"]/*' />
    [NativeTypeName("#define MAXDWORD 0xffffffff")]
    public const uint MAXDWORD = 0xffffffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ENCLAVE_SHORT_ID_LENGTH"]/*' />
    [NativeTypeName("#define ENCLAVE_SHORT_ID_LENGTH 16")]
    public const int ENCLAVE_SHORT_ID_LENGTH = 16;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ENCLAVE_LONG_ID_LENGTH"]/*' />
    [NativeTypeName("#define ENCLAVE_LONG_ID_LENGTH 32")]
    public const int ENCLAVE_LONG_ID_LENGTH = 32;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NLS_VALID_LOCALE_MASK"]/*' />
    [NativeTypeName("#define NLS_VALID_LOCALE_MASK 0x000fffff")]
    public const int NLS_VALID_LOCALE_MASK = 0x000fffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows._MM_HINT_T0"]/*' />
    [NativeTypeName("#define _MM_HINT_T0 1")]
    public const int _MM_HINT_T0 = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows._MM_HINT_T1"]/*' />
    [NativeTypeName("#define _MM_HINT_T1 2")]
    public const int _MM_HINT_T1 = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows._MM_HINT_T2"]/*' />
    [NativeTypeName("#define _MM_HINT_T2 3")]
    public const int _MM_HINT_T2 = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows._MM_HINT_NTA"]/*' />
    [NativeTypeName("#define _MM_HINT_NTA 0")]
    public const int _MM_HINT_NTA = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ARM64_TPIDR2_BLOCK_ALIGN"]/*' />
    [NativeTypeName("#define ARM64_TPIDR2_BLOCK_ALIGN 16")]
    public const int ARM64_TPIDR2_BLOCK_ALIGN = 16;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DELETE"]/*' />
    [NativeTypeName("#define DELETE (0x00010000L)")]
    public const int DELETE = (0x00010000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WRITE_DAC"]/*' />
    [NativeTypeName("#define WRITE_DAC (0x00040000L)")]
    public const int WRITE_DAC = (0x00040000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WRITE_OWNER"]/*' />
    [NativeTypeName("#define WRITE_OWNER (0x00080000L)")]
    public const int WRITE_OWNER = (0x00080000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNCHRONIZE"]/*' />
    [NativeTypeName("#define SYNCHRONIZE (0x00100000L)")]
    public const int SYNCHRONIZE = (0x00100000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STANDARD_RIGHTS_REQUIRED"]/*' />
    [NativeTypeName("#define STANDARD_RIGHTS_REQUIRED (0x000F0000L)")]
    public const int STANDARD_RIGHTS_REQUIRED = (0x000F0000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STANDARD_RIGHTS_READ"]/*' />
    [NativeTypeName("#define STANDARD_RIGHTS_READ (READ_CONTROL)")]
    public const int STANDARD_RIGHTS_READ = ((0x00020000));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STANDARD_RIGHTS_WRITE"]/*' />
    [NativeTypeName("#define STANDARD_RIGHTS_WRITE (READ_CONTROL)")]
    public const int STANDARD_RIGHTS_WRITE = ((0x00020000));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STANDARD_RIGHTS_EXECUTE"]/*' />
    [NativeTypeName("#define STANDARD_RIGHTS_EXECUTE (READ_CONTROL)")]
    public const int STANDARD_RIGHTS_EXECUTE = ((0x00020000));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STANDARD_RIGHTS_ALL"]/*' />
    [NativeTypeName("#define STANDARD_RIGHTS_ALL (0x001F0000L)")]
    public const int STANDARD_RIGHTS_ALL = (0x001F0000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SPECIFIC_RIGHTS_ALL"]/*' />
    [NativeTypeName("#define SPECIFIC_RIGHTS_ALL (0x0000FFFFL)")]
    public const int SPECIFIC_RIGHTS_ALL = (0x0000FFFF);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GENERIC_READ"]/*' />
    [NativeTypeName("#define GENERIC_READ (0x80000000L)")]
    public const uint GENERIC_READ = (0x80000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GENERIC_WRITE"]/*' />
    [NativeTypeName("#define GENERIC_WRITE (0x40000000L)")]
    public const int GENERIC_WRITE = (0x40000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GENERIC_EXECUTE"]/*' />
    [NativeTypeName("#define GENERIC_EXECUTE (0x20000000L)")]
    public const int GENERIC_EXECUTE = (0x20000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GENERIC_ALL"]/*' />
    [NativeTypeName("#define GENERIC_ALL (0x10000000L)")]
    public const int GENERIC_ALL = (0x10000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FOREST_USER_RID_MAX"]/*' />
    [NativeTypeName("#define FOREST_USER_RID_MAX (0x000001F3L)")]
    public const int FOREST_USER_RID_MAX = (0x000001F3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACL_REVISION"]/*' />
    [NativeTypeName("#define ACL_REVISION (2)")]
    public const int ACL_REVISION = (2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACL_REVISION_DS"]/*' />
    [NativeTypeName("#define ACL_REVISION_DS (4)")]
    public const int ACL_REVISION_DS = (4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACL_REVISION1"]/*' />
    [NativeTypeName("#define ACL_REVISION1 (1)")]
    public const int ACL_REVISION1 = (1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MIN_ACL_REVISION"]/*' />
    [NativeTypeName("#define MIN_ACL_REVISION ACL_REVISION2")]
    public const int MIN_ACL_REVISION = (2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACL_REVISION2"]/*' />
    [NativeTypeName("#define ACL_REVISION2 (2)")]
    public const int ACL_REVISION2 = (2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACL_REVISION3"]/*' />
    [NativeTypeName("#define ACL_REVISION3 (3)")]
    public const int ACL_REVISION3 = (3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACL_REVISION4"]/*' />
    [NativeTypeName("#define ACL_REVISION4 (4)")]
    public const int ACL_REVISION4 = (4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OBJECT_INHERIT_ACE"]/*' />
    [NativeTypeName("#define OBJECT_INHERIT_ACE (0x1)")]
    public const int OBJECT_INHERIT_ACE = (0x1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NO_PROPAGATE_INHERIT_ACE"]/*' />
    [NativeTypeName("#define NO_PROPAGATE_INHERIT_ACE (0x4)")]
    public const int NO_PROPAGATE_INHERIT_ACE = (0x4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INHERIT_ONLY_ACE"]/*' />
    [NativeTypeName("#define INHERIT_ONLY_ACE (0x8)")]
    public const int INHERIT_ONLY_ACE = (0x8);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INHERITED_ACE"]/*' />
    [NativeTypeName("#define INHERITED_ACE (0x10)")]
    public const int INHERITED_ACE = (0x10);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VALID_INHERIT_FLAGS"]/*' />
    [NativeTypeName("#define VALID_INHERIT_FLAGS (0x1F)")]
    public const int VALID_INHERIT_FLAGS = (0x1F);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CRITICAL_ACE_FLAG"]/*' />
    [NativeTypeName("#define CRITICAL_ACE_FLAG (0x20)")]
    public const int CRITICAL_ACE_FLAG = (0x20);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SUCCESSFUL_ACCESS_ACE_FLAG"]/*' />
    [NativeTypeName("#define SUCCESSFUL_ACCESS_ACE_FLAG (0x40)")]
    public const int SUCCESSFUL_ACCESS_ACE_FLAG = (0x40);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FAILED_ACCESS_ACE_FLAG"]/*' />
    [NativeTypeName("#define FAILED_ACCESS_ACE_FLAG (0x80)")]
    public const int FAILED_ACCESS_ACE_FLAG = (0x80);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACE_OBJECT_TYPE_PRESENT"]/*' />
    [NativeTypeName("#define ACE_OBJECT_TYPE_PRESENT 0x1")]
    public const int ACE_OBJECT_TYPE_PRESENT = 0x1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACE_INHERITED_OBJECT_TYPE_PRESENT"]/*' />
    [NativeTypeName("#define ACE_INHERITED_OBJECT_TYPE_PRESENT 0x2")]
    public const int ACE_INHERITED_OBJECT_TYPE_PRESENT = 0x2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AUDIT_ALLOW_NO_PRIVILEGE"]/*' />
    [NativeTypeName("#define AUDIT_ALLOW_NO_PRIVILEGE 0x1")]
    public const int AUDIT_ALLOW_NO_PRIVILEGE = 0x1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PRIVILEGE_SET_ALL_NECESSARY"]/*' />
    [NativeTypeName("#define PRIVILEGE_SET_ALL_NECESSARY (1)")]
    public const int PRIVILEGE_SET_ALL_NECESSARY = (1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DISABLE_MAX_PRIVILEGE"]/*' />
    [NativeTypeName("#define DISABLE_MAX_PRIVILEGE 0x1")]
    public const int DISABLE_MAX_PRIVILEGE = 0x1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SANDBOX_INERT"]/*' />
    [NativeTypeName("#define SANDBOX_INERT 0x2")]
    public const int SANDBOX_INERT = 0x2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LUA_TOKEN"]/*' />
    [NativeTypeName("#define LUA_TOKEN 0x4")]
    public const int LUA_TOKEN = 0x4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WRITE_RESTRICTED"]/*' />
    [NativeTypeName("#define WRITE_RESTRICTED 0x8")]
    public const int WRITE_RESTRICTED = 0x8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OWNER_SECURITY_INFORMATION"]/*' />
    [NativeTypeName("#define OWNER_SECURITY_INFORMATION (0x00000001L)")]
    public const int OWNER_SECURITY_INFORMATION = (0x00000001);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GROUP_SECURITY_INFORMATION"]/*' />
    [NativeTypeName("#define GROUP_SECURITY_INFORMATION (0x00000002L)")]
    public const int GROUP_SECURITY_INFORMATION = (0x00000002);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DACL_SECURITY_INFORMATION"]/*' />
    [NativeTypeName("#define DACL_SECURITY_INFORMATION (0x00000004L)")]
    public const int DACL_SECURITY_INFORMATION = (0x00000004);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SACL_SECURITY_INFORMATION"]/*' />
    [NativeTypeName("#define SACL_SECURITY_INFORMATION (0x00000008L)")]
    public const int SACL_SECURITY_INFORMATION = (0x00000008);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LABEL_SECURITY_INFORMATION"]/*' />
    [NativeTypeName("#define LABEL_SECURITY_INFORMATION (0x00000010L)")]
    public const int LABEL_SECURITY_INFORMATION = (0x00000010);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ATTRIBUTE_SECURITY_INFORMATION"]/*' />
    [NativeTypeName("#define ATTRIBUTE_SECURITY_INFORMATION (0x00000020L)")]
    public const int ATTRIBUTE_SECURITY_INFORMATION = (0x00000020);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SCOPE_SECURITY_INFORMATION"]/*' />
    [NativeTypeName("#define SCOPE_SECURITY_INFORMATION (0x00000040L)")]
    public const int SCOPE_SECURITY_INFORMATION = (0x00000040);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MANDATORY_ACCESS_SECURITY_INFORMATION"]/*' />
    [NativeTypeName("#define MANDATORY_ACCESS_SECURITY_INFORMATION (0x00000200L)")]
    public const int MANDATORY_ACCESS_SECURITY_INFORMATION = (0x00000200);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PROTECTED_DACL_SECURITY_INFORMATION"]/*' />
    [NativeTypeName("#define PROTECTED_DACL_SECURITY_INFORMATION (0x80000000L)")]
    public const uint PROTECTED_DACL_SECURITY_INFORMATION = (0x80000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PROTECTED_SACL_SECURITY_INFORMATION"]/*' />
    [NativeTypeName("#define PROTECTED_SACL_SECURITY_INFORMATION (0x40000000L)")]
    public const int PROTECTED_SACL_SECURITY_INFORMATION = (0x40000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNPROTECTED_DACL_SECURITY_INFORMATION"]/*' />
    [NativeTypeName("#define UNPROTECTED_DACL_SECURITY_INFORMATION (0x20000000L)")]
    public const int UNPROTECTED_DACL_SECURITY_INFORMATION = (0x20000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNPROTECTED_SACL_SECURITY_INFORMATION"]/*' />
    [NativeTypeName("#define UNPROTECTED_SACL_SECURITY_INFORMATION (0x10000000L)")]
    public const int UNPROTECTED_SACL_SECURITY_INFORMATION = (0x10000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLS_MAXIMUM_AVAILABLE"]/*' />
    [NativeTypeName("#define FLS_MAXIMUM_AVAILABLE 4080")]
    public const int FLS_MAXIMUM_AVAILABLE = 4080;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TLS_MINIMUM_AVAILABLE"]/*' />
    [NativeTypeName("#define TLS_MINIMUM_AVAILABLE 64")]
    public const int TLS_MINIMUM_AVAILABLE = 64;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMPONENT_KTM"]/*' />
    [NativeTypeName("#define COMPONENT_KTM 0x01")]
    public const int COMPONENT_KTM = 0x01;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMPONENT_VALID_FLAGS"]/*' />
    [NativeTypeName("#define COMPONENT_VALID_FLAGS (COMPONENT_KTM)")]
    public const int COMPONENT_VALID_FLAGS = (0x01);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DYNAMIC_EH_CONTINUATION_TARGET_ADD"]/*' />
    [NativeTypeName("#define DYNAMIC_EH_CONTINUATION_TARGET_ADD (0x00000001)")]
    public const int DYNAMIC_EH_CONTINUATION_TARGET_ADD = (0x00000001);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DYNAMIC_EH_CONTINUATION_TARGET_PROCESSED"]/*' />
    [NativeTypeName("#define DYNAMIC_EH_CONTINUATION_TARGET_PROCESSED (0x00000002)")]
    public const int DYNAMIC_EH_CONTINUATION_TARGET_PROCESSED = (0x00000002);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DYNAMIC_ENFORCED_ADDRESS_RANGE_ADD"]/*' />
    [NativeTypeName("#define DYNAMIC_ENFORCED_ADDRESS_RANGE_ADD (0x00000001)")]
    public const int DYNAMIC_ENFORCED_ADDRESS_RANGE_ADD = (0x00000001);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DYNAMIC_ENFORCED_ADDRESS_RANGE_PROCESSED"]/*' />
    [NativeTypeName("#define DYNAMIC_ENFORCED_ADDRESS_RANGE_PROCESSED (0x00000002)")]
    public const int DYNAMIC_ENFORCED_ADDRESS_RANGE_PROCESSED = (0x00000002);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QUOTA_LIMITS_HARDWS_MIN_ENABLE"]/*' />
    [NativeTypeName("#define QUOTA_LIMITS_HARDWS_MIN_ENABLE 0x00000001")]
    public const int QUOTA_LIMITS_HARDWS_MIN_ENABLE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QUOTA_LIMITS_HARDWS_MIN_DISABLE"]/*' />
    [NativeTypeName("#define QUOTA_LIMITS_HARDWS_MIN_DISABLE 0x00000002")]
    public const int QUOTA_LIMITS_HARDWS_MIN_DISABLE = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QUOTA_LIMITS_HARDWS_MAX_ENABLE"]/*' />
    [NativeTypeName("#define QUOTA_LIMITS_HARDWS_MAX_ENABLE 0x00000004")]
    public const int QUOTA_LIMITS_HARDWS_MAX_ENABLE = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QUOTA_LIMITS_HARDWS_MAX_DISABLE"]/*' />
    [NativeTypeName("#define QUOTA_LIMITS_HARDWS_MAX_DISABLE 0x00000008")]
    public const int QUOTA_LIMITS_HARDWS_MAX_DISABLE = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QUOTA_LIMITS_USE_DEFAULT_LIMITS"]/*' />
    [NativeTypeName("#define QUOTA_LIMITS_USE_DEFAULT_LIMITS 0x00000010")]
    public const int QUOTA_LIMITS_USE_DEFAULT_LIMITS = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MUTANT_QUERY_STATE"]/*' />
    [NativeTypeName("#define MUTANT_QUERY_STATE 0x0001")]
    public const int MUTANT_QUERY_STATE = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MUTANT_ALL_ACCESS"]/*' />
    [NativeTypeName("#define MUTANT_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|\\\r\n                          MUTANT_QUERY_STATE)")]
    public const int MUTANT_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x0001);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SEMAPHORE_MODIFY_STATE"]/*' />
    [NativeTypeName("#define SEMAPHORE_MODIFY_STATE 0x0002")]
    public const int SEMAPHORE_MODIFY_STATE = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SEMAPHORE_ALL_ACCESS"]/*' />
    [NativeTypeName("#define SEMAPHORE_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|0x3)")]
    public const int SEMAPHORE_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TIMER_QUERY_STATE"]/*' />
    [NativeTypeName("#define TIMER_QUERY_STATE 0x0001")]
    public const int TIMER_QUERY_STATE = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TIMER_MODIFY_STATE"]/*' />
    [NativeTypeName("#define TIMER_MODIFY_STATE 0x0002")]
    public const int TIMER_MODIFY_STATE = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TIMER_ALL_ACCESS"]/*' />
    [NativeTypeName("#define TIMER_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|\\\r\n                          TIMER_QUERY_STATE|TIMER_MODIFY_STATE)")]
    public const int TIMER_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x0001 | 0x0002);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LTP_PC_SMT"]/*' />
    [NativeTypeName("#define LTP_PC_SMT 0x1")]
    public const int LTP_PC_SMT = 0x1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CACHE_FULLY_ASSOCIATIVE"]/*' />
    [NativeTypeName("#define CACHE_FULLY_ASSOCIATIVE 0xFF")]
    public const int CACHE_FULLY_ASSOCIATIVE = 0xFF;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RUNTIME_REPORT_PACKAGE_MAGIC"]/*' />
    [NativeTypeName("#define RUNTIME_REPORT_PACKAGE_MAGIC 0x52545250")]
    public const int RUNTIME_REPORT_PACKAGE_MAGIC = 0x52545250;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RUNTIME_REPORT_PACKAGE_VERSION_CURRENT"]/*' />
    [NativeTypeName("#define RUNTIME_REPORT_PACKAGE_VERSION_CURRENT (1)")]
    public const int RUNTIME_REPORT_PACKAGE_VERSION_CURRENT = (1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RUNTIME_REPORT_NONCE_SIZE"]/*' />
    [NativeTypeName("#define RUNTIME_REPORT_NONCE_SIZE 32")]
    public const int RUNTIME_REPORT_NONCE_SIZE = 32;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RUNTIME_REPORT_DIGEST_MAX_SIZE"]/*' />
    [NativeTypeName("#define RUNTIME_REPORT_DIGEST_MAX_SIZE 64")]
    public const int RUNTIME_REPORT_DIGEST_MAX_SIZE = 64;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RUNTIME_REPORT_SIGNATURE_SCHEME_SHA512_RSA_PSS_SHA512"]/*' />
    [NativeTypeName("#define RUNTIME_REPORT_SIGNATURE_SCHEME_SHA512_RSA_PSS_SHA512 (1)")]
    public const int RUNTIME_REPORT_SIGNATURE_SCHEME_SHA512_RSA_PSS_SHA512 = (1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RUNTIME_REPORT_TYPE_MASK_ALL"]/*' />
    [NativeTypeName("#define RUNTIME_REPORT_TYPE_MASK_ALL ((1ULL << RuntimeReportTypeMax) - 1)")]
    public const ulong RUNTIME_REPORT_TYPE_MASK_ALL = ((1UL << (int)((int)(RuntimeReportTypeMax))) - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DRIVER_REPORT_DIGEST_MAX_SIZE"]/*' />
    [NativeTypeName("#define DRIVER_REPORT_DIGEST_MAX_SIZE RUNTIME_REPORT_DIGEST_MAX_SIZE")]
    public const int DRIVER_REPORT_DIGEST_MAX_SIZE = 64;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DRIVER_REPORT_NAME_MAX_LENGTH"]/*' />
    [NativeTypeName("#define DRIVER_REPORT_NAME_MAX_LENGTH 32")]
    public const int DRIVER_REPORT_NAME_MAX_LENGTH = 32;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CODE_INTEGRITY_REPORT_GENERATION_VERSION_CURRENT"]/*' />
    [NativeTypeName("#define CODE_INTEGRITY_REPORT_GENERATION_VERSION_CURRENT (1)")]
    public const int CODE_INTEGRITY_REPORT_GENERATION_VERSION_CURRENT = (1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CODE_INTEGRITY_REPORT_RECORD_VERSION_CURRENT"]/*' />
    [NativeTypeName("#define CODE_INTEGRITY_REPORT_RECORD_VERSION_CURRENT (1)")]
    public const int CODE_INTEGRITY_REPORT_RECORD_VERSION_CURRENT = (1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CFG_CALL_TARGET_VALID"]/*' />
    [NativeTypeName("#define CFG_CALL_TARGET_VALID (0x00000001)")]
    public const int CFG_CALL_TARGET_VALID = (0x00000001);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CFG_CALL_TARGET_PROCESSED"]/*' />
    [NativeTypeName("#define CFG_CALL_TARGET_PROCESSED (0x00000002)")]
    public const int CFG_CALL_TARGET_PROCESSED = (0x00000002);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CFG_CALL_TARGET_CONVERT_EXPORT_SUPPRESSED_TO_VALID"]/*' />
    [NativeTypeName("#define CFG_CALL_TARGET_CONVERT_EXPORT_SUPPRESSED_TO_VALID (0x00000004)")]
    public const int CFG_CALL_TARGET_CONVERT_EXPORT_SUPPRESSED_TO_VALID = (0x00000004);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CFG_CALL_TARGET_VALID_XFG"]/*' />
    [NativeTypeName("#define CFG_CALL_TARGET_VALID_XFG (0x00000008)")]
    public const int CFG_CALL_TARGET_VALID_XFG = (0x00000008);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CFG_CALL_TARGET_CONVERT_XFG_TO_CFG"]/*' />
    [NativeTypeName("#define CFG_CALL_TARGET_CONVERT_XFG_TO_CFG (0x00000010)")]
    public const int CFG_CALL_TARGET_CONVERT_XFG_TO_CFG = (0x00000010);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SECTION_QUERY"]/*' />
    [NativeTypeName("#define SECTION_QUERY 0x0001")]
    public const int SECTION_QUERY = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SECTION_MAP_WRITE"]/*' />
    [NativeTypeName("#define SECTION_MAP_WRITE 0x0002")]
    public const int SECTION_MAP_WRITE = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SECTION_MAP_READ"]/*' />
    [NativeTypeName("#define SECTION_MAP_READ 0x0004")]
    public const int SECTION_MAP_READ = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SECTION_MAP_EXECUTE"]/*' />
    [NativeTypeName("#define SECTION_MAP_EXECUTE 0x0008")]
    public const int SECTION_MAP_EXECUTE = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SECTION_EXTEND_SIZE"]/*' />
    [NativeTypeName("#define SECTION_EXTEND_SIZE 0x0010")]
    public const int SECTION_EXTEND_SIZE = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SECTION_MAP_EXECUTE_EXPLICIT"]/*' />
    [NativeTypeName("#define SECTION_MAP_EXECUTE_EXPLICIT 0x0020")]
    public const int SECTION_MAP_EXECUTE_EXPLICIT = 0x0020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SECTION_ALL_ACCESS"]/*' />
    [NativeTypeName("#define SECTION_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SECTION_QUERY|\\\r\n                            SECTION_MAP_WRITE |      \\\r\n                            SECTION_MAP_READ |       \\\r\n                            SECTION_MAP_EXECUTE |    \\\r\n                            SECTION_EXTEND_SIZE)")]
    public const int SECTION_ALL_ACCESS = ((0x000F0000) | 0x0001 | 0x0002 | 0x0004 | 0x0008 | 0x0010);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SESSION_QUERY_ACCESS"]/*' />
    [NativeTypeName("#define SESSION_QUERY_ACCESS 0x0001")]
    public const int SESSION_QUERY_ACCESS = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SESSION_MODIFY_ACCESS"]/*' />
    [NativeTypeName("#define SESSION_MODIFY_ACCESS 0x0002")]
    public const int SESSION_MODIFY_ACCESS = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SESSION_ALL_ACCESS"]/*' />
    [NativeTypeName("#define SESSION_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED |  \\\r\n                            SESSION_QUERY_ACCESS |             \\\r\n                            SESSION_MODIFY_ACCESS)")]
    public const int SESSION_ALL_ACCESS = ((0x000F0000) | 0x0001 | 0x0002);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WRITE_WATCH_FLAG_RESET"]/*' />
    [NativeTypeName("#define WRITE_WATCH_FLAG_RESET 0x01")]
    public const int WRITE_WATCH_FLAG_RESET = 0x01;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ENCLAVE_TYPE_SGX"]/*' />
    [NativeTypeName("#define ENCLAVE_TYPE_SGX 0x00000001")]
    public const int ENCLAVE_TYPE_SGX = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ENCLAVE_TYPE_SGX2"]/*' />
    [NativeTypeName("#define ENCLAVE_TYPE_SGX2 0x00000002")]
    public const int ENCLAVE_TYPE_SGX2 = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ENCLAVE_TYPE_VBS"]/*' />
    [NativeTypeName("#define ENCLAVE_TYPE_VBS 0x00000010")]
    public const int ENCLAVE_TYPE_VBS = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ENCLAVE_VBS_FLAG_DEBUG"]/*' />
    [NativeTypeName("#define ENCLAVE_VBS_FLAG_DEBUG 0x00000001")]
    public const int ENCLAVE_VBS_FLAG_DEBUG = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ENCLAVE_TYPE_VBS_BASIC"]/*' />
    [NativeTypeName("#define ENCLAVE_TYPE_VBS_BASIC 0x00000011")]
    public const int ENCLAVE_TYPE_VBS_BASIC = 0x00000011;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VBS_BASIC_PAGE_MEASURED_DATA"]/*' />
    [NativeTypeName("#define VBS_BASIC_PAGE_MEASURED_DATA 0x00000001")]
    public const int VBS_BASIC_PAGE_MEASURED_DATA = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VBS_BASIC_PAGE_UNMEASURED_DATA"]/*' />
    [NativeTypeName("#define VBS_BASIC_PAGE_UNMEASURED_DATA 0x00000002")]
    public const int VBS_BASIC_PAGE_UNMEASURED_DATA = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VBS_BASIC_PAGE_ZERO_FILL"]/*' />
    [NativeTypeName("#define VBS_BASIC_PAGE_ZERO_FILL 0x00000003")]
    public const int VBS_BASIC_PAGE_ZERO_FILL = 0x00000003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VBS_BASIC_PAGE_THREAD_DESCRIPTOR"]/*' />
    [NativeTypeName("#define VBS_BASIC_PAGE_THREAD_DESCRIPTOR 0x00000004")]
    public const int VBS_BASIC_PAGE_THREAD_DESCRIPTOR = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VBS_BASIC_PAGE_SYSTEM_CALL"]/*' />
    [NativeTypeName("#define VBS_BASIC_PAGE_SYSTEM_CALL 0x00000005")]
    public const int VBS_BASIC_PAGE_SYSTEM_CALL = 0x00000005;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DEDICATED_MEMORY_CACHE_ELIGIBLE"]/*' />
    [NativeTypeName("#define DEDICATED_MEMORY_CACHE_ELIGIBLE 0x1")]
    public const int DEDICATED_MEMORY_CACHE_ELIGIBLE = 0x1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TREE_CONNECT_ATTRIBUTE_PRIVACY"]/*' />
    [NativeTypeName("#define TREE_CONNECT_ATTRIBUTE_PRIVACY 0x00004000")]
    public const int TREE_CONNECT_ATTRIBUTE_PRIVACY = 0x00004000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TREE_CONNECT_ATTRIBUTE_INTEGRITY"]/*' />
    [NativeTypeName("#define TREE_CONNECT_ATTRIBUTE_INTEGRITY 0x00008000")]
    public const int TREE_CONNECT_ATTRIBUTE_INTEGRITY = 0x00008000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TREE_CONNECT_ATTRIBUTE_GLOBAL"]/*' />
    [NativeTypeName("#define TREE_CONNECT_ATTRIBUTE_GLOBAL 0x00000004")]
    public const int TREE_CONNECT_ATTRIBUTE_GLOBAL = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TREE_CONNECT_ATTRIBUTE_PINNED"]/*' />
    [NativeTypeName("#define TREE_CONNECT_ATTRIBUTE_PINNED 0x00000002")]
    public const int TREE_CONNECT_ATTRIBUTE_PINNED = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MAILSLOT_NO_MESSAGE"]/*' />
    [NativeTypeName("#define MAILSLOT_NO_MESSAGE ((DWORD)-1)")]
    public const uint MAILSLOT_NO_MESSAGE = unchecked((uint)(-1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MAILSLOT_WAIT_FOREVER"]/*' />
    [NativeTypeName("#define MAILSLOT_WAIT_FOREVER ((DWORD)-1)")]
    public const uint MAILSLOT_WAIT_FOREVER = unchecked((uint)(-1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LX_FILE_METADATA_HAS_UID"]/*' />
    [NativeTypeName("#define LX_FILE_METADATA_HAS_UID 0x1")]
    public const int LX_FILE_METADATA_HAS_UID = 0x1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LX_FILE_METADATA_HAS_GID"]/*' />
    [NativeTypeName("#define LX_FILE_METADATA_HAS_GID 0x2")]
    public const int LX_FILE_METADATA_HAS_GID = 0x2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LX_FILE_METADATA_HAS_MODE"]/*' />
    [NativeTypeName("#define LX_FILE_METADATA_HAS_MODE 0x4")]
    public const int LX_FILE_METADATA_HAS_MODE = 0x4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LX_FILE_METADATA_HAS_DEVICE_ID"]/*' />
    [NativeTypeName("#define LX_FILE_METADATA_HAS_DEVICE_ID 0x8")]
    public const int LX_FILE_METADATA_HAS_DEVICE_ID = 0x8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LX_FILE_CASE_SENSITIVE_DIR"]/*' />
    [NativeTypeName("#define LX_FILE_CASE_SENSITIVE_DIR 0x10")]
    public const int LX_FILE_CASE_SENSITIVE_DIR = 0x10;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLUSH_FLAGS_FILE_DATA_ONLY"]/*' />
    [NativeTypeName("#define FLUSH_FLAGS_FILE_DATA_ONLY 0x00000001")]
    public const int FLUSH_FLAGS_FILE_DATA_ONLY = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLUSH_FLAGS_NO_SYNC"]/*' />
    [NativeTypeName("#define FLUSH_FLAGS_NO_SYNC 0x00000002")]
    public const int FLUSH_FLAGS_NO_SYNC = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLUSH_FLAGS_FILE_DATA_SYNC_ONLY"]/*' />
    [NativeTypeName("#define FLUSH_FLAGS_FILE_DATA_SYNC_ONLY 0x00000004")]
    public const int FLUSH_FLAGS_FILE_DATA_SYNC_ONLY = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLUSH_FLAGS_FLUSH_AND_PURGE"]/*' />
    [NativeTypeName("#define FLUSH_FLAGS_FLUSH_AND_PURGE 0x00000008")]
    public const int FLUSH_FLAGS_FLUSH_AND_PURGE = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHUFFLE_FILE_FLAG_SKIP_INITIALIZING_NEW_CLUSTERS"]/*' />
    [NativeTypeName("#define SHUFFLE_FILE_FLAG_SKIP_INITIALIZING_NEW_CLUSTERS (0x00000001)")]
    public const int SHUFFLE_FILE_FLAG_SKIP_INITIALIZING_NEW_CLUSTERS = (0x00000001);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMB_CCF_APP_INSTANCE_EA_NAME"]/*' />
    [NativeTypeName("#define SMB_CCF_APP_INSTANCE_EA_NAME \"ClusteredApplicationInstance\"")]
    public static ReadOnlySpan<byte> SMB_CCF_APP_INSTANCE_EA_NAME => "ClusteredApplicationInstance"u8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NETWORK_APP_INSTANCE_CSV_FLAGS_VALID_ONLY_IF_CSV_COORDINATOR"]/*' />
    [NativeTypeName("#define NETWORK_APP_INSTANCE_CSV_FLAGS_VALID_ONLY_IF_CSV_COORDINATOR 0x00000001")]
    public const int NETWORK_APP_INSTANCE_CSV_FLAGS_VALID_ONLY_IF_CSV_COORDINATOR = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DUPLICATE_CLOSE_SOURCE"]/*' />
    [NativeTypeName("#define DUPLICATE_CLOSE_SOURCE 0x00000001")]
    public const int DUPLICATE_CLOSE_SOURCE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DUPLICATE_SAME_ACCESS"]/*' />
    [NativeTypeName("#define DUPLICATE_SAME_ACCESS 0x00000002")]
    public const int DUPLICATE_SAME_ACCESS = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERFSTATE_POLICY_CHANGE_IDEAL"]/*' />
    [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_IDEAL 0")]
    public const int PERFSTATE_POLICY_CHANGE_IDEAL = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERFSTATE_POLICY_CHANGE_SINGLE"]/*' />
    [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_SINGLE 1")]
    public const int PERFSTATE_POLICY_CHANGE_SINGLE = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERFSTATE_POLICY_CHANGE_ROCKET"]/*' />
    [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_ROCKET 2")]
    public const int PERFSTATE_POLICY_CHANGE_ROCKET = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE"]/*' />
    [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE 3")]
    public const int PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERFSTATE_POLICY_CHANGE_DECREASE_MAX"]/*' />
    [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_DECREASE_MAX PERFSTATE_POLICY_CHANGE_ROCKET")]
    public const int PERFSTATE_POLICY_CHANGE_DECREASE_MAX = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERFSTATE_POLICY_CHANGE_INCREASE_MAX"]/*' />
    [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_INCREASE_MAX PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE")]
    public const int PERFSTATE_POLICY_CHANGE_INCREASE_MAX = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CORE_PARKING_POLICY_CHANGE_IDEAL"]/*' />
    [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_IDEAL 0")]
    public const int CORE_PARKING_POLICY_CHANGE_IDEAL = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CORE_PARKING_POLICY_CHANGE_SINGLE"]/*' />
    [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_SINGLE 1")]
    public const int CORE_PARKING_POLICY_CHANGE_SINGLE = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CORE_PARKING_POLICY_CHANGE_ROCKET"]/*' />
    [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_ROCKET 2")]
    public const int CORE_PARKING_POLICY_CHANGE_ROCKET = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CORE_PARKING_POLICY_CHANGE_MULTISTEP"]/*' />
    [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_MULTISTEP 3")]
    public const int CORE_PARKING_POLICY_CHANGE_MULTISTEP = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CORE_PARKING_POLICY_CHANGE_MAX"]/*' />
    [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_MAX CORE_PARKING_POLICY_CHANGE_MULTISTEP")]
    public const int CORE_PARKING_POLICY_CHANGE_MAX = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PARKING_TOPOLOGY_POLICY_DISABLED"]/*' />
    [NativeTypeName("#define PARKING_TOPOLOGY_POLICY_DISABLED 0")]
    public const int PARKING_TOPOLOGY_POLICY_DISABLED = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PARKING_TOPOLOGY_POLICY_ROUNDROBIN"]/*' />
    [NativeTypeName("#define PARKING_TOPOLOGY_POLICY_ROUNDROBIN 1")]
    public const int PARKING_TOPOLOGY_POLICY_ROUNDROBIN = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PARKING_TOPOLOGY_POLICY_SEQUENTIAL"]/*' />
    [NativeTypeName("#define PARKING_TOPOLOGY_POLICY_SEQUENTIAL 2")]
    public const int PARKING_TOPOLOGY_POLICY_SEQUENTIAL = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PARKING_TOPOLOGY_POLICY_ROUNDROBIN_P_ROUNDROBIN_E"]/*' />
    [NativeTypeName("#define PARKING_TOPOLOGY_POLICY_ROUNDROBIN_P_ROUNDROBIN_E 3")]
    public const int PARKING_TOPOLOGY_POLICY_ROUNDROBIN_P_ROUNDROBIN_E = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PARKING_TOPOLOGY_POLICY_SEQUENTIAL_P_SEQUENTIAL_E"]/*' />
    [NativeTypeName("#define PARKING_TOPOLOGY_POLICY_SEQUENTIAL_P_SEQUENTIAL_E 4")]
    public const int PARKING_TOPOLOGY_POLICY_SEQUENTIAL_P_SEQUENTIAL_E = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PARKING_TOPOLOGY_POLICY_ROUNDROBIN_P_SEQUENTIAL_E"]/*' />
    [NativeTypeName("#define PARKING_TOPOLOGY_POLICY_ROUNDROBIN_P_SEQUENTIAL_E 5")]
    public const int PARKING_TOPOLOGY_POLICY_ROUNDROBIN_P_SEQUENTIAL_E = 5;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PARKING_TOPOLOGY_POLICY_SEQUENTIAL_P_ROUNDROBIN_E"]/*' />
    [NativeTypeName("#define PARKING_TOPOLOGY_POLICY_SEQUENTIAL_P_ROUNDROBIN_E 6")]
    public const int PARKING_TOPOLOGY_POLICY_SEQUENTIAL_P_ROUNDROBIN_E = 6;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMT_UNPARKING_POLICY_CORE"]/*' />
    [NativeTypeName("#define SMT_UNPARKING_POLICY_CORE 0")]
    public const int SMT_UNPARKING_POLICY_CORE = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMT_UNPARKING_POLICY_CORE_PER_THREAD"]/*' />
    [NativeTypeName("#define SMT_UNPARKING_POLICY_CORE_PER_THREAD 1")]
    public const int SMT_UNPARKING_POLICY_CORE_PER_THREAD = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMT_UNPARKING_POLICY_LP_ROUNDROBIN"]/*' />
    [NativeTypeName("#define SMT_UNPARKING_POLICY_LP_ROUNDROBIN 2")]
    public const int SMT_UNPARKING_POLICY_LP_ROUNDROBIN = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMT_UNPARKING_POLICY_LP_SEQUENTIAL"]/*' />
    [NativeTypeName("#define SMT_UNPARKING_POLICY_LP_SEQUENTIAL 3")]
    public const int SMT_UNPARKING_POLICY_LP_SEQUENTIAL = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DIAGNOSTIC_REASON_VERSION"]/*' />
    [NativeTypeName("#define DIAGNOSTIC_REASON_VERSION 0")]
    public const int DIAGNOSTIC_REASON_VERSION = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DIAGNOSTIC_REASON_SIMPLE_STRING"]/*' />
    [NativeTypeName("#define DIAGNOSTIC_REASON_SIMPLE_STRING 0x00000001")]
    public const int DIAGNOSTIC_REASON_SIMPLE_STRING = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DIAGNOSTIC_REASON_DETAILED_STRING"]/*' />
    [NativeTypeName("#define DIAGNOSTIC_REASON_DETAILED_STRING 0x00000002")]
    public const int DIAGNOSTIC_REASON_DETAILED_STRING = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DIAGNOSTIC_REASON_NOT_SPECIFIED"]/*' />
    [NativeTypeName("#define DIAGNOSTIC_REASON_NOT_SPECIFIED 0x80000000")]
    public const uint DIAGNOSTIC_REASON_NOT_SPECIFIED = 0x80000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DIAGNOSTIC_REASON_INVALID_FLAGS"]/*' />
    [NativeTypeName("#define DIAGNOSTIC_REASON_INVALID_FLAGS (~0x80000007)")]
    public const uint DIAGNOSTIC_REASON_INVALID_FLAGS = (~0x80000007);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PDCAP_D0_SUPPORTED"]/*' />
    [NativeTypeName("#define PDCAP_D0_SUPPORTED 0x00000001")]
    public const int PDCAP_D0_SUPPORTED = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PDCAP_D1_SUPPORTED"]/*' />
    [NativeTypeName("#define PDCAP_D1_SUPPORTED 0x00000002")]
    public const int PDCAP_D1_SUPPORTED = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PDCAP_D2_SUPPORTED"]/*' />
    [NativeTypeName("#define PDCAP_D2_SUPPORTED 0x00000004")]
    public const int PDCAP_D2_SUPPORTED = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PDCAP_D3_SUPPORTED"]/*' />
    [NativeTypeName("#define PDCAP_D3_SUPPORTED 0x00000008")]
    public const int PDCAP_D3_SUPPORTED = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PDCAP_WAKE_FROM_D0_SUPPORTED"]/*' />
    [NativeTypeName("#define PDCAP_WAKE_FROM_D0_SUPPORTED 0x00000010")]
    public const int PDCAP_WAKE_FROM_D0_SUPPORTED = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PDCAP_WAKE_FROM_D1_SUPPORTED"]/*' />
    [NativeTypeName("#define PDCAP_WAKE_FROM_D1_SUPPORTED 0x00000020")]
    public const int PDCAP_WAKE_FROM_D1_SUPPORTED = 0x00000020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PDCAP_WAKE_FROM_D2_SUPPORTED"]/*' />
    [NativeTypeName("#define PDCAP_WAKE_FROM_D2_SUPPORTED 0x00000040")]
    public const int PDCAP_WAKE_FROM_D2_SUPPORTED = 0x00000040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PDCAP_WAKE_FROM_D3_SUPPORTED"]/*' />
    [NativeTypeName("#define PDCAP_WAKE_FROM_D3_SUPPORTED 0x00000080")]
    public const int PDCAP_WAKE_FROM_D3_SUPPORTED = 0x00000080;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PDCAP_WARM_EJECT_SUPPORTED"]/*' />
    [NativeTypeName("#define PDCAP_WARM_EJECT_SUPPORTED 0x00000100")]
    public const int PDCAP_WARM_EJECT_SUPPORTED = 0x00000100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACPI_PPM_SOFTWARE_ALL"]/*' />
    [NativeTypeName("#define ACPI_PPM_SOFTWARE_ALL 0xFC")]
    public const int ACPI_PPM_SOFTWARE_ALL = 0xFC;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACPI_PPM_SOFTWARE_ANY"]/*' />
    [NativeTypeName("#define ACPI_PPM_SOFTWARE_ANY 0xFD")]
    public const int ACPI_PPM_SOFTWARE_ANY = 0xFD;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ACPI_PPM_HARDWARE_ALL"]/*' />
    [NativeTypeName("#define ACPI_PPM_HARDWARE_ALL 0xFE")]
    public const int ACPI_PPM_HARDWARE_ALL = 0xFE;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NUM_DISCHARGE_POLICIES"]/*' />
    [NativeTypeName("#define NUM_DISCHARGE_POLICIES 4")]
    public const int NUM_DISCHARGE_POLICIES = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DISCHARGE_POLICY_CRITICAL"]/*' />
    [NativeTypeName("#define DISCHARGE_POLICY_CRITICAL 0")]
    public const int DISCHARGE_POLICY_CRITICAL = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DISCHARGE_POLICY_LOW"]/*' />
    [NativeTypeName("#define DISCHARGE_POLICY_LOW 1")]
    public const int DISCHARGE_POLICY_LOW = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PO_THROTTLE_NONE"]/*' />
    [NativeTypeName("#define PO_THROTTLE_NONE 0")]
    public const int PO_THROTTLE_NONE = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PO_THROTTLE_CONSTANT"]/*' />
    [NativeTypeName("#define PO_THROTTLE_CONSTANT 1")]
    public const int PO_THROTTLE_CONSTANT = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PO_THROTTLE_DEGRADE"]/*' />
    [NativeTypeName("#define PO_THROTTLE_DEGRADE 2")]
    public const int PO_THROTTLE_DEGRADE = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PO_THROTTLE_ADAPTIVE"]/*' />
    [NativeTypeName("#define PO_THROTTLE_ADAPTIVE 3")]
    public const int PO_THROTTLE_ADAPTIVE = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PO_THROTTLE_MAXIMUM"]/*' />
    [NativeTypeName("#define PO_THROTTLE_MAXIMUM 4")]
    public const int PO_THROTTLE_MAXIMUM = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HIBERFILE_TYPE_NONE"]/*' />
    [NativeTypeName("#define HIBERFILE_TYPE_NONE 0x00")]
    public const int HIBERFILE_TYPE_NONE = 0x00;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HIBERFILE_TYPE_REDUCED"]/*' />
    [NativeTypeName("#define HIBERFILE_TYPE_REDUCED 0x01")]
    public const int HIBERFILE_TYPE_REDUCED = 0x01;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HIBERFILE_TYPE_FULL"]/*' />
    [NativeTypeName("#define HIBERFILE_TYPE_FULL 0x02")]
    public const int HIBERFILE_TYPE_FULL = 0x02;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HIBERFILE_TYPE_MAX"]/*' />
    [NativeTypeName("#define HIBERFILE_TYPE_MAX 0x03")]
    public const int HIBERFILE_TYPE_MAX = 0x03;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.N_BTMASK"]/*' />
    [NativeTypeName("#define N_BTMASK 0x000F")]
    public const int N_BTMASK = 0x000F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.N_TMASK"]/*' />
    [NativeTypeName("#define N_TMASK 0x0030")]
    public const int N_TMASK = 0x0030;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.N_TMASK1"]/*' />
    [NativeTypeName("#define N_TMASK1 0x00C0")]
    public const int N_TMASK1 = 0x00C0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.N_TMASK2"]/*' />
    [NativeTypeName("#define N_TMASK2 0x00F0")]
    public const int N_TMASK2 = 0x00F0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.N_BTSHFT"]/*' />
    [NativeTypeName("#define N_BTSHFT 4")]
    public const int N_BTSHFT = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.N_TSHIFT"]/*' />
    [NativeTypeName("#define N_TSHIFT 2")]
    public const int N_TSHIFT = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FRAME_FPO"]/*' />
    [NativeTypeName("#define FRAME_FPO 0")]
    public const int FRAME_FPO = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FRAME_TRAP"]/*' />
    [NativeTypeName("#define FRAME_TRAP 1")]
    public const int FRAME_TRAP = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FRAME_TSS"]/*' />
    [NativeTypeName("#define FRAME_TSS 2")]
    public const int FRAME_TSS = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FRAME_NONFPO"]/*' />
    [NativeTypeName("#define FRAME_NONFPO 3")]
    public const int FRAME_NONFPO = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZEOF_RFPO_DATA"]/*' />
    [NativeTypeName("#define SIZEOF_RFPO_DATA 16")]
    public const int SIZEOF_RFPO_DATA = 16;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NON_PAGED_DEBUG_SIGNATURE"]/*' />
    [NativeTypeName("#define NON_PAGED_DEBUG_SIGNATURE 0x494E")]
    public const int NON_PAGED_DEBUG_SIGNATURE = 0x494E;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMPORT_OBJECT_HDR_SIG2"]/*' />
    [NativeTypeName("#define IMPORT_OBJECT_HDR_SIG2 0xffff")]
    public const int IMPORT_OBJECT_HDR_SIG2 = 0xffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNWIND_HISTORY_TABLE_SIZE"]/*' />
    [NativeTypeName("#define UNWIND_HISTORY_TABLE_SIZE 12")]
    public const int UNWIND_HISTORY_TABLE_SIZE = 12;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMPRESSION_FORMAT_NONE"]/*' />
    [NativeTypeName("#define COMPRESSION_FORMAT_NONE (0x0000)")]
    public const int COMPRESSION_FORMAT_NONE = (0x0000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMPRESSION_FORMAT_DEFAULT"]/*' />
    [NativeTypeName("#define COMPRESSION_FORMAT_DEFAULT (0x0001)")]
    public const int COMPRESSION_FORMAT_DEFAULT = (0x0001);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMPRESSION_FORMAT_LZNT1"]/*' />
    [NativeTypeName("#define COMPRESSION_FORMAT_LZNT1 (0x0002)")]
    public const int COMPRESSION_FORMAT_LZNT1 = (0x0002);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMPRESSION_FORMAT_XPRESS"]/*' />
    [NativeTypeName("#define COMPRESSION_FORMAT_XPRESS (0x0003)")]
    public const int COMPRESSION_FORMAT_XPRESS = (0x0003);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMPRESSION_FORMAT_XPRESS_HUFF"]/*' />
    [NativeTypeName("#define COMPRESSION_FORMAT_XPRESS_HUFF (0x0004)")]
    public const int COMPRESSION_FORMAT_XPRESS_HUFF = (0x0004);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMPRESSION_FORMAT_XP10"]/*' />
    [NativeTypeName("#define COMPRESSION_FORMAT_XP10 (0x0005)")]
    public const int COMPRESSION_FORMAT_XP10 = (0x0005);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMPRESSION_FORMAT_LZ4"]/*' />
    [NativeTypeName("#define COMPRESSION_FORMAT_LZ4 (0x0006)")]
    public const int COMPRESSION_FORMAT_LZ4 = (0x0006);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMPRESSION_FORMAT_DEFLATE"]/*' />
    [NativeTypeName("#define COMPRESSION_FORMAT_DEFLATE (0x0007)")]
    public const int COMPRESSION_FORMAT_DEFLATE = (0x0007);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMPRESSION_FORMAT_ZLIB"]/*' />
    [NativeTypeName("#define COMPRESSION_FORMAT_ZLIB (0x0008)")]
    public const int COMPRESSION_FORMAT_ZLIB = (0x0008);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMPRESSION_ENGINE_STANDARD"]/*' />
    [NativeTypeName("#define COMPRESSION_ENGINE_STANDARD (0x0000)")]
    public const int COMPRESSION_ENGINE_STANDARD = (0x0000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMPRESSION_ENGINE_MAXIMUM"]/*' />
    [NativeTypeName("#define COMPRESSION_ENGINE_MAXIMUM (0x0100)")]
    public const int COMPRESSION_ENGINE_MAXIMUM = (0x0100);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.COMPRESSION_ENGINE_HIBER"]/*' />
    [NativeTypeName("#define COMPRESSION_ENGINE_HIBER (0x0200)")]
    public const int COMPRESSION_ENGINE_HIBER = (0x0200);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MESSAGE_RESOURCE_UNICODE"]/*' />
    [NativeTypeName("#define MESSAGE_RESOURCE_UNICODE 0x0001")]
    public const int MESSAGE_RESOURCE_UNICODE = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MESSAGE_RESOURCE_UTF8"]/*' />
    [NativeTypeName("#define MESSAGE_RESOURCE_UTF8 0x0002")]
    public const int MESSAGE_RESOURCE_UTF8 = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VRL_PREDEFINED_CLASS_BEGIN"]/*' />
    [NativeTypeName("#define VRL_PREDEFINED_CLASS_BEGIN (1 << 0)")]
    public const int VRL_PREDEFINED_CLASS_BEGIN = (1 << 0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VRL_CUSTOM_CLASS_BEGIN"]/*' />
    [NativeTypeName("#define VRL_CUSTOM_CLASS_BEGIN (1 << 8)")]
    public const int VRL_CUSTOM_CLASS_BEGIN = (1 << 8);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VRL_CLASS_CONSISTENCY"]/*' />
    [NativeTypeName("#define VRL_CLASS_CONSISTENCY (VRL_PREDEFINED_CLASS_BEGIN << 0)")]
    public const int VRL_CLASS_CONSISTENCY = ((1 << 0) << 0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VRL_ENABLE_KERNEL_BREAKS"]/*' />
    [NativeTypeName("#define VRL_ENABLE_KERNEL_BREAKS (1 << 31)")]
    public const int VRL_ENABLE_KERNEL_BREAKS = (1 << 31);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CTMF_INCLUDE_APPCONTAINER"]/*' />
    [NativeTypeName("#define CTMF_INCLUDE_APPCONTAINER 0x00000001UL")]
    public const uint CTMF_INCLUDE_APPCONTAINER = 0x00000001U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CTMF_INCLUDE_LPAC"]/*' />
    [NativeTypeName("#define CTMF_INCLUDE_LPAC 0x00000002UL")]
    public const uint CTMF_INCLUDE_LPAC = 0x00000002U;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CTMF_VALID_FLAGS"]/*' />
    [NativeTypeName("#define CTMF_VALID_FLAGS (CTMF_INCLUDE_APPCONTAINER | CTMF_INCLUDE_LPAC)")]
    public const uint CTMF_VALID_FLAGS = (0x00000001U | 0x00000002U);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLUSH_NV_MEMORY_IN_FLAG_NO_DRAIN"]/*' />
    [NativeTypeName("#define FLUSH_NV_MEMORY_IN_FLAG_NO_DRAIN (0x00000001)")]
    public const int FLUSH_NV_MEMORY_IN_FLAG_NO_DRAIN = (0x00000001);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLUSH_NV_MEMORY_DEFAULT_TOKEN"]/*' />
    [NativeTypeName("#define FLUSH_NV_MEMORY_DEFAULT_TOKEN (ULONG_PTR)(-1)")]
    public static nuint FLUSH_NV_MEMORY_DEFAULT_TOKEN => unchecked((nuint)(-1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WRITE_NV_MEMORY_FLAG_FLUSH"]/*' />
    [NativeTypeName("#define WRITE_NV_MEMORY_FLAG_FLUSH (0x00000001)")]
    public const int WRITE_NV_MEMORY_FLAG_FLUSH = (0x00000001);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WRITE_NV_MEMORY_FLAG_NON_TEMPORAL"]/*' />
    [NativeTypeName("#define WRITE_NV_MEMORY_FLAG_NON_TEMPORAL (0x00000002)")]
    public const int WRITE_NV_MEMORY_FLAG_NON_TEMPORAL = (0x00000002);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WRITE_NV_MEMORY_FLAG_PERSIST"]/*' />
    [NativeTypeName("#define WRITE_NV_MEMORY_FLAG_PERSIST (WRITE_NV_MEMORY_FLAG_FLUSH \\\r\n                                              | WRITE_NV_MEMORY_FLAG_NON_TEMPORAL)")]
    public const int WRITE_NV_MEMORY_FLAG_PERSIST = ((0x00000001) | (0x00000002));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WRITE_NV_MEMORY_FLAG_NO_DRAIN"]/*' />
    [NativeTypeName("#define WRITE_NV_MEMORY_FLAG_NO_DRAIN (0x00000100)")]
    public const int WRITE_NV_MEMORY_FLAG_NO_DRAIN = (0x00000100);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FILL_NV_MEMORY_FLAG_FLUSH"]/*' />
    [NativeTypeName("#define FILL_NV_MEMORY_FLAG_FLUSH (0x00000001)")]
    public const int FILL_NV_MEMORY_FLAG_FLUSH = (0x00000001);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FILL_NV_MEMORY_FLAG_NON_TEMPORAL"]/*' />
    [NativeTypeName("#define FILL_NV_MEMORY_FLAG_NON_TEMPORAL (0x00000002)")]
    public const int FILL_NV_MEMORY_FLAG_NON_TEMPORAL = (0x00000002);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FILL_NV_MEMORY_FLAG_PERSIST"]/*' />
    [NativeTypeName("#define FILL_NV_MEMORY_FLAG_PERSIST (FILL_NV_MEMORY_FLAG_FLUSH \\\r\n                                              | FILL_NV_MEMORY_FLAG_NON_TEMPORAL)")]
    public const int FILL_NV_MEMORY_FLAG_PERSIST = ((0x00000001) | (0x00000002));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FILL_NV_MEMORY_FLAG_NO_DRAIN"]/*' />
    [NativeTypeName("#define FILL_NV_MEMORY_FLAG_NO_DRAIN (0x00000100)")]
    public const int FILL_NV_MEMORY_FLAG_NO_DRAIN = (0x00000100);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERFORMANCE_DATA_VERSION"]/*' />
    [NativeTypeName("#define PERFORMANCE_DATA_VERSION 1")]
    public const int PERFORMANCE_DATA_VERSION = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNIFIEDBUILDREVISION_KEY"]/*' />
    [NativeTypeName("#define UNIFIEDBUILDREVISION_KEY L\"\\Registry\\Machine\\Software\\Microsoft\\Windows NT\\CurrentVersion\"")]
    public const string UNIFIEDBUILDREVISION_KEY = "\\Registry\\Machine\\Software\\Microsoft\\Windows NT\\CurrentVersion";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNIFIEDBUILDREVISION_VALUE"]/*' />
    [NativeTypeName("#define UNIFIEDBUILDREVISION_VALUE L\"UBR\"")]
    public const string UNIFIEDBUILDREVISION_VALUE = "UBR";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UNIFIEDBUILDREVISION_MIN"]/*' />
    [NativeTypeName("#define UNIFIEDBUILDREVISION_MIN 0x00000000")]
    public const int UNIFIEDBUILDREVISION_MIN = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DLL_PROCESS_ATTACH"]/*' />
    [NativeTypeName("#define DLL_PROCESS_ATTACH 1")]
    public const int DLL_PROCESS_ATTACH = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DLL_THREAD_ATTACH"]/*' />
    [NativeTypeName("#define DLL_THREAD_ATTACH 2")]
    public const int DLL_THREAD_ATTACH = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DLL_THREAD_DETACH"]/*' />
    [NativeTypeName("#define DLL_THREAD_DETACH 3")]
    public const int DLL_THREAD_DETACH = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DLL_PROCESS_DETACH"]/*' />
    [NativeTypeName("#define DLL_PROCESS_DETACH 0")]
    public const int DLL_PROCESS_DETACH = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MAXLOGICALLOGNAMESIZE"]/*' />
    [NativeTypeName("#define MAXLOGICALLOGNAMESIZE 256")]
    public const int MAXLOGICALLOGNAMESIZE = 256;
}
