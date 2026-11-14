// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public static void* VOID_OFFSET(void* pv, uint cb) => ((byte*)pv) + cb;

    public static ITEMIDLIST* ILSkip([NativeTypeName("PCUIDLIST_RELATIVE")] ITEMIDLIST* pidl, uint cb)
        => (ITEMIDLIST*)VOID_OFFSET(pidl, cb);

    public static ITEMIDLIST* ILNext([NativeTypeName("PCUIDLIST_RELATIVE")] ITEMIDLIST* pidl)
        => ILSkip(pidl, pidl->mkid.cb);

    public static BOOL ILIsAligned([NativeTypeName("PCUIDLIST_RELATIVE")] ITEMIDLIST* pidl)
        => (((nuint)pidl & ((nuint)sizeof(void*) - 1)) == 0);

    public static BOOL ILIsEmpty([NativeTypeName("PCUIDLIST_RELATIVE")] ITEMIDLIST* pidl)
        => (pidl == null) || (pidl->mkid.cb == 0);

    public static BOOL ILIsChild([NativeTypeName("PCUIDLIST_RELATIVE")] ITEMIDLIST* pidl)
        => ILIsEmpty(pidl) || ILIsEmpty(ILNext(pidl));

    [NativeTypeName("#define SHELLSTATE_SIZE_WIN95 FIELD_OFFSET(SHELLSTATE,lParamSort)")]
    public static uint SHELLSTATE_SIZE_WIN95
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out SHELLSTATEW tmp);
            return unchecked((uint)(&tmp.lParamSort) - (uint)(&tmp));
        }
    }

    [NativeTypeName("#define SHELLSTATE_SIZE_NT4 FIELD_OFFSET(SHELLSTATE,version)")]
    public static uint SHELLSTATE_SIZE_NT4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out SHELLSTATEW tmp);
            return unchecked((uint)(&tmp.version) - (uint)(&tmp));
        }
    }

    [NativeTypeName("#define SHELLSTATE_SIZE_IE4 FIELD_OFFSET(SHELLSTATE,uNotUsed)")]
    public static uint SHELLSTATE_SIZE_IE4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out SHELLSTATEW tmp);
            return unchecked((uint)(&tmp.uNotUsed) - (uint)(&tmp));
        }
    }
}
