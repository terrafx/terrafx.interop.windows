// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22F55881-280B-11D0-A8A9-00A0C90C2004")]
    public unsafe partial struct IPersistPropertyBag2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPersistPropertyBag2*, Guid*, void**, int>)(lpVtbl[0]))((IPersistPropertyBag2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPersistPropertyBag2*, uint>)(lpVtbl[1]))((IPersistPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPersistPropertyBag2*, uint>)(lpVtbl[2]))((IPersistPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* stdcall<IPersistPropertyBag2*, Guid*, int>)(lpVtbl[3]))((IPersistPropertyBag2*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitNew()
        {
            return ((delegate* stdcall<IPersistPropertyBag2*, int>)(lpVtbl[4]))((IPersistPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IPropertyBag2 *")] IPropertyBag2* pPropBag, [NativeTypeName("IErrorLog *")] IErrorLog* pErrLog)
        {
            return ((delegate* stdcall<IPersistPropertyBag2*, IPropertyBag2*, IErrorLog*, int>)(lpVtbl[5]))((IPersistPropertyBag2*)Unsafe.AsPointer(ref this), pPropBag, pErrLog);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("IPropertyBag2 *")] IPropertyBag2* pPropBag, [NativeTypeName("BOOL")] int fClearDirty, [NativeTypeName("BOOL")] int fSaveAllProperties)
        {
            return ((delegate* stdcall<IPersistPropertyBag2*, IPropertyBag2*, int, int, int>)(lpVtbl[6]))((IPersistPropertyBag2*)Unsafe.AsPointer(ref this), pPropBag, fClearDirty, fSaveAllProperties);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return ((delegate* stdcall<IPersistPropertyBag2*, int>)(lpVtbl[7]))((IPersistPropertyBag2*)Unsafe.AsPointer(ref this));
        }
    }
}
