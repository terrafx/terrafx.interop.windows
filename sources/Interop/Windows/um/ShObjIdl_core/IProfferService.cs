// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CB728B20-F786-11CE-92AD-00AA00A74CD0")]
    [NativeTypeName("struct IProfferService : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IProfferService
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IProfferService*, Guid*, void**, int>)(lpVtbl[0]))((IProfferService*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProfferService*, uint>)(lpVtbl[1]))((IProfferService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProfferService*, uint>)(lpVtbl[2]))((IProfferService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ProfferService([NativeTypeName("const GUID &")] Guid* serviceId, IServiceProvider* serviceProvider, [NativeTypeName("DWORD *")] uint* cookie)
        {
            return ((delegate* unmanaged<IProfferService*, Guid*, IServiceProvider*, uint*, int>)(lpVtbl[3]))((IProfferService*)Unsafe.AsPointer(ref this), serviceId, serviceProvider, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT RevokeService([NativeTypeName("DWORD")] uint cookie)
        {
            return ((delegate* unmanaged<IProfferService*, uint, int>)(lpVtbl[4]))((IProfferService*)Unsafe.AsPointer(ref this), cookie);
        }
    }
}
