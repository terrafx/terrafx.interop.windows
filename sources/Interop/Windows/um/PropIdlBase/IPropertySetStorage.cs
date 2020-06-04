// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000013A-0000-0000-C000-000000000046")]
    public unsafe partial struct IPropertySetStorage
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPropertySetStorage*, Guid*, void**, int>)(lpVtbl[0]))((IPropertySetStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPropertySetStorage*, uint>)(lpVtbl[1]))((IPropertySetStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPropertySetStorage*, uint>)(lpVtbl[2]))((IPropertySetStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Create([NativeTypeName("const IID &")] Guid* rfmtid, [NativeTypeName("const CLSID *")] Guid* pclsid, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("IPropertyStorage **")] IPropertyStorage** ppprstg)
        {
            return ((delegate* stdcall<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)(lpVtbl[3]))((IPropertySetStorage*)Unsafe.AsPointer(ref this), rfmtid, pclsid, grfFlags, grfMode, ppprstg);
        }

        [return: NativeTypeName("HRESULT")]
        public int Open([NativeTypeName("const IID &")] Guid* rfmtid, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("IPropertyStorage **")] IPropertyStorage** ppprstg)
        {
            return ((delegate* stdcall<IPropertySetStorage*, Guid*, uint, IPropertyStorage**, int>)(lpVtbl[4]))((IPropertySetStorage*)Unsafe.AsPointer(ref this), rfmtid, grfMode, ppprstg);
        }

        [return: NativeTypeName("HRESULT")]
        public int Delete([NativeTypeName("const IID &")] Guid* rfmtid)
        {
            return ((delegate* stdcall<IPropertySetStorage*, Guid*, int>)(lpVtbl[5]))((IPropertySetStorage*)Unsafe.AsPointer(ref this), rfmtid);
        }

        [return: NativeTypeName("HRESULT")]
        public int Enum([NativeTypeName("IEnumSTATPROPSETSTG **")] IEnumSTATPROPSETSTG** ppenum)
        {
            return ((delegate* stdcall<IPropertySetStorage*, IEnumSTATPROPSETSTG**, int>)(lpVtbl[6]))((IPropertySetStorage*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
