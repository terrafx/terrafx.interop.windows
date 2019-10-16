// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propidlbase.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROPVARIANT
    {
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            public DECIMAL decVal;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("VARTYPE")]
                public ushort vt;

                [NativeTypeName("PROPVAR_PAD1")]
                public ushort wReserved1;

                [NativeTypeName("PROPVAR_PAD1")]
                public ushort wReserved2;

                [NativeTypeName("PROPVAR_PAD1")]
                public ushort wReserved3;

                public _Anonymous_e__Union Anonymous;

                [StructLayout(LayoutKind.Explicit)]
                public partial struct _Anonymous_e__Union
                {
                    [FieldOffset(0)]
                    [NativeTypeName("CHAR")]
                    public sbyte cVal;

                    [FieldOffset(0)]
                    [NativeTypeName("UCHAR")]
                    public byte bVal;

                    [FieldOffset(0)]
                    [NativeTypeName("SHORT")]
                    public short iVal;

                    [FieldOffset(0)]
                    [NativeTypeName("USHORT")]
                    public ushort uiVal;

                    [FieldOffset(0)]
                    [NativeTypeName("LONG")]
                    public int lVal;

                    [FieldOffset(0)]
                    [NativeTypeName("ULONG")]
                    public uint ulVal;

                    [FieldOffset(0)]
                    [NativeTypeName("INT")]
                    public int intVal;

                    [FieldOffset(0)]
                    [NativeTypeName("UINT")]
                    public uint uintVal;

                    [FieldOffset(0)]
                    public LARGE_INTEGER hVal;

                    [FieldOffset(0)]
                    public ULARGE_INTEGER uhVal;

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
                    public FILETIME filetime;

                    [FieldOffset(0)]
                    [NativeTypeName("CLSID")]
                    public Guid* puuid;

                    [FieldOffset(0)]
                    public CLIPDATA* pclipdata;

                    [FieldOffset(0)]
                    [NativeTypeName("BSTR")]
                    public ushort* bstrVal;

                    [FieldOffset(0)]
                    public BSTRBLOB bstrblobVal;

                    [FieldOffset(0)]
                    public BLOB blob;

                    [FieldOffset(0)]
                    [NativeTypeName("LPSTR")]
                    public sbyte* pszVal;

                    [FieldOffset(0)]
                    [NativeTypeName("LPWSTR")]
                    public ushort* pwszVal;

                    [FieldOffset(0)]
                    public IUnknown* punkVal;

                    [FieldOffset(0)]
                    public IDispatch* pdispVal;

                    [FieldOffset(0)]
                    public IStream* pStream;

                    [FieldOffset(0)]
                    public IStorage* pStorage;

                    [FieldOffset(0)]
                    [NativeTypeName("LPVERSIONEDSTREAM")]
                    public VERSIONEDSTREAM* pVersionedStream;

                    [FieldOffset(0)]
                    [NativeTypeName("LPSAFEARRAY")]
                    public SAFEARRAY* parray;

                    [FieldOffset(0)]
                    public CAC cac;

                    [FieldOffset(0)]
                    public CAUB caub;

                    [FieldOffset(0)]
                    public CAI cai;

                    [FieldOffset(0)]
                    public CAUI caui;

                    [FieldOffset(0)]
                    public CAL cal;

                    [FieldOffset(0)]
                    public CAUL caul;

                    [FieldOffset(0)]
                    public CAH cah;

                    [FieldOffset(0)]
                    public CAUH cauh;

                    [FieldOffset(0)]
                    public CAFLT caflt;

                    [FieldOffset(0)]
                    public CADBL cadbl;

                    [FieldOffset(0)]
                    public CABOOL cabool;

                    [FieldOffset(0)]
                    public CASCODE cascode;

                    [FieldOffset(0)]
                    public CACY cacy;

                    [FieldOffset(0)]
                    public CADATE cadate;

                    [FieldOffset(0)]
                    public CAFILETIME cafiletime;

                    [FieldOffset(0)]
                    public CACLSID cauuid;

                    [FieldOffset(0)]
                    public CACLIPDATA caclipdata;

                    [FieldOffset(0)]
                    public CABSTR cabstr;

                    [FieldOffset(0)]
                    public CABSTRBLOB cabstrblob;

                    [FieldOffset(0)]
                    public CALPSTR calpstr;

                    [FieldOffset(0)]
                    public CALPWSTR calpwstr;

                    [FieldOffset(0)]
                    public CAPROPVARIANT capropvar;

                    [FieldOffset(0)]
                    [NativeTypeName("CHAR")]
                    public sbyte* pcVal;

                    [FieldOffset(0)]
                    [NativeTypeName("UCHAR")]
                    public byte* pbVal;

                    [FieldOffset(0)]
                    [NativeTypeName("SHORT")]
                    public short* piVal;

                    [FieldOffset(0)]
                    [NativeTypeName("USHORT")]
                    public ushort* puiVal;

                    [FieldOffset(0)]
                    [NativeTypeName("LONG")]
                    public int* plVal;

                    [FieldOffset(0)]
                    [NativeTypeName("ULONG")]
                    public uint* pulVal;

                    [FieldOffset(0)]
                    [NativeTypeName("INT")]
                    public int* pintVal;

                    [FieldOffset(0)]
                    [NativeTypeName("UINT")]
                    public uint* puintVal;

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
                    public DECIMAL* pdecVal;

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
                    public ushort** pbstrVal;

                    [FieldOffset(0)]
                    public IUnknown** ppunkVal;

                    [FieldOffset(0)]
                    public IDispatch** ppdispVal;

                    [FieldOffset(0)]
                    [NativeTypeName("LPSAFEARRAY")]
                    public SAFEARRAY** pparray;

                    [FieldOffset(0)]
                    public PROPVARIANT* pvarVal;
                }
            }
        }
    }
}
