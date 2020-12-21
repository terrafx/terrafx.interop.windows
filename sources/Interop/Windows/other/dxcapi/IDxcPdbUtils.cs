// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcapi.h in the microsoft/DirectXCompiler commit 747ee519eb9b65f893bb891bc6d229dfe9687e6a
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E6C9647E-9D6A-4C3B-B94C-524B5A6C343D")]
    [NativeTypeName("struct IDxcPdbUtils : IUnknown")]
    public unsafe partial struct IDxcPdbUtils
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Guid*, void**, int>)(lpVtbl[0]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint>)(lpVtbl[1]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint>)(lpVtbl[2]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IDxcBlob *")] IDxcBlob* pPdbOrDxil)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob*, int>)(lpVtbl[3]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pPdbOrDxil);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourceCount([NativeTypeName("UINT32 *")] uint* pCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)(lpVtbl[4]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSource([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("IDxcBlobEncoding **")] IDxcBlobEncoding** ppResult)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)(lpVtbl[5]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourceName([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, ushort**, int>)(lpVtbl[6]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFlagCount([NativeTypeName("UINT32 *")] uint* pCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)(lpVtbl[7]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFlag([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, ushort**, int>)(lpVtbl[8]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetArgCount([NativeTypeName("UINT32 *")] uint* pCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)(lpVtbl[9]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetArg([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, ushort**, int>)(lpVtbl[10]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefineCount([NativeTypeName("UINT32 *")] uint* pCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)(lpVtbl[11]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefine([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, ushort**, int>)(lpVtbl[12]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTargetProfile([NativeTypeName("BSTR *")] ushort** pResult)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, ushort**, int>)(lpVtbl[13]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEntryPoint([NativeTypeName("BSTR *")] ushort** pResult)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, ushort**, int>)(lpVtbl[14]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMainFileName([NativeTypeName("BSTR *")] ushort** pResult)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, ushort**, int>)(lpVtbl[15]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHash([NativeTypeName("IDxcBlob **")] IDxcBlob** ppResult)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)(lpVtbl[16]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("BSTR *")] ushort** pResult)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, ushort**, int>)(lpVtbl[17]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsFullPDB()
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, int>)(lpVtbl[18]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFullPDB([NativeTypeName("IDxcBlob **")] IDxcBlob** ppFullPDB)
        {
            return ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)(lpVtbl[19]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), ppFullPDB);
        }
    }
}
