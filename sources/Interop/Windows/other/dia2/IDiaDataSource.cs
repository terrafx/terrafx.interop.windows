// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79F1BB5F-B66E-48E5-B6A9-1545C323CA3D")]
    [NativeTypeName("struct IDiaDataSource : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaDataSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaDataSource*, Guid*, void**, int>)(lpVtbl[0]))((IDiaDataSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaDataSource*, uint>)(lpVtbl[1]))((IDiaDataSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaDataSource*, uint>)(lpVtbl[2]))((IDiaDataSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_lastError([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaDataSource*, ushort**, int>)(lpVtbl[3]))((IDiaDataSource*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT loadDataFromPdb([NativeTypeName("LPCOLESTR")] ushort* pdbPath)
        {
            return ((delegate* unmanaged<IDiaDataSource*, ushort*, int>)(lpVtbl[4]))((IDiaDataSource*)Unsafe.AsPointer(ref this), pdbPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT loadAndValidateDataFromPdb([NativeTypeName("LPCOLESTR")] ushort* pdbPath, [NativeTypeName("GUID *")] Guid* pcsig70, [NativeTypeName("DWORD")] uint sig, [NativeTypeName("DWORD")] uint age)
        {
            return ((delegate* unmanaged<IDiaDataSource*, ushort*, Guid*, uint, uint, int>)(lpVtbl[5]))((IDiaDataSource*)Unsafe.AsPointer(ref this), pdbPath, pcsig70, sig, age);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT loadDataForExe([NativeTypeName("LPCOLESTR")] ushort* executable, [NativeTypeName("LPCOLESTR")] ushort* searchPath, IUnknown* pCallback)
        {
            return ((delegate* unmanaged<IDiaDataSource*, ushort*, ushort*, IUnknown*, int>)(lpVtbl[6]))((IDiaDataSource*)Unsafe.AsPointer(ref this), executable, searchPath, pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT loadDataFromIStream(IStream* pIStream)
        {
            return ((delegate* unmanaged<IDiaDataSource*, IStream*, int>)(lpVtbl[7]))((IDiaDataSource*)Unsafe.AsPointer(ref this), pIStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT openSession(IDiaSession** ppSession)
        {
            return ((delegate* unmanaged<IDiaDataSource*, IDiaSession**, int>)(lpVtbl[8]))((IDiaDataSource*)Unsafe.AsPointer(ref this), ppSession);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT loadDataFromCodeViewInfo([NativeTypeName("LPCOLESTR")] ushort* executable, [NativeTypeName("LPCOLESTR")] ushort* searchPath, [NativeTypeName("DWORD")] uint cbCvInfo, [NativeTypeName("BYTE *")] byte* pbCvInfo, IUnknown* pCallback)
        {
            return ((delegate* unmanaged<IDiaDataSource*, ushort*, ushort*, uint, byte*, IUnknown*, int>)(lpVtbl[9]))((IDiaDataSource*)Unsafe.AsPointer(ref this), executable, searchPath, cbCvInfo, pbCvInfo, pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT loadDataFromMiscInfo([NativeTypeName("LPCOLESTR")] ushort* executable, [NativeTypeName("LPCOLESTR")] ushort* searchPath, [NativeTypeName("DWORD")] uint timeStampExe, [NativeTypeName("DWORD")] uint timeStampDbg, [NativeTypeName("DWORD")] uint sizeOfExe, [NativeTypeName("DWORD")] uint cbMiscInfo, [NativeTypeName("BYTE *")] byte* pbMiscInfo, IUnknown* pCallback)
        {
            return ((delegate* unmanaged<IDiaDataSource*, ushort*, ushort*, uint, uint, uint, uint, byte*, IUnknown*, int>)(lpVtbl[10]))((IDiaDataSource*)Unsafe.AsPointer(ref this), executable, searchPath, timeStampExe, timeStampDbg, sizeOfExe, cbMiscInfo, pbMiscInfo, pCallback);
        }
    }
}
