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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPropertyStorage*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPropertyStorage*, uint>)(lpVtbl[1]))((IPropertyStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPropertyStorage*, uint>)(lpVtbl[2]))((IPropertyStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec, [NativeTypeName("PROPVARIANT []")] PROPVARIANT* rgpropvar)
        {
            return ((delegate* stdcall<IPropertyStorage*, uint, PROPSPEC*, PROPVARIANT*, int>)(lpVtbl[3]))((IPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec, rgpropvar);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec, [NativeTypeName("const PROPVARIANT []")] PROPVARIANT* rgpropvar, [NativeTypeName("PROPID")] uint propidNameFirst)
        {
            return ((delegate* stdcall<IPropertyStorage*, uint, PROPSPEC*, PROPVARIANT*, uint, int>)(lpVtbl[4]))((IPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec, rgpropvar, propidNameFirst);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec)
        {
            return ((delegate* stdcall<IPropertyStorage*, uint, PROPSPEC*, int>)(lpVtbl[5]))((IPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadPropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID []")] uint* rgpropid, [NativeTypeName("LPOLESTR []")] ushort** rglpwstrName)
        {
            return ((delegate* stdcall<IPropertyStorage*, uint, uint*, ushort**, int>)(lpVtbl[6]))((IPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid, rglpwstrName);
        }

        [return: NativeTypeName("HRESULT")]
        public int WritePropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID []")] uint* rgpropid, [NativeTypeName("const LPOLESTR []")] ushort** rglpwstrName)
        {
            return ((delegate* stdcall<IPropertyStorage*, uint, uint*, ushort**, int>)(lpVtbl[7]))((IPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid, rglpwstrName);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeletePropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID []")] uint* rgpropid)
        {
            return ((delegate* stdcall<IPropertyStorage*, uint, uint*, int>)(lpVtbl[8]))((IPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* stdcall<IPropertyStorage*, uint, int>)(lpVtbl[9]))((IPropertyStorage*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return ((delegate* stdcall<IPropertyStorage*, int>)(lpVtbl[10]))((IPropertyStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Enum([NativeTypeName("IEnumSTATPROPSTG **")] IEnumSTATPROPSTG** ppenum)
        {
            return ((delegate* stdcall<IPropertyStorage*, IEnumSTATPROPSTG**, int>)(lpVtbl[11]))((IPropertyStorage*)Unsafe.AsPointer(ref this), ppenum);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTimes([NativeTypeName("const FILETIME *")] FILETIME* pctime, [NativeTypeName("const FILETIME *")] FILETIME* patime, [NativeTypeName("const FILETIME *")] FILETIME* pmtime)
        {
            return ((delegate* stdcall<IPropertyStorage*, FILETIME*, FILETIME*, FILETIME*, int>)(lpVtbl[12]))((IPropertyStorage*)Unsafe.AsPointer(ref this), pctime, patime, pmtime);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClass([NativeTypeName("const IID &")] Guid* clsid)
        {
            return ((delegate* stdcall<IPropertyStorage*, Guid*, int>)(lpVtbl[13]))((IPropertyStorage*)Unsafe.AsPointer(ref this), clsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATPROPSETSTG *")] STATPROPSETSTG* pstatpsstg)
        {
            return ((delegate* stdcall<IPropertyStorage*, STATPROPSETSTG*, int>)(lpVtbl[14]))((IPropertyStorage*)Unsafe.AsPointer(ref this), pstatpsstg);
        }
    }
}
