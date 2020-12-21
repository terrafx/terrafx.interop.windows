// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ED6A8A2A-B160-4E77-8F73-AA7435CD5C27")]
    [NativeTypeName("struct ITypeLibRegistrationReader : IUnknown")]
    public unsafe partial struct ITypeLibRegistrationReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ITypeLibRegistrationReader*, Guid*, void**, int>)(lpVtbl[0]))((ITypeLibRegistrationReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ITypeLibRegistrationReader*, uint>)(lpVtbl[1]))((ITypeLibRegistrationReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ITypeLibRegistrationReader*, uint>)(lpVtbl[2]))((ITypeLibRegistrationReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumTypeLibRegistrations([NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppEnumUnknown)
        {
            return ((delegate* unmanaged[Stdcall]<ITypeLibRegistrationReader*, IEnumUnknown**, int>)(lpVtbl[3]))((ITypeLibRegistrationReader*)Unsafe.AsPointer(ref this), ppEnumUnknown);
        }
    }
}
