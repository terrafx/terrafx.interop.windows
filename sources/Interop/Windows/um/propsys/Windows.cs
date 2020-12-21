// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PropVariantToWinRTPropertyValue([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WinRTPropertyValueToPropVariant([NativeTypeName("IUnknown *")] IUnknown* punkPropertyValue, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSFormatForDisplay([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdfFlags, [NativeTypeName("LPWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint cchText);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSFormatForDisplayAlloc([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdff, [NativeTypeName("PWSTR *")] ushort** ppszDisplay);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSFormatPropertyValue([NativeTypeName("IPropertyStore *")] IPropertyStore* pps, [NativeTypeName("IPropertyDescription *")] IPropertyDescription* ppd, PROPDESC_FORMAT_FLAGS pdff, [NativeTypeName("LPWSTR *")] ushort** ppszDisplay);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetImageReferenceForValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("PWSTR *")] ushort** ppszImageRes);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSStringFromPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* pkey, [NativeTypeName("LPWSTR")] ushort* psz, [NativeTypeName("UINT")] uint cch);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyKeyFromString([NativeTypeName("LPCWSTR")] ushort* pszString, [NativeTypeName("PROPERTYKEY *")] PROPERTYKEY* pkey);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCreateMemoryPropertyStore([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCreateDelayedMultiplexPropertyStore(GETPROPERTYSTOREFLAGS flags, [NativeTypeName("IDelayedPropertyStoreFactory *")] IDelayedPropertyStoreFactory* pdpsf, [NativeTypeName("const DWORD *")] uint* rgStoreIds, [NativeTypeName("DWORD")] uint cStores, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCreateMultiplexPropertyStore([NativeTypeName("IUnknown **")] IUnknown** prgpunkStores, [NativeTypeName("DWORD")] uint cStores, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCreatePropertyChangeArray([NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgpropkey, [NativeTypeName("const PKA_FLAGS *")] PKA_FLAGS* rgflags, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* rgpropvar, [NativeTypeName("UINT")] uint cChanges, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCreateSimplePropertyChange(PKA_FLAGS flags, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetPropertyDescription([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetPropertyDescriptionByName([NativeTypeName("LPCWSTR")] ushort* pszCanonicalName, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSLookupPropertyHandlerCLSID([NativeTypeName("PCWSTR")] ushort* pszFilePath, [NativeTypeName("CLSID *")] Guid* pclsid);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetItemPropertyHandler([NativeTypeName("IUnknown *")] IUnknown* punkItem, [NativeTypeName("BOOL")] int fReadWrite, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetItemPropertyHandlerWithCreateObject([NativeTypeName("IUnknown *")] IUnknown* punkItem, [NativeTypeName("BOOL")] int fReadWrite, [NativeTypeName("IUnknown *")] IUnknown* punkCreateObject, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetPropertyValue([NativeTypeName("IPropertyStore *")] IPropertyStore* pps, [NativeTypeName("IPropertyDescription *")] IPropertyDescription* ppd, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSSetPropertyValue([NativeTypeName("IPropertyStore *")] IPropertyStore* pps, [NativeTypeName("IPropertyDescription *")] IPropertyDescription* ppd, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSRegisterPropertySchema([NativeTypeName("PCWSTR")] ushort* pszPath);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSUnregisterPropertySchema([NativeTypeName("PCWSTR")] ushort* pszPath);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSRefreshPropertySchema();

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSEnumeratePropertyDescriptions(PROPDESC_ENUMFILTER filterOn, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetPropertyKeyFromName([NativeTypeName("PCWSTR")] ushort* pszName, [NativeTypeName("PROPERTYKEY *")] PROPERTYKEY* ppropkey);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetNameFromPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("PWSTR *")] ushort** ppszCanonicalName);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCoerceToCanonicalValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetPropertyDescriptionListFromString([NativeTypeName("LPCWSTR")] ushort* pszPropList, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCreatePropertyStoreFromPropertySetStorage([NativeTypeName("IPropertySetStorage *")] IPropertySetStorage* ppss, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCreatePropertyStoreFromObject([NativeTypeName("IUnknown *")] IUnknown* punk, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSCreateAdapterFromPropertyStore([NativeTypeName("IPropertyStore *")] IPropertyStore* pps, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetPropertySystem([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetPropertyFromPropertyStorage([NativeTypeName("PCUSERIALIZEDPROPSTORAGE")] IntPtr psps, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* rpkey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSGetNamedPropertyFromPropertyStorage([NativeTypeName("PCUSERIALIZEDPROPSTORAGE")] IntPtr psps, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadType([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("VARIANT *")] VARIANT* var, [NativeTypeName("VARTYPE")] ushort type);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadStr([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("LPWSTR")] ushort* value, int characterCount);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadStrAlloc([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("PWSTR *")] ushort** value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadBSTR([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("BSTR *")] ushort** value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteStr([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("LPCWSTR")] ushort* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteBSTR([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("BSTR")] ushort* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadInt([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("INT *")] int* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteInt([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("INT")] int value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadSHORT([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("SHORT *")] short* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteSHORT([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("SHORT")] short value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadLONG([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("LONG *")] int* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteLONG([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("LONG")] int value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadDWORD([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("DWORD *")] uint* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteDWORD([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("DWORD")] uint value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadBOOL([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("BOOL *")] int* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteBOOL([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("BOOL")] int value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadPOINTL([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("POINTL *")] POINTL* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WritePOINTL([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const POINTL *")] POINTL* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadPOINTS([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("POINTS *")] POINTS* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WritePOINTS([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const POINTS *")] POINTS* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadRECTL([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("RECTL *")] RECTL* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteRECTL([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const RECTL *")] RECTL* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadStream([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("IStream **")] IStream** value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteStream([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("IStream *")] IStream* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_Delete([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadULONGLONG([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("ULONGLONG *")] ulong* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteULONGLONG([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("ULONGLONG")] ulong value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadUnknown([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteUnknown([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("IUnknown *")] IUnknown* punk);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadGUID([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("GUID *")] Guid* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_WriteGUID([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const GUID *")] Guid* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PSPropertyBag_ReadPropertyKey([NativeTypeName("IPropertyBag *")] IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("PROPERTYKEY *")] PROPERTYKEY* value);

        [DllImport("propsys", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
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

        public static readonly Guid IID_IInitializeWithFile = new Guid(0xB7D14566, 0x0509, 0x4CCE, 0xA7, 0x1F, 0x0A, 0x55, 0x42, 0x33, 0xBD, 0x9B);

        public static readonly Guid IID_IInitializeWithStream = new Guid(0xB824B49D, 0x22AC, 0x4161, 0xAC, 0x8A, 0x99, 0x16, 0xE8, 0xFA, 0x3F, 0x7F);

        public static readonly Guid IID_IPropertyStore = new Guid(0x886D8EEB, 0x8CF2, 0x4446, 0x8D, 0x02, 0xCD, 0xBA, 0x1D, 0xBD, 0xCF, 0x99);

        public static readonly Guid IID_INamedPropertyStore = new Guid(0x71604B0F, 0x97B0, 0x4764, 0x85, 0x77, 0x2F, 0x13, 0xE9, 0x8A, 0x14, 0x22);

        public static readonly Guid IID_IObjectWithPropertyKey = new Guid(0xFC0CA0A7, 0xC316, 0x4FD2, 0x90, 0x31, 0x3E, 0x62, 0x8E, 0x6D, 0x4F, 0x23);

        public static readonly Guid IID_IPropertyChange = new Guid(0xF917BC8A, 0x1BBA, 0x4478, 0xA2, 0x45, 0x1B, 0xDE, 0x03, 0xEB, 0x94, 0x31);

        public static readonly Guid IID_IPropertyChangeArray = new Guid(0x380F5CAD, 0x1B5E, 0x42F2, 0x80, 0x5D, 0x63, 0x7F, 0xD3, 0x92, 0xD3, 0x1E);

        public static readonly Guid IID_IPropertyStoreCapabilities = new Guid(0xC8E2D566, 0x186E, 0x4D49, 0xBF, 0x41, 0x69, 0x09, 0xEA, 0xD5, 0x6A, 0xCC);

        public static readonly Guid IID_IPropertyStoreCache = new Guid(0x3017056D, 0x9A91, 0x4E90, 0x93, 0x7D, 0x74, 0x6C, 0x72, 0xAB, 0xBF, 0x4F);

        public static readonly Guid IID_IPropertyEnumType = new Guid(0x11E1FBF9, 0x2D56, 0x4A6B, 0x8D, 0xB3, 0x7C, 0xD1, 0x93, 0xA4, 0x71, 0xF2);

        public static readonly Guid IID_IPropertyEnumType2 = new Guid(0x9B6E051C, 0x5DDD, 0x4321, 0x90, 0x70, 0xFE, 0x2A, 0xCB, 0x55, 0xE7, 0x94);

        public static readonly Guid IID_IPropertyEnumTypeList = new Guid(0xA99400F4, 0x3D84, 0x4557, 0x94, 0xBA, 0x12, 0x42, 0xFB, 0x2C, 0xC9, 0xA6);

        public static readonly Guid IID_IPropertyDescription = new Guid(0x6F79D558, 0x3E96, 0x4549, 0xA1, 0xD1, 0x7D, 0x75, 0xD2, 0x28, 0x88, 0x14);

        public static readonly Guid IID_IPropertyDescription2 = new Guid(0x57D2EDED, 0x5062, 0x400E, 0xB1, 0x07, 0x5D, 0xAE, 0x79, 0xFE, 0x57, 0xA6);

        public static readonly Guid IID_IPropertyDescriptionAliasInfo = new Guid(0xF67104FC, 0x2AF9, 0x46FD, 0xB3, 0x2D, 0x24, 0x3C, 0x14, 0x04, 0xF3, 0xD1);

        public static readonly Guid IID_IPropertyDescriptionSearchInfo = new Guid(0x078F91BD, 0x29A2, 0x440F, 0x92, 0x4E, 0x46, 0xA2, 0x91, 0x52, 0x45, 0x20);

        public static readonly Guid IID_IPropertyDescriptionRelatedPropertyInfo = new Guid(0x507393F4, 0x2A3D, 0x4A60, 0xB5, 0x9E, 0xD9, 0xC7, 0x57, 0x16, 0xC2, 0xDD);

        public static readonly Guid IID_IPropertySystem = new Guid(0xCA724E8A, 0xC3E6, 0x442B, 0x88, 0xA4, 0x6F, 0xB0, 0xDB, 0x80, 0x35, 0xA3);

        public static readonly Guid IID_IPropertyDescriptionList = new Guid(0x1F9FC1D0, 0xC39B, 0x4B26, 0x81, 0x7F, 0x01, 0x19, 0x67, 0xD3, 0x44, 0x0E);

        public static readonly Guid IID_IPropertyStoreFactory = new Guid(0xBC110B6D, 0x57E8, 0x4148, 0xA9, 0xC6, 0x91, 0x01, 0x5A, 0xB2, 0xF3, 0xA5);

        public static readonly Guid IID_IDelayedPropertyStoreFactory = new Guid(0x40D4577F, 0xE237, 0x4BDB, 0xBD, 0x69, 0x58, 0xF0, 0x89, 0x43, 0x1B, 0x6A);

        public static readonly Guid IID_IPersistSerializedPropStorage = new Guid(0xE318AD57, 0x0AA0, 0x450F, 0xAC, 0xA5, 0x6F, 0xAB, 0x71, 0x03, 0xD9, 0x17);

        public static readonly Guid IID_IPersistSerializedPropStorage2 = new Guid(0x77EFFA68, 0x4F98, 0x4366, 0xBA, 0x72, 0x57, 0x3B, 0x3D, 0x88, 0x05, 0x71);

        public static readonly Guid IID_IPropertySystemChangeNotify = new Guid(0xFA955FD9, 0x38BE, 0x4879, 0xA6, 0xCE, 0x82, 0x4C, 0xF5, 0x2D, 0x60, 0x9F);

        public static readonly Guid IID_ICreateObject = new Guid(0x75121952, 0xE0D0, 0x43E5, 0x93, 0x80, 0x1D, 0x80, 0x48, 0x3A, 0xCF, 0x72);

        public static readonly Guid CLSID_InMemoryPropertyStore = new Guid(0x9A02E012, 0x6303, 0x4E1E, 0xB9, 0xA1, 0x63, 0x0F, 0x80, 0x25, 0x92, 0xC5);

        public static readonly Guid CLSID_InMemoryPropertyStoreMarshalByValue = new Guid(0xD4CA0E2D, 0x6DA7, 0x4B75, 0xA9, 0x7C, 0x5F, 0x30, 0x6F, 0x0E, 0xAE, 0xDC);

        public static readonly Guid CLSID_PropertySystem = new Guid(0xB8967F85, 0x58AE, 0x4F46, 0x9F, 0xB2, 0x5D, 0x79, 0x04, 0x79, 0x8F, 0x4B);
    }
}
