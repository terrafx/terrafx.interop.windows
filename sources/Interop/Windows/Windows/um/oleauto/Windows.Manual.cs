// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleauto.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

// VarI4FromUI8 and VarI4FromI8 show up twice in OleAuto.h.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [return: NativeTypeName("ULONG")]
    public static uint LHashValOfName(uint lcid, char* szName)
        => LHashValOfNameSys(SYSKIND.SYS_WIN32, lcid, szName);

    [return: NativeTypeName("USHORT")]
    public static ushort WHashValOfLHashVal(uint lhashval)
        => (ushort)(0x0000FFFF & lhashval);

    [return: NativeTypeName("BOOL")]
    public static BOOL IsHashValCompatible(uint lhashval1, uint lhashval2)
        => ((0x00FF0000 & lhashval1) == (0x00FF0000 & lhashval2));

    [return: NativeTypeName("LONG")]
    public static int VarI4FromI4(int lIn, int* plOut) => (*plOut = lIn);

    [return: NativeTypeName("LONG64")]
    public static long VarI8FromI8(long i64In, long* pi64Out) => (*pi64Out = i64In);

    [return: NativeTypeName("ULONG")]
    public static uint VarUI4FromUI4(uint ulIn, uint* pulOut) => (*pulOut = ulIn);

    [return: NativeTypeName("ULONG64")]
    public static ulong VarUI8FromUI8(ulong ui64In, ulong* pi64Out) => (*pi64Out = ui64In);

    [return: NativeTypeName("HRESULT")]
    public static HRESULT VarUI8FromI4(int lIn, ulong* pi64Out) => VarUI8FromI8(lIn, pi64Out);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VarI4FromI8"]/*' />
    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromI8([NativeTypeName("LONG64")] long i64In, [NativeTypeName("LONG *")] int* plOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VarI4FromUI8"]/*' />
    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromUI8([NativeTypeName("ULONG64")] ulong ui64In, [NativeTypeName("LONG *")] int* plOut);
}
