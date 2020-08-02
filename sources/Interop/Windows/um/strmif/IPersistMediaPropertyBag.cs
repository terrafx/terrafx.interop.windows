// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5738E040-B67F-11D0-BD4D-00A0C911CE86")]
    public unsafe partial struct IPersistMediaPropertyBag
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPersistMediaPropertyBag*, Guid*, void**, int>)(lpVtbl[0]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPersistMediaPropertyBag*, uint>)(lpVtbl[1]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPersistMediaPropertyBag*, uint>)(lpVtbl[2]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* stdcall<IPersistMediaPropertyBag*, Guid*, int>)(lpVtbl[3]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitNew()
        {
            return ((delegate* stdcall<IPersistMediaPropertyBag*, int>)(lpVtbl[4]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IMediaPropertyBag *")] IMediaPropertyBag* pPropBag, [NativeTypeName("IErrorLog *")] IErrorLog* pErrorLog)
        {
            return ((delegate* stdcall<IPersistMediaPropertyBag*, IMediaPropertyBag*, IErrorLog*, int>)(lpVtbl[5]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this), pPropBag, pErrorLog);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("IMediaPropertyBag *")] IMediaPropertyBag* pPropBag, [NativeTypeName("BOOL")] int fClearDirty, [NativeTypeName("BOOL")] int fSaveAllProperties)
        {
            return ((delegate* stdcall<IPersistMediaPropertyBag*, IMediaPropertyBag*, int, int, int>)(lpVtbl[6]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this), pPropBag, fClearDirty, fSaveAllProperties);
        }
    }
}
