// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E3BC42CE-4E5C-11D3-9144-00104BA11C5E")]
    [NativeTypeName("struct IJolietDiscMaster : IUnknown")]
    public unsafe partial struct IJolietDiscMaster
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IJolietDiscMaster*, Guid*, void**, int>)(lpVtbl[0]))((IJolietDiscMaster*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IJolietDiscMaster*, uint>)(lpVtbl[1]))((IJolietDiscMaster*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IJolietDiscMaster*, uint>)(lpVtbl[2]))((IJolietDiscMaster*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTotalDataBlocks([NativeTypeName("long *")] int* pnBlocks)
        {
            return ((delegate* unmanaged<IJolietDiscMaster*, int*, int>)(lpVtbl[3]))((IJolietDiscMaster*)Unsafe.AsPointer(ref this), pnBlocks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUsedDataBlocks([NativeTypeName("long *")] int* pnBlocks)
        {
            return ((delegate* unmanaged<IJolietDiscMaster*, int*, int>)(lpVtbl[4]))((IJolietDiscMaster*)Unsafe.AsPointer(ref this), pnBlocks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDataBlockSize([NativeTypeName("long *")] int* pnBlockBytes)
        {
            return ((delegate* unmanaged<IJolietDiscMaster*, int*, int>)(lpVtbl[5]))((IJolietDiscMaster*)Unsafe.AsPointer(ref this), pnBlockBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddData(IStorage* pStorage, [NativeTypeName("long")] int lFileOverwrite)
        {
            return ((delegate* unmanaged<IJolietDiscMaster*, IStorage*, int, int>)(lpVtbl[6]))((IJolietDiscMaster*)Unsafe.AsPointer(ref this), pStorage, lFileOverwrite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetJolietProperties(IPropertyStorage** ppPropStg)
        {
            return ((delegate* unmanaged<IJolietDiscMaster*, IPropertyStorage**, int>)(lpVtbl[7]))((IJolietDiscMaster*)Unsafe.AsPointer(ref this), ppPropStg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetJolietProperties(IPropertyStorage* pPropStg)
        {
            return ((delegate* unmanaged<IJolietDiscMaster*, IPropertyStorage*, int>)(lpVtbl[8]))((IJolietDiscMaster*)Unsafe.AsPointer(ref this), pPropStg);
        }
    }
}
