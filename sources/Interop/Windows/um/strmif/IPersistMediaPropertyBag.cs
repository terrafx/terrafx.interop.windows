// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5738E040-B67F-11D0-BD4D-00A0C911CE86")]
    [NativeTypeName("struct IPersistMediaPropertyBag : IPersist")]
    public unsafe partial struct IPersistMediaPropertyBag
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPersistMediaPropertyBag*, Guid*, void**, int>)(lpVtbl[0]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPersistMediaPropertyBag*, uint>)(lpVtbl[1]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPersistMediaPropertyBag*, uint>)(lpVtbl[2]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IPersistMediaPropertyBag*, Guid*, int>)(lpVtbl[3]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitNew()
        {
            return ((delegate* unmanaged<IPersistMediaPropertyBag*, int>)(lpVtbl[4]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load(IMediaPropertyBag* pPropBag, IErrorLog* pErrorLog)
        {
            return ((delegate* unmanaged<IPersistMediaPropertyBag*, IMediaPropertyBag*, IErrorLog*, int>)(lpVtbl[5]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this), pPropBag, pErrorLog);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Save(IMediaPropertyBag* pPropBag, [NativeTypeName("BOOL")] int fClearDirty, [NativeTypeName("BOOL")] int fSaveAllProperties)
        {
            return ((delegate* unmanaged<IPersistMediaPropertyBag*, IMediaPropertyBag*, int, int, int>)(lpVtbl[6]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this), pPropBag, fClearDirty, fSaveAllProperties);
        }
    }
}
