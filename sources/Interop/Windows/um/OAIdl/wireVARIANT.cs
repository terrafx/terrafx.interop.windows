// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct wireVARIANT
    {
        [NativeTypeName("DWORD")]
        public uint clSize;

        [NativeTypeName("DWORD")]
        public uint rpcReserved;

        [NativeTypeName("USHORT")]
        public ushort vt;

        [NativeTypeName("USHORT")]
        public ushort wReserved1;

        [NativeTypeName("USHORT")]
        public ushort wReserved2;

        [NativeTypeName("USHORT")]
        public ushort wReserved3;

        [NativeTypeName("_wireVARIANT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/OAIdl.h:573:36)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("LONGLONG")]
            public long llVal;

            [FieldOffset(0)]
            [NativeTypeName("LONG")]
            public int lVal;

            [FieldOffset(0)]
            [NativeTypeName("BYTE")]
            public byte bVal;

            [FieldOffset(0)]
            [NativeTypeName("SHORT")]
            public short iVal;

            [FieldOffset(0)]
            [NativeTypeName("FLOAT")]
            public float fltVal;

            [FieldOffset(0)]
            [NativeTypeName("DOUBLE")]
            public double dblVal;

            [FieldOffset(0)]
            [NativeTypeName("VARIANT_BOOL")]
            public short boolVal;

            [FieldOffset(0)]
            [NativeTypeName("SCODE")]
            public int scode;

            [FieldOffset(0)]
            public CY cyVal;

            [FieldOffset(0)]
            [NativeTypeName("DATE")]
            public double date;

            [FieldOffset(0)]
            [NativeTypeName("wireBSTR")]
            public FLAGGED_WORD_BLOB* bstrVal;

            [FieldOffset(0)]
            [NativeTypeName("IUnknown *")]
            public IUnknown* punkVal;

            [FieldOffset(0)]
            [NativeTypeName("IDispatch *")]
            public IDispatch* pdispVal;

            [FieldOffset(0)]
            [NativeTypeName("wirePSAFEARRAY")]
            public wireSAFEARRAY** parray;

            [FieldOffset(0)]
            [NativeTypeName("wireBRECORD")]
            public wireBRECORD* brecVal;

            [FieldOffset(0)]
            [NativeTypeName("BYTE *")]
            public byte* pbVal;

            [FieldOffset(0)]
            [NativeTypeName("SHORT *")]
            public short* piVal;

            [FieldOffset(0)]
            [NativeTypeName("LONG *")]
            public int* plVal;

            [FieldOffset(0)]
            [NativeTypeName("LONGLONG *")]
            public long* pllVal;

            [FieldOffset(0)]
            [NativeTypeName("FLOAT *")]
            public float* pfltVal;

            [FieldOffset(0)]
            [NativeTypeName("DOUBLE *")]
            public double* pdblVal;

            [FieldOffset(0)]
            [NativeTypeName("VARIANT_BOOL *")]
            public short* pboolVal;

            [FieldOffset(0)]
            [NativeTypeName("SCODE *")]
            public int* pscode;

            [FieldOffset(0)]
            [NativeTypeName("CY *")]
            public CY* pcyVal;

            [FieldOffset(0)]
            [NativeTypeName("DATE *")]
            public double* pdate;

            [FieldOffset(0)]
            [NativeTypeName("wireBSTR *")]
            public FLAGGED_WORD_BLOB** pbstrVal;

            [FieldOffset(0)]
            [NativeTypeName("IUnknown **")]
            public IUnknown** ppunkVal;

            [FieldOffset(0)]
            [NativeTypeName("IDispatch **")]
            public IDispatch** ppdispVal;

            [FieldOffset(0)]
            [NativeTypeName("wirePSAFEARRAY *")]
            public wireSAFEARRAY*** pparray;

            [FieldOffset(0)]
            [NativeTypeName("wireVARIANT *")]
            public wireVARIANT** pvarVal;

            [FieldOffset(0)]
            [NativeTypeName("CHAR")]
            public sbyte cVal;

            [FieldOffset(0)]
            [NativeTypeName("USHORT")]
            public ushort uiVal;

            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint ulVal;

            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong ullVal;

            [FieldOffset(0)]
            [NativeTypeName("INT")]
            public int intVal;

            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint uintVal;

            [FieldOffset(0)]
            public DECIMAL decVal;

            [FieldOffset(0)]
            [NativeTypeName("DECIMAL *")]
            public DECIMAL* pdecVal;

            [FieldOffset(0)]
            [NativeTypeName("CHAR *")]
            public sbyte* pcVal;

            [FieldOffset(0)]
            [NativeTypeName("USHORT *")]
            public ushort* puiVal;

            [FieldOffset(0)]
            [NativeTypeName("ULONG *")]
            public uint* pulVal;

            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG *")]
            public ulong* pullVal;

            [FieldOffset(0)]
            [NativeTypeName("INT *")]
            public int* pintVal;

            [FieldOffset(0)]
            [NativeTypeName("UINT *")]
            public uint* puintVal;
        }
    }
}
