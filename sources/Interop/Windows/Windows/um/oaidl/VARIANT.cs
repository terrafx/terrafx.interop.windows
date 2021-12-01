// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='VARIANT.xml' path='doc/member[@name="VARIANT"]/*' />
public unsafe partial struct VARIANT
{
    /// <include file='VARIANT.xml' path='doc/member[@name="VARIANT.Anonymous"]/*' />
    [NativeTypeName("tagVARIANT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/oaidl.h:478:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.vt"]/*' />
    public ref ushort vt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.vt, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wReserved1"]/*' />
    public ref ushort wReserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.wReserved1, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wReserved2"]/*' />
    public ref ushort wReserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.wReserved2, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wReserved3"]/*' />
    public ref ushort wReserved3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.wReserved3, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.llVal"]/*' />
    public ref long llVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.llVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lVal"]/*' />
    public ref int lVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.lVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bVal"]/*' />
    public ref byte bVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.bVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.iVal"]/*' />
    public ref short iVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.iVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.fltVal"]/*' />
    public ref float fltVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.fltVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dblVal"]/*' />
    public ref double dblVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.dblVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.boolVal"]/*' />
    public ref short boolVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.boolVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.__OBSOLETE__VARIANT_BOOL"]/*' />
    public ref short __OBSOLETE__VARIANT_BOOL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.__OBSOLETE__VARIANT_BOOL, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.scode"]/*' />
    public ref int scode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.scode, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cyVal"]/*' />
    public ref CY cyVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cyVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.date"]/*' />
    public ref double date
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.date, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bstrVal"]/*' />
    public ref ushort* bstrVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.bstrVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.punkVal"]/*' />
    public ref IUnknown* punkVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.punkVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdispVal"]/*' />
    public ref IDispatch* pdispVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pdispVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.parray"]/*' />
    public ref SAFEARRAY* parray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.parray;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pbVal"]/*' />
    public ref byte* pbVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pbVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.piVal"]/*' />
    public ref short* piVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.piVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.plVal"]/*' />
    public ref int* plVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.plVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pllVal"]/*' />
    public ref long* pllVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pllVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pfltVal"]/*' />
    public ref float* pfltVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pfltVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdblVal"]/*' />
    public ref double* pdblVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pdblVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pboolVal"]/*' />
    public ref short* pboolVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pboolVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.__OBSOLETE__VARIANT_PBOOL"]/*' />
    public ref short* __OBSOLETE__VARIANT_PBOOL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.__OBSOLETE__VARIANT_PBOOL;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pscode"]/*' />
    public ref int* pscode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pscode;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pcyVal"]/*' />
    public ref CY* pcyVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pcyVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdate"]/*' />
    public ref double* pdate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pdate;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pbstrVal"]/*' />
    public ref ushort** pbstrVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pbstrVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ppunkVal"]/*' />
    public ref IUnknown** ppunkVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.ppunkVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ppdispVal"]/*' />
    public ref IDispatch** ppdispVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.ppdispVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pparray"]/*' />
    public ref SAFEARRAY** pparray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pparray;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pvarVal"]/*' />
    public ref VARIANT* pvarVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pvarVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.byref"]/*' />
    public ref void* byref
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.byref;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cVal"]/*' />
    public ref sbyte cVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uiVal"]/*' />
    public ref ushort uiVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.uiVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ulVal"]/*' />
    public ref uint ulVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.ulVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ullVal"]/*' />
    public ref ulong ullVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.ullVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.intVal"]/*' />
    public ref int intVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.intVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uintVal"]/*' />
    public ref uint uintVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.uintVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdecVal"]/*' />
    public ref DECIMAL* pdecVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pdecVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pcVal"]/*' />
    public ref sbyte* pcVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pcVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.puiVal"]/*' />
    public ref ushort* puiVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.puiVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pulVal"]/*' />
    public ref uint* pulVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pulVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pullVal"]/*' />
    public ref ulong* pullVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pullVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pintVal"]/*' />
    public ref int* pintVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pintVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.puintVal"]/*' />
    public ref uint* puintVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.puintVal;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.pvRecord"]/*' />
    public ref void* pvRecord
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.Anonymous.pvRecord;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.pRecInfo"]/*' />
    public ref IRecordInfo* pRecInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.Anonymous.pRecInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.decVal"]/*' />
    public ref DECIMAL decVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.decVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("tagVARIANT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/oaidl.h:480:9)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.decVal"]/*' />
        [FieldOffset(0)]
        public DECIMAL decVal;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public unsafe partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.vt"]/*' />
            [NativeTypeName("VARTYPE")]
            public ushort vt;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wReserved1"]/*' />
            [NativeTypeName("WORD")]
            public ushort wReserved1;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wReserved2"]/*' />
            [NativeTypeName("WORD")]
            public ushort wReserved2;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wReserved3"]/*' />
            [NativeTypeName("WORD")]
            public ushort wReserved3;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Anonymous"]/*' />
            [NativeTypeName("tagVARIANT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/oaidl.h:486:13)")]
            public _Anonymous_e__Union Anonymous;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
            [StructLayout(LayoutKind.Explicit)]
            public unsafe partial struct _Anonymous_e__Union
            {
                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.llVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LONGLONG")]
                public long llVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LONG")]
                public int lVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bVal"]/*' />
                [FieldOffset(0)]
                public byte bVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.iVal"]/*' />
                [FieldOffset(0)]
                public short iVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.fltVal"]/*' />
                [FieldOffset(0)]
                public float fltVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dblVal"]/*' />
                [FieldOffset(0)]
                public double dblVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.boolVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("VARIANT_BOOL")]
                public short boolVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.__OBSOLETE__VARIANT_BOOL"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("VARIANT_BOOL")]
                public short __OBSOLETE__VARIANT_BOOL;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.scode"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("SCODE")]
                public int scode;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cyVal"]/*' />
                [FieldOffset(0)]
                public CY cyVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.date"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("DATE")]
                public double date;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bstrVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("BSTR")]
                public ushort* bstrVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.punkVal"]/*' />
                [FieldOffset(0)]
                public IUnknown* punkVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdispVal"]/*' />
                [FieldOffset(0)]
                public IDispatch* pdispVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.parray"]/*' />
                [FieldOffset(0)]
                public SAFEARRAY* parray;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pbVal"]/*' />
                [FieldOffset(0)]
                public byte* pbVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.piVal"]/*' />
                [FieldOffset(0)]
                public short* piVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.plVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LONG *")]
                public int* plVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pllVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LONGLONG *")]
                public long* pllVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pfltVal"]/*' />
                [FieldOffset(0)]
                public float* pfltVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdblVal"]/*' />
                [FieldOffset(0)]
                public double* pdblVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pboolVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("VARIANT_BOOL *")]
                public short* pboolVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.__OBSOLETE__VARIANT_PBOOL"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("VARIANT_BOOL *")]
                public short* __OBSOLETE__VARIANT_PBOOL;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pscode"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("SCODE *")]
                public int* pscode;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pcyVal"]/*' />
                [FieldOffset(0)]
                public CY* pcyVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdate"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("DATE *")]
                public double* pdate;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pbstrVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("BSTR *")]
                public ushort** pbstrVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ppunkVal"]/*' />
                [FieldOffset(0)]
                public IUnknown** ppunkVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ppdispVal"]/*' />
                [FieldOffset(0)]
                public IDispatch** ppdispVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pparray"]/*' />
                [FieldOffset(0)]
                public SAFEARRAY** pparray;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pvarVal"]/*' />
                [FieldOffset(0)]
                public VARIANT* pvarVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.byref"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("PVOID")]
                public void* byref;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("CHAR")]
                public sbyte cVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uiVal"]/*' />
                [FieldOffset(0)]
                public ushort uiVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ulVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("ULONG")]
                public uint ulVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ullVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("ULONGLONG")]
                public ulong ullVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.intVal"]/*' />
                [FieldOffset(0)]
                public int intVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uintVal"]/*' />
                [FieldOffset(0)]
                public uint uintVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdecVal"]/*' />
                [FieldOffset(0)]
                public DECIMAL* pdecVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pcVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("CHAR *")]
                public sbyte* pcVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.puiVal"]/*' />
                [FieldOffset(0)]
                public ushort* puiVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pulVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("ULONG *")]
                public uint* pulVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pullVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("ULONGLONG *")]
                public ulong* pullVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pintVal"]/*' />
                [FieldOffset(0)]
                public int* pintVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.puintVal"]/*' />
                [FieldOffset(0)]
                public uint* puintVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("tagVARIANT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/oaidl.h:533:17)")]
                public _Anonymous_e__Struct Anonymous;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
                public unsafe partial struct _Anonymous_e__Struct
                {
                    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.pvRecord"]/*' />
                    [NativeTypeName("PVOID")]
                    public void* pvRecord;

                    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.pRecInfo"]/*' />
                    public IRecordInfo* pRecInfo;
                }
            }
        }
    }
}
