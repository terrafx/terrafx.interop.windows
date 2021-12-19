// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='PROPVARIANT.xml' path='doc/member[@name="PROPVARIANT"]/*' />
public unsafe partial struct PROPVARIANT
{
    /// <include file='PROPVARIANT.xml' path='doc/member[@name="PROPVARIANT.Anonymous"]/*' />
    [NativeTypeName("tagPROPVARIANT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/PropIdlBase.h:303:3)")]
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

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cVal"]/*' />
    public ref sbyte cVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cVal, 1));
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

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uiVal"]/*' />
    public ref ushort uiVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.uiVal, 1));
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

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ulVal"]/*' />
    public ref uint ulVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.ulVal, 1));
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

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hVal"]/*' />
    public ref LARGE_INTEGER hVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.hVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uhVal"]/*' />
    public ref ULARGE_INTEGER uhVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.uhVal, 1));
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

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.filetime"]/*' />
    public ref FILETIME filetime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.filetime, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.puuid"]/*' />
    public ref Guid* puuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.puuid;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pclipdata"]/*' />
    public ref CLIPDATA* pclipdata
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pclipdata;
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

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bstrblobVal"]/*' />
    public ref BSTRBLOB bstrblobVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.bstrblobVal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.blob"]/*' />
    public ref BLOB blob
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.blob, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pszVal"]/*' />
    public ref sbyte* pszVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pszVal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszVal"]/*' />
    public ref ushort* pwszVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pwszVal;
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

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pStream"]/*' />
    public ref IStream* pStream
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pStream;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pStorage"]/*' />
    public ref IStorage* pStorage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pStorage;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pVersionedStream"]/*' />
    public ref VERSIONEDSTREAM* pVersionedStream
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pVersionedStream;
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

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cac"]/*' />
    public ref CAC cac
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cac, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caub"]/*' />
    public ref CAUB caub
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.caub, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cai"]/*' />
    public ref CAI cai
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cai, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caui"]/*' />
    public ref CAUI caui
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.caui, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cal"]/*' />
    public ref CAL cal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cal, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caul"]/*' />
    public ref CAUL caul
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.caul, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cah"]/*' />
    public ref CAH cah
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cah, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cauh"]/*' />
    public ref CAUH cauh
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cauh, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caflt"]/*' />
    public ref CAFLT caflt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.caflt, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cadbl"]/*' />
    public ref CADBL cadbl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cadbl, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cabool"]/*' />
    public ref CABOOL cabool
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cabool, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cascode"]/*' />
    public ref CASCODE cascode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cascode, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cacy"]/*' />
    public ref CACY cacy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cacy, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cadate"]/*' />
    public ref CADATE cadate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cadate, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cafiletime"]/*' />
    public ref CAFILETIME cafiletime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cafiletime, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cauuid"]/*' />
    public ref CACLSID cauuid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cauuid, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caclipdata"]/*' />
    public ref CACLIPDATA caclipdata
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.caclipdata, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cabstr"]/*' />
    public ref CABSTR cabstr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cabstr, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cabstrblob"]/*' />
    public ref CABSTRBLOB cabstrblob
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.cabstrblob, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.calpstr"]/*' />
    public ref CALPSTR calpstr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.calpstr, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.calpwstr"]/*' />
    public ref CALPWSTR calpwstr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.calpwstr, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.capropvar"]/*' />
    public ref CAPROPVARIANT capropvar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Anonymous.capropvar, 1));
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

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.puiVal"]/*' />
    public ref ushort* puiVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.puiVal;
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

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pulVal"]/*' />
    public ref uint* pulVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pulVal;
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

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdecVal"]/*' />
    public ref DECIMAL* pdecVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pdecVal;
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
    public ref PROPVARIANT* pvarVal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.Anonymous.Anonymous.pvarVal;
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
        [NativeTypeName("tagPROPVARIANT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/PropIdlBase.h:305:1)")]
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
            [NativeTypeName("PROPVAR_PAD1")]
            public ushort wReserved1;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wReserved2"]/*' />
            [NativeTypeName("PROPVAR_PAD2")]
            public ushort wReserved2;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wReserved3"]/*' />
            [NativeTypeName("PROPVAR_PAD3")]
            public ushort wReserved3;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Anonymous"]/*' />
            [NativeTypeName("tagPROPVARIANT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/PropIdlBase.h:311:43)")]
            public _Anonymous_e__Union Anonymous;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
            [StructLayout(LayoutKind.Explicit)]
            public unsafe partial struct _Anonymous_e__Union
            {
                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("CHAR")]
                public sbyte cVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("UCHAR")]
                public byte bVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.iVal"]/*' />
                [FieldOffset(0)]
                public short iVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uiVal"]/*' />
                [FieldOffset(0)]
                public ushort uiVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.lVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LONG")]
                public int lVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ulVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("ULONG")]
                public uint ulVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.intVal"]/*' />
                [FieldOffset(0)]
                public int intVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uintVal"]/*' />
                [FieldOffset(0)]
                public uint uintVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hVal"]/*' />
                [FieldOffset(0)]
                public LARGE_INTEGER hVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uhVal"]/*' />
                [FieldOffset(0)]
                public ULARGE_INTEGER uhVal;

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

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.filetime"]/*' />
                [FieldOffset(0)]
                public FILETIME filetime;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.puuid"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("CLSID *")]
                public Guid* puuid;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pclipdata"]/*' />
                [FieldOffset(0)]
                public CLIPDATA* pclipdata;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bstrVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("BSTR")]
                public ushort* bstrVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bstrblobVal"]/*' />
                [FieldOffset(0)]
                public BSTRBLOB bstrblobVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.blob"]/*' />
                [FieldOffset(0)]
                public BLOB blob;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pszVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LPSTR")]
                public sbyte* pszVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LPWSTR")]
                public ushort* pwszVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.punkVal"]/*' />
                [FieldOffset(0)]
                public IUnknown* punkVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdispVal"]/*' />
                [FieldOffset(0)]
                public IDispatch* pdispVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pStream"]/*' />
                [FieldOffset(0)]
                public IStream* pStream;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pStorage"]/*' />
                [FieldOffset(0)]
                public IStorage* pStorage;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pVersionedStream"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LPVERSIONEDSTREAM")]
                public VERSIONEDSTREAM* pVersionedStream;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.parray"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LPSAFEARRAY")]
                public SAFEARRAY* parray;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cac"]/*' />
                [FieldOffset(0)]
                public CAC cac;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caub"]/*' />
                [FieldOffset(0)]
                public CAUB caub;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cai"]/*' />
                [FieldOffset(0)]
                public CAI cai;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caui"]/*' />
                [FieldOffset(0)]
                public CAUI caui;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cal"]/*' />
                [FieldOffset(0)]
                public CAL cal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caul"]/*' />
                [FieldOffset(0)]
                public CAUL caul;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cah"]/*' />
                [FieldOffset(0)]
                public CAH cah;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cauh"]/*' />
                [FieldOffset(0)]
                public CAUH cauh;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caflt"]/*' />
                [FieldOffset(0)]
                public CAFLT caflt;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cadbl"]/*' />
                [FieldOffset(0)]
                public CADBL cadbl;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cabool"]/*' />
                [FieldOffset(0)]
                public CABOOL cabool;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cascode"]/*' />
                [FieldOffset(0)]
                public CASCODE cascode;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cacy"]/*' />
                [FieldOffset(0)]
                public CACY cacy;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cadate"]/*' />
                [FieldOffset(0)]
                public CADATE cadate;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cafiletime"]/*' />
                [FieldOffset(0)]
                public CAFILETIME cafiletime;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cauuid"]/*' />
                [FieldOffset(0)]
                public CACLSID cauuid;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.caclipdata"]/*' />
                [FieldOffset(0)]
                public CACLIPDATA caclipdata;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cabstr"]/*' />
                [FieldOffset(0)]
                public CABSTR cabstr;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cabstrblob"]/*' />
                [FieldOffset(0)]
                public CABSTRBLOB cabstrblob;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.calpstr"]/*' />
                [FieldOffset(0)]
                public CALPSTR calpstr;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.calpwstr"]/*' />
                [FieldOffset(0)]
                public CALPWSTR calpwstr;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.capropvar"]/*' />
                [FieldOffset(0)]
                public CAPROPVARIANT capropvar;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pcVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("CHAR *")]
                public sbyte* pcVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pbVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("UCHAR *")]
                public byte* pbVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.piVal"]/*' />
                [FieldOffset(0)]
                public short* piVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.puiVal"]/*' />
                [FieldOffset(0)]
                public ushort* puiVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.plVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("LONG *")]
                public int* plVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pulVal"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("ULONG *")]
                public uint* pulVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pintVal"]/*' />
                [FieldOffset(0)]
                public int* pintVal;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.puintVal"]/*' />
                [FieldOffset(0)]
                public uint* puintVal;

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

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pdecVal"]/*' />
                [FieldOffset(0)]
                public DECIMAL* pdecVal;

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
                [NativeTypeName("LPSAFEARRAY *")]
                public SAFEARRAY** pparray;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pvarVal"]/*' />
                [FieldOffset(0)]
                public PROPVARIANT* pvarVal;
            }
        }
    }
}
