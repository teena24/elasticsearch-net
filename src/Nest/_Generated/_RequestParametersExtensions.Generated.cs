
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elasticsearch.Net;
using Nest.Resolvers;

///This file contains all the typed request parameters that are generated of the client spec.
///This file is automatically generated from https://github.com/elasticsearch/elasticsearch-rest-api-spec
///Generated of commit 

namespace Nest
{
	public static class RequestPameterExtensions
	{
		
		///<summary>Default comma-separated list of fields to return in the response for updates</summary>
		internal static BulkRequestParameters _Fields<T>(this BulkRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(FieldName)e));
		
		///<summary>A comma-separated list of fields to return in the output</summary>
		internal static CatFielddataRequestParameters _Fields<T>(this CatFielddataRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(FieldName)e));
		
		///<summary>A comma-separated list of fields to return in the response</summary>
		internal static ExplainRequestParameters _Fields<T>(this ExplainRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(FieldName)e));
		
		///<summary>A list of fields to exclude from the returned _source field</summary>
		internal static ExplainRequestParameters _SourceExclude<T>(this ExplainRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_exclude) where T : class =>
			qs.AddQueryString("_source_exclude", source_exclude.Select(e=>(FieldName)e));
		
		///<summary>A list of fields to extract and return from the _source field</summary>
		internal static ExplainRequestParameters _SourceInclude<T>(this ExplainRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_include) where T : class =>
			qs.AddQueryString("_source_include", source_include.Select(e=>(FieldName)e));
		
		///<summary>A comma-separated list of fields for to get field statistics for (min value, max value, and more)</summary>
		internal static FieldStatsRequestParameters _Fields<T>(this FieldStatsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(FieldName)e));
		
		///<summary>A comma-separated list of fields to return in the response</summary>
		internal static GetRequestParameters _Fields<T>(this GetRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(FieldName)e));
		
		///<summary>A list of fields to exclude from the returned _source field</summary>
		internal static GetRequestParameters _SourceExclude<T>(this GetRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_exclude) where T : class =>
			qs.AddQueryString("_source_exclude", source_exclude.Select(e=>(FieldName)e));
		
		///<summary>A list of fields to extract and return from the _source field</summary>
		internal static GetRequestParameters _SourceInclude<T>(this GetRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_include) where T : class =>
			qs.AddQueryString("_source_include", source_include.Select(e=>(FieldName)e));
		
		///<summary>A list of fields to exclude from the returned _source field</summary>
		internal static SourceRequestParameters _SourceExclude<T>(this SourceRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_exclude) where T : class =>
			qs.AddQueryString("_source_exclude", source_exclude.Select(e=>(FieldName)e));
		
		///<summary>A list of fields to extract and return from the _source field</summary>
		internal static SourceRequestParameters _SourceInclude<T>(this SourceRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_include) where T : class =>
			qs.AddQueryString("_source_include", source_include.Select(e=>(FieldName)e));
		
		///<summary>Use the analyzer configured for this field (instead of passing the analyzer name)</summary>
		internal static AnalyzeRequestParameters _Field<T>(this AnalyzeRequestParameters qs, Expression<Func<T, object>> field) where T : class =>
			qs.AddQueryString("field", (FieldName)field);
		
		///<summary>A comma-separated list of fields to clear when using the `field_data` parameter (default: all)</summary>
		internal static ClearCacheRequestParameters _Fields<T>(this ClearCacheRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(FieldName)e));
		
		///<summary>A comma-separated list of fields for `fielddata` and `suggest` index metric (supports wildcards)</summary>
		internal static IndicesStatsRequestParameters _CompletionFields<T>(this IndicesStatsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  completion_fields) where T : class =>
			qs.AddQueryString("completion_fields", completion_fields.Select(e=>(FieldName)e));
		
		///<summary>A comma-separated list of fields for `fielddata` index metric (supports wildcards)</summary>
		internal static IndicesStatsRequestParameters _FielddataFields<T>(this IndicesStatsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fielddata_fields) where T : class =>
			qs.AddQueryString("fielddata_fields", fielddata_fields.Select(e=>(FieldName)e));
		
		///<summary>A comma-separated list of fields for `fielddata` and `completion` index metric (supports wildcards)</summary>
		internal static IndicesStatsRequestParameters _Fields<T>(this IndicesStatsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(FieldName)e));
		
		///<summary>A comma-separated list of fields to return in the response</summary>
		internal static MultiGetRequestParameters _Fields<T>(this MultiGetRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(FieldName)e));
		
		///<summary>A list of fields to exclude from the returned _source field</summary>
		internal static MultiGetRequestParameters _SourceExclude<T>(this MultiGetRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_exclude) where T : class =>
			qs.AddQueryString("_source_exclude", source_exclude.Select(e=>(FieldName)e));
		
		///<summary>A list of fields to extract and return from the _source field</summary>
		internal static MultiGetRequestParameters _SourceInclude<T>(this MultiGetRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  source_include) where T : class =>
			qs.AddQueryString("_source_include", source_include.Select(e=>(FieldName)e));
		
		///<summary>A comma-separated list of fields to return. Applies to all returned documents unless otherwise specified in body &quot;params&quot; or &quot;docs&quot;.</summary>
		internal static MultiTermVectorsRequestParameters _Fields<T>(this MultiTermVectorsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(FieldName)e));
		
		///<summary>A comma-separated list of fields for `fielddata` and `suggest` index metric (supports wildcards)</summary>
		internal static NodesStatsRequestParameters _CompletionFields<T>(this NodesStatsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  completion_fields) where T : class =>
			qs.AddQueryString("completion_fields", completion_fields.Select(e=>(FieldName)e));
		
		///<summary>A comma-separated list of fields for `fielddata` index metric (supports wildcards)</summary>
		internal static NodesStatsRequestParameters _FielddataFields<T>(this NodesStatsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fielddata_fields) where T : class =>
			qs.AddQueryString("fielddata_fields", fielddata_fields.Select(e=>(FieldName)e));
		
		///<summary>A comma-separated list of fields for `fielddata` and `completion` index metric (supports wildcards)</summary>
		internal static NodesStatsRequestParameters _Fields<T>(this NodesStatsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(FieldName)e));
		
		///<summary>Specify which field to use for suggestions</summary>
		internal static SearchRequestParameters _SuggestField<T>(this SearchRequestParameters qs, Expression<Func<T, object>> suggest_field) where T : class =>
			qs.AddQueryString("suggest_field", (FieldName)suggest_field);
		
		///<summary>A comma-separated list of fields to return.</summary>
		internal static TermVectorsRequestParameters _Fields<T>(this TermVectorsRequestParameters qs, IEnumerable<Expression<Func<T, object>>>  fields) where T : class =>
			qs.AddQueryString("fields", fields.Select(e=>(FieldName)e));
	}
}
 