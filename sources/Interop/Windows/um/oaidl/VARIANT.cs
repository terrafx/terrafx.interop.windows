// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe struct VARIANT
    {
        #region Fields
        public _Anonymous_e__Union Anonymous;
        #endregion

        #region Structs
        [StructLayout(LayoutKind.Explicit)]
        public struct _Anonymous_e__Union
        {
            #region Fields
            [FieldOffset(0)]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            public DECIMAL decVal;
            #endregion

            #region Structs
            public struct _Anonymous_e__Struct
            {
                #region Fields
                [NativeTypeName("VARTYPE")]
                public ushort vt;

                [NativeTypeName("WORD")]
                public ushort wReserved1;

                [NativeTypeName("WORD")]
                public ushort wReserved2;

                [NativeTypeName("WORD")]
                public ushort wReserved3;

                public _Anonymous_e__Union Anonymous;
                #endregion

                #region Structs
                [StructLayout(LayoutKind.Explicit)]
                public struct _Anonymous_e__Union
                {
                    #region Fields
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
                    [NativeTypeName("VARIANT_BOOL")]
                    public short __OBSOLETE__VARIANT_BOOL;

                    [FieldOffset(0)]
                    [NativeTypeName("SCODE")]
                    public int scode;

                    [FieldOffset(0)]
                    public CY cyVal;

                    [FieldOffset(0)]
                    [NativeTypeName("DATE")]
                    public double date;

                    [FieldOffset(0)]
                    [NativeTypeName("BSTR")]
                    public char* bstrVal;

                    [FieldOffset(0)]
                    public IUnknown* punkVal;

                    [FieldOffset(0)]
                    public IDispatch* pdispVal;

                    [FieldOffset(0)]
                    public SAFEARRAY* parray;

                    [FieldOffset(0)]
                    [NativeTypeName("BYTE")]
                    public byte* pbVal;

                    [FieldOffset(0)]
                    [NativeTypeName("SHORT")]
                    public short* piVal;

                    [FieldOffset(0)]
                    [NativeTypeName("LONG")]
                    public int* plVal;

                    [FieldOffset(0)]
                    [NativeTypeName("LONGLONG")]
                    public long* pllVal;

                    [FieldOffset(0)]
                    [NativeTypeName("FLOAT")]
                    public float* pfltVal;

                    [FieldOffset(0)]
                    [NativeTypeName("DOUBLE")]
                    public double* pdblVal;

                    [FieldOffset(0)]
                    [NativeTypeName("VARIANT_BOOL")]
                    public short* pboolVal;

                    [FieldOffset(0)]
                    [NativeTypeName("VARIANT_BOOL")]
                    public short* __OBSOLETE__VARIANT_PBOOL;

                    [FieldOffset(0)]
                    [NativeTypeName("SCODE")]
                    public int* pscode;

                    [FieldOffset(0)]
                    public CY* pcyVal;

                    [FieldOffset(0)]
                    [NativeTypeName("DATE")]
                    public double* pdate;

                    [FieldOffset(0)]
                    [NativeTypeName("BSTR")]
                    public char** pbstrVal;

                    [FieldOffset(0)]
                    public IUnknown** ppunkVal;

                    [FieldOffset(0)]
                    public IDispatch** ppdispVal;

                    [FieldOffset(0)]
                    public SAFEARRAY** pparray;

                    [FieldOffset(0)]
                    public VARIANT* pvarVal;

                    [FieldOffset(0)]
                    [NativeTypeName("PVOID")]
                    public void* byref;

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
                    public DECIMAL* pdecVal;

                    [FieldOffset(0)]
                    [NativeTypeName("CHAR")]
                    public sbyte* pcVal;

                    [FieldOffset(0)]
                    [NativeTypeName("USHORT")]
                    public ushort* puiVal;

                    [FieldOffset(0)]
                    [NativeTypeName("ULONG")]
                    public uint* pulVal;

                    [FieldOffset(0)]
                    [NativeTypeName("ULONGLONG")]
                    public ulong* pullVal;

                    [FieldOffset(0)]
                    [NativeTypeName("INT")]
                    public int* pintVal;

                    [FieldOffset(0)]
                    [NativeTypeName("UINT")]
                    public uint* puintVal;

                    [FieldOffset(0)]
                    public _Anonymous_e__Struct Anonymous;
                    #endregion

                    #region Structs
                    public struct _Anonymous_e__Struct
                    {
                        #region Fields
                        [NativeTypeName("PVOID")]
                        public void* pvRecord;

                        public IRecordInfo* pRecInfo;
                        #endregion
                    }
                    #endregion
                }
                #endregion
            }
            #endregion
        }
        #endregion
    }
}
