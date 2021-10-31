// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1CFABA8C-1523-11D1-AD79-00C04FD8FDFF")]
    [NativeTypeName("struct IUnsecuredApartment : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUnsecuredApartment
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUnsecuredApartment*, Guid*, void**, int>)(lpVtbl[0]))((IUnsecuredApartment*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUnsecuredApartment*, uint>)(lpVtbl[1]))((IUnsecuredApartment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUnsecuredApartment*, uint>)(lpVtbl[2]))((IUnsecuredApartment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateObjectStub(IUnknown* pObject, IUnknown** ppStub)
        {
            return ((delegate* unmanaged<IUnsecuredApartment*, IUnknown*, IUnknown**, int>)(lpVtbl[3]))((IUnsecuredApartment*)Unsafe.AsPointer(ref this), pObject, ppStub);
        }
    }
}
