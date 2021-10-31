// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000138-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IPropertyStorage : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPropertyStorage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyStorage*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyStorage*, uint>)(lpVtbl[1]))((IPropertyStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyStorage*, uint>)(lpVtbl[2]))((IPropertyStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ReadMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec, [NativeTypeName("PROPVARIANT []")] PROPVARIANT* rgpropvar)
        {
            return ((delegate* unmanaged<IPropertyStorage*, uint, PROPSPEC*, PROPVARIANT*, int>)(lpVtbl[3]))((IPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec, rgpropvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT WriteMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec, [NativeTypeName("const PROPVARIANT []")] PROPVARIANT* rgpropvar, [NativeTypeName("PROPID")] uint propidNameFirst)
        {
            return ((delegate* unmanaged<IPropertyStorage*, uint, PROPSPEC*, PROPVARIANT*, uint, int>)(lpVtbl[4]))((IPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec, rgpropvar, propidNameFirst);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT DeleteMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec)
        {
            return ((delegate* unmanaged<IPropertyStorage*, uint, PROPSPEC*, int>)(lpVtbl[5]))((IPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT ReadPropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID []")] uint* rgpropid, [NativeTypeName("LPOLESTR []")] ushort** rglpwstrName)
        {
            return ((delegate* unmanaged<IPropertyStorage*, uint, uint*, ushort**, int>)(lpVtbl[6]))((IPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid, rglpwstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT WritePropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID []")] uint* rgpropid, [NativeTypeName("const LPOLESTR []")] ushort** rglpwstrName)
        {
            return ((delegate* unmanaged<IPropertyStorage*, uint, uint*, ushort**, int>)(lpVtbl[7]))((IPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid, rglpwstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT DeletePropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID []")] uint* rgpropid)
        {
            return ((delegate* unmanaged<IPropertyStorage*, uint, uint*, int>)(lpVtbl[8]))((IPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* unmanaged<IPropertyStorage*, uint, int>)(lpVtbl[9]))((IPropertyStorage*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Revert()
        {
            return ((delegate* unmanaged<IPropertyStorage*, int>)(lpVtbl[10]))((IPropertyStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Enum(IEnumSTATPROPSTG** ppenum)
        {
            return ((delegate* unmanaged<IPropertyStorage*, IEnumSTATPROPSTG**, int>)(lpVtbl[11]))((IPropertyStorage*)Unsafe.AsPointer(ref this), ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetTimes([NativeTypeName("const FILETIME *")] FILETIME* pctime, [NativeTypeName("const FILETIME *")] FILETIME* patime, [NativeTypeName("const FILETIME *")] FILETIME* pmtime)
        {
            return ((delegate* unmanaged<IPropertyStorage*, FILETIME*, FILETIME*, FILETIME*, int>)(lpVtbl[12]))((IPropertyStorage*)Unsafe.AsPointer(ref this), pctime, patime, pmtime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetClass([NativeTypeName("const IID &")] Guid* clsid)
        {
            return ((delegate* unmanaged<IPropertyStorage*, Guid*, int>)(lpVtbl[13]))((IPropertyStorage*)Unsafe.AsPointer(ref this), clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT Stat(STATPROPSETSTG* pstatpsstg)
        {
            return ((delegate* unmanaged<IPropertyStorage*, STATPROPSETSTG*, int>)(lpVtbl[14]))((IPropertyStorage*)Unsafe.AsPointer(ref this), pstatpsstg);
        }
    }
}
