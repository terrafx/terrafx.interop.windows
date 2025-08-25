// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostPropertySchema.xml' path='doc/member[@name="IAppHostPropertySchema"]/*' />
[Guid("450386DB-7409-4667-935E-384DBBEE2A9E")]
[NativeTypeName("struct IAppHostPropertySchema : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostPropertySchema : IAppHostPropertySchema.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostPropertySchema);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, uint>)(lpVtbl[1]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, uint>)(lpVtbl[2]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostPropertySchema.xml' path='doc/member[@name="IAppHostPropertySchema.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] char** pbstrName)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, char**, int>)(lpVtbl[3]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='IAppHostPropertySchema.xml' path='doc/member[@name="IAppHostPropertySchema.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Type([NativeTypeName("BSTR *")] char** pbstrType)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, char**, int>)(lpVtbl[4]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this), pbstrType);
    }

    /// <include file='IAppHostPropertySchema.xml' path='doc/member[@name="IAppHostPropertySchema.get_DefaultValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_DefaultValue(VARIANT* pDefaultValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, VARIANT*, int>)(lpVtbl[5]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this), pDefaultValue);
    }

    /// <include file='IAppHostPropertySchema.xml' path='doc/member[@name="IAppHostPropertySchema.get_IsRequired"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsRequired([NativeTypeName("VARIANT_BOOL *")] short* pfIsRequired)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, short*, int>)(lpVtbl[6]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this), pfIsRequired);
    }

    /// <include file='IAppHostPropertySchema.xml' path='doc/member[@name="IAppHostPropertySchema.get_IsUniqueKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsUniqueKey([NativeTypeName("VARIANT_BOOL *")] short* pfIsUniqueKey)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, short*, int>)(lpVtbl[7]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this), pfIsUniqueKey);
    }

    /// <include file='IAppHostPropertySchema.xml' path='doc/member[@name="IAppHostPropertySchema.get_IsCombinedKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsCombinedKey([NativeTypeName("VARIANT_BOOL *")] short* pfIsCombinedKey)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, short*, int>)(lpVtbl[8]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this), pfIsCombinedKey);
    }

    /// <include file='IAppHostPropertySchema.xml' path='doc/member[@name="IAppHostPropertySchema.get_IsExpanded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsExpanded([NativeTypeName("VARIANT_BOOL *")] short* pfIsExpanded)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, short*, int>)(lpVtbl[9]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this), pfIsExpanded);
    }

    /// <include file='IAppHostPropertySchema.xml' path='doc/member[@name="IAppHostPropertySchema.get_ValidationType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ValidationType([NativeTypeName("BSTR *")] char** pbstrValidationType)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, char**, int>)(lpVtbl[10]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this), pbstrValidationType);
    }

    /// <include file='IAppHostPropertySchema.xml' path='doc/member[@name="IAppHostPropertySchema.get_ValidationParameter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ValidationParameter([NativeTypeName("BSTR *")] char** pbstrValidationParameter)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, char**, int>)(lpVtbl[11]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this), pbstrValidationParameter);
    }

    /// <include file='IAppHostPropertySchema.xml' path='doc/member[@name="IAppHostPropertySchema.GetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, char*, VARIANT*, int>)(lpVtbl[12]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this), bstrMetadataType, pValue);
    }

    /// <include file='IAppHostPropertySchema.xml' path='doc/member[@name="IAppHostPropertySchema.get_IsCaseSensitive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_IsCaseSensitive([NativeTypeName("VARIANT_BOOL *")] short* pfIsCaseSensitive)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, short*, int>)(lpVtbl[13]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this), pfIsCaseSensitive);
    }

    /// <include file='IAppHostPropertySchema.xml' path='doc/member[@name="IAppHostPropertySchema.get_PossibleValues"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PossibleValues(IAppHostConstantValueCollection** ppValues)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, IAppHostConstantValueCollection**, int>)(lpVtbl[14]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this), ppValues);
    }

    /// <include file='IAppHostPropertySchema.xml' path='doc/member[@name="IAppHostPropertySchema.get_DoesAllowInfinite"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_DoesAllowInfinite([NativeTypeName("VARIANT_BOOL *")] short* pfAllowInfinite)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, short*, int>)(lpVtbl[15]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this), pfAllowInfinite);
    }

    /// <include file='IAppHostPropertySchema.xml' path='doc/member[@name="IAppHostPropertySchema.get_IsEncrypted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_IsEncrypted([NativeTypeName("VARIANT_BOOL *")] short* pfIsEncrypted)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, short*, int>)(lpVtbl[16]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this), pfIsEncrypted);
    }

    /// <include file='IAppHostPropertySchema.xml' path='doc/member[@name="IAppHostPropertySchema.get_TimeSpanFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_TimeSpanFormat([NativeTypeName("BSTR *")] char** pbstrTimeSpanFormat)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertySchema*, char**, int>)(lpVtbl[17]))((IAppHostPropertySchema*)Unsafe.AsPointer(ref this), pbstrTimeSpanFormat);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Name([NativeTypeName("BSTR *")] char** pbstrName);

        [VtblIndex(4)]
        HRESULT get_Type([NativeTypeName("BSTR *")] char** pbstrType);

        [VtblIndex(5)]
        HRESULT get_DefaultValue(VARIANT* pDefaultValue);

        [VtblIndex(6)]
        HRESULT get_IsRequired([NativeTypeName("VARIANT_BOOL *")] short* pfIsRequired);

        [VtblIndex(7)]
        HRESULT get_IsUniqueKey([NativeTypeName("VARIANT_BOOL *")] short* pfIsUniqueKey);

        [VtblIndex(8)]
        HRESULT get_IsCombinedKey([NativeTypeName("VARIANT_BOOL *")] short* pfIsCombinedKey);

        [VtblIndex(9)]
        HRESULT get_IsExpanded([NativeTypeName("VARIANT_BOOL *")] short* pfIsExpanded);

        [VtblIndex(10)]
        HRESULT get_ValidationType([NativeTypeName("BSTR *")] char** pbstrValidationType);

        [VtblIndex(11)]
        HRESULT get_ValidationParameter([NativeTypeName("BSTR *")] char** pbstrValidationParameter);

        [VtblIndex(12)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue);

        [VtblIndex(13)]
        HRESULT get_IsCaseSensitive([NativeTypeName("VARIANT_BOOL *")] short* pfIsCaseSensitive);

        [VtblIndex(14)]
        HRESULT get_PossibleValues(IAppHostConstantValueCollection** ppValues);

        [VtblIndex(15)]
        HRESULT get_DoesAllowInfinite([NativeTypeName("VARIANT_BOOL *")] short* pfAllowInfinite);

        [VtblIndex(16)]
        HRESULT get_IsEncrypted([NativeTypeName("VARIANT_BOOL *")] short* pfIsEncrypted);

        [VtblIndex(17)]
        HRESULT get_TimeSpanFormat([NativeTypeName("BSTR *")] char** pbstrTimeSpanFormat);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_Name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_Type;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_DefaultValue;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_IsRequired;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_IsUniqueKey;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_IsCombinedKey;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_IsExpanded;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ValidationType;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_ValidationParameter;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> GetMetadata;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_IsCaseSensitive;

        [NativeTypeName("HRESULT (IAppHostConstantValueCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostConstantValueCollection**, int> get_PossibleValues;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_DoesAllowInfinite;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_IsEncrypted;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_TimeSpanFormat;
    }
}
