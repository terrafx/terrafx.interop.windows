// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("37D84F60-42CB-11CE-8135-00AA004BB851")]
    [NativeTypeName("struct IPersistPropertyBag : IPersist")]
    public unsafe partial struct IPersistPropertyBag
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPersistPropertyBag*, Guid*, void**, int>)(lpVtbl[0]))((IPersistPropertyBag*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPersistPropertyBag*, uint>)(lpVtbl[1]))((IPersistPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPersistPropertyBag*, uint>)(lpVtbl[2]))((IPersistPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IPersistPropertyBag*, Guid*, int>)(lpVtbl[3]))((IPersistPropertyBag*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitNew()
        {
            return ((delegate* unmanaged<IPersistPropertyBag*, int>)(lpVtbl[4]))((IPersistPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load(IPropertyBag* pPropBag, IErrorLog* pErrorLog)
        {
            return ((delegate* unmanaged<IPersistPropertyBag*, IPropertyBag*, IErrorLog*, int>)(lpVtbl[5]))((IPersistPropertyBag*)Unsafe.AsPointer(ref this), pPropBag, pErrorLog);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Save(IPropertyBag* pPropBag, [NativeTypeName("BOOL")] int fClearDirty, [NativeTypeName("BOOL")] int fSaveAllProperties)
        {
            return ((delegate* unmanaged<IPersistPropertyBag*, IPropertyBag*, int, int, int>)(lpVtbl[6]))((IPersistPropertyBag*)Unsafe.AsPointer(ref this), pPropBag, fClearDirty, fSaveAllProperties);
        }
    }
}
