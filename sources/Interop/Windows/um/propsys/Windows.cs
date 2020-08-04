// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("propsys", EntryPoint = "PropVariantToWinRTPropertyValue", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PropVariantToWinRTPropertyValue([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "WinRTPropertyValueToPropVariant", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WinRTPropertyValueToPropVariant([NativeTypeName("IUnknown *")] IUnknown* punkPropertyValue, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar);

        [DllImport("propsys", EntryPoint = "PSFormatForDisplay", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSFormatForDisplay([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdfFlags, [NativeTypeName("LPWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint cchText);

        [DllImport("propsys", EntryPoint = "PSFormatForDisplayAlloc", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSFormatForDisplayAlloc([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdff, [NativeTypeName("PWSTR *")] ushort** ppszDisplay);

        [DllImport("propsys", EntryPoint = "PSFormatPropertyValue", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSFormatPropertyValue([NativeTypeName("IPropertyStore *")] IPropertyStore* pps, [NativeTypeName("IPropertyDescription *")] IPropertyDescription* ppd, PROPDESC_FORMAT_FLAGS pdff, [NativeTypeName("LPWSTR *")] ushort** ppszDisplay);

        [DllImport("propsys", EntryPoint = "PSGetImageReferenceForValue", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetImageReferenceForValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("PWSTR *")] ushort** ppszImageRes);

        [DllImport("propsys", EntryPoint = "PSStringFromPropertyKey", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSStringFromPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* pkey, [NativeTypeName("LPWSTR")] ushort* psz, [NativeTypeName("UINT")] uint cch);

        [DllImport("propsys", EntryPoint = "PSPropertyKeyFromString", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyKeyFromString([NativeTypeName("LPCWSTR")] ushort* pszString, [NativeTypeName("PROPERTYKEY *")] PROPERTYKEY* pkey);

        [DllImport("propsys", EntryPoint = "PSCreateMemoryPropertyStore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCreateMemoryPropertyStore([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "PSCreateDelayedMultiplexPropertyStore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCreateDelayedMultiplexPropertyStore(GETPROPERTYSTOREFLAGS flags, [NativeTypeName("IDelayedPropertyStoreFactory *")] IDelayedPropertyStoreFactory* pdpsf, [NativeTypeName("const DWORD *")] uint* rgStoreIds, [NativeTypeName("DWORD")] uint cStores, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "PSCreateMultiplexPropertyStore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCreateMultiplexPropertyStore([NativeTypeName("IUnknown **")] IUnknown** prgpunkStores, [NativeTypeName("DWORD")] uint cStores, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "PSCreatePropertyChangeArray", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCreatePropertyChangeArray([NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgpropkey, [NativeTypeName("const PKA_FLAGS *")] PKA_FLAGS* rgflags, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* rgpropvar, [NativeTypeName("UINT")] uint cChanges, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "PSCreateSimplePropertyChange", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCreateSimplePropertyChange(PKA_FLAGS flags, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "PSGetPropertyDescription", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetPropertyDescription([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "PSGetPropertyDescriptionByName", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetPropertyDescriptionByName([NativeTypeName("LPCWSTR")] ushort* pszCanonicalName, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "PSLookupPropertyHandlerCLSID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSLookupPropertyHandlerCLSID([NativeTypeName("PCWSTR")] ushort* pszFilePath, [NativeTypeName("CLSID *")] Guid* pclsid);

        [DllImport("propsys", EntryPoint = "PSGetItemPropertyHandler", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetItemPropertyHandler([NativeTypeName("IUnknown *")] IUnknown* punkItem, [NativeTypeName("BOOL")] int fReadWrite, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "PSGetItemPropertyHandlerWithCreateObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetItemPropertyHandlerWithCreateObject([NativeTypeName("IUnknown *")] IUnknown* punkItem, [NativeTypeName("BOOL")] int fReadWrite, [NativeTypeName("IUnknown *")] IUnknown* punkCreateObject, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "PSGetPropertyValue", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetPropertyValue([NativeTypeName("IPropertyStore *")] IPropertyStore* pps, [NativeTypeName("IPropertyDescription *")] IPropertyDescription* ppd, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar);

        [DllImport("propsys", EntryPoint = "PSSetPropertyValue", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSSetPropertyValue([NativeTypeName("IPropertyStore *")] IPropertyStore* pps, [NativeTypeName("IPropertyDescription *")] IPropertyDescription* ppd, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar);

        [DllImport("propsys", EntryPoint = "PSRegisterPropertySchema", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSRegisterPropertySchema([NativeTypeName("PCWSTR")] ushort* pszPath);

        [DllImport("propsys", EntryPoint = "PSUnregisterPropertySchema", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSUnregisterPropertySchema([NativeTypeName("PCWSTR")] ushort* pszPath);

        [DllImport("propsys", EntryPoint = "PSRefreshPropertySchema", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSRefreshPropertySchema();

        [DllImport("propsys", EntryPoint = "PSEnumeratePropertyDescriptions", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSEnumeratePropertyDescriptions(PROPDESC_ENUMFILTER filterOn, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "PSGetPropertyKeyFromName", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetPropertyKeyFromName([NativeTypeName("PCWSTR")] ushort* pszName, [NativeTypeName("PROPERTYKEY *")] PROPERTYKEY* ppropkey);

        [DllImport("propsys", EntryPoint = "PSGetNameFromPropertyKey", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetNameFromPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("PWSTR *")] ushort** ppszCanonicalName);

        [DllImport("propsys", EntryPoint = "PSCoerceToCanonicalValue", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCoerceToCanonicalValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar);

        [DllImport("propsys", EntryPoint = "PSGetPropertyDescriptionListFromString", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetPropertyDescriptionListFromString([NativeTypeName("LPCWSTR")] ushort* pszPropList, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "PSCreatePropertyStoreFromPropertySetStorage", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCreatePropertyStoreFromPropertySetStorage([NativeTypeName("IPropertySetStorage *")] IPropertySetStorage* ppss, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "PSCreatePropertyStoreFromObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCreatePropertyStoreFromObject([NativeTypeName("IUnknown *")] IUnknown* punk, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "PSCreateAdapterFromPropertyStore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCreateAdapterFromPropertyStore([NativeTypeName("IPropertyStore *")] IPropertyStore* pps, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "PSGetPropertySystem", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetPropertySystem([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "PSGetPropertyFromPropertyStorage", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetPropertyFromPropertyStorage([NativeTypeName("PCUSERIALIZEDPROPSTORAGE")] IntPtr psps, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* rpkey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar);

        [DllImport("propsys", EntryPoint = "PSGetNamedPropertyFromPropertyStorage", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetNamedPropertyFromPropertyStorage([NativeTypeName("PCUSERIALIZEDPROPSTORAGE")] IntPtr psps, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadType([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("VARIANT *")] VARIANT* var, [NativeTypeName("VARTYPE")] ushort type);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadStr", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadStr([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("LPWSTR")] ushort* value, int characterCount);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadStrAlloc", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadStrAlloc([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("PWSTR *")] ushort** value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadBSTR", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadBSTR([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("BSTR *")] ushort** value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_WriteStr", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteStr([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("LPCWSTR")] ushort* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_WriteBSTR", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteBSTR([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("BSTR")] ushort* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadInt", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadInt([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("INT *")] int* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_WriteInt", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteInt([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("INT")] int value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadSHORT", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadSHORT([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("SHORT *")] short* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_WriteSHORT", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteSHORT([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("SHORT")] short value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadLONG", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadLONG([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("LONG *")] int* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_WriteLONG", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteLONG([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("LONG")] int value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadDWORD", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadDWORD([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("DWORD *")] uint* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_WriteDWORD", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteDWORD([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("DWORD")] uint value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadBOOL", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadBOOL([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("BOOL *")] int* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_WriteBOOL", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteBOOL([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("BOOL")] int value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadPOINTL", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadPOINTL([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("POINTL *")] POINTL* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_WritePOINTL", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WritePOINTL([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const POINTL *")] POINTL* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadPOINTS", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadPOINTS([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("POINTS *")] POINTS* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_WritePOINTS", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WritePOINTS([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const POINTS *")] POINTS* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadRECTL", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadRECTL([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("RECTL *")] RECTL* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_WriteRECTL", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteRECTL([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const RECTL *")] RECTL* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadStream([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("IStream **")] IStream** value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_WriteStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteStream([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("IStream *")] IStream* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_Delete", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_Delete([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadULONGLONG", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadULONGLONG([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("ULONGLONG *")] ulong* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_WriteULONGLONG", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteULONGLONG([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("ULONGLONG")] ulong value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadUnknown", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadUnknown([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_WriteUnknown", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteUnknown([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("IUnknown *")] IUnknown* punk);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadGUID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadGUID([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("GUID *")] Guid* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_WriteGUID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteGUID([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const GUID *")] Guid* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_ReadPropertyKey", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadPropertyKey([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("PROPERTYKEY *")] PROPERTYKEY* value);

        [DllImport("propsys", EntryPoint = "PSPropertyBag_WritePropertyKey", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WritePropertyKey([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* value);

        [NativeTypeName("#define PDFF_PREFERFRIENDLY static_cast<PROPDESC_FORMAT_FLAGS>(0x10000000)")]
        public const PROPDESC_FORMAT_FLAGS PDFF_PREFERFRIENDLY = (PROPDESC_FORMAT_FLAGS)(0x10000000);

        [NativeTypeName("#define PKEY_PIDSTR_MAX 10")]
        public const int PKEY_PIDSTR_MAX = 10;

        [NativeTypeName("#define GUIDSTRING_MAX (1 + 8 + 1 + 4 + 1 + 4 + 1 + 4 + 1 + 12 + 1 + 1)")]
        public const int GUIDSTRING_MAX = (1 + 8 + 1 + 4 + 1 + 4 + 1 + 4 + 1 + 12 + 1 + 1);

        [NativeTypeName("#define PKEYSTR_MAX (GUIDSTRING_MAX + 1 + PKEY_PIDSTR_MAX)")]
        public const int PKEYSTR_MAX = ((1 + 8 + 1 + 4 + 1 + 4 + 1 + 4 + 1 + 12 + 1 + 1) + 1 + 10);
    }
}
