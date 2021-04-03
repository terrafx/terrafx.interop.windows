// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct VARIANT
    {
        [NativeTypeName("tagVARIANT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/OAIdl.h:470:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref ushort vt
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.vt, 1));
            }
        }

        public ref ushort wReserved1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.wReserved1, 1));
            }
        }

        public ref ushort wReserved2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.wReserved2, 1));
            }
        }

        public ref ushort wReserved3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.wReserved3, 1));
            }
        }

        public ref long llVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.llVal, 1));
            }
        }

        public ref int lVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.lVal, 1));
            }
        }

        public ref byte bVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.bVal, 1));
            }
        }

        public ref short iVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.iVal, 1));
            }
        }

        public ref float fltVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.fltVal, 1));
            }
        }

        public ref double dblVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.dblVal, 1));
            }
        }

        public ref short boolVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.boolVal, 1));
            }
        }

        public ref short __OBSOLETE__VARIANT_BOOL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.__OBSOLETE__VARIANT_BOOL, 1));
            }
        }

        public ref int scode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.scode, 1));
            }
        }

        public ref CY cyVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cyVal, 1));
            }
        }

        public ref double date
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.date, 1));
            }
        }

        public ref ushort* bstrVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->bstrVal;
                }
            }
        }

        public ref IUnknown* punkVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->punkVal;
                }
            }
        }

        public ref IDispatch* pdispVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pdispVal;
                }
            }
        }

        public ref SAFEARRAY* parray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->parray;
                }
            }
        }

        public ref byte* pbVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pbVal;
                }
            }
        }

        public ref short* piVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->piVal;
                }
            }
        }

        public ref int* plVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->plVal;
                }
            }
        }

        public ref long* pllVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pllVal;
                }
            }
        }

        public ref float* pfltVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pfltVal;
                }
            }
        }

        public ref double* pdblVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pdblVal;
                }
            }
        }

        public ref short* pboolVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pboolVal;
                }
            }
        }

        public ref short* __OBSOLETE__VARIANT_PBOOL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->__OBSOLETE__VARIANT_PBOOL;
                }
            }
        }

        public ref int* pscode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pscode;
                }
            }
        }

        public ref CY* pcyVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pcyVal;
                }
            }
        }

        public ref double* pdate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pdate;
                }
            }
        }

        public ref ushort** pbstrVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pbstrVal;
                }
            }
        }

        public ref IUnknown** ppunkVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->ppunkVal;
                }
            }
        }

        public ref IDispatch** ppdispVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->ppdispVal;
                }
            }
        }

        public ref SAFEARRAY** pparray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pparray;
                }
            }
        }

        public ref VARIANT* pvarVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pvarVal;
                }
            }
        }

        public ref void* byref
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->byref;
                }
            }
        }

        public ref sbyte cVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cVal, 1));
            }
        }

        public ref ushort uiVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.uiVal, 1));
            }
        }

        public ref uint ulVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.ulVal, 1));
            }
        }

        public ref ulong ullVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.ullVal, 1));
            }
        }

        public ref int intVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.intVal, 1));
            }
        }

        public ref uint uintVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.uintVal, 1));
            }
        }

        public ref DECIMAL* pdecVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pdecVal;
                }
            }
        }

        public ref sbyte* pcVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pcVal;
                }
            }
        }

        public ref ushort* puiVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->puiVal;
                }
            }
        }

        public ref uint* pulVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pulVal;
                }
            }
        }

        public ref ulong* pullVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pullVal;
                }
            }
        }

        public ref int* pintVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pintVal;
                }
            }
        }

        public ref uint* puintVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union* pField = &Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->puintVal;
                }
            }
        }

        public ref void* pvRecord
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pvRecord;
                }
            }
        }

        public ref IRecordInfo* pRecInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct._Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous.Anonymous.Anonymous)
                {
                    return ref pField->pRecInfo;
                }
            }
        }

        public ref DECIMAL decVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.decVal, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("tagVARIANT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/OAIdl.h:472:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            public DECIMAL decVal;

            public unsafe partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("VARTYPE")]
                public ushort vt;

                [NativeTypeName("WORD")]
                public ushort wReserved1;

                [NativeTypeName("WORD")]
                public ushort wReserved2;

                [NativeTypeName("WORD")]
                public ushort wReserved3;

                [NativeTypeName("tagVARIANT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/OAIdl.h:478:13)")]
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
                    public ushort* bstrVal;

                    [FieldOffset(0)]
                    public IUnknown* punkVal;

                    [FieldOffset(0)]
                    public IDispatch* pdispVal;

                    [FieldOffset(0)]
                    public SAFEARRAY* parray;

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
                    [NativeTypeName("VARIANT_BOOL *")]
                    public short* __OBSOLETE__VARIANT_PBOOL;

                    [FieldOffset(0)]
                    [NativeTypeName("SCODE *")]
                    public int* pscode;

                    [FieldOffset(0)]
                    public CY* pcyVal;

                    [FieldOffset(0)]
                    [NativeTypeName("DATE *")]
                    public double* pdate;

                    [FieldOffset(0)]
                    [NativeTypeName("BSTR *")]
                    public ushort** pbstrVal;

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

                    [FieldOffset(0)]
                    [NativeTypeName("tagVARIANT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/OAIdl.h:525:17)")]
                    public _Anonymous_e__Struct Anonymous;

                    public unsafe partial struct _Anonymous_e__Struct
                    {
                        [NativeTypeName("PVOID")]
                        public void* pvRecord;

                        public IRecordInfo* pRecInfo;
                    }
                }
            }
        }
    }
}
