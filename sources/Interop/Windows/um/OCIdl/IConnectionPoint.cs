// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B286-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct IConnectionPoint : IUnknown")]
    public unsafe partial struct IConnectionPoint
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IConnectionPoint*, Guid*, void**, int>)(lpVtbl[0]))((IConnectionPoint*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IConnectionPoint*, uint>)(lpVtbl[1]))((IConnectionPoint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IConnectionPoint*, uint>)(lpVtbl[2]))((IConnectionPoint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetConnectionInterface([NativeTypeName("IID *")] Guid* pIID)
        {
            return ((delegate* unmanaged[Stdcall]<IConnectionPoint*, Guid*, int>)(lpVtbl[3]))((IConnectionPoint*)Unsafe.AsPointer(ref this), pIID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetConnectionPointContainer([NativeTypeName("IConnectionPointContainer **")] IConnectionPointContainer** ppCPC)
        {
            return ((delegate* unmanaged[Stdcall]<IConnectionPoint*, IConnectionPointContainer**, int>)(lpVtbl[4]))((IConnectionPoint*)Unsafe.AsPointer(ref this), ppCPC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Advise([NativeTypeName("IUnknown *")] IUnknown* pUnkSink, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged[Stdcall]<IConnectionPoint*, IUnknown*, uint*, int>)(lpVtbl[5]))((IConnectionPoint*)Unsafe.AsPointer(ref this), pUnkSink, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged[Stdcall]<IConnectionPoint*, uint, int>)(lpVtbl[6]))((IConnectionPoint*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumConnections([NativeTypeName("IEnumConnections **")] IEnumConnections** ppEnum)
        {
            return ((delegate* unmanaged[Stdcall]<IConnectionPoint*, IEnumConnections**, int>)(lpVtbl[7]))((IConnectionPoint*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
