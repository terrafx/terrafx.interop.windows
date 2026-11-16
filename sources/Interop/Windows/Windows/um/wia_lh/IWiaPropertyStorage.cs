// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage"]/*' />
[Guid("98B5E8A0-29CC-491A-AAC0-E6DB4FDCCEB6")]
[NativeTypeName("struct IWiaPropertyStorage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaPropertyStorage : IWiaPropertyStorage.Interface, INativeGuid
{
    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaPropertyStorage);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, Guid*, void**, int>)(lpVtbl[0]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, uint>)(lpVtbl[1]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, uint>)(lpVtbl[2]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.ReadMultiple"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReadMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC[]")] PROPSPEC* rgpspec, [NativeTypeName("PROPVARIANT[]")] PROPVARIANT* rgpropvar)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, uint, PROPSPEC*, PROPVARIANT*, int>)(lpVtbl[3]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec, rgpropvar);
    }

    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.WriteMultiple"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT WriteMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC[]")] PROPSPEC* rgpspec, [NativeTypeName("const PROPVARIANT[]")] PROPVARIANT* rgpropvar, [NativeTypeName("PROPID")] uint propidNameFirst)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, uint, PROPSPEC*, PROPVARIANT*, uint, int>)(lpVtbl[4]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec, rgpropvar, propidNameFirst);
    }

    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.DeleteMultiple"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DeleteMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC[]")] PROPSPEC* rgpspec)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, uint, PROPSPEC*, int>)(lpVtbl[5]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec);
    }

    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.ReadPropertyNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReadPropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID[]")] uint* rgpropid, [NativeTypeName("LPOLESTR[]")] char** rglpwstrName)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, uint, uint*, char**, int>)(lpVtbl[6]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid, rglpwstrName);
    }

    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.WritePropertyNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT WritePropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID[]")] uint* rgpropid, [NativeTypeName("const LPOLESTR[]")] char** rglpwstrName)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, uint, uint*, char**, int>)(lpVtbl[7]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid, rglpwstrName);
    }

    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.DeletePropertyNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeletePropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID[]")] uint* rgpropid)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, uint, uint*, int>)(lpVtbl[8]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid);
    }

    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.Commit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, uint, int>)(lpVtbl[9]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this), grfCommitFlags);
    }

    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.Revert"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, int>)(lpVtbl[10]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.Enum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Enum(IEnumSTATPROPSTG** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, IEnumSTATPROPSTG**, int>)(lpVtbl[11]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this), ppenum);
    }

    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.SetTimes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetTimes([NativeTypeName("const FILETIME *")] FILETIME* pctime, [NativeTypeName("const FILETIME *")] FILETIME* patime, [NativeTypeName("const FILETIME *")] FILETIME* pmtime)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, FILETIME*, FILETIME*, FILETIME*, int>)(lpVtbl[12]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this), pctime, patime, pmtime);
    }

    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.SetClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetClass([NativeTypeName("const IID &")] Guid* clsid)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, Guid*, int>)(lpVtbl[13]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this), clsid);
    }

    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.Stat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Stat(STATPROPSETSTG* pstatpsstg)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, STATPROPSETSTG*, int>)(lpVtbl[14]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this), pstatpsstg);
    }

    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.GetPropertyAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetPropertyAttributes([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("PROPSPEC[]")] PROPSPEC* rgpspec, [NativeTypeName("ULONG[]")] uint* rgflags, [NativeTypeName("PROPVARIANT[]")] PROPVARIANT* rgpropvar)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, uint, PROPSPEC*, uint*, PROPVARIANT*, int>)(lpVtbl[15]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec, rgflags, rgpropvar);
    }

    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.GetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetCount([NativeTypeName("ULONG *")] uint* pulNumProps)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, uint*, int>)(lpVtbl[16]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this), pulNumProps);
    }

    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.GetPropertyStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetPropertyStream(Guid* pCompatibilityId, IStream** ppIStream)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, Guid*, IStream**, int>)(lpVtbl[17]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this), pCompatibilityId, ppIStream);
    }

    /// <include file='IWiaPropertyStorage.xml' path='doc/member[@name="IWiaPropertyStorage.SetPropertyStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetPropertyStream(Guid* pCompatibilityId, IStream* pIStream)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPropertyStorage*, Guid*, IStream*, int>)(lpVtbl[18]))((IWiaPropertyStorage*)Unsafe.AsPointer(ref this), pCompatibilityId, pIStream);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReadMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC[]")] PROPSPEC* rgpspec, [NativeTypeName("PROPVARIANT[]")] PROPVARIANT* rgpropvar);

        [VtblIndex(4)]
        HRESULT WriteMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC[]")] PROPSPEC* rgpspec, [NativeTypeName("const PROPVARIANT[]")] PROPVARIANT* rgpropvar, [NativeTypeName("PROPID")] uint propidNameFirst);

        [VtblIndex(5)]
        HRESULT DeleteMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC[]")] PROPSPEC* rgpspec);

        [VtblIndex(6)]
        HRESULT ReadPropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID[]")] uint* rgpropid, [NativeTypeName("LPOLESTR[]")] char** rglpwstrName);

        [VtblIndex(7)]
        HRESULT WritePropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID[]")] uint* rgpropid, [NativeTypeName("const LPOLESTR[]")] char** rglpwstrName);

        [VtblIndex(8)]
        HRESULT DeletePropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID[]")] uint* rgpropid);

        [VtblIndex(9)]
        HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags);

        [VtblIndex(10)]
        HRESULT Revert();

        [VtblIndex(11)]
        HRESULT Enum(IEnumSTATPROPSTG** ppenum);

        [VtblIndex(12)]
        HRESULT SetTimes([NativeTypeName("const FILETIME *")] FILETIME* pctime, [NativeTypeName("const FILETIME *")] FILETIME* patime, [NativeTypeName("const FILETIME *")] FILETIME* pmtime);

        [VtblIndex(13)]
        HRESULT SetClass([NativeTypeName("const IID &")] Guid* clsid);

        [VtblIndex(14)]
        HRESULT Stat(STATPROPSETSTG* pstatpsstg);

        [VtblIndex(15)]
        HRESULT GetPropertyAttributes([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("PROPSPEC[]")] PROPSPEC* rgpspec, [NativeTypeName("ULONG[]")] uint* rgflags, [NativeTypeName("PROPVARIANT[]")] PROPVARIANT* rgpropvar);

        [VtblIndex(16)]
        HRESULT GetCount([NativeTypeName("ULONG *")] uint* pulNumProps);

        [VtblIndex(17)]
        HRESULT GetPropertyStream(Guid* pCompatibilityId, IStream** ppIStream);

        [VtblIndex(18)]
        HRESULT SetPropertyStream(Guid* pCompatibilityId, IStream* pIStream);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG, const PROPSPEC *, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, PROPSPEC*, PROPVARIANT*, int> ReadMultiple;

        [NativeTypeName("HRESULT (ULONG, const PROPSPEC *, const PROPVARIANT *, PROPID) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, PROPSPEC*, PROPVARIANT*, uint, int> WriteMultiple;

        [NativeTypeName("HRESULT (ULONG, const PROPSPEC *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, PROPSPEC*, int> DeleteMultiple;

        [NativeTypeName("HRESULT (ULONG, const PROPID *, LPOLESTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, char**, int> ReadPropertyNames;

        [NativeTypeName("HRESULT (ULONG, const PROPID *, const LPOLESTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, char**, int> WritePropertyNames;

        [NativeTypeName("HRESULT (ULONG, const PROPID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, int> DeletePropertyNames;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Commit;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Revert;

        [NativeTypeName("HRESULT (IEnumSTATPROPSTG **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEnumSTATPROPSTG**, int> Enum;

        [NativeTypeName("HRESULT (const FILETIME *, const FILETIME *, const FILETIME *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FILETIME*, FILETIME*, FILETIME*, int> SetTimes;

        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> SetClass;

        [NativeTypeName("HRESULT (STATPROPSETSTG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, STATPROPSETSTG*, int> Stat;

        [NativeTypeName("HRESULT (ULONG, PROPSPEC *, ULONG *, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, PROPSPEC*, uint*, PROPVARIANT*, int> GetPropertyAttributes;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (GUID *, IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IStream**, int> GetPropertyStream;

        [NativeTypeName("HRESULT (GUID *, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IStream*, int> SetPropertyStream;
    }
}
