// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00675040-6908-45F8-86A3-49C7DFD6D9AD")]
    [NativeTypeName("struct IWICPersistStream : IPersistStream")]
    public unsafe partial struct IWICPersistStream
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IWICPersistStream*, Guid*, void**, int>)(lpVtbl[0]))((IWICPersistStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICPersistStream*, uint>)(lpVtbl[1]))((IWICPersistStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICPersistStream*, uint>)(lpVtbl[2]))((IWICPersistStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IWICPersistStream*, Guid*, int>)(lpVtbl[3]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return ((delegate* unmanaged<IWICPersistStream*, int>)(lpVtbl[4]))((IWICPersistStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IStream *")] IStream* pStm)
        {
            return ((delegate* unmanaged<IWICPersistStream*, IStream*, int>)(lpVtbl[5]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pStm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("BOOL")] int fClearDirty)
        {
            return ((delegate* unmanaged<IWICPersistStream*, IStream*, int, int>)(lpVtbl[6]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax([NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbSize)
        {
            return ((delegate* unmanaged<IWICPersistStream*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadEx([NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidPreferredVendor, [NativeTypeName("DWORD")] uint dwPersistOptions)
        {
            return ((delegate* unmanaged<IWICPersistStream*, IStream*, Guid*, uint, int>)(lpVtbl[8]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pIStream, pguidPreferredVendor, dwPersistOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SaveEx([NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("DWORD")] uint dwPersistOptions, [NativeTypeName("BOOL")] int fClearDirty)
        {
            return ((delegate* unmanaged<IWICPersistStream*, IStream*, uint, int, int>)(lpVtbl[9]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pIStream, dwPersistOptions, fClearDirty);
        }
    }
}
