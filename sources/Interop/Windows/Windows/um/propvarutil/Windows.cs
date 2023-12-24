// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propvarutil.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromResource"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromResource(HINSTANCE hinst, uint id, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromBuffer"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromBuffer([NativeTypeName("const void *")] void* pv, uint cb, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromCLSID"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromCLSID([NativeTypeName("const IID &")] Guid* clsid, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromGUIDAsString"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromGUIDAsString([NativeTypeName("const GUID &")] Guid* guid, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromFileTime"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromFileTime([NativeTypeName("const FILETIME *")] FILETIME* pftIn, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromPropVariantVectorElem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromPropVariantVectorElem([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, [NativeTypeName("ULONG")] uint iElem, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantVectorFromPropVariant"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantVectorFromPropVariant([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarSingle, PROPVARIANT* ppropvarVector);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromStrRet"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromStrRet(STRRET* pstrret, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromBooleanVector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromBooleanVector([NativeTypeName("const BOOL *")] BOOL* prgf, [NativeTypeName("ULONG")] uint cElems, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromInt16Vector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromInt16Vector([NativeTypeName("const SHORT *")] short* prgn, [NativeTypeName("ULONG")] uint cElems, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromUInt16Vector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromUInt16Vector([NativeTypeName("const USHORT *")] ushort* prgn, [NativeTypeName("ULONG")] uint cElems, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromInt32Vector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromInt32Vector([NativeTypeName("const LONG *")] int* prgn, [NativeTypeName("ULONG")] uint cElems, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromUInt32Vector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromUInt32Vector([NativeTypeName("const ULONG *")] uint* prgn, [NativeTypeName("ULONG")] uint cElems, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromInt64Vector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromInt64Vector([NativeTypeName("const LONGLONG *")] long* prgn, [NativeTypeName("ULONG")] uint cElems, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromUInt64Vector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromUInt64Vector([NativeTypeName("const ULONGLONG *")] ulong* prgn, [NativeTypeName("ULONG")] uint cElems, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromDoubleVector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromDoubleVector([NativeTypeName("const DOUBLE *")] double* prgn, [NativeTypeName("ULONG")] uint cElems, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromFileTimeVector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromFileTimeVector([NativeTypeName("const FILETIME *")] FILETIME* prgft, [NativeTypeName("ULONG")] uint cElems, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromStringVector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromStringVector([NativeTypeName("PCWSTR *")] char** prgsz, [NativeTypeName("ULONG")] uint cElems, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromStringAsVector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromStringAsVector([NativeTypeName("PCWSTR")] char* psz, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToBooleanWithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern BOOL PropVariantToBooleanWithDefault([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, BOOL fDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToInt16WithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern short PropVariantToInt16WithDefault([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, short iDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToUInt16WithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern ushort PropVariantToUInt16WithDefault([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, ushort uiDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToInt32WithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int PropVariantToInt32WithDefault([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, [NativeTypeName("LONG")] int lDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToUInt32WithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint PropVariantToUInt32WithDefault([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, [NativeTypeName("ULONG")] uint ulDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToInt64WithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("LONGLONG")]
    public static extern long PropVariantToInt64WithDefault([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, [NativeTypeName("LONGLONG")] long llDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToUInt64WithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("ULONGLONG")]
    public static extern ulong PropVariantToUInt64WithDefault([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, [NativeTypeName("ULONGLONG")] ulong ullDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToDoubleWithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern double PropVariantToDoubleWithDefault([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, double dblDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToStringWithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("PCWSTR")]
    public static extern char* PropVariantToStringWithDefault([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, [NativeTypeName("LPCWSTR")] char* pszDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToBoolean"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToBoolean([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, BOOL* pfRet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToInt16"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToInt16([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, short* piRet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToUInt16"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToUInt16([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, ushort* puiRet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToInt64"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToInt64([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, [NativeTypeName("LONGLONG *")] long* pllRet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToUInt64"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToUInt64([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, [NativeTypeName("ULONGLONG *")] ulong* pullRet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToDouble"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToDouble([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn, double* pdblRet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToBuffer"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToBuffer([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, void* pv, uint cb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToString"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToString([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("PWSTR")] char* psz, uint cch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToGUID"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToGUID([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, Guid* pguid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToStringAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToStringAlloc([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("PWSTR *")] char** ppszOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToBSTR"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToBSTR([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("BSTR *")] char** pbstrOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToStrRet"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToStrRet([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, STRRET* pstrret);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToFileTime"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToFileTime([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("PSTIME_FLAGS")] int pstfOut, FILETIME* pftOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantGetElementCount"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint PropVariantGetElementCount([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToBooleanVector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToBooleanVector([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, BOOL* prgf, [NativeTypeName("ULONG")] uint crgf, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToInt16Vector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToInt16Vector([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, short* prgn, [NativeTypeName("ULONG")] uint crgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToUInt16Vector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToUInt16Vector([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, ushort* prgn, [NativeTypeName("ULONG")] uint crgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToInt32Vector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToInt32Vector([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("LONG *")] int* prgn, [NativeTypeName("ULONG")] uint crgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToUInt32Vector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToUInt32Vector([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("ULONG *")] uint* prgn, [NativeTypeName("ULONG")] uint crgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToInt64Vector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToInt64Vector([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("LONGLONG *")] long* prgn, [NativeTypeName("ULONG")] uint crgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToUInt64Vector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToUInt64Vector([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("ULONGLONG *")] ulong* prgn, [NativeTypeName("ULONG")] uint crgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToDoubleVector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToDoubleVector([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, double* prgn, [NativeTypeName("ULONG")] uint crgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToFileTimeVector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToFileTimeVector([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, FILETIME* prgft, [NativeTypeName("ULONG")] uint crgft, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToStringVector"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToStringVector([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("PWSTR *")] char** prgsz, [NativeTypeName("ULONG")] uint crgsz, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToBooleanVectorAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToBooleanVectorAlloc([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, BOOL** pprgf, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToInt16VectorAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToInt16VectorAlloc([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, short** pprgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToUInt16VectorAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToUInt16VectorAlloc([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, ushort** pprgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToInt32VectorAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToInt32VectorAlloc([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("LONG **")] int** pprgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToUInt32VectorAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToUInt32VectorAlloc([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("ULONG **")] uint** pprgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToInt64VectorAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToInt64VectorAlloc([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("LONGLONG **")] long** pprgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToUInt64VectorAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToUInt64VectorAlloc([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("ULONGLONG **")] ulong** pprgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToDoubleVectorAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToDoubleVectorAlloc([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, double** pprgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToFileTimeVectorAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToFileTimeVectorAlloc([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, FILETIME** pprgft, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToStringVectorAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToStringVectorAlloc([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("PWSTR **")] char*** pprgsz, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantGetBooleanElem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetBooleanElem([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("ULONG")] uint iElem, BOOL* pfVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantGetInt16Elem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetInt16Elem([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("ULONG")] uint iElem, short* pnVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantGetUInt16Elem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetUInt16Elem([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("ULONG")] uint iElem, ushort* pnVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantGetInt32Elem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetInt32Elem([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("ULONG")] uint iElem, [NativeTypeName("LONG *")] int* pnVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantGetUInt32Elem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetUInt32Elem([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("ULONG")] uint iElem, [NativeTypeName("ULONG *")] uint* pnVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantGetInt64Elem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetInt64Elem([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("ULONG")] uint iElem, [NativeTypeName("LONGLONG *")] long* pnVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantGetUInt64Elem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetUInt64Elem([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("ULONG")] uint iElem, [NativeTypeName("ULONGLONG *")] ulong* pnVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantGetDoubleElem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetDoubleElem([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("ULONG")] uint iElem, double* pnVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantGetFileTimeElem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetFileTimeElem([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("ULONG")] uint iElem, FILETIME* pftVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantGetStringElem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetStringElem([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("ULONG")] uint iElem, [NativeTypeName("PWSTR *")] char** ppszVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ClearPropVariantArray"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern void ClearPropVariantArray(PROPVARIANT* rgPropVar, uint cVars);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantCompareEx"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern int PropVariantCompareEx([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar1, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar2, PROPVAR_COMPARE_UNIT unit, [NativeTypeName("PROPVAR_COMPARE_FLAGS")] int flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantChangeType"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantChangeType(PROPVARIANT* ppropvarDest, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarSrc, [NativeTypeName("PROPVAR_CHANGE_FLAGS")] int flags, [NativeTypeName("VARTYPE")] ushort vt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToVariant"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToVariant([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pPropVar, VARIANT* pVar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToPropVariant"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToPropVariant([NativeTypeName("const VARIANT *")] VARIANT* pVar, PROPVARIANT* pPropVar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgSerializePropVariant"]/*' />
    [DllImport("propsys.dll", ExactSpelling = true)]
    public static extern HRESULT StgSerializePropVariant([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* ppropvar, SERIALIZEDPROPERTYVALUE** ppProp, [NativeTypeName("ULONG *")] uint* pcb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgDeserializePropVariant"]/*' />
    [DllImport("propsys.dll", ExactSpelling = true)]
    public static extern HRESULT StgDeserializePropVariant([NativeTypeName("const SERIALIZEDPROPERTYVALUE *")] SERIALIZEDPROPERTYVALUE* pprop, [NativeTypeName("ULONG")] uint cbMax, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromResource"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromResource(HINSTANCE hinst, uint id, VARIANT* pvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromBuffer"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromBuffer([NativeTypeName("const void *")] void* pv, uint cb, VARIANT* pvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromGUIDAsString"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromGUIDAsString([NativeTypeName("const GUID &")] Guid* guid, VARIANT* pvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromFileTime"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromFileTime([NativeTypeName("const FILETIME *")] FILETIME* pft, VARIANT* pvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromFileTimeArray"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromFileTimeArray([NativeTypeName("const FILETIME *")] FILETIME* prgft, [NativeTypeName("ULONG")] uint cElems, VARIANT* pvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromStrRet"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromStrRet(STRRET* pstrret, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, VARIANT* pvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromVariantArrayElem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromVariantArrayElem([NativeTypeName("const VARIANT &")] VARIANT* varIn, [NativeTypeName("ULONG")] uint iElem, VARIANT* pvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromBooleanArray"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromBooleanArray([NativeTypeName("const BOOL *")] BOOL* prgf, [NativeTypeName("ULONG")] uint cElems, VARIANT* pvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromInt16Array"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromInt16Array([NativeTypeName("const SHORT *")] short* prgn, [NativeTypeName("ULONG")] uint cElems, VARIANT* pvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromUInt16Array"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromUInt16Array([NativeTypeName("const USHORT *")] ushort* prgn, [NativeTypeName("ULONG")] uint cElems, VARIANT* pvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromInt32Array"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromInt32Array([NativeTypeName("const LONG *")] int* prgn, [NativeTypeName("ULONG")] uint cElems, VARIANT* pvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromUInt32Array"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromUInt32Array([NativeTypeName("const ULONG *")] uint* prgn, [NativeTypeName("ULONG")] uint cElems, VARIANT* pvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromInt64Array"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromInt64Array([NativeTypeName("const LONGLONG *")] long* prgn, [NativeTypeName("ULONG")] uint cElems, VARIANT* pvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromUInt64Array"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromUInt64Array([NativeTypeName("const ULONGLONG *")] ulong* prgn, [NativeTypeName("ULONG")] uint cElems, VARIANT* pvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromDoubleArray"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromDoubleArray([NativeTypeName("const DOUBLE *")] double* prgn, [NativeTypeName("ULONG")] uint cElems, VARIANT* pvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromStringArray"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromStringArray([NativeTypeName("PCWSTR *")] char** prgsz, [NativeTypeName("ULONG")] uint cElems, VARIANT* pvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToBooleanWithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern BOOL VariantToBooleanWithDefault([NativeTypeName("const VARIANT &")] VARIANT* varIn, BOOL fDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToInt16WithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern short VariantToInt16WithDefault([NativeTypeName("const VARIANT &")] VARIANT* varIn, short iDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToUInt16WithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern ushort VariantToUInt16WithDefault([NativeTypeName("const VARIANT &")] VARIANT* varIn, ushort uiDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToInt32WithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int VariantToInt32WithDefault([NativeTypeName("const VARIANT &")] VARIANT* varIn, [NativeTypeName("LONG")] int lDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToUInt32WithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint VariantToUInt32WithDefault([NativeTypeName("const VARIANT &")] VARIANT* varIn, [NativeTypeName("ULONG")] uint ulDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToInt64WithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("LONGLONG")]
    public static extern long VariantToInt64WithDefault([NativeTypeName("const VARIANT &")] VARIANT* varIn, [NativeTypeName("LONGLONG")] long llDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToUInt64WithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("ULONGLONG")]
    public static extern ulong VariantToUInt64WithDefault([NativeTypeName("const VARIANT &")] VARIANT* varIn, [NativeTypeName("ULONGLONG")] ulong ullDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToDoubleWithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern double VariantToDoubleWithDefault([NativeTypeName("const VARIANT &")] VARIANT* varIn, double dblDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToStringWithDefault"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("PCWSTR")]
    public static extern char* VariantToStringWithDefault([NativeTypeName("const VARIANT &")] VARIANT* varIn, [NativeTypeName("LPCWSTR")] char* pszDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToBoolean"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToBoolean([NativeTypeName("const VARIANT &")] VARIANT* varIn, BOOL* pfRet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToInt16"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToInt16([NativeTypeName("const VARIANT &")] VARIANT* varIn, short* piRet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToUInt16"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToUInt16([NativeTypeName("const VARIANT &")] VARIANT* varIn, ushort* puiRet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToInt64"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToInt64([NativeTypeName("const VARIANT &")] VARIANT* varIn, [NativeTypeName("LONGLONG *")] long* pllRet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToUInt64"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToUInt64([NativeTypeName("const VARIANT &")] VARIANT* varIn, [NativeTypeName("ULONGLONG *")] ulong* pullRet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToDouble"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToDouble([NativeTypeName("const VARIANT &")] VARIANT* varIn, double* pdblRet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToBuffer"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToBuffer([NativeTypeName("const VARIANT &")] VARIANT* varIn, void* pv, uint cb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToGUID"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToGUID([NativeTypeName("const VARIANT &")] VARIANT* varIn, Guid* pguid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToString"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToString([NativeTypeName("const VARIANT &")] VARIANT* varIn, [NativeTypeName("PWSTR")] char* pszBuf, uint cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToStringAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToStringAlloc([NativeTypeName("const VARIANT &")] VARIANT* varIn, [NativeTypeName("PWSTR *")] char** ppszBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToDosDateTime"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToDosDateTime([NativeTypeName("const VARIANT &")] VARIANT* varIn, [NativeTypeName("WORD *")] ushort* pwDate, [NativeTypeName("WORD *")] ushort* pwTime);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToStrRet"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToStrRet([NativeTypeName("const VARIANT &")] VARIANT* varIn, STRRET* pstrret);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToFileTime"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToFileTime([NativeTypeName("const VARIANT &")] VARIANT* varIn, [NativeTypeName("PSTIME_FLAGS")] int stfOut, FILETIME* pftOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantGetElementCount"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint VariantGetElementCount([NativeTypeName("const VARIANT &")] VARIANT* varIn);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToBooleanArray"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToBooleanArray([NativeTypeName("const VARIANT &")] VARIANT* var, BOOL* prgf, [NativeTypeName("ULONG")] uint crgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToInt16Array"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToInt16Array([NativeTypeName("const VARIANT &")] VARIANT* var, short* prgn, [NativeTypeName("ULONG")] uint crgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToUInt16Array"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToUInt16Array([NativeTypeName("const VARIANT &")] VARIANT* var, ushort* prgn, [NativeTypeName("ULONG")] uint crgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToInt32Array"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToInt32Array([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("LONG *")] int* prgn, [NativeTypeName("ULONG")] uint crgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToUInt32Array"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToUInt32Array([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("ULONG *")] uint* prgn, [NativeTypeName("ULONG")] uint crgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToInt64Array"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToInt64Array([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("LONGLONG *")] long* prgn, [NativeTypeName("ULONG")] uint crgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToUInt64Array"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToUInt64Array([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("ULONGLONG *")] ulong* prgn, [NativeTypeName("ULONG")] uint crgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToDoubleArray"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToDoubleArray([NativeTypeName("const VARIANT &")] VARIANT* var, double* prgn, [NativeTypeName("ULONG")] uint crgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToStringArray"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToStringArray([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("PWSTR *")] char** prgsz, [NativeTypeName("ULONG")] uint crgsz, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToBooleanArrayAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToBooleanArrayAlloc([NativeTypeName("const VARIANT &")] VARIANT* var, BOOL** pprgf, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToInt16ArrayAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToInt16ArrayAlloc([NativeTypeName("const VARIANT &")] VARIANT* var, short** pprgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToUInt16ArrayAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToUInt16ArrayAlloc([NativeTypeName("const VARIANT &")] VARIANT* var, ushort** pprgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToInt32ArrayAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToInt32ArrayAlloc([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("LONG **")] int** pprgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToUInt32ArrayAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToUInt32ArrayAlloc([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("ULONG **")] uint** pprgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToInt64ArrayAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToInt64ArrayAlloc([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("LONGLONG **")] long** pprgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToUInt64ArrayAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToUInt64ArrayAlloc([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("ULONGLONG **")] ulong** pprgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToDoubleArrayAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToDoubleArrayAlloc([NativeTypeName("const VARIANT &")] VARIANT* var, double** pprgn, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToStringArrayAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToStringArrayAlloc([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("PWSTR **")] char*** pprgsz, [NativeTypeName("ULONG *")] uint* pcElem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantGetBooleanElem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetBooleanElem([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("ULONG")] uint iElem, BOOL* pfVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantGetInt16Elem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetInt16Elem([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("ULONG")] uint iElem, short* pnVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantGetUInt16Elem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetUInt16Elem([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("ULONG")] uint iElem, ushort* pnVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantGetInt32Elem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetInt32Elem([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("ULONG")] uint iElem, [NativeTypeName("LONG *")] int* pnVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantGetUInt32Elem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetUInt32Elem([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("ULONG")] uint iElem, [NativeTypeName("ULONG *")] uint* pnVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantGetInt64Elem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetInt64Elem([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("ULONG")] uint iElem, [NativeTypeName("LONGLONG *")] long* pnVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantGetUInt64Elem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetUInt64Elem([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("ULONG")] uint iElem, [NativeTypeName("ULONGLONG *")] ulong* pnVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantGetDoubleElem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetDoubleElem([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("ULONG")] uint iElem, double* pnVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantGetStringElem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetStringElem([NativeTypeName("const VARIANT &")] VARIANT* var, [NativeTypeName("ULONG")] uint iElem, [NativeTypeName("PWSTR *")] char** ppszVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ClearVariantArray"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern void ClearVariantArray(VARIANT* pvars, uint cvars);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantCompare"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern int VariantCompare([NativeTypeName("const VARIANT &")] VARIANT* var1, [NativeTypeName("const VARIANT &")] VARIANT* var2);
}
