// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("48ADDD32-3CA5-4124-ABE3-B5A72531B207")]
    [NativeTypeName("struct ITransferDestination : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITransferDestination
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITransferDestination*, Guid*, void**, int>)(lpVtbl[0]))((ITransferDestination*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITransferDestination*, uint>)(lpVtbl[1]))((ITransferDestination*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITransferDestination*, uint>)(lpVtbl[2]))((ITransferDestination*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Advise(ITransferAdviseSink* psink, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<ITransferDestination*, ITransferAdviseSink*, uint*, int>)(lpVtbl[3]))((ITransferDestination*)Unsafe.AsPointer(ref this), psink, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<ITransferDestination*, uint, int>)(lpVtbl[4]))((ITransferDestination*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreateItem([NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("DWORD")] uint dwAttributes, [NativeTypeName("ULONGLONG")] ulong ullSize, [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags, [NativeTypeName("const IID &")] Guid* riidItem, void** ppvItem, [NativeTypeName("const IID &")] Guid* riidResources, void** ppvResources)
        {
            return ((delegate* unmanaged<ITransferDestination*, ushort*, uint, ulong, uint, Guid*, void**, Guid*, void**, int>)(lpVtbl[5]))((ITransferDestination*)Unsafe.AsPointer(ref this), pszName, dwAttributes, ullSize, flags, riidItem, ppvItem, riidResources, ppvResources);
        }
    }
}
