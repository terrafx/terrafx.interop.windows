// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.xml.dom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IXmlCharacterData.xml' path='doc/member[@name="IXmlCharacterData"]/*' />
[Guid("132E42AB-4E36-4DF6-B1C8-0CE62FD88B26")]
[NativeTypeName("struct IXmlCharacterData : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IXmlCharacterData : IXmlCharacterData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IXmlCharacterData);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlCharacterData*, Guid*, void**, int>)(lpVtbl[0]))((IXmlCharacterData*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlCharacterData*, uint>)(lpVtbl[1]))((IXmlCharacterData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlCharacterData*, uint>)(lpVtbl[2]))((IXmlCharacterData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlCharacterData*, uint*, Guid**, int>)(lpVtbl[3]))((IXmlCharacterData*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlCharacterData*, HSTRING*, int>)(lpVtbl[4]))((IXmlCharacterData*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlCharacterData*, TrustLevel*, int>)(lpVtbl[5]))((IXmlCharacterData*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IXmlCharacterData.xml' path='doc/member[@name="IXmlCharacterData.get_Data"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Data(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlCharacterData*, HSTRING*, int>)(lpVtbl[6]))((IXmlCharacterData*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlCharacterData.xml' path='doc/member[@name="IXmlCharacterData.put_Data"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Data(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlCharacterData*, HSTRING, int>)(lpVtbl[7]))((IXmlCharacterData*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlCharacterData.xml' path='doc/member[@name="IXmlCharacterData.get_Length"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Length([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlCharacterData*, uint*, int>)(lpVtbl[8]))((IXmlCharacterData*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlCharacterData.xml' path='doc/member[@name="IXmlCharacterData.SubstringData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SubstringData([NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint count, HSTRING* data)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlCharacterData*, uint, uint, HSTRING*, int>)(lpVtbl[9]))((IXmlCharacterData*)Unsafe.AsPointer(ref this), offset, count, data);
    }

    /// <include file='IXmlCharacterData.xml' path='doc/member[@name="IXmlCharacterData.AppendData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AppendData(HSTRING data)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlCharacterData*, HSTRING, int>)(lpVtbl[10]))((IXmlCharacterData*)Unsafe.AsPointer(ref this), data);
    }

    /// <include file='IXmlCharacterData.xml' path='doc/member[@name="IXmlCharacterData.InsertData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT InsertData([NativeTypeName("UINT32")] uint offset, HSTRING data)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlCharacterData*, uint, HSTRING, int>)(lpVtbl[11]))((IXmlCharacterData*)Unsafe.AsPointer(ref this), offset, data);
    }

    /// <include file='IXmlCharacterData.xml' path='doc/member[@name="IXmlCharacterData.DeleteData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DeleteData([NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint count)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlCharacterData*, uint, uint, int>)(lpVtbl[12]))((IXmlCharacterData*)Unsafe.AsPointer(ref this), offset, count);
    }

    /// <include file='IXmlCharacterData.xml' path='doc/member[@name="IXmlCharacterData.ReplaceData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ReplaceData([NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint count, HSTRING data)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlCharacterData*, uint, uint, HSTRING, int>)(lpVtbl[13]))((IXmlCharacterData*)Unsafe.AsPointer(ref this), offset, count, data);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Data(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Data(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Length([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT SubstringData([NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint count, HSTRING* data);

        [VtblIndex(10)]
        HRESULT AppendData(HSTRING data);

        [VtblIndex(11)]
        HRESULT InsertData([NativeTypeName("UINT32")] uint offset, HSTRING data);

        [VtblIndex(12)]
        HRESULT DeleteData([NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint count);

        [VtblIndex(13)]
        HRESULT ReplaceData([NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint count, HSTRING data);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Data;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Data;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Length;

        [NativeTypeName("HRESULT (UINT32, UINT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, HSTRING*, int> SubstringData;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> AppendData;

        [NativeTypeName("HRESULT (UINT32, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, HSTRING, int> InsertData;

        [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, int> DeleteData;

        [NativeTypeName("HRESULT (UINT32, UINT32, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, HSTRING, int> ReplaceData;
    }
}
