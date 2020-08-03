// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A7ABA9C1-8983-11CF-8F20-00805F2CD064")]
    public unsafe partial struct IProvideMultipleClassInfo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IProvideMultipleClassInfo*, Guid*, void**, int>)(lpVtbl[0]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IProvideMultipleClassInfo*, uint>)(lpVtbl[1]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IProvideMultipleClassInfo*, uint>)(lpVtbl[2]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassInfo([NativeTypeName("ITypeInfo **")] ITypeInfo** ppTI)
        {
            return ((delegate* stdcall<IProvideMultipleClassInfo*, ITypeInfo**, int>)(lpVtbl[3]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), ppTI);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("DWORD")] uint dwGuidKind, [NativeTypeName("GUID *")] Guid* pGUID)
        {
            return ((delegate* stdcall<IProvideMultipleClassInfo*, uint, Guid*, int>)(lpVtbl[4]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), dwGuidKind, pGUID);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMultiTypeInfoCount([NativeTypeName("ULONG *")] uint* pcti)
        {
            return ((delegate* stdcall<IProvideMultipleClassInfo*, uint*, int>)(lpVtbl[5]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), pcti);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInfoOfIndex([NativeTypeName("ULONG")] uint iti, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ITypeInfo **")] ITypeInfo** pptiCoClass, [NativeTypeName("DWORD *")] uint* pdwTIFlags, [NativeTypeName("ULONG *")] uint* pcdispidReserved, [NativeTypeName("IID *")] Guid* piidPrimary, [NativeTypeName("IID *")] Guid* piidSource)
        {
            return ((delegate* stdcall<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)(lpVtbl[6]))((IProvideMultipleClassInfo*)Unsafe.AsPointer(ref this), iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, piidPrimary, piidSource);
        }
    }
}
