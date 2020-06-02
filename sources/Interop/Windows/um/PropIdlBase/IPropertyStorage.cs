// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000138-0000-0000-C000-000000000046")]
    public unsafe partial struct IPropertyStorage
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPropertyStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPropertyStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPropertyStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec, [NativeTypeName("PROPVARIANT []")] PROPVARIANT* rgpropvar)
        {
            return lpVtbl->ReadMultiple((IPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec, rgpropvar);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec, [NativeTypeName("const PROPVARIANT []")] PROPVARIANT* rgpropvar, [NativeTypeName("PROPID")] uint propidNameFirst)
        {
            return lpVtbl->WriteMultiple((IPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec, rgpropvar, propidNameFirst);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec)
        {
            return lpVtbl->DeleteMultiple((IPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadPropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID []")] uint* rgpropid, [NativeTypeName("LPOLESTR []")] ushort** rglpwstrName)
        {
            return lpVtbl->ReadPropertyNames((IPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid, rglpwstrName);
        }

        [return: NativeTypeName("HRESULT")]
        public int WritePropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID []")] uint* rgpropid, [NativeTypeName("const LPOLESTR []")] ushort** rglpwstrName)
        {
            return lpVtbl->WritePropertyNames((IPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid, rglpwstrName);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeletePropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID []")] uint* rgpropid)
        {
            return lpVtbl->DeletePropertyNames((IPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return lpVtbl->Commit((IPropertyStorage*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return lpVtbl->Revert((IPropertyStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Enum([NativeTypeName("IEnumSTATPROPSTG **")] IEnumSTATPROPSTG** ppenum)
        {
            return lpVtbl->Enum((IPropertyStorage*)Unsafe.AsPointer(ref this), ppenum);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTimes([NativeTypeName("const FILETIME *")] FILETIME* pctime, [NativeTypeName("const FILETIME *")] FILETIME* patime, [NativeTypeName("const FILETIME *")] FILETIME* pmtime)
        {
            return lpVtbl->SetTimes((IPropertyStorage*)Unsafe.AsPointer(ref this), pctime, patime, pmtime);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClass([NativeTypeName("const IID &")] Guid* clsid)
        {
            return lpVtbl->SetClass((IPropertyStorage*)Unsafe.AsPointer(ref this), clsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATPROPSETSTG *")] STATPROPSETSTG* pstatpsstg)
        {
            return lpVtbl->Stat((IPropertyStorage*)Unsafe.AsPointer(ref this), pstatpsstg);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyStorage*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyStorage*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyStorage*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, const PROPSPEC *, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyStorage*, uint, PROPSPEC*, PROPVARIANT*, int> ReadMultiple;

            [NativeTypeName("HRESULT (ULONG, const PROPSPEC *, const PROPVARIANT *, PROPID) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyStorage*, uint, PROPSPEC*, PROPVARIANT*, uint, int> WriteMultiple;

            [NativeTypeName("HRESULT (ULONG, const PROPSPEC *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyStorage*, uint, PROPSPEC*, int> DeleteMultiple;

            [NativeTypeName("HRESULT (ULONG, const PROPID *, LPOLESTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyStorage*, uint, uint*, ushort**, int> ReadPropertyNames;

            [NativeTypeName("HRESULT (ULONG, const PROPID *, const LPOLESTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyStorage*, uint, uint*, ushort**, int> WritePropertyNames;

            [NativeTypeName("HRESULT (ULONG, const PROPID *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyStorage*, uint, uint*, int> DeletePropertyNames;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyStorage*, uint, int> Commit;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyStorage*, int> Revert;

            [NativeTypeName("HRESULT (IEnumSTATPROPSTG **) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyStorage*, IEnumSTATPROPSTG**, int> Enum;

            [NativeTypeName("HRESULT (const FILETIME *, const FILETIME *, const FILETIME *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyStorage*, FILETIME*, FILETIME*, FILETIME*, int> SetTimes;

            [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyStorage*, Guid*, int> SetClass;

            [NativeTypeName("HRESULT (STATPROPSETSTG *) __attribute__((stdcall))")]
            public delegate* stdcall<IPropertyStorage*, STATPROPSETSTG*, int> Stat;
        }
    }
}
