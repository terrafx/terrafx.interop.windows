// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9C0-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IBinding : IUnknown")]
    public unsafe partial struct IBinding
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBinding*, Guid*, void**, int>)(lpVtbl[0]))((IBinding*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBinding*, uint>)(lpVtbl[1]))((IBinding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBinding*, uint>)(lpVtbl[2]))((IBinding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Abort()
        {
            return ((delegate* unmanaged<IBinding*, int>)(lpVtbl[3]))((IBinding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Suspend()
        {
            return ((delegate* unmanaged<IBinding*, int>)(lpVtbl[4]))((IBinding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return ((delegate* unmanaged<IBinding*, int>)(lpVtbl[5]))((IBinding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPriority([NativeTypeName("LONG")] int nPriority)
        {
            return ((delegate* unmanaged<IBinding*, int, int>)(lpVtbl[6]))((IBinding*)Unsafe.AsPointer(ref this), nPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPriority([NativeTypeName("LONG *")] int* pnPriority)
        {
            return ((delegate* unmanaged<IBinding*, int*, int>)(lpVtbl[7]))((IBinding*)Unsafe.AsPointer(ref this), pnPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBindResult([NativeTypeName("CLSID *")] Guid* pclsidProtocol, [NativeTypeName("DWORD *")] uint* pdwResult, [NativeTypeName("LPOLESTR *")] ushort** pszResult, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return ((delegate* unmanaged<IBinding*, Guid*, uint*, ushort**, uint*, int>)(lpVtbl[8]))((IBinding*)Unsafe.AsPointer(ref this), pclsidProtocol, pdwResult, pszResult, pdwReserved);
        }
    }
}
