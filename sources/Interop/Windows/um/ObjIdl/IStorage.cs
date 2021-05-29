// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000000B-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IStorage : IUnknown")]
    public unsafe partial struct IStorage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IStorage*, Guid*, void**, int>)(lpVtbl[0]))((IStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorage*, uint>)(lpVtbl[1]))((IStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorage*, uint>)(lpVtbl[2]))((IStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStream([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("DWORD")] uint reserved2, IStream** ppstm)
        {
            return ((delegate* unmanaged<IStorage*, ushort*, uint, uint, uint, IStream**, int>)(lpVtbl[3]))((IStorage*)Unsafe.AsPointer(ref this), pwcsName, grfMode, reserved1, reserved2, ppstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenStream([NativeTypeName("const OLECHAR *")] ushort* pwcsName, void* reserved1, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved2, IStream** ppstm)
        {
            return ((delegate* unmanaged<IStorage*, ushort*, void*, uint, uint, IStream**, int>)(lpVtbl[4]))((IStorage*)Unsafe.AsPointer(ref this), pwcsName, reserved1, grfMode, reserved2, ppstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStorage([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("DWORD")] uint reserved2, IStorage** ppstg)
        {
            return ((delegate* unmanaged<IStorage*, ushort*, uint, uint, uint, IStorage**, int>)(lpVtbl[5]))((IStorage*)Unsafe.AsPointer(ref this), pwcsName, grfMode, reserved1, reserved2, ppstg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenStorage([NativeTypeName("const OLECHAR *")] ushort* pwcsName, IStorage* pstgPriority, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("SNB")] ushort** snbExclude, [NativeTypeName("DWORD")] uint reserved, IStorage** ppstg)
        {
            return ((delegate* unmanaged<IStorage*, ushort*, IStorage*, uint, ushort**, uint, IStorage**, int>)(lpVtbl[6]))((IStorage*)Unsafe.AsPointer(ref this), pwcsName, pstgPriority, grfMode, snbExclude, reserved, ppstg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyTo([NativeTypeName("DWORD")] uint ciidExclude, [NativeTypeName("const IID *")] Guid* rgiidExclude, [NativeTypeName("SNB")] ushort** snbExclude, IStorage* pstgDest)
        {
            return ((delegate* unmanaged<IStorage*, uint, Guid*, ushort**, IStorage*, int>)(lpVtbl[7]))((IStorage*)Unsafe.AsPointer(ref this), ciidExclude, rgiidExclude, snbExclude, pstgDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveElementTo([NativeTypeName("const OLECHAR *")] ushort* pwcsName, IStorage* pstgDest, [NativeTypeName("const OLECHAR *")] ushort* pwcsNewName, [NativeTypeName("DWORD")] uint grfFlags)
        {
            return ((delegate* unmanaged<IStorage*, ushort*, IStorage*, ushort*, uint, int>)(lpVtbl[8]))((IStorage*)Unsafe.AsPointer(ref this), pwcsName, pstgDest, pwcsNewName, grfFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* unmanaged<IStorage*, uint, int>)(lpVtbl[9]))((IStorage*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return ((delegate* unmanaged<IStorage*, int>)(lpVtbl[10]))((IStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumElements([NativeTypeName("DWORD")] uint reserved1, void* reserved2, [NativeTypeName("DWORD")] uint reserved3, IEnumSTATSTG** ppenum)
        {
            return ((delegate* unmanaged<IStorage*, uint, void*, uint, IEnumSTATSTG**, int>)(lpVtbl[11]))((IStorage*)Unsafe.AsPointer(ref this), reserved1, reserved2, reserved3, ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DestroyElement([NativeTypeName("const OLECHAR *")] ushort* pwcsName)
        {
            return ((delegate* unmanaged<IStorage*, ushort*, int>)(lpVtbl[12]))((IStorage*)Unsafe.AsPointer(ref this), pwcsName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RenameElement([NativeTypeName("const OLECHAR *")] ushort* pwcsOldName, [NativeTypeName("const OLECHAR *")] ushort* pwcsNewName)
        {
            return ((delegate* unmanaged<IStorage*, ushort*, ushort*, int>)(lpVtbl[13]))((IStorage*)Unsafe.AsPointer(ref this), pwcsOldName, pwcsNewName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetElementTimes([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("const FILETIME *")] FILETIME* pctime, [NativeTypeName("const FILETIME *")] FILETIME* patime, [NativeTypeName("const FILETIME *")] FILETIME* pmtime)
        {
            return ((delegate* unmanaged<IStorage*, ushort*, FILETIME*, FILETIME*, FILETIME*, int>)(lpVtbl[14]))((IStorage*)Unsafe.AsPointer(ref this), pwcsName, pctime, patime, pmtime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClass([NativeTypeName("const IID &")] Guid* clsid)
        {
            return ((delegate* unmanaged<IStorage*, Guid*, int>)(lpVtbl[15]))((IStorage*)Unsafe.AsPointer(ref this), clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStateBits([NativeTypeName("DWORD")] uint grfStateBits, [NativeTypeName("DWORD")] uint grfMask)
        {
            return ((delegate* unmanaged<IStorage*, uint, uint, int>)(lpVtbl[16]))((IStorage*)Unsafe.AsPointer(ref this), grfStateBits, grfMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return ((delegate* unmanaged<IStorage*, STATSTG*, uint, int>)(lpVtbl[17]))((IStorage*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }
    }
}
