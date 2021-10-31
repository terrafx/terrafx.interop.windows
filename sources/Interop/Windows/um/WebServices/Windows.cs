// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int WS_HTTP_HEADER_MAPPING_COMMA_SEPARATOR = 0x1;
        public const int WS_HTTP_HEADER_MAPPING_SEMICOLON_SEPARATOR = 0x2;
        public const int WS_HTTP_HEADER_MAPPING_QUOTED_VALUE = 0x4;

        public const int WS_HTTP_RESPONSE_MAPPING_STATUS_CODE = 0x1;
        public const int WS_HTTP_RESPONSE_MAPPING_STATUS_TEXT = 0x2;

        public const int WS_HTTP_REQUEST_MAPPING_VERB = 0x2;

        public const int WS_MATCH_URL_DNS_HOST = 0x1;
        public const int WS_MATCH_URL_DNS_FULLY_QUALIFIED_HOST = 0x2;
        public const int WS_MATCH_URL_NETBIOS_HOST = 0x4;
        public const int WS_MATCH_URL_LOCAL_HOST = 0x8;
        public const int WS_MATCH_URL_HOST_ADDRESSES = 0x10;
        public const int WS_MATCH_URL_THIS_HOST = (WS_MATCH_URL_DNS_HOST | WS_MATCH_URL_DNS_FULLY_QUALIFIED_HOST | WS_MATCH_URL_NETBIOS_HOST | WS_MATCH_URL_LOCAL_HOST | WS_MATCH_URL_HOST_ADDRESSES);
        public const int WS_MATCH_URL_PORT = 0x20;
        public const int WS_MATCH_URL_EXACT_PATH = 0x40;
        public const int WS_MATCH_URL_PREFIX_PATH = 0x80;
        public const int WS_MATCH_URL_NO_QUERY = 0x100;

        public const int WS_MUST_UNDERSTAND_HEADER_ATTRIBUTE = 0x1;
        public const int WS_RELAY_HEADER_ATTRIBUTE = 0x2;

        public const int WS_HTTP_HEADER_AUTH_SCHEME_NONE = 0x1;
        public const int WS_HTTP_HEADER_AUTH_SCHEME_BASIC = 0x2;
        public const int WS_HTTP_HEADER_AUTH_SCHEME_DIGEST = 0x4;
        public const int WS_HTTP_HEADER_AUTH_SCHEME_NTLM = 0x8;
        public const int WS_HTTP_HEADER_AUTH_SCHEME_NEGOTIATE = 0x10;
        public const int WS_HTTP_HEADER_AUTH_SCHEME_PASSPORT = 0x20;

        public const int WS_CERT_FAILURE_CN_MISMATCH = 0x1;
        public const int WS_CERT_FAILURE_INVALID_DATE = 0x2;
        public const int WS_CERT_FAILURE_UNTRUSTED_ROOT = 0x4;
        public const int WS_CERT_FAILURE_WRONG_USAGE = 0x8;
        public const int WS_CERT_FAILURE_REVOCATION_OFFLINE = 0x10;

        public const int WS_STRUCT_ABSTRACT = 0x1;
        public const int WS_STRUCT_IGNORE_TRAILING_ELEMENT_CONTENT = 0x2;
        public const int WS_STRUCT_IGNORE_UNHANDLED_ATTRIBUTES = 0x4;

        public const int WS_FIELD_POINTER = 0x1;
        public const int WS_FIELD_OPTIONAL = 0x2;
        public const int WS_FIELD_NILLABLE = 0x4;
        public const int WS_FIELD_NILLABLE_ITEM = 0x8;
        public const int WS_FIELD_OTHER_NAMESPACE = 0x10;

        public const int WS_SERVICE_OPERATION_MESSAGE_NILLABLE_ELEMENT = 0x1;

        public const int WS_URL_FLAGS_ALLOW_HOST_WILDCARDS = 0x1;
        public const int WS_URL_FLAGS_NO_PATH_COLLAPSE = 0x2;
        public const int WS_URL_FLAGS_ZERO_TERMINATE = 0x4;

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsStartReaderCanonicalization([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("WS_WRITE_CALLBACK")] delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, int> writeCallback, void* writeCallbackState, [NativeTypeName("const WS_XML_CANONICALIZATION_PROPERTY *")] WS_XML_CANONICALIZATION_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsEndReaderCanonicalization([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsStartWriterCanonicalization([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("WS_WRITE_CALLBACK")] delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, int> writeCallback, void* writeCallbackState, [NativeTypeName("const WS_XML_CANONICALIZATION_PROPERTY *")] WS_XML_CANONICALIZATION_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsEndWriterCanonicalization([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateXmlBuffer([NativeTypeName("WS_HEAP *")] IntPtr heap, [NativeTypeName("const WS_XML_BUFFER_PROPERTY *")] WS_XML_BUFFER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_XML_BUFFER **")] IntPtr* buffer, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsRemoveNode([NativeTypeName("const WS_XML_NODE_POSITION *")] WS_XML_NODE_POSITION* nodePosition, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateReader([NativeTypeName("const WS_XML_READER_PROPERTY *")] WS_XML_READER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_XML_READER **")] IntPtr* reader, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSetInput([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("const WS_XML_READER_ENCODING *")] WS_XML_READER_ENCODING* encoding, [NativeTypeName("const WS_XML_READER_INPUT *")] WS_XML_READER_INPUT* input, [NativeTypeName("const WS_XML_READER_PROPERTY *")] WS_XML_READER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSetInputToBuffer([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("WS_XML_BUFFER *")] IntPtr buffer, [NativeTypeName("const WS_XML_READER_PROPERTY *")] WS_XML_READER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeReader([NativeTypeName("WS_XML_READER *")] IntPtr reader);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetReaderProperty([NativeTypeName("WS_XML_READER *")] IntPtr reader, WS_XML_READER_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetReaderNode([NativeTypeName("WS_XML_READER *")] IntPtr xmlReader, [NativeTypeName("const WS_XML_NODE **")] WS_XML_NODE** node, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsFillReader([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("ULONG")] uint minSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadStartElement([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadToStartElement([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL* found, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadStartAttribute([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("ULONG")] uint attributeIndex, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadEndAttribute([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadNode([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSkipNode([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadEndElement([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsFindAttribute([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL required, [NativeTypeName("ULONG *")] uint* attributeIndex, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadValue([NativeTypeName("WS_XML_READER *")] IntPtr reader, WS_VALUE_TYPE valueType, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadChars([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("WCHAR *")] ushort* chars, [NativeTypeName("ULONG")] uint maxCharCount, [NativeTypeName("ULONG *")] uint* actualCharCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadCharsUtf8([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("BYTE *")] byte* bytes, [NativeTypeName("ULONG")] uint maxByteCount, [NativeTypeName("ULONG *")] uint* actualByteCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadBytes([NativeTypeName("WS_XML_READER *")] IntPtr reader, void* bytes, [NativeTypeName("ULONG")] uint maxByteCount, [NativeTypeName("ULONG *")] uint* actualByteCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadArray([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, WS_VALUE_TYPE valueType, void* array, [NativeTypeName("ULONG")] uint arraySize, [NativeTypeName("ULONG")] uint itemOffset, [NativeTypeName("ULONG")] uint itemCount, [NativeTypeName("ULONG *")] uint* actualItemCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetReaderPosition([NativeTypeName("WS_XML_READER *")] IntPtr reader, WS_XML_NODE_POSITION* nodePosition, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSetReaderPosition([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("const WS_XML_NODE_POSITION *")] WS_XML_NODE_POSITION* nodePosition, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsMoveReader([NativeTypeName("WS_XML_READER *")] IntPtr reader, WS_MOVE_TO moveTo, BOOL* found, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateWriter([NativeTypeName("const WS_XML_WRITER_PROPERTY *")] WS_XML_WRITER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_XML_WRITER **")] IntPtr* writer, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeWriter([NativeTypeName("WS_XML_WRITER *")] IntPtr writer);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSetOutput([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("const WS_XML_WRITER_ENCODING *")] WS_XML_WRITER_ENCODING* encoding, [NativeTypeName("const WS_XML_WRITER_OUTPUT *")] WS_XML_WRITER_OUTPUT* output, [NativeTypeName("const WS_XML_WRITER_PROPERTY *")] WS_XML_WRITER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSetOutputToBuffer([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("WS_XML_BUFFER *")] IntPtr buffer, [NativeTypeName("const WS_XML_WRITER_PROPERTY *")] WS_XML_WRITER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetWriterProperty([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, WS_XML_WRITER_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsFlushWriter([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("ULONG")] uint minSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteStartElement([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteEndStartElement([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteXmlnsAttribute([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL singleQuote, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteStartAttribute([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL singleQuote, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteEndAttribute([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteValue([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, WS_VALUE_TYPE valueType, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteXmlBuffer([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("WS_XML_BUFFER *")] IntPtr xmlBuffer, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadXmlBuffer([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("WS_HEAP *")] IntPtr heap, [NativeTypeName("WS_XML_BUFFER **")] IntPtr* xmlBuffer, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteXmlBufferToBytes([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("WS_XML_BUFFER *")] IntPtr xmlBuffer, [NativeTypeName("const WS_XML_WRITER_ENCODING *")] WS_XML_WRITER_ENCODING* encoding, [NativeTypeName("const WS_XML_WRITER_PROPERTY *")] WS_XML_WRITER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_HEAP *")] IntPtr heap, void** bytes, [NativeTypeName("ULONG *")] uint* byteCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadXmlBufferFromBytes([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("const WS_XML_READER_ENCODING *")] WS_XML_READER_ENCODING* encoding, [NativeTypeName("const WS_XML_READER_PROPERTY *")] WS_XML_READER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("const void *")] void* bytes, [NativeTypeName("ULONG")] uint byteCount, [NativeTypeName("WS_HEAP *")] IntPtr heap, [NativeTypeName("WS_XML_BUFFER **")] IntPtr* xmlBuffer, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteArray([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, WS_VALUE_TYPE valueType, [NativeTypeName("const void *")] void* array, [NativeTypeName("ULONG")] uint arraySize, [NativeTypeName("ULONG")] uint itemOffset, [NativeTypeName("ULONG")] uint itemCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteQualifiedName([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteChars([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("const WCHAR *")] ushort* chars, [NativeTypeName("ULONG")] uint charCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteCharsUtf8([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("const BYTE *")] byte* bytes, [NativeTypeName("ULONG")] uint byteCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteBytes([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("const void *")] void* bytes, [NativeTypeName("ULONG")] uint byteCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsPushBytes([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("WS_PUSH_BYTES_CALLBACK")] delegate* unmanaged<void*, delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, int>, void*, WS_ASYNC_CONTEXT*, IntPtr, int> callback, void* callbackState, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsPullBytes([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("WS_PULL_BYTES_CALLBACK")] delegate* unmanaged<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, int> callback, void* callbackState, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteEndElement([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteText([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("const WS_XML_TEXT *")] WS_XML_TEXT* text, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteStartCData([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteEndCData([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteNode([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("const WS_XML_NODE *")] WS_XML_NODE* node, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetPrefixFromNamespace([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL required, [NativeTypeName("const WS_XML_STRING **")] WS_XML_STRING** prefix, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetWriterPosition([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, WS_XML_NODE_POSITION* nodePosition, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSetWriterPosition([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("const WS_XML_NODE_POSITION *")] WS_XML_NODE_POSITION* nodePosition, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsMoveWriter([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, WS_MOVE_TO moveTo, BOOL* found, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsTrimXmlWhitespace([NativeTypeName("WCHAR *")] ushort* chars, [NativeTypeName("ULONG")] uint charCount, [NativeTypeName("WCHAR **")] ushort** trimmedChars, [NativeTypeName("ULONG *")] uint* trimmedCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsVerifyXmlNCName([NativeTypeName("const WCHAR *")] ushort* ncNameChars, [NativeTypeName("ULONG")] uint ncNameCharCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsXmlStringEquals([NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* string1, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* string2, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetNamespaceFromPrefix([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, BOOL required, [NativeTypeName("const WS_XML_STRING **")] WS_XML_STRING** ns, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadQualifiedName([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("WS_HEAP *")] IntPtr heap, WS_XML_STRING* prefix, WS_XML_STRING* localName, WS_XML_STRING* ns, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetXmlAttribute([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("WS_HEAP *")] IntPtr heap, [NativeTypeName("WCHAR **")] ushort** valueChars, [NativeTypeName("ULONG *")] uint* valueCharCount, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCopyNode([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsAsyncExecute(WS_ASYNC_STATE* asyncState, [NativeTypeName("WS_ASYNC_FUNCTION")] delegate* unmanaged<int, WS_CALLBACK_MODEL, void*, WS_ASYNC_OPERATION*, WS_ASYNC_CONTEXT*, IntPtr, int> operation, WS_CALLBACK_MODEL callbackModel, void* callbackState, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateChannel(WS_CHANNEL_TYPE channelType, WS_CHANNEL_BINDING channelBinding, [NativeTypeName("const WS_CHANNEL_PROPERTY *")] WS_CHANNEL_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("const WS_SECURITY_DESCRIPTION *")] WS_SECURITY_DESCRIPTION* securityDescription, [NativeTypeName("WS_CHANNEL **")] IntPtr* channel, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsOpenChannel([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("const WS_ENDPOINT_ADDRESS *")] WS_ENDPOINT_ADDRESS* endpointAddress, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSendMessage([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("const WS_MESSAGE_DESCRIPTION *")] WS_MESSAGE_DESCRIPTION* messageDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* bodyValue, [NativeTypeName("ULONG")] uint bodyValueSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReceiveMessage([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("const WS_MESSAGE_DESCRIPTION **")] WS_MESSAGE_DESCRIPTION** messageDescriptions, [NativeTypeName("ULONG")] uint messageDescriptionCount, WS_RECEIVE_OPTION receiveOption, WS_READ_OPTION readBodyOption, [NativeTypeName("WS_HEAP *")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("ULONG *")] uint* index, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsRequestReply([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("WS_MESSAGE *")] IntPtr requestMessage, [NativeTypeName("const WS_MESSAGE_DESCRIPTION *")] WS_MESSAGE_DESCRIPTION* requestMessageDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* requestBodyValue, [NativeTypeName("ULONG")] uint requestBodyValueSize, [NativeTypeName("WS_MESSAGE *")] IntPtr replyMessage, [NativeTypeName("const WS_MESSAGE_DESCRIPTION *")] WS_MESSAGE_DESCRIPTION* replyMessageDescription, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP *")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSendReplyMessage([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("WS_MESSAGE *")] IntPtr replyMessage, [NativeTypeName("const WS_MESSAGE_DESCRIPTION *")] WS_MESSAGE_DESCRIPTION* replyMessageDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* replyBodyValue, [NativeTypeName("ULONG")] uint replyBodyValueSize, [NativeTypeName("WS_MESSAGE *")] IntPtr requestMessage, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSendFaultMessageForError([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("WS_MESSAGE *")] IntPtr replyMessage, [NativeTypeName("WS_ERROR *")] IntPtr faultError, [NativeTypeName("HRESULT")] int faultErrorCode, WS_FAULT_DISCLOSURE faultDisclosure, [NativeTypeName("WS_MESSAGE *")] IntPtr requestMessage, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetChannelProperty([NativeTypeName("WS_CHANNEL *")] IntPtr channel, WS_CHANNEL_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSetChannelProperty([NativeTypeName("WS_CHANNEL *")] IntPtr channel, WS_CHANNEL_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteMessageStart([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteMessageEnd([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadMessageStart([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadMessageEnd([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCloseChannel([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsAbortChannel([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeChannel([NativeTypeName("WS_CHANNEL *")] IntPtr channel);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsResetChannel([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsAbandonMessage([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsShutdownSessionChannel([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetOperationContextProperty([NativeTypeName("const WS_OPERATION_CONTEXT *")] IntPtr context, [NativeTypeName("const WS_OPERATION_CONTEXT_PROPERTY_ID")] WS_OPERATION_CONTEXT_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetDictionary(WS_ENCODING encoding, WS_XML_DICTIONARY** dictionary, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadEndpointAddressExtension([NativeTypeName("WS_XML_READER *")] IntPtr reader, WS_ENDPOINT_ADDRESS* endpointAddress, WS_ENDPOINT_ADDRESS_EXTENSION_TYPE extensionType, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP *")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateError([NativeTypeName("const WS_ERROR_PROPERTY *")] WS_ERROR_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_ERROR **")] IntPtr* error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsAddErrorString([NativeTypeName("WS_ERROR *")] IntPtr error, [NativeTypeName("const WS_STRING *")] WS_STRING* @string);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetErrorString([NativeTypeName("WS_ERROR *")] IntPtr error, [NativeTypeName("ULONG")] uint index, WS_STRING* @string);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCopyError([NativeTypeName("WS_ERROR *")] IntPtr source, [NativeTypeName("WS_ERROR *")] IntPtr destination);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetErrorProperty([NativeTypeName("WS_ERROR *")] IntPtr error, WS_ERROR_PROPERTY_ID id, void* buffer, [NativeTypeName("ULONG")] uint bufferSize);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSetErrorProperty([NativeTypeName("WS_ERROR *")] IntPtr error, WS_ERROR_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsResetError([NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeError([NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetFaultErrorProperty([NativeTypeName("WS_ERROR *")] IntPtr error, WS_FAULT_ERROR_PROPERTY_ID id, void* buffer, [NativeTypeName("ULONG")] uint bufferSize);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSetFaultErrorProperty([NativeTypeName("WS_ERROR *")] IntPtr error, WS_FAULT_ERROR_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateFaultFromError([NativeTypeName("WS_ERROR *")] IntPtr error, [NativeTypeName("HRESULT")] int faultErrorCode, WS_FAULT_DISCLOSURE faultDisclosure, [NativeTypeName("WS_HEAP *")] IntPtr heap, WS_FAULT* fault);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSetFaultErrorDetail([NativeTypeName("WS_ERROR *")] IntPtr error, [NativeTypeName("const WS_FAULT_DETAIL_DESCRIPTION *")] WS_FAULT_DETAIL_DESCRIPTION* faultDetailDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetFaultErrorDetail([NativeTypeName("WS_ERROR *")] IntPtr error, [NativeTypeName("const WS_FAULT_DETAIL_DESCRIPTION *")] WS_FAULT_DETAIL_DESCRIPTION* faultDetailDescription, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP *")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateHeap([NativeTypeName("SIZE_T")] nuint maxSize, [NativeTypeName("SIZE_T")] nuint trimSize, [NativeTypeName("const WS_HEAP_PROPERTY *")] WS_HEAP_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_HEAP **")] IntPtr* heap, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsAlloc([NativeTypeName("WS_HEAP *")] IntPtr heap, [NativeTypeName("SIZE_T")] nuint size, void** ptr, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetHeapProperty([NativeTypeName("WS_HEAP *")] IntPtr heap, WS_HEAP_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsResetHeap([NativeTypeName("WS_HEAP *")] IntPtr heap, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeHeap([NativeTypeName("WS_HEAP *")] IntPtr heap);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateListener(WS_CHANNEL_TYPE channelType, WS_CHANNEL_BINDING channelBinding, [NativeTypeName("const WS_LISTENER_PROPERTY *")] WS_LISTENER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("const WS_SECURITY_DESCRIPTION *")] WS_SECURITY_DESCRIPTION* securityDescription, [NativeTypeName("WS_LISTENER **")] IntPtr* listener, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsOpenListener([NativeTypeName("WS_LISTENER *")] IntPtr listener, [NativeTypeName("const WS_STRING *")] WS_STRING* url, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsAcceptChannel([NativeTypeName("WS_LISTENER *")] IntPtr listener, [NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCloseListener([NativeTypeName("WS_LISTENER *")] IntPtr listener, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsAbortListener([NativeTypeName("WS_LISTENER *")] IntPtr listener, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsResetListener([NativeTypeName("WS_LISTENER *")] IntPtr listener, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeListener([NativeTypeName("WS_LISTENER *")] IntPtr listener);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetListenerProperty([NativeTypeName("WS_LISTENER *")] IntPtr listener, WS_LISTENER_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSetListenerProperty([NativeTypeName("WS_LISTENER *")] IntPtr listener, WS_LISTENER_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateChannelForListener([NativeTypeName("WS_LISTENER *")] IntPtr listener, [NativeTypeName("const WS_CHANNEL_PROPERTY *")] WS_CHANNEL_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_CHANNEL **")] IntPtr* channel, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateMessage(WS_ENVELOPE_VERSION envelopeVersion, WS_ADDRESSING_VERSION addressingVersion, [NativeTypeName("const WS_MESSAGE_PROPERTY *")] WS_MESSAGE_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_MESSAGE **")] IntPtr* message, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateMessageForChannel([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("const WS_MESSAGE_PROPERTY *")] WS_MESSAGE_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_MESSAGE **")] IntPtr* message, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsInitializeMessage([NativeTypeName("WS_MESSAGE *")] IntPtr message, WS_MESSAGE_INITIALIZATION initialization, [NativeTypeName("WS_MESSAGE *")] IntPtr sourceMessage, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsResetMessage([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeMessage([NativeTypeName("WS_MESSAGE *")] IntPtr message);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetHeaderAttributes([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("ULONG *")] uint* headerAttributes, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetHeader([NativeTypeName("WS_MESSAGE *")] IntPtr message, WS_HEADER_TYPE headerType, WS_TYPE valueType, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP *")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetCustomHeader([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* customHeaderDescription, WS_REPEATING_HEADER_OPTION repeatingOption, [NativeTypeName("ULONG")] uint headerIndex, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP *")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("ULONG *")] uint* headerAttributes, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsRemoveHeader([NativeTypeName("WS_MESSAGE *")] IntPtr message, WS_HEADER_TYPE headerType, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSetHeader([NativeTypeName("WS_MESSAGE *")] IntPtr message, WS_HEADER_TYPE headerType, WS_TYPE valueType, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsRemoveCustomHeader([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerNs, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsAddCustomHeader([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* headerDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("ULONG")] uint headerAttributes, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsAddMappedHeader([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerName, WS_TYPE valueType, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsRemoveMappedHeader([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerName, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetMappedHeader([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerName, WS_REPEATING_HEADER_OPTION repeatingOption, [NativeTypeName("ULONG")] uint headerIndex, WS_TYPE valueType, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP *")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteBody([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* bodyDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadBody([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* bodyDescription, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP *")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteEnvelopeStart([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("WS_MESSAGE_DONE_CALLBACK")] delegate* unmanaged<void*, void> doneCallback, void* doneCallbackState, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteEnvelopeEnd([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadEnvelopeStart([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("WS_MESSAGE_DONE_CALLBACK")] delegate* unmanaged<void*, void> doneCallback, void* doneCallbackState, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadEnvelopeEnd([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetMessageProperty([NativeTypeName("WS_MESSAGE *")] IntPtr message, WS_MESSAGE_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsSetMessageProperty([NativeTypeName("WS_MESSAGE *")] IntPtr message, WS_MESSAGE_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsAddressMessage([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("const WS_ENDPOINT_ADDRESS *")] WS_ENDPOINT_ADDRESS* address, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCheckMustUnderstandHeaders([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsMarkHeaderAsUnderstood([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("const WS_XML_NODE_POSITION *")] WS_XML_NODE_POSITION* headerPosition, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsFillBody([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("ULONG")] uint minSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsFlushBody([NativeTypeName("WS_MESSAGE *")] IntPtr message, [NativeTypeName("ULONG")] uint minSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsRequestSecurityToken([NativeTypeName("WS_CHANNEL *")] IntPtr channel, [NativeTypeName("const WS_REQUEST_SECURITY_TOKEN_PROPERTY *")] WS_REQUEST_SECURITY_TOKEN_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_SECURITY_TOKEN **")] IntPtr* token, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetSecurityTokenProperty([NativeTypeName("WS_SECURITY_TOKEN *")] IntPtr securityToken, WS_SECURITY_TOKEN_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_HEAP *")] IntPtr heap, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateXmlSecurityToken([NativeTypeName("WS_XML_BUFFER *")] IntPtr tokenXml, WS_SECURITY_KEY_HANDLE* tokenKey, [NativeTypeName("const WS_XML_SECURITY_TOKEN_PROPERTY *")] WS_XML_SECURITY_TOKEN_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_SECURITY_TOKEN **")] IntPtr* token, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeSecurityToken([NativeTypeName("WS_SECURITY_TOKEN *")] IntPtr token);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsRevokeSecurityContext([NativeTypeName("WS_SECURITY_CONTEXT *")] IntPtr securityContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetSecurityContextProperty([NativeTypeName("WS_SECURITY_CONTEXT *")] IntPtr securityContext, WS_SECURITY_CONTEXT_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadElement([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* elementDescription, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP *")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadAttribute([NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("const WS_ATTRIBUTE_DESCRIPTION *")] WS_ATTRIBUTE_DESCRIPTION* attributeDescription, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP *")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadType([NativeTypeName("WS_XML_READER *")] IntPtr reader, WS_TYPE_MAPPING typeMapping, WS_TYPE type, [NativeTypeName("const void *")] void* typeDescription, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP *")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteElement([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* elementDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteAttribute([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, [NativeTypeName("const WS_ATTRIBUTE_DESCRIPTION *")] WS_ATTRIBUTE_DESCRIPTION* attributeDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsWriteType([NativeTypeName("WS_XML_WRITER *")] IntPtr writer, WS_TYPE_MAPPING typeMapping, WS_TYPE type, [NativeTypeName("const void *")] void* typeDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsRegisterOperationForCancel([NativeTypeName("const WS_OPERATION_CONTEXT *")] IntPtr context, [NativeTypeName("WS_OPERATION_CANCEL_CALLBACK")] delegate* unmanaged<WS_SERVICE_CANCEL_REASON, void*, void> cancelCallback, [NativeTypeName("WS_OPERATION_FREE_STATE_CALLBACK")] delegate* unmanaged<void*, void> freestateCallback, void* userState, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetServiceHostProperty([NativeTypeName("WS_SERVICE_HOST *")] IntPtr serviceHost, [NativeTypeName("const WS_SERVICE_PROPERTY_ID")] WS_SERVICE_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateServiceHost([NativeTypeName("const WS_SERVICE_ENDPOINT **")] WS_SERVICE_ENDPOINT** endpoints, [NativeTypeName("const USHORT")] ushort endpointCount, [NativeTypeName("const WS_SERVICE_PROPERTY *")] WS_SERVICE_PROPERTY* serviceProperties, [NativeTypeName("ULONG")] uint servicePropertyCount, [NativeTypeName("WS_SERVICE_HOST **")] IntPtr* serviceHost, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsOpenServiceHost([NativeTypeName("WS_SERVICE_HOST *")] IntPtr serviceHost, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCloseServiceHost([NativeTypeName("WS_SERVICE_HOST *")] IntPtr serviceHost, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsAbortServiceHost([NativeTypeName("WS_SERVICE_HOST *")] IntPtr serviceHost, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeServiceHost([NativeTypeName("WS_SERVICE_HOST *")] IntPtr serviceHost);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsResetServiceHost([NativeTypeName("WS_SERVICE_HOST *")] IntPtr serviceHost, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetServiceProxyProperty([NativeTypeName("WS_SERVICE_PROXY *")] IntPtr serviceProxy, [NativeTypeName("const WS_PROXY_PROPERTY_ID")] WS_PROXY_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateServiceProxy([NativeTypeName("const WS_CHANNEL_TYPE")] WS_CHANNEL_TYPE channelType, [NativeTypeName("const WS_CHANNEL_BINDING")] WS_CHANNEL_BINDING channelBinding, [NativeTypeName("const WS_SECURITY_DESCRIPTION *")] WS_SECURITY_DESCRIPTION* securityDescription, [NativeTypeName("const WS_PROXY_PROPERTY *")] WS_PROXY_PROPERTY* properties, [NativeTypeName("const ULONG")] uint propertyCount, [NativeTypeName("const WS_CHANNEL_PROPERTY *")] WS_CHANNEL_PROPERTY* channelProperties, [NativeTypeName("const ULONG")] uint channelPropertyCount, [NativeTypeName("WS_SERVICE_PROXY **")] IntPtr* serviceProxy, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsOpenServiceProxy([NativeTypeName("WS_SERVICE_PROXY *")] IntPtr serviceProxy, [NativeTypeName("const WS_ENDPOINT_ADDRESS *")] WS_ENDPOINT_ADDRESS* address, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCloseServiceProxy([NativeTypeName("WS_SERVICE_PROXY *")] IntPtr serviceProxy, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsAbortServiceProxy([NativeTypeName("WS_SERVICE_PROXY *")] IntPtr serviceProxy, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeServiceProxy([NativeTypeName("WS_SERVICE_PROXY *")] IntPtr serviceProxy);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsResetServiceProxy([NativeTypeName("WS_SERVICE_PROXY *")] IntPtr serviceProxy, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsAbandonCall([NativeTypeName("WS_SERVICE_PROXY *")] IntPtr serviceProxy, [NativeTypeName("ULONG")] uint callId, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCall([NativeTypeName("WS_SERVICE_PROXY *")] IntPtr serviceProxy, [NativeTypeName("const WS_OPERATION_DESCRIPTION *")] WS_OPERATION_DESCRIPTION* operation, [NativeTypeName("const void **")] void** arguments, [NativeTypeName("WS_HEAP *")] IntPtr heap, [NativeTypeName("const WS_CALL_PROPERTY *")] WS_CALL_PROPERTY* callProperties, [NativeTypeName("const ULONG")] uint callPropertyCount, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsDecodeUrl([NativeTypeName("const WS_STRING *")] WS_STRING* url, [NativeTypeName("ULONG")] uint flags, [NativeTypeName("WS_HEAP *")] IntPtr heap, WS_URL** outUrl, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsEncodeUrl([NativeTypeName("const WS_URL *")] WS_URL* url, [NativeTypeName("ULONG")] uint flags, [NativeTypeName("WS_HEAP *")] IntPtr heap, WS_STRING* outUrl, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCombineUrl([NativeTypeName("const WS_STRING *")] WS_STRING* baseUrl, [NativeTypeName("const WS_STRING *")] WS_STRING* referenceUrl, [NativeTypeName("ULONG")] uint flags, [NativeTypeName("WS_HEAP *")] IntPtr heap, WS_STRING* resultUrl, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsDateTimeToFileTime([NativeTypeName("const WS_DATETIME *")] WS_DATETIME* dateTime, FILETIME* fileTime, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsFileTimeToDateTime([NativeTypeName("const FILETIME *")] FILETIME* fileTime, WS_DATETIME* dateTime, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateMetadata([NativeTypeName("const WS_METADATA_PROPERTY *")] WS_METADATA_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_METADATA **")] IntPtr* metadata, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsReadMetadata([NativeTypeName("WS_METADATA *")] IntPtr metadata, [NativeTypeName("WS_XML_READER *")] IntPtr reader, [NativeTypeName("const WS_STRING *")] WS_STRING* url, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeMetadata([NativeTypeName("WS_METADATA *")] IntPtr metadata);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsResetMetadata([NativeTypeName("WS_METADATA *")] IntPtr metadata, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetMetadataProperty([NativeTypeName("WS_METADATA *")] IntPtr metadata, WS_METADATA_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetMissingMetadataDocumentAddress([NativeTypeName("WS_METADATA *")] IntPtr metadata, WS_ENDPOINT_ADDRESS** address, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetMetadataEndpoints([NativeTypeName("WS_METADATA *")] IntPtr metadata, WS_METADATA_ENDPOINTS* endpoints, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsMatchPolicyAlternative([NativeTypeName("WS_POLICY *")] IntPtr policy, [NativeTypeName("ULONG")] uint alternativeIndex, WS_POLICY_CONSTRAINTS* policyConstraints, BOOL matchRequired, [NativeTypeName("WS_HEAP *")] IntPtr heap, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetPolicyProperty([NativeTypeName("WS_POLICY *")] IntPtr policy, WS_POLICY_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsGetPolicyAlternativeCount([NativeTypeName("WS_POLICY *")] IntPtr policy, [NativeTypeName("ULONG *")] uint* count, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateServiceProxyFromTemplate(WS_CHANNEL_TYPE channelType, [NativeTypeName("const WS_PROXY_PROPERTY *")] WS_PROXY_PROPERTY* properties, [NativeTypeName("const ULONG")] uint propertyCount, WS_BINDING_TEMPLATE_TYPE templateType, void* templateValue, [NativeTypeName("ULONG")] uint templateSize, [NativeTypeName("const void *")] void* templateDescription, [NativeTypeName("ULONG")] uint templateDescriptionSize, [NativeTypeName("WS_SERVICE_PROXY **")] IntPtr* serviceProxy, [NativeTypeName("WS_ERROR *")] IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WsCreateServiceEndpointFromTemplate(WS_CHANNEL_TYPE channelType, [NativeTypeName("const WS_SERVICE_ENDPOINT_PROPERTY *")] WS_SERVICE_ENDPOINT_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("const WS_STRING *")] WS_STRING* addressUrl, [NativeTypeName("const WS_SERVICE_CONTRACT *")] WS_SERVICE_CONTRACT* contract, [NativeTypeName("WS_SERVICE_SECURITY_CALLBACK")] delegate* unmanaged<IntPtr, BOOL*, IntPtr, int> authorizationCallback, [NativeTypeName("WS_HEAP *")] IntPtr heap, WS_BINDING_TEMPLATE_TYPE templateType, void* templateValue, [NativeTypeName("ULONG")] uint templateSize, [NativeTypeName("const void *")] void* templateDescription, [NativeTypeName("ULONG")] uint templateDescriptionSize, WS_SERVICE_ENDPOINT** serviceEndpoint, [NativeTypeName("WS_ERROR *")] IntPtr error);
    }
}
