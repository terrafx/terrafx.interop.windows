// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A6BC3AC0-DBAA-11CE-9DE3-00AA004BB851")]
    [NativeTypeName("struct IProvideClassInfo2 : IProvideClassInfo")]
    public unsafe partial struct IProvideClassInfo2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IProvideClassInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IProvideClassInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IProvideClassInfo2*, uint>)(lpVtbl[1]))((IProvideClassInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IProvideClassInfo2*, uint>)(lpVtbl[2]))((IProvideClassInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassInfo([NativeTypeName("ITypeInfo **")] ITypeInfo** ppTI)
        {
            return ((delegate* unmanaged[Stdcall]<IProvideClassInfo2*, ITypeInfo**, int>)(lpVtbl[3]))((IProvideClassInfo2*)Unsafe.AsPointer(ref this), ppTI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("DWORD")] uint dwGuidKind, [NativeTypeName("GUID *")] Guid* pGUID)
        {
            return ((delegate* unmanaged[Stdcall]<IProvideClassInfo2*, uint, Guid*, int>)(lpVtbl[4]))((IProvideClassInfo2*)Unsafe.AsPointer(ref this), dwGuidKind, pGUID);
        }
    }
}
